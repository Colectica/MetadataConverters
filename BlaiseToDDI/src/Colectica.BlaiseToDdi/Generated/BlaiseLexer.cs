// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g 2011-10-05 12:20:53

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

using Colectica.BlaiseToDdi.Utility;
using System.IO;
using System.Collections.Generic;



using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



namespace Colectica.BlaiseToDdi
{
public partial class BlaiseLexer : Lexer {
    public const int STAR = 188;
    public const int LETTER = 210;
    public const int MOD = 177;
    public const int SUB_TYPE = 27;
    public const int NODONTKNOW = 131;
    public const int DO = 183;
    public const int NOT = 175;
    public const int EOF = -1;
    public const int TYPE = 167;
    public const int DK = 137;
    public const int RPAREN = 201;
    public const int IMPORT = 119;
    public const int TYPE_INTEGER = 44;
    public const int NOT_EQUAL = 195;
    public const int INCLUDE = 54;
    public const int EXTERNALS = 117;
    public const int EXPORT = 120;
    public const int TYPE_STRING = 42;
    public const int NOEMPTY = 133;
    public const int SHOW = 153;
    public const int ENDMODEL = 88;
    public const int RBRACK = 203;
    public const int D = 61;
    public const int E = 62;
    public const int FIELD_TAG = 40;
    public const int GE = 198;
    public const int F = 63;
    public const int G = 64;
    public const int A = 58;
    public const int B = 59;
    public const int C = 60;
    public const int L = 69;
    public const int M = 70;
    public const int N = 71;
    public const int O = 72;
    public const int GRID = 158;
    public const int H = 65;
    public const int I = 66;
    public const int J = 67;
    public const int ELSE = 98;
    public const int ASK = 152;
    public const int PARALLEL_ITEM = 23;
    public const int K = 68;
    public const int U = 78;
    public const int T = 77;
    public const int W = 80;
    public const int V = 79;
    public const int LCURLY = 207;
    public const int Q = 74;
    public const int INT = 209;
    public const int P = 73;
    public const int S = 76;
    public const int R = 75;
    public const int SUB_LAYOUT = 26;
    public const int Y = 82;
    public const int X = 81;
    public const int EMPTY = 128;
    public const int Z = 83;
    public const int LANGUAGE = 20;
    public const int WS = 55;
    public const int VARIABLE_LIST = 9;
    public const int MS_LANGUAGES = 19;
    public const int USES = 143;
    public const int DONTKNOW = 136;
    public const int SUB_LOCALS = 28;
    public const int INFOPANE = 157;
    public const int GT = 199;
    public const int RESERVECHECK = 166;
    public const int SEARCH = 156;
    public const int END = 96;
    public const int SECONDARY_KEY = 18;
    public const int RF = 135;
    public const int T__214 = 214;
    public const int LBRACK = 202;
    public const int ATTRIBUTES = 145;
    public const int PARAMETERS = 116;
    public const int MS_SETTINGS = 15;
    public const int MS_PRIMARY = 16;
    public const int TABLE = 102;
    public const int POSITION = 184;
    public const int LPAREN = 200;
    public const int MS_SECONDARY = 17;
    public const int AT = 172;
    public const int SELECTOR = 30;
    public const int SLASH = 189;
    public const int THEN = 103;
    public const int CASE_ITEM = 35;
    public const int TYPE_CATEGORY_CODE = 46;
    public const int ARRAY_INDEX = 53;
    public const int SIGNAL = 114;
    public const int PLUS = 186;
    public const int ENDDO = 91;
    public const int EMBEDDED = 105;
    public const int QSTRING = 56;
    public const int REFUSAL = 134;
    public const int LIBRARIES = 118;
    public const int FORDO = 34;
    public const int BUILTIN_FUNCTION = 12;
    public const int INTEGER = 110;
    public const int LOCALS = 168;
    public const int INTEGER_LIST = 10;
    public const int TO = 171;
    public const int TYPEDEF = 41;
    public const int INHERIT = 124;
    public const int FIELD_DESC = 39;
    public const int SET = 180;
    public const int SQUOTE = 211;
    public const int MINUS = 187;
    public const int TYPE_SETOF = 51;
    public const int SEMI = 192;
    public const int SQSTRING = 212;
    public const int COLON = 193;
    public const int NEWCOLUMN = 162;
    public const int LID_STRING = 36;
    public const int TYPE_USERDEF = 50;
    public const int NORF = 130;
    public const int NEWPAGE = 86;
    public const int BLOCK = 104;
    public const int RCURLY = 208;
    public const int ALIEN = 139;
    public const int TYPE_TIMETYPE = 48;
    public const int CAPI = 126;
    public const int DIV = 176;
    public const int STRING = 108;
    public const int LT = 196;
    public const int WHILE = 107;
    public const int ENDBLOCK = 93;
    public const int DATETYPE = 111;
    public const int CASE = 100;
    public const int CHAR = 182;
    public const int PARAMETERS_OR_EXPRESSION = 11;
    public const int UPPERCASE = 185;
    public const int USES_ITEM = 25;
    public const int ENDIF = 89;
    public const int CLASSIFY = 155;
    public const int VAR = 169;
    public const int FIELD_TEXT = 38;
    public const int ENDWHILE = 90;
    public const int COMMENT = 84;
    public const int PARAMETER_LIST = 6;
    public const int ARRAY = 113;
    public const int ENDTABLE = 92;
    public const int SETTINGS = 140;
    public const int DATA_MODEL = 14;
    public const int NODK = 132;
    public const int CONDITIONAL = 13;
    public const int CATEGORY = 52;
    public const int SECONDARY = 146;
    public const int PRIMARY = 142;
    public const int TYPE_ITEM = 31;
    public const int ERROR = 99;
    public const int OF = 181;
    public const int ALPHA = 147;
    public const int TYPE_REAL = 32;
    public const int LOOKUP = 154;
    public const int VARIABLE = 29;
    public const int CATI = 125;
    public const int TYPE_CATEGORY = 45;
    public const int OR = 179;
    public const int FIELD = 37;
    public const int CHECK = 115;
    public const int INCLUDE_FILE = 57;
    public const int ENDPROCEDURE = 94;
    public const int FROM = 165;
    public const int INTRANGE = 4;
    public const int TRIGRAM = 148;
    public const int PARALLEL = 149;
    public const int FIELDPANE = 159;
    public const int FOR = 106;
    public const int DOTDOT = 205;
    public const int ID = 213;
    public const int ID_LIST = 8;
    public const int AND = 178;
    public const int DUMMY = 160;
    public const int IF = 173;
    public const int TYPE_OPEN = 43;
    public const int TRANSIT = 121;
    public const int IN = 174;
    public const int TYPE_DATETYPE = 47;
    public const int COMMA = 191;
    public const int AUXFIELDS = 122;
    public const int EQUAL = 194;
    public const int REALRANGE = 5;
    public const int IMGLINK = 127;
    public const int ATSYMB = 204;
    public const int MS_ATTRIBUTES = 21;
    public const int DOT = 206;
    public const int LANGUAGES = 144;
    public const int RULES = 170;
    public const int MS_PARALLEL = 22;
    public const int ENDCASE = 101;
    public const int NOREFUSAL = 129;
    public const int DATAMODEL = 87;
    public const int PARAMETER_ITEM = 7;
    public const int BEFORE = 164;
    public const int FIELDS = 123;
    public const int AFTER = 163;
    public const int LAYOUT = 141;
    public const int PROCEDURE = 95;
    public const int ELSEIF = 97;
    public const int OPEN = 109;
    public const int WHILEDO = 33;
    public const int TYPE_ARRAY = 49;
    public const int ROUTER = 138;
    public const int TIMETYPE = 112;
    public const int NEWLINE = 85;
    public const int LABEL = 24;
    public const int KEEP = 151;
    public const int ASSIGN = 190;
    public const int T_NEWLINE = 161;
    public const int INVOLVING = 150;
    public const int LE = 197;


        class SaveStruct
        {
            public SaveStruct(Antlr.Runtime.ICharStream input)
            {
                this.input = input;
                this.marker = input.Mark();
            }
            private Antlr.Runtime.ICharStream input;
            private int marker;

            public Antlr.Runtime.ICharStream Input
            {
                get { return this.input; }
                set { this.input = value; }
            }

            public int Marker
            {
                get { return this.marker; }
                set { this.marker = value; }
            }
        }
        
        private List<string> missingFilesField = new List<string>();
        public List<string> MissingFiles { get { return this.missingFilesField; } }
            
        Stack includes = new Stack();
        string topLevelDirectory = string.Empty;

        /// <summary>
        /// override for EOF handling of included file
        /// </summary>
        /// <returns>next IToken</returns>
        public override IToken NextToken()
        {
            IToken token = base.NextToken();

            if (token == Token.EOF_TOKEN && includes.Count != 0)
            {
                // We've got EOF and have non empty stack.
                SaveStruct ss = (SaveStruct)includes.Pop();
                this.CharStream = ss.Input;
                input.Rewind(ss.Marker);
                token = this.NextToken();
            }

            // Skip first token after switching on another input.
            if (((CommonToken)token).StartIndex < 0)
                token = this.NextToken();

            return token;
        }


    // delegates
    // delegators

    public BlaiseLexer() 
    {
		InitializeCyclicDFAs();
    }
    public BlaiseLexer(ICharStream input)
		: this(input, null) {
    }
    public BlaiseLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g";} 
    }

