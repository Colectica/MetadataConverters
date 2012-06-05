using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime.Tree;
using System.Collections.ObjectModel;

namespace Colectica.BlaiseToDdi.Model
{
    internal class Field
    {
        private string title;
        private Collection<LanguageString> question = new Collection<LanguageString>();
        private Collection<LanguageString> description = new Collection<LanguageString>();

        private ITree typedef;
        private Block parent;

        private int fieldOrder;
        private bool auxField;

        private string tag;

        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public Collection<LanguageString> Question
        {
            get { return this.question; }
            set { this.question = value; }
        }

        public Collection<LanguageString> Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public Antlr.Runtime.Tree.ITree Typedef
        {
            get { return this.typedef; }
            set { this.typedef = value; }
        }

        public int FieldOrder
        {
            get { return this.fieldOrder; }
            set { this.fieldOrder = value; }
        }

        public bool AuxField
        {
            get { return this.auxField; }
            set { this.auxField = value; }
        }

        public Block Parent
        {
            get { return this.parent; }
            set { this.parent = value; }
        }
    }
}
