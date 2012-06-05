using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.Collections.ObjectModel;
using Colectica.BlaiseToDdi.Model;
using Colectica.BlaiseToDdi.Utility;

namespace Colectica.BlaiseToDdi.Converter
{
	public class BlaiseConverter
	{
		#region Fields

		BlaiseImportOptions options;
		
		CommonTree tree;
		CommonTokenStream tokens;

		#endregion

		#region Properties

		public string AgencyId { get; set; }
		public string MainLanguage { get; set; }

		public string LanguageVersion { get; set; }
		public string LsidAuthority { get; set; }

		Dictionary<string, int> itemLineNumbersField = new Dictionary<string, int>();
		public Dictionary<string, int> ItemLineNumbers
		{
			get { return this.itemLineNumbersField; }
		}

		private Collection<string> messagesField = new Collection<string>();
		public Collection<string> Messages { get { return this.messagesField; } }

		#endregion

		#region Event Trigger Methods

		protected void TriggerError(RecognitionException e)
		{
			if (this.Error != null)
			{
				Error(this, new ParseErrorEventArgs(e));
			}
		}

		protected void TriggerWarning(RecognitionException e)
		{
			if (this.Warning != null)
			{
				Warning(this, new ParseErrorEventArgs(e));
			}
		}

		protected void TriggerMessage(RecognitionException e)
		{
			if (this.Message != null)
			{
				Message(this, new ParseErrorEventArgs(e));
			}
		}

		public event EventHandler<ParseErrorEventArgs> Error;

		public event EventHandler<ParseErrorEventArgs> Warning;

		public event EventHandler<ParseErrorEventArgs> Message;

		#endregion

		#region Event Handlers

		void parser_Error(object sender, ParseErrorEventArgs e)
		{
			TriggerError(e.Exception);
		}

		void parser_Warning(object sender, ParseErrorEventArgs e)
		{
			TriggerWarning(e.Exception);
		}

		void parser_Message(object sender, ParseErrorEventArgs e)
		{
			TriggerMessage(e.Exception);
		}

		#endregion

		#region Constructor

		public BlaiseConverter()
		{
			
		}

		#endregion

		public BlaiseImportOptions ConvertPhase1(string fileName)
		{
			CaseInsensitiveFileStream stream = new CaseInsensitiveFileStream(fileName);
			stream.UpperCaseGrammar = true;

			// Run the lexer.
			BlaiseLexer lexer = new BlaiseLexer(stream);
			this.tokens = new CommonTokenStream(lexer, Lexer.DEFAULT_TOKEN_CHANNEL);

			// Create the parser and sign up for error events.
			BParser parser = new BParser(this.tokens);
			parser.TreeAdaptor = new CommonTreeAdaptor();
			parser.Error += new EventHandler<ParseErrorEventArgs>(parser_Error);
			parser.Warning += new EventHandler<ParseErrorEventArgs>(parser_Warning);
			parser.Message += new EventHandler<ParseErrorEventArgs>(parser_Message);

			// Run the parser.
			BParser.blaise_file_return r = null;
			try
			{
				r = parser.blaise_file();
			}
			catch (RecognitionException e)
			{
				TriggerError(e);
			}

			foreach (string missingFile in lexer.MissingFiles)
			{
				this.Messages.Add("Could not find " + missingFile);
			}

			if (r == null)
			{
				return null;
			}

			this.tree = r.Tree as CommonTree;

			if (this.tree == null ||
				this.tokens == null)
			{
				// TODO log this and/or send an error.
				return null;
			}


			// Prepare for the tree walkers.
			CommonTreeNodeStream nodes = new CommonTreeNodeStream(tree);
			nodes.TokenStream = this.tokens;
			
			// Walk the tree to find language definitions.
			BlaiseImportOptions options = new BlaiseImportOptions() { BaseFilePath = fileName };
			LanguageTreeWalker ltw = new LanguageTreeWalker(tree);
			ltw.Parse();
			options.DefinedLanguages = ltw.DefinedLanguages;
			options.DefinedLanguagesOrder = ltw.DefinedLanguagesOrder;

			return options;
		}

		public void ConvertPhase2(BlaiseImportOptions options, string outputFileName)
		{
			if (this.tree == null || this.tokens == null)
			{
				throw new InvalidOperationException("Call ConvertPhase1 first");
			}

			this.options = options;
			
			BlaiseInstrumentTreeWalker itw = new BlaiseInstrumentTreeWalker(this.tree, this.tokens, options, this.AgencyId, this.MainLanguage);
			itw.ParseInstrument();

			//InstrumentShrinker shrinker = new InstrumentShrinker(itw.ActivityToTree, tokens);
			//this.Instrument.Accept(shrinker);

			
			itw.DdiInstance.Save(outputFileName, System.Xml.Linq.SaveOptions.None);
		}



		
	}
}
