using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Colectica.BlaiseToDdi.Model;

namespace Colectica.BlaiseToDdi.Converter
{
    class BParser : BlaiseParser
    {
        #region Events

        public event EventHandler<ParseErrorEventArgs> Error;
        public event EventHandler<ParseErrorEventArgs> Warning;
        public event EventHandler<ParseErrorEventArgs> Message;

        #endregion

        #region Constructor

        public BParser(ITokenStream input)
            : base(input)
        {

        }

        #endregion

        #region Overrides

        public override void ReportError(Antlr.Runtime.RecognitionException e)
        {
            base.ReportError(e);

            TriggerError(e);
        }

        public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
        {
            System.Collections.IList stack = GetRuleInvocationStack(e, typeof(BlaiseParser).FullName);

            string msg = string.Empty;
            if (e is NoViableAltException)
            {
                NoViableAltException nvae = (NoViableAltException)e;
                msg = "noviablealt;token=" + e.Token.ToString() +
                    "(decision=" + nvae.decisionNumber +
                    "state" + nvae.stateNumber + ")" +
                    "decision=<<" + nvae.grammarDecisionDescription + ">>";
            }
            else
            {
                msg = base.GetErrorMessage(e, tokenNames);
            }

            string stackStr = string.Empty;
            foreach (object obj in stack)
            {
                stackStr += obj.ToString();
            }

            return stackStr + " " + msg;
        }


        #endregion

        #region Event trigger methods

        private void TriggerError(Antlr.Runtime.RecognitionException e)
        {
            if (this.Error != null)
            {
                Error(this, new ParseErrorEventArgs(e));
            }
        }

        private void TriggerWarning(Antlr.Runtime.RecognitionException e)
        {
            if (this.Warning != null)
            {
                Warning(this, new ParseErrorEventArgs(e));
            }
        }

        private void TriggerMessage(Antlr.Runtime.RecognitionException e)
        {
            if (this.Message != null)
            {
                Message(this, new ParseErrorEventArgs(e));
            }
        }

        #endregion
    }

}