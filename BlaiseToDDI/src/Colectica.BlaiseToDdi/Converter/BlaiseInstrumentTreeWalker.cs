using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Colectica.BlaiseToDdi.Model;
using Colectica.BlaiseToDdi.Utility;

namespace Colectica.BlaiseToDdi.Converter
{
	public class BlaiseInstrumentTreeWalker
	{
		#region Fields

		CommonTree tree;
		CommonTokenStream tokens;
		BlaiseImportOptions options;

		List<XElement> categorySchemes = new List<XElement>();
		List<XElement> codeSchemes = new List<XElement>();

		Dictionary<Block, Dictionary<string, XElement>> questionsByBlock = new Dictionary<Block, Dictionary<string, XElement>>();
		Dictionary<ITree, XElement> foundDomains = new Dictionary<ITree, XElement>();
		Dictionary<string, Block> blocks = new Dictionary<string, Block>();

		int computationCount = 1;
		int assignmentCount = 1;

		#endregion

		#region Properties

		private Dictionary<XElement, ITree> activityToTree = new Dictionary<XElement, ITree>();
		public Dictionary<XElement, ITree> ActivityToTree
		{
			get { return activityToTree; }
			set { activityToTree = value; }
		}

		public XDocument Result { get; set; }

		public XElement DdiInstance { get; set; }
		public XElement Instrument { get; set; }
		public XElement ResourcePackage { get; set; }
		public XElement ControlConstructScheme { get; set; }

		public string AgencyId { get; set; }
		public string MainLanguage { get; set; }

		#endregion

		#region Constructor

		public BlaiseInstrumentTreeWalker(CommonTree tree, CommonTokenStream tokens, BlaiseImportOptions options, string agencyId, string mainLanguage)
		{
			this.tree = tree;
			this.tokens = tokens;
			this.options = options;
			this.MainLanguage = mainLanguage;
			this.AgencyId = agencyId;

			Result = new XDocument();

			DdiInstance = Ddi.Element(Ddi.DdiInstance);
			Ddi.AddNamespaces(DdiInstance);
			
			ResourcePackage = Ddi.Element(Ddi.ResourcePackage);

			// Required in DDI 3.1
			var purpose = Ddi.Element(Ddi.Purpose);
			purpose.Add(Ddi.XmlLang(MainLanguage));
			purpose.Add(new XElement(Ddi.Content, "Not Specified"));
			ResourcePackage.Add(purpose);

			Instrument = Ddi.Element(Ddi.Instrument);
			ControlConstructScheme = Ddi.Element(Ddi.ControlConstructScheme);
			
			XElement groupDataCollection = Ddi.Element(Ddi.GroupDataCollection, false);
			XElement dataCollection = Ddi.Element(Ddi.DataCollection);
			groupDataCollection.Add(dataCollection);
			dataCollection.Add(Instrument);
			ResourcePackage.Add(groupDataCollection);
			ResourcePackage.Add(ControlConstructScheme);
			DdiInstance.Add(ResourcePackage);			
		}

		#endregion

		#region Public Methods

		public void ParseInstrument()
		{
			if (tree.Type != BlaiseParser.DATA_MODEL)
			{
				throw new InvalidOperationException("A DATAMODEL was not found in the instrument");
			}

			ITree label = tree.GetChild(0);
			ITree modelSettings = tree.GetChild(1);

			Block outer = WalkSubModel(tree, null);
			if (outer != null)
			{
				string instrumentName = outer.Title;
				string description = outer.Description;

				var nameElement = new XElement(Ddi.InstrumentName,
					Ddi.XmlLang(MainLanguage),
					instrumentName);
				this.Instrument.AddFirst(nameElement);

				var descElement = new XElement(Ddi.Description,
					Ddi.XmlLang(MainLanguage),
					description);
				nameElement.AddAfterSelf(descElement);
			}

			// Create a QuestionScheme for each BLOCK.
			foreach (var kvpBlock in this.blocks)
			{
				string blockName = kvpBlock.Key;
				Block block = kvpBlock.Value;

				// Create a question scheme that contains all FIELDs.
				if (block.Fields.Count > 0)
				{
					XElement questionScheme = Ddi.Element(Ddi.QuestionScheme);
					questionScheme.Add(new XElement(
						Ddi.QuestionSchemeName, 
						Ddi.XmlLang(MainLanguage), 
						block.Title));

					bool hasQuestions = false;
					foreach (var kvpField in block.Fields)
					{
						Field field = kvpField.Value;

						if (field.Question != null && field.Question.Count > 0)
						{
							XElement question = CreateQuestion(field, block.Title, block);
							questionScheme.Add(question);
							hasQuestions = true;
						}
					}
					
					if (hasQuestions)
					{
						this.ResourcePackage.Add(questionScheme);
					}
				}
			}

			// Create the instrument flow.
			XElement outerConstruct = GetBlockControlConstruct(outer, outer.Title);
			Instrument.Add(Ddi.GetReference(Ddi.ControlConstructReference, outerConstruct));

			foreach (var catScheme in categorySchemes)
			{
				ResourcePackage.Add(catScheme);
			}

			foreach (var codeScheme in codeSchemes)
			{
				ResourcePackage.Add(codeScheme);
			}
		}

