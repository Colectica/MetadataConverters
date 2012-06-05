using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime.Tree;
using System.Collections.ObjectModel;

namespace Colectica.BlaiseToDdi.Converter
{
    public class LanguageTreeWalker
    {
        CommonTree _tree;
        public LanguageTreeWalker(CommonTree tree)
        {
            this._tree = tree;
        }

        Collection<string> walkedLanguages = new Collection<string>();
        public Collection<string> WalkedLanguages
        {
            get { return walkedLanguages; }
        }


        public void Parse()
        {
            Collection<string> results = new Collection<string>();
            FindLanguageStrings(_tree, results);
            walkedLanguages = results;
        }

        Collection<string> definedLanguagesOrder = new Collection<string>();
        public Collection<string> DefinedLanguagesOrder
        {
            get { return definedLanguagesOrder; }
            set { definedLanguagesOrder = value; }
        }
        private Dictionary<string, string> definedLanguages = new Dictionary<string, string>();
        public Dictionary<string, string> DefinedLanguages
        {
            get { return definedLanguages; }
            set { definedLanguages = value; }
        }

        private void FindLanguageStrings(ITree tree, Collection<string> results)
        {
            if (tree.Type == BlaiseParser.LID_STRING)
            {
                if (tree.ChildCount == 2)
                {
                    string text = tree.GetChild(1).Text;
                    if (!results.Contains(text))
                    {
                        results.Add(text);
                    }
                }
            }

            if (tree.Type == BlaiseParser.LANGUAGE)
            {
                if (tree.ChildCount > 0)
                {
                    string lang = tree.GetChild(0).Text;
                    definedLanguagesOrder.Add(lang);
                    if (tree.ChildCount > 1)
                    {
                        string def = tree.GetChild(1).Text;
                        definedLanguages[lang] = def;
                    }
                    else
                    {
                        definedLanguages[lang] = "";
                    }
                }
            }

            for (int i = 0; i < tree.ChildCount; ++i)
            {
                ITree child = tree.GetChild(i);
                FindLanguageStrings(child, results);
            }
        }
    }
}
