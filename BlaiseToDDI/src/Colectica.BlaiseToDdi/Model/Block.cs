using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Antlr.Runtime.Tree;

namespace Colectica.BlaiseToDdi.Model
{
	internal class Block
	{
		private Dictionary<string, Block> blocks = new Dictionary<string, Block>();
		private Dictionary<string, Field> fields = new Dictionary<string, Field>();
		private Dictionary<string, ITree> types = new Dictionary<string, ITree>();
		private ITree rules;
		private ITree label;
		private Block parent;

		public Dictionary<string, Field> Fields { get { return this.fields; } }
		
		/// <summary>
		/// Determine if a type name is within the current scope
		/// </summary>
		/// <param name="typename"></param>
		/// <returns></returns>
		public bool HasBlaiseType(string typename)
		{
			foreach (string s in types.Keys)
			{
				if (string.Compare(s, typename, true) == 0)
				{
					return true;
				}
			}
			if (parent != null)
			{
				return parent.HasBlaiseType(typename);
			}
			return false;            
		}

		public ITree GetBlaiseType(string typename)
		{
			foreach (string s in types.Keys)
			{
				if (string.Compare(s, typename, true) == 0)
				{
					return types[s];
				}
			}
			if (parent != null)
			{
				return parent.GetBlaiseType(typename);
			}
			return null;   
		}

		public bool HasBlaiseField(string fieldname)
		{
			foreach (string s in fields.Keys)
			{
				if (string.Compare(s, fieldname, true) == 0)
				{
					return true;
				}
			}
			if (parent != null)
			{
				return parent.HasBlaiseField(fieldname);
			}
			return false;            
		}

		public Field GetBlaiseField(string fieldname)
		{
			foreach (string s in fields.Keys)
			{
				if (string.Compare(s, fieldname, true) == 0)
				{
					return fields[s];
				}
			}
			if (parent != null)
			{
				return parent.GetBlaiseField(fieldname);
			}
			return null;
		}

		/*
		public System.Collections.Generic.Dictionary<string, Algenta.Data.Parsing.Blaise.BlaiseModel.Block> Blocks
		{
			get { return this.blocks; }
		}

		public System.Collections.Generic.Dictionary<string, Algenta.Data.Parsing.Blaise.BlaiseModel.Field> Fields
		{
			get { return this.fields; }
		}*/

		public void AddField(string name, Field field)
		{
			this.fields.Add(name, field);
		}

		public void AddBlock(string name, Block block)
		{
			this.blocks.Add(name, block);
		}

		public void AddType(string name, ITree typetree)
		{
			this.types.Add(name, typetree);
		}

		public Antlr.Runtime.Tree.ITree Rules
		{
			get { return this.rules; }
			set { this.rules = value; }
		}

		public Block Parent
		{
			get { return this.parent; }
			set { this.parent = value; }
		}

		/*
		public System.Collections.Generic.Dictionary<string, Antlr.Runtime.Tree.ITree> Types
		{
			get { return this.types; }
		}*/

		public Antlr.Runtime.Tree.ITree Label
		{
			get { return this.label; }
			set { this.label = value; }
		}
		public string Title
		{
			get 
			{
				if (label != null && label.ChildCount != 0)
				{
					return label.GetChild(0).Text;
				}
				return null;            
			}
		}
		public string Description {
			get 
			{
				if (label != null && label.ChildCount >= 2)
				{
					return label.GetChild(1).Text.Trim('"');
				}
				return null;            
			}
		}


	}
}