		#endregion

		#region Parse helper methods

		private Block WalkSubModel(ITree datamodel, Block scope)
		{
			if (datamodel.ChildCount < 1)
			{
				return null; // TODO maybe warn
			}
			Block block = new Block();
			block.Label = datamodel.GetChild(0);
			blocks[block.Title] = block;

			if (scope != null) // not the top datamodel
			{
				block.Parent = scope;
				scope.AddBlock(block.Title, block);
			}


			ITree submodel = datamodel; // TODO 

			// extract all type information for this submodel
			for (int i = 0; i < submodel.ChildCount; ++i)
			{
				ITree subtype = submodel.GetChild(i);
				if (subtype.Type == BlaiseParser.SUB_TYPE)
				{
					// add all types to this block
					for (int j = 0; j < subtype.ChildCount; ++j)
					{
						ITree typeItem = subtype.GetChild(j);
						if (typeItem.Type == BlaiseParser.TYPE_ITEM)
						{
							if (typeItem.ChildCount == 2 &&
								typeItem.GetChild(1).Type == BlaiseParser.TYPEDEF)
							{
								string typeName = typeItem.GetChild(0).Text;
								block.AddType(typeName, typeItem.GetChild(1));
							}
						}
					}
				}
			}


			// extract all field information for this submodel
			for (int i = 0; i < submodel.ChildCount; ++i)
			{
				ITree fields = submodel.GetChild(i);
				if (fields.Type == BlaiseParser.FIELDS || fields.Type == BlaiseParser.AUXFIELDS
				   || fields.Type == BlaiseParser.SUB_LOCALS)
				{
					// add all fields to this block
					for (int j = 0; j < fields.ChildCount; ++j)
					{
						ITree field = fields.GetChild(j);
						if (field.Type == BlaiseParser.FIELD) // not necessary unless parser changes
						{
							if (field.ChildCount < 2) { continue; }
							ITree idList = field.GetChild(0);
							List<Field> toadd = new List<Field>(idList.ChildCount);
							for (int k = 0; k < idList.ChildCount; ++k)
							{
								Field f = new Field();
								f.Title = idList.GetChild(k).Text;
								toadd.Add(f);
							}

							ITree typedef = null;

							Collection<LanguageString> fieldTexts = new Collection<LanguageString>();
							Collection<LanguageString> fieldDescriptions = new Collection<LanguageString>();
							string tag = null;

							// Do these seperate so we can keep the language ordering
							int langCount = 0;
							for (int k = 0; k < field.ChildCount; ++k)
							{
								ITree fi = field.GetChild(k);
								if (fi.Type == BlaiseParser.FIELD_TEXT)
								{
									ITree lidString = fi.GetChild(0);
									LanguageString ls = new LanguageString(lidString);
									if (string.IsNullOrEmpty(ls.Language) && langCount < options.DefinedLanguagesOrder.Count)
									{
										ls.Language = options.DefinedLanguagesOrder[langCount];
										langCount++;
									}
									fieldTexts.Add(ls);
								}
							}

							langCount = 0;
							for (int k = 0; k < field.ChildCount; ++k)
							{
								ITree fi = field.GetChild(k);
								if (fi.Type == BlaiseParser.FIELD_DESC)
								{
									ITree lidString = fi.GetChild(0);
									LanguageString ls = new LanguageString(lidString);
									if (string.IsNullOrEmpty(ls.Language) && langCount < options.DefinedLanguagesOrder.Count)
									{
										ls.Language = options.DefinedLanguagesOrder[langCount];
										langCount++;
									}
									fieldDescriptions.Add(ls);
								}

								// tack this on here, there is only one of them
								if (fi.Type == BlaiseParser.TYPEDEF)
								{
									typedef = fi;
								}
								else if (fi.Type == BlaiseParser.FIELD_TAG)
								{
									if (fi.ChildCount == 1)
									{
										ITree tagList = fi.GetChild(0);
										for (int ti = 0; ti < tagList.ChildCount; ti++)
										{
											if (ti == 0) { tag = tagList.GetChild(ti).Text; }
											else { tag += "," + tagList.GetChild(ti).Text; }
										}

									}
								}
							}

							foreach (Field f in toadd)
							{
								f.Question = fieldTexts;
								f.Description = fieldDescriptions;
								f.Typedef = typedef;
								f.Parent = block;
								f.Tag = tag;
								block.AddField(f.Title, f);
							}
						}
					}
				}
			}

			// extract all child block information for this submodel
			for (int i = 0; i < submodel.ChildCount; ++i)
			{
				ITree child = submodel.GetChild(i);
				if (child.Type == BlaiseParser.BLOCK || child.Type == BlaiseParser.TABLE || child.Type == BlaiseParser.PROCEDURE)
				{
					WalkSubModel(child, block);
				}
			}

			// extract rules for this submodel
			for (int i = 0; i < submodel.ChildCount; ++i)
			{
				ITree child = submodel.GetChild(i);
				if (child.Type == BlaiseParser.RULES)
				{
					block.Rules = child;
				}
			}

			return block;
		}

