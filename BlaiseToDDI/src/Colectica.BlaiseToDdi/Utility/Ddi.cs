using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Colectica.BlaiseToDdi.Utility
{
	public static class Ddi
	{
		public static XNamespace Instance = "ddi:instance:3_1";
		public static XNamespace Reusable = "ddi:reusable:3_1";
		public static XNamespace Group = "ddi:group:3_1";
		public static XNamespace DataCollectionNS = "ddi:datacollection:3_1";
		public static XNamespace LogicalProduct = "ddi:logicalproduct:3_1";

		public static string AgencyId = "example.org";

		public static void AddNamespaces(XElement item)
		{
			item.Add(new XAttribute(XNamespace.Xmlns + "ddi", Ddi.Instance));
			item.Add(new XAttribute(XNamespace.Xmlns + "r", Ddi.Reusable));
			item.Add(new XAttribute(XNamespace.Xmlns + "g", Ddi.Group));
			item.Add(new XAttribute(XNamespace.Xmlns + "d", Ddi.DataCollectionNS));
			item.Add(new XAttribute(XNamespace.Xmlns + "l", Ddi.LogicalProduct));
		}

		public static XName DdiInstance
		{
			get { return Instance + "DDIInstance"; }
		}

		public static XName Description
		{
			get { return Reusable + "Description"; }
		}

		public static XName ResourcePackage
		{
			get { return Group + "ResourcePackage"; }
		}

		public static XName Instrument
		{
			get { return DataCollectionNS + "Instrument"; }
		}

		public static XName InstrumentName
		{
			get { return DataCollectionNS + "InstrumentName"; }
		}

		public static XName QuestionScheme
		{
			get { return DataCollectionNS + "QuestionScheme"; }
		}

		public static XName QuestionSchemeName
		{
			get { return DataCollectionNS + "QuestionSchemeName"; }
		}

		public static XName QuestionItem
		{
			get { return DataCollectionNS + "QuestionItem"; }
		}

		public static XName QuestionText
		{
			get { return DataCollectionNS + "QuestionText"; }
		}

		public static XName Label
		{
			get { return Reusable + "Label"; }
		}

		public static XName QuestionIntent
		{
			get { return DataCollectionNS + "QuestionIntent"; }
		}

		public static XName QuestionConstruct
		{
			get { return DataCollectionNS + "QuestionConstruct"; }
		}

		public static XName ComputationItem
		{
			get { return DataCollectionNS + "ComputationItem"; }
		}

		public static XName ConstructName
		{
			get { return DataCollectionNS + "ConstructName"; }
		}

		public static XName Code
		{
			get { return DataCollectionNS + "Code"; }
		}

		public static XName SourceCode
		{
			get { return Reusable + "Code"; }
		}

		public static XName ControlConstructReference
		{
			get { return DataCollectionNS + "ControlConstructReference"; }
		}

		public static XName ID
		{
			get { return Reusable + "ID"; }
		}

		public static XName IdentifyingAgency
		{
			get { return Reusable + "IdentifyingAgency"; }
		}

		public static XName Version
		{
			get { return Reusable + "Version"; }
		}

		public static XName Sequence
		{
			get { return DataCollectionNS + "Sequence"; }
		}

		public static XName ControlConstructScheme
		{
			get { return DataCollectionNS + "ControlConstructScheme"; }
		}

		public static XName Statement
		{
			get { return DataCollectionNS + "StatementItem"; }
		}

		public static XName StatementText
		{
			get { return DataCollectionNS + "StatementText"; }
		}

		public static XName While
		{
			get { return DataCollectionNS + "While"; }
		}

		public static XName GroupDataCollection
		{
			get { return Group + "DataCollection"; }
		}

		public static XName DataCollection
		{
			get { return DataCollectionNS + "DataCollection"; }
		}

		public static XName QuestionItemName
		{
			get { return DataCollectionNS + "QuestionItemName"; }
		}

		public static XName NumericDomain
		{
			get { return DataCollectionNS + "NumericDomain"; }
		}

		public static XName TextDomain
		{
			get { return DataCollectionNS + "TextDomain"; }
		}

		public static XName DateTimeDomain
		{
			get { return DataCollectionNS + "DateTimeDomain"; }
		}

		public static XName NumberRange
		{
			get { return Reusable + "NumberRange"; }
		}

		public static XName Low
		{
			get { return Reusable + "Low"; }
		}

		public static XName High
		{
			get { return Reusable + "High"; }
		}

		public static XName CategoryScheme
		{
			get { return LogicalProduct + "CategoryScheme"; }
		}

		public static XName CodeScheme
		{
			get { return LogicalProduct + "CodeScheme"; }
		}

		public static XName CodeDomain
		{
			get { return DataCollectionNS + "CodeDomain"; }
		}

		public static XName CodeSchemeReference
		{
			get { return Reusable + "CodeSchemeReference"; }
		}

		public static XName Category
		{
			get { return LogicalProduct + "Category"; }
		}

		public static XName LogicalCode
		{
			get { return LogicalProduct + "Code"; }
		}

		public static XName CategoryReference
		{
			get { return LogicalProduct + "CategoryReference"; }
		}

		public static XName CategoryName
		{
			get { return LogicalProduct + "CategoryName"; }
		}

		public static XName CategorySchemeName
		{
			get { return LogicalProduct + "CategorySchemeName"; }
		}

		public static XName CodeSchemeName
		{
			get { return LogicalProduct + "CodeSchemeName"; }
		}

		public static XName QuestionReference
		{
			get { return DataCollectionNS + "QuestionReference"; }
		}

		public static XName Purpose
		{
			get { return Group + "Purpose"; }
		}

		public static XName WhileCondition
		{
			get { return DataCollectionNS + "WhileCondition"; }
		}

		public static XName WhileConstructReference
		{
			get { return DataCollectionNS + "WhileConstructReference"; }
		}

		public static XName Loop
		{
			get { return DataCollectionNS + "Loop"; }
		}

		public static XName InitialValue
		{
			get { return DataCollectionNS + "InitialValue"; }
		}

		public static XName LoopWhile
		{
			get { return DataCollectionNS + "LoopWhile"; }
		}

		public static XName StepValue
		{
			get { return DataCollectionNS + "StepValue"; }
		}

		public static XName Content
		{
			get { return Reusable + "Content"; }
		}


		public static XElement Element(XName name, bool isIdentifiable = true)
		{
			XElement element = new XElement(name);

			if (isIdentifiable)
			{
				element.Add(new XAttribute("id", IdentifierService.GetIdentifier()));
			}

			return element;
		}

		public static XAttribute XmlLang(string value)
		{
			return new XAttribute(XNamespace.Xml + "lang", value);
		}

		public static XElement GetReference(XName refName, XElement item)
		{
			string id = item.GetAttribute("id");
			string version = item.GetAttribute("version") ?? "1.0.0";

			return new XElement(refName,
				new XElement(Ddi.ID, id),
				new XElement(Ddi.IdentifyingAgency, Ddi.AgencyId),
				new XElement(Ddi.Version, version)
			);
		}

		public static string GetAttribute(this XElement element, string name)
		{
			XAttribute attr = element.Attribute(name);
			if (attr == null) return null;

			return attr.Value;
		}

		public static XElement GetCode(XName name, string code)
		{
			return new XElement(name,
				new XElement(Ddi.SourceCode,
						new XAttribute("programmingLanguage", "Blaise"),
						code));
		}


		public static XName LiteralText
		{
			get { return DataCollectionNS + "LiteralText"; }
		}

		public static XName Text
		{
			get { return DataCollectionNS + "Text"; }
		}

		public static XName Value
		{
			get { return LogicalProduct + "Value"; }
		}

		public static XName IfThenElse
		{
			get { return DataCollectionNS + "IfThenElse"; }
		}

		public static XName IfCondition
		{
			get { return DataCollectionNS + "IfCondition"; }
		}

		public static XName ThenConstructReference
		{
			get { return DataCollectionNS + "ThenConstructReference"; }
		}

		public static XName ElseIf
		{
			get { return DataCollectionNS + "ElseIf"; }
		}

		public static XName ElseConstructReference
		{
			get { return DataCollectionNS + "ElseConstructReference"; }
		}
	}
}