    // $ANTLR start "T__214"
    public void mT__214() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__214;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:70:8: ( 'REAL' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:70:10: 'REAL'
            {
            	Match("REAL"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__214"

    // $ANTLR start "INCLUDE_FILE"
    public void mINCLUDE_FILE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INCLUDE_FILE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            IToken f = null;

            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:159:13: ( INCLUDE ( WS )* f= QSTRING )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:159:15: INCLUDE ( WS )* f= QSTRING
            {
            	mINCLUDE(); 
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:159:23: ( WS )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '\t' && LA1_0 <= '\n') || (LA1_0 >= '\f' && LA1_0 <= '\r') || LA1_0 == ' ') )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:159:24: WS
            			    {
            			    	mWS(); 

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	int fStart58 = CharIndex;
            	mQSTRING(); 
            	f = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, fStart58, CharIndex-1);

            		#region Include input stream switching
            		String name = f.Text;
            		name = name.Trim('"');
            		try
            		{
            			// save current lexer's state
            			SaveStruct ss = new SaveStruct(input);
            		
            		CaseInsensitiveFileStream currentStream = input as CaseInsensitiveFileStream;
            			if (currentStream != null)
            			{
            				if (string.IsNullOrEmpty(topLevelDirectory))
            				{
            					topLevelDirectory = Path.GetDirectoryName(currentStream.SourceName);
            				}
            		
            			if(topLevelDirectory != null) 
            				{
            					// Blaise apparently treats all INCLUDES as if they are relative to the top level.
            					// string dir = Path.GetDirectoryName(currentStream.SourceName);
            					string bigPath = topLevelDirectory +
            					System.IO.Path.DirectorySeparatorChar +
            					name;
            					name = System.IO.Path.GetFullPath(bigPath);
            				}
            			}
            			
            			// switch on new input stream
            			if(!File.Exists(name)) 
            			{ 
            				System.Console.WriteLine("Cannot find include file " + name);
            				this.MissingFiles.Add(name);
            			}
            			else {
            			CaseInsensitiveFileStream newStream = new CaseInsensitiveFileStream(name);
            			newStream.UpperCaseGrammar = true;                    
            			this.CharStream = newStream;
            			includes.Push(ss);
            			Reset();
            			}
            		}
            		catch (Exception fnf)
            		{
            			//throw new Exception("Cannot open include file " + name, fnf);
            			System.Console.WriteLine("Cannot open include file " + name);
            		}
            		#endregion


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INCLUDE_FILE"

    // $ANTLR start "A"
    public void mA() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:310:11: ( ( 'a' | 'A' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:310:12: ( 'a' | 'A' )
            {
            	if ( input.LA(1) == 'A' || input.LA(1) == 'a' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "A"

    // $ANTLR start "B"
    public void mB() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:311:11: ( ( 'b' | 'B' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:311:12: ( 'b' | 'B' )
            {
            	if ( input.LA(1) == 'B' || input.LA(1) == 'b' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "B"

    // $ANTLR start "C"
    public void mC() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:312:11: ( ( 'c' | 'C' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:312:12: ( 'c' | 'C' )
            {
            	if ( input.LA(1) == 'C' || input.LA(1) == 'c' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "C"

    // $ANTLR start "D"
    public void mD() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:313:11: ( ( 'd' | 'D' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:313:12: ( 'd' | 'D' )
            {
            	if ( input.LA(1) == 'D' || input.LA(1) == 'd' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "D"

    // $ANTLR start "E"
    public void mE() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:314:11: ( ( 'e' | 'E' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:314:12: ( 'e' | 'E' )
            {
            	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "E"

    // $ANTLR start "F"
    public void mF() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:315:11: ( ( 'f' | 'F' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:315:12: ( 'f' | 'F' )
            {
            	if ( input.LA(1) == 'F' || input.LA(1) == 'f' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "F"

    // $ANTLR start "G"
    public void mG() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:316:11: ( ( 'g' | 'G' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:316:12: ( 'g' | 'G' )
            {
            	if ( input.LA(1) == 'G' || input.LA(1) == 'g' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "G"

    // $ANTLR start "H"
    public void mH() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:317:11: ( ( 'h' | 'H' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:317:12: ( 'h' | 'H' )
            {
            	if ( input.LA(1) == 'H' || input.LA(1) == 'h' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "H"

    // $ANTLR start "I"
    public void mI() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:318:11: ( ( 'i' | 'I' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:318:12: ( 'i' | 'I' )
            {
            	if ( input.LA(1) == 'I' || input.LA(1) == 'i' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "I"

    // $ANTLR start "J"
    public void mJ() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:319:11: ( ( 'j' | 'J' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:319:12: ( 'j' | 'J' )
            {
            	if ( input.LA(1) == 'J' || input.LA(1) == 'j' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "J"

    // $ANTLR start "K"
    public void mK() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:320:11: ( ( 'k' | 'K' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:320:12: ( 'k' | 'K' )
            {
            	if ( input.LA(1) == 'K' || input.LA(1) == 'k' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "K"

    // $ANTLR start "L"
    public void mL() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:321:11: ( ( 'l' | 'L' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:321:12: ( 'l' | 'L' )
            {
            	if ( input.LA(1) == 'L' || input.LA(1) == 'l' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "L"

    // $ANTLR start "M"
    public void mM() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:322:11: ( ( 'm' | 'M' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:322:12: ( 'm' | 'M' )
            {
            	if ( input.LA(1) == 'M' || input.LA(1) == 'm' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "M"

    // $ANTLR start "N"
    public void mN() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:323:11: ( ( 'n' | 'N' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:323:12: ( 'n' | 'N' )
            {
            	if ( input.LA(1) == 'N' || input.LA(1) == 'n' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "N"

    // $ANTLR start "O"
    public void mO() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:324:11: ( ( 'o' | 'O' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:324:12: ( 'o' | 'O' )
            {
            	if ( input.LA(1) == 'O' || input.LA(1) == 'o' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "O"

    // $ANTLR start "P"
    public void mP() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:325:11: ( ( 'p' | 'P' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:325:12: ( 'p' | 'P' )
            {
            	if ( input.LA(1) == 'P' || input.LA(1) == 'p' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "P"

    // $ANTLR start "Q"
    public void mQ() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:326:11: ( ( 'q' | 'Q' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:326:12: ( 'q' | 'Q' )
            {
            	if ( input.LA(1) == 'Q' || input.LA(1) == 'q' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Q"

    // $ANTLR start "R"
    public void mR() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:327:11: ( ( 'r' | 'R' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:327:12: ( 'r' | 'R' )
            {
            	if ( input.LA(1) == 'R' || input.LA(1) == 'r' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "R"

    // $ANTLR start "S"
    public void mS() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:328:11: ( ( 's' | 'S' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:328:12: ( 's' | 'S' )
            {
            	if ( input.LA(1) == 'S' || input.LA(1) == 's' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "S"

    // $ANTLR start "T"
    public void mT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:329:11: ( ( 't' | 'T' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:329:12: ( 't' | 'T' )
            {
            	if ( input.LA(1) == 'T' || input.LA(1) == 't' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "T"

    // $ANTLR start "U"
    public void mU() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:330:11: ( ( 'u' | 'U' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:330:12: ( 'u' | 'U' )
            {
            	if ( input.LA(1) == 'U' || input.LA(1) == 'u' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "U"

    // $ANTLR start "V"
    public void mV() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:331:11: ( ( 'v' | 'V' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:331:12: ( 'v' | 'V' )
            {
            	if ( input.LA(1) == 'V' || input.LA(1) == 'v' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "V"

    // $ANTLR start "W"
    public void mW() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:332:11: ( ( 'w' | 'W' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:332:12: ( 'w' | 'W' )
            {
            	if ( input.LA(1) == 'W' || input.LA(1) == 'w' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "W"

    // $ANTLR start "X"
    public void mX() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:333:11: ( ( 'x' | 'X' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:333:12: ( 'x' | 'X' )
            {
            	if ( input.LA(1) == 'X' || input.LA(1) == 'x' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "X"

    // $ANTLR start "Y"
    public void mY() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:334:11: ( ( 'y' | 'Y' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:334:12: ( 'y' | 'Y' )
            {
            	if ( input.LA(1) == 'Y' || input.LA(1) == 'y' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Y"

    // $ANTLR start "Z"
    public void mZ() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:335:11: ( ( 'z' | 'Z' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:335:12: ( 'z' | 'Z' )
            {
            	if ( input.LA(1) == 'Z' || input.LA(1) == 'z' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Z"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:340:5: ( '{' ( options {greedy=false; } : WS | COMMENT | . )* '}' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:340:9: '{' ( options {greedy=false; } : WS | COMMENT | . )* '}'
            {
            	Match('{'); 
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:341:9: ( options {greedy=false; } : WS | COMMENT | . )*
            	do 
            	{
            	    int alt2 = 4;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == '}') )
            	    {
            	        alt2 = 4;
            	    }
            	    else if ( (LA2_0 == ' ') )
            	    {
            	        alt2 = 1;
            	    }
            	    else if ( (LA2_0 == '\t') )
            	    {
            	        alt2 = 1;
            	    }
            	    else if ( (LA2_0 == '\f') )
            	    {
            	        alt2 = 1;
            	    }
            	    else if ( (LA2_0 == '\r') )
            	    {
            	        alt2 = 1;
            	    }
            	    else if ( (LA2_0 == '\n') )
            	    {
            	        alt2 = 1;
            	    }
            	    else if ( (LA2_0 == '{') )
            	    {
            	        alt2 = 2;
            	    }
            	    else if ( ((LA2_0 >= '\u0000' && LA2_0 <= '\b') || LA2_0 == '\u000B' || (LA2_0 >= '\u000E' && LA2_0 <= '\u001F') || (LA2_0 >= '!' && LA2_0 <= 'z') || LA2_0 == '|' || (LA2_0 >= '~' && LA2_0 <= '\uFFFF')) )
            	    {
            	        alt2 = 3;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:342:11: WS
            			    {
            			    	mWS(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:343:11: COMMENT
            			    {
            			    	mCOMMENT(); 

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:344:11: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	Match('}'); 
            	 Skip(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:350:5: ( ( ' ' | '\\t' | '\\f' | NEWLINE ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:350:7: ( ' ' | '\\t' | '\\f' | NEWLINE )
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:350:7: ( ' ' | '\\t' | '\\f' | NEWLINE )
            	int alt3 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case ' ':
            		{
            	    alt3 = 1;
            	    }
            	    break;
            	case '\t':
            		{
            	    alt3 = 2;
            	    }
            	    break;
            	case '\f':
            		{
            	    alt3 = 3;
            	    }
            	    break;
            	case '\n':
            	case '\r':
            		{
            	    alt3 = 4;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d3s0 =
            		        new NoViableAltException("", 3, 0, input);

            		    throw nvae_d3s0;
            	}

            	switch (alt3) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:350:9: ' '
            	        {
            	        	Match(' '); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:351:7: '\\t'
            	        {
            	        	Match('\t'); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:352:7: '\\f'
            	        {
            	        	Match('\f'); 

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:353:7: NEWLINE
            	        {
            	        	mNEWLINE(); 

            	        }
            	        break;

            	}

            	 Skip(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:357:18: ( ( '\\r\\n' | '\\r' | '\\n' ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:357:19: ( '\\r\\n' | '\\r' | '\\n' )
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:357:19: ( '\\r\\n' | '\\r' | '\\n' )
            	int alt4 = 3;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == '\r') )
            	{
            	    int LA4_1 = input.LA(2);

            	    if ( (LA4_1 == '\n') )
            	    {
            	        alt4 = 1;
            	    }
            	    else 
            	    {
            	        alt4 = 2;}
            	}
            	else if ( (LA4_0 == '\n') )
            	{
            	    alt4 = 3;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:357:21: '\\r\\n'
            	        {
            	        	Match("\r\n"); 


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:358:5: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:359:5: '\\n'
            	        {
            	        	Match('\n'); 

            	        }
            	        break;

            	}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWLINE"

    // $ANTLR start "NEWPAGE"
    public void mNEWPAGE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWPAGE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:362:9: ( N E W P A G E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:362:11: N E W P A G E
            {
            	mN(); 
            	mE(); 
            	mW(); 
            	mP(); 
            	mA(); 
            	mG(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWPAGE"

    // $ANTLR start "DATAMODEL"
    public void mDATAMODEL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DATAMODEL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:363:10: ( D A T A M O D E L )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:363:12: D A T A M O D E L
            {
            	mD(); 
            	mA(); 
            	mT(); 
            	mA(); 
            	mM(); 
            	mO(); 
            	mD(); 
            	mE(); 
            	mL(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DATAMODEL"

    // $ANTLR start "ENDMODEL"
    public void mENDMODEL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ENDMODEL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:365:9: ( E N D M O D E L )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:365:11: E N D M O D E L
            {
            	mE(); 
            	mN(); 
            	mD(); 
            	mM(); 
            	mO(); 
            	mD(); 
            	mE(); 
            	mL(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ENDMODEL"

    // $ANTLR start "ENDIF"
    public void mENDIF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ENDIF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:366:7: ( E N D I F )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:366:9: E N D I F
            {
            	mE(); 
            	mN(); 
            	mD(); 
            	mI(); 
            	mF(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ENDIF"

    // $ANTLR start "ENDWHILE"
    public void mENDWHILE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ENDWHILE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:367:9: ( E N D W H I L E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:367:11: E N D W H I L E
            {
            	mE(); 
            	mN(); 
            	mD(); 
            	mW(); 
            	mH(); 
            	mI(); 
            	mL(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ENDWHILE"

    // $ANTLR start "ENDDO"
    public void mENDDO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ENDDO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:368:7: ( E N D D O )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:368:9: E N D D O
            {
            	mE(); 
            	mN(); 
            	mD(); 
            	mD(); 
            	mO(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ENDDO"

    // $ANTLR start "ENDTABLE"
    public void mENDTABLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ENDTABLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:369:9: ( E N D T A B L E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:369:11: E N D T A B L E
            {
            	mE(); 
            	mN(); 
            	mD(); 
            	mT(); 
            	mA(); 
            	mB(); 
            	mL(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ENDTABLE"

    // $ANTLR start "ENDBLOCK"
    public void mENDBLOCK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ENDBLOCK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:370:10: ( E N D B L O C K )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:370:11: E N D B L O C K
            {
            	mE(); 
            	mN(); 
            	mD(); 
            	mB(); 
            	mL(); 
            	mO(); 
            	mC(); 
            	mK(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ENDBLOCK"

    // $ANTLR start "ENDPROCEDURE"
    public void mENDPROCEDURE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ENDPROCEDURE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:371:13: ( E N D P R O C E D U R E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:371:15: E N D P R O C E D U R E
            {
            	mE(); 
            	mN(); 
            	mD(); 
            	mP(); 
            	mR(); 
            	mO(); 
            	mC(); 
            	mE(); 
            	mD(); 
            	mU(); 
            	mR(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ENDPROCEDURE"

    // $ANTLR start "PROCEDURE"
    public void mPROCEDURE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PROCEDURE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:372:10: ( P R O C E D U R E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:372:12: P R O C E D U R E
            {
            	mP(); 
            	mR(); 
            	mO(); 
            	mC(); 
            	mE(); 
            	mD(); 
            	mU(); 
            	mR(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PROCEDURE"

    // $ANTLR start "END"
    public void mEND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:373:5: ( E N D )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:373:7: E N D
            {
            	mE(); 
            	mN(); 
            	mD(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "END"

    // $ANTLR start "ELSEIF"
    public void mELSEIF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELSEIF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:375:8: ( E L S E I F )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:375:10: E L S E I F
            {
            	mE(); 
            	mL(); 
            	mS(); 
            	mE(); 
            	mI(); 
            	mF(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELSEIF"

    // $ANTLR start "ELSE"
    public void mELSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:376:6: ( E L S E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:376:8: E L S E
            {
            	mE(); 
            	mL(); 
            	mS(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELSE"

    // $ANTLR start "ERROR"
    public void mERROR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ERROR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:377:7: ( E R R O R )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:377:9: E R R O R
            {
            	mE(); 
            	mR(); 
            	mR(); 
            	mO(); 
            	mR(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ERROR"

    // $ANTLR start "CASE"
    public void mCASE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CASE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:379:6: ( C A S E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:379:8: C A S E
            {
            	mC(); 
            	mA(); 
            	mS(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CASE"

    // $ANTLR start "ENDCASE"
    public void mENDCASE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ENDCASE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:380:9: ( E N D C A S E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:380:11: E N D C A S E
            {
            	mE(); 
            	mN(); 
            	mD(); 
            	mC(); 
            	mA(); 
            	mS(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ENDCASE"

    // $ANTLR start "TABLE"
    public void mTABLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TABLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:383:7: ( T A B L E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:383:9: T A B L E
            {
            	mT(); 
            	mA(); 
            	mB(); 
            	mL(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TABLE"

    // $ANTLR start "THEN"
    public void mTHEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = THEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:385:6: ( T H E N )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:385:8: T H E N
            {
            	mT(); 
            	mH(); 
            	mE(); 
            	mN(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "THEN"

    // $ANTLR start "BLOCK"
    public void mBLOCK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BLOCK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:386:7: ( B L O C K )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:386:9: B L O C K
            {
            	mB(); 
            	mL(); 
            	mO(); 
            	mC(); 
            	mK(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BLOCK"

    // $ANTLR start "EMBEDDED"
    public void mEMBEDDED() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EMBEDDED;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:388:10: ( E M B E D D E D )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:388:14: E M B E D D E D
            {
            	mE(); 
            	mM(); 
            	mB(); 
            	mE(); 
            	mD(); 
            	mD(); 
            	mE(); 
            	mD(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EMBEDDED"

    // $ANTLR start "FOR"
    public void mFOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:391:5: ( F O R )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:391:7: F O R
            {
            	mF(); 
            	mO(); 
            	mR(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FOR"

    // $ANTLR start "WHILE"
    public void mWHILE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHILE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:392:7: ( W H I L E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:392:9: W H I L E
            {
            	mW(); 
            	mH(); 
            	mI(); 
            	mL(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHILE"

    // $ANTLR start "STRING"
    public void mSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:393:8: ( S T R I N G )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:393:11: S T R I N G
            {
            	mS(); 
            	mT(); 
            	mR(); 
            	mI(); 
            	mN(); 
            	mG(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "OPEN"
    public void mOPEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:394:7: ( O P E N )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:394:9: O P E N
            {
            	mO(); 
            	mP(); 
            	mE(); 
            	mN(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPEN"

    // $ANTLR start "INTEGER"
    public void mINTEGER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INTEGER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:395:9: ( I N T E G E R )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:395:11: I N T E G E R
            {
            	mI(); 
            	mN(); 
            	mT(); 
            	mE(); 
            	mG(); 
            	mE(); 
            	mR(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INTEGER"

    // $ANTLR start "DATETYPE"
    public void mDATETYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DATETYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:397:9: ( D A T E T Y P E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:397:12: D A T E T Y P E
            {
            	mD(); 
            	mA(); 
            	mT(); 
            	mE(); 
            	mT(); 
            	mY(); 
            	mP(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DATETYPE"

    // $ANTLR start "TIMETYPE"
    public void mTIMETYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TIMETYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:398:9: ( T I M E T Y P E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:398:12: T I M E T Y P E
            {
            	mT(); 
            	mI(); 
            	mM(); 
            	mE(); 
            	mT(); 
            	mY(); 
            	mP(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TIMETYPE"

    // $ANTLR start "ARRAY"
    public void mARRAY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ARRAY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:399:6: ( A R R A Y )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:399:9: A R R A Y
            {
            	mA(); 
            	mR(); 
            	mR(); 
            	mA(); 
            	mY(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ARRAY"

    // $ANTLR start "INCLUDE"
    public void mINCLUDE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INCLUDE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:401:9: ( I N C L U D E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:401:11: I N C L U D E
            {
            	mI(); 
            	mN(); 
            	mC(); 
            	mL(); 
            	mU(); 
            	mD(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INCLUDE"

    // $ANTLR start "SIGNAL"
    public void mSIGNAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SIGNAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:404:8: ( S I G N A L )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:404:10: S I G N A L
            {
            	mS(); 
            	mI(); 
            	mG(); 
            	mN(); 
            	mA(); 
            	mL(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SIGNAL"

    // $ANTLR start "CHECK"
    public void mCHECK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CHECK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:405:7: ( C H E C K )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:405:9: C H E C K
            {
            	mC(); 
            	mH(); 
            	mE(); 
            	mC(); 
            	mK(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHECK"

    // $ANTLR start "PARAMETERS"
    public void mPARAMETERS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PARAMETERS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:407:11: ( P A R A M E T E R S )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:407:13: P A R A M E T E R S
            {
            	mP(); 
            	mA(); 
            	mR(); 
            	mA(); 
            	mM(); 
            	mE(); 
            	mT(); 
            	mE(); 
            	mR(); 
            	mS(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PARAMETERS"

    // $ANTLR start "EXTERNALS"
    public void mEXTERNALS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EXTERNALS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:408:10: ( E X T E R N A L S )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:408:12: E X T E R N A L S
            {
            	mE(); 
            	mX(); 
            	mT(); 
            	mE(); 
            	mR(); 
            	mN(); 
            	mA(); 
            	mL(); 
            	mS(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EXTERNALS"

    // $ANTLR start "LIBRARIES"
    public void mLIBRARIES() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LIBRARIES;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:409:11: ( L I B R A R I E S )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:409:14: L I B R A R I E S
            {
            	mL(); 
            	mI(); 
            	mB(); 
            	mR(); 
            	mA(); 
            	mR(); 
            	mI(); 
            	mE(); 
            	mS(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LIBRARIES"

    // $ANTLR start "IMPORT"
    public void mIMPORT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IMPORT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:410:8: ( I M P O R T )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:410:10: I M P O R T
            {
            	mI(); 
            	mM(); 
            	mP(); 
            	mO(); 
            	mR(); 
            	mT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IMPORT"

    // $ANTLR start "EXPORT"
    public void mEXPORT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EXPORT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:411:9: ( E X P O R T )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:411:11: E X P O R T
            {
            	mE(); 
            	mX(); 
            	mP(); 
            	mO(); 
            	mR(); 
            	mT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EXPORT"

    // $ANTLR start "TRANSIT"
    public void mTRANSIT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRANSIT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:412:9: ( T R A N S I T )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:412:11: T R A N S I T
            {
            	mT(); 
            	mR(); 
            	mA(); 
            	mN(); 
            	mS(); 
            	mI(); 
            	mT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRANSIT"

    // $ANTLR start "AUXFIELDS"
    public void mAUXFIELDS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AUXFIELDS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:413:10: ( A U X F I E L D S )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:413:12: A U X F I E L D S
            {
            	mA(); 
            	mU(); 
            	mX(); 
            	mF(); 
            	mI(); 
            	mE(); 
            	mL(); 
            	mD(); 
            	mS(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AUXFIELDS"

    // $ANTLR start "FIELDS"
    public void mFIELDS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FIELDS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:414:8: ( F I E L D S )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:414:10: F I E L D S
            {
            	mF(); 
            	mI(); 
            	mE(); 
            	mL(); 
            	mD(); 
            	mS(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FIELDS"

    // $ANTLR start "INHERIT"
    public void mINHERIT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INHERIT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:416:9: ( I N H E R I T )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:416:11: I N H E R I T
            {
            	mI(); 
            	mN(); 
            	mH(); 
            	mE(); 
            	mR(); 
            	mI(); 
            	mT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INHERIT"

    // $ANTLR start "CATI"
    public void mCATI() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CATI;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:417:6: ( C A T I )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:417:8: C A T I
            {
            	mC(); 
            	mA(); 
            	mT(); 
            	mI(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CATI"

    // $ANTLR start "CAPI"
    public void mCAPI() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CAPI;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:418:6: ( C A P I )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:418:8: C A P I
            {
            	mC(); 
            	mA(); 
            	mP(); 
            	mI(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CAPI"

    // $ANTLR start "IMGLINK"
    public void mIMGLINK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IMGLINK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:419:9: ( I M G L I N K )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:419:11: I M G L I N K
            {
            	mI(); 
            	mM(); 
            	mG(); 
            	mL(); 
            	mI(); 
            	mN(); 
            	mK(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IMGLINK"

    // $ANTLR start "EMPTY"
    public void mEMPTY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EMPTY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:422:7: ( E M P T Y )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:422:9: E M P T Y
            {
            	mE(); 
            	mM(); 
            	mP(); 
            	mT(); 
            	mY(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EMPTY"

    // $ANTLR start "NOREFUSAL"
    public void mNOREFUSAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOREFUSAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:423:11: ( N O R E F U S A L )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:423:13: N O R E F U S A L
            {
            	mN(); 
            	mO(); 
            	mR(); 
            	mE(); 
            	mF(); 
            	mU(); 
            	mS(); 
            	mA(); 
            	mL(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOREFUSAL"

    // $ANTLR start "NORF"
    public void mNORF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NORF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:424:6: ( N O R F )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:424:8: N O R F
            {
            	mN(); 
            	mO(); 
            	mR(); 
            	mF(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NORF"

    // $ANTLR start "NODONTKNOW"
    public void mNODONTKNOW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NODONTKNOW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:425:12: ( N O D O N T K N O W )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:425:14: N O D O N T K N O W
            {
            	mN(); 
            	mO(); 
            	mD(); 
            	mO(); 
            	mN(); 
            	mT(); 
            	mK(); 
            	mN(); 
            	mO(); 
            	mW(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NODONTKNOW"

    // $ANTLR start "NODK"
    public void mNODK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NODK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:426:6: ( N O D K )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:426:8: N O D K
            {
            	mN(); 
            	mO(); 
            	mD(); 
            	mK(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NODK"

    // $ANTLR start "NOEMPTY"
    public void mNOEMPTY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOEMPTY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:427:9: ( N O E M P T Y )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:427:11: N O E M P T Y
            {
            	mN(); 
            	mO(); 
            	mE(); 
            	mM(); 
            	mP(); 
            	mT(); 
            	mY(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOEMPTY"

    // $ANTLR start "REFUSAL"
    public void mREFUSAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = REFUSAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:428:9: ( R E F U S A L )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:428:11: R E F U S A L
            {
            	mR(); 
            	mE(); 
            	mF(); 
            	mU(); 
            	mS(); 
            	mA(); 
            	mL(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "REFUSAL"

    // $ANTLR start "RF"
    public void mRF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:429:4: ( R F )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:429:6: R F
            {
            	mR(); 
            	mF(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RF"

    // $ANTLR start "DONTKNOW"
    public void mDONTKNOW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DONTKNOW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:430:9: ( D O N T K N O W )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:430:11: D O N T K N O W
            {
            	mD(); 
            	mO(); 
            	mN(); 
            	mT(); 
            	mK(); 
            	mN(); 
            	mO(); 
            	mW(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DONTKNOW"

    // $ANTLR start "DK"
    public void mDK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:431:4: ( D K )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:431:6: D K
            {
            	mD(); 
            	mK(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DK"

    // $ANTLR start "ROUTER"
    public void mROUTER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ROUTER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:433:9: ( R O U T E R )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:433:11: R O U T E R
            {
            	mR(); 
            	mO(); 
            	mU(); 
            	mT(); 
            	mE(); 
            	mR(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ROUTER"

    // $ANTLR start "ALIEN"
    public void mALIEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ALIEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:434:7: ( A L I E N )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:434:9: A L I E N
            {
            	mA(); 
            	mL(); 
            	mI(); 
            	mE(); 
            	mN(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ALIEN"

    // $ANTLR start "SETTINGS"
    public void mSETTINGS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SETTINGS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:435:9: ( S E T T I N G S )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:435:11: S E T T I N G S
            {
            	mS(); 
            	mE(); 
            	mT(); 
            	mT(); 
            	mI(); 
            	mN(); 
            	mG(); 
            	mS(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SETTINGS"

    // $ANTLR start "LAYOUT"
    public void mLAYOUT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LAYOUT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:436:8: ( L A Y O U T )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:436:10: L A Y O U T
            {
            	mL(); 
            	mA(); 
            	mY(); 
            	mO(); 
            	mU(); 
            	mT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LAYOUT"

    // $ANTLR start "PRIMARY"
    public void mPRIMARY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PRIMARY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:437:9: ( P R I M A R Y )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:437:11: P R I M A R Y
            {
            	mP(); 
            	mR(); 
            	mI(); 
            	mM(); 
            	mA(); 
            	mR(); 
            	mY(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PRIMARY"

    // $ANTLR start "USES"
    public void mUSES() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = USES;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:438:6: ( U S E S )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:438:8: U S E S
            {
            	mU(); 
            	mS(); 
            	mE(); 
            	mS(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "USES"

    // $ANTLR start "LANGUAGES"
    public void mLANGUAGES() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LANGUAGES;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:439:10: ( L A N G U A G E S )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:439:12: L A N G U A G E S
            {
            	mL(); 
            	mA(); 
            	mN(); 
            	mG(); 
            	mU(); 
            	mA(); 
            	mG(); 
            	mE(); 
            	mS(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LANGUAGES"

    // $ANTLR start "ATTRIBUTES"
    public void mATTRIBUTES() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ATTRIBUTES;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:440:11: ( A T T R I B U T E S )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:440:13: A T T R I B U T E S
            {
            	mA(); 
            	mT(); 
            	mT(); 
            	mR(); 
            	mI(); 
            	mB(); 
            	mU(); 
            	mT(); 
            	mE(); 
            	mS(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ATTRIBUTES"

    // $ANTLR start "SECONDARY"
    public void mSECONDARY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SECONDARY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:441:10: ( S E C O N D A R Y )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:441:12: S E C O N D A R Y
            {
            	mS(); 
            	mE(); 
            	mC(); 
            	mO(); 
            	mN(); 
            	mD(); 
            	mA(); 
            	mR(); 
            	mY(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SECONDARY"

    // $ANTLR start "ALPHA"
    public void mALPHA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ALPHA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:442:7: ( A L P H A )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:442:9: A L P H A
            {
            	mA(); 
            	mL(); 
            	mP(); 
            	mH(); 
            	mA(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ALPHA"

    // $ANTLR start "TRIGRAM"
    public void mTRIGRAM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRIGRAM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:443:9: ( T R I G R A M )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:443:11: T R I G R A M
            {
            	mT(); 
            	mR(); 
            	mI(); 
            	mG(); 
            	mR(); 
            	mA(); 
            	mM(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRIGRAM"

    // $ANTLR start "PARALLEL"
    public void mPARALLEL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PARALLEL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:444:9: ( P A R A L L E L )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:444:11: P A R A L L E L
            {
            	mP(); 
            	mA(); 
            	mR(); 
            	mA(); 
            	mL(); 
            	mL(); 
            	mE(); 
            	mL(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PARALLEL"

    // $ANTLR start "INVOLVING"
    public void mINVOLVING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INVOLVING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:445:10: ( I N V O L V I N G )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:445:12: I N V O L V I N G
            {
            	mI(); 
            	mN(); 
            	mV(); 
            	mO(); 
            	mL(); 
            	mV(); 
            	mI(); 
            	mN(); 
            	mG(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INVOLVING"

    // $ANTLR start "KEEP"
    public void mKEEP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = KEEP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:446:6: ( K E E P )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:446:8: K E E P
            {
            	mK(); 
            	mE(); 
            	mE(); 
            	mP(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "KEEP"

    // $ANTLR start "ASK"
    public void mASK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:447:5: ( A S K )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:447:7: A S K
            {
            	mA(); 
            	mS(); 
            	mK(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASK"

    // $ANTLR start "SHOW"
    public void mSHOW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SHOW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:448:6: ( S H O W )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:448:8: S H O W
            {
            	mS(); 
            	mH(); 
            	mO(); 
            	mW(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SHOW"

    // $ANTLR start "LOOKUP"
    public void mLOOKUP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LOOKUP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:449:9: ( L O O K U P )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:449:11: L O O K U P
            {
            	mL(); 
            	mO(); 
            	mO(); 
            	mK(); 
            	mU(); 
            	mP(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LOOKUP"

    // $ANTLR start "CLASSIFY"
    public void mCLASSIFY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLASSIFY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:450:10: ( C L A S S I F Y )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:450:12: C L A S S I F Y
            {
            	mC(); 
            	mL(); 
            	mA(); 
            	mS(); 
            	mS(); 
            	mI(); 
            	mF(); 
            	mY(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLASSIFY"

    // $ANTLR start "SEARCH"
    public void mSEARCH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SEARCH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:451:9: ( S E A R C H )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:451:11: S E A R C H
            {
            	mS(); 
            	mE(); 
            	mA(); 
            	mR(); 
            	mC(); 
            	mH(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SEARCH"

    // $ANTLR start "INFOPANE"
    public void mINFOPANE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INFOPANE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:453:9: ( I N F O P A N E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:453:11: I N F O P A N E
            {
            	mI(); 
            	mN(); 
            	mF(); 
            	mO(); 
            	mP(); 
            	mA(); 
            	mN(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INFOPANE"

    // $ANTLR start "GRID"
    public void mGRID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GRID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:454:6: ( G R I D )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:454:8: G R I D
            {
            	mG(); 
            	mR(); 
            	mI(); 
            	mD(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GRID"

    // $ANTLR start "FIELDPANE"
    public void mFIELDPANE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FIELDPANE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:455:10: ( F I E L D P A N E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:455:12: F I E L D P A N E
            {
            	mF(); 
            	mI(); 
            	mE(); 
            	mL(); 
            	mD(); 
            	mP(); 
            	mA(); 
            	mN(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FIELDPANE"

    // $ANTLR start "DUMMY"
    public void mDUMMY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DUMMY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:456:7: ( D U M M Y )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:456:9: D U M M Y
            {
            	mD(); 
            	mU(); 
            	mM(); 
            	mM(); 
            	mY(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DUMMY"

    // $ANTLR start "T_NEWLINE"
    public void mT_NEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T_NEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:457:10: ( N E W L I N E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:457:12: N E W L I N E
            {
            	mN(); 
            	mE(); 
            	mW(); 
            	mL(); 
            	mI(); 
            	mN(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T_NEWLINE"

    // $ANTLR start "NEWCOLUMN"
    public void mNEWCOLUMN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWCOLUMN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:458:10: ( N E W C O L U M N )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:458:12: N E W C O L U M N
            {
            	mN(); 
            	mE(); 
            	mW(); 
            	mC(); 
            	mO(); 
            	mL(); 
            	mU(); 
            	mM(); 
            	mN(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWCOLUMN"

    // $ANTLR start "AFTER"
    public void mAFTER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AFTER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:460:7: ( A F T E R )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:460:9: A F T E R
            {
            	mA(); 
            	mF(); 
            	mT(); 
            	mE(); 
            	mR(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AFTER"

    // $ANTLR start "BEFORE"
    public void mBEFORE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BEFORE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:461:8: ( B E F O R E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:461:10: B E F O R E
            {
            	mB(); 
            	mE(); 
            	mF(); 
            	mO(); 
            	mR(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BEFORE"

    // $ANTLR start "FROM"
    public void mFROM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FROM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:462:6: ( F R O M )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:462:8: F R O M
            {
            	mF(); 
            	mR(); 
            	mO(); 
            	mM(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FROM"

    // $ANTLR start "RESERVECHECK"
    public void mRESERVECHECK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RESERVECHECK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:463:13: ( R E S E R V E C H E C K )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:463:15: R E S E R V E C H E C K
            {
            	mR(); 
            	mE(); 
            	mS(); 
            	mE(); 
            	mR(); 
            	mV(); 
            	mE(); 
            	mC(); 
            	mH(); 
            	mE(); 
            	mC(); 
            	mK(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RESERVECHECK"

    // $ANTLR start "TYPE"
    public void mTYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:464:6: ( T Y P E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:464:8: T Y P E
            {
            	mT(); 
            	mY(); 
            	mP(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TYPE"

    // $ANTLR start "LOCALS"
    public void mLOCALS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LOCALS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:465:8: ( L O C A L S )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:465:10: L O C A L S
            {
            	mL(); 
            	mO(); 
            	mC(); 
            	mA(); 
            	mL(); 
            	mS(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LOCALS"

    // $ANTLR start "VAR"
    public void mVAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:466:5: ( V A R )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:466:7: V A R
            {
            	mV(); 
            	mA(); 
            	mR(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VAR"

    // $ANTLR start "RULES"
    public void mRULES() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RULES;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:467:7: ( R U L E S )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:467:9: R U L E S
            {
            	mR(); 
            	mU(); 
            	mL(); 
            	mE(); 
            	mS(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RULES"

    // $ANTLR start "TO"
    public void mTO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:469:4: ( T O )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:469:6: T O
            {
            	mT(); 
            	mO(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TO"

    // $ANTLR start "AT"
    public void mAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:471:4: ( A T )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:471:6: A T
            {
            	mA(); 
            	mT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AT"

    // $ANTLR start "IF"
    public void mIF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:472:4: ( I F )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:472:6: I F
            {
            	mI(); 
            	mF(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IF"

    // $ANTLR start "IN"
    public void mIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:473:5: ( I N )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:473:8: I N
            {
            	mI(); 
            	mN(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IN"

    // $ANTLR start "NOT"
    public void mNOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:474:6: ( N O T )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:474:10: N O T
            {
            	mN(); 
            	mO(); 
            	mT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOT"

    // $ANTLR start "DIV"
    public void mDIV() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIV;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:475:5: ( D I V )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:475:7: D I V
            {
            	mD(); 
            	mI(); 
            	mV(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIV"

    // $ANTLR start "MOD"
    public void mMOD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MOD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:476:5: ( M O D )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:476:7: M O D
            {
            	mM(); 
            	mO(); 
            	mD(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MOD"

    // $ANTLR start "AND"
    public void mAND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:477:5: ( A N D )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:477:7: A N D
            {
            	mA(); 
            	mN(); 
            	mD(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AND"

    // $ANTLR start "OR"
    public void mOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:478:4: ( O R )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:478:6: O R
            {
            	mO(); 
            	mR(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OR"

    // $ANTLR start "SET"
    public void mSET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:479:5: ( S E T )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:479:7: S E T
            {
            	mS(); 
            	mE(); 
            	mT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SET"

    // $ANTLR start "OF"
    public void mOF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:480:4: ( O F )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:480:6: O F
            {
            	mO(); 
            	mF(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OF"

    // $ANTLR start "CHAR"
    public void mCHAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CHAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:481:6: ( C H A R )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:481:8: C H A R
            {
            	mC(); 
            	mH(); 
            	mA(); 
            	mR(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHAR"

    // $ANTLR start "DO"
    public void mDO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:482:4: ( D O )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:482:6: D O
            {
            	mD(); 
            	mO(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DO"

    // $ANTLR start "POSITION"
    public void mPOSITION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = POSITION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:485:9: ( P O S I T I O N )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:485:11: P O S I T I O N
            {
            	mP(); 
            	mO(); 
            	mS(); 
            	mI(); 
            	mT(); 
            	mI(); 
            	mO(); 
            	mN(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "POSITION"

    // $ANTLR start "UPPERCASE"
    public void mUPPERCASE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UPPERCASE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:486:10: ( U P P E R C A S E )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:486:12: U P P E R C A S E
            {
            	mU(); 
            	mP(); 
            	mP(); 
            	mE(); 
            	mR(); 
            	mC(); 
            	mA(); 
            	mS(); 
            	mE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UPPERCASE"

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:508:17: ( '+' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:508:19: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PLUS"

    // $ANTLR start "MINUS"
    public void mMINUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MINUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:509:17: ( '-' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:509:19: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MINUS"

    // $ANTLR start "STAR"
    public void mSTAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:510:17: ( '*' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:510:19: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STAR"

    // $ANTLR start "SLASH"
    public void mSLASH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SLASH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:511:17: ( '/' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:511:19: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SLASH"

    // $ANTLR start "ASSIGN"
    public void mASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:512:17: ( ':=' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:512:19: ':='
            {
            	Match(":="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGN"

    // $ANTLR start "COMMA"
    public void mCOMMA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:513:17: ( ',' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:513:19: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMA"

    // $ANTLR start "SEMI"
    public void mSEMI() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SEMI;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:514:17: ( ';' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:514:19: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SEMI"

    // $ANTLR start "COLON"
    public void mCOLON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COLON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:515:17: ( ':' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:515:19: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COLON"

    // $ANTLR start "EQUAL"
    public void mEQUAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQUAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:516:17: ( '=' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:516:19: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQUAL"

    // $ANTLR start "NOT_EQUAL"
    public void mNOT_EQUAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOT_EQUAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:517:17: ( '<>' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:517:19: '<>'
            {
            	Match("<>"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOT_EQUAL"

    // $ANTLR start "LT"
    public void mLT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:518:17: ( '<' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:518:19: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LT"

    // $ANTLR start "LE"
    public void mLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:519:17: ( '<=' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:519:19: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LE"

    // $ANTLR start "GE"
    public void mGE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:520:17: ( '>=' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:520:19: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GE"

    // $ANTLR start "GT"
    public void mGT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:521:17: ( '>' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:521:19: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GT"

    // $ANTLR start "LPAREN"
    public void mLPAREN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LPAREN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:522:17: ( '(' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:522:19: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LPAREN"

    // $ANTLR start "RPAREN"
    public void mRPAREN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RPAREN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:523:17: ( ')' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:523:19: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RPAREN"

    // $ANTLR start "LBRACK"
    public void mLBRACK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBRACK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:524:17: ( '[' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:524:19: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LBRACK"

    // $ANTLR start "RBRACK"
    public void mRBRACK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBRACK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:525:17: ( ']' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:525:19: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RBRACK"

    // $ANTLR start "ATSYMB"
    public void mATSYMB() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ATSYMB;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:526:17: ( '@' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:526:19: '@'
            {
            	Match('@'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ATSYMB"

    // $ANTLR start "DOTDOT"
    public void mDOTDOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOTDOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:527:9: ( '..' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:527:11: '..'
            {
            	Match(".."); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOTDOT"

    // $ANTLR start "DOT"
    public void mDOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:528:17: ( '.' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:528:19: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOT"

    // $ANTLR start "LCURLY"
    public void mLCURLY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LCURLY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:529:17: ( '{' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:529:19: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LCURLY"

    // $ANTLR start "RCURLY"
    public void mRCURLY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RCURLY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:530:17: ( '}' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:530:19: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RCURLY"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:539:5: ( ( '0' .. '9' )+ )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:539:7: ( '0' .. '9' )+
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:539:7: ( '0' .. '9' )+
            	int cnt5 = 0;
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:539:8: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt5 >= 1 ) goto loop5;
            		            EarlyExitException eee5 =
            		                new EarlyExitException(5, input);
            		            throw eee5;
            	    }
            	    cnt5++;
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "LETTER"
    public void mLETTER() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:544:18: ( '\\u0041' .. '\\u005a' | '\\u005f' | '\\u0061' .. '\\u007a' | '\\u00c0' .. '\\u00d6' | '\\u00d8' .. '\\u00f6' | '\\u00f8' .. '\\u00ff' | '\\u0100' .. '\\u1fff' | '\\u3040' .. '\\u318f' | '\\u3300' .. '\\u337f' | '\\u3400' .. '\\u3d2d' | '\\u4e00' .. '\\u9fff' | '\\uf900' .. '\\ufaff' | '&' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:
            {
            	if ( input.LA(1) == '&' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u00C0' && input.LA(1) <= '\u00D6') || (input.LA(1) >= '\u00D8' && input.LA(1) <= '\u00F6') || (input.LA(1) >= '\u00F8' && input.LA(1) <= '\u1FFF') || (input.LA(1) >= '\u3040' && input.LA(1) <= '\u318F') || (input.LA(1) >= '\u3300' && input.LA(1) <= '\u337F') || (input.LA(1) >= '\u3400' && input.LA(1) <= '\u3D2D') || (input.LA(1) >= '\u4E00' && input.LA(1) <= '\u9FFF') || (input.LA(1) >= '\uF900' && input.LA(1) <= '\uFAFF') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "LETTER"

    // $ANTLR start "QSTRING"
    public void mQSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = QSTRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:565:8: ( '\"' ( '\\\\\"\\\\\"' | ~ ( '\"' ) )* '\"' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:565:10: '\"' ( '\\\\\"\\\\\"' | ~ ( '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:565:14: ( '\\\\\"\\\\\"' | ~ ( '\"' ) )*
            	do 
            	{
            	    int alt6 = 3;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == '\\') )
            	    {
            	        int LA6_2 = input.LA(2);

            	        if ( (LA6_2 == '\"') )
            	        {
            	            int LA6_4 = input.LA(3);

            	            if ( (LA6_4 == '\\') )
            	            {
            	                alt6 = 1;
            	            }

            	            else 
            	            {
            	                alt6 = 2;
            	            }

            	        }
            	        else if ( ((LA6_2 >= '\u0000' && LA6_2 <= '!') || (LA6_2 >= '#' && LA6_2 <= '\uFFFF')) )
            	        {
            	            alt6 = 2;
            	        }


            	    }
            	    else if ( ((LA6_0 >= '\u0000' && LA6_0 <= '!') || (LA6_0 >= '#' && LA6_0 <= '[') || (LA6_0 >= ']' && LA6_0 <= '\uFFFF')) )
            	    {
            	        alt6 = 2;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:565:15: '\\\\\"\\\\\"'
            			    {
            			    	Match("\\\"\\\""); 


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:565:26: ~ ( '\"' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "QSTRING"

    // $ANTLR start "SQSTRING"
    public void mSQSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SQSTRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:566:9: ( '\\'' ( SQUOTE SQUOTE | ~ ( '\\'' ) )* '\\'' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:566:11: '\\'' ( SQUOTE SQUOTE | ~ ( '\\'' ) )* '\\''
            {
            	Match('\''); 
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:566:16: ( SQUOTE SQUOTE | ~ ( '\\'' ) )*
            	do 
            	{
            	    int alt7 = 3;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == '\'') )
            	    {
            	        int LA7_1 = input.LA(2);

            	        if ( (LA7_1 == '\'') )
            	        {
            	            alt7 = 1;
            	        }


            	    }
            	    else if ( ((LA7_0 >= '\u0000' && LA7_0 <= '&') || (LA7_0 >= '(' && LA7_0 <= '\uFFFF')) )
            	    {
            	        alt7 = 2;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:566:17: SQUOTE SQUOTE
            			    {
            			    	mSQUOTE(); 
            			    	mSQUOTE(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:566:33: ~ ( '\\'' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	Match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SQSTRING"

    // $ANTLR start "SQUOTE"
    public void mSQUOTE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SQUOTE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:568:9: ( '\\'' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:568:11: '\\''
            {
            	Match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SQUOTE"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:569:4: ( ( LETTER ) ( LETTER | '0' .. '9' )* )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:569:6: ( LETTER ) ( LETTER | '0' .. '9' )*
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:569:6: ( LETTER )
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:569:7: LETTER
            	{
            		mLETTER(); 

            	}

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:569:15: ( LETTER | '0' .. '9' )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == '&' || (LA8_0 >= '0' && LA8_0 <= '9') || (LA8_0 >= 'A' && LA8_0 <= 'Z') || LA8_0 == '_' || (LA8_0 >= 'a' && LA8_0 <= 'z') || (LA8_0 >= '\u00C0' && LA8_0 <= '\u00D6') || (LA8_0 >= '\u00D8' && LA8_0 <= '\u00F6') || (LA8_0 >= '\u00F8' && LA8_0 <= '\u1FFF') || (LA8_0 >= '\u3040' && LA8_0 <= '\u318F') || (LA8_0 >= '\u3300' && LA8_0 <= '\u337F') || (LA8_0 >= '\u3400' && LA8_0 <= '\u3D2D') || (LA8_0 >= '\u4E00' && LA8_0 <= '\u9FFF') || (LA8_0 >= '\uF900' && LA8_0 <= '\uFAFF')) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:
            			    {
            			    	if ( input.LA(1) == '&' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u00C0' && input.LA(1) <= '\u00D6') || (input.LA(1) >= '\u00D8' && input.LA(1) <= '\u00F6') || (input.LA(1) >= '\u00F8' && input.LA(1) <= '\u1FFF') || (input.LA(1) >= '\u3040' && input.LA(1) <= '\u318F') || (input.LA(1) >= '\u3300' && input.LA(1) <= '\u337F') || (input.LA(1) >= '\u3400' && input.LA(1) <= '\u3D2D') || (input.LA(1) >= '\u4E00' && input.LA(1) <= '\u9FFF') || (input.LA(1) >= '\uF900' && input.LA(1) <= '\uFAFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:8: ( T__214 | INCLUDE_FILE | COMMENT | WS | NEWPAGE | DATAMODEL | ENDMODEL | ENDIF | ENDWHILE | ENDDO | ENDTABLE | ENDBLOCK | ENDPROCEDURE | PROCEDURE | END | ELSEIF | ELSE | ERROR | CASE | ENDCASE | TABLE | THEN | BLOCK | EMBEDDED | FOR | WHILE | STRING | OPEN | INTEGER | DATETYPE | TIMETYPE | ARRAY | INCLUDE | SIGNAL | CHECK | PARAMETERS | EXTERNALS | LIBRARIES | IMPORT | EXPORT | TRANSIT | AUXFIELDS | FIELDS | INHERIT | CATI | CAPI | IMGLINK | EMPTY | NOREFUSAL | NORF | NODONTKNOW | NODK | NOEMPTY | REFUSAL | RF | DONTKNOW | DK | ROUTER | ALIEN | SETTINGS | LAYOUT | PRIMARY | USES | LANGUAGES | ATTRIBUTES | SECONDARY | ALPHA | TRIGRAM | PARALLEL | INVOLVING | KEEP | ASK | SHOW | LOOKUP | CLASSIFY | SEARCH | INFOPANE | GRID | FIELDPANE | DUMMY | T_NEWLINE | NEWCOLUMN | AFTER | BEFORE | FROM | RESERVECHECK | TYPE | LOCALS | VAR | RULES | TO | AT | IF | IN | NOT | DIV | MOD | AND | OR | SET | OF | CHAR | DO | POSITION | UPPERCASE | PLUS | MINUS | STAR | SLASH | ASSIGN | COMMA | SEMI | COLON | EQUAL | NOT_EQUAL | LT | LE | GE | GT | LPAREN | RPAREN | LBRACK | RBRACK | ATSYMB | DOTDOT | DOT | LCURLY | RCURLY | INT | QSTRING | SQSTRING | SQUOTE | ID )
        int alt9 = 133;
        alt9 = dfa9.Predict(input);
        switch (alt9) 
        {
            case 1 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:10: T__214
                {
                	mT__214(); 

                }
                break;
            case 2 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:17: INCLUDE_FILE
                {
                	mINCLUDE_FILE(); 

                }
                break;
            case 3 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:30: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 4 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:38: WS
                {
                	mWS(); 

                }
                break;
            case 5 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:41: NEWPAGE
                {
                	mNEWPAGE(); 

                }
                break;
            case 6 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:49: DATAMODEL
                {
                	mDATAMODEL(); 

                }
                break;
            case 7 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:59: ENDMODEL
                {
                	mENDMODEL(); 

                }
                break;
            case 8 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:68: ENDIF
                {
                	mENDIF(); 

                }
                break;
            case 9 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:74: ENDWHILE
                {
                	mENDWHILE(); 

                }
                break;
            case 10 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:83: ENDDO
                {
                	mENDDO(); 

                }
                break;
            case 11 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:89: ENDTABLE
                {
                	mENDTABLE(); 

                }
                break;
            case 12 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:98: ENDBLOCK
                {
                	mENDBLOCK(); 

                }
                break;
            case 13 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:107: ENDPROCEDURE
                {
                	mENDPROCEDURE(); 

                }
                break;
            case 14 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:120: PROCEDURE
                {
                	mPROCEDURE(); 

                }
                break;
            case 15 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:130: END
                {
                	mEND(); 

                }
                break;
            case 16 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:134: ELSEIF
                {
                	mELSEIF(); 

                }
                break;
            case 17 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:141: ELSE
                {
                	mELSE(); 

                }
                break;
            case 18 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:146: ERROR
                {
                	mERROR(); 

                }
                break;
            case 19 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:152: CASE
                {
                	mCASE(); 

                }
                break;
            case 20 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:157: ENDCASE
                {
                	mENDCASE(); 

                }
                break;
            case 21 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:165: TABLE
                {
                	mTABLE(); 

                }
                break;
            case 22 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:171: THEN
                {
                	mTHEN(); 

                }
                break;
            case 23 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:176: BLOCK
                {
                	mBLOCK(); 

                }
                break;
            case 24 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:182: EMBEDDED
                {
                	mEMBEDDED(); 

                }
                break;
            case 25 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:191: FOR
                {
                	mFOR(); 

                }
                break;
            case 26 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:195: WHILE
                {
                	mWHILE(); 

                }
                break;
            case 27 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:201: STRING
                {
                	mSTRING(); 

                }
                break;
            case 28 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:208: OPEN
                {
                	mOPEN(); 

                }
                break;
            case 29 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:213: INTEGER
                {
                	mINTEGER(); 

                }
                break;
            case 30 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:221: DATETYPE
                {
                	mDATETYPE(); 

                }
                break;
            case 31 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:230: TIMETYPE
                {
                	mTIMETYPE(); 

                }
                break;
            case 32 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:239: ARRAY
                {
                	mARRAY(); 

                }
                break;
            case 33 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:245: INCLUDE
                {
                	mINCLUDE(); 

                }
                break;
            case 34 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:253: SIGNAL
                {
                	mSIGNAL(); 

                }
                break;
            case 35 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:260: CHECK
                {
                	mCHECK(); 

                }
                break;
            case 36 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:266: PARAMETERS
                {
                	mPARAMETERS(); 

                }
                break;
            case 37 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:277: EXTERNALS
                {
                	mEXTERNALS(); 

                }
                break;
            case 38 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:287: LIBRARIES
                {
                	mLIBRARIES(); 

                }
                break;
            case 39 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:297: IMPORT
                {
                	mIMPORT(); 

                }
                break;
            case 40 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:304: EXPORT
                {
                	mEXPORT(); 

                }
                break;
            case 41 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:311: TRANSIT
                {
                	mTRANSIT(); 

                }
                break;
            case 42 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:319: AUXFIELDS
                {
                	mAUXFIELDS(); 

                }
                break;
            case 43 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:329: FIELDS
                {
                	mFIELDS(); 

                }
                break;
            case 44 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:336: INHERIT
                {
                	mINHERIT(); 

                }
                break;
            case 45 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:344: CATI
                {
                	mCATI(); 

                }
                break;
            case 46 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:349: CAPI
                {
                	mCAPI(); 

                }
                break;
            case 47 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:354: IMGLINK
                {
                	mIMGLINK(); 

                }
                break;
            case 48 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:362: EMPTY
                {
                	mEMPTY(); 

                }
                break;
            case 49 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:368: NOREFUSAL
                {
                	mNOREFUSAL(); 

                }
                break;
            case 50 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:378: NORF
                {
                	mNORF(); 

                }
                break;
            case 51 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:383: NODONTKNOW
                {
                	mNODONTKNOW(); 

                }
                break;
            case 52 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:394: NODK
                {
                	mNODK(); 

                }
                break;
            case 53 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:399: NOEMPTY
                {
                	mNOEMPTY(); 

                }
                break;
            case 54 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:407: REFUSAL
                {
                	mREFUSAL(); 

                }
                break;
            case 55 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:415: RF
                {
                	mRF(); 

                }
                break;
            case 56 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:418: DONTKNOW
                {
                	mDONTKNOW(); 

                }
                break;
            case 57 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:427: DK
                {
                	mDK(); 

                }
                break;
            case 58 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:430: ROUTER
                {
                	mROUTER(); 

                }
                break;
            case 59 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:437: ALIEN
                {
                	mALIEN(); 

                }
                break;
            case 60 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:443: SETTINGS
                {
                	mSETTINGS(); 

                }
                break;
            case 61 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:452: LAYOUT
                {
                	mLAYOUT(); 

                }
                break;
            case 62 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:459: PRIMARY
                {
                	mPRIMARY(); 

                }
                break;
            case 63 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:467: USES
                {
                	mUSES(); 

                }
                break;
            case 64 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:472: LANGUAGES
                {
                	mLANGUAGES(); 

                }
                break;
            case 65 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:482: ATTRIBUTES
                {
                	mATTRIBUTES(); 

                }
                break;
            case 66 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:493: SECONDARY
                {
                	mSECONDARY(); 

                }
                break;
            case 67 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:503: ALPHA
                {
                	mALPHA(); 

                }
                break;
            case 68 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:509: TRIGRAM
                {
                	mTRIGRAM(); 

                }
                break;
            case 69 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:517: PARALLEL
                {
                	mPARALLEL(); 

                }
                break;
            case 70 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:526: INVOLVING
                {
                	mINVOLVING(); 

                }
                break;
            case 71 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:536: KEEP
                {
                	mKEEP(); 

                }
                break;
            case 72 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:541: ASK
                {
                	mASK(); 

                }
                break;
            case 73 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:545: SHOW
                {
                	mSHOW(); 

                }
                break;
            case 74 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:550: LOOKUP
                {
                	mLOOKUP(); 

                }
                break;
            case 75 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:557: CLASSIFY
                {
                	mCLASSIFY(); 

                }
                break;
            case 76 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:566: SEARCH
                {
                	mSEARCH(); 

                }
                break;
            case 77 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:573: INFOPANE
                {
                	mINFOPANE(); 

                }
                break;
            case 78 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:582: GRID
                {
                	mGRID(); 

                }
                break;
            case 79 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:587: FIELDPANE
                {
                	mFIELDPANE(); 

                }
                break;
            case 80 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:597: DUMMY
                {
                	mDUMMY(); 

                }
                break;
            case 81 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:603: T_NEWLINE
                {
                	mT_NEWLINE(); 

                }
                break;
            case 82 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:613: NEWCOLUMN
                {
                	mNEWCOLUMN(); 

                }
                break;
            case 83 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:623: AFTER
                {
                	mAFTER(); 

                }
                break;
            case 84 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:629: BEFORE
                {
                	mBEFORE(); 

                }
                break;
            case 85 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:636: FROM
                {
                	mFROM(); 

                }
                break;
            case 86 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:641: RESERVECHECK
                {
                	mRESERVECHECK(); 

                }
                break;
            case 87 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:654: TYPE
                {
                	mTYPE(); 

                }
                break;
            case 88 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:659: LOCALS
                {
                	mLOCALS(); 

                }
                break;
            case 89 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:666: VAR
                {
                	mVAR(); 

                }
                break;
            case 90 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:670: RULES
                {
                	mRULES(); 

                }
                break;
            case 91 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:676: TO
                {
                	mTO(); 

                }
                break;
            case 92 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:679: AT
                {
                	mAT(); 

                }
                break;
            case 93 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:682: IF
                {
                	mIF(); 

                }
                break;
            case 94 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:685: IN
                {
                	mIN(); 

                }
                break;
            case 95 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:688: NOT
                {
                	mNOT(); 

                }
                break;
            case 96 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:692: DIV
                {
                	mDIV(); 

                }
                break;
            case 97 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:696: MOD
                {
                	mMOD(); 

                }
                break;
            case 98 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:700: AND
                {
                	mAND(); 

                }
                break;
            case 99 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:704: OR
                {
                	mOR(); 

                }
                break;
            case 100 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:707: SET
                {
                	mSET(); 

                }
                break;
            case 101 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:711: OF
                {
                	mOF(); 

                }
                break;
            case 102 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:714: CHAR
                {
                	mCHAR(); 

                }
                break;
            case 103 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:719: DO
                {
                	mDO(); 

                }
                break;
            case 104 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:722: POSITION
                {
                	mPOSITION(); 

                }
                break;
            case 105 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:731: UPPERCASE
                {
                	mUPPERCASE(); 

                }
                break;
            case 106 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:741: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 107 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:746: MINUS
                {
                	mMINUS(); 

                }
                break;
            case 108 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:752: STAR
                {
                	mSTAR(); 

                }
                break;
            case 109 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:757: SLASH
                {
                	mSLASH(); 

                }
                break;
            case 110 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:763: ASSIGN
                {
                	mASSIGN(); 

                }
                break;
            case 111 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:770: COMMA
                {
                	mCOMMA(); 

                }
                break;
            case 112 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:776: SEMI
                {
                	mSEMI(); 

                }
                break;
            case 113 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:781: COLON
                {
                	mCOLON(); 

                }
                break;
            case 114 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:787: EQUAL
                {
                	mEQUAL(); 

                }
                break;
            case 115 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:793: NOT_EQUAL
                {
                	mNOT_EQUAL(); 

                }
                break;
            case 116 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:803: LT
                {
                	mLT(); 

                }
                break;
            case 117 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:806: LE
                {
                	mLE(); 

                }
                break;
            case 118 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:809: GE
                {
                	mGE(); 

                }
                break;
            case 119 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:812: GT
                {
                	mGT(); 

                }
                break;
            case 120 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:815: LPAREN
                {
                	mLPAREN(); 

                }
                break;
            case 121 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:822: RPAREN
                {
                	mRPAREN(); 

                }
                break;
            case 122 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:829: LBRACK
                {
                	mLBRACK(); 

                }
                break;
            case 123 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:836: RBRACK
                {
                	mRBRACK(); 

                }
                break;
            case 124 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:843: ATSYMB
                {
                	mATSYMB(); 

                }
                break;
            case 125 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:850: DOTDOT
                {
                	mDOTDOT(); 

                }
                break;
            case 126 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:857: DOT
                {
                	mDOT(); 

                }
                break;
            case 127 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:861: LCURLY
                {
                	mLCURLY(); 

                }
                break;
            case 128 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:868: RCURLY
                {
                	mRCURLY(); 

                }
                break;
            case 129 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:875: INT
                {
                	mINT(); 

                }
                break;
            case 130 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:879: QSTRING
                {
                	mQSTRING(); 

                }
                break;
            case 131 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:887: SQSTRING
                {
                	mSQSTRING(); 

                }
                break;
            case 132 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:896: SQUOTE
                {
                	mSQUOTE(); 

                }
                break;
            case 133 :
                // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1:903: ID
                {
                	mID(); 

                }
                break;

        }

    }


    protected DFA9 dfa9;
	private void InitializeCyclicDFAs()
	{
	    this.dfa9 = new DFA9(this);
	    this.dfa9.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA9_SpecialStateTransition);
	}

    const string DFA9_eotS =
        "\x01\uffff\x02\x2c\x01\x36\x01\uffff\x13\x2c\x04\uffff\x01\x6d"+
        "\x03\uffff\x01\x70\x01\x72\x05\uffff\x01\x74\x03\uffff\x01\x75\x01"+
        "\uffff\x03\x2c\x01\x7b\x02\x2c\x01\x7f\x01\u0085\x02\uffff\x03\x2c"+
        "\x01\u008c\x01\x2c\x01\u008f\x0c\x2c\x01\u00a2\x10\x2c\x01\u00b6"+
        "\x01\u00b7\x05\x2c\x01\u00be\x0a\x2c\x0b\uffff\x04\x2c\x01\uffff"+
        "\x03\x2c\x01\uffff\x05\x2c\x01\uffff\x02\x2c\x01\u00dc\x02\x2c\x01"+
        "\u00e1\x01\uffff\x02\x2c\x01\uffff\x01\x2c\x01\u00e6\x10\x2c\x01"+
        "\uffff\x08\x2c\x01\u0107\x05\x2c\x01\u010d\x04\x2c\x02\uffff\x03"+
        "\x2c\x01\u0116\x02\x2c\x01\uffff\x01\x2c\x01\u011a\x09\x2c\x01\u0124"+
        "\x01\u0125\x01\u0126\x0b\x2c\x01\u0132\x01\x2c\x01\u0134\x01\x2c"+
        "\x01\uffff\x04\x2c\x01\uffff\x04\x2c\x01\uffff\x0a\x2c\x01\u0148"+
        "\x07\x2c\x01\u0152\x02\x2c\x01\u0155\x01\u0156\x01\u0157\x02\x2c"+
        "\x01\u015a\x01\u015b\x04\x2c\x01\uffff\x01\u0160\x04\x2c\x01\uffff"+
        "\x01\x2c\x01\u0166\x02\x2c\x01\u0169\x03\x2c\x01\uffff\x03\x2c\x01"+
        "\uffff\x06\x2c\x01\u0176\x01\u0177\x01\u0178\x03\uffff\x03\x2c\x01"+
        "\u017c\x07\x2c\x01\uffff\x01\x2c\x01\uffff\x08\x2c\x01\u018d\x03"+
        "\x2c\x01\u0191\x01\x2c\x01\u0193\x03\x2c\x01\u0197\x01\uffff\x03"+
        "\x2c\x01\u019b\x05\x2c\x01\uffff\x01\u01a1\x01\x2c\x03\uffff\x02"+
        "\x2c\x02\uffff\x01\x2c\x01\u01a6\x01\u01a7\x01\x2c\x01\uffff\x01"+
        "\x2c\x01\u01ab\x03\x2c\x01\uffff\x02\x2c\x01\uffff\x01\x2c\x01\u01b2"+
        "\x01\u01b3\x01\u01b4\x01\u01b5\x07\x2c\x03\uffff\x02\x2c\x01\u01bf"+
        "\x01\uffff\x01\x2c\x01\u01c1\x0e\x2c\x01\uffff\x03\x2c\x01\uffff"+
        "\x01\x2c\x01\uffff\x03\x2c\x01\uffff\x01\u01d7\x01\u01d8\x01\x2c"+
        "\x01\uffff\x05\x2c\x01\uffff\x04\x2c\x02\uffff\x01\u01e3\x01\x2c"+
        "\x01\u01e5\x01\uffff\x01\u01e6\x02\x2c\x01\u01e9\x01\u01ea\x01\x2c"+
        "\x04\uffff\x01\x2c\x01\u01ed\x01\u01ee\x02\x2c\x01\u01f1\x02\x2c"+
        "\x01\u01f4\x01\uffff\x01\u01f5\x01\uffff\x01\x2c\x01\u01f7\x01\x2c"+
        "\x01\u01f9\x01\u01fa\x02\x2c\x01\u01fe\x01\u01ff\x01\u0200\x09\x2c"+
        "\x01\u020a\x01\x2c\x02\uffff\x05\x2c\x01\u0211\x01\x2c\x01\u0213"+
        "\x01\u0214\x01\x2c\x01\uffff\x01\x2c\x02\uffff\x02\x2c\x02\uffff"+
        "\x02\x2c\x02\uffff\x02\x2c\x01\uffff\x02\x2c\x02\uffff\x01\u021f"+
        "\x01\uffff\x01\x2c\x03\uffff\x02\x2c\x03\uffff\x01\x2c\x01\u0224"+
        "\x01\u0225\x01\x2c\x01\u0227\x01\u0228\x01\u0229\x01\x2c\x01\u022b"+
        "\x01\uffff\x01\u022c\x01\x2c\x01\u022e\x01\x2c\x01\u0230\x01\x2c"+
        "\x01\uffff\x01\u0232\x02\uffff\x01\u0233\x02\x2c\x01\u0236\x06\x2c"+
        "\x01\uffff\x01\u023d\x01\x2c\x01\u023f\x01\u0240\x02\uffff\x01\u0241"+
        "\x03\uffff\x01\x2c\x02\uffff\x01\u0243\x01\uffff\x01\x2c\x01\uffff"+
        "\x01\u0245\x02\uffff\x01\u0246\x01\u0247\x01\uffff\x01\u0248\x01"+
        "\x2c\x01\u024a\x01\u024b\x01\u024c\x01\x2c\x01\uffff\x01\u024e\x03"+
        "\uffff\x01\x2c\x01\uffff\x01\u0250\x04\uffff\x01\u0251\x03\uffff"+
        "\x01\x2c\x01\uffff\x01\x2c\x02\uffff\x01\u0254\x01\u0255\x02\uffff";
    const string DFA9_eofS =
        "\u0256\uffff";
    const string DFA9_minS =
        "\x01\x09\x01\x45\x01\x46\x01\x00\x01\uffff\x01\x45\x01\x41\x01"+
        "\x4c\x03\x41\x01\x45\x01\x49\x01\x48\x01\x45\x02\x46\x01\x41\x01"+
        "\x45\x01\x50\x01\x45\x01\x52\x01\x41\x01\x4f\x04\uffff\x01\x3d\x03"+
        "\uffff\x02\x3d\x05\uffff\x01\x2e\x03\uffff\x01\x00\x01\uffff\x01"+
        "\x41\x01\x55\x01\x46\x01\x26\x01\x4c\x01\x47\x02\x26\x02\uffff\x01"+
        "\x44\x01\x57\x01\x56\x01\x26\x01\x54\x01\x26\x01\x4d\x01\x44\x01"+
        "\x42\x01\x53\x01\x50\x02\x52\x01\x53\x01\x49\x02\x41\x01\x50\x01"+
        "\x26\x01\x41\x01\x45\x01\x50\x01\x4d\x01\x42\x01\x4f\x01\x46\x01"+
        "\x52\x01\x4f\x01\x45\x01\x49\x01\x41\x01\x4f\x01\x52\x01\x47\x01"+
        "\x45\x02\x26\x01\x58\x01\x49\x01\x44\x01\x52\x01\x54\x01\x26\x01"+
        "\x4b\x01\x43\x01\x42\x01\x4e\x01\x50\x02\x45\x01\x49\x01\x52\x01"+
        "\x44\x0b\uffff\x01\x4c\x01\x45\x01\x55\x01\x54\x01\uffff\x01\x45"+
        "\x01\x4c\x01\x4f\x01\uffff\x01\x4f\x01\x45\x01\x4f\x01\x45\x01\x4c"+
        "\x01\uffff\x01\x4b\x01\x45\x01\x26\x01\x4d\x01\x43\x01\x26\x01\uffff"+
        "\x01\x54\x01\x41\x01\uffff\x01\x4d\x01\x26\x01\x45\x01\x54\x01\x45"+
        "\x01\x4f\x01\x45\x01\x4f\x01\x41\x01\x49\x01\x43\x01\x4d\x01\x52"+
        "\x01\x43\x01\x53\x02\x49\x01\x45\x01\uffff\x01\x4e\x01\x47\x01\x4e"+
        "\x02\x45\x01\x4c\x01\x43\x01\x4f\x01\x26\x01\x4d\x02\x4c\x01\x52"+
        "\x01\x4f\x01\x26\x01\x57\x01\x49\x02\x4e\x02\uffff\x01\x46\x01\x45"+
        "\x01\x48\x01\x26\x01\x41\x01\x45\x01\uffff\x01\x52\x01\x26\x01\x41"+
        "\x01\x4b\x01\x52\x01\x47\x01\x4f\x01\x45\x01\x53\x01\x50\x01\x44"+
        "\x03\x26\x01\x52\x01\x53\x01\x45\x01\x53\x01\x49\x01\x52\x01\x50"+
        "\x01\x52\x01\x4c\x01\x47\x01\x55\x01\x26\x01\x4e\x01\x26\x01\x46"+
        "\x01\uffff\x01\x50\x01\x41\x01\x49\x01\x4f\x01\uffff\x01\x4b\x01"+
        "\x54\x01\x4d\x01\x59\x01\uffff\x01\x4f\x01\x48\x01\x4c\x01\x46\x01"+
        "\x52\x01\x4f\x02\x41\x01\x44\x01\x59\x01\x26\x03\x52\x01\x4c\x01"+
        "\x54\x01\x45\x01\x41\x01\x26\x01\x4b\x01\x53\x03\x26\x01\x53\x01"+
        "\x52\x02\x26\x01\x54\x01\x45\x01\x4b\x01\x52\x01\uffff\x01\x26\x01"+
        "\x44\x01\x45\x01\x43\x01\x4e\x01\uffff\x01\x49\x01\x26\x01\x4e\x01"+
        "\x41\x01\x26\x01\x49\x01\x4e\x01\x41\x01\uffff\x01\x59\x01\x52\x01"+
        "\x49\x01\uffff\x01\x4c\x01\x55\x01\x41\x02\x55\x01\x52\x03\x26\x03"+
        "\uffff\x01\x56\x01\x41\x01\x52\x01\x26\x01\x4e\x01\x54\x01\x41\x01"+
        "\x49\x01\x56\x01\x45\x01\x44\x01\uffff\x01\x54\x01\uffff\x01\x55"+
        "\x01\x54\x01\x47\x01\x4e\x01\x4c\x01\x4e\x01\x59\x01\x4f\x01\x26"+
        "\x01\x44\x01\x49\x01\x4f\x01\x26\x01\x4f\x01\x26\x01\x42\x01\x53"+
        "\x01\x44\x01\x26\x01\uffff\x01\x46\x01\x54\x01\x4e\x01\x26\x01\x4c"+
        "\x01\x45\x01\x49\x01\x44\x01\x52\x01\uffff\x01\x26\x01\x49\x03\uffff"+
        "\x01\x49\x01\x41\x02\uffff\x01\x59\x02\x26\x01\x45\x01\uffff\x01"+
        "\x50\x01\x26\x01\x48\x01\x44\x01\x4e\x01\uffff\x01\x47\x01\x4c\x01"+
        "\uffff\x01\x45\x04\x26\x01\x42\x01\x53\x01\x50\x01\x52\x01\x41\x01"+
        "\x54\x01\x43\x03\uffff\x01\x45\x01\x4c\x01\x26\x01\uffff\x01\x4b"+
        "\x01\x26\x01\x4e\x01\x54\x01\x49\x01\x52\x01\x45\x01\x4b\x01\x53"+
        "\x01\x59\x02\x45\x01\x55\x01\x4f\x01\x50\x01\x44\x01\uffff\x01\x45"+
        "\x01\x4c\x01\x43\x01\uffff\x01\x43\x01\uffff\x01\x4c\x02\x45\x01"+
        "\uffff\x02\x26\x01\x41\x01\uffff\x01\x45\x01\x54\x01\x4f\x01\x55"+
        "\x01\x59\x01\uffff\x01\x46\x01\x54\x01\x4d\x01\x50\x02\uffff\x01"+
        "\x26\x01\x41\x01\x26\x01\uffff\x01\x26\x01\x41\x01\x47\x02\x26\x01"+
        "\x4c\x04\uffff\x01\x55\x02\x26\x01\x49\x01\x47\x01\x26\x01\x41\x01"+
        "\x43\x01\x26\x01\uffff\x01\x26\x01\uffff\x01\x45\x01\x26\x01\x4e"+
        "\x01\x26\x01\x09\x01\x4e\x01\x41\x03\x26\x01\x4d\x01\x57\x02\x45"+
        "\x01\x4c\x01\x45\x01\x4b\x02\x45\x01\x26\x01\x44\x02\uffff\x02\x4c"+
        "\x01\x45\x01\x4e\x01\x52\x01\x26\x01\x59\x02\x26\x01\x45\x01\uffff"+
        "\x01\x4e\x02\uffff\x01\x52\x01\x53\x02\uffff\x01\x44\x01\x54\x02"+
        "\uffff\x02\x45\x01\uffff\x01\x53\x01\x48\x02\uffff\x01\x26\x01\uffff"+
        "\x01\x47\x03\uffff\x01\x4f\x01\x4c\x03\uffff\x01\x4e\x02\x26\x01"+
        "\x4c\x03\x26\x01\x44\x01\x26\x01\uffff\x01\x26\x01\x53\x01\x26\x01"+
        "\x52\x01\x26\x01\x45\x01\uffff\x01\x26\x02\uffff\x01\x26\x01\x45"+
        "\x01\x59\x01\x26\x01\x53\x01\x45\x02\x53\x02\x45\x01\uffff\x01\x26"+
        "\x01\x57\x02\x26\x02\uffff\x01\x26\x03\uffff\x01\x55\x02\uffff\x01"+
        "\x26\x01\uffff\x01\x53\x01\uffff\x01\x26\x02\uffff\x02\x26\x01\uffff"+
        "\x01\x26\x01\x53\x03\x26\x01\x43\x01\uffff\x01\x26\x03\uffff\x01"+
        "\x52\x01\uffff\x01\x26\x04\uffff\x01\x26\x03\uffff\x01\x4b\x01\uffff"+
        "\x01\x45\x02\uffff\x02\x26\x02\uffff";
    const string DFA9_maxS =
        "\x01\ufaff\x01\x75\x01\x6e\x01\uffff\x01\uffff\x01\x6f\x01\x75"+
        "\x01\x78\x01\x72\x01\x6c\x01\x79\x01\x6c\x01\x72\x01\x68\x01\x74"+
        "\x01\x72\x01\x75\x01\x6f\x01\x75\x01\x73\x01\x65\x01\x72\x01\x61"+
        "\x01\x6f\x04\uffff\x01\x3d\x03\uffff\x01\x3e\x01\x3d\x05\uffff\x01"+
        "\x2e\x03\uffff\x01\uffff\x01\uffff\x01\x73\x01\x75\x01\x73\x01\ufaff"+
        "\x01\x6c\x01\x70\x02\ufaff\x02\uffff\x01\x74\x01\x77\x01\x76\x01"+
        "\ufaff\x01\x74\x01\ufaff\x01\x6d\x01\x64\x01\x70\x01\x73\x01\x74"+
        "\x02\x72\x01\x73\x01\x6f\x01\x65\x01\x61\x01\x74\x01\ufaff\x01\x69"+
        "\x01\x65\x01\x70\x01\x6d\x01\x62\x01\x6f\x01\x66\x01\x72\x01\x6f"+
        "\x01\x65\x01\x69\x01\x74\x01\x6f\x01\x72\x01\x67\x01\x65\x02\ufaff"+
        "\x01\x78\x01\x70\x01\x64\x01\x72\x01\x74\x01\ufaff\x01\x6b\x01\x6f"+
        "\x01\x62\x01\x79\x01\x70\x02\x65\x01\x69\x01\x72\x01\x64\x0b\uffff"+
        "\x01\x4c\x01\x65\x01\x75\x01\x74\x01\uffff\x01\x65\x01\x6c\x01\x6f"+
        "\x01\uffff\x01\x6f\x01\x65\x01\x6f\x01\x65\x01\x6c\x01\uffff\x01"+
        "\x6f\x01\x66\x01\ufaff\x01\x6d\x01\x70\x01\ufaff\x01\uffff\x01\x74"+
        "\x01\x65\x01\uffff\x01\x6d\x01\ufaff\x01\x65\x01\x74\x01\x65\x01"+
        "\x6f\x01\x65\x01\x6f\x01\x61\x01\x69\x01\x63\x01\x6d\x01\x72\x01"+
        "\x63\x01\x73\x02\x69\x01\x65\x01\uffff\x01\x6e\x01\x67\x01\x6e\x02"+
        "\x65\x01\x6c\x01\x63\x01\x6f\x01\ufaff\x01\x6d\x02\x6c\x01\x72\x01"+
        "\x6f\x01\ufaff\x01\x77\x01\x69\x02\x6e\x02\uffff\x01\x66\x01\x65"+
        "\x01\x68\x01\ufaff\x01\x61\x01\x65\x01\uffff\x01\x72\x01\ufaff\x01"+
        "\x61\x01\x6b\x01\x72\x01\x67\x01\x6f\x01\x65\x01\x73\x01\x70\x01"+
        "\x64\x03\ufaff\x01\x72\x01\x73\x01\x65\x01\x73\x01\x69\x01\x72\x01"+
        "\x70\x01\x72\x01\x6c\x01\x67\x01\x75\x01\ufaff\x01\x6e\x01\ufaff"+
        "\x01\x66\x01\uffff\x01\x70\x01\x61\x01\x69\x01\x6f\x01\uffff\x01"+
        "\x6b\x01\x74\x01\x6d\x01\x79\x01\uffff\x01\x6f\x01\x68\x01\x6c\x01"+
        "\x66\x01\x72\x01\x6f\x02\x61\x01\x64\x01\x79\x01\ufaff\x03\x72\x01"+
        "\x6d\x01\x74\x01\x65\x01\x61\x01\ufaff\x01\x6b\x01\x73\x03\ufaff"+
        "\x01\x73\x01\x72\x02\ufaff\x01\x74\x01\x65\x01\x6b\x01\x72\x01\uffff"+
        "\x01\ufaff\x01\x64\x01\x65\x01\x63\x01\x6e\x01\uffff\x01\x69\x01"+
        "\ufaff\x01\x6e\x01\x61\x01\ufaff\x01\x69\x01\x6e\x01\x61\x01\uffff"+
        "\x01\x79\x01\x72\x01\x69\x01\uffff\x01\x6c\x01\x75\x01\x61\x02\x75"+
        "\x01\x72\x03\ufaff\x03\uffff\x01\x76\x01\x61\x01\x72\x01\ufaff\x01"+
        "\x6e\x01\x74\x01\x61\x01\x69\x01\x76\x01\x65\x01\x64\x01\uffff\x01"+
        "\x74\x01\uffff\x01\x75\x01\x74\x01\x67\x01\x6e\x01\x6c\x01\x6e\x01"+
        "\x79\x01\x6f\x01\ufaff\x01\x64\x01\x69\x01\x6f\x01\ufaff\x01\x6f"+
        "\x01\ufaff\x01\x62\x01\x73\x01\x64\x01\ufaff\x01\uffff\x01\x66\x01"+
        "\x74\x01\x6e\x01\ufaff\x01\x6c\x01\x65\x01\x69\x01\x64\x01\x72\x01"+
        "\uffff\x01\ufaff\x01\x69\x03\uffff\x01\x69\x01\x61\x02\uffff\x01"+
        "\x79\x02\ufaff\x01\x65\x01\uffff\x01\x73\x01\ufaff\x01\x68\x01\x64"+
        "\x01\x6e\x01\uffff\x01\x67\x01\x6c\x01\uffff\x01\x65\x04\ufaff\x01"+
        "\x62\x01\x73\x01\x70\x01\x72\x01\x61\x01\x74\x01\x63\x03\uffff\x01"+
        "\x65\x01\x6c\x01\ufaff\x01\uffff\x01\x6b\x01\ufaff\x01\x6e\x01\x74"+
        "\x01\x69\x01\x72\x01\x65\x01\x6b\x01\x73\x01\x79\x02\x65\x01\x75"+
        "\x01\x6f\x01\x70\x01\x64\x01\uffff\x01\x65\x01\x6c\x01\x63\x01\uffff"+
        "\x01\x63\x01\uffff\x01\x6c\x02\x65\x01\uffff\x02\ufaff\x01\x61\x01"+
        "\uffff\x01\x65\x01\x74\x01\x6f\x01\x75\x01\x79\x01\uffff\x01\x66"+
        "\x01\x74\x01\x6d\x01\x70\x02\uffff\x01\ufaff\x01\x61\x01\ufaff\x01"+
        "\uffff\x01\ufaff\x01\x61\x01\x67\x02\ufaff\x01\x6c\x04\uffff\x01"+
        "\x75\x02\ufaff\x01\x69\x01\x67\x01\ufaff\x01\x61\x01\x63\x01\ufaff"+
        "\x01\uffff\x01\ufaff\x01\uffff\x01\x65\x01\ufaff\x01\x6e\x02\ufaff"+
        "\x01\x6e\x01\x61\x03\ufaff\x01\x6d\x01\x77\x02\x65\x01\x6c\x01\x65"+
        "\x01\x6b\x02\x65\x01\ufaff\x01\x64\x02\uffff\x02\x6c\x01\x65\x01"+
        "\x6e\x01\x72\x01\ufaff\x01\x79\x02\ufaff\x01\x65\x01\uffff\x01\x6e"+
        "\x02\uffff\x01\x72\x01\x73\x02\uffff\x01\x64\x01\x74\x02\uffff\x02"+
        "\x65\x01\uffff\x01\x73\x01\x68\x02\uffff\x01\ufaff\x01\uffff\x01"+
        "\x67\x03\uffff\x01\x6f\x01\x6c\x03\uffff\x01\x6e\x02\ufaff\x01\x6c"+
        "\x03\ufaff\x01\x64\x01\ufaff\x01\uffff\x01\ufaff\x01\x73\x01\ufaff"+
        "\x01\x72\x01\ufaff\x01\x65\x01\uffff\x01\ufaff\x02\uffff\x01\ufaff"+
        "\x01\x65\x01\x79\x01\ufaff\x01\x73\x01\x65\x02\x73\x02\x65\x01\uffff"+
        "\x01\ufaff\x01\x77\x02\ufaff\x02\uffff\x01\ufaff\x03\uffff\x01\x75"+
        "\x02\uffff\x01\ufaff\x01\uffff\x01\x73\x01\uffff\x01\ufaff\x02\uffff"+
        "\x02\ufaff\x01\uffff\x01\ufaff\x01\x73\x03\ufaff\x01\x63\x01\uffff"+
        "\x01\ufaff\x03\uffff\x01\x72\x01\uffff\x01\ufaff\x04\uffff\x01\ufaff"+
        "\x03\uffff\x01\x6b\x01\uffff\x01\x65\x02\uffff\x02\ufaff\x02\uffff";
    const string DFA9_acceptS =
        "\x04\uffff\x01\x04\x13\uffff\x01\x6a\x01\x6b\x01\x6c\x01\x6d\x01"+
        "\uffff\x01\x6f\x01\x70\x01\x72\x02\uffff\x01\x78\x01\x79\x01\x7a"+
        "\x01\x7b\x01\x7c\x01\uffff\x01\u0080\x01\u0081\x01\u0082\x01\uffff"+
        "\x01\u0085\x08\uffff\x01\x03\x01\x7f\x35\uffff\x01\x6e\x01\x71\x01"+
        "\x73\x01\x75\x01\x74\x01\x76\x01\x77\x01\x7d\x01\x7e\x01\u0084\x01"+
        "\u0083\x04\uffff\x01\x37\x03\uffff\x01\x5e\x05\uffff\x01\x5d\x06"+
        "\uffff\x01\x67\x02\uffff\x01\x39\x12\uffff\x01\x5b\x13\uffff\x01"+
        "\x65\x01\x63\x06\uffff\x01\x5c\x1d\uffff\x01\x5f\x04\uffff\x01\x60"+
        "\x04\uffff\x01\x0f\x20\uffff\x01\x19\x05\uffff\x01\x64\x08\uffff"+
        "\x01\x62\x03\uffff\x01\x48\x09\uffff\x01\x59\x01\x61\x01\x01\x0b"+
        "\uffff\x01\x34\x01\uffff\x01\x32\x13\uffff\x01\x11\x09\uffff\x01"+
        "\x66\x02\uffff\x01\x2d\x01\x2e\x01\x13\x02\uffff\x01\x16\x01\x57"+
        "\x04\uffff\x01\x55\x05\uffff\x01\x49\x02\uffff\x01\x1c\x0c\uffff"+
        "\x01\x3f\x01\x47\x01\x4e\x03\uffff\x01\x5a\x10\uffff\x01\x50\x03"+
        "\uffff\x01\x08\x01\uffff\x01\x0a\x03\uffff\x01\x30\x03\uffff\x01"+
        "\x12\x05\uffff\x01\x23\x04\uffff\x01\x15\x01\x17\x03\uffff\x01\x1a"+
        "\x06\uffff\x01\x3b\x01\x43\x01\x20\x01\x53\x09\uffff\x01\x3a\x01"+
        "\uffff\x01\x27\x15\uffff\x01\x10\x01\x28\x0a\uffff\x01\x54\x01\uffff"+
        "\x01\x2b\x01\x4c\x02\uffff\x01\x1b\x01\x22\x02\uffff\x01\x58\x01"+
        "\x4a\x02\uffff\x01\x3d\x02\uffff\x01\x36\x01\x2f\x01\uffff\x01\x2c"+
        "\x01\uffff\x01\x1d\x01\x21\x01\x02\x02\uffff\x01\x35\x01\x05\x01"+
        "\x51\x09\uffff\x01\x14\x06\uffff\x01\x3e\x01\uffff\x01\x29\x01\x44"+
        "\x0a\uffff\x01\x4d\x04\uffff\x01\x38\x01\x1e\x01\uffff\x01\x07\x01"+
        "\x09\x01\x0c\x01\uffff\x01\x0b\x01\x18\x01\uffff\x01\x45\x01\uffff"+
        "\x01\x68\x01\uffff\x01\x4b\x01\x1f\x02\uffff\x01\x3c\x06\uffff\x01"+
        "\x46\x01\uffff\x01\x31\x01\x52\x01\x06\x01\uffff\x01\x25\x01\uffff"+
        "\x01\x0e\x01\x4f\x01\x42\x01\x2a\x01\uffff\x01\x26\x01\x40\x01\x69"+
        "\x01\uffff\x01\x33\x01\uffff\x01\x24\x01\x41\x02\uffff\x01\x56\x01"+
        "\x0d";
    const string DFA9_specialS =
        "\x03\uffff\x01\x00\x27\uffff\x01\x01\u022a\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x02\x04\x01\uffff\x02\x04\x12\uffff\x01\x04\x01\uffff\x01"+
            "\x2a\x03\uffff\x01\x2c\x01\x2b\x01\x22\x01\x23\x01\x1a\x01\x18"+
            "\x01\x1d\x01\x19\x01\x27\x01\x1b\x0a\x29\x01\x1c\x01\x1e\x01"+
            "\x20\x01\x1f\x01\x21\x01\uffff\x01\x26\x01\x10\x01\x0b\x01\x09"+
            "\x01\x06\x01\x07\x01\x0c\x01\x15\x01\x2c\x01\x02\x01\x2c\x01"+
            "\x14\x01\x11\x01\x17\x01\x05\x01\x0f\x01\x08\x01\x2c\x01\x01"+
            "\x01\x0e\x01\x0a\x01\x13\x01\x16\x01\x0d\x03\x2c\x01\x24\x01"+
            "\uffff\x01\x25\x01\uffff\x01\x2c\x01\uffff\x01\x10\x01\x0b\x01"+
            "\x09\x01\x06\x01\x07\x01\x0c\x01\x15\x01\x2c\x01\x02\x01\x2c"+
            "\x01\x14\x01\x11\x01\x17\x01\x05\x01\x0f\x01\x08\x01\x2c\x01"+
            "\x12\x01\x0e\x01\x0a\x01\x13\x01\x16\x01\x0d\x03\x2c\x01\x03"+
            "\x01\uffff\x01\x28\x42\uffff\x17\x2c\x01\uffff\x1f\x2c\x01\uffff"+
            "\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c\u0080"+
            "\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200\x2c",
            "\x01\x2d\x01\x30\x08\uffff\x01\x2e\x05\uffff\x01\x31\x0f\uffff"+
            "\x01\x2f\x01\x30\x08\uffff\x01\x2e\x05\uffff\x01\x31",
            "\x01\x34\x06\uffff\x01\x32\x01\x33\x17\uffff\x01\x34\x06\uffff"+
            "\x01\x32\x01\x33",
            "\x00\x35",
            "",
            "\x01\x38\x09\uffff\x01\x37\x15\uffff\x01\x38\x09\uffff\x01"+
            "\x37",
            "\x01\x3b\x07\uffff\x01\x39\x01\uffff\x01\x3c\x03\uffff\x01"+
            "\x3a\x05\uffff\x01\x3d\x0b\uffff\x01\x3b\x07\uffff\x01\x39\x01"+
            "\uffff\x01\x3c\x03\uffff\x01\x3a\x05\uffff\x01\x3d",
            "\x01\x40\x01\x3f\x01\x3e\x03\uffff\x01\x42\x05\uffff\x01\x41"+
            "\x13\uffff\x01\x40\x01\x3f\x01\x3e\x03\uffff\x01\x42\x05\uffff"+
            "\x01\x41",
            "\x01\x43\x0d\uffff\x01\x44\x02\uffff\x01\x45\x0e\uffff\x01"+
            "\x43\x0d\uffff\x01\x44\x02\uffff\x01\x45",
            "\x01\x48\x06\uffff\x01\x46\x03\uffff\x01\x47\x14\uffff\x01"+
            "\x48\x06\uffff\x01\x46\x03\uffff\x01\x47",
            "\x01\x4e\x06\uffff\x01\x4b\x01\x4d\x05\uffff\x01\x49\x02\uffff"+
            "\x01\x4a\x06\uffff\x01\x4c\x07\uffff\x01\x4e\x06\uffff\x01\x4b"+
            "\x01\x4d\x05\uffff\x01\x49\x02\uffff\x01\x4a\x06\uffff\x01\x4c",
            "\x01\x50\x06\uffff\x01\x4f\x18\uffff\x01\x50\x06\uffff\x01"+
            "\x4f",
            "\x01\x53\x05\uffff\x01\x51\x02\uffff\x01\x52\x16\uffff\x01"+
            "\x53\x05\uffff\x01\x51\x02\uffff\x01\x52",
            "\x01\x54\x1f\uffff\x01\x54",
            "\x01\x55\x02\uffff\x01\x56\x01\x58\x0a\uffff\x01\x57\x10\uffff"+
            "\x01\x55\x02\uffff\x01\x56\x01\x58\x0a\uffff\x01\x57",
            "\x01\x5a\x09\uffff\x01\x59\x01\uffff\x01\x5b\x13\uffff\x01"+
            "\x5a\x09\uffff\x01\x59\x01\uffff\x01\x5b",
            "\x01\x60\x05\uffff\x01\x5d\x01\uffff\x01\x5e\x03\uffff\x01"+
            "\x5f\x01\x62\x01\x61\x01\x5c\x10\uffff\x01\x60\x05\uffff\x01"+
            "\x5d\x01\uffff\x01\x5e\x03\uffff\x01\x5f\x01\x62\x01\x61\x01"+
            "\x5c",
            "\x01\x65\x07\uffff\x01\x64\x05\uffff\x01\x63\x11\uffff\x01"+
            "\x65\x07\uffff\x01\x64\x05\uffff\x01\x63",
            "\x01\x2f\x01\x30\x08\uffff\x01\x2e\x05\uffff\x01\x31\x0f\uffff"+
            "\x01\x2f\x01\x30\x08\uffff\x01\x2e\x05\uffff\x01\x31",
            "\x01\x66\x02\uffff\x01\x67\x1c\uffff\x01\x66\x02\uffff\x01"+
            "\x67",
            "\x01\x68\x1f\uffff\x01\x68",
            "\x01\x69\x1f\uffff\x01\x69",
            "\x01\x6a\x1f\uffff\x01\x6a",
            "\x01\x6b\x1f\uffff\x01\x6b",
            "",
            "",
            "",
            "",
            "\x01\x6c",
            "",
            "",
            "",
            "\x01\x6f\x01\x6e",
            "\x01\x71",
            "",
            "",
            "",
            "",
            "",
            "\x01\x73",
            "",
            "",
            "",
            "\x00\x76",
            "",
            "\x01\x77\x04\uffff\x01\x79\x0c\uffff\x01\x78\x12\uffff\x01"+
            "\x79\x0c\uffff\x01\x78",
            "\x01\x7a\x1f\uffff\x01\x7a",
            "\x01\x79\x0c\uffff\x01\x78\x12\uffff\x01\x79\x0c\uffff\x01"+
            "\x78",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x7c\x1f\uffff\x01\x7c",
            "\x01\x7d\x08\uffff\x01\x7e\x16\uffff\x01\x7d\x08\uffff\x01"+
            "\x7e",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x02\x2c\x01\u0084\x02"+
            "\x2c\x01\u0080\x01\x2c\x01\u0081\x0b\x2c\x01\u0083\x01\x2c\x01"+
            "\u0082\x04\x2c\x04\uffff\x01\x2c\x01\uffff\x02\x2c\x01\u0084"+
            "\x02\x2c\x01\u0080\x01\x2c\x01\u0081\x0b\x2c\x01\u0083\x01\x2c"+
            "\x01\u0082\x04\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01\uffff"+
            "\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c\u0080"+
            "\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "",
            "\x01\u0086\x01\u0089\x0c\uffff\x01\u0087\x01\uffff\x01\u0088"+
            "\x0f\uffff\x01\u0086\x01\u0089\x0c\uffff\x01\u0087\x01\uffff"+
            "\x01\u0088",
            "\x01\u008a\x1f\uffff\x01\u008a",
            "\x01\u008b\x1f\uffff\x01\u008b",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x0d\x2c\x01\u008d\x0c"+
            "\x2c\x04\uffff\x01\x2c\x01\uffff\x0d\x2c\x01\u008d\x0c\x2c\x45"+
            "\uffff\x17\x2c\x01\uffff\x1f\x2c\x01\uffff\u1f08\x2c\u1040\uffff"+
            "\u0150\x2c\u0170\uffff\u0080\x2c\u0080\uffff\u092e\x2c\u10d2"+
            "\uffff\u5200\x2c\u5900\uffff\u0200\x2c",
            "\x01\u008e\x1f\uffff\x01\u008e",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0090\x1f\uffff\x01\u0090",
            "\x01\u0091\x1f\uffff\x01\u0091",
            "\x01\u0092\x0d\uffff\x01\u0093\x11\uffff\x01\u0092\x0d\uffff"+
            "\x01\u0093",
            "\x01\u0094\x1f\uffff\x01\u0094",
            "\x01\u0095\x03\uffff\x01\u0096\x1b\uffff\x01\u0095\x03\uffff"+
            "\x01\u0096",
            "\x01\u0097\x1f\uffff\x01\u0097",
            "\x01\u0098\x1f\uffff\x01\u0098",
            "\x01\u0099\x1f\uffff\x01\u0099",
            "\x01\u009b\x05\uffff\x01\u009a\x19\uffff\x01\u009b\x05\uffff"+
            "\x01\u009a",
            "\x01\u009c\x03\uffff\x01\u009d\x1b\uffff\x01\u009c\x03\uffff"+
            "\x01\u009d",
            "\x01\u009e\x1f\uffff\x01\u009e",
            "\x01\u00a0\x02\uffff\x01\u00a1\x01\u009f\x1b\uffff\x01\u00a0"+
            "\x02\uffff\x01\u00a1\x01\u009f",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00a3\x07\uffff\x01\u00a4\x17\uffff\x01\u00a3\x07\uffff"+
            "\x01\u00a4",
            "\x01\u00a5\x1f\uffff\x01\u00a5",
            "\x01\u00a6\x1f\uffff\x01\u00a6",
            "\x01\u00a7\x1f\uffff\x01\u00a7",
            "\x01\u00a8\x1f\uffff\x01\u00a8",
            "\x01\u00a9\x1f\uffff\x01\u00a9",
            "\x01\u00aa\x1f\uffff\x01\u00aa",
            "\x01\u00ab\x1f\uffff\x01\u00ab",
            "\x01\u00ac\x1f\uffff\x01\u00ac",
            "\x01\u00ad\x1f\uffff\x01\u00ad",
            "\x01\u00ae\x1f\uffff\x01\u00ae",
            "\x01\u00af\x01\uffff\x01\u00b0\x10\uffff\x01\u00b1\x0c\uffff"+
            "\x01\u00af\x01\uffff\x01\u00b0\x10\uffff\x01\u00b1",
            "\x01\u00b2\x1f\uffff\x01\u00b2",
            "\x01\u00b3\x1f\uffff\x01\u00b3",
            "\x01\u00b4\x1f\uffff\x01\u00b4",
            "\x01\u00b5\x1f\uffff\x01\u00b5",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00b8\x1f\uffff\x01\u00b8",
            "\x01\u00b9\x06\uffff\x01\u00ba\x18\uffff\x01\u00b9\x06\uffff"+
            "\x01\u00ba",
            "\x01\u00bb\x1f\uffff\x01\u00bb",
            "\x01\u00bc\x1f\uffff\x01\u00bc",
            "\x01\u00bd\x1f\uffff\x01\u00bd",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x13\x2c\x01\u00bf\x06"+
            "\x2c\x04\uffff\x01\x2c\x01\uffff\x13\x2c\x01\u00bf\x06\x2c\x45"+
            "\uffff\x17\x2c\x01\uffff\x1f\x2c\x01\uffff\u1f08\x2c\u1040\uffff"+
            "\u0150\x2c\u0170\uffff\u0080\x2c\u0080\uffff\u092e\x2c\u10d2"+
            "\uffff\u5200\x2c\u5900\uffff\u0200\x2c",
            "\x01\u00c0\x1f\uffff\x01\u00c0",
            "\x01\u00c1\x0b\uffff\x01\u00c2\x13\uffff\x01\u00c1\x0b\uffff"+
            "\x01\u00c2",
            "\x01\u00c3\x1f\uffff\x01\u00c3",
            "\x01\u00c4\x0a\uffff\x01\u00c5\x14\uffff\x01\u00c4\x0a\uffff"+
            "\x01\u00c5",
            "\x01\u00c6\x1f\uffff\x01\u00c6",
            "\x01\u00c7\x1f\uffff\x01\u00c7",
            "\x01\u00c8\x1f\uffff\x01\u00c8",
            "\x01\u00c9\x1f\uffff\x01\u00c9",
            "\x01\u00ca\x1f\uffff\x01\u00ca",
            "\x01\u00cb\x1f\uffff\x01\u00cb",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\u00cc",
            "\x01\u00cd\x1f\uffff\x01\u00cd",
            "\x01\u00ce\x1f\uffff\x01\u00ce",
            "\x01\u00cf\x1f\uffff\x01\u00cf",
            "",
            "\x01\u00d0\x1f\uffff\x01\u00d0",
            "\x01\u00d1\x1f\uffff\x01\u00d1",
            "\x01\u00d2\x1f\uffff\x01\u00d2",
            "",
            "\x01\u00d3\x1f\uffff\x01\u00d3",
            "\x01\u00d4\x1f\uffff\x01\u00d4",
            "\x01\u00d5\x1f\uffff\x01\u00d5",
            "\x01\u00d6\x1f\uffff\x01\u00d6",
            "\x01\u00d7\x1f\uffff\x01\u00d7",
            "",
            "\x01\u00d8\x03\uffff\x01\u00d9\x1b\uffff\x01\u00d8\x03\uffff"+
            "\x01\u00d9",
            "\x01\u00db\x01\u00da\x1e\uffff\x01\u00db\x01\u00da",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00dd\x1f\uffff\x01\u00dd",
            "\x01\u00e0\x08\uffff\x01\u00df\x03\uffff\x01\u00de\x12\uffff"+
            "\x01\u00e0\x08\uffff\x01\u00df\x03\uffff\x01\u00de",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "\x01\u00e2\x1f\uffff\x01\u00e2",
            "\x01\u00e4\x03\uffff\x01\u00e3\x1b\uffff\x01\u00e4\x03\uffff"+
            "\x01\u00e3",
            "",
            "\x01\u00e5\x1f\uffff\x01\u00e5",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x01\x2c\x01\u00e9\x01"+
            "\u00ee\x01\u00ec\x04\x2c\x01\u00ea\x03\x2c\x01\u00e7\x02\x2c"+
            "\x01\u00eb\x03\x2c\x01\u00ed\x02\x2c\x01\u00e8\x03\x2c\x04\uffff"+
            "\x01\x2c\x01\uffff\x01\x2c\x01\u00e9\x01\u00ee\x01\u00ec\x04"+
            "\x2c\x01\u00ea\x03\x2c\x01\u00e7\x02\x2c\x01\u00eb\x03\x2c\x01"+
            "\u00ed\x02\x2c\x01\u00e8\x03\x2c\x45\uffff\x17\x2c\x01\uffff"+
            "\x1f\x2c\x01\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff"+
            "\u0080\x2c\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900"+
            "\uffff\u0200\x2c",
            "\x01\u00ef\x1f\uffff\x01\u00ef",
            "\x01\u00f0\x1f\uffff\x01\u00f0",
            "\x01\u00f1\x1f\uffff\x01\u00f1",
            "\x01\u00f2\x1f\uffff\x01\u00f2",
            "\x01\u00f3\x1f\uffff\x01\u00f3",
            "\x01\u00f4\x1f\uffff\x01\u00f4",
            "\x01\u00f5\x1f\uffff\x01\u00f5",
            "\x01\u00f6\x1f\uffff\x01\u00f6",
            "\x01\u00f7\x1f\uffff\x01\u00f7",
            "\x01\u00f8\x1f\uffff\x01\u00f8",
            "\x01\u00f9\x1f\uffff\x01\u00f9",
            "\x01\u00fa\x1f\uffff\x01\u00fa",
            "\x01\u00fb\x1f\uffff\x01\u00fb",
            "\x01\u00fc\x1f\uffff\x01\u00fc",
            "\x01\u00fd\x1f\uffff\x01\u00fd",
            "\x01\u00fe\x1f\uffff\x01\u00fe",
            "",
            "\x01\u00ff\x1f\uffff\x01\u00ff",
            "\x01\u0100\x1f\uffff\x01\u0100",
            "\x01\u0101\x1f\uffff\x01\u0101",
            "\x01\u0102\x1f\uffff\x01\u0102",
            "\x01\u0103\x1f\uffff\x01\u0103",
            "\x01\u0104\x1f\uffff\x01\u0104",
            "\x01\u0105\x1f\uffff\x01\u0105",
            "\x01\u0106\x1f\uffff\x01\u0106",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0108\x1f\uffff\x01\u0108",
            "\x01\u0109\x1f\uffff\x01\u0109",
            "\x01\u010a\x1f\uffff\x01\u010a",
            "\x01\u010b\x1f\uffff\x01\u010b",
            "\x01\u010c\x1f\uffff\x01\u010c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x13\x2c\x01\u010e\x06"+
            "\x2c\x04\uffff\x01\x2c\x01\uffff\x13\x2c\x01\u010e\x06\x2c\x45"+
            "\uffff\x17\x2c\x01\uffff\x1f\x2c\x01\uffff\u1f08\x2c\u1040\uffff"+
            "\u0150\x2c\u0170\uffff\u0080\x2c\u0080\uffff\u092e\x2c\u10d2"+
            "\uffff\u5200\x2c\u5900\uffff\u0200\x2c",
            "\x01\u010f\x1f\uffff\x01\u010f",
            "\x01\u0110\x1f\uffff\x01\u0110",
            "\x01\u0111\x1f\uffff\x01\u0111",
            "\x01\u0112\x1f\uffff\x01\u0112",
            "",
            "",
            "\x01\u0113\x1f\uffff\x01\u0113",
            "\x01\u0114\x1f\uffff\x01\u0114",
            "\x01\u0115\x1f\uffff\x01\u0115",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0117\x1f\uffff\x01\u0117",
            "\x01\u0118\x1f\uffff\x01\u0118",
            "",
            "\x01\u0119\x1f\uffff\x01\u0119",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u011b\x1f\uffff\x01\u011b",
            "\x01\u011c\x1f\uffff\x01\u011c",
            "\x01\u011d\x1f\uffff\x01\u011d",
            "\x01\u011e\x1f\uffff\x01\u011e",
            "\x01\u011f\x1f\uffff\x01\u011f",
            "\x01\u0120\x1f\uffff\x01\u0120",
            "\x01\u0121\x1f\uffff\x01\u0121",
            "\x01\u0122\x1f\uffff\x01\u0122",
            "\x01\u0123\x1f\uffff\x01\u0123",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0127\x1f\uffff\x01\u0127",
            "\x01\u0128\x1f\uffff\x01\u0128",
            "\x01\u0129\x1f\uffff\x01\u0129",
            "\x01\u012a\x1f\uffff\x01\u012a",
            "\x01\u012b\x1f\uffff\x01\u012b",
            "\x01\u012c\x1f\uffff\x01\u012c",
            "\x01\u012d\x1f\uffff\x01\u012d",
            "\x01\u012e\x1f\uffff\x01\u012e",
            "\x01\u012f\x1f\uffff\x01\u012f",
            "\x01\u0130\x1f\uffff\x01\u0130",
            "\x01\u0131\x1f\uffff\x01\u0131",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0133\x1f\uffff\x01\u0133",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0135\x1f\uffff\x01\u0135",
            "",
            "\x01\u0136\x1f\uffff\x01\u0136",
            "\x01\u0137\x1f\uffff\x01\u0137",
            "\x01\u0138\x1f\uffff\x01\u0138",
            "\x01\u0139\x1f\uffff\x01\u0139",
            "",
            "\x01\u013a\x1f\uffff\x01\u013a",
            "\x01\u013b\x1f\uffff\x01\u013b",
            "\x01\u013c\x1f\uffff\x01\u013c",
            "\x01\u013d\x1f\uffff\x01\u013d",
            "",
            "\x01\u013e\x1f\uffff\x01\u013e",
            "\x01\u013f\x1f\uffff\x01\u013f",
            "\x01\u0140\x1f\uffff\x01\u0140",
            "\x01\u0141\x1f\uffff\x01\u0141",
            "\x01\u0142\x1f\uffff\x01\u0142",
            "\x01\u0143\x1f\uffff\x01\u0143",
            "\x01\u0144\x1f\uffff\x01\u0144",
            "\x01\u0145\x1f\uffff\x01\u0145",
            "\x01\u0146\x1f\uffff\x01\u0146",
            "\x01\u0147\x1f\uffff\x01\u0147",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x08\x2c\x01\u0149\x11"+
            "\x2c\x04\uffff\x01\x2c\x01\uffff\x08\x2c\x01\u0149\x11\x2c\x45"+
            "\uffff\x17\x2c\x01\uffff\x1f\x2c\x01\uffff\u1f08\x2c\u1040\uffff"+
            "\u0150\x2c\u0170\uffff\u0080\x2c\u0080\uffff\u092e\x2c\u10d2"+
            "\uffff\u5200\x2c\u5900\uffff\u0200\x2c",
            "\x01\u014a\x1f\uffff\x01\u014a",
            "\x01\u014b\x1f\uffff\x01\u014b",
            "\x01\u014c\x1f\uffff\x01\u014c",
            "\x01\u014d\x01\u014e\x1e\uffff\x01\u014d\x01\u014e",
            "\x01\u014f\x1f\uffff\x01\u014f",
            "\x01\u0150\x1f\uffff\x01\u0150",
            "\x01\u0151\x1f\uffff\x01\u0151",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0153\x1f\uffff\x01\u0153",
            "\x01\u0154\x1f\uffff\x01\u0154",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0158\x1f\uffff\x01\u0158",
            "\x01\u0159\x1f\uffff\x01\u0159",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u015c\x1f\uffff\x01\u015c",
            "\x01\u015d\x1f\uffff\x01\u015d",
            "\x01\u015e\x1f\uffff\x01\u015e",
            "\x01\u015f\x1f\uffff\x01\u015f",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0161\x1f\uffff\x01\u0161",
            "\x01\u0162\x1f\uffff\x01\u0162",
            "\x01\u0163\x1f\uffff\x01\u0163",
            "\x01\u0164\x1f\uffff\x01\u0164",
            "",
            "\x01\u0165\x1f\uffff\x01\u0165",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0167\x1f\uffff\x01\u0167",
            "\x01\u0168\x1f\uffff\x01\u0168",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u016a\x1f\uffff\x01\u016a",
            "\x01\u016b\x1f\uffff\x01\u016b",
            "\x01\u016c\x1f\uffff\x01\u016c",
            "",
            "\x01\u016d\x1f\uffff\x01\u016d",
            "\x01\u016e\x1f\uffff\x01\u016e",
            "\x01\u016f\x1f\uffff\x01\u016f",
            "",
            "\x01\u0170\x1f\uffff\x01\u0170",
            "\x01\u0171\x1f\uffff\x01\u0171",
            "\x01\u0172\x1f\uffff\x01\u0172",
            "\x01\u0173\x1f\uffff\x01\u0173",
            "\x01\u0174\x1f\uffff\x01\u0174",
            "\x01\u0175\x1f\uffff\x01\u0175",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "",
            "",
            "\x01\u0179\x1f\uffff\x01\u0179",
            "\x01\u017a\x1f\uffff\x01\u017a",
            "\x01\u017b\x1f\uffff\x01\u017b",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u017d\x1f\uffff\x01\u017d",
            "\x01\u017e\x1f\uffff\x01\u017e",
            "\x01\u017f\x1f\uffff\x01\u017f",
            "\x01\u0180\x1f\uffff\x01\u0180",
            "\x01\u0181\x1f\uffff\x01\u0181",
            "\x01\u0182\x1f\uffff\x01\u0182",
            "\x01\u0183\x1f\uffff\x01\u0183",
            "",
            "\x01\u0184\x1f\uffff\x01\u0184",
            "",
            "\x01\u0185\x1f\uffff\x01\u0185",
            "\x01\u0186\x1f\uffff\x01\u0186",
            "\x01\u0187\x1f\uffff\x01\u0187",
            "\x01\u0188\x1f\uffff\x01\u0188",
            "\x01\u0189\x1f\uffff\x01\u0189",
            "\x01\u018a\x1f\uffff\x01\u018a",
            "\x01\u018b\x1f\uffff\x01\u018b",
            "\x01\u018c\x1f\uffff\x01\u018c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u018e\x1f\uffff\x01\u018e",
            "\x01\u018f\x1f\uffff\x01\u018f",
            "\x01\u0190\x1f\uffff\x01\u0190",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0192\x1f\uffff\x01\u0192",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0194\x1f\uffff\x01\u0194",
            "\x01\u0195\x1f\uffff\x01\u0195",
            "\x01\u0196\x1f\uffff\x01\u0196",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "\x01\u0198\x1f\uffff\x01\u0198",
            "\x01\u0199\x1f\uffff\x01\u0199",
            "\x01\u019a\x1f\uffff\x01\u019a",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u019c\x1f\uffff\x01\u019c",
            "\x01\u019d\x1f\uffff\x01\u019d",
            "\x01\u019e\x1f\uffff\x01\u019e",
            "\x01\u019f\x1f\uffff\x01\u019f",
            "\x01\u01a0\x1f\uffff\x01\u01a0",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u01a2\x1f\uffff\x01\u01a2",
            "",
            "",
            "",
            "\x01\u01a3\x1f\uffff\x01\u01a3",
            "\x01\u01a4\x1f\uffff\x01\u01a4",
            "",
            "",
            "\x01\u01a5\x1f\uffff\x01\u01a5",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u01a8\x1f\uffff\x01\u01a8",
            "",
            "\x01\u01a9\x02\uffff\x01\u01aa\x1c\uffff\x01\u01a9\x02\uffff"+
            "\x01\u01aa",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u01ac\x1f\uffff\x01\u01ac",
            "\x01\u01ad\x1f\uffff\x01\u01ad",
            "\x01\u01ae\x1f\uffff\x01\u01ae",
            "",
            "\x01\u01af\x1f\uffff\x01\u01af",
            "\x01\u01b0\x1f\uffff\x01\u01b0",
            "",
            "\x01\u01b1\x1f\uffff\x01\u01b1",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u01b6\x1f\uffff\x01\u01b6",
            "\x01\u01b7\x1f\uffff\x01\u01b7",
            "\x01\u01b8\x1f\uffff\x01\u01b8",
            "\x01\u01b9\x1f\uffff\x01\u01b9",
            "\x01\u01ba\x1f\uffff\x01\u01ba",
            "\x01\u01bb\x1f\uffff\x01\u01bb",
            "\x01\u01bc\x1f\uffff\x01\u01bc",
            "",
            "",
            "",
            "\x01\u01bd\x1f\uffff\x01\u01bd",
            "\x01\u01be\x1f\uffff\x01\u01be",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "\x01\u01c0\x1f\uffff\x01\u01c0",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u01c2\x1f\uffff\x01\u01c2",
            "\x01\u01c3\x1f\uffff\x01\u01c3",
            "\x01\u01c4\x1f\uffff\x01\u01c4",
            "\x01\u01c5\x1f\uffff\x01\u01c5",
            "\x01\u01c6\x1f\uffff\x01\u01c6",
            "\x01\u01c7\x1f\uffff\x01\u01c7",
            "\x01\u01c8\x1f\uffff\x01\u01c8",
            "\x01\u01c9\x1f\uffff\x01\u01c9",
            "\x01\u01ca\x1f\uffff\x01\u01ca",
            "\x01\u01cb\x1f\uffff\x01\u01cb",
            "\x01\u01cc\x1f\uffff\x01\u01cc",
            "\x01\u01cd\x1f\uffff\x01\u01cd",
            "\x01\u01ce\x1f\uffff\x01\u01ce",
            "\x01\u01cf\x1f\uffff\x01\u01cf",
            "",
            "\x01\u01d0\x1f\uffff\x01\u01d0",
            "\x01\u01d1\x1f\uffff\x01\u01d1",
            "\x01\u01d2\x1f\uffff\x01\u01d2",
            "",
            "\x01\u01d3\x1f\uffff\x01\u01d3",
            "",
            "\x01\u01d4\x1f\uffff\x01\u01d4",
            "\x01\u01d5\x1f\uffff\x01\u01d5",
            "\x01\u01d6\x1f\uffff\x01\u01d6",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u01d9\x1f\uffff\x01\u01d9",
            "",
            "\x01\u01da\x1f\uffff\x01\u01da",
            "\x01\u01db\x1f\uffff\x01\u01db",
            "\x01\u01dc\x1f\uffff\x01\u01dc",
            "\x01\u01dd\x1f\uffff\x01\u01dd",
            "\x01\u01de\x1f\uffff\x01\u01de",
            "",
            "\x01\u01df\x1f\uffff\x01\u01df",
            "\x01\u01e0\x1f\uffff\x01\u01e0",
            "\x01\u01e1\x1f\uffff\x01\u01e1",
            "\x01\u01e2\x1f\uffff\x01\u01e2",
            "",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u01e4\x1f\uffff\x01\u01e4",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u01e7\x1f\uffff\x01\u01e7",
            "\x01\u01e8\x1f\uffff\x01\u01e8",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u01eb\x1f\uffff\x01\u01eb",
            "",
            "",
            "",
            "",
            "\x01\u01ec\x1f\uffff\x01\u01ec",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u01ef\x1f\uffff\x01\u01ef",
            "\x01\u01f0\x1f\uffff\x01\u01f0",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u01f2\x1f\uffff\x01\u01f2",
            "\x01\u01f3\x1f\uffff\x01\u01f3",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "\x01\u01f6\x1f\uffff\x01\u01f6",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u01f8\x1f\uffff\x01\u01f8",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x02\u01fb\x01\uffff\x02\u01fb\x12\uffff\x01\u01fb\x01\uffff"+
            "\x01\u01fb\x03\uffff\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a"+
            "\x2c\x04\uffff\x01\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01"+
            "\uffff\x1f\x2c\x01\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170"+
            "\uffff\u0080\x2c\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c"+
            "\u5900\uffff\u0200\x2c",
            "\x01\u01fc\x1f\uffff\x01\u01fc",
            "\x01\u01fd\x1f\uffff\x01\u01fd",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0201\x1f\uffff\x01\u0201",
            "\x01\u0202\x1f\uffff\x01\u0202",
            "\x01\u0203\x1f\uffff\x01\u0203",
            "\x01\u0204\x1f\uffff\x01\u0204",
            "\x01\u0205\x1f\uffff\x01\u0205",
            "\x01\u0206\x1f\uffff\x01\u0206",
            "\x01\u0207\x1f\uffff\x01\u0207",
            "\x01\u0208\x1f\uffff\x01\u0208",
            "\x01\u0209\x1f\uffff\x01\u0209",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u020b\x1f\uffff\x01\u020b",
            "",
            "",
            "\x01\u020c\x1f\uffff\x01\u020c",
            "\x01\u020d\x1f\uffff\x01\u020d",
            "\x01\u020e\x1f\uffff\x01\u020e",
            "\x01\u020f\x1f\uffff\x01\u020f",
            "\x01\u0210\x1f\uffff\x01\u0210",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0212\x1f\uffff\x01\u0212",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0215\x1f\uffff\x01\u0215",
            "",
            "\x01\u0216\x1f\uffff\x01\u0216",
            "",
            "",
            "\x01\u0217\x1f\uffff\x01\u0217",
            "\x01\u0218\x1f\uffff\x01\u0218",
            "",
            "",
            "\x01\u0219\x1f\uffff\x01\u0219",
            "\x01\u021a\x1f\uffff\x01\u021a",
            "",
            "",
            "\x01\u021b\x1f\uffff\x01\u021b",
            "\x01\u021c\x1f\uffff\x01\u021c",
            "",
            "\x01\u021d\x1f\uffff\x01\u021d",
            "\x01\u021e\x1f\uffff\x01\u021e",
            "",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "\x01\u0220\x1f\uffff\x01\u0220",
            "",
            "",
            "",
            "\x01\u0221\x1f\uffff\x01\u0221",
            "\x01\u0222\x1f\uffff\x01\u0222",
            "",
            "",
            "",
            "\x01\u0223\x1f\uffff\x01\u0223",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0226\x1f\uffff\x01\u0226",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u022a\x1f\uffff\x01\u022a",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u022d\x1f\uffff\x01\u022d",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u022f\x1f\uffff\x01\u022f",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0231\x1f\uffff\x01\u0231",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0234\x1f\uffff\x01\u0234",
            "\x01\u0235\x1f\uffff\x01\u0235",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0237\x1f\uffff\x01\u0237",
            "\x01\u0238\x1f\uffff\x01\u0238",
            "\x01\u0239\x1f\uffff\x01\u0239",
            "\x01\u023a\x1f\uffff\x01\u023a",
            "\x01\u023b\x1f\uffff\x01\u023b",
            "\x01\u023c\x1f\uffff\x01\u023c",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u023e\x1f\uffff\x01\u023e",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "",
            "",
            "\x01\u0242\x1f\uffff\x01\u0242",
            "",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "\x01\u0244\x1f\uffff\x01\u0244",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0249\x1f\uffff\x01\u0249",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u024d\x1f\uffff\x01\u024d",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "",
            "",
            "\x01\u024f\x1f\uffff\x01\u024f",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "",
            "",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "",
            "",
            "\x01\u0252\x1f\uffff\x01\u0252",
            "",
            "\x01\u0253\x1f\uffff\x01\u0253",
            "",
            "",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x09\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__214 | INCLUDE_FILE | COMMENT | WS | NEWPAGE | DATAMODEL | ENDMODEL | ENDIF | ENDWHILE | ENDDO | ENDTABLE | ENDBLOCK | ENDPROCEDURE | PROCEDURE | END | ELSEIF | ELSE | ERROR | CASE | ENDCASE | TABLE | THEN | BLOCK | EMBEDDED | FOR | WHILE | STRING | OPEN | INTEGER | DATETYPE | TIMETYPE | ARRAY | INCLUDE | SIGNAL | CHECK | PARAMETERS | EXTERNALS | LIBRARIES | IMPORT | EXPORT | TRANSIT | AUXFIELDS | FIELDS | INHERIT | CATI | CAPI | IMGLINK | EMPTY | NOREFUSAL | NORF | NODONTKNOW | NODK | NOEMPTY | REFUSAL | RF | DONTKNOW | DK | ROUTER | ALIEN | SETTINGS | LAYOUT | PRIMARY | USES | LANGUAGES | ATTRIBUTES | SECONDARY | ALPHA | TRIGRAM | PARALLEL | INVOLVING | KEEP | ASK | SHOW | LOOKUP | CLASSIFY | SEARCH | INFOPANE | GRID | FIELDPANE | DUMMY | T_NEWLINE | NEWCOLUMN | AFTER | BEFORE | FROM | RESERVECHECK | TYPE | LOCALS | VAR | RULES | TO | AT | IF | IN | NOT | DIV | MOD | AND | OR | SET | OF | CHAR | DO | POSITION | UPPERCASE | PLUS | MINUS | STAR | SLASH | ASSIGN | COMMA | SEMI | COLON | EQUAL | NOT_EQUAL | LT | LE | GE | GT | LPAREN | RPAREN | LBRACK | RBRACK | ATSYMB | DOTDOT | DOT | LCURLY | RCURLY | INT | QSTRING | SQSTRING | SQUOTE | ID );"; }
        }

    }


    protected internal int DFA9_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA9_3 = input.LA(1);

                   	s = -1;
                   	if ( ((LA9_3 >= '\u0000' && LA9_3 <= '\uFFFF')) ) { s = 53; }

                   	else s = 54;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA9_43 = input.LA(1);

                   	s = -1;
                   	if ( ((LA9_43 >= '\u0000' && LA9_43 <= '\uFFFF')) ) { s = 118; }

                   	else s = 117;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae9 =
            new NoViableAltException(dfa.Description, 9, _s, input);
        dfa.Error(nvae9);
        throw nvae9;
    }
 
    
}
}