		private XElement GetCCFromRule(ITree rule, Block scope, string prefix)
		{
			//string ruleName = tokens.ToString(rule.TokenStartIndex, rule.TokenStopIndex);
			XElement result = null;

			if (rule.Type == BlaiseParser.VARIABLE) 
			{
				Field field = scope.GetBlaiseField(rule.GetChild(0).Text);
				if (field == null) 
				{ 
					result = GetActionForTree(rule); 
				} //TODO is this a function?
				else
				{
					result = GetCCFromVariable(field, rule, scope, prefix);
				}
			}

			else if(rule.Type == BlaiseParser.ASK || rule.Type == BlaiseParser.SHOW)
			{
				if (rule.ChildCount == 0) { return null; } // TODO skip

				ITree variable = rule.GetChild(0);
				
				Field field = scope.GetBlaiseField(variable.GetChild(0).Text);
				if (field == null)
				{ 
					result = GetActionForTree(rule); 
				} //TODO would this ever happen?
				else
				{
					result = GetCCFromVariable(field, variable, scope, prefix);
				}
			}
			else if (rule.Type == BlaiseParser.ASSIGN)
			{
				XElement cc = GetAssignment(rule, scope, prefix);
				result = cc;
			}

			else if (rule.Type == BlaiseParser.IF)
			{
				XElement cc = GetIf(rule, scope, prefix);
				result = cc;
			}

			else if (rule.Type == BlaiseParser.WHILEDO)
			{
				XElement cc = GetWhile(rule, scope, prefix);
				result = cc;
					
			}
			else if (rule.Type == BlaiseParser.FORDO)
			{
				XElement cc = GetFor(rule, scope, prefix);
				result = cc;
			}
			else
			{
				result = GetActionForTree(rule); // catchall
			}

			if (result == null)
			{
				return null; // shouldn't happen
			}

			activityToTree.Add(result, rule);
			return result;
		}

		private XElement GetCCFromVariable(Field field, ITree variable, Block scope, string prefix)
		{
			ITree typeDefChild = field.Typedef.GetChild(0);

			// See if this is a block?
			if (typeDefChild.Type == BlaiseParser.TYPE_USERDEF ||
				typeDefChild.Type == BlaiseParser.TYPE_ARRAY)
			{
				string userdef = null;
				if (typeDefChild.Type == BlaiseParser.TYPE_USERDEF)
				{
					userdef = typeDefChild.GetChild(0).Text;
				}
				else if (typeDefChild.Type == BlaiseParser.TYPE_ARRAY && typeDefChild.ChildCount == 2)
				{
					ITree typeDef = typeDefChild.GetChild(1);
					if (typeDef.Type == BlaiseParser.TYPE_USERDEF)
					{
						userdef = typeDef.GetChild(0).Text;
					}
				}

				// TODO look for selector and then include question or block
				if (userdef != null && blocks.ContainsKey(userdef))
				{
					// We are asking a Block
					//CustomSequenceActivity seq = new CustomSequenceActivity();

					// First add a statement with the text of this node.
					//if (field.Question != null)
					//{
					//   seq.Activities.Add(GetStatement(field.Question, prefix, scope));
					//}

					// Now add everything in the block.
					//seq.Activities.Add(GetControlConstruct(blocks[userdef], userdef));
					return GetBlockControlConstruct(blocks[userdef], userdef);
				}
			}

			//TODO this doesn't account for selectors, but that may only be for blocks
			string questionName = variable.GetChild(0).Text;
			XElement questionReference = GetQuestionReference(scope, GetQuestionName(questionName, prefix));

			if (questionReference != null)
			{
				XElement questionActivity = Ddi.Element(Ddi.QuestionConstruct);
				questionActivity.Add(questionReference);
				return questionActivity;
			}

			//TODO could not find the field?
			return GetActionForTree(variable);
		}

