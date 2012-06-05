using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;

namespace Colectica.BlaiseToDdi.Utility
{
    /// <summary>
    /// Look ahead for tokenizing is all lowercase, whereas the original case of an input stream is preserved.
    ///</summary>
    public class CaseInsensitiveFileStream : ANTLRFileStream
    {
        public CaseInsensitiveFileStream() { }

        public CaseInsensitiveFileStream(string input) : base(input) { }


        private bool upperCaseGrammar;


        // Only the lookahead is converted to lowercase. The original case is preserved in the stream.
        public override int LA(int i)
        {
            if (i == 0)
            {
                return 0;
            }

            if (i < 0)
            {
                i++;
            }

            if (((p + i) - 1) >= n)
            {
                return (int)CharStreamConstants.EOF;
            }

            // This is how "case insensitive" is defined, i.e., could also use a special culture...
            if (upperCaseGrammar)
            {
                return Char.ToUpperInvariant(data[(p + i) - 1]);
            }
            return Char.ToLowerInvariant(data[(p + i) - 1]);
        }

        public bool UpperCaseGrammar
        {
            get { return this.upperCaseGrammar; }
            set { this.upperCaseGrammar = value; }
        }
    }
}
