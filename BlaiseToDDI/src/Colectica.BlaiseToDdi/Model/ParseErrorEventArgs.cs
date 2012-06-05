using System;
using System.Collections.Generic;
using System.Text;

namespace Colectica.BlaiseToDdi.Model
{
	public class ParseErrorEventArgs : EventArgs
	{
		private Antlr.Runtime.RecognitionException exception;

		public Antlr.Runtime.RecognitionException Exception
		{
			get { return this.exception; }
		}

		public ParseErrorEventArgs(Antlr.Runtime.RecognitionException exception)
		{
			this.exception = exception;
		}
	}
}