		private XElement GetQuestionReference(Block scope, string questionName)
		{
			if (!this.questionsByBlock.ContainsKey(scope))
			{
				return null;
			}

			var questions = this.questionsByBlock[scope];
			if (!questions.ContainsKey(questionName))
			{
				return null;
			}

			XElement question = questions[questionName];
			if (question == null) return null;

			XElement qref = Ddi.GetReference(Ddi.QuestionReference, question);

			return qref;
		}

		private XElement GetActionForTree(ITree tree)
		{
			// The source code isn't always accurate.
			XElement action = Ddi.Element(Ddi.ComputationItem);
			action.Add(new XElement(
				Ddi.ConstructName, 
				Ddi.XmlLang(MainLanguage), 
				string.Format("Computation{0}", this.computationCount)));
			this.computationCount++;

			string codeStr = tree.ToOriginalCode(tokens);

			action.Add(
				new XElement(
					Ddi.Code,
					new XElement(Ddi.SourceCode,
						new XAttribute("programmingLanguage", "Blaise"),
						codeStr)));

			return action;
		}

		private Dictionary<Block, XElement> processedBlocks = new Dictionary<Block, XElement>();
		private XElement GetBlockControlConstruct(Block block, string prefix)
		{
			if (prefix == null) { prefix = ""; }
			if (processedBlocks.ContainsKey(block))
			{
				return processedBlocks[block];
			}

			// Process rules.
			XElement seq = Ddi.Element(Ddi.Sequence);
			seq.Add(new XElement(
				Ddi.ConstructName,
				Ddi.XmlLang(MainLanguage),
				block.Title));
			
			if (block.Rules != null)
			{
				for (int i = 0; i < block.Rules.ChildCount; i++)
				{
					ITree rule = block.Rules.GetChild(i);
					XElement cc = GetCCFromRule(rule, block, prefix);
					if (cc != null)
					{
						ControlConstructScheme.Add(cc);

						seq.Add(Ddi.GetReference(Ddi.ControlConstructReference, cc));
					}
				}
			}
			return seq;
		}

		private XElement GetStatement(string text, string prefix, Block scope)
		{
			XElement statement = Ddi.Element(Ddi.Statement);
			
			string statementText = GetQuestionText(text, scope);

			statement.Add(new XElement(Ddi.StatementText, statementText));

			ControlConstructScheme.Add(statement);		

			return statement;
		}

		private XElement GetWhile(ITree whileTree, Block scope, string prefix)
		{
			if (whileTree.ChildCount == 0)
			{
				return null;
			}

			// WhileCondition
			string condition = whileTree.GetChild(0).GetChild(0).ToOriginalCode(tokens);
			XElement whileActivity = Ddi.Element(Ddi.While);
			whileActivity.Add(Ddi.GetCode(Ddi.WhileCondition, condition));
			XElement whileSeq = Ddi.Element(Ddi.Sequence);
			ControlConstructScheme.Add(whileSeq);
			whileActivity.Add(whileSeq);

			// WhileConstructReference
			for (int i = 1; i < whileTree.ChildCount; ++i)
			{
				XElement child = GetCCFromRule(whileTree.GetChild(i), scope, prefix);
				ControlConstructScheme.Add(child);
				whileSeq.Add(Ddi.GetReference(Ddi.ControlConstructReference, child));
			}
			
			return whileActivity;
		}

