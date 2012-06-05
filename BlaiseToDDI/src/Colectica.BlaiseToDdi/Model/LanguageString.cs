using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime.Tree;

namespace Colectica.BlaiseToDdi.Model
{
	internal class LanguageString
	{
		string language = "";

		public string Language
		{
			get { return language; }
			set { language = value; }
		}
		string value = "";

		public string Value
		{
			get { return this.value; }
			//set { this.value = value; }
		}

		public LanguageString(ITree lidString)
		{
			if (lidString.Type != BlaiseParser.LID_STRING)
			{
				//TODO
				throw new InvalidOperationException("Parsed tree node was not a multilingual string");
			}

			if (lidString.ChildCount > 0)
			{
				this.value = lidString.GetChild(0).Text.Trim(trim);
				if (lidString.ChildCount > 1)
				{
					this.language = lidString.GetChild(1).Text;
				}
			}
		}

		public LanguageString(string value)
			: this(null, value)
		{
		}
		private static readonly char[] trim = new char[] { '"', ' ', '\'' };

		public LanguageString(string language, string value)
		{
			this.language = language;
			this.value = value.Trim(trim);
		}
	}

}
