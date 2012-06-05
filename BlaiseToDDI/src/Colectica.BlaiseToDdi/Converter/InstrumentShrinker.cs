using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.Xml.Linq;

namespace Colectica.BlaiseToDdi.Converter
{
	public class InstrumentShrinker
	{
		private CommonTokenStream tokens;

		public CommonTokenStream Tokens
		{
			get { return tokens; }
			set { tokens = value; }
		}


		public InstrumentShrinker(XElement instrument, CommonTokenStream tokens)
		{
			this.tokens = tokens;
		}

	}

	public class InstrumentUtility
	{
		public bool ContainsQuestionOrSubInstrument(XElement element)
		{
			return CheckNode(element);
		}

		bool CheckNode(XElement item)
		{
			if (item.Name.LocalName == "QuestionItem")
			{
				return true;
			}

			foreach (var child in item.Elements())
			{
				if (CheckNode(child))
				{
					return true;
				}
			}

			return false;
		}		
	}

	public static class TreeUtils
	{        
		public static void Times(this int count, Action action)
		{
			for (int i = 0; i < count; i++)
			{
				action();
			}
		}

		public static void Times(this int count, Action<int> action)
		{
			for (int i = 0; i < count; i++)
			{
				action(i);
			}
		}

		private static int GetFirstStartToken(ITree tree) 
		{
			int? start = null;
			for(int i = 0; i < tree.ChildCount; i++) 
			{
				ITree child = tree.GetChild(i);
				if (child.TokenStartIndex != -1)
				{
					if (!start.HasValue)
					{
						start = child.TokenStartIndex;
					} 
					else if (start.HasValue && child.TokenStartIndex < start.Value)
					{
						start = child.TokenStartIndex;
					} 
				} 
				else 
				{
					int childStart = GetFirstStartToken(child);
					if (childStart != -1)
					{
						start = childStart;
					}
				}
			}

			if (start.HasValue)
			{
				return start.Value;
			}
			else
			{
				return -1;
			}
		}

		private static int GetLastStopToken(ITree tree)
		{
			int? stop = null;
			for (int i = 0; i < tree.ChildCount; i++)
			{
				ITree child = tree.GetChild(i);
				if (child.TokenStopIndex != -1)
				{
					if (!stop.HasValue)
					{
						stop = child.TokenStopIndex;
					}
					else if (stop.HasValue && child.TokenStopIndex > stop.Value)
					{
						stop = child.TokenStopIndex;
					}
				}
				else
				{
					int childStop = GetLastStopToken(child);
					if (childStop != -1)
					{
						stop = childStop;
					}
				}
			}

			if (stop.HasValue)
			{
				return stop.Value;
			}
			else
			{
				return -1;
			}
		}

		public static string ToOriginalCode(this ITree tree, ITree nextTree, CommonTokenStream tokens)
		{
			int start = tree.TokenStartIndex;
			int end = nextTree.TokenStopIndex;
			int line = tree.Line;

			if (start < 0)
			{
				start = GetFirstStartToken(tree);                
			}
			if (end < 0)
			{
				end = GetLastStopToken(nextTree);
			}
			return ToOriginalCode(start, end, line, tokens);
		}


		public static string ToOriginalCode(this ITree tree, CommonTokenStream tokens)
		{

			int start = tree.TokenStartIndex;
			int end = tree.TokenStopIndex;
			int line = tree.Line;

			if (start < 0 || end < 0)
			{
				start = GetFirstStartToken(tree);
				end = GetLastStopToken(tree);
			}
			return ToOriginalCode(start, end, line, tokens);

		}

		private static string ToOriginalCode(int start, int end, int line, CommonTokenStream tokens)
		{
			if (start < 0 || end < 0)
			{
				return string.Empty;
			}

			StringBuilder buf = new StringBuilder();
			for (int i = start; (i <= end) && (i < tokens.Count); i++)
			{
				IToken token = tokens.Get(i);

				// if we have added newlines, add them.
				if (token.Line > line)
				{
					int numberOfNewlines = token.Line - line;
					numberOfNewlines.Times(() => buf.Append(Environment.NewLine));
					line = token.Line;

					// is this token indented to start off a new line?
					token.CharPositionInLine.Times(() => buf.Append(" "));
				}
				buf.Append(token.Text);

				// is there another token on this line, and is there a space
				if (i + 1 < tokens.Count)
				{
					IToken nextToken = tokens.Get(i + 1);
					if (nextToken.Line == line) // on the same line
					{
						// add spaces if there are any
						int numberOfSpaces = nextToken.CharPositionInLine - (token.CharPositionInLine + token.Text.Length);
						numberOfSpaces.Times(() => buf.Append(" "));
					}
				}
			}
			return buf.ToString();
		}
	}
}