		private XElement GetFor(ITree forTree, Block scope, string prefix)
		{
			if (forTree.ChildCount < 4)
			{
				return null;
			}

			string initialValue = forTree.GetChild(0).ToOriginalCode(tokens);
			string condition = forTree.GetChild(1).ToOriginalCode(tokens);
			string stepValue = forTree.GetChild(2).ToOriginalCode(tokens);

			XElement loop = Ddi.Element(Ddi.Loop);
			loop.Add(new XElement(Ddi.InitialValue, new XElement(Ddi.SourceCode, new XAttribute("programmingLanguage", "Blaise"), initialValue)));
			loop.Add(new XElement(Ddi.LoopWhile, new XElement(Ddi.SourceCode, new XAttribute("programmingLanguage", "Blaise"), condition)));
			loop.Add(new XElement(Ddi.StepValue, new XElement(Ddi.SourceCode, new XAttribute("programmingLanguage", "Blaise"), stepValue)));

			XElement loopSeq = Ddi.Element(Ddi.Sequence);
			ControlConstructScheme.Add(loopSeq);
			loop.Add(loopSeq);

			for (int i = 3; i < forTree.ChildCount; ++i)
			{
				XElement child = GetCCFromRule(forTree.GetChild(i), scope, prefix);
				ControlConstructScheme.Add(child);
				loopSeq.Add(Ddi.GetReference(Ddi.ControlConstructReference, child));
			}

			return loop;
		}

		private XElement GetIf(ITree ifTree, Block scope, string prefix)
		{
			XElement ifElement = Ddi.Element(Ddi.IfThenElse);

			XElement ifCondition = Ddi.Element(Ddi.IfCondition, false);
			string ifConditionStr = ifTree.GetChild(0).ToOriginalCode(tokens);
			ifElement.Add(Ddi.GetCode(Ddi.IfCondition, ifConditionStr));

			XElement thenSeq = Ddi.Element(Ddi.Sequence);
			ControlConstructScheme.Add(thenSeq);

			XElement thenRef = Ddi.GetReference(Ddi.ThenConstructReference, thenSeq);
			ifElement.Add(thenRef);

			for (int i = 1; i < ifTree.ChildCount; i++)
			{
			    ITree child = ifTree.GetChild(i);
			    if (child.Type == BlaiseParser.THEN)
			    {
			        for (int j = 0; j < child.ChildCount; ++j)
			        {
			            XElement thenChild = GetCCFromRule(child.GetChild(j), scope, prefix);
			            if (thenChild != null)
			            {
							ControlConstructScheme.Add(thenChild);
			                thenSeq.Add(Ddi.GetReference(Ddi.ControlConstructReference, thenChild));
			            }
			        }
			    }
				else if (child.Type == BlaiseParser.ELSEIF)
				{
					XElement elseIf = Ddi.Element(Ddi.ElseIf, false);

					if (child.ChildCount >= 2)
					{
						string elseConditionStr = child.GetChild(0).ToOriginalCode(tokens);
						elseIf.Add(new XElement(Ddi.GetCode(Ddi.IfCondition, elseConditionStr)));

						XElement elseSeq = Ddi.Element(Ddi.Sequence);
						ControlConstructScheme.Add(elseSeq);

						XElement elseRef = Ddi.GetReference(Ddi.ThenConstructReference, elseSeq);
						elseIf.Add(elseRef);

						ITree thenTree = child.GetChild(1);
						for (int k = 0; k < thenTree.ChildCount; k++)
						{
							XElement elseChild = GetCCFromRule(thenTree.GetChild(k), scope, prefix);
							if (elseChild != null)
							{
								ControlConstructScheme.Add(elseChild);
								elseSeq.Add(Ddi.GetReference(Ddi.ControlConstructReference, elseChild));
							}
						}
					}

					ifElement.Add(elseIf);
				}
				else if (child.Type == BlaiseParser.ELSE)
				{
					XElement elseSeq = Ddi.Element(Ddi.Sequence);
					ControlConstructScheme.Add(elseSeq);

					XElement elseRef = Ddi.GetReference(Ddi.ElseConstructReference, elseSeq);
					ifElement.Add(elseRef);

					for (int k = 0; k < child.ChildCount; k++)
					{
						XElement elseChild = GetCCFromRule(child.GetChild(k), scope, prefix);
						if (elseChild != null)
						{
							ControlConstructScheme.Add(elseChild);
							elseSeq.Add(Ddi.GetReference(Ddi.ControlConstructReference, elseChild));
						}
					}
				}
			    else
			    {
			        //TODO parser error
			        Console.WriteLine("Parser error in ifthenelse");
			    }
			}
			
			return ifElement;
		}

		private XElement GetAssignment(ITree aTree, Block scope, string prefix)
		{
			XElement action = Ddi.Element(Ddi.ComputationItem);
			action.Add(new XElement(
				Ddi.ConstructName,
				Ddi.XmlLang(MainLanguage),
				string.Format("Computation{0}", this.computationCount)));
			
			string assignmentStr = aTree.ToOriginalCode(tokens);

			action.Add(
				new XElement(
					Ddi.Code,
					new XElement(Ddi.SourceCode,
						new XAttribute("programmingLanguage", "Blaise"),
						assignmentStr)));

			this.computationCount++;
			return action;
		}

		private XElement CreateQuestion(Field field, string prefix, Block scope)
		{
			XElement question = Ddi.Element(Ddi.QuestionItem);

			string name = GetQuestionName(field.Title, prefix);
			question.Add(new XElement(Ddi.QuestionItemName, Ddi.XmlLang(MainLanguage), name));
						
			// Add the question to our cache.
			if (!this.questionsByBlock.ContainsKey(scope))
			{
				this.questionsByBlock.Add(scope, new Dictionary<string, XElement>());
			}
			var questionsByName = this.questionsByBlock[scope];

			questionsByName.Add(name, question);
			
			if (!string.IsNullOrEmpty(field.Tag))
			{
			    question.Add(new XElement(Ddi.QuestionIntent, field.Tag));
			}

			// Set the question text.
			foreach (LanguageString ls in field.Question)
			{
				AssignQuestionStrings(question, ls, scope);
			}

			foreach (LanguageString ls in field.Description)
			{
				AssignQuestionStrings(question, ls, scope);
			}

			question.Add(ParseTypedefTree(field.Typedef, scope));

			return question;			
		}

		private XElement ParseTypedefTree(ITree tree, Block scope)
		{
			if (foundDomains.ContainsKey(tree))
			{
				return foundDomains[tree];
			}

			if (tree.ChildCount == 0) { return null; }
			ITree tt = tree.GetChild(0);

			XElement domain = null;

			if (tt.Type == BlaiseParser.TYPE_ARRAY)
			{
				ITree realDomain = tt.GetChild(tt.ChildCount - 2); // last child
				return ParseTypedefTree(tt, scope); // array of this type
			}
			else if (tt.Type == BlaiseParser.TYPE_CATEGORY)
			{
				XElement catScheme = Ddi.Element(Ddi.CategoryScheme);
				XElement codeScheme = Ddi.Element(Ddi.CodeScheme);

				this.categorySchemes.Add(catScheme);
				this.codeSchemes.Add(codeScheme);

				domain = Ddi.Element(Ddi.CodeDomain, false);
				domain.Add(Ddi.GetReference(Ddi.CodeSchemeReference, codeScheme));

				// for each child category
				List<string> categoryNames = new List<string>(); // for making up a scheme name
				int codeNumber = 1;

				for (int i = 0; i < tt.ChildCount; ++i)
				{
					int langCount = 0;
					ITree cat = tt.GetChild(i);

					XElement category = Ddi.Element(Ddi.Category);
					XElement code = Ddi.Element(Ddi.LogicalCode, false);
					
					
					code.Add(Ddi.GetReference(Ddi.CategoryReference, category));

					catScheme.Add(category);
					codeScheme.Add(code);
					
					string catName= string.Empty;

					// initialize the category
					if (cat.ChildCount > 0)
					{
						catName = cat.GetChild(0).Text;
						category.Add(new XElement(Ddi.CategoryName, Ddi.XmlLang(MainLanguage), catName));
						category.Add(new XElement(Ddi.Label, Ddi.XmlLang(MainLanguage), catName));
					}

					for (int c = 1; c < cat.ChildCount; ++c)
					{
						ITree test = cat.GetChild(c);

						// set the current code if present
						if (test.Type == BlaiseParser.TYPE_CATEGORY_CODE)
						{
							if (test.ChildCount == 1)
							{
								try
								{
									codeNumber = Int32.Parse(test.GetChild(0).Text);
								}
								catch (Exception)
								{
									//TODO
								}
							}
						}

						//labels for each language
						else if (test.Type == BlaiseParser.LID_STRING)
						{
							LanguageString ls = new LanguageString(test);
							if (string.IsNullOrEmpty(ls.Language) && langCount < options.DefinedLanguagesOrder.Count)
							{
								ls.Language = options.DefinedLanguagesOrder[langCount];
								langCount++;
							}
							BlaiseLanguageMapping mapping = options.GetMapping(ls.Language);
							if (mapping != null)
							{
								category.Add(new XElement(Ddi.Label, Ddi.XmlLang(mapping.Culture), ls.Value));
							}
							else
							{
								category.Add(new XElement(Ddi.Label, Ddi.XmlLang(MainLanguage), ls.Value));
							}
						}

					}

					code.Add(new XElement(Ddi.Value, codeNumber.ToString()));
					codeNumber++;

					/*
					if (cat.ChildCount == 1)
					{
						code.Value = cat.GetChild(0).Text;
						category.ItemName.Current = cat.GetChild(0).Text;
						category.Label.Current = cat.GetChild(0).Text;
					}
					else if (cat.ChildCount >= 2)
					{
						// TODO for now ignore the (code) coding
						code.Value = cat.GetChild(0).Text;
						for (int j = 1; j < cat.ChildCount; ++j)
						{
							if (cat.GetChild(j).Text.StartsWith("\""))
							{
								category.Label.Current = cat.GetChild(j).Text.Trim(new char[] { '"' });
								break;
							}
						}
					}
					*/
					if (categoryNames.Count < 3)
					{
						categoryNames.Add(catName);
					}
				}

				string madeUpName = string.Join(string.Empty, categoryNames.ToArray());
				catScheme.AddFirst(new XElement(Ddi.CategorySchemeName, madeUpName + "Categories"));
				codeScheme.AddFirst(new XElement(Ddi.CodeSchemeName, madeUpName + " Codes"));
			}
			else if (tt.Type == BlaiseParser.TYPE_INTEGER)
			{
				domain = Ddi.Element(Ddi.NumericDomain, false);
				domain.Add(new XAttribute("type", "Integer"));
			}
			else if (tt.Type == BlaiseParser.TYPE_OPEN)
			{
				domain = Ddi.Element(Ddi.TextDomain, false);
			}
			else if (tt.Type == BlaiseParser.TYPE_REAL)
			{
				domain = Ddi.Element(Ddi.NumericDomain, false);
				domain.Add(new XAttribute("type", "Float"));
			}
			else if (tt.Type == BlaiseParser.TYPE_SETOF)
			{
				string temp = tree.ToStringTree();
			}
			else if (tt.Type == BlaiseParser.TYPE_STRING)
			{
				domain = Ddi.Element(Ddi.TextDomain, false);
			}
			else if (tt.Type == BlaiseParser.TYPE_TIMETYPE)
			{
				domain = Ddi.Element(Ddi.DateTimeDomain, false);
			}
			else if (tt.Type == BlaiseParser.REALRANGE)
			{
				domain = Ddi.Element(Ddi.NumericDomain, false);
				domain.Add(new XAttribute("type", "Real"));

				var child0 = tt.GetChild(0);
				string low = null;
				if (child0 != null)
				{
					if (child0.GetChild(0) != null)
					{
						low = child0.GetChild(0).Text;
					}

					if (child0.GetChild(1) != null)
					{
						low += "." + child0.GetChild(1).Text;
					}
				}

				var child1 = tt.GetChild(1);
				string high = null;
				if (child1 != null)
				{
					if (child1.GetChild(0) != null)
					{
						high = child1.GetChild(0).Text;
					}

					if (child1.GetChild(1) != null)
					{
						high += "." + child1.GetChild(1).Text;
					}
				}

				try
				{
					bool hasRange = false;
					XElement range = Ddi.Element(Ddi.NumberRange, false);

					if (!string.IsNullOrEmpty(low))
					{
						range.Add(new XElement(Ddi.Low, low));
						hasRange = true;
					}

					if (!string.IsNullOrEmpty(high))
					{
						range.Add(new XElement(Ddi.High, high));
						hasRange = true;
					}

					if (hasRange)
					{
						domain.Add(range);
					}

					if (child0 != null)
					{
						domain.Add(new XAttribute("decimalPositions", child0.GetChild(1).Text.Length));
					}
				}
				catch (Exception)
				{
					// TODO warn invalid blaise file
				}
			}
			else if (tt.Type == BlaiseParser.INTRANGE)
			{
				domain = Ddi.Element(Ddi.NumericDomain, false);
				domain.Add(new XAttribute("type", "Integer"));

				//TODO parse reals as reals
				string low = tt.GetChild(0).Text;
				string high = tt.GetChild(1).Text;
				try
				{
					XElement range = Ddi.Element(Ddi.NumberRange, false);
					range.Add(new XElement(Ddi.Low, low));
					range.Add(new XElement(Ddi.High, high));
					domain.Add(range);
					domain.Add(new XAttribute("decimalPositions", 0));
				}
				catch (Exception)
				{
					// TODO warn invalid blaise file
				}
			}
			else if (tt.Type == BlaiseParser.TYPE_USERDEF)
			{
				// find the type and ask again
				if (tt.ChildCount != 0)
				{
					string usertype = tt.GetChild(0).Text;
					if (scope.HasBlaiseType(usertype))
					{
						ITree usertree = scope.GetBlaiseType(usertype);
						return ParseTypedefTree(usertree, scope);
					}
				}
			}

			if (domain == null)
			{
				domain = Ddi.Element(Ddi.TextDomain, false);
			}

			foundDomains.Add(tree, domain);
			return domain;
		}

		private void AssignQuestionStrings(XElement question, LanguageString blaiseString, Block scope)
		{
			BlaiseLanguageMapping mapping = options.GetMapping(blaiseString.Language);
			string encodedText = GetQuestionText(blaiseString.Value, scope);

			if (mapping != null)
			{
				if (mapping.MetadataElement == MetadataFieldType.Default)
				{
					question.Add(new XElement(Ddi.QuestionText, Ddi.XmlLang(mapping.Culture), new XElement(Ddi.LiteralText, new XElement(Ddi.Text, encodedText))));
				}
				else if (mapping.MetadataElement == MetadataFieldType.Description)
				{
					question.Add(new XElement(Ddi.Description, Ddi.XmlLang(mapping.Culture), encodedText));
				}
				else if (mapping.MetadataElement == MetadataFieldType.QuestionText)
				{
					question.Add(new XElement(Ddi.QuestionText, Ddi.XmlLang(mapping.Culture), new XElement(Ddi.LiteralText, new XElement(Ddi.Text, encodedText))));
				}
				else if (mapping.MetadataElement == MetadataFieldType.Intent)
				{
					question.Add(new XElement(Ddi.QuestionIntent, Ddi.XmlLang(mapping.Culture), encodedText));
				}
				else if (mapping.MetadataElement == MetadataFieldType.Label)
				{
					question.Add(new XElement(Ddi.Label, Ddi.XmlLang(mapping.Culture), encodedText));
				}
				else if (mapping.MetadataElement == MetadataFieldType.Instructions)
				{
					// TODO
				}
			}
			else
			{
				question.Add(new XElement(Ddi.QuestionText, Ddi.XmlLang(MainLanguage), new XElement(Ddi.LiteralText, new XElement(Ddi.Text, encodedText))));
			}
		}

		private string GetQuestionName(string questionName, string prefix)
		{
			// Don't really need a prefix.
			return questionName;

			//if (string.IsNullOrEmpty(prefix))
			//{
			//    return questionName;
			//}
			//else
			//{
			//    return prefix + ":" + questionName;
			//}
		}

		private string GetQuestionText(string formattedText, Block scope)
		{
			StringBuilder textBuilder = new StringBuilder();

			/////
			// first properly strip the text
			/////

			// strip quotes from sourcecode
			formattedText = formattedText.Trim(new char[] { '"' });

			// strip newline
			formattedText = formattedText.Replace('\n', ' ');

			// I think this is right, since tab stops are defined as @|
			formattedText = formattedText.Replace('\t', ' ');

			// strip multiple spaces
			while (formattedText.Contains("  "))
			{
				formattedText = formattedText.Replace("  ", " ");
			}

			/////
			// Do blaise formatting
			/////

			// add newlines
			formattedText = formattedText.Replace("@/", "\n");
			// add spaces ( Ctrl-period )
			// TODO find out what character this is

			// TODO
			// Ignore formating (for now)
			for (char i = 'A'; i <= 'Z'; i++)
			{
				StringBuilder tmp = new StringBuilder();
				tmp.Append("@");
				tmp.Append(i);
				string search = tmp.ToString();
				formattedText = formattedText.Replace(search, "");
			}

			formattedText = formattedText.Replace("@|", "\t");

			/////
			// replace blaise control characters
			/////

			//formatedText = formatedText.Replace("^^", "^");
			//formatedText = formatedText.Replace("\"\"", "\"");
			formattedText = formattedText.Replace("@@", "@");

			// Replace fill fields. "^fieldName" => "{fieldName}".
			Regex fillRegex = new Regex(@"\^([^\^\r\n ]+)");
			formattedText = fillRegex.Replace(formattedText, new MatchEvaluator(ReplaceFill));

			return formattedText;
		}

		private string ReplaceFill(Match match)
		{
			return "{" + match.Value.Replace("^", string.Empty) + "}";
		}

		#endregion
	}
}
