// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g 2011-10-05 12:20:53

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


//deprecated constructor
#pragma warning disable 618


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace Colectica.BlaiseToDdi
{
public partial class BlaiseParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"INTRANGE", 
		"REALRANGE", 
		"PARAMETER_LIST", 
		"PARAMETER_ITEM", 
		"ID_LIST", 
		"VARIABLE_LIST", 
		"INTEGER_LIST", 
		"PARAMETERS_OR_EXPRESSION", 
		"BUILTIN_FUNCTION", 
		"CONDITIONAL", 
		"DATA_MODEL", 
		"MS_SETTINGS", 
		"MS_PRIMARY", 
		"MS_SECONDARY", 
		"SECONDARY_KEY", 
		"MS_LANGUAGES", 
		"LANGUAGE", 
		"MS_ATTRIBUTES", 
		"MS_PARALLEL", 
		"PARALLEL_ITEM", 
		"LABEL", 
		"USES_ITEM", 
		"SUB_LAYOUT", 
		"SUB_TYPE", 
		"SUB_LOCALS", 
		"VARIABLE", 
		"SELECTOR", 
		"TYPE_ITEM", 
		"TYPE_REAL", 
		"WHILEDO", 
		"FORDO", 
		"CASE_ITEM", 
		"LID_STRING", 
		"FIELD", 
		"FIELD_TEXT", 
		"FIELD_DESC", 
		"FIELD_TAG", 
		"TYPEDEF", 
		"TYPE_STRING", 
		"TYPE_OPEN", 
		"TYPE_INTEGER", 
		"TYPE_CATEGORY", 
		"TYPE_CATEGORY_CODE", 
		"TYPE_DATETYPE", 
		"TYPE_TIMETYPE", 
		"TYPE_ARRAY", 
		"TYPE_USERDEF", 
		"TYPE_SETOF", 
		"CATEGORY", 
		"ARRAY_INDEX", 
		"INCLUDE", 
		"WS", 
		"QSTRING", 
		"INCLUDE_FILE", 
		"A", 
		"B", 
		"C", 
		"D", 
		"E", 
		"F", 
		"G", 
		"H", 
		"I", 
		"J", 
		"K", 
		"L", 
		"M", 
		"N", 
		"O", 
		"P", 
		"Q", 
		"R", 
		"S", 
		"T", 
		"U", 
		"V", 
		"W", 
		"X", 
		"Y", 
		"Z", 
		"COMMENT", 
		"NEWLINE", 
		"NEWPAGE", 
		"DATAMODEL", 
		"ENDMODEL", 
		"ENDIF", 
		"ENDWHILE", 
		"ENDDO", 
		"ENDTABLE", 
		"ENDBLOCK", 
		"ENDPROCEDURE", 
		"PROCEDURE", 
		"END", 
		"ELSEIF", 
		"ELSE", 
		"ERROR", 
		"CASE", 
		"ENDCASE", 
		"TABLE", 
		"THEN", 
		"BLOCK", 
		"EMBEDDED", 
		"FOR", 
		"WHILE", 
		"STRING", 
		"OPEN", 
		"INTEGER", 
		"DATETYPE", 
		"TIMETYPE", 
		"ARRAY", 
		"SIGNAL", 
		"CHECK", 
		"PARAMETERS", 
		"EXTERNALS", 
		"LIBRARIES", 
		"IMPORT", 
		"EXPORT", 
		"TRANSIT", 
		"AUXFIELDS", 
		"FIELDS", 
		"INHERIT", 
		"CATI", 
		"CAPI", 
		"IMGLINK", 
		"EMPTY", 
		"NOREFUSAL", 
		"NORF", 
		"NODONTKNOW", 
		"NODK", 
		"NOEMPTY", 
		"REFUSAL", 
		"RF", 
		"DONTKNOW", 
		"DK", 
		"ROUTER", 
		"ALIEN", 
		"SETTINGS", 
		"LAYOUT", 
		"PRIMARY", 
		"USES", 
		"LANGUAGES", 
		"ATTRIBUTES", 
		"SECONDARY", 
		"ALPHA", 
		"TRIGRAM", 
		"PARALLEL", 
		"INVOLVING", 
		"KEEP", 
		"ASK", 
		"SHOW", 
		"LOOKUP", 
		"CLASSIFY", 
		"SEARCH", 
		"INFOPANE", 
		"GRID", 
		"FIELDPANE", 
		"DUMMY", 
		"T_NEWLINE", 
		"NEWCOLUMN", 
		"AFTER", 
		"BEFORE", 
		"FROM", 
		"RESERVECHECK", 
		"TYPE", 
		"LOCALS", 
		"VAR", 
		"RULES", 
		"TO", 
		"AT", 
		"IF", 
		"IN", 
		"NOT", 
		"DIV", 
		"MOD", 
		"AND", 
		"OR", 
		"SET", 
		"OF", 
		"CHAR", 
		"DO", 
		"POSITION", 
		"UPPERCASE", 
		"PLUS", 
		"MINUS", 
		"STAR", 
		"SLASH", 
		"ASSIGN", 
		"COMMA", 
		"SEMI", 
		"COLON", 
		"EQUAL", 
		"NOT_EQUAL", 
		"LT", 
		"LE", 
		"GE", 
		"GT", 
		"LPAREN", 
		"RPAREN", 
		"LBRACK", 
		"RBRACK", 
		"ATSYMB", 
		"DOTDOT", 
		"DOT", 
		"LCURLY", 
		"RCURLY", 
		"INT", 
		"LETTER", 
		"SQUOTE", 
		"SQSTRING", 
		"ID", 
		"'REAL'"
    };

    public const int STAR = 188;
    public const int LETTER = 210;
    public const int MOD = 177;
    public const int SUB_TYPE = 27;
    public const int NODONTKNOW = 131;
    public const int DO = 183;
    public const int NOT = 175;
    public const int EOF = -1;
    public const int DK = 137;
    public const int TYPE = 167;
    public const int RPAREN = 201;
    public const int IMPORT = 119;
    public const int NOT_EQUAL = 195;
    public const int TYPE_INTEGER = 44;
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
    public const int K = 68;
    public const int PARALLEL_ITEM = 23;
    public const int ASK = 152;
    public const int U = 78;
    public const int T = 77;
    public const int W = 80;
    public const int LCURLY = 207;
    public const int V = 79;
    public const int INT = 209;
    public const int Q = 74;
    public const int P = 73;
    public const int S = 76;
    public const int R = 75;
    public const int Y = 82;
    public const int SUB_LAYOUT = 26;
    public const int X = 81;
    public const int Z = 83;
    public const int EMPTY = 128;
    public const int WS = 55;
    public const int LANGUAGE = 20;
    public const int VARIABLE_LIST = 9;
    public const int MS_LANGUAGES = 19;
    public const int USES = 143;
    public const int DONTKNOW = 136;
    public const int SUB_LOCALS = 28;
    public const int INFOPANE = 157;
    public const int GT = 199;
    public const int SEARCH = 156;
    public const int RESERVECHECK = 166;
    public const int END = 96;
    public const int SECONDARY_KEY = 18;
    public const int T__214 = 214;
    public const int RF = 135;
    public const int LBRACK = 202;
    public const int ATTRIBUTES = 145;
    public const int PARAMETERS = 116;
    public const int MS_SETTINGS = 15;
    public const int MS_PRIMARY = 16;
    public const int TABLE = 102;
    public const int LPAREN = 200;
    public const int POSITION = 184;
    public const int MS_SECONDARY = 17;
    public const int AT = 172;
    public const int SLASH = 189;
    public const int SELECTOR = 30;
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
    public const int PROCEDURE = 95;
    public const int LAYOUT = 141;
    public const int ELSEIF = 97;
    public const int OPEN = 109;
    public const int TYPE_ARRAY = 49;
    public const int WHILEDO = 33;
    public const int ROUTER = 138;
    public const int NEWLINE = 85;
    public const int TIMETYPE = 112;
    public const int LABEL = 24;
    public const int KEEP = 151;
    public const int ASSIGN = 190;
    public const int T_NEWLINE = 161;
    public const int INVOLVING = 150;
    public const int LE = 197;

    // delegates
    // delegators



        public BlaiseParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public BlaiseParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return BlaiseParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g"; }
    }


    public class inherit_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "inherit"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:581:1: inherit : INHERIT (a= CATI | a= IMGLINK ) -> ^( INHERIT $a) ;
    public BlaiseParser.inherit_return inherit() // throws RecognitionException [1]
    {   
        BlaiseParser.inherit_return retval = new BlaiseParser.inherit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken INHERIT1 = null;

        object a_tree=null;
        object INHERIT1_tree=null;
        RewriteRuleTokenStream stream_CATI = new RewriteRuleTokenStream(adaptor,"token CATI");
        RewriteRuleTokenStream stream_INHERIT = new RewriteRuleTokenStream(adaptor,"token INHERIT");
        RewriteRuleTokenStream stream_IMGLINK = new RewriteRuleTokenStream(adaptor,"token IMGLINK");

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:581:9: ( INHERIT (a= CATI | a= IMGLINK ) -> ^( INHERIT $a) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:581:11: INHERIT (a= CATI | a= IMGLINK )
            {
            	INHERIT1=(IToken)Match(input,INHERIT,FOLLOW_INHERIT_in_inherit3341); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_INHERIT.Add(INHERIT1);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:581:19: (a= CATI | a= IMGLINK )
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == CATI) )
            	{
            	    alt1 = 1;
            	}
            	else if ( (LA1_0 == IMGLINK) )
            	{
            	    alt1 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:581:20: a= CATI
            	        {
            	        	a=(IToken)Match(input,CATI,FOLLOW_CATI_in_inherit3346); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_CATI.Add(a);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:581:29: a= IMGLINK
            	        {
            	        	a=(IToken)Match(input,IMGLINK,FOLLOW_IMGLINK_in_inherit3352); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_IMGLINK.Add(a);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          a, INHERIT
            	// token labels:      a
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_a = new RewriteRuleTokenStream(adaptor, "token a", a);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 581:40: -> ^( INHERIT $a)
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:581:43: ^( INHERIT $a)
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_INHERIT.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "inherit"

    public class id_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "id_list"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:586:1: id_list : a= ID ( ',' b+= ID )* -> ^( ID_LIST $a ( $b)* ) ;
    public BlaiseParser.id_list_return id_list() // throws RecognitionException [1]
    {   
        BlaiseParser.id_list_return retval = new BlaiseParser.id_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken char_literal2 = null;
        IToken b = null;
        IList list_b = null;

        object a_tree=null;
        object char_literal2_tree=null;
        object b_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:586:9: (a= ID ( ',' b+= ID )* -> ^( ID_LIST $a ( $b)* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:586:11: a= ID ( ',' b+= ID )*
            {
            	a=(IToken)Match(input,ID,FOLLOW_ID_in_id_list3375); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(a);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:586:16: ( ',' b+= ID )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == COMMA) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:586:17: ',' b+= ID
            			    {
            			    	char_literal2=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_id_list3378); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(char_literal2);

            			    	b=(IToken)Match(input,ID,FOLLOW_ID_in_id_list3382); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_ID.Add(b);

            			    	if (list_b == null) list_b = new ArrayList();
            			    	list_b.Add(b);


            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements



            	// AST REWRITE
            	// elements:          b, a
            	// token labels:      a
            	// rule labels:       retval
            	// token list labels: b
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_a = new RewriteRuleTokenStream(adaptor, "token a", a);
            	RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor,"token b", list_b);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 586:29: -> ^( ID_LIST $a ( $b)* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:586:32: ^( ID_LIST $a ( $b)* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ID_LIST, "ID_LIST"), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextNode());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:586:45: ( $b)*
            	    while ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextNode());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "id_list"

    public class var_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "var_list"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:587:1: var_list : a= variable ( ',' b+= variable )* -> ^( VARIABLE_LIST $a ( $b)* ) ;
    public BlaiseParser.var_list_return var_list() // throws RecognitionException [1]
    {   
        BlaiseParser.var_list_return retval = new BlaiseParser.var_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal3 = null;
        IList list_b = null;
        BlaiseParser.variable_return a = default(BlaiseParser.variable_return);

        BlaiseParser.variable_return b = default(BlaiseParser.variable_return);
         b = null;
        object char_literal3_tree=null;
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:587:10: (a= variable ( ',' b+= variable )* -> ^( VARIABLE_LIST $a ( $b)* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:587:12: a= variable ( ',' b+= variable )*
            {
            	PushFollow(FOLLOW_variable_in_var_list3406);
            	a = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(a.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:587:23: ( ',' b+= variable )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == COMMA) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:587:24: ',' b+= variable
            			    {
            			    	char_literal3=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_var_list3409); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(char_literal3);

            			    	PushFollow(FOLLOW_variable_in_var_list3413);
            			    	b = variable();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_variable.Add(b.Tree);
            			    	if (list_b == null) list_b = new ArrayList();
            			    	list_b.Add(b.Tree);


            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements



            	// AST REWRITE
            	// elements:          a, b
            	// token labels:      
            	// rule labels:       retval, a
            	// token list labels: 
            	// rule list labels:  b
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "token b", list_b);
            	root_0 = (object)adaptor.GetNilNode();
            	// 587:42: -> ^( VARIABLE_LIST $a ( $b)* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:587:45: ^( VARIABLE_LIST $a ( $b)* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARIABLE_LIST, "VARIABLE_LIST"), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextTree());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:587:64: ( $b)*
            	    while ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextTree());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "var_list"

    public class int_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "int_list"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:588:1: int_list : a= signedInteger ( ',' b+= signedInteger )* -> ^( INTEGER_LIST $a ( $b)* ) ;
    public BlaiseParser.int_list_return int_list() // throws RecognitionException [1]
    {   
        BlaiseParser.int_list_return retval = new BlaiseParser.int_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal4 = null;
        IList list_b = null;
        BlaiseParser.signedInteger_return a = default(BlaiseParser.signedInteger_return);

        BlaiseParser.signedInteger_return b = default(BlaiseParser.signedInteger_return);
         b = null;
        object char_literal4_tree=null;
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleSubtreeStream stream_signedInteger = new RewriteRuleSubtreeStream(adaptor,"rule signedInteger");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:588:10: (a= signedInteger ( ',' b+= signedInteger )* -> ^( INTEGER_LIST $a ( $b)* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:588:12: a= signedInteger ( ',' b+= signedInteger )*
            {
            	PushFollow(FOLLOW_signedInteger_in_int_list3437);
            	a = signedInteger();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_signedInteger.Add(a.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:588:28: ( ',' b+= signedInteger )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == COMMA) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:588:29: ',' b+= signedInteger
            			    {
            			    	char_literal4=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_int_list3440); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(char_literal4);

            			    	PushFollow(FOLLOW_signedInteger_in_int_list3444);
            			    	b = signedInteger();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_signedInteger.Add(b.Tree);
            			    	if (list_b == null) list_b = new ArrayList();
            			    	list_b.Add(b.Tree);


            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements



            	// AST REWRITE
            	// elements:          b, a
            	// token labels:      
            	// rule labels:       retval, a
            	// token list labels: 
            	// rule list labels:  b
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "token b", list_b);
            	root_0 = (object)adaptor.GetNilNode();
            	// 588:52: -> ^( INTEGER_LIST $a ( $b)* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:588:55: ^( INTEGER_LIST $a ( $b)* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INTEGER_LIST, "INTEGER_LIST"), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextTree());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:588:73: ( $b)*
            	    while ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextTree());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "int_list"

    public class realrange_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "realrange"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:591:1: realrange : (a= signedReal DOTDOT b= signedReal -> ^( REALRANGE $a $b) | c= signedInteger DOTDOT d= signedReal -> ^( REALRANGE $c $d) | e= signedReal DOTDOT f= signedInteger -> ^( REALRANGE $e $f) | g= signedInteger DOTDOT h= signedInteger -> ^( INTRANGE $g $h) );
    public BlaiseParser.realrange_return realrange() // throws RecognitionException [1]
    {   
        BlaiseParser.realrange_return retval = new BlaiseParser.realrange_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DOTDOT5 = null;
        IToken DOTDOT6 = null;
        IToken DOTDOT7 = null;
        IToken DOTDOT8 = null;
        BlaiseParser.signedReal_return a = default(BlaiseParser.signedReal_return);

        BlaiseParser.signedReal_return b = default(BlaiseParser.signedReal_return);

        BlaiseParser.signedInteger_return c = default(BlaiseParser.signedInteger_return);

        BlaiseParser.signedReal_return d = default(BlaiseParser.signedReal_return);

        BlaiseParser.signedReal_return e = default(BlaiseParser.signedReal_return);

        BlaiseParser.signedInteger_return f = default(BlaiseParser.signedInteger_return);

        BlaiseParser.signedInteger_return g = default(BlaiseParser.signedInteger_return);

        BlaiseParser.signedInteger_return h = default(BlaiseParser.signedInteger_return);


        object DOTDOT5_tree=null;
        object DOTDOT6_tree=null;
        object DOTDOT7_tree=null;
        object DOTDOT8_tree=null;
        RewriteRuleTokenStream stream_DOTDOT = new RewriteRuleTokenStream(adaptor,"token DOTDOT");
        RewriteRuleSubtreeStream stream_signedInteger = new RewriteRuleSubtreeStream(adaptor,"rule signedInteger");
        RewriteRuleSubtreeStream stream_signedReal = new RewriteRuleSubtreeStream(adaptor,"rule signedReal");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:591:12: (a= signedReal DOTDOT b= signedReal -> ^( REALRANGE $a $b) | c= signedInteger DOTDOT d= signedReal -> ^( REALRANGE $c $d) | e= signedReal DOTDOT f= signedInteger -> ^( REALRANGE $e $f) | g= signedInteger DOTDOT h= signedInteger -> ^( INTRANGE $g $h) )
            int alt5 = 4;
            alt5 = dfa5.Predict(input);
            switch (alt5) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:591:15: a= signedReal DOTDOT b= signedReal
                    {
                    	PushFollow(FOLLOW_signedReal_in_realrange3472);
                    	a = signedReal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_signedReal.Add(a.Tree);
                    	DOTDOT5=(IToken)Match(input,DOTDOT,FOLLOW_DOTDOT_in_realrange3474); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DOTDOT.Add(DOTDOT5);

                    	PushFollow(FOLLOW_signedReal_in_realrange3478);
                    	b = signedReal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_signedReal.Add(b.Tree);


                    	// AST REWRITE
                    	// elements:          b, a
                    	// token labels:      
                    	// rule labels:       retval, b, a
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
                    	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "rule b", b!=null ? b.Tree : null);
                    	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 591:48: -> ^( REALRANGE $a $b)
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:591:51: ^( REALRANGE $a $b)
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(REALRANGE, "REALRANGE"), root_1);

                    	    adaptor.AddChild(root_1, stream_a.NextTree());
                    	    adaptor.AddChild(root_1, stream_b.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:592:4: c= signedInteger DOTDOT d= signedReal
                    {
                    	PushFollow(FOLLOW_signedInteger_in_realrange3497);
                    	c = signedInteger();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_signedInteger.Add(c.Tree);
                    	DOTDOT6=(IToken)Match(input,DOTDOT,FOLLOW_DOTDOT_in_realrange3499); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DOTDOT.Add(DOTDOT6);

                    	PushFollow(FOLLOW_signedReal_in_realrange3503);
                    	d = signedReal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_signedReal.Add(d.Tree);


                    	// AST REWRITE
                    	// elements:          d, c
                    	// token labels:      
                    	// rule labels:       retval, d, c
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
                    	RewriteRuleSubtreeStream stream_d = new RewriteRuleSubtreeStream(adaptor, "rule d", d!=null ? d.Tree : null);
                    	RewriteRuleSubtreeStream stream_c = new RewriteRuleSubtreeStream(adaptor, "rule c", c!=null ? c.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 592:40: -> ^( REALRANGE $c $d)
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:592:43: ^( REALRANGE $c $d)
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(REALRANGE, "REALRANGE"), root_1);

                    	    adaptor.AddChild(root_1, stream_c.NextTree());
                    	    adaptor.AddChild(root_1, stream_d.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:593:4: e= signedReal DOTDOT f= signedInteger
                    {
                    	PushFollow(FOLLOW_signedReal_in_realrange3522);
                    	e = signedReal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_signedReal.Add(e.Tree);
                    	DOTDOT7=(IToken)Match(input,DOTDOT,FOLLOW_DOTDOT_in_realrange3524); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DOTDOT.Add(DOTDOT7);

                    	PushFollow(FOLLOW_signedInteger_in_realrange3528);
                    	f = signedInteger();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_signedInteger.Add(f.Tree);


                    	// AST REWRITE
                    	// elements:          e, f
                    	// token labels:      
                    	// rule labels:       f, retval, e
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_f = new RewriteRuleSubtreeStream(adaptor, "rule f", f!=null ? f.Tree : null);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
                    	RewriteRuleSubtreeStream stream_e = new RewriteRuleSubtreeStream(adaptor, "rule e", e!=null ? e.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 593:40: -> ^( REALRANGE $e $f)
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:593:43: ^( REALRANGE $e $f)
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(REALRANGE, "REALRANGE"), root_1);

                    	    adaptor.AddChild(root_1, stream_e.NextTree());
                    	    adaptor.AddChild(root_1, stream_f.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:594:4: g= signedInteger DOTDOT h= signedInteger
                    {
                    	PushFollow(FOLLOW_signedInteger_in_realrange3547);
                    	g = signedInteger();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_signedInteger.Add(g.Tree);
                    	DOTDOT8=(IToken)Match(input,DOTDOT,FOLLOW_DOTDOT_in_realrange3549); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DOTDOT.Add(DOTDOT8);

                    	PushFollow(FOLLOW_signedInteger_in_realrange3553);
                    	h = signedInteger();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_signedInteger.Add(h.Tree);


                    	// AST REWRITE
                    	// elements:          h, g
                    	// token labels:      
                    	// rule labels:       g, retval, h
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_g = new RewriteRuleSubtreeStream(adaptor, "rule g", g!=null ? g.Tree : null);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
                    	RewriteRuleSubtreeStream stream_h = new RewriteRuleSubtreeStream(adaptor, "rule h", h!=null ? h.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 594:43: -> ^( INTRANGE $g $h)
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:594:46: ^( INTRANGE $g $h)
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INTRANGE, "INTRANGE"), root_1);

                    	    adaptor.AddChild(root_1, stream_g.NextTree());
                    	    adaptor.AddChild(root_1, stream_h.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "realrange"

    public class datamodel_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "datamodel"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:601:1: datamodel : DATAMODEL a= ID (b= QSTRING )? ( model_settings )* submodel ( ENDMODEL | END ) -> ^( DATA_MODEL ^( LABEL $a ( $b)? ) ^( MS_SETTINGS ( model_settings )* ) submodel ) ;
    public BlaiseParser.datamodel_return datamodel() // throws RecognitionException [1]
    {   
        BlaiseParser.datamodel_return retval = new BlaiseParser.datamodel_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken b = null;
        IToken DATAMODEL9 = null;
        IToken ENDMODEL12 = null;
        IToken END13 = null;
        BlaiseParser.model_settings_return model_settings10 = default(BlaiseParser.model_settings_return);

        BlaiseParser.submodel_return submodel11 = default(BlaiseParser.submodel_return);


        object a_tree=null;
        object b_tree=null;
        object DATAMODEL9_tree=null;
        object ENDMODEL12_tree=null;
        object END13_tree=null;
        RewriteRuleTokenStream stream_QSTRING = new RewriteRuleTokenStream(adaptor,"token QSTRING");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_ENDMODEL = new RewriteRuleTokenStream(adaptor,"token ENDMODEL");
        RewriteRuleTokenStream stream_DATAMODEL = new RewriteRuleTokenStream(adaptor,"token DATAMODEL");
        RewriteRuleSubtreeStream stream_submodel = new RewriteRuleSubtreeStream(adaptor,"rule submodel");
        RewriteRuleSubtreeStream stream_model_settings = new RewriteRuleSubtreeStream(adaptor,"rule model_settings");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:602:2: ( DATAMODEL a= ID (b= QSTRING )? ( model_settings )* submodel ( ENDMODEL | END ) -> ^( DATA_MODEL ^( LABEL $a ( $b)? ) ^( MS_SETTINGS ( model_settings )* ) submodel ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:602:4: DATAMODEL a= ID (b= QSTRING )? ( model_settings )* submodel ( ENDMODEL | END )
            {
            	DATAMODEL9=(IToken)Match(input,DATAMODEL,FOLLOW_DATAMODEL_in_datamodel3591); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_DATAMODEL.Add(DATAMODEL9);

            	a=(IToken)Match(input,ID,FOLLOW_ID_in_datamodel3595); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(a);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:602:20: (b= QSTRING )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == QSTRING) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: b= QSTRING
            	        {
            	        	b=(IToken)Match(input,QSTRING,FOLLOW_QSTRING_in_datamodel3599); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_QSTRING.Add(b);


            	        }
            	        break;

            	}

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:603:2: ( model_settings )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == INCLUDE_FILE || LA7_0 == INHERIT || (LA7_0 >= PRIMARY && LA7_0 <= SECONDARY) || LA7_0 == PARALLEL) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: model_settings
            			    {
            			    	PushFollow(FOLLOW_model_settings_in_datamodel3603);
            			    	model_settings10 = model_settings();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_model_settings.Add(model_settings10.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	PushFollow(FOLLOW_submodel_in_datamodel3613);
            	submodel11 = submodel();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_submodel.Add(submodel11.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:606:2: ( ENDMODEL | END )
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == ENDMODEL) )
            	{
            	    alt8 = 1;
            	}
            	else if ( (LA8_0 == END) )
            	{
            	    alt8 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:606:3: ENDMODEL
            	        {
            	        	ENDMODEL12=(IToken)Match(input,ENDMODEL,FOLLOW_ENDMODEL_in_datamodel3618); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ENDMODEL.Add(ENDMODEL12);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:606:14: END
            	        {
            	        	END13=(IToken)Match(input,END,FOLLOW_END_in_datamodel3622); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_END.Add(END13);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          a, submodel, model_settings, b
            	// token labels:      b, a
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor, "token b", b);
            	RewriteRuleTokenStream stream_a = new RewriteRuleTokenStream(adaptor, "token a", a);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 607:2: -> ^( DATA_MODEL ^( LABEL $a ( $b)? ) ^( MS_SETTINGS ( model_settings )* ) submodel )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:607:5: ^( DATA_MODEL ^( LABEL $a ( $b)? ) ^( MS_SETTINGS ( model_settings )* ) submodel )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DATA_MODEL, "DATA_MODEL"), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:607:18: ^( LABEL $a ( $b)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(LABEL, "LABEL"), root_2);

            	    adaptor.AddChild(root_2, stream_a.NextNode());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:607:29: ( $b)?
            	    if ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_b.NextNode());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:607:34: ^( MS_SETTINGS ( model_settings )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(MS_SETTINGS, "MS_SETTINGS"), root_2);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:607:48: ( model_settings )*
            	    while ( stream_model_settings.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_model_settings.NextTree());

            	    }
            	    stream_model_settings.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_submodel.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "datamodel"

    public class submodel_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "submodel"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:610:1: submodel : ( block | procedure | table | parameters | externals | libraries | type | fields | auxfields | routerAlien | locals )* ( rules | layout )* ;
    public BlaiseParser.submodel_return submodel() // throws RecognitionException [1]
    {   
        BlaiseParser.submodel_return retval = new BlaiseParser.submodel_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        BlaiseParser.block_return block14 = default(BlaiseParser.block_return);

        BlaiseParser.procedure_return procedure15 = default(BlaiseParser.procedure_return);

        BlaiseParser.table_return table16 = default(BlaiseParser.table_return);

        BlaiseParser.parameters_return parameters17 = default(BlaiseParser.parameters_return);

        BlaiseParser.externals_return externals18 = default(BlaiseParser.externals_return);

        BlaiseParser.libraries_return libraries19 = default(BlaiseParser.libraries_return);

        BlaiseParser.type_return type20 = default(BlaiseParser.type_return);

        BlaiseParser.fields_return fields21 = default(BlaiseParser.fields_return);

        BlaiseParser.auxfields_return auxfields22 = default(BlaiseParser.auxfields_return);

        BlaiseParser.routerAlien_return routerAlien23 = default(BlaiseParser.routerAlien_return);

        BlaiseParser.locals_return locals24 = default(BlaiseParser.locals_return);

        BlaiseParser.rules_return rules25 = default(BlaiseParser.rules_return);

        BlaiseParser.layout_return layout26 = default(BlaiseParser.layout_return);



        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:610:9: ( ( block | procedure | table | parameters | externals | libraries | type | fields | auxfields | routerAlien | locals )* ( rules | layout )* )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:610:11: ( block | procedure | table | parameters | externals | libraries | type | fields | auxfields | routerAlien | locals )* ( rules | layout )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:610:11: ( block | procedure | table | parameters | externals | libraries | type | fields | auxfields | routerAlien | locals )*
            	do 
            	{
            	    int alt9 = 12;
            	    alt9 = dfa9.Predict(input);
            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:610:13: block
            			    {
            			    	PushFollow(FOLLOW_block_in_submodel3662);
            			    	block14 = block();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block14.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:611:5: procedure
            			    {
            			    	PushFollow(FOLLOW_procedure_in_submodel3669);
            			    	procedure15 = procedure();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, procedure15.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:612:5: table
            			    {
            			    	PushFollow(FOLLOW_table_in_submodel3675);
            			    	table16 = table();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, table16.Tree);

            			    }
            			    break;
            			case 4 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:613:5: parameters
            			    {
            			    	PushFollow(FOLLOW_parameters_in_submodel3681);
            			    	parameters17 = parameters();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parameters17.Tree);

            			    }
            			    break;
            			case 5 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:614:5: externals
            			    {
            			    	PushFollow(FOLLOW_externals_in_submodel3688);
            			    	externals18 = externals();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, externals18.Tree);

            			    }
            			    break;
            			case 6 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:615:5: libraries
            			    {
            			    	PushFollow(FOLLOW_libraries_in_submodel3694);
            			    	libraries19 = libraries();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, libraries19.Tree);

            			    }
            			    break;
            			case 7 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:616:5: type
            			    {
            			    	PushFollow(FOLLOW_type_in_submodel3700);
            			    	type20 = type();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type20.Tree);

            			    }
            			    break;
            			case 8 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:617:5: fields
            			    {
            			    	PushFollow(FOLLOW_fields_in_submodel3707);
            			    	fields21 = fields();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, fields21.Tree);

            			    }
            			    break;
            			case 9 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:618:5: auxfields
            			    {
            			    	PushFollow(FOLLOW_auxfields_in_submodel3714);
            			    	auxfields22 = auxfields();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, auxfields22.Tree);

            			    }
            			    break;
            			case 10 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:619:5: routerAlien
            			    {
            			    	PushFollow(FOLLOW_routerAlien_in_submodel3721);
            			    	routerAlien23 = routerAlien();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, routerAlien23.Tree);

            			    }
            			    break;
            			case 11 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:620:5: locals
            			    {
            			    	PushFollow(FOLLOW_locals_in_submodel3727);
            			    	locals24 = locals();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, locals24.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:622:3: ( rules | layout )*
            	do 
            	{
            	    int alt10 = 3;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == RULES) )
            	    {
            	        alt10 = 1;
            	    }
            	    else if ( (LA10_0 == LAYOUT) )
            	    {
            	        alt10 = 2;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:622:5: rules
            			    {
            			    	PushFollow(FOLLOW_rules_in_submodel3741);
            			    	rules25 = rules();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, rules25.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:623:5: layout
            			    {
            			    	PushFollow(FOLLOW_layout_in_submodel3748);
            			    	layout26 = layout();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, layout26.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "submodel"

    public class blaise_file_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "blaise_file"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:629:1: blaise_file : datamodel EOF ;
    public BlaiseParser.blaise_file_return blaise_file() // throws RecognitionException [1]
    {   
        BlaiseParser.blaise_file_return retval = new BlaiseParser.blaise_file_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF28 = null;
        BlaiseParser.datamodel_return datamodel27 = default(BlaiseParser.datamodel_return);


        object EOF28_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:630:2: ( datamodel EOF )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:630:4: datamodel EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_datamodel_in_blaise_file3767);
            	datamodel27 = datamodel();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, datamodel27.Tree);
            	EOF28=(IToken)Match(input,EOF,FOLLOW_EOF_in_blaise_file3769); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "blaise_file"

    public class submodel_file_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "submodel_file"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:632:1: submodel_file : submodel EOF ;
    public BlaiseParser.submodel_file_return submodel_file() // throws RecognitionException [1]
    {   
        BlaiseParser.submodel_file_return retval = new BlaiseParser.submodel_file_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF30 = null;
        BlaiseParser.submodel_return submodel29 = default(BlaiseParser.submodel_return);


        object EOF30_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:633:1: ( submodel EOF )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:633:3: submodel EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_submodel_in_submodel_file3779);
            	submodel29 = submodel();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, submodel29.Tree);
            	EOF30=(IToken)Match(input,EOF,FOLLOW_EOF_in_submodel_file3781); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "submodel_file"

    public class model_settings_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "model_settings"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:643:1: model_settings : ( primary | secondary | uses | inherit | parallel | languages | attributes | INCLUDE_FILE );
    public BlaiseParser.model_settings_return model_settings() // throws RecognitionException [1]
    {   
        BlaiseParser.model_settings_return retval = new BlaiseParser.model_settings_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INCLUDE_FILE38 = null;
        BlaiseParser.primary_return primary31 = default(BlaiseParser.primary_return);

        BlaiseParser.secondary_return secondary32 = default(BlaiseParser.secondary_return);

        BlaiseParser.uses_return uses33 = default(BlaiseParser.uses_return);

        BlaiseParser.inherit_return inherit34 = default(BlaiseParser.inherit_return);

        BlaiseParser.parallel_return parallel35 = default(BlaiseParser.parallel_return);

        BlaiseParser.languages_return languages36 = default(BlaiseParser.languages_return);

        BlaiseParser.attributes_return attributes37 = default(BlaiseParser.attributes_return);


        object INCLUDE_FILE38_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:644:2: ( primary | secondary | uses | inherit | parallel | languages | attributes | INCLUDE_FILE )
            int alt11 = 8;
            switch ( input.LA(1) ) 
            {
            case PRIMARY:
            	{
                alt11 = 1;
                }
                break;
            case SECONDARY:
            	{
                alt11 = 2;
                }
                break;
            case USES:
            	{
                alt11 = 3;
                }
                break;
            case INHERIT:
            	{
                alt11 = 4;
                }
                break;
            case PARALLEL:
            	{
                alt11 = 5;
                }
                break;
            case LANGUAGES:
            	{
                alt11 = 6;
                }
                break;
            case ATTRIBUTES:
            	{
                alt11 = 7;
                }
                break;
            case INCLUDE_FILE:
            	{
                alt11 = 8;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d11s0 =
            	        new NoViableAltException("", 11, 0, input);

            	    throw nvae_d11s0;
            }

            switch (alt11) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:644:4: primary
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primary_in_model_settings3799);
                    	primary31 = primary();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primary31.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:644:14: secondary
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_secondary_in_model_settings3803);
                    	secondary32 = secondary();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, secondary32.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:644:26: uses
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_uses_in_model_settings3807);
                    	uses33 = uses();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, uses33.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:644:32: inherit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_inherit_in_model_settings3810);
                    	inherit34 = inherit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inherit34.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:644:42: parallel
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parallel_in_model_settings3814);
                    	parallel35 = parallel();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parallel35.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:644:53: languages
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_languages_in_model_settings3818);
                    	languages36 = languages();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, languages36.Tree);

                    }
                    break;
                case 7 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:644:65: attributes
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_attributes_in_model_settings3822);
                    	attributes37 = attributes();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, attributes37.Tree);

                    }
                    break;
                case 8 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:644:78: INCLUDE_FILE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	INCLUDE_FILE38=(IToken)Match(input,INCLUDE_FILE,FOLLOW_INCLUDE_FILE_in_model_settings3826); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{INCLUDE_FILE38_tree = (object)adaptor.Create(INCLUDE_FILE38);
                    		adaptor.AddChild(root_0, INCLUDE_FILE38_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "model_settings"

    public class primary_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "primary"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:650:1: primary : PRIMARY var_list -> ^( MS_PRIMARY var_list ) ;
    public BlaiseParser.primary_return primary() // throws RecognitionException [1]
    {   
        BlaiseParser.primary_return retval = new BlaiseParser.primary_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PRIMARY39 = null;
        BlaiseParser.var_list_return var_list40 = default(BlaiseParser.var_list_return);


        object PRIMARY39_tree=null;
        RewriteRuleTokenStream stream_PRIMARY = new RewriteRuleTokenStream(adaptor,"token PRIMARY");
        RewriteRuleSubtreeStream stream_var_list = new RewriteRuleSubtreeStream(adaptor,"rule var_list");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:650:9: ( PRIMARY var_list -> ^( MS_PRIMARY var_list ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:650:11: PRIMARY var_list
            {
            	PRIMARY39=(IToken)Match(input,PRIMARY,FOLLOW_PRIMARY_in_primary3838); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PRIMARY.Add(PRIMARY39);

            	PushFollow(FOLLOW_var_list_in_primary3840);
            	var_list40 = var_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_var_list.Add(var_list40.Tree);


            	// AST REWRITE
            	// elements:          var_list
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 650:28: -> ^( MS_PRIMARY var_list )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:650:31: ^( MS_PRIMARY var_list )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MS_PRIMARY, "MS_PRIMARY"), root_1);

            	    adaptor.AddChild(root_1, stream_var_list.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "primary"

    public class uses_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "uses"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:652:1: uses : USES a= uses_item ( COMMA b+= uses_item )* -> ^( USES $a ( $b)* ) ;
    public BlaiseParser.uses_return uses() // throws RecognitionException [1]
    {   
        BlaiseParser.uses_return retval = new BlaiseParser.uses_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken USES41 = null;
        IToken COMMA42 = null;
        IList list_b = null;
        BlaiseParser.uses_item_return a = default(BlaiseParser.uses_item_return);

        BlaiseParser.uses_item_return b = default(BlaiseParser.uses_item_return);
         b = null;
        object USES41_tree=null;
        object COMMA42_tree=null;
        RewriteRuleTokenStream stream_USES = new RewriteRuleTokenStream(adaptor,"token USES");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleSubtreeStream stream_uses_item = new RewriteRuleSubtreeStream(adaptor,"rule uses_item");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:652:6: ( USES a= uses_item ( COMMA b+= uses_item )* -> ^( USES $a ( $b)* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:652:8: USES a= uses_item ( COMMA b+= uses_item )*
            {
            	USES41=(IToken)Match(input,USES,FOLLOW_USES_in_uses3856); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_USES.Add(USES41);

            	PushFollow(FOLLOW_uses_item_in_uses3860);
            	a = uses_item();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_uses_item.Add(a.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:652:25: ( COMMA b+= uses_item )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == COMMA) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:652:26: COMMA b+= uses_item
            			    {
            			    	COMMA42=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_uses3863); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA42);

            			    	PushFollow(FOLLOW_uses_item_in_uses3867);
            			    	b = uses_item();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_uses_item.Add(b.Tree);
            			    	if (list_b == null) list_b = new ArrayList();
            			    	list_b.Add(b.Tree);


            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements



            	// AST REWRITE
            	// elements:          USES, b, a
            	// token labels:      
            	// rule labels:       retval, a
            	// token list labels: 
            	// rule list labels:  b
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "token b", list_b);
            	root_0 = (object)adaptor.GetNilNode();
            	// 652:47: -> ^( USES $a ( $b)* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:652:50: ^( USES $a ( $b)* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_USES.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextTree());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:652:60: ( $b)*
            	    while ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextTree());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "uses"

    public class uses_item_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "uses_item"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:653:1: uses_item : ID SQSTRING -> ^( USES_ITEM ID SQSTRING ) ;
    public BlaiseParser.uses_item_return uses_item() // throws RecognitionException [1]
    {   
        BlaiseParser.uses_item_return retval = new BlaiseParser.uses_item_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID43 = null;
        IToken SQSTRING44 = null;

        object ID43_tree=null;
        object SQSTRING44_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_SQSTRING = new RewriteRuleTokenStream(adaptor,"token SQSTRING");

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:654:2: ( ID SQSTRING -> ^( USES_ITEM ID SQSTRING ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:654:4: ID SQSTRING
            {
            	ID43=(IToken)Match(input,ID,FOLLOW_ID_in_uses_item3890); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID43);

            	SQSTRING44=(IToken)Match(input,SQSTRING,FOLLOW_SQSTRING_in_uses_item3892); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_SQSTRING.Add(SQSTRING44);



            	// AST REWRITE
            	// elements:          ID, SQSTRING
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 654:16: -> ^( USES_ITEM ID SQSTRING )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:654:19: ^( USES_ITEM ID SQSTRING )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(USES_ITEM, "USES_ITEM"), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    adaptor.AddChild(root_1, stream_SQSTRING.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "uses_item"

    public class languages_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "languages"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:656:1: languages : LANGUAGES '=' a= language ( ',' b+= language )* -> ^( MS_LANGUAGES $a ( $b)* ) ;
    public BlaiseParser.languages_return languages() // throws RecognitionException [1]
    {   
        BlaiseParser.languages_return retval = new BlaiseParser.languages_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LANGUAGES45 = null;
        IToken char_literal46 = null;
        IToken char_literal47 = null;
        IList list_b = null;
        BlaiseParser.language_return a = default(BlaiseParser.language_return);

        BlaiseParser.language_return b = default(BlaiseParser.language_return);
         b = null;
        object LANGUAGES45_tree=null;
        object char_literal46_tree=null;
        object char_literal47_tree=null;
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_LANGUAGES = new RewriteRuleTokenStream(adaptor,"token LANGUAGES");
        RewriteRuleTokenStream stream_EQUAL = new RewriteRuleTokenStream(adaptor,"token EQUAL");
        RewriteRuleSubtreeStream stream_language = new RewriteRuleSubtreeStream(adaptor,"rule language");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:657:2: ( LANGUAGES '=' a= language ( ',' b+= language )* -> ^( MS_LANGUAGES $a ( $b)* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:657:4: LANGUAGES '=' a= language ( ',' b+= language )*
            {
            	LANGUAGES45=(IToken)Match(input,LANGUAGES,FOLLOW_LANGUAGES_in_languages3911); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LANGUAGES.Add(LANGUAGES45);

            	char_literal46=(IToken)Match(input,EQUAL,FOLLOW_EQUAL_in_languages3913); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EQUAL.Add(char_literal46);

            	PushFollow(FOLLOW_language_in_languages3917);
            	a = language();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_language.Add(a.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:657:29: ( ',' b+= language )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == COMMA) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:657:30: ',' b+= language
            			    {
            			    	char_literal47=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_languages3920); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(char_literal47);

            			    	PushFollow(FOLLOW_language_in_languages3924);
            			    	b = language();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_language.Add(b.Tree);
            			    	if (list_b == null) list_b = new ArrayList();
            			    	list_b.Add(b.Tree);


            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements



            	// AST REWRITE
            	// elements:          b, a
            	// token labels:      
            	// rule labels:       retval, a
            	// token list labels: 
            	// rule list labels:  b
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "token b", list_b);
            	root_0 = (object)adaptor.GetNilNode();
            	// 657:48: -> ^( MS_LANGUAGES $a ( $b)* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:657:51: ^( MS_LANGUAGES $a ( $b)* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MS_LANGUAGES, "MS_LANGUAGES"), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextTree());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:657:69: ( $b)*
            	    while ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextTree());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "languages"

    public class language_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "language"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:658:1: language : a= ID (b= QSTRING )? -> ^( LANGUAGE $a ( $b)? ) ;
    public BlaiseParser.language_return language() // throws RecognitionException [1]
    {   
        BlaiseParser.language_return retval = new BlaiseParser.language_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken b = null;

        object a_tree=null;
        object b_tree=null;
        RewriteRuleTokenStream stream_QSTRING = new RewriteRuleTokenStream(adaptor,"token QSTRING");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:659:2: (a= ID (b= QSTRING )? -> ^( LANGUAGE $a ( $b)? ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:659:5: a= ID (b= QSTRING )?
            {
            	a=(IToken)Match(input,ID,FOLLOW_ID_in_language3951); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(a);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:659:11: (b= QSTRING )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == QSTRING) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: b= QSTRING
            	        {
            	        	b=(IToken)Match(input,QSTRING,FOLLOW_QSTRING_in_language3955); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_QSTRING.Add(b);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          b, a
            	// token labels:      b, a
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor, "token b", b);
            	RewriteRuleTokenStream stream_a = new RewriteRuleTokenStream(adaptor, "token a", a);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 659:21: -> ^( LANGUAGE $a ( $b)? )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:659:24: ^( LANGUAGE $a ( $b)? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LANGUAGE, "LANGUAGE"), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextNode());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:659:38: ( $b)?
            	    if ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextNode());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "language"

    public class attributes_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "attributes"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:661:1: attributes : ATTRIBUTES '=' (a= attribute_values )? ( COMMA b+= attribute_values )* -> ^( MS_ATTRIBUTES ( $a)? ( $b)* ) ;
    public BlaiseParser.attributes_return attributes() // throws RecognitionException [1]
    {   
        BlaiseParser.attributes_return retval = new BlaiseParser.attributes_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ATTRIBUTES48 = null;
        IToken char_literal49 = null;
        IToken COMMA50 = null;
        IList list_b = null;
        BlaiseParser.attribute_values_return a = default(BlaiseParser.attribute_values_return);

        BlaiseParser.attribute_values_return b = default(BlaiseParser.attribute_values_return);
         b = null;
        object ATTRIBUTES48_tree=null;
        object char_literal49_tree=null;
        object COMMA50_tree=null;
        RewriteRuleTokenStream stream_ATTRIBUTES = new RewriteRuleTokenStream(adaptor,"token ATTRIBUTES");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_EQUAL = new RewriteRuleTokenStream(adaptor,"token EQUAL");
        RewriteRuleSubtreeStream stream_attribute_values = new RewriteRuleSubtreeStream(adaptor,"rule attribute_values");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:662:2: ( ATTRIBUTES '=' (a= attribute_values )? ( COMMA b+= attribute_values )* -> ^( MS_ATTRIBUTES ( $a)? ( $b)* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:662:4: ATTRIBUTES '=' (a= attribute_values )? ( COMMA b+= attribute_values )*
            {
            	ATTRIBUTES48=(IToken)Match(input,ATTRIBUTES,FOLLOW_ATTRIBUTES_in_attributes3979); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ATTRIBUTES.Add(ATTRIBUTES48);

            	char_literal49=(IToken)Match(input,EQUAL,FOLLOW_EQUAL_in_attributes3981); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EQUAL.Add(char_literal49);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:662:20: (a= attribute_values )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( ((LA15_0 >= EMPTY && LA15_0 <= DK)) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: a= attribute_values
            	        {
            	        	PushFollow(FOLLOW_attribute_values_in_attributes3985);
            	        	a = attribute_values();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_attribute_values.Add(a.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:662:39: ( COMMA b+= attribute_values )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( (LA16_0 == COMMA) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:662:40: COMMA b+= attribute_values
            			    {
            			    	COMMA50=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_attributes3989); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA50);

            			    	PushFollow(FOLLOW_attribute_values_in_attributes3993);
            			    	b = attribute_values();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_attribute_values.Add(b.Tree);
            			    	if (list_b == null) list_b = new ArrayList();
            			    	list_b.Add(b.Tree);


            			    }
            			    break;

            			default:
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements



            	// AST REWRITE
            	// elements:          a, b
            	// token labels:      
            	// rule labels:       retval, a
            	// token list labels: 
            	// rule list labels:  b
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "token b", list_b);
            	root_0 = (object)adaptor.GetNilNode();
            	// 662:68: -> ^( MS_ATTRIBUTES ( $a)? ( $b)* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:662:71: ^( MS_ATTRIBUTES ( $a)? ( $b)* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MS_ATTRIBUTES, "MS_ATTRIBUTES"), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:662:87: ( $a)?
            	    if ( stream_a.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_a.NextTree());

            	    }
            	    stream_a.Reset();
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:662:91: ( $b)*
            	    while ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextTree());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "attributes"

    public class secondary_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "secondary"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:664:1: secondary : SECONDARY ( secondary_key )* -> ^( MS_SECONDARY ( secondary_key )* ) ;
    public BlaiseParser.secondary_return secondary() // throws RecognitionException [1]
    {   
        BlaiseParser.secondary_return retval = new BlaiseParser.secondary_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SECONDARY51 = null;
        BlaiseParser.secondary_key_return secondary_key52 = default(BlaiseParser.secondary_key_return);


        object SECONDARY51_tree=null;
        RewriteRuleTokenStream stream_SECONDARY = new RewriteRuleTokenStream(adaptor,"token SECONDARY");
        RewriteRuleSubtreeStream stream_secondary_key = new RewriteRuleSubtreeStream(adaptor,"rule secondary_key");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:665:2: ( SECONDARY ( secondary_key )* -> ^( MS_SECONDARY ( secondary_key )* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:665:4: SECONDARY ( secondary_key )*
            {
            	SECONDARY51=(IToken)Match(input,SECONDARY,FOLLOW_SECONDARY_in_secondary4018); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_SECONDARY.Add(SECONDARY51);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:665:14: ( secondary_key )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == ID) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: secondary_key
            			    {
            			    	PushFollow(FOLLOW_secondary_key_in_secondary4020);
            			    	secondary_key52 = secondary_key();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_secondary_key.Add(secondary_key52.Tree);

            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements



            	// AST REWRITE
            	// elements:          secondary_key
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 665:29: -> ^( MS_SECONDARY ( secondary_key )* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:665:32: ^( MS_SECONDARY ( secondary_key )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MS_SECONDARY, "MS_SECONDARY"), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:665:47: ( secondary_key )*
            	    while ( stream_secondary_key.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_secondary_key.NextTree());

            	    }
            	    stream_secondary_key.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "secondary"

    public class secondary_key_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "secondary_key"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:666:1: secondary_key : (b= ID '=' )? a= var_list ( '(' c= ( ALPHA | TRIGRAM ) ')' )? -> ^( SECONDARY_KEY $a ( $b)? ( $c)? ) ;
    public BlaiseParser.secondary_key_return secondary_key() // throws RecognitionException [1]
    {   
        BlaiseParser.secondary_key_return retval = new BlaiseParser.secondary_key_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken b = null;
        IToken c = null;
        IToken char_literal53 = null;
        IToken char_literal54 = null;
        IToken ALPHA55 = null;
        IToken TRIGRAM56 = null;
        IToken char_literal57 = null;
        BlaiseParser.var_list_return a = default(BlaiseParser.var_list_return);


        object b_tree=null;
        object c_tree=null;
        object char_literal53_tree=null;
        object char_literal54_tree=null;
        object ALPHA55_tree=null;
        object TRIGRAM56_tree=null;
        object char_literal57_tree=null;
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_TRIGRAM = new RewriteRuleTokenStream(adaptor,"token TRIGRAM");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ALPHA = new RewriteRuleTokenStream(adaptor,"token ALPHA");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleTokenStream stream_EQUAL = new RewriteRuleTokenStream(adaptor,"token EQUAL");
        RewriteRuleSubtreeStream stream_var_list = new RewriteRuleSubtreeStream(adaptor,"rule var_list");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:667:2: ( (b= ID '=' )? a= var_list ( '(' c= ( ALPHA | TRIGRAM ) ')' )? -> ^( SECONDARY_KEY $a ( $b)? ( $c)? ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:667:4: (b= ID '=' )? a= var_list ( '(' c= ( ALPHA | TRIGRAM ) ')' )?
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:667:4: (b= ID '=' )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == ID) )
            	{
            	    int LA18_1 = input.LA(2);

            	    if ( (LA18_1 == EQUAL) )
            	    {
            	        alt18 = 1;
            	    }
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:667:5: b= ID '='
            	        {
            	        	b=(IToken)Match(input,ID,FOLLOW_ID_in_secondary_key4042); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ID.Add(b);

            	        	char_literal53=(IToken)Match(input,EQUAL,FOLLOW_EQUAL_in_secondary_key4044); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_EQUAL.Add(char_literal53);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_var_list_in_secondary_key4050);
            	a = var_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_var_list.Add(a.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:667:27: ( '(' c= ( ALPHA | TRIGRAM ) ')' )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == LPAREN) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:667:28: '(' c= ( ALPHA | TRIGRAM ) ')'
            	        {
            	        	char_literal54=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_secondary_key4053); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_LPAREN.Add(char_literal54);

            	        	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:667:34: ( ALPHA | TRIGRAM )
            	        	int alt19 = 2;
            	        	int LA19_0 = input.LA(1);

            	        	if ( (LA19_0 == ALPHA) )
            	        	{
            	        	    alt19 = 1;
            	        	}
            	        	else if ( (LA19_0 == TRIGRAM) )
            	        	{
            	        	    alt19 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    NoViableAltException nvae_d19s0 =
            	        	        new NoViableAltException("", 19, 0, input);

            	        	    throw nvae_d19s0;
            	        	}
            	        	switch (alt19) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:667:35: ALPHA
            	        	        {
            	        	        	ALPHA55=(IToken)Match(input,ALPHA,FOLLOW_ALPHA_in_secondary_key4058); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_ALPHA.Add(ALPHA55);


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:667:43: TRIGRAM
            	        	        {
            	        	        	TRIGRAM56=(IToken)Match(input,TRIGRAM,FOLLOW_TRIGRAM_in_secondary_key4062); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_TRIGRAM.Add(TRIGRAM56);


            	        	        }
            	        	        break;

            	        	}

            	        	char_literal57=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_secondary_key4065); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_RPAREN.Add(char_literal57);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          b, a, c
            	// token labels:      b, c
            	// rule labels:       retval, a
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor, "token b", b);
            	RewriteRuleTokenStream stream_c = new RewriteRuleTokenStream(adaptor, "token c", c);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 667:58: -> ^( SECONDARY_KEY $a ( $b)? ( $c)? )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:667:61: ^( SECONDARY_KEY $a ( $b)? ( $c)? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SECONDARY_KEY, "SECONDARY_KEY"), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextTree());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:667:80: ( $b)?
            	    if ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextNode());

            	    }
            	    stream_b.Reset();
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:667:84: ( $c)?
            	    if ( stream_c.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_c.NextNode());

            	    }
            	    stream_c.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "secondary_key"

    public class parallel_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parallel"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:669:1: parallel : PARALLEL ( parallel_item )* -> ^( MS_PARALLEL ( parallel_item )* ) ;
    public BlaiseParser.parallel_return parallel() // throws RecognitionException [1]
    {   
        BlaiseParser.parallel_return retval = new BlaiseParser.parallel_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PARALLEL58 = null;
        BlaiseParser.parallel_item_return parallel_item59 = default(BlaiseParser.parallel_item_return);


        object PARALLEL58_tree=null;
        RewriteRuleTokenStream stream_PARALLEL = new RewriteRuleTokenStream(adaptor,"token PARALLEL");
        RewriteRuleSubtreeStream stream_parallel_item = new RewriteRuleSubtreeStream(adaptor,"rule parallel_item");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:669:9: ( PARALLEL ( parallel_item )* -> ^( MS_PARALLEL ( parallel_item )* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:669:11: PARALLEL ( parallel_item )*
            {
            	PARALLEL58=(IToken)Match(input,PARALLEL,FOLLOW_PARALLEL_in_parallel4091); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PARALLEL.Add(PARALLEL58);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:669:20: ( parallel_item )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == ID) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: parallel_item
            			    {
            			    	PushFollow(FOLLOW_parallel_item_in_parallel4093);
            			    	parallel_item59 = parallel_item();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_parallel_item.Add(parallel_item59.Tree);

            			    }
            			    break;

            			default:
            			    goto loop21;
            	    }
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whining that label 'loop21' has no statements



            	// AST REWRITE
            	// elements:          parallel_item
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 669:35: -> ^( MS_PARALLEL ( parallel_item )* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:669:38: ^( MS_PARALLEL ( parallel_item )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MS_PARALLEL, "MS_PARALLEL"), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:669:52: ( parallel_item )*
            	    while ( stream_parallel_item.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_parallel_item.NextTree());

            	    }
            	    stream_parallel_item.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parallel"

    public class parallel_item_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parallel_item"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:670:1: parallel_item : (a= variable '=' )? b= variable -> ^( PARALLEL_ITEM $b ( $a)? ) ;
    public BlaiseParser.parallel_item_return parallel_item() // throws RecognitionException [1]
    {   
        BlaiseParser.parallel_item_return retval = new BlaiseParser.parallel_item_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal60 = null;
        BlaiseParser.variable_return a = default(BlaiseParser.variable_return);

        BlaiseParser.variable_return b = default(BlaiseParser.variable_return);


        object char_literal60_tree=null;
        RewriteRuleTokenStream stream_EQUAL = new RewriteRuleTokenStream(adaptor,"token EQUAL");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:671:2: ( (a= variable '=' )? b= variable -> ^( PARALLEL_ITEM $b ( $a)? ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:671:4: (a= variable '=' )? b= variable
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:671:4: (a= variable '=' )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( (LA22_0 == ID) )
            	{
            	    int LA22_1 = input.LA(2);

            	    if ( (synpred41_Blaise()) )
            	    {
            	        alt22 = 1;
            	    }
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:671:5: a= variable '='
            	        {
            	        	PushFollow(FOLLOW_variable_in_parallel_item4114);
            	        	a = variable();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_variable.Add(a.Tree);
            	        	char_literal60=(IToken)Match(input,EQUAL,FOLLOW_EQUAL_in_parallel_item4116); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_EQUAL.Add(char_literal60);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_variable_in_parallel_item4122);
            	b = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(b.Tree);


            	// AST REWRITE
            	// elements:          a, b
            	// token labels:      
            	// rule labels:       retval, b, a
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "rule b", b!=null ? b.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 671:33: -> ^( PARALLEL_ITEM $b ( $a)? )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:671:36: ^( PARALLEL_ITEM $b ( $a)? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARALLEL_ITEM, "PARALLEL_ITEM"), root_1);

            	    adaptor.AddChild(root_1, stream_b.NextTree());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:671:55: ( $a)?
            	    if ( stream_a.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_a.NextTree());

            	    }
            	    stream_a.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parallel_item"

    public class procedure_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "procedure"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:678:1: procedure : PROCEDURE ID ( procedure_fields )* ( alien | rules )? ENDPROCEDURE -> ^( PROCEDURE ^( LABEL ID ) ( procedure_fields )* ( rules )? ( alien )? ) ;
    public BlaiseParser.procedure_return procedure() // throws RecognitionException [1]
    {   
        BlaiseParser.procedure_return retval = new BlaiseParser.procedure_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PROCEDURE61 = null;
        IToken ID62 = null;
        IToken ENDPROCEDURE66 = null;
        BlaiseParser.procedure_fields_return procedure_fields63 = default(BlaiseParser.procedure_fields_return);

        BlaiseParser.alien_return alien64 = default(BlaiseParser.alien_return);

        BlaiseParser.rules_return rules65 = default(BlaiseParser.rules_return);


        object PROCEDURE61_tree=null;
        object ID62_tree=null;
        object ENDPROCEDURE66_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ENDPROCEDURE = new RewriteRuleTokenStream(adaptor,"token ENDPROCEDURE");
        RewriteRuleTokenStream stream_PROCEDURE = new RewriteRuleTokenStream(adaptor,"token PROCEDURE");
        RewriteRuleSubtreeStream stream_alien = new RewriteRuleSubtreeStream(adaptor,"rule alien");
        RewriteRuleSubtreeStream stream_procedure_fields = new RewriteRuleSubtreeStream(adaptor,"rule procedure_fields");
        RewriteRuleSubtreeStream stream_rules = new RewriteRuleSubtreeStream(adaptor,"rule rules");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:679:2: ( PROCEDURE ID ( procedure_fields )* ( alien | rules )? ENDPROCEDURE -> ^( PROCEDURE ^( LABEL ID ) ( procedure_fields )* ( rules )? ( alien )? ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:679:4: PROCEDURE ID ( procedure_fields )* ( alien | rules )? ENDPROCEDURE
            {
            	PROCEDURE61=(IToken)Match(input,PROCEDURE,FOLLOW_PROCEDURE_in_procedure4149); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PROCEDURE.Add(PROCEDURE61);

            	ID62=(IToken)Match(input,ID,FOLLOW_ID_in_procedure4151); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID62);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:679:17: ( procedure_fields )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( ((LA23_0 >= PARAMETERS && LA23_0 <= EXTERNALS) || (LA23_0 >= AUXFIELDS && LA23_0 <= FIELDS) || (LA23_0 >= LOCALS && LA23_0 <= VAR)) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: procedure_fields
            			    {
            			    	PushFollow(FOLLOW_procedure_fields_in_procedure4153);
            			    	procedure_fields63 = procedure_fields();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_procedure_fields.Add(procedure_fields63.Tree);

            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:679:35: ( alien | rules )?
            	int alt24 = 3;
            	int LA24_0 = input.LA(1);

            	if ( (LA24_0 == ALIEN) )
            	{
            	    alt24 = 1;
            	}
            	else if ( (LA24_0 == RULES) )
            	{
            	    alt24 = 2;
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:679:36: alien
            	        {
            	        	PushFollow(FOLLOW_alien_in_procedure4157);
            	        	alien64 = alien();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_alien.Add(alien64.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:679:44: rules
            	        {
            	        	PushFollow(FOLLOW_rules_in_procedure4161);
            	        	rules65 = rules();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_rules.Add(rules65.Tree);

            	        }
            	        break;

            	}

            	ENDPROCEDURE66=(IToken)Match(input,ENDPROCEDURE,FOLLOW_ENDPROCEDURE_in_procedure4165); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ENDPROCEDURE.Add(ENDPROCEDURE66);



            	// AST REWRITE
            	// elements:          rules, PROCEDURE, ID, alien, procedure_fields
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 679:65: -> ^( PROCEDURE ^( LABEL ID ) ( procedure_fields )* ( rules )? ( alien )? )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:679:68: ^( PROCEDURE ^( LABEL ID ) ( procedure_fields )* ( rules )? ( alien )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_PROCEDURE.NextNode(), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:679:80: ^( LABEL ID )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(LABEL, "LABEL"), root_2);

            	    adaptor.AddChild(root_2, stream_ID.NextNode());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:679:92: ( procedure_fields )*
            	    while ( stream_procedure_fields.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_procedure_fields.NextTree());

            	    }
            	    stream_procedure_fields.Reset();
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:679:110: ( rules )?
            	    if ( stream_rules.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_rules.NextTree());

            	    }
            	    stream_rules.Reset();
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:679:117: ( alien )?
            	    if ( stream_alien.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_alien.NextTree());

            	    }
            	    stream_alien.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "procedure"

    public class procedure_fields_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "procedure_fields"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:681:1: procedure_fields : ( parameters | externals | fields | auxfields | locals );
    public BlaiseParser.procedure_fields_return procedure_fields() // throws RecognitionException [1]
    {   
        BlaiseParser.procedure_fields_return retval = new BlaiseParser.procedure_fields_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        BlaiseParser.parameters_return parameters67 = default(BlaiseParser.parameters_return);

        BlaiseParser.externals_return externals68 = default(BlaiseParser.externals_return);

        BlaiseParser.fields_return fields69 = default(BlaiseParser.fields_return);

        BlaiseParser.auxfields_return auxfields70 = default(BlaiseParser.auxfields_return);

        BlaiseParser.locals_return locals71 = default(BlaiseParser.locals_return);



        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:682:2: ( parameters | externals | fields | auxfields | locals )
            int alt25 = 5;
            switch ( input.LA(1) ) 
            {
            case PARAMETERS:
            	{
                alt25 = 1;
                }
                break;
            case EXTERNALS:
            	{
                alt25 = 2;
                }
                break;
            case FIELDS:
            	{
                alt25 = 3;
                }
                break;
            case AUXFIELDS:
            	{
                alt25 = 4;
                }
                break;
            case LOCALS:
            case VAR:
            	{
                alt25 = 5;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d25s0 =
            	        new NoViableAltException("", 25, 0, input);

            	    throw nvae_d25s0;
            }

            switch (alt25) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:682:4: parameters
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parameters_in_procedure_fields4196);
                    	parameters67 = parameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parameters67.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:682:17: externals
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_externals_in_procedure_fields4200);
                    	externals68 = externals();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, externals68.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:682:29: fields
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fields_in_procedure_fields4204);
                    	fields69 = fields();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, fields69.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:682:38: auxfields
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_auxfields_in_procedure_fields4208);
                    	auxfields70 = auxfields();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, auxfields70.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:682:50: locals
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_locals_in_procedure_fields4212);
                    	locals71 = locals();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, locals71.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "procedure_fields"

    public class routerAlien_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "routerAlien"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:687:1: routerAlien : ROUTER ID alien ;
    public BlaiseParser.routerAlien_return routerAlien() // throws RecognitionException [1]
    {   
        BlaiseParser.routerAlien_return retval = new BlaiseParser.routerAlien_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ROUTER72 = null;
        IToken ID73 = null;
        BlaiseParser.alien_return alien74 = default(BlaiseParser.alien_return);


        object ROUTER72_tree=null;
        object ID73_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:688:2: ( ROUTER ID alien )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:688:5: ROUTER ID alien
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ROUTER72=(IToken)Match(input,ROUTER,FOLLOW_ROUTER_in_routerAlien4227); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ROUTER72_tree = (object)adaptor.Create(ROUTER72);
            		adaptor.AddChild(root_0, ROUTER72_tree);
            	}
            	ID73=(IToken)Match(input,ID,FOLLOW_ID_in_routerAlien4229); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ID73_tree = (object)adaptor.Create(ID73);
            		adaptor.AddChild(root_0, ID73_tree);
            	}
            	PushFollow(FOLLOW_alien_in_routerAlien4231);
            	alien74 = alien();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, alien74.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "routerAlien"

    public class alien_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "alien"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:690:1: alien : ALIEN LPAREN SQSTRING ( COMMA ( SQSTRING | unsignedInteger ) ) RPAREN ;
    public BlaiseParser.alien_return alien() // throws RecognitionException [1]
    {   
        BlaiseParser.alien_return retval = new BlaiseParser.alien_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ALIEN75 = null;
        IToken LPAREN76 = null;
        IToken SQSTRING77 = null;
        IToken COMMA78 = null;
        IToken SQSTRING79 = null;
        IToken RPAREN81 = null;
        BlaiseParser.unsignedInteger_return unsignedInteger80 = default(BlaiseParser.unsignedInteger_return);


        object ALIEN75_tree=null;
        object LPAREN76_tree=null;
        object SQSTRING77_tree=null;
        object COMMA78_tree=null;
        object SQSTRING79_tree=null;
        object RPAREN81_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:690:7: ( ALIEN LPAREN SQSTRING ( COMMA ( SQSTRING | unsignedInteger ) ) RPAREN )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:690:9: ALIEN LPAREN SQSTRING ( COMMA ( SQSTRING | unsignedInteger ) ) RPAREN
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ALIEN75=(IToken)Match(input,ALIEN,FOLLOW_ALIEN_in_alien4239); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ALIEN75_tree = (object)adaptor.Create(ALIEN75);
            		adaptor.AddChild(root_0, ALIEN75_tree);
            	}
            	LPAREN76=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_alien4241); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LPAREN76_tree = (object)adaptor.Create(LPAREN76);
            		adaptor.AddChild(root_0, LPAREN76_tree);
            	}
            	SQSTRING77=(IToken)Match(input,SQSTRING,FOLLOW_SQSTRING_in_alien4243); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SQSTRING77_tree = (object)adaptor.Create(SQSTRING77);
            		adaptor.AddChild(root_0, SQSTRING77_tree);
            	}
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:690:31: ( COMMA ( SQSTRING | unsignedInteger ) )
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:690:32: COMMA ( SQSTRING | unsignedInteger )
            	{
            		COMMA78=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_alien4246); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{COMMA78_tree = (object)adaptor.Create(COMMA78);
            			adaptor.AddChild(root_0, COMMA78_tree);
            		}
            		// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:690:38: ( SQSTRING | unsignedInteger )
            		int alt26 = 2;
            		int LA26_0 = input.LA(1);

            		if ( (LA26_0 == SQSTRING) )
            		{
            		    alt26 = 1;
            		}
            		else if ( (LA26_0 == INT) )
            		{
            		    alt26 = 2;
            		}
            		else 
            		{
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    NoViableAltException nvae_d26s0 =
            		        new NoViableAltException("", 26, 0, input);

            		    throw nvae_d26s0;
            		}
            		switch (alt26) 
            		{
            		    case 1 :
            		        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:690:39: SQSTRING
            		        {
            		        	SQSTRING79=(IToken)Match(input,SQSTRING,FOLLOW_SQSTRING_in_alien4249); if (state.failed) return retval;
            		        	if ( state.backtracking == 0 )
            		        	{SQSTRING79_tree = (object)adaptor.Create(SQSTRING79);
            		        		adaptor.AddChild(root_0, SQSTRING79_tree);
            		        	}

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:690:50: unsignedInteger
            		        {
            		        	PushFollow(FOLLOW_unsignedInteger_in_alien4253);
            		        	unsignedInteger80 = unsignedInteger();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unsignedInteger80.Tree);

            		        }
            		        break;

            		}


            	}

            	RPAREN81=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_alien4257); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RPAREN81_tree = (object)adaptor.Create(RPAREN81);
            		adaptor.AddChild(root_0, RPAREN81_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "alien"

    public class block_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "block"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:692:1: block : ( EMBEDDED )? BLOCK a= ID (b= QSTRING )? ( block_settings )? submodel ( ENDBLOCK | ENDTABLE ) -> ^( BLOCK ^( LABEL $a ( $b)? ) submodel ) ;
    public BlaiseParser.block_return block() // throws RecognitionException [1]
    {   
        BlaiseParser.block_return retval = new BlaiseParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken b = null;
        IToken EMBEDDED82 = null;
        IToken BLOCK83 = null;
        IToken ENDBLOCK86 = null;
        IToken ENDTABLE87 = null;
        BlaiseParser.block_settings_return block_settings84 = default(BlaiseParser.block_settings_return);

        BlaiseParser.submodel_return submodel85 = default(BlaiseParser.submodel_return);


        object a_tree=null;
        object b_tree=null;
        object EMBEDDED82_tree=null;
        object BLOCK83_tree=null;
        object ENDBLOCK86_tree=null;
        object ENDTABLE87_tree=null;
        RewriteRuleTokenStream stream_EMBEDDED = new RewriteRuleTokenStream(adaptor,"token EMBEDDED");
        RewriteRuleTokenStream stream_QSTRING = new RewriteRuleTokenStream(adaptor,"token QSTRING");
        RewriteRuleTokenStream stream_ENDTABLE = new RewriteRuleTokenStream(adaptor,"token ENDTABLE");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ENDBLOCK = new RewriteRuleTokenStream(adaptor,"token ENDBLOCK");
        RewriteRuleTokenStream stream_BLOCK = new RewriteRuleTokenStream(adaptor,"token BLOCK");
        RewriteRuleSubtreeStream stream_submodel = new RewriteRuleSubtreeStream(adaptor,"rule submodel");
        RewriteRuleSubtreeStream stream_block_settings = new RewriteRuleSubtreeStream(adaptor,"rule block_settings");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:692:7: ( ( EMBEDDED )? BLOCK a= ID (b= QSTRING )? ( block_settings )? submodel ( ENDBLOCK | ENDTABLE ) -> ^( BLOCK ^( LABEL $a ( $b)? ) submodel ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:692:9: ( EMBEDDED )? BLOCK a= ID (b= QSTRING )? ( block_settings )? submodel ( ENDBLOCK | ENDTABLE )
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:692:9: ( EMBEDDED )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( (LA27_0 == EMBEDDED) )
            	{
            	    alt27 = 1;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: EMBEDDED
            	        {
            	        	EMBEDDED82=(IToken)Match(input,EMBEDDED,FOLLOW_EMBEDDED_in_block4265); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_EMBEDDED.Add(EMBEDDED82);


            	        }
            	        break;

            	}

            	BLOCK83=(IToken)Match(input,BLOCK,FOLLOW_BLOCK_in_block4268); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BLOCK.Add(BLOCK83);

            	a=(IToken)Match(input,ID,FOLLOW_ID_in_block4272); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(a);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:692:31: (b= QSTRING )?
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( (LA28_0 == QSTRING) )
            	{
            	    alt28 = 1;
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: b= QSTRING
            	        {
            	        	b=(IToken)Match(input,QSTRING,FOLLOW_QSTRING_in_block4276); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_QSTRING.Add(b);


            	        }
            	        break;

            	}

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:693:4: ( block_settings )?
            	int alt29 = 2;
            	int LA29_0 = input.LA(1);

            	if ( (LA29_0 == SETTINGS) )
            	{
            	    alt29 = 1;
            	}
            	switch (alt29) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: block_settings
            	        {
            	        	PushFollow(FOLLOW_block_settings_in_block4282);
            	        	block_settings84 = block_settings();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_block_settings.Add(block_settings84.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_submodel_in_block4288);
            	submodel85 = submodel();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_submodel.Add(submodel85.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:695:3: ( ENDBLOCK | ENDTABLE )
            	int alt30 = 2;
            	int LA30_0 = input.LA(1);

            	if ( (LA30_0 == ENDBLOCK) )
            	{
            	    alt30 = 1;
            	}
            	else if ( (LA30_0 == ENDTABLE) )
            	{
            	    alt30 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d30s0 =
            	        new NoViableAltException("", 30, 0, input);

            	    throw nvae_d30s0;
            	}
            	switch (alt30) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:695:4: ENDBLOCK
            	        {
            	        	ENDBLOCK86=(IToken)Match(input,ENDBLOCK,FOLLOW_ENDBLOCK_in_block4293); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ENDBLOCK.Add(ENDBLOCK86);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:695:15: ENDTABLE
            	        {
            	        	ENDTABLE87=(IToken)Match(input,ENDTABLE,FOLLOW_ENDTABLE_in_block4297); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ENDTABLE.Add(ENDTABLE87);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          a, BLOCK, b, submodel
            	// token labels:      b, a
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor, "token b", b);
            	RewriteRuleTokenStream stream_a = new RewriteRuleTokenStream(adaptor, "token a", a);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 695:25: -> ^( BLOCK ^( LABEL $a ( $b)? ) submodel )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:695:28: ^( BLOCK ^( LABEL $a ( $b)? ) submodel )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_BLOCK.NextNode(), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:695:36: ^( LABEL $a ( $b)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(LABEL, "LABEL"), root_2);

            	    adaptor.AddChild(root_2, stream_a.NextNode());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:695:47: ( $b)?
            	    if ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_b.NextNode());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_submodel.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "block"

    public class table_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "table"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:697:1: table : ( EMBEDDED )? TABLE a= ID (b= QSTRING )? ( block_settings )? submodel ( ENDTABLE | ENDBLOCK ) -> ^( BLOCK ^( LABEL $a ( $b)? ) submodel ) ;
    public BlaiseParser.table_return table() // throws RecognitionException [1]
    {   
        BlaiseParser.table_return retval = new BlaiseParser.table_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken b = null;
        IToken EMBEDDED88 = null;
        IToken TABLE89 = null;
        IToken ENDTABLE92 = null;
        IToken ENDBLOCK93 = null;
        BlaiseParser.block_settings_return block_settings90 = default(BlaiseParser.block_settings_return);

        BlaiseParser.submodel_return submodel91 = default(BlaiseParser.submodel_return);


        object a_tree=null;
        object b_tree=null;
        object EMBEDDED88_tree=null;
        object TABLE89_tree=null;
        object ENDTABLE92_tree=null;
        object ENDBLOCK93_tree=null;
        RewriteRuleTokenStream stream_TABLE = new RewriteRuleTokenStream(adaptor,"token TABLE");
        RewriteRuleTokenStream stream_EMBEDDED = new RewriteRuleTokenStream(adaptor,"token EMBEDDED");
        RewriteRuleTokenStream stream_QSTRING = new RewriteRuleTokenStream(adaptor,"token QSTRING");
        RewriteRuleTokenStream stream_ENDTABLE = new RewriteRuleTokenStream(adaptor,"token ENDTABLE");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ENDBLOCK = new RewriteRuleTokenStream(adaptor,"token ENDBLOCK");
        RewriteRuleSubtreeStream stream_submodel = new RewriteRuleSubtreeStream(adaptor,"rule submodel");
        RewriteRuleSubtreeStream stream_block_settings = new RewriteRuleSubtreeStream(adaptor,"rule block_settings");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:697:7: ( ( EMBEDDED )? TABLE a= ID (b= QSTRING )? ( block_settings )? submodel ( ENDTABLE | ENDBLOCK ) -> ^( BLOCK ^( LABEL $a ( $b)? ) submodel ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:697:9: ( EMBEDDED )? TABLE a= ID (b= QSTRING )? ( block_settings )? submodel ( ENDTABLE | ENDBLOCK )
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:697:9: ( EMBEDDED )?
            	int alt31 = 2;
            	int LA31_0 = input.LA(1);

            	if ( (LA31_0 == EMBEDDED) )
            	{
            	    alt31 = 1;
            	}
            	switch (alt31) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: EMBEDDED
            	        {
            	        	EMBEDDED88=(IToken)Match(input,EMBEDDED,FOLLOW_EMBEDDED_in_table4325); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_EMBEDDED.Add(EMBEDDED88);


            	        }
            	        break;

            	}

            	TABLE89=(IToken)Match(input,TABLE,FOLLOW_TABLE_in_table4328); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_TABLE.Add(TABLE89);

            	a=(IToken)Match(input,ID,FOLLOW_ID_in_table4332); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(a);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:697:31: (b= QSTRING )?
            	int alt32 = 2;
            	int LA32_0 = input.LA(1);

            	if ( (LA32_0 == QSTRING) )
            	{
            	    alt32 = 1;
            	}
            	switch (alt32) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: b= QSTRING
            	        {
            	        	b=(IToken)Match(input,QSTRING,FOLLOW_QSTRING_in_table4336); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_QSTRING.Add(b);


            	        }
            	        break;

            	}

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:698:4: ( block_settings )?
            	int alt33 = 2;
            	int LA33_0 = input.LA(1);

            	if ( (LA33_0 == SETTINGS) )
            	{
            	    alt33 = 1;
            	}
            	switch (alt33) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: block_settings
            	        {
            	        	PushFollow(FOLLOW_block_settings_in_table4342);
            	        	block_settings90 = block_settings();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_block_settings.Add(block_settings90.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_submodel_in_table4348);
            	submodel91 = submodel();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_submodel.Add(submodel91.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:700:3: ( ENDTABLE | ENDBLOCK )
            	int alt34 = 2;
            	int LA34_0 = input.LA(1);

            	if ( (LA34_0 == ENDTABLE) )
            	{
            	    alt34 = 1;
            	}
            	else if ( (LA34_0 == ENDBLOCK) )
            	{
            	    alt34 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d34s0 =
            	        new NoViableAltException("", 34, 0, input);

            	    throw nvae_d34s0;
            	}
            	switch (alt34) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:700:4: ENDTABLE
            	        {
            	        	ENDTABLE92=(IToken)Match(input,ENDTABLE,FOLLOW_ENDTABLE_in_table4353); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ENDTABLE.Add(ENDTABLE92);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:700:15: ENDBLOCK
            	        {
            	        	ENDBLOCK93=(IToken)Match(input,ENDBLOCK,FOLLOW_ENDBLOCK_in_table4357); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ENDBLOCK.Add(ENDBLOCK93);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          a, submodel, b
            	// token labels:      b, a
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor, "token b", b);
            	RewriteRuleTokenStream stream_a = new RewriteRuleTokenStream(adaptor, "token a", a);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 700:25: -> ^( BLOCK ^( LABEL $a ( $b)? ) submodel )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:700:28: ^( BLOCK ^( LABEL $a ( $b)? ) submodel )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:700:36: ^( LABEL $a ( $b)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(LABEL, "LABEL"), root_2);

            	    adaptor.AddChild(root_2, stream_a.NextNode());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:700:47: ( $b)?
            	    if ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_b.NextNode());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_submodel.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "table"

    public class block_settings_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "block_settings"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:702:1: block_settings : SETTINGS attributes ;
    public BlaiseParser.block_settings_return block_settings() // throws RecognitionException [1]
    {   
        BlaiseParser.block_settings_return retval = new BlaiseParser.block_settings_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SETTINGS94 = null;
        BlaiseParser.attributes_return attributes95 = default(BlaiseParser.attributes_return);


        object SETTINGS94_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:703:2: ( SETTINGS attributes )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:703:4: SETTINGS attributes
            {
            	root_0 = (object)adaptor.GetNilNode();

            	SETTINGS94=(IToken)Match(input,SETTINGS,FOLLOW_SETTINGS_in_block_settings4386); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SETTINGS94_tree = (object)adaptor.Create(SETTINGS94);
            		adaptor.AddChild(root_0, SETTINGS94_tree);
            	}
            	PushFollow(FOLLOW_attributes_in_block_settings4388);
            	attributes95 = attributes();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, attributes95.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "block_settings"

    public class layout_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "layout"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:705:1: layout : LAYOUT ( layoutspec )* -> ^( SUB_LAYOUT ( layoutspec )* ) ;
    public BlaiseParser.layout_return layout() // throws RecognitionException [1]
    {   
        BlaiseParser.layout_return retval = new BlaiseParser.layout_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LAYOUT96 = null;
        BlaiseParser.layoutspec_return layoutspec97 = default(BlaiseParser.layoutspec_return);


        object LAYOUT96_tree=null;
        RewriteRuleTokenStream stream_LAYOUT = new RewriteRuleTokenStream(adaptor,"token LAYOUT");
        RewriteRuleSubtreeStream stream_layoutspec = new RewriteRuleSubtreeStream(adaptor,"rule layoutspec");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:705:8: ( LAYOUT ( layoutspec )* -> ^( SUB_LAYOUT ( layoutspec )* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:705:10: LAYOUT ( layoutspec )*
            {
            	LAYOUT96=(IToken)Match(input,LAYOUT,FOLLOW_LAYOUT_in_layout4396); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LAYOUT.Add(LAYOUT96);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:705:17: ( layoutspec )*
            	do 
            	{
            	    int alt35 = 2;
            	    int LA35_0 = input.LA(1);

            	    if ( ((LA35_0 >= AFTER && LA35_0 <= FROM) || LA35_0 == AT) )
            	    {
            	        alt35 = 1;
            	    }


            	    switch (alt35) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: layoutspec
            			    {
            			    	PushFollow(FOLLOW_layoutspec_in_layout4398);
            			    	layoutspec97 = layoutspec();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_layoutspec.Add(layoutspec97.Tree);

            			    }
            			    break;

            			default:
            			    goto loop35;
            	    }
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements



            	// AST REWRITE
            	// elements:          layoutspec
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 705:29: -> ^( SUB_LAYOUT ( layoutspec )* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:705:32: ^( SUB_LAYOUT ( layoutspec )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SUB_LAYOUT, "SUB_LAYOUT"), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:705:45: ( layoutspec )*
            	    while ( stream_layoutspec.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_layoutspec.NextTree());

            	    }
            	    stream_layoutspec.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "layout"

    public class layoutspec_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "layoutspec"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:707:1: layoutspec : ( AFTER | BEFORE | AT | FROM variable TO ) variable ( layoutstyle )* ;
    public BlaiseParser.layoutspec_return layoutspec() // throws RecognitionException [1]
    {   
        BlaiseParser.layoutspec_return retval = new BlaiseParser.layoutspec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken AFTER98 = null;
        IToken BEFORE99 = null;
        IToken AT100 = null;
        IToken FROM101 = null;
        IToken TO103 = null;
        BlaiseParser.variable_return variable102 = default(BlaiseParser.variable_return);

        BlaiseParser.variable_return variable104 = default(BlaiseParser.variable_return);

        BlaiseParser.layoutstyle_return layoutstyle105 = default(BlaiseParser.layoutstyle_return);


        object AFTER98_tree=null;
        object BEFORE99_tree=null;
        object AT100_tree=null;
        object FROM101_tree=null;
        object TO103_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:708:2: ( ( AFTER | BEFORE | AT | FROM variable TO ) variable ( layoutstyle )* )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:708:4: ( AFTER | BEFORE | AT | FROM variable TO ) variable ( layoutstyle )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:708:4: ( AFTER | BEFORE | AT | FROM variable TO )
            	int alt36 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case AFTER:
            		{
            	    alt36 = 1;
            	    }
            	    break;
            	case BEFORE:
            		{
            	    alt36 = 2;
            	    }
            	    break;
            	case AT:
            		{
            	    alt36 = 3;
            	    }
            	    break;
            	case FROM:
            		{
            	    alt36 = 4;
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    NoViableAltException nvae_d36s0 =
            		        new NoViableAltException("", 36, 0, input);

            		    throw nvae_d36s0;
            	}

            	switch (alt36) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:708:5: AFTER
            	        {
            	        	AFTER98=(IToken)Match(input,AFTER,FOLLOW_AFTER_in_layoutspec4419); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{AFTER98_tree = (object)adaptor.Create(AFTER98);
            	        		root_0 = (object)adaptor.BecomeRoot(AFTER98_tree, root_0);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:708:14: BEFORE
            	        {
            	        	BEFORE99=(IToken)Match(input,BEFORE,FOLLOW_BEFORE_in_layoutspec4424); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{BEFORE99_tree = (object)adaptor.Create(BEFORE99);
            	        		root_0 = (object)adaptor.BecomeRoot(BEFORE99_tree, root_0);
            	        	}

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:708:24: AT
            	        {
            	        	AT100=(IToken)Match(input,AT,FOLLOW_AT_in_layoutspec4429); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{AT100_tree = (object)adaptor.Create(AT100);
            	        		root_0 = (object)adaptor.BecomeRoot(AT100_tree, root_0);
            	        	}

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:708:30: FROM variable TO
            	        {
            	        	FROM101=(IToken)Match(input,FROM,FOLLOW_FROM_in_layoutspec4434); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{FROM101_tree = (object)adaptor.Create(FROM101);
            	        		root_0 = (object)adaptor.BecomeRoot(FROM101_tree, root_0);
            	        	}
            	        	PushFollow(FOLLOW_variable_in_layoutspec4437);
            	        	variable102 = variable();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable102.Tree);
            	        	TO103=(IToken)Match(input,TO,FOLLOW_TO_in_layoutspec4439); if (state.failed) return retval;

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_variable_in_layoutspec4443);
            	variable104 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable104.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:708:59: ( layoutstyle )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == NEWPAGE || (LA37_0 >= INFOPANE && LA37_0 <= NEWCOLUMN)) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: layoutstyle
            			    {
            			    	PushFollow(FOLLOW_layoutstyle_in_layoutspec4445);
            			    	layoutstyle105 = layoutstyle();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, layoutstyle105.Tree);

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "layoutspec"

    public class layoutstyle_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "layoutstyle"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:710:1: layoutstyle : ( ruleslayoutstyle | INFOPANE variable | GRID variable | FIELDPANE variable );
    public BlaiseParser.layoutstyle_return layoutstyle() // throws RecognitionException [1]
    {   
        BlaiseParser.layoutstyle_return retval = new BlaiseParser.layoutstyle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INFOPANE107 = null;
        IToken GRID109 = null;
        IToken FIELDPANE111 = null;
        BlaiseParser.ruleslayoutstyle_return ruleslayoutstyle106 = default(BlaiseParser.ruleslayoutstyle_return);

        BlaiseParser.variable_return variable108 = default(BlaiseParser.variable_return);

        BlaiseParser.variable_return variable110 = default(BlaiseParser.variable_return);

        BlaiseParser.variable_return variable112 = default(BlaiseParser.variable_return);


        object INFOPANE107_tree=null;
        object GRID109_tree=null;
        object FIELDPANE111_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:711:2: ( ruleslayoutstyle | INFOPANE variable | GRID variable | FIELDPANE variable )
            int alt38 = 4;
            switch ( input.LA(1) ) 
            {
            case NEWPAGE:
            case DUMMY:
            case T_NEWLINE:
            case NEWCOLUMN:
            	{
                alt38 = 1;
                }
                break;
            case INFOPANE:
            	{
                alt38 = 2;
                }
                break;
            case GRID:
            	{
                alt38 = 3;
                }
                break;
            case FIELDPANE:
            	{
                alt38 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d38s0 =
            	        new NoViableAltException("", 38, 0, input);

            	    throw nvae_d38s0;
            }

            switch (alt38) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:712:2: ruleslayoutstyle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleslayoutstyle_in_layoutstyle4458);
                    	ruleslayoutstyle106 = ruleslayoutstyle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ruleslayoutstyle106.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:713:4: INFOPANE variable
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	INFOPANE107=(IToken)Match(input,INFOPANE,FOLLOW_INFOPANE_in_layoutstyle4463); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{INFOPANE107_tree = (object)adaptor.Create(INFOPANE107);
                    		adaptor.AddChild(root_0, INFOPANE107_tree);
                    	}
                    	PushFollow(FOLLOW_variable_in_layoutstyle4465);
                    	variable108 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable108.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:714:4: GRID variable
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	GRID109=(IToken)Match(input,GRID,FOLLOW_GRID_in_layoutstyle4471); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{GRID109_tree = (object)adaptor.Create(GRID109);
                    		adaptor.AddChild(root_0, GRID109_tree);
                    	}
                    	PushFollow(FOLLOW_variable_in_layoutstyle4473);
                    	variable110 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable110.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:715:4: FIELDPANE variable
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FIELDPANE111=(IToken)Match(input,FIELDPANE,FOLLOW_FIELDPANE_in_layoutstyle4479); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FIELDPANE111_tree = (object)adaptor.Create(FIELDPANE111);
                    		adaptor.AddChild(root_0, FIELDPANE111_tree);
                    	}
                    	PushFollow(FOLLOW_variable_in_layoutstyle4481);
                    	variable112 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable112.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "layoutstyle"

    public class ruleslayoutstyle_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ruleslayoutstyle"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:717:1: ruleslayoutstyle : ( DUMMY | NEWPAGE | T_NEWLINE | NEWCOLUMN );
    public BlaiseParser.ruleslayoutstyle_return ruleslayoutstyle() // throws RecognitionException [1]
    {   
        BlaiseParser.ruleslayoutstyle_return retval = new BlaiseParser.ruleslayoutstyle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set113 = null;

        object set113_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:718:2: ( DUMMY | NEWPAGE | T_NEWLINE | NEWCOLUMN )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set113 = (IToken)input.LT(1);
            	if ( input.LA(1) == NEWPAGE || (input.LA(1) >= DUMMY && input.LA(1) <= NEWCOLUMN) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set113));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ruleslayoutstyle"

    public class type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "type"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:726:1: type : TYPE ( type_item )* -> ^( SUB_TYPE ( type_item )* ) ;
    public BlaiseParser.type_return type() // throws RecognitionException [1]
    {   
        BlaiseParser.type_return retval = new BlaiseParser.type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TYPE114 = null;
        BlaiseParser.type_item_return type_item115 = default(BlaiseParser.type_item_return);


        object TYPE114_tree=null;
        RewriteRuleTokenStream stream_TYPE = new RewriteRuleTokenStream(adaptor,"token TYPE");
        RewriteRuleSubtreeStream stream_type_item = new RewriteRuleSubtreeStream(adaptor,"rule type_item");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:726:6: ( TYPE ( type_item )* -> ^( SUB_TYPE ( type_item )* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:726:8: TYPE ( type_item )*
            {
            	TYPE114=(IToken)Match(input,TYPE,FOLLOW_TYPE_in_type4520); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_TYPE.Add(TYPE114);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:726:13: ( type_item )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( (LA39_0 == ID) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: type_item
            			    {
            			    	PushFollow(FOLLOW_type_item_in_type4522);
            			    	type_item115 = type_item();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_type_item.Add(type_item115.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements



            	// AST REWRITE
            	// elements:          type_item
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 726:23: -> ^( SUB_TYPE ( type_item )* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:726:26: ^( SUB_TYPE ( type_item )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SUB_TYPE, "SUB_TYPE"), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:726:37: ( type_item )*
            	    while ( stream_type_item.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_type_item.NextTree());

            	    }
            	    stream_type_item.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type"

    public class type_item_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "type_item"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:727:1: type_item : ID '=' typedef -> ^( TYPE_ITEM ID typedef ) ;
    public BlaiseParser.type_item_return type_item() // throws RecognitionException [1]
    {   
        BlaiseParser.type_item_return retval = new BlaiseParser.type_item_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID116 = null;
        IToken char_literal117 = null;
        BlaiseParser.typedef_return typedef118 = default(BlaiseParser.typedef_return);


        object ID116_tree=null;
        object char_literal117_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_EQUAL = new RewriteRuleTokenStream(adaptor,"token EQUAL");
        RewriteRuleSubtreeStream stream_typedef = new RewriteRuleSubtreeStream(adaptor,"rule typedef");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:728:2: ( ID '=' typedef -> ^( TYPE_ITEM ID typedef ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:728:4: ID '=' typedef
            {
            	ID116=(IToken)Match(input,ID,FOLLOW_ID_in_type_item4540); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID116);

            	char_literal117=(IToken)Match(input,EQUAL,FOLLOW_EQUAL_in_type_item4542); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EQUAL.Add(char_literal117);

            	PushFollow(FOLLOW_typedef_in_type_item4544);
            	typedef118 = typedef();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_typedef.Add(typedef118.Tree);


            	// AST REWRITE
            	// elements:          typedef, ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 728:18: -> ^( TYPE_ITEM ID typedef )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:728:21: ^( TYPE_ITEM ID typedef )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_ITEM, "TYPE_ITEM"), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    adaptor.AddChild(root_1, stream_typedef.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type_item"

    public class locals_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "locals"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:732:1: locals : ( LOCALS | VAR ) ( field )* -> ^( SUB_LOCALS ( field )* ) ;
    public BlaiseParser.locals_return locals() // throws RecognitionException [1]
    {   
        BlaiseParser.locals_return retval = new BlaiseParser.locals_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOCALS119 = null;
        IToken VAR120 = null;
        BlaiseParser.field_return field121 = default(BlaiseParser.field_return);


        object LOCALS119_tree=null;
        object VAR120_tree=null;
        RewriteRuleTokenStream stream_LOCALS = new RewriteRuleTokenStream(adaptor,"token LOCALS");
        RewriteRuleTokenStream stream_VAR = new RewriteRuleTokenStream(adaptor,"token VAR");
        RewriteRuleSubtreeStream stream_field = new RewriteRuleSubtreeStream(adaptor,"rule field");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:732:8: ( ( LOCALS | VAR ) ( field )* -> ^( SUB_LOCALS ( field )* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:732:10: ( LOCALS | VAR ) ( field )*
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:732:10: ( LOCALS | VAR )
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( (LA40_0 == LOCALS) )
            	{
            	    alt40 = 1;
            	}
            	else if ( (LA40_0 == VAR) )
            	{
            	    alt40 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d40s0 =
            	        new NoViableAltException("", 40, 0, input);

            	    throw nvae_d40s0;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:732:11: LOCALS
            	        {
            	        	LOCALS119=(IToken)Match(input,LOCALS,FOLLOW_LOCALS_in_locals4564); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_LOCALS.Add(LOCALS119);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:732:20: VAR
            	        {
            	        	VAR120=(IToken)Match(input,VAR,FOLLOW_VAR_in_locals4568); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_VAR.Add(VAR120);


            	        }
            	        break;

            	}

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:732:25: ( field )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( (LA41_0 == ID) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: field
            			    {
            			    	PushFollow(FOLLOW_field_in_locals4571);
            			    	field121 = field();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_field.Add(field121.Tree);

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements



            	// AST REWRITE
            	// elements:          field
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 732:32: -> ^( SUB_LOCALS ( field )* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:732:35: ^( SUB_LOCALS ( field )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SUB_LOCALS, "SUB_LOCALS"), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:732:48: ( field )*
            	    while ( stream_field.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_field.NextTree());

            	    }
            	    stream_field.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "locals"

    public class rules_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "rules"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:738:1: rules : RULES ( statement ( SEMI )? )* ;
    public BlaiseParser.rules_return rules() // throws RecognitionException [1]
    {   
        BlaiseParser.rules_return retval = new BlaiseParser.rules_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken RULES122 = null;
        IToken SEMI124 = null;
        BlaiseParser.statement_return statement123 = default(BlaiseParser.statement_return);


        object RULES122_tree=null;
        object SEMI124_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:738:7: ( RULES ( statement ( SEMI )? )* )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:738:9: RULES ( statement ( SEMI )? )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	RULES122=(IToken)Match(input,RULES,FOLLOW_RULES_in_rules4594); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RULES122_tree = (object)adaptor.Create(RULES122);
            		root_0 = (object)adaptor.BecomeRoot(RULES122_tree, root_0);
            	}
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:738:16: ( statement ( SEMI )? )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( (LA43_0 == QSTRING || LA43_0 == NEWPAGE || LA43_0 == ERROR || (LA43_0 >= FOR && LA43_0 <= WHILE) || (LA43_0 >= SIGNAL && LA43_0 <= CHECK) || (LA43_0 >= CATI && LA43_0 <= CAPI) || (LA43_0 >= EMPTY && LA43_0 <= DK) || (LA43_0 >= DUMMY && LA43_0 <= NEWCOLUMN) || LA43_0 == RESERVECHECK || LA43_0 == IF || LA43_0 == NOT || LA43_0 == CHAR || (LA43_0 >= POSITION && LA43_0 <= MINUS) || LA43_0 == LPAREN || LA43_0 == INT || (LA43_0 >= SQSTRING && LA43_0 <= ID)) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:738:17: statement ( SEMI )?
            			    {
            			    	PushFollow(FOLLOW_statement_in_rules4598);
            			    	statement123 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement123.Tree);
            			    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:738:27: ( SEMI )?
            			    	int alt42 = 2;
            			    	int LA42_0 = input.LA(1);

            			    	if ( (LA42_0 == SEMI) )
            			    	{
            			    	    alt42 = 1;
            			    	}
            			    	switch (alt42) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: SEMI
            			    	        {
            			    	        	SEMI124=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_rules4600); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{SEMI124_tree = (object)adaptor.Create(SEMI124);
            			    	        		adaptor.AddChild(root_0, SEMI124_tree);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "rules"

    public class statement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statement"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:740:1: statement : ( ifblock | whiledoblock | fordoblock | ruleslayoutstyle | RESERVECHECK | ( SIGNAL | CHECK ) | ( ID ASSIGN )=> assignment | ( variable ASSIGN )=> assignment | ask_or_check );
    public BlaiseParser.statement_return statement() // throws RecognitionException [1]
    {   
        BlaiseParser.statement_return retval = new BlaiseParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken RESERVECHECK129 = null;
        IToken set130 = null;
        BlaiseParser.ifblock_return ifblock125 = default(BlaiseParser.ifblock_return);

        BlaiseParser.whiledoblock_return whiledoblock126 = default(BlaiseParser.whiledoblock_return);

        BlaiseParser.fordoblock_return fordoblock127 = default(BlaiseParser.fordoblock_return);

        BlaiseParser.ruleslayoutstyle_return ruleslayoutstyle128 = default(BlaiseParser.ruleslayoutstyle_return);

        BlaiseParser.assignment_return assignment131 = default(BlaiseParser.assignment_return);

        BlaiseParser.assignment_return assignment132 = default(BlaiseParser.assignment_return);

        BlaiseParser.ask_or_check_return ask_or_check133 = default(BlaiseParser.ask_or_check_return);


        object RESERVECHECK129_tree=null;
        object set130_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:741:2: ( ifblock | whiledoblock | fordoblock | ruleslayoutstyle | RESERVECHECK | ( SIGNAL | CHECK ) | ( ID ASSIGN )=> assignment | ( variable ASSIGN )=> assignment | ask_or_check )
            int alt44 = 9;
            alt44 = dfa44.Predict(input);
            switch (alt44) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:741:4: ifblock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifblock_in_statement4613);
                    	ifblock125 = ifblock();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifblock125.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:742:4: whiledoblock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whiledoblock_in_statement4619);
                    	whiledoblock126 = whiledoblock();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whiledoblock126.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:743:4: fordoblock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fordoblock_in_statement4625);
                    	fordoblock127 = fordoblock();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, fordoblock127.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:744:4: ruleslayoutstyle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ruleslayoutstyle_in_statement4631);
                    	ruleslayoutstyle128 = ruleslayoutstyle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ruleslayoutstyle128.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:745:4: RESERVECHECK
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	RESERVECHECK129=(IToken)Match(input,RESERVECHECK,FOLLOW_RESERVECHECK_in_statement4636); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{RESERVECHECK129_tree = (object)adaptor.Create(RESERVECHECK129);
                    		adaptor.AddChild(root_0, RESERVECHECK129_tree);
                    	}

                    }
                    break;
                case 6 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:746:4: ( SIGNAL | CHECK )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	set130 = (IToken)input.LT(1);
                    	if ( (input.LA(1) >= SIGNAL && input.LA(1) <= CHECK) ) 
                    	{
                    	    input.Consume();
                    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set130));
                    	    state.errorRecovery = false;state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}


                    }
                    break;
                case 7 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:748:4: ( ID ASSIGN )=> assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_statement4662);
                    	assignment131 = assignment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment131.Tree);

                    }
                    break;
                case 8 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:750:4: ( variable ASSIGN )=> assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_statement4678);
                    	assignment132 = assignment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment132.Tree);

                    }
                    break;
                case 9 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:752:4: ask_or_check
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ask_or_check_in_statement4686);
                    	ask_or_check133 = ask_or_check();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ask_or_check133.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class ask_or_check_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ask_or_check"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:757:1: ask_or_check : ( ( expression QSTRING )=> expression a= QSTRING | expression );
    public BlaiseParser.ask_or_check_return ask_or_check() // throws RecognitionException [1]
    {   
        BlaiseParser.ask_or_check_return retval = new BlaiseParser.ask_or_check_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        BlaiseParser.expression_return expression134 = default(BlaiseParser.expression_return);

        BlaiseParser.expression_return expression135 = default(BlaiseParser.expression_return);


        object a_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:758:3: ( ( expression QSTRING )=> expression a= QSTRING | expression )
            int alt45 = 2;
            alt45 = dfa45.Predict(input);
            switch (alt45) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:758:5: ( expression QSTRING )=> expression a= QSTRING
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_ask_or_check4710);
                    	expression134 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression134.Tree);
                    	a=(IToken)Match(input,QSTRING,FOLLOW_QSTRING_in_ask_or_check4715); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{a_tree = (object)adaptor.Create(a);
                    		adaptor.AddChild(root_0, a_tree);
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:759:6: expression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_ask_or_check4723);
                    	expression135 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression135.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ask_or_check"

    public class assignment_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignment"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:762:1: assignment : a= variable ASSIGN ( ( '[' )=>b= rightofin | c= simpleExpression ) -> ^( ASSIGN $a ( $b)? ( $c)? ) ;
    public BlaiseParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        BlaiseParser.assignment_return retval = new BlaiseParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGN136 = null;
        BlaiseParser.variable_return a = default(BlaiseParser.variable_return);

        BlaiseParser.rightofin_return b = default(BlaiseParser.rightofin_return);

        BlaiseParser.simpleExpression_return c = default(BlaiseParser.simpleExpression_return);


        object ASSIGN136_tree=null;
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_rightofin = new RewriteRuleSubtreeStream(adaptor,"rule rightofin");
        RewriteRuleSubtreeStream stream_simpleExpression = new RewriteRuleSubtreeStream(adaptor,"rule simpleExpression");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:763:2: (a= variable ASSIGN ( ( '[' )=>b= rightofin | c= simpleExpression ) -> ^( ASSIGN $a ( $b)? ( $c)? ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:763:4: a= variable ASSIGN ( ( '[' )=>b= rightofin | c= simpleExpression )
            {
            	PushFollow(FOLLOW_variable_in_assignment4738);
            	a = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(a.Tree);
            	ASSIGN136=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment4740); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN136);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:763:22: ( ( '[' )=>b= rightofin | c= simpleExpression )
            	int alt46 = 2;
            	int LA46_0 = input.LA(1);

            	if ( (LA46_0 == LBRACK) && (synpred84_Blaise()) )
            	{
            	    alt46 = 1;
            	}
            	else if ( (LA46_0 == ID) )
            	{
            	    int LA46_2 = input.LA(2);

            	    if ( (synpred84_Blaise()) )
            	    {
            	        alt46 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt46 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d46s2 =
            	            new NoViableAltException("", 46, 2, input);

            	        throw nvae_d46s2;
            	    }
            	}
            	else if ( (LA46_0 == QSTRING || (LA46_0 >= EMPTY && LA46_0 <= DK) || LA46_0 == NOT || LA46_0 == CHAR || (LA46_0 >= POSITION && LA46_0 <= MINUS) || LA46_0 == LPAREN || LA46_0 == INT || LA46_0 == SQSTRING) )
            	{
            	    alt46 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d46s0 =
            	        new NoViableAltException("", 46, 0, input);

            	    throw nvae_d46s0;
            	}
            	switch (alt46) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:764:3: ( '[' )=>b= rightofin
            	        {
            	        	PushFollow(FOLLOW_rightofin_in_assignment4754);
            	        	b = rightofin();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_rightofin.Add(b.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:765:5: c= simpleExpression
            	        {
            	        	PushFollow(FOLLOW_simpleExpression_in_assignment4763);
            	        	c = simpleExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_simpleExpression.Add(c.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          a, ASSIGN, c, b
            	// token labels:      
            	// rule labels:       retval, b, c, a
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "rule b", b!=null ? b.Tree : null);
            	RewriteRuleSubtreeStream stream_c = new RewriteRuleSubtreeStream(adaptor, "rule c", c!=null ? c.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 765:25: -> ^( ASSIGN $a ( $b)? ( $c)? )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:765:28: ^( ASSIGN $a ( $b)? ( $c)? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextTree());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:765:40: ( $b)?
            	    if ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextTree());

            	    }
            	    stream_b.Reset();
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:765:44: ( $c)?
            	    if ( stream_c.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_c.NextTree());

            	    }
            	    stream_c.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class variable_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variable"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:800:2: variable : ID (a+= variableSelector )* -> ^( VARIABLE ID ( $a)* ) ;
    public BlaiseParser.variable_return variable() // throws RecognitionException [1]
    {   
        BlaiseParser.variable_return retval = new BlaiseParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID137 = null;
        IList list_a = null;
        BlaiseParser.variableSelector_return a = default(BlaiseParser.variableSelector_return);
         a = null;
        object ID137_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_variableSelector = new RewriteRuleSubtreeStream(adaptor,"rule variableSelector");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:800:10: ( ID (a+= variableSelector )* -> ^( VARIABLE ID ( $a)* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:800:12: ID (a+= variableSelector )*
            {
            	ID137=(IToken)Match(input,ID,FOLLOW_ID_in_variable4798); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID137);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:800:15: (a+= variableSelector )*
            	do 
            	{
            	    int alt47 = 2;
            	    int LA47_0 = input.LA(1);

            	    if ( (LA47_0 == DOT) )
            	    {
            	        int LA47_2 = input.LA(2);

            	        if ( (LA47_2 == ID) )
            	        {
            	            alt47 = 1;
            	        }


            	    }
            	    else if ( (LA47_0 == LBRACK) )
            	    {
            	        alt47 = 1;
            	    }


            	    switch (alt47) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:800:16: a+= variableSelector
            			    {
            			    	PushFollow(FOLLOW_variableSelector_in_variable4803);
            			    	a = variableSelector();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_variableSelector.Add(a.Tree);
            			    	if (list_a == null) list_a = new ArrayList();
            			    	list_a.Add(a.Tree);


            			    }
            			    break;

            			default:
            			    goto loop47;
            	    }
            	} while (true);

            	loop47:
            		;	// Stops C# compiler whining that label 'loop47' has no statements



            	// AST REWRITE
            	// elements:          ID, a
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  a
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "token a", list_a);
            	root_0 = (object)adaptor.GetNilNode();
            	// 800:38: -> ^( VARIABLE ID ( $a)* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:800:41: ^( VARIABLE ID ( $a)* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARIABLE, "VARIABLE"), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:800:55: ( $a)*
            	    while ( stream_a.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_a.NextTree());

            	    }
            	    stream_a.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variable"

    public class variableSelector_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableSelector"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:802:2: variableSelector : ( '.' selector= ID -> ^( SELECTOR $selector) | '[' simpleExpression ']' -> ^( ARRAY_INDEX simpleExpression ) );
    public BlaiseParser.variableSelector_return variableSelector() // throws RecognitionException [1]
    {   
        BlaiseParser.variableSelector_return retval = new BlaiseParser.variableSelector_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken selector = null;
        IToken char_literal138 = null;
        IToken char_literal139 = null;
        IToken char_literal141 = null;
        BlaiseParser.simpleExpression_return simpleExpression140 = default(BlaiseParser.simpleExpression_return);


        object selector_tree=null;
        object char_literal138_tree=null;
        object char_literal139_tree=null;
        object char_literal141_tree=null;
        RewriteRuleTokenStream stream_RBRACK = new RewriteRuleTokenStream(adaptor,"token RBRACK");
        RewriteRuleTokenStream stream_LBRACK = new RewriteRuleTokenStream(adaptor,"token LBRACK");
        RewriteRuleTokenStream stream_DOT = new RewriteRuleTokenStream(adaptor,"token DOT");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_simpleExpression = new RewriteRuleSubtreeStream(adaptor,"rule simpleExpression");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:802:19: ( '.' selector= ID -> ^( SELECTOR $selector) | '[' simpleExpression ']' -> ^( ARRAY_INDEX simpleExpression ) )
            int alt48 = 2;
            int LA48_0 = input.LA(1);

            if ( (LA48_0 == DOT) )
            {
                alt48 = 1;
            }
            else if ( (LA48_0 == LBRACK) )
            {
                alt48 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d48s0 =
                    new NoViableAltException("", 48, 0, input);

                throw nvae_d48s0;
            }
            switch (alt48) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:802:21: '.' selector= ID
                    {
                    	char_literal138=(IToken)Match(input,DOT,FOLLOW_DOT_in_variableSelector4827); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DOT.Add(char_literal138);

                    	selector=(IToken)Match(input,ID,FOLLOW_ID_in_variableSelector4831); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_ID.Add(selector);



                    	// AST REWRITE
                    	// elements:          selector
                    	// token labels:      selector
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleTokenStream stream_selector = new RewriteRuleTokenStream(adaptor, "token selector", selector);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 802:37: -> ^( SELECTOR $selector)
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:802:40: ^( SELECTOR $selector)
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(SELECTOR, "SELECTOR"), root_1);

                    	    adaptor.AddChild(root_1, stream_selector.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:803:8: '[' simpleExpression ']'
                    {
                    	char_literal139=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_variableSelector4849); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LBRACK.Add(char_literal139);

                    	PushFollow(FOLLOW_simpleExpression_in_variableSelector4851);
                    	simpleExpression140 = simpleExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_simpleExpression.Add(simpleExpression140.Tree);
                    	char_literal141=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_variableSelector4853); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RBRACK.Add(char_literal141);



                    	// AST REWRITE
                    	// elements:          simpleExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 803:33: -> ^( ARRAY_INDEX simpleExpression )
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:803:36: ^( ARRAY_INDEX simpleExpression )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_INDEX, "ARRAY_INDEX"), root_1);

                    	    adaptor.AddChild(root_1, stream_simpleExpression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableSelector"

    public class builtinfuction_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "builtinfuction"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:814:1: builtinfuction : (a= POSITION LPAREN b= parameterList RPAREN | a= UPPERCASE LPAREN c= simpleExpression RPAREN ) -> ^( BUILTIN_FUNCTION $a ( $b)? ( $c)? ) ;
    public BlaiseParser.builtinfuction_return builtinfuction() // throws RecognitionException [1]
    {   
        BlaiseParser.builtinfuction_return retval = new BlaiseParser.builtinfuction_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken LPAREN142 = null;
        IToken RPAREN143 = null;
        IToken LPAREN144 = null;
        IToken RPAREN145 = null;
        BlaiseParser.parameterList_return b = default(BlaiseParser.parameterList_return);

        BlaiseParser.simpleExpression_return c = default(BlaiseParser.simpleExpression_return);


        object a_tree=null;
        object LPAREN142_tree=null;
        object RPAREN143_tree=null;
        object LPAREN144_tree=null;
        object RPAREN145_tree=null;
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_UPPERCASE = new RewriteRuleTokenStream(adaptor,"token UPPERCASE");
        RewriteRuleTokenStream stream_POSITION = new RewriteRuleTokenStream(adaptor,"token POSITION");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_parameterList = new RewriteRuleSubtreeStream(adaptor,"rule parameterList");
        RewriteRuleSubtreeStream stream_simpleExpression = new RewriteRuleSubtreeStream(adaptor,"rule simpleExpression");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:815:2: ( (a= POSITION LPAREN b= parameterList RPAREN | a= UPPERCASE LPAREN c= simpleExpression RPAREN ) -> ^( BUILTIN_FUNCTION $a ( $b)? ( $c)? ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:815:3: (a= POSITION LPAREN b= parameterList RPAREN | a= UPPERCASE LPAREN c= simpleExpression RPAREN )
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:815:3: (a= POSITION LPAREN b= parameterList RPAREN | a= UPPERCASE LPAREN c= simpleExpression RPAREN )
            	int alt49 = 2;
            	int LA49_0 = input.LA(1);

            	if ( (LA49_0 == POSITION) )
            	{
            	    alt49 = 1;
            	}
            	else if ( (LA49_0 == UPPERCASE) )
            	{
            	    alt49 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d49s0 =
            	        new NoViableAltException("", 49, 0, input);

            	    throw nvae_d49s0;
            	}
            	switch (alt49) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:816:2: a= POSITION LPAREN b= parameterList RPAREN
            	        {
            	        	a=(IToken)Match(input,POSITION,FOLLOW_POSITION_in_builtinfuction4884); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_POSITION.Add(a);

            	        	LPAREN142=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_builtinfuction4886); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN142);

            	        	PushFollow(FOLLOW_parameterList_in_builtinfuction4890);
            	        	b = parameterList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_parameterList.Add(b.Tree);
            	        	RPAREN143=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_builtinfuction4893); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN143);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:817:3: a= UPPERCASE LPAREN c= simpleExpression RPAREN
            	        {
            	        	a=(IToken)Match(input,UPPERCASE,FOLLOW_UPPERCASE_in_builtinfuction4899); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_UPPERCASE.Add(a);

            	        	LPAREN144=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_builtinfuction4901); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN144);

            	        	PushFollow(FOLLOW_simpleExpression_in_builtinfuction4905);
            	        	c = simpleExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_simpleExpression.Add(c.Tree);
            	        	RPAREN145=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_builtinfuction4908); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN145);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          c, b, a
            	// token labels:      a
            	// rule labels:       retval, b, c
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_a = new RewriteRuleTokenStream(adaptor, "token a", a);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "rule b", b!=null ? b.Tree : null);
            	RewriteRuleSubtreeStream stream_c = new RewriteRuleSubtreeStream(adaptor, "rule c", c!=null ? c.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 818:4: -> ^( BUILTIN_FUNCTION $a ( $b)? ( $c)? )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:818:7: ^( BUILTIN_FUNCTION $a ( $b)? ( $c)? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BUILTIN_FUNCTION, "BUILTIN_FUNCTION"), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextNode());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:818:29: ( $b)?
            	    if ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextTree());

            	    }
            	    stream_b.Reset();
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:818:33: ( $c)?
            	    if ( stream_c.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_c.NextTree());

            	    }
            	    stream_c.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "builtinfuction"

    public class builtinBools_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "builtinBools"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:821:1: builtinBools : ( CATI | CAPI | ERROR );
    public BlaiseParser.builtinBools_return builtinBools() // throws RecognitionException [1]
    {   
        BlaiseParser.builtinBools_return retval = new BlaiseParser.builtinBools_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set146 = null;

        object set146_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:822:2: ( CATI | CAPI | ERROR )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set146 = (IToken)input.LT(1);
            	if ( input.LA(1) == ERROR || (input.LA(1) >= CATI && input.LA(1) <= CAPI) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set146));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "builtinBools"

    public class expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expression"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:824:1: expression : a= noparenexpression (c+= ( ( AND | OR ) noparenexpression ) )* (b= involving )? ;
    public BlaiseParser.expression_return expression() // throws RecognitionException [1]
    {   
        BlaiseParser.expression_return retval = new BlaiseParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set147 = null;
        IToken c = null;
        IList list_c = null;
        BlaiseParser.noparenexpression_return a = default(BlaiseParser.noparenexpression_return);

        BlaiseParser.involving_return b = default(BlaiseParser.involving_return);

        BlaiseParser.noparenexpression_return noparenexpression148 = default(BlaiseParser.noparenexpression_return);


        object set147_tree=null;
        object c_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:825:2: (a= noparenexpression (c+= ( ( AND | OR ) noparenexpression ) )* (b= involving )? )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:825:4: a= noparenexpression (c+= ( ( AND | OR ) noparenexpression ) )* (b= involving )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_noparenexpression_in_expression4961);
            	a = noparenexpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:825:25: (c+= ( ( AND | OR ) noparenexpression ) )*
            	do 
            	{
            	    int alt50 = 2;
            	    int LA50_0 = input.LA(1);

            	    if ( ((LA50_0 >= AND && LA50_0 <= OR)) )
            	    {
            	        alt50 = 1;
            	    }


            	    switch (alt50) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: c+= ( ( AND | OR ) noparenexpression )
            			    {
            			    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:825:27: ( ( AND | OR ) noparenexpression )
            			    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:825:29: ( AND | OR ) noparenexpression
            			    	{
            			    		set147 = (IToken)input.LT(1);
            			    		if ( (input.LA(1) >= AND && input.LA(1) <= OR) ) 
            			    		{
            			    		    input.Consume();
            			    		    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set147));
            			    		    state.errorRecovery = false;state.failed = false;
            			    		}
            			    		else 
            			    		{
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    		    throw mse;
            			    		}

            			    		PushFollow(FOLLOW_noparenexpression_in_expression4975);
            			    		noparenexpression148 = noparenexpression();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, noparenexpression148.Tree);

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop50;
            	    }
            	} while (true);

            	loop50:
            		;	// Stops C# compiler whining that label 'loop50' has no statements

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:825:61: (b= involving )?
            	int alt51 = 2;
            	int LA51_0 = input.LA(1);

            	if ( (LA51_0 == INVOLVING) )
            	{
            	    alt51 = 1;
            	}
            	switch (alt51) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: b= involving
            	        {
            	        	PushFollow(FOLLOW_involving_in_expression4981);
            	        	b = involving();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, b.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class involving_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "involving"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:829:1: involving : INVOLVING '(' var_list ')' ;
    public BlaiseParser.involving_return involving() // throws RecognitionException [1]
    {   
        BlaiseParser.involving_return retval = new BlaiseParser.involving_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INVOLVING149 = null;
        IToken char_literal150 = null;
        IToken char_literal152 = null;
        BlaiseParser.var_list_return var_list151 = default(BlaiseParser.var_list_return);


        object INVOLVING149_tree=null;
        object char_literal150_tree=null;
        object char_literal152_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:830:2: ( INVOLVING '(' var_list ')' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:830:4: INVOLVING '(' var_list ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INVOLVING149=(IToken)Match(input,INVOLVING,FOLLOW_INVOLVING_in_involving4996); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{INVOLVING149_tree = (object)adaptor.Create(INVOLVING149);
            		root_0 = (object)adaptor.BecomeRoot(INVOLVING149_tree, root_0);
            	}
            	char_literal150=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_involving4999); if (state.failed) return retval;
            	PushFollow(FOLLOW_var_list_in_involving5002);
            	var_list151 = var_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, var_list151.Tree);
            	char_literal152=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_involving5004); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "involving"

    public class noparenexpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "noparenexpression"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:832:1: noparenexpression : a= ( builtinBools | simpleExpression ) ( ( EQUAL | NOT_EQUAL | LT | LE | GE | GT ) simpleExpression | IN rightofin )* ;
    public BlaiseParser.noparenexpression_return noparenexpression() // throws RecognitionException [1]
    {   
        BlaiseParser.noparenexpression_return retval = new BlaiseParser.noparenexpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken EQUAL155 = null;
        IToken NOT_EQUAL156 = null;
        IToken LT157 = null;
        IToken LE158 = null;
        IToken GE159 = null;
        IToken GT160 = null;
        IToken IN162 = null;
        BlaiseParser.builtinBools_return builtinBools153 = default(BlaiseParser.builtinBools_return);

        BlaiseParser.simpleExpression_return simpleExpression154 = default(BlaiseParser.simpleExpression_return);

        BlaiseParser.simpleExpression_return simpleExpression161 = default(BlaiseParser.simpleExpression_return);

        BlaiseParser.rightofin_return rightofin163 = default(BlaiseParser.rightofin_return);


        object a_tree=null;
        object EQUAL155_tree=null;
        object NOT_EQUAL156_tree=null;
        object LT157_tree=null;
        object LE158_tree=null;
        object GE159_tree=null;
        object GT160_tree=null;
        object IN162_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:833:5: (a= ( builtinBools | simpleExpression ) ( ( EQUAL | NOT_EQUAL | LT | LE | GE | GT ) simpleExpression | IN rightofin )* )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:834:6: a= ( builtinBools | simpleExpression ) ( ( EQUAL | NOT_EQUAL | LT | LE | GE | GT ) simpleExpression | IN rightofin )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:834:8: ( builtinBools | simpleExpression )
            	int alt52 = 2;
            	int LA52_0 = input.LA(1);

            	if ( (LA52_0 == ERROR || (LA52_0 >= CATI && LA52_0 <= CAPI)) )
            	{
            	    alt52 = 1;
            	}
            	else if ( (LA52_0 == QSTRING || (LA52_0 >= EMPTY && LA52_0 <= DK) || LA52_0 == NOT || LA52_0 == CHAR || (LA52_0 >= POSITION && LA52_0 <= MINUS) || LA52_0 == LPAREN || LA52_0 == INT || (LA52_0 >= SQSTRING && LA52_0 <= ID)) )
            	{
            	    alt52 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d52s0 =
            	        new NoViableAltException("", 52, 0, input);

            	    throw nvae_d52s0;
            	}
            	switch (alt52) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:834:9: builtinBools
            	        {
            	        	PushFollow(FOLLOW_builtinBools_in_noparenexpression5033);
            	        	builtinBools153 = builtinBools();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, builtinBools153.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:835:8: simpleExpression
            	        {
            	        	PushFollow(FOLLOW_simpleExpression_in_noparenexpression5043);
            	        	simpleExpression154 = simpleExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleExpression154.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:837:12: ( ( EQUAL | NOT_EQUAL | LT | LE | GE | GT ) simpleExpression | IN rightofin )*
            	do 
            	{
            	    int alt54 = 3;
            	    int LA54_0 = input.LA(1);

            	    if ( ((LA54_0 >= EQUAL && LA54_0 <= GT)) )
            	    {
            	        alt54 = 1;
            	    }
            	    else if ( (LA54_0 == IN) )
            	    {
            	        alt54 = 2;
            	    }


            	    switch (alt54) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:838:12: ( EQUAL | NOT_EQUAL | LT | LE | GE | GT ) simpleExpression
            			    {
            			    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:838:12: ( EQUAL | NOT_EQUAL | LT | LE | GE | GT )
            			    	int alt53 = 6;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case EQUAL:
            			    		{
            			    	    alt53 = 1;
            			    	    }
            			    	    break;
            			    	case NOT_EQUAL:
            			    		{
            			    	    alt53 = 2;
            			    	    }
            			    	    break;
            			    	case LT:
            			    		{
            			    	    alt53 = 3;
            			    	    }
            			    	    break;
            			    	case LE:
            			    		{
            			    	    alt53 = 4;
            			    	    }
            			    	    break;
            			    	case GE:
            			    		{
            			    	    alt53 = 5;
            			    	    }
            			    	    break;
            			    	case GT:
            			    		{
            			    	    alt53 = 6;
            			    	    }
            			    	    break;
            			    		default:
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    NoViableAltException nvae_d53s0 =
            			    		        new NoViableAltException("", 53, 0, input);

            			    		    throw nvae_d53s0;
            			    	}

            			    	switch (alt53) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:838:13: EQUAL
            			    	        {
            			    	        	EQUAL155=(IToken)Match(input,EQUAL,FOLLOW_EQUAL_in_noparenexpression5080); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{EQUAL155_tree = (object)adaptor.Create(EQUAL155);
            			    	        		root_0 = (object)adaptor.BecomeRoot(EQUAL155_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:838:22: NOT_EQUAL
            			    	        {
            			    	        	NOT_EQUAL156=(IToken)Match(input,NOT_EQUAL,FOLLOW_NOT_EQUAL_in_noparenexpression5085); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{NOT_EQUAL156_tree = (object)adaptor.Create(NOT_EQUAL156);
            			    	        		root_0 = (object)adaptor.BecomeRoot(NOT_EQUAL156_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:838:35: LT
            			    	        {
            			    	        	LT157=(IToken)Match(input,LT,FOLLOW_LT_in_noparenexpression5090); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{LT157_tree = (object)adaptor.Create(LT157);
            			    	        		root_0 = (object)adaptor.BecomeRoot(LT157_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:838:41: LE
            			    	        {
            			    	        	LE158=(IToken)Match(input,LE,FOLLOW_LE_in_noparenexpression5095); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{LE158_tree = (object)adaptor.Create(LE158);
            			    	        		root_0 = (object)adaptor.BecomeRoot(LE158_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 5 :
            			    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:838:47: GE
            			    	        {
            			    	        	GE159=(IToken)Match(input,GE,FOLLOW_GE_in_noparenexpression5100); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{GE159_tree = (object)adaptor.Create(GE159);
            			    	        		root_0 = (object)adaptor.BecomeRoot(GE159_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 6 :
            			    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:838:53: GT
            			    	        {
            			    	        	GT160=(IToken)Match(input,GT,FOLLOW_GT_in_noparenexpression5105); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{GT160_tree = (object)adaptor.Create(GT160);
            			    	        		root_0 = (object)adaptor.BecomeRoot(GT160_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_simpleExpression_in_noparenexpression5109);
            			    	simpleExpression161 = simpleExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleExpression161.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:839:15: IN rightofin
            			    {
            			    	IN162=(IToken)Match(input,IN,FOLLOW_IN_in_noparenexpression5125); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{IN162_tree = (object)adaptor.Create(IN162);
            			    		root_0 = (object)adaptor.BecomeRoot(IN162_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_rightofin_in_noparenexpression5128);
            			    	rightofin163 = rightofin();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, rightofin163.Tree);

            			    }
            			    break;

            			default:
            			    goto loop54;
            	    }
            	} while (true);

            	loop54:
            		;	// Stops C# compiler whining that label 'loop54' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "noparenexpression"

    public class rightofin_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "rightofin"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:844:1: rightofin : ( '[' realrange ( ',' realrange )* ']' | '[' signedNumberOrRange ( ',' signedNumberOrRange )* ']' | '[' constantChr ( ',' constantChr )* ']' | '[' idOrIdRange ( ',' idOrIdRange )* ']' | variable );
    public BlaiseParser.rightofin_return rightofin() // throws RecognitionException [1]
    {   
        BlaiseParser.rightofin_return retval = new BlaiseParser.rightofin_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal164 = null;
        IToken char_literal166 = null;
        IToken char_literal168 = null;
        IToken char_literal169 = null;
        IToken char_literal171 = null;
        IToken char_literal173 = null;
        IToken char_literal174 = null;
        IToken char_literal176 = null;
        IToken char_literal178 = null;
        IToken char_literal179 = null;
        IToken char_literal181 = null;
        IToken char_literal183 = null;
        BlaiseParser.realrange_return realrange165 = default(BlaiseParser.realrange_return);

        BlaiseParser.realrange_return realrange167 = default(BlaiseParser.realrange_return);

        BlaiseParser.signedNumberOrRange_return signedNumberOrRange170 = default(BlaiseParser.signedNumberOrRange_return);

        BlaiseParser.signedNumberOrRange_return signedNumberOrRange172 = default(BlaiseParser.signedNumberOrRange_return);

        BlaiseParser.constantChr_return constantChr175 = default(BlaiseParser.constantChr_return);

        BlaiseParser.constantChr_return constantChr177 = default(BlaiseParser.constantChr_return);

        BlaiseParser.idOrIdRange_return idOrIdRange180 = default(BlaiseParser.idOrIdRange_return);

        BlaiseParser.idOrIdRange_return idOrIdRange182 = default(BlaiseParser.idOrIdRange_return);

        BlaiseParser.variable_return variable184 = default(BlaiseParser.variable_return);


        object char_literal164_tree=null;
        object char_literal166_tree=null;
        object char_literal168_tree=null;
        object char_literal169_tree=null;
        object char_literal171_tree=null;
        object char_literal173_tree=null;
        object char_literal174_tree=null;
        object char_literal176_tree=null;
        object char_literal178_tree=null;
        object char_literal179_tree=null;
        object char_literal181_tree=null;
        object char_literal183_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:845:2: ( '[' realrange ( ',' realrange )* ']' | '[' signedNumberOrRange ( ',' signedNumberOrRange )* ']' | '[' constantChr ( ',' constantChr )* ']' | '[' idOrIdRange ( ',' idOrIdRange )* ']' | variable )
            int alt59 = 5;
            alt59 = dfa59.Predict(input);
            switch (alt59) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:845:4: '[' realrange ( ',' realrange )* ']'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal164=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_rightofin5161); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal164_tree = (object)adaptor.Create(char_literal164);
                    		adaptor.AddChild(root_0, char_literal164_tree);
                    	}
                    	PushFollow(FOLLOW_realrange_in_rightofin5163);
                    	realrange165 = realrange();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, realrange165.Tree);
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:845:18: ( ',' realrange )*
                    	do 
                    	{
                    	    int alt55 = 2;
                    	    int LA55_0 = input.LA(1);

                    	    if ( (LA55_0 == COMMA) )
                    	    {
                    	        alt55 = 1;
                    	    }


                    	    switch (alt55) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:845:19: ',' realrange
                    			    {
                    			    	char_literal166=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_rightofin5166); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{char_literal166_tree = (object)adaptor.Create(char_literal166);
                    			    		adaptor.AddChild(root_0, char_literal166_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_realrange_in_rightofin5168);
                    			    	realrange167 = realrange();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, realrange167.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop55;
                    	    }
                    	} while (true);

                    	loop55:
                    		;	// Stops C# compiler whining that label 'loop55' has no statements

                    	char_literal168=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_rightofin5172); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal168_tree = (object)adaptor.Create(char_literal168);
                    		adaptor.AddChild(root_0, char_literal168_tree);
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:846:4: '[' signedNumberOrRange ( ',' signedNumberOrRange )* ']'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal169=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_rightofin5177); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal169_tree = (object)adaptor.Create(char_literal169);
                    		adaptor.AddChild(root_0, char_literal169_tree);
                    	}
                    	PushFollow(FOLLOW_signedNumberOrRange_in_rightofin5179);
                    	signedNumberOrRange170 = signedNumberOrRange();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signedNumberOrRange170.Tree);
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:846:28: ( ',' signedNumberOrRange )*
                    	do 
                    	{
                    	    int alt56 = 2;
                    	    int LA56_0 = input.LA(1);

                    	    if ( (LA56_0 == COMMA) )
                    	    {
                    	        alt56 = 1;
                    	    }


                    	    switch (alt56) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:846:29: ',' signedNumberOrRange
                    			    {
                    			    	char_literal171=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_rightofin5182); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{char_literal171_tree = (object)adaptor.Create(char_literal171);
                    			    		adaptor.AddChild(root_0, char_literal171_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_signedNumberOrRange_in_rightofin5184);
                    			    	signedNumberOrRange172 = signedNumberOrRange();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signedNumberOrRange172.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop56;
                    	    }
                    	} while (true);

                    	loop56:
                    		;	// Stops C# compiler whining that label 'loop56' has no statements

                    	char_literal173=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_rightofin5189); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal173_tree = (object)adaptor.Create(char_literal173);
                    		adaptor.AddChild(root_0, char_literal173_tree);
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:847:5: '[' constantChr ( ',' constantChr )* ']'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal174=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_rightofin5195); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal174_tree = (object)adaptor.Create(char_literal174);
                    		adaptor.AddChild(root_0, char_literal174_tree);
                    	}
                    	PushFollow(FOLLOW_constantChr_in_rightofin5197);
                    	constantChr175 = constantChr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constantChr175.Tree);
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:847:21: ( ',' constantChr )*
                    	do 
                    	{
                    	    int alt57 = 2;
                    	    int LA57_0 = input.LA(1);

                    	    if ( (LA57_0 == COMMA) )
                    	    {
                    	        alt57 = 1;
                    	    }


                    	    switch (alt57) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:847:22: ',' constantChr
                    			    {
                    			    	char_literal176=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_rightofin5200); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{char_literal176_tree = (object)adaptor.Create(char_literal176);
                    			    		adaptor.AddChild(root_0, char_literal176_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_constantChr_in_rightofin5202);
                    			    	constantChr177 = constantChr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constantChr177.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop57;
                    	    }
                    	} while (true);

                    	loop57:
                    		;	// Stops C# compiler whining that label 'loop57' has no statements

                    	char_literal178=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_rightofin5207); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal178_tree = (object)adaptor.Create(char_literal178);
                    		adaptor.AddChild(root_0, char_literal178_tree);
                    	}

                    }
                    break;
                case 4 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:848:5: '[' idOrIdRange ( ',' idOrIdRange )* ']'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal179=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_rightofin5213); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal179_tree = (object)adaptor.Create(char_literal179);
                    		adaptor.AddChild(root_0, char_literal179_tree);
                    	}
                    	PushFollow(FOLLOW_idOrIdRange_in_rightofin5215);
                    	idOrIdRange180 = idOrIdRange();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idOrIdRange180.Tree);
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:848:21: ( ',' idOrIdRange )*
                    	do 
                    	{
                    	    int alt58 = 2;
                    	    int LA58_0 = input.LA(1);

                    	    if ( (LA58_0 == COMMA) )
                    	    {
                    	        alt58 = 1;
                    	    }


                    	    switch (alt58) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:848:22: ',' idOrIdRange
                    			    {
                    			    	char_literal181=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_rightofin5218); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{char_literal181_tree = (object)adaptor.Create(char_literal181);
                    			    		adaptor.AddChild(root_0, char_literal181_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_idOrIdRange_in_rightofin5220);
                    			    	idOrIdRange182 = idOrIdRange();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, idOrIdRange182.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop58;
                    	    }
                    	} while (true);

                    	loop58:
                    		;	// Stops C# compiler whining that label 'loop58' has no statements

                    	char_literal183=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_rightofin5225); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal183_tree = (object)adaptor.Create(char_literal183);
                    		adaptor.AddChild(root_0, char_literal183_tree);
                    	}

                    }
                    break;
                case 5 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:849:5: variable
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_rightofin5231);
                    	variable184 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable184.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "rightofin"

    public class idOrIdRange_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "idOrIdRange"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:852:1: idOrIdRange : ( ID | ID DOTDOT ID );
    public BlaiseParser.idOrIdRange_return idOrIdRange() // throws RecognitionException [1]
    {   
        BlaiseParser.idOrIdRange_return retval = new BlaiseParser.idOrIdRange_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID185 = null;
        IToken ID186 = null;
        IToken DOTDOT187 = null;
        IToken ID188 = null;

        object ID185_tree=null;
        object ID186_tree=null;
        object DOTDOT187_tree=null;
        object ID188_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:853:2: ( ID | ID DOTDOT ID )
            int alt60 = 2;
            int LA60_0 = input.LA(1);

            if ( (LA60_0 == ID) )
            {
                int LA60_1 = input.LA(2);

                if ( (LA60_1 == DOTDOT) )
                {
                    alt60 = 2;
                }
                else if ( (LA60_1 == EOF || LA60_1 == COMMA || LA60_1 == RBRACK) )
                {
                    alt60 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d60s1 =
                        new NoViableAltException("", 60, 1, input);

                    throw nvae_d60s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d60s0 =
                    new NoViableAltException("", 60, 0, input);

                throw nvae_d60s0;
            }
            switch (alt60) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:853:4: ID
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ID185=(IToken)Match(input,ID,FOLLOW_ID_in_idOrIdRange5246); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID185_tree = (object)adaptor.Create(ID185);
                    		adaptor.AddChild(root_0, ID185_tree);
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:854:4: ID DOTDOT ID
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ID186=(IToken)Match(input,ID,FOLLOW_ID_in_idOrIdRange5251); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID186_tree = (object)adaptor.Create(ID186);
                    		adaptor.AddChild(root_0, ID186_tree);
                    	}
                    	DOTDOT187=(IToken)Match(input,DOTDOT,FOLLOW_DOTDOT_in_idOrIdRange5253); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DOTDOT187_tree = (object)adaptor.Create(DOTDOT187);
                    		adaptor.AddChild(root_0, DOTDOT187_tree);
                    	}
                    	ID188=(IToken)Match(input,ID,FOLLOW_ID_in_idOrIdRange5255); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID188_tree = (object)adaptor.Create(ID188);
                    		adaptor.AddChild(root_0, ID188_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "idOrIdRange"

    public class signedNumberOrRange_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "signedNumberOrRange"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:857:1: signedNumberOrRange : ( signedNumber | signedNumber DOTDOT signedNumber );
    public BlaiseParser.signedNumberOrRange_return signedNumberOrRange() // throws RecognitionException [1]
    {   
        BlaiseParser.signedNumberOrRange_return retval = new BlaiseParser.signedNumberOrRange_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DOTDOT191 = null;
        BlaiseParser.signedNumber_return signedNumber189 = default(BlaiseParser.signedNumber_return);

        BlaiseParser.signedNumber_return signedNumber190 = default(BlaiseParser.signedNumber_return);

        BlaiseParser.signedNumber_return signedNumber192 = default(BlaiseParser.signedNumber_return);


        object DOTDOT191_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:858:2: ( signedNumber | signedNumber DOTDOT signedNumber )
            int alt61 = 2;
            int LA61_0 = input.LA(1);

            if ( (LA61_0 == MINUS) )
            {
                int LA61_1 = input.LA(2);

                if ( (LA61_1 == INT) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case DOT:
                    	{
                        int LA61_3 = input.LA(4);

                        if ( (LA61_3 == INT) )
                        {
                            int LA61_6 = input.LA(5);

                            if ( (LA61_6 == EOF || LA61_6 == COMMA || LA61_6 == RBRACK) )
                            {
                                alt61 = 1;
                            }
                            else if ( (LA61_6 == DOTDOT) )
                            {
                                alt61 = 2;
                            }
                            else 
                            {
                                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                                NoViableAltException nvae_d61s6 =
                                    new NoViableAltException("", 61, 6, input);

                                throw nvae_d61s6;
                            }
                        }
                        else 
                        {
                            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                            NoViableAltException nvae_d61s3 =
                                new NoViableAltException("", 61, 3, input);

                            throw nvae_d61s3;
                        }
                        }
                        break;
                    case EOF:
                    case COMMA:
                    case RBRACK:
                    	{
                        alt61 = 1;
                        }
                        break;
                    case DOTDOT:
                    	{
                        alt61 = 2;
                        }
                        break;
                    	default:
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d61s2 =
                    	        new NoViableAltException("", 61, 2, input);

                    	    throw nvae_d61s2;
                    }

                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d61s1 =
                        new NoViableAltException("", 61, 1, input);

                    throw nvae_d61s1;
                }
            }
            else if ( (LA61_0 == INT) )
            {
                switch ( input.LA(2) ) 
                {
                case DOT:
                	{
                    int LA61_3 = input.LA(3);

                    if ( (LA61_3 == INT) )
                    {
                        int LA61_6 = input.LA(4);

                        if ( (LA61_6 == EOF || LA61_6 == COMMA || LA61_6 == RBRACK) )
                        {
                            alt61 = 1;
                        }
                        else if ( (LA61_6 == DOTDOT) )
                        {
                            alt61 = 2;
                        }
                        else 
                        {
                            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                            NoViableAltException nvae_d61s6 =
                                new NoViableAltException("", 61, 6, input);

                            throw nvae_d61s6;
                        }
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d61s3 =
                            new NoViableAltException("", 61, 3, input);

                        throw nvae_d61s3;
                    }
                    }
                    break;
                case EOF:
                case COMMA:
                case RBRACK:
                	{
                    alt61 = 1;
                    }
                    break;
                case DOTDOT:
                	{
                    alt61 = 2;
                    }
                    break;
                	default:
                	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                	    NoViableAltException nvae_d61s2 =
                	        new NoViableAltException("", 61, 2, input);

                	    throw nvae_d61s2;
                }

            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d61s0 =
                    new NoViableAltException("", 61, 0, input);

                throw nvae_d61s0;
            }
            switch (alt61) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:858:4: signedNumber
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_signedNumber_in_signedNumberOrRange5267);
                    	signedNumber189 = signedNumber();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signedNumber189.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:859:4: signedNumber DOTDOT signedNumber
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_signedNumber_in_signedNumberOrRange5272);
                    	signedNumber190 = signedNumber();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signedNumber190.Tree);
                    	DOTDOT191=(IToken)Match(input,DOTDOT,FOLLOW_DOTDOT_in_signedNumberOrRange5274); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DOTDOT191_tree = (object)adaptor.Create(DOTDOT191);
                    		adaptor.AddChild(root_0, DOTDOT191_tree);
                    	}
                    	PushFollow(FOLLOW_signedNumber_in_signedNumberOrRange5276);
                    	signedNumber192 = signedNumber();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signedNumber192.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "signedNumberOrRange"

    public class simpleExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "simpleExpression"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:862:1: simpleExpression : ( term ( ( PLUS | MINUS )=> ( PLUS | MINUS ) term )* | attribute_values );
    public BlaiseParser.simpleExpression_return simpleExpression() // throws RecognitionException [1]
    {   
        BlaiseParser.simpleExpression_return retval = new BlaiseParser.simpleExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set194 = null;
        BlaiseParser.term_return term193 = default(BlaiseParser.term_return);

        BlaiseParser.term_return term195 = default(BlaiseParser.term_return);

        BlaiseParser.attribute_values_return attribute_values196 = default(BlaiseParser.attribute_values_return);


        object set194_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:863:5: ( term ( ( PLUS | MINUS )=> ( PLUS | MINUS ) term )* | attribute_values )
            int alt63 = 2;
            int LA63_0 = input.LA(1);

            if ( (LA63_0 == QSTRING || LA63_0 == NOT || LA63_0 == CHAR || (LA63_0 >= POSITION && LA63_0 <= MINUS) || LA63_0 == LPAREN || LA63_0 == INT || (LA63_0 >= SQSTRING && LA63_0 <= ID)) )
            {
                alt63 = 1;
            }
            else if ( ((LA63_0 >= EMPTY && LA63_0 <= DK)) )
            {
                alt63 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d63s0 =
                    new NoViableAltException("", 63, 0, input);

                throw nvae_d63s0;
            }
            switch (alt63) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:864:5: term ( ( PLUS | MINUS )=> ( PLUS | MINUS ) term )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_term_in_simpleExpression5294);
                    	term193 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term193.Tree);
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:864:10: ( ( PLUS | MINUS )=> ( PLUS | MINUS ) term )*
                    	do 
                    	{
                    	    int alt62 = 2;
                    	    alt62 = dfa62.Predict(input);
                    	    switch (alt62) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:864:12: ( PLUS | MINUS )=> ( PLUS | MINUS ) term
                    			    {
                    			    	set194 = (IToken)input.LT(1);
                    			    	if ( (input.LA(1) >= PLUS && input.LA(1) <= MINUS) ) 
                    			    	{
                    			    	    input.Consume();
                    			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set194));
                    			    	    state.errorRecovery = false;state.failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    throw mse;
                    			    	}

                    			    	PushFollow(FOLLOW_term_in_simpleExpression5317);
                    			    	term195 = term();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term195.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop62;
                    	    }
                    	} while (true);

                    	loop62:
                    		;	// Stops C# compiler whining that label 'loop62' has no statements


                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:865:7: attribute_values
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_attribute_values_in_simpleExpression5328);
                    	attribute_values196 = attribute_values();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, attribute_values196.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "simpleExpression"

    public class term_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "term"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:873:1: term : signedFactor ( ( STAR | SLASH | DIV | MOD ) signedFactor )* ;
    public BlaiseParser.term_return term() // throws RecognitionException [1]
    {   
        BlaiseParser.term_return retval = new BlaiseParser.term_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken STAR198 = null;
        IToken SLASH199 = null;
        IToken DIV200 = null;
        IToken MOD201 = null;
        BlaiseParser.signedFactor_return signedFactor197 = default(BlaiseParser.signedFactor_return);

        BlaiseParser.signedFactor_return signedFactor202 = default(BlaiseParser.signedFactor_return);


        object STAR198_tree=null;
        object SLASH199_tree=null;
        object DIV200_tree=null;
        object MOD201_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:874:9: ( signedFactor ( ( STAR | SLASH | DIV | MOD ) signedFactor )* )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:874:11: signedFactor ( ( STAR | SLASH | DIV | MOD ) signedFactor )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_signedFactor_in_term5354);
            	signedFactor197 = signedFactor();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signedFactor197.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:874:24: ( ( STAR | SLASH | DIV | MOD ) signedFactor )*
            	do 
            	{
            	    int alt65 = 2;
            	    int LA65_0 = input.LA(1);

            	    if ( ((LA65_0 >= DIV && LA65_0 <= MOD) || (LA65_0 >= STAR && LA65_0 <= SLASH)) )
            	    {
            	        alt65 = 1;
            	    }


            	    switch (alt65) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:874:27: ( STAR | SLASH | DIV | MOD ) signedFactor
            			    {
            			    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:874:27: ( STAR | SLASH | DIV | MOD )
            			    	int alt64 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case STAR:
            			    		{
            			    	    alt64 = 1;
            			    	    }
            			    	    break;
            			    	case SLASH:
            			    		{
            			    	    alt64 = 2;
            			    	    }
            			    	    break;
            			    	case DIV:
            			    		{
            			    	    alt64 = 3;
            			    	    }
            			    	    break;
            			    	case MOD:
            			    		{
            			    	    alt64 = 4;
            			    	    }
            			    	    break;
            			    		default:
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    NoViableAltException nvae_d64s0 =
            			    		        new NoViableAltException("", 64, 0, input);

            			    		    throw nvae_d64s0;
            			    	}

            			    	switch (alt64) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:874:28: STAR
            			    	        {
            			    	        	STAR198=(IToken)Match(input,STAR,FOLLOW_STAR_in_term5360); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{STAR198_tree = (object)adaptor.Create(STAR198);
            			    	        		root_0 = (object)adaptor.BecomeRoot(STAR198_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:874:36: SLASH
            			    	        {
            			    	        	SLASH199=(IToken)Match(input,SLASH,FOLLOW_SLASH_in_term5365); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{SLASH199_tree = (object)adaptor.Create(SLASH199);
            			    	        		root_0 = (object)adaptor.BecomeRoot(SLASH199_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:874:45: DIV
            			    	        {
            			    	        	DIV200=(IToken)Match(input,DIV,FOLLOW_DIV_in_term5370); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{DIV200_tree = (object)adaptor.Create(DIV200);
            			    	        		root_0 = (object)adaptor.BecomeRoot(DIV200_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:874:52: MOD
            			    	        {
            			    	        	MOD201=(IToken)Match(input,MOD,FOLLOW_MOD_in_term5375); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{MOD201_tree = (object)adaptor.Create(MOD201);
            			    	        		root_0 = (object)adaptor.BecomeRoot(MOD201_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_signedFactor_in_term5379);
            			    	signedFactor202 = signedFactor();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signedFactor202.Tree);

            			    }
            			    break;

            			default:
            			    goto loop65;
            	    }
            	} while (true);

            	loop65:
            		;	// Stops C# compiler whining that label 'loop65' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "term"

    public class factor_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "factor"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:878:1: factor : ( NOT factor | builtinfuction | LPAREN expression ( ',' expression )* RPAREN -> ^( PARAMETERS_OR_EXPRESSION ( expression )* ) | unsignedConstant | askOrVarOrFunctionDesignator | search );
    public BlaiseParser.factor_return factor() // throws RecognitionException [1]
    {   
        BlaiseParser.factor_return retval = new BlaiseParser.factor_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NOT203 = null;
        IToken LPAREN206 = null;
        IToken char_literal208 = null;
        IToken RPAREN210 = null;
        BlaiseParser.factor_return factor204 = default(BlaiseParser.factor_return);

        BlaiseParser.builtinfuction_return builtinfuction205 = default(BlaiseParser.builtinfuction_return);

        BlaiseParser.expression_return expression207 = default(BlaiseParser.expression_return);

        BlaiseParser.expression_return expression209 = default(BlaiseParser.expression_return);

        BlaiseParser.unsignedConstant_return unsignedConstant211 = default(BlaiseParser.unsignedConstant_return);

        BlaiseParser.askOrVarOrFunctionDesignator_return askOrVarOrFunctionDesignator212 = default(BlaiseParser.askOrVarOrFunctionDesignator_return);

        BlaiseParser.search_return search213 = default(BlaiseParser.search_return);


        object NOT203_tree=null;
        object LPAREN206_tree=null;
        object char_literal208_tree=null;
        object RPAREN210_tree=null;
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:879:5: ( NOT factor | builtinfuction | LPAREN expression ( ',' expression )* RPAREN -> ^( PARAMETERS_OR_EXPRESSION ( expression )* ) | unsignedConstant | askOrVarOrFunctionDesignator | search )
            int alt67 = 6;
            alt67 = dfa67.Predict(input);
            switch (alt67) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:880:6: NOT factor
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	NOT203=(IToken)Match(input,NOT,FOLLOW_NOT_in_factor5406); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NOT203_tree = (object)adaptor.Create(NOT203);
                    		root_0 = (object)adaptor.BecomeRoot(NOT203_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_factor_in_factor5409);
                    	factor204 = factor();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, factor204.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:881:7: builtinfuction
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_builtinfuction_in_factor5419);
                    	builtinfuction205 = builtinfuction();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, builtinfuction205.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:886:8: LPAREN expression ( ',' expression )* RPAREN
                    {
                    	LPAREN206=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_factor5452); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LPAREN.Add(LPAREN206);

                    	PushFollow(FOLLOW_expression_in_factor5454);
                    	expression207 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression207.Tree);
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:886:26: ( ',' expression )*
                    	do 
                    	{
                    	    int alt66 = 2;
                    	    int LA66_0 = input.LA(1);

                    	    if ( (LA66_0 == COMMA) )
                    	    {
                    	        alt66 = 1;
                    	    }


                    	    switch (alt66) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:886:27: ',' expression
                    			    {
                    			    	char_literal208=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_factor5457); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_COMMA.Add(char_literal208);

                    			    	PushFollow(FOLLOW_expression_in_factor5459);
                    			    	expression209 = expression();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_expression.Add(expression209.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop66;
                    	    }
                    	} while (true);

                    	loop66:
                    		;	// Stops C# compiler whining that label 'loop66' has no statements

                    	RPAREN210=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_factor5463); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RPAREN.Add(RPAREN210);



                    	// AST REWRITE
                    	// elements:          expression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 886:51: -> ^( PARAMETERS_OR_EXPRESSION ( expression )* )
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:886:54: ^( PARAMETERS_OR_EXPRESSION ( expression )* )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETERS_OR_EXPRESSION, "PARAMETERS_OR_EXPRESSION"), root_1);

                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:886:81: ( expression )*
                    	    while ( stream_expression.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_expression.NextTree());

                    	    }
                    	    stream_expression.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:888:7: unsignedConstant
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unsignedConstant_in_factor5485);
                    	unsignedConstant211 = unsignedConstant();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unsignedConstant211.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:889:7: askOrVarOrFunctionDesignator
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_askOrVarOrFunctionDesignator_in_factor5493);
                    	askOrVarOrFunctionDesignator212 = askOrVarOrFunctionDesignator();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, askOrVarOrFunctionDesignator212.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:890:7: search
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_search_in_factor5501);
                    	search213 = search();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, search213.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "factor"

    public class signedFactor_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "signedFactor"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:897:1: signedFactor : ( PLUS | MINUS )? factor ;
    public BlaiseParser.signedFactor_return signedFactor() // throws RecognitionException [1]
    {   
        BlaiseParser.signedFactor_return retval = new BlaiseParser.signedFactor_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS214 = null;
        IToken MINUS215 = null;
        BlaiseParser.factor_return factor216 = default(BlaiseParser.factor_return);


        object PLUS214_tree=null;
        object MINUS215_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:898:5: ( ( PLUS | MINUS )? factor )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:898:7: ( PLUS | MINUS )? factor
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:898:7: ( PLUS | MINUS )?
            	int alt68 = 3;
            	int LA68_0 = input.LA(1);

            	if ( (LA68_0 == PLUS) )
            	{
            	    alt68 = 1;
            	}
            	else if ( (LA68_0 == MINUS) )
            	{
            	    alt68 = 2;
            	}
            	switch (alt68) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:898:8: PLUS
            	        {
            	        	PLUS214=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_signedFactor5541); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{PLUS214_tree = (object)adaptor.Create(PLUS214);
            	        		root_0 = (object)adaptor.BecomeRoot(PLUS214_tree, root_0);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:898:14: MINUS
            	        {
            	        	MINUS215=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_signedFactor5544); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MINUS215_tree = (object)adaptor.Create(MINUS215);
            	        		root_0 = (object)adaptor.BecomeRoot(MINUS215_tree, root_0);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_factor_in_signedFactor5549);
            	factor216 = factor();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, factor216.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "signedFactor"

    public class search_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "search"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:901:1: search : variable DOT SEARCH ( LPAREN parameterList RPAREN )? ;
    public BlaiseParser.search_return search() // throws RecognitionException [1]
    {   
        BlaiseParser.search_return retval = new BlaiseParser.search_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DOT218 = null;
        IToken SEARCH219 = null;
        IToken LPAREN220 = null;
        IToken RPAREN222 = null;
        BlaiseParser.variable_return variable217 = default(BlaiseParser.variable_return);

        BlaiseParser.parameterList_return parameterList221 = default(BlaiseParser.parameterList_return);


        object DOT218_tree=null;
        object SEARCH219_tree=null;
        object LPAREN220_tree=null;
        object RPAREN222_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:902:5: ( variable DOT SEARCH ( LPAREN parameterList RPAREN )? )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:902:7: variable DOT SEARCH ( LPAREN parameterList RPAREN )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_search5572);
            	variable217 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable217.Tree);
            	DOT218=(IToken)Match(input,DOT,FOLLOW_DOT_in_search5574); if (state.failed) return retval;
            	SEARCH219=(IToken)Match(input,SEARCH,FOLLOW_SEARCH_in_search5577); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEARCH219_tree = (object)adaptor.Create(SEARCH219);
            		adaptor.AddChild(root_0, SEARCH219_tree);
            	}
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:902:28: ( LPAREN parameterList RPAREN )?
            	int alt69 = 2;
            	alt69 = dfa69.Predict(input);
            	switch (alt69) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:902:29: LPAREN parameterList RPAREN
            	        {
            	        	LPAREN220=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_search5580); if (state.failed) return retval;
            	        	PushFollow(FOLLOW_parameterList_in_search5583);
            	        	parameterList221 = parameterList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parameterList221.Tree);
            	        	RPAREN222=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_search5585); if (state.failed) return retval;

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "search"

    public class askOrVarOrFunctionDesignator_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "askOrVarOrFunctionDesignator"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:909:1: askOrVarOrFunctionDesignator : ( variable DOT KEEP ( LPAREN parameterList RPAREN )? | variable DOT ASK ( LPAREN parameterList RPAREN )? | variable DOT SHOW ( LPAREN parameterList RPAREN )? | variable DOT LOOKUP ( LPAREN lookupParameterList RPAREN )? ( DOT ID )? | variable DOT CLASSIFY | variable ( LPAREN parameterList RPAREN )? );
    public BlaiseParser.askOrVarOrFunctionDesignator_return askOrVarOrFunctionDesignator() // throws RecognitionException [1]
    {   
        BlaiseParser.askOrVarOrFunctionDesignator_return retval = new BlaiseParser.askOrVarOrFunctionDesignator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DOT224 = null;
        IToken KEEP225 = null;
        IToken LPAREN226 = null;
        IToken RPAREN228 = null;
        IToken DOT230 = null;
        IToken ASK231 = null;
        IToken LPAREN232 = null;
        IToken RPAREN234 = null;
        IToken DOT236 = null;
        IToken SHOW237 = null;
        IToken LPAREN238 = null;
        IToken RPAREN240 = null;
        IToken DOT242 = null;
        IToken LOOKUP243 = null;
        IToken LPAREN244 = null;
        IToken RPAREN246 = null;
        IToken DOT247 = null;
        IToken ID248 = null;
        IToken DOT250 = null;
        IToken CLASSIFY251 = null;
        IToken LPAREN253 = null;
        IToken RPAREN255 = null;
        BlaiseParser.variable_return variable223 = default(BlaiseParser.variable_return);

        BlaiseParser.parameterList_return parameterList227 = default(BlaiseParser.parameterList_return);

        BlaiseParser.variable_return variable229 = default(BlaiseParser.variable_return);

        BlaiseParser.parameterList_return parameterList233 = default(BlaiseParser.parameterList_return);

        BlaiseParser.variable_return variable235 = default(BlaiseParser.variable_return);

        BlaiseParser.parameterList_return parameterList239 = default(BlaiseParser.parameterList_return);

        BlaiseParser.variable_return variable241 = default(BlaiseParser.variable_return);

        BlaiseParser.lookupParameterList_return lookupParameterList245 = default(BlaiseParser.lookupParameterList_return);

        BlaiseParser.variable_return variable249 = default(BlaiseParser.variable_return);

        BlaiseParser.variable_return variable252 = default(BlaiseParser.variable_return);

        BlaiseParser.parameterList_return parameterList254 = default(BlaiseParser.parameterList_return);


        object DOT224_tree=null;
        object KEEP225_tree=null;
        object LPAREN226_tree=null;
        object RPAREN228_tree=null;
        object DOT230_tree=null;
        object ASK231_tree=null;
        object LPAREN232_tree=null;
        object RPAREN234_tree=null;
        object DOT236_tree=null;
        object SHOW237_tree=null;
        object LPAREN238_tree=null;
        object RPAREN240_tree=null;
        object DOT242_tree=null;
        object LOOKUP243_tree=null;
        object LPAREN244_tree=null;
        object RPAREN246_tree=null;
        object DOT247_tree=null;
        object ID248_tree=null;
        object DOT250_tree=null;
        object CLASSIFY251_tree=null;
        object LPAREN253_tree=null;
        object RPAREN255_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:910:5: ( variable DOT KEEP ( LPAREN parameterList RPAREN )? | variable DOT ASK ( LPAREN parameterList RPAREN )? | variable DOT SHOW ( LPAREN parameterList RPAREN )? | variable DOT LOOKUP ( LPAREN lookupParameterList RPAREN )? ( DOT ID )? | variable DOT CLASSIFY | variable ( LPAREN parameterList RPAREN )? )
            int alt76 = 6;
            int LA76_0 = input.LA(1);

            if ( (LA76_0 == ID) )
            {
                int LA76_1 = input.LA(2);

                if ( (synpred130_Blaise()) )
                {
                    alt76 = 1;
                }
                else if ( (synpred132_Blaise()) )
                {
                    alt76 = 2;
                }
                else if ( (synpred134_Blaise()) )
                {
                    alt76 = 3;
                }
                else if ( (synpred137_Blaise()) )
                {
                    alt76 = 4;
                }
                else if ( (synpred138_Blaise()) )
                {
                    alt76 = 5;
                }
                else if ( (true) )
                {
                    alt76 = 6;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d76s1 =
                        new NoViableAltException("", 76, 1, input);

                    throw nvae_d76s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d76s0 =
                    new NoViableAltException("", 76, 0, input);

                throw nvae_d76s0;
            }
            switch (alt76) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:917:3: variable DOT KEEP ( LPAREN parameterList RPAREN )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_askOrVarOrFunctionDesignator5615);
                    	variable223 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable223.Tree);
                    	DOT224=(IToken)Match(input,DOT,FOLLOW_DOT_in_askOrVarOrFunctionDesignator5617); if (state.failed) return retval;
                    	KEEP225=(IToken)Match(input,KEEP,FOLLOW_KEEP_in_askOrVarOrFunctionDesignator5620); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{KEEP225_tree = (object)adaptor.Create(KEEP225);
                    		root_0 = (object)adaptor.BecomeRoot(KEEP225_tree, root_0);
                    	}
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:917:23: ( LPAREN parameterList RPAREN )?
                    	int alt70 = 2;
                    	alt70 = dfa70.Predict(input);
                    	switch (alt70) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:917:24: LPAREN parameterList RPAREN
                    	        {
                    	        	LPAREN226=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_askOrVarOrFunctionDesignator5624); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_parameterList_in_askOrVarOrFunctionDesignator5627);
                    	        	parameterList227 = parameterList();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parameterList227.Tree);
                    	        	RPAREN228=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_askOrVarOrFunctionDesignator5629); if (state.failed) return retval;

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:918:4: variable DOT ASK ( LPAREN parameterList RPAREN )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_askOrVarOrFunctionDesignator5637);
                    	variable229 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable229.Tree);
                    	DOT230=(IToken)Match(input,DOT,FOLLOW_DOT_in_askOrVarOrFunctionDesignator5639); if (state.failed) return retval;
                    	ASK231=(IToken)Match(input,ASK,FOLLOW_ASK_in_askOrVarOrFunctionDesignator5642); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASK231_tree = (object)adaptor.Create(ASK231);
                    		root_0 = (object)adaptor.BecomeRoot(ASK231_tree, root_0);
                    	}
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:918:23: ( LPAREN parameterList RPAREN )?
                    	int alt71 = 2;
                    	alt71 = dfa71.Predict(input);
                    	switch (alt71) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:918:24: LPAREN parameterList RPAREN
                    	        {
                    	        	LPAREN232=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_askOrVarOrFunctionDesignator5646); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_parameterList_in_askOrVarOrFunctionDesignator5649);
                    	        	parameterList233 = parameterList();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parameterList233.Tree);
                    	        	RPAREN234=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_askOrVarOrFunctionDesignator5651); if (state.failed) return retval;

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:919:4: variable DOT SHOW ( LPAREN parameterList RPAREN )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_askOrVarOrFunctionDesignator5660);
                    	variable235 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable235.Tree);
                    	DOT236=(IToken)Match(input,DOT,FOLLOW_DOT_in_askOrVarOrFunctionDesignator5662); if (state.failed) return retval;
                    	SHOW237=(IToken)Match(input,SHOW,FOLLOW_SHOW_in_askOrVarOrFunctionDesignator5665); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{SHOW237_tree = (object)adaptor.Create(SHOW237);
                    		root_0 = (object)adaptor.BecomeRoot(SHOW237_tree, root_0);
                    	}
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:919:24: ( LPAREN parameterList RPAREN )?
                    	int alt72 = 2;
                    	alt72 = dfa72.Predict(input);
                    	switch (alt72) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:919:25: LPAREN parameterList RPAREN
                    	        {
                    	        	LPAREN238=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_askOrVarOrFunctionDesignator5669); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_parameterList_in_askOrVarOrFunctionDesignator5672);
                    	        	parameterList239 = parameterList();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parameterList239.Tree);
                    	        	RPAREN240=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_askOrVarOrFunctionDesignator5674); if (state.failed) return retval;

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 4 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:4: variable DOT LOOKUP ( LPAREN lookupParameterList RPAREN )? ( DOT ID )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_askOrVarOrFunctionDesignator5682);
                    	variable241 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable241.Tree);
                    	DOT242=(IToken)Match(input,DOT,FOLLOW_DOT_in_askOrVarOrFunctionDesignator5684); if (state.failed) return retval;
                    	LOOKUP243=(IToken)Match(input,LOOKUP,FOLLOW_LOOKUP_in_askOrVarOrFunctionDesignator5687); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOOKUP243_tree = (object)adaptor.Create(LOOKUP243);
                    		root_0 = (object)adaptor.BecomeRoot(LOOKUP243_tree, root_0);
                    	}
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:26: ( LPAREN lookupParameterList RPAREN )?
                    	int alt73 = 2;
                    	alt73 = dfa73.Predict(input);
                    	switch (alt73) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:27: LPAREN lookupParameterList RPAREN
                    	        {
                    	        	LPAREN244=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_askOrVarOrFunctionDesignator5691); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{LPAREN244_tree = (object)adaptor.Create(LPAREN244);
                    	        		adaptor.AddChild(root_0, LPAREN244_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_lookupParameterList_in_askOrVarOrFunctionDesignator5693);
                    	        	lookupParameterList245 = lookupParameterList();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lookupParameterList245.Tree);
                    	        	RPAREN246=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_askOrVarOrFunctionDesignator5695); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{RPAREN246_tree = (object)adaptor.Create(RPAREN246);
                    	        		adaptor.AddChild(root_0, RPAREN246_tree);
                    	        	}

                    	        }
                    	        break;

                    	}

                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:63: ( DOT ID )?
                    	int alt74 = 2;
                    	int LA74_0 = input.LA(1);

                    	if ( (LA74_0 == DOT) )
                    	{
                    	    alt74 = 1;
                    	}
                    	switch (alt74) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:64: DOT ID
                    	        {
                    	        	DOT247=(IToken)Match(input,DOT,FOLLOW_DOT_in_askOrVarOrFunctionDesignator5700); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{DOT247_tree = (object)adaptor.Create(DOT247);
                    	        		adaptor.AddChild(root_0, DOT247_tree);
                    	        	}
                    	        	ID248=(IToken)Match(input,ID,FOLLOW_ID_in_askOrVarOrFunctionDesignator5702); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{ID248_tree = (object)adaptor.Create(ID248);
                    	        		adaptor.AddChild(root_0, ID248_tree);
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 5 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:921:4: variable DOT CLASSIFY
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_askOrVarOrFunctionDesignator5709);
                    	variable249 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable249.Tree);
                    	DOT250=(IToken)Match(input,DOT,FOLLOW_DOT_in_askOrVarOrFunctionDesignator5711); if (state.failed) return retval;
                    	CLASSIFY251=(IToken)Match(input,CLASSIFY,FOLLOW_CLASSIFY_in_askOrVarOrFunctionDesignator5714); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{CLASSIFY251_tree = (object)adaptor.Create(CLASSIFY251);
                    		root_0 = (object)adaptor.BecomeRoot(CLASSIFY251_tree, root_0);
                    	}

                    }
                    break;
                case 6 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:922:5: variable ( LPAREN parameterList RPAREN )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_askOrVarOrFunctionDesignator5721);
                    	variable252 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(variable252.Tree, root_0);
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:922:15: ( LPAREN parameterList RPAREN )?
                    	int alt75 = 2;
                    	alt75 = dfa75.Predict(input);
                    	switch (alt75) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:922:16: LPAREN parameterList RPAREN
                    	        {
                    	        	LPAREN253=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_askOrVarOrFunctionDesignator5725); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_parameterList_in_askOrVarOrFunctionDesignator5728);
                    	        	parameterList254 = parameterList();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parameterList254.Tree);
                    	        	RPAREN255=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_askOrVarOrFunctionDesignator5730); if (state.failed) return retval;

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "askOrVarOrFunctionDesignator"

    public class parameterList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parameterList"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:945:1: parameterList : simpleExpression ( COMMA simpleExpression )* -> ^( PARAMETER_LIST simpleExpression ( simpleExpression )* ) ;
    public BlaiseParser.parameterList_return parameterList() // throws RecognitionException [1]
    {   
        BlaiseParser.parameterList_return retval = new BlaiseParser.parameterList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA257 = null;
        BlaiseParser.simpleExpression_return simpleExpression256 = default(BlaiseParser.simpleExpression_return);

        BlaiseParser.simpleExpression_return simpleExpression258 = default(BlaiseParser.simpleExpression_return);


        object COMMA257_tree=null;
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleSubtreeStream stream_simpleExpression = new RewriteRuleSubtreeStream(adaptor,"rule simpleExpression");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:946:5: ( simpleExpression ( COMMA simpleExpression )* -> ^( PARAMETER_LIST simpleExpression ( simpleExpression )* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:946:7: simpleExpression ( COMMA simpleExpression )*
            {
            	PushFollow(FOLLOW_simpleExpression_in_parameterList5766);
            	simpleExpression256 = simpleExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_simpleExpression.Add(simpleExpression256.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:946:24: ( COMMA simpleExpression )*
            	do 
            	{
            	    int alt77 = 2;
            	    int LA77_0 = input.LA(1);

            	    if ( (LA77_0 == COMMA) )
            	    {
            	        alt77 = 1;
            	    }


            	    switch (alt77) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:946:26: COMMA simpleExpression
            			    {
            			    	COMMA257=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_parameterList5770); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA257);

            			    	PushFollow(FOLLOW_simpleExpression_in_parameterList5772);
            			    	simpleExpression258 = simpleExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_simpleExpression.Add(simpleExpression258.Tree);

            			    }
            			    break;

            			default:
            			    goto loop77;
            	    }
            	} while (true);

            	loop77:
            		;	// Stops C# compiler whining that label 'loop77' has no statements



            	// AST REWRITE
            	// elements:          simpleExpression, simpleExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 946:52: -> ^( PARAMETER_LIST simpleExpression ( simpleExpression )* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:946:55: ^( PARAMETER_LIST simpleExpression ( simpleExpression )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETER_LIST, "PARAMETER_LIST"), root_1);

            	    adaptor.AddChild(root_1, stream_simpleExpression.NextTree());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:946:89: ( simpleExpression )*
            	    while ( stream_simpleExpression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_simpleExpression.NextTree());

            	    }
            	    stream_simpleExpression.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parameterList"

    public class lookupParameterList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "lookupParameterList"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:949:1: lookupParameterList : lookupParameter ( COMMA lookupParameter )* ;
    public BlaiseParser.lookupParameterList_return lookupParameterList() // throws RecognitionException [1]
    {   
        BlaiseParser.lookupParameterList_return retval = new BlaiseParser.lookupParameterList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA260 = null;
        BlaiseParser.lookupParameter_return lookupParameter259 = default(BlaiseParser.lookupParameter_return);

        BlaiseParser.lookupParameter_return lookupParameter261 = default(BlaiseParser.lookupParameter_return);


        object COMMA260_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:950:2: ( lookupParameter ( COMMA lookupParameter )* )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:950:4: lookupParameter ( COMMA lookupParameter )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_lookupParameter_in_lookupParameterList5804);
            	lookupParameter259 = lookupParameter();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lookupParameter259.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:950:20: ( COMMA lookupParameter )*
            	do 
            	{
            	    int alt78 = 2;
            	    int LA78_0 = input.LA(1);

            	    if ( (LA78_0 == COMMA) )
            	    {
            	        alt78 = 1;
            	    }


            	    switch (alt78) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:950:22: COMMA lookupParameter
            			    {
            			    	COMMA260=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_lookupParameterList5808); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA260_tree = (object)adaptor.Create(COMMA260);
            			    		adaptor.AddChild(root_0, COMMA260_tree);
            			    	}
            			    	PushFollow(FOLLOW_lookupParameter_in_lookupParameterList5810);
            			    	lookupParameter261 = lookupParameter();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lookupParameter261.Tree);

            			    }
            			    break;

            			default:
            			    goto loop78;
            	    }
            	} while (true);

            	loop78:
            		;	// Stops C# compiler whining that label 'loop78' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "lookupParameterList"

    public class lookupParameter_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "lookupParameter"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:953:1: lookupParameter : ( ID | ID ASSIGN LPAREN SQSTRING RPAREN | ID ASSIGN LPAREN ID RPAREN | ID ASSIGN LPAREN variable RPAREN );
    public BlaiseParser.lookupParameter_return lookupParameter() // throws RecognitionException [1]
    {   
        BlaiseParser.lookupParameter_return retval = new BlaiseParser.lookupParameter_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID262 = null;
        IToken ID263 = null;
        IToken ASSIGN264 = null;
        IToken LPAREN265 = null;
        IToken SQSTRING266 = null;
        IToken RPAREN267 = null;
        IToken ID268 = null;
        IToken ASSIGN269 = null;
        IToken LPAREN270 = null;
        IToken ID271 = null;
        IToken RPAREN272 = null;
        IToken ID273 = null;
        IToken ASSIGN274 = null;
        IToken LPAREN275 = null;
        IToken RPAREN277 = null;
        BlaiseParser.variable_return variable276 = default(BlaiseParser.variable_return);


        object ID262_tree=null;
        object ID263_tree=null;
        object ASSIGN264_tree=null;
        object LPAREN265_tree=null;
        object SQSTRING266_tree=null;
        object RPAREN267_tree=null;
        object ID268_tree=null;
        object ASSIGN269_tree=null;
        object LPAREN270_tree=null;
        object ID271_tree=null;
        object RPAREN272_tree=null;
        object ID273_tree=null;
        object ASSIGN274_tree=null;
        object LPAREN275_tree=null;
        object RPAREN277_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:954:2: ( ID | ID ASSIGN LPAREN SQSTRING RPAREN | ID ASSIGN LPAREN ID RPAREN | ID ASSIGN LPAREN variable RPAREN )
            int alt79 = 4;
            alt79 = dfa79.Predict(input);
            switch (alt79) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:954:4: ID
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ID262=(IToken)Match(input,ID,FOLLOW_ID_in_lookupParameter5824); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID262_tree = (object)adaptor.Create(ID262);
                    		adaptor.AddChild(root_0, ID262_tree);
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:955:4: ID ASSIGN LPAREN SQSTRING RPAREN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ID263=(IToken)Match(input,ID,FOLLOW_ID_in_lookupParameter5829); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID263_tree = (object)adaptor.Create(ID263);
                    		adaptor.AddChild(root_0, ID263_tree);
                    	}
                    	ASSIGN264=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_lookupParameter5831); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN264_tree = (object)adaptor.Create(ASSIGN264);
                    		adaptor.AddChild(root_0, ASSIGN264_tree);
                    	}
                    	LPAREN265=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_lookupParameter5833); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LPAREN265_tree = (object)adaptor.Create(LPAREN265);
                    		adaptor.AddChild(root_0, LPAREN265_tree);
                    	}
                    	SQSTRING266=(IToken)Match(input,SQSTRING,FOLLOW_SQSTRING_in_lookupParameter5835); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{SQSTRING266_tree = (object)adaptor.Create(SQSTRING266);
                    		adaptor.AddChild(root_0, SQSTRING266_tree);
                    	}
                    	RPAREN267=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_lookupParameter5837); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{RPAREN267_tree = (object)adaptor.Create(RPAREN267);
                    		adaptor.AddChild(root_0, RPAREN267_tree);
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:956:4: ID ASSIGN LPAREN ID RPAREN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ID268=(IToken)Match(input,ID,FOLLOW_ID_in_lookupParameter5843); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID268_tree = (object)adaptor.Create(ID268);
                    		adaptor.AddChild(root_0, ID268_tree);
                    	}
                    	ASSIGN269=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_lookupParameter5845); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN269_tree = (object)adaptor.Create(ASSIGN269);
                    		adaptor.AddChild(root_0, ASSIGN269_tree);
                    	}
                    	LPAREN270=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_lookupParameter5847); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LPAREN270_tree = (object)adaptor.Create(LPAREN270);
                    		adaptor.AddChild(root_0, LPAREN270_tree);
                    	}
                    	ID271=(IToken)Match(input,ID,FOLLOW_ID_in_lookupParameter5849); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID271_tree = (object)adaptor.Create(ID271);
                    		adaptor.AddChild(root_0, ID271_tree);
                    	}
                    	RPAREN272=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_lookupParameter5851); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{RPAREN272_tree = (object)adaptor.Create(RPAREN272);
                    		adaptor.AddChild(root_0, RPAREN272_tree);
                    	}

                    }
                    break;
                case 4 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:957:4: ID ASSIGN LPAREN variable RPAREN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ID273=(IToken)Match(input,ID,FOLLOW_ID_in_lookupParameter5856); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID273_tree = (object)adaptor.Create(ID273);
                    		adaptor.AddChild(root_0, ID273_tree);
                    	}
                    	ASSIGN274=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_lookupParameter5858); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN274_tree = (object)adaptor.Create(ASSIGN274);
                    		adaptor.AddChild(root_0, ASSIGN274_tree);
                    	}
                    	LPAREN275=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_lookupParameter5860); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LPAREN275_tree = (object)adaptor.Create(LPAREN275);
                    		adaptor.AddChild(root_0, LPAREN275_tree);
                    	}
                    	PushFollow(FOLLOW_variable_in_lookupParameter5862);
                    	variable276 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable276.Tree);
                    	RPAREN277=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_lookupParameter5864); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{RPAREN277_tree = (object)adaptor.Create(RPAREN277);
                    		adaptor.AddChild(root_0, RPAREN277_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "lookupParameter"

    public class unsignedConstant_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unsignedConstant"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:966:1: unsignedConstant : ( unsignedNumber | constantChr );
    public BlaiseParser.unsignedConstant_return unsignedConstant() // throws RecognitionException [1]
    {   
        BlaiseParser.unsignedConstant_return retval = new BlaiseParser.unsignedConstant_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        BlaiseParser.unsignedNumber_return unsignedNumber278 = default(BlaiseParser.unsignedNumber_return);

        BlaiseParser.constantChr_return constantChr279 = default(BlaiseParser.constantChr_return);



        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:967:5: ( unsignedNumber | constantChr )
            int alt80 = 2;
            int LA80_0 = input.LA(1);

            if ( (LA80_0 == INT) )
            {
                alt80 = 1;
            }
            else if ( (LA80_0 == QSTRING || LA80_0 == CHAR || LA80_0 == SQSTRING) )
            {
                alt80 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d80s0 =
                    new NoViableAltException("", 80, 0, input);

                throw nvae_d80s0;
            }
            switch (alt80) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:967:7: unsignedNumber
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unsignedNumber_in_unsignedConstant5896);
                    	unsignedNumber278 = unsignedNumber();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unsignedNumber278.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:968:7: constantChr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_constantChr_in_unsignedConstant5904);
                    	constantChr279 = constantChr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constantChr279.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unsignedConstant"

    public class constantChr_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "constantChr"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:972:1: constantChr : ( CHAR LPAREN ( expression ) RPAREN | QSTRING | SQSTRING );
    public BlaiseParser.constantChr_return constantChr() // throws RecognitionException [1]
    {   
        BlaiseParser.constantChr_return retval = new BlaiseParser.constantChr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken CHAR280 = null;
        IToken LPAREN281 = null;
        IToken RPAREN283 = null;
        IToken QSTRING284 = null;
        IToken SQSTRING285 = null;
        BlaiseParser.expression_return expression282 = default(BlaiseParser.expression_return);


        object CHAR280_tree=null;
        object LPAREN281_tree=null;
        object RPAREN283_tree=null;
        object QSTRING284_tree=null;
        object SQSTRING285_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:973:5: ( CHAR LPAREN ( expression ) RPAREN | QSTRING | SQSTRING )
            int alt81 = 3;
            switch ( input.LA(1) ) 
            {
            case CHAR:
            	{
                alt81 = 1;
                }
                break;
            case QSTRING:
            	{
                alt81 = 2;
                }
                break;
            case SQSTRING:
            	{
                alt81 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d81s0 =
            	        new NoViableAltException("", 81, 0, input);

            	    throw nvae_d81s0;
            }

            switch (alt81) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:973:7: CHAR LPAREN ( expression ) RPAREN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CHAR280=(IToken)Match(input,CHAR,FOLLOW_CHAR_in_constantChr5926); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{CHAR280_tree = (object)adaptor.Create(CHAR280);
                    		root_0 = (object)adaptor.BecomeRoot(CHAR280_tree, root_0);
                    	}
                    	LPAREN281=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_constantChr5929); if (state.failed) return retval;
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:973:21: ( expression )
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:973:22: expression
                    	{
                    		PushFollow(FOLLOW_expression_in_constantChr5933);
                    		expression282 = expression();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression282.Tree);

                    	}

                    	RPAREN283=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_constantChr5936); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:974:6: QSTRING
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	QSTRING284=(IToken)Match(input,QSTRING,FOLLOW_QSTRING_in_constantChr5944); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{QSTRING284_tree = (object)adaptor.Create(QSTRING284);
                    		adaptor.AddChild(root_0, QSTRING284_tree);
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:975:6: SQSTRING
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	SQSTRING285=(IToken)Match(input,SQSTRING,FOLLOW_SQSTRING_in_constantChr5951); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{SQSTRING285_tree = (object)adaptor.Create(SQSTRING285);
                    		adaptor.AddChild(root_0, SQSTRING285_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constantChr"

    public class unsignedNumber_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unsignedNumber"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:980:1: unsignedNumber : ( unsignedReal | unsignedInteger );
    public BlaiseParser.unsignedNumber_return unsignedNumber() // throws RecognitionException [1]
    {   
        BlaiseParser.unsignedNumber_return retval = new BlaiseParser.unsignedNumber_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        BlaiseParser.unsignedReal_return unsignedReal286 = default(BlaiseParser.unsignedReal_return);

        BlaiseParser.unsignedInteger_return unsignedInteger287 = default(BlaiseParser.unsignedInteger_return);



        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:981:5: ( unsignedReal | unsignedInteger )
            int alt82 = 2;
            int LA82_0 = input.LA(1);

            if ( (LA82_0 == INT) )
            {
                int LA82_1 = input.LA(2);

                if ( (LA82_1 == DOT) )
                {
                    alt82 = 1;
                }
                else if ( (LA82_1 == EOF || LA82_1 == QSTRING || LA82_1 == NEWPAGE || (LA82_1 >= ENDMODEL && LA82_1 <= ENDPROCEDURE) || (LA82_1 >= END && LA82_1 <= ERROR) || LA82_1 == ENDCASE || LA82_1 == THEN || (LA82_1 >= FOR && LA82_1 <= WHILE) || (LA82_1 >= SIGNAL && LA82_1 <= CHECK) || (LA82_1 >= CATI && LA82_1 <= CAPI) || (LA82_1 >= EMPTY && LA82_1 <= DK) || LA82_1 == LAYOUT || LA82_1 == INVOLVING || (LA82_1 >= DUMMY && LA82_1 <= NEWCOLUMN) || LA82_1 == RESERVECHECK || (LA82_1 >= RULES && LA82_1 <= TO) || (LA82_1 >= IF && LA82_1 <= OR) || (LA82_1 >= CHAR && LA82_1 <= SLASH) || (LA82_1 >= COMMA && LA82_1 <= SEMI) || (LA82_1 >= EQUAL && LA82_1 <= RPAREN) || LA82_1 == RBRACK || LA82_1 == INT || (LA82_1 >= SQSTRING && LA82_1 <= ID)) )
                {
                    alt82 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d82s1 =
                        new NoViableAltException("", 82, 1, input);

                    throw nvae_d82s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d82s0 =
                    new NoViableAltException("", 82, 0, input);

                throw nvae_d82s0;
            }
            switch (alt82) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:981:7: unsignedReal
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unsignedReal_in_unsignedNumber5982);
                    	unsignedReal286 = unsignedReal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unsignedReal286.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:982:7: unsignedInteger
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unsignedInteger_in_unsignedNumber5990);
                    	unsignedInteger287 = unsignedInteger();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unsignedInteger287.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unsignedNumber"

    public class signedInteger_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "signedInteger"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:986:1: signedInteger : ( MINUS )? unsignedInteger ;
    public BlaiseParser.signedInteger_return signedInteger() // throws RecognitionException [1]
    {   
        BlaiseParser.signedInteger_return retval = new BlaiseParser.signedInteger_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MINUS288 = null;
        BlaiseParser.unsignedInteger_return unsignedInteger289 = default(BlaiseParser.unsignedInteger_return);


        object MINUS288_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:987:2: ( ( MINUS )? unsignedInteger )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:987:4: ( MINUS )? unsignedInteger
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:987:4: ( MINUS )?
            	int alt83 = 2;
            	int LA83_0 = input.LA(1);

            	if ( (LA83_0 == MINUS) )
            	{
            	    alt83 = 1;
            	}
            	switch (alt83) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: MINUS
            	        {
            	        	MINUS288=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_signedInteger6010); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MINUS288_tree = (object)adaptor.Create(MINUS288);
            	        		adaptor.AddChild(root_0, MINUS288_tree);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_unsignedInteger_in_signedInteger6013);
            	unsignedInteger289 = unsignedInteger();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unsignedInteger289.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "signedInteger"

    public class signedReal_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "signedReal"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:989:1: signedReal : ( MINUS )? unsignedReal ;
    public BlaiseParser.signedReal_return signedReal() // throws RecognitionException [1]
    {   
        BlaiseParser.signedReal_return retval = new BlaiseParser.signedReal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MINUS290 = null;
        BlaiseParser.unsignedReal_return unsignedReal291 = default(BlaiseParser.unsignedReal_return);


        object MINUS290_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:989:11: ( ( MINUS )? unsignedReal )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:989:13: ( MINUS )? unsignedReal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:989:13: ( MINUS )?
            	int alt84 = 2;
            	int LA84_0 = input.LA(1);

            	if ( (LA84_0 == MINUS) )
            	{
            	    alt84 = 1;
            	}
            	switch (alt84) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: MINUS
            	        {
            	        	MINUS290=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_signedReal6020); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MINUS290_tree = (object)adaptor.Create(MINUS290);
            	        		adaptor.AddChild(root_0, MINUS290_tree);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_unsignedReal_in_signedReal6023);
            	unsignedReal291 = unsignedReal();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unsignedReal291.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "signedReal"

    public class signedNumber_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "signedNumber"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:992:1: signedNumber : ( signedReal | signedInteger );
    public BlaiseParser.signedNumber_return signedNumber() // throws RecognitionException [1]
    {   
        BlaiseParser.signedNumber_return retval = new BlaiseParser.signedNumber_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        BlaiseParser.signedReal_return signedReal292 = default(BlaiseParser.signedReal_return);

        BlaiseParser.signedInteger_return signedInteger293 = default(BlaiseParser.signedInteger_return);



        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:993:5: ( signedReal | signedInteger )
            int alt85 = 2;
            int LA85_0 = input.LA(1);

            if ( (LA85_0 == MINUS) )
            {
                int LA85_1 = input.LA(2);

                if ( (LA85_1 == INT) )
                {
                    int LA85_2 = input.LA(3);

                    if ( (LA85_2 == DOT) )
                    {
                        alt85 = 1;
                    }
                    else if ( (LA85_2 == EOF || LA85_2 == COMMA || LA85_2 == RBRACK || LA85_2 == DOTDOT) )
                    {
                        alt85 = 2;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d85s2 =
                            new NoViableAltException("", 85, 2, input);

                        throw nvae_d85s2;
                    }
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d85s1 =
                        new NoViableAltException("", 85, 1, input);

                    throw nvae_d85s1;
                }
            }
            else if ( (LA85_0 == INT) )
            {
                int LA85_2 = input.LA(2);

                if ( (LA85_2 == DOT) )
                {
                    alt85 = 1;
                }
                else if ( (LA85_2 == EOF || LA85_2 == COMMA || LA85_2 == RBRACK || LA85_2 == DOTDOT) )
                {
                    alt85 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d85s2 =
                        new NoViableAltException("", 85, 2, input);

                    throw nvae_d85s2;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d85s0 =
                    new NoViableAltException("", 85, 0, input);

                throw nvae_d85s0;
            }
            switch (alt85) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:993:7: signedReal
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_signedReal_in_signedNumber6036);
                    	signedReal292 = signedReal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signedReal292.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:994:7: signedInteger
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_signedInteger_in_signedNumber6044);
                    	signedInteger293 = signedInteger();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signedInteger293.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "signedNumber"

    public class unsignedInteger_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unsignedInteger"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:998:1: unsignedInteger : INT ;
    public BlaiseParser.unsignedInteger_return unsignedInteger() // throws RecognitionException [1]
    {   
        BlaiseParser.unsignedInteger_return retval = new BlaiseParser.unsignedInteger_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT294 = null;

        object INT294_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:999:5: ( INT )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:999:7: INT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT294=(IToken)Match(input,INT,FOLLOW_INT_in_unsignedInteger6062); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{INT294_tree = (object)adaptor.Create(INT294);
            		adaptor.AddChild(root_0, INT294_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unsignedInteger"

    public class unsignedReal_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unsignedReal"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1002:1: unsignedReal : a= INT DOT b= INT -> ^( TYPE_REAL $a $b) ;
    public BlaiseParser.unsignedReal_return unsignedReal() // throws RecognitionException [1]
    {   
        BlaiseParser.unsignedReal_return retval = new BlaiseParser.unsignedReal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken b = null;
        IToken DOT295 = null;

        object a_tree=null;
        object b_tree=null;
        object DOT295_tree=null;
        RewriteRuleTokenStream stream_INT = new RewriteRuleTokenStream(adaptor,"token INT");
        RewriteRuleTokenStream stream_DOT = new RewriteRuleTokenStream(adaptor,"token DOT");

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1003:5: (a= INT DOT b= INT -> ^( TYPE_REAL $a $b) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1003:7: a= INT DOT b= INT
            {
            	a=(IToken)Match(input,INT,FOLLOW_INT_in_unsignedReal6084); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_INT.Add(a);

            	DOT295=(IToken)Match(input,DOT,FOLLOW_DOT_in_unsignedReal6086); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_DOT.Add(DOT295);

            	b=(IToken)Match(input,INT,FOLLOW_INT_in_unsignedReal6090); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_INT.Add(b);



            	// AST REWRITE
            	// elements:          a, b
            	// token labels:      b, a
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor, "token b", b);
            	RewriteRuleTokenStream stream_a = new RewriteRuleTokenStream(adaptor, "token a", a);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 1003:23: -> ^( TYPE_REAL $a $b)
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1003:26: ^( TYPE_REAL $a $b)
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_REAL, "TYPE_REAL"), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextNode());
            	    adaptor.AddChild(root_1, stream_b.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unsignedReal"

    public class sign_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "sign"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1006:1: sign : ( PLUS | MINUS );
    public BlaiseParser.sign_return sign() // throws RecognitionException [1]
    {   
        BlaiseParser.sign_return retval = new BlaiseParser.sign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set296 = null;

        object set296_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1007:5: ( PLUS | MINUS )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set296 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PLUS && input.LA(1) <= MINUS) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set296));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sign"

    public class ifblock_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ifblock"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1036:1: ifblock : IF a= expression (qs= field_desc )* THEN (ifs+= statement )* (b+= elseifblock )* (c= elseblock )? ENDIF -> ^( IF ^( CONDITIONAL $a) ( $qs)* ^( THEN ( $ifs)* ) ( $b)* ( $c)? ) ;
    public BlaiseParser.ifblock_return ifblock() // throws RecognitionException [1]
    {   
        BlaiseParser.ifblock_return retval = new BlaiseParser.ifblock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IF297 = null;
        IToken THEN298 = null;
        IToken ENDIF299 = null;
        IList list_ifs = null;
        IList list_b = null;
        BlaiseParser.expression_return a = default(BlaiseParser.expression_return);

        BlaiseParser.field_desc_return qs = default(BlaiseParser.field_desc_return);

        BlaiseParser.elseblock_return c = default(BlaiseParser.elseblock_return);

        BlaiseParser.statement_return ifs = default(BlaiseParser.statement_return);
         ifs = null;
        BlaiseParser.elseifblock_return b = default(BlaiseParser.elseifblock_return);
         b = null;
        object IF297_tree=null;
        object THEN298_tree=null;
        object ENDIF299_tree=null;
        RewriteRuleTokenStream stream_ENDIF = new RewriteRuleTokenStream(adaptor,"token ENDIF");
        RewriteRuleTokenStream stream_THEN = new RewriteRuleTokenStream(adaptor,"token THEN");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_field_desc = new RewriteRuleSubtreeStream(adaptor,"rule field_desc");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        RewriteRuleSubtreeStream stream_elseifblock = new RewriteRuleSubtreeStream(adaptor,"rule elseifblock");
        RewriteRuleSubtreeStream stream_elseblock = new RewriteRuleSubtreeStream(adaptor,"rule elseblock");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1036:9: ( IF a= expression (qs= field_desc )* THEN (ifs+= statement )* (b+= elseifblock )* (c= elseblock )? ENDIF -> ^( IF ^( CONDITIONAL $a) ( $qs)* ^( THEN ( $ifs)* ) ( $b)* ( $c)? ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1036:11: IF a= expression (qs= field_desc )* THEN (ifs+= statement )* (b+= elseifblock )* (c= elseblock )? ENDIF
            {
            	IF297=(IToken)Match(input,IF,FOLLOW_IF_in_ifblock6159); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IF.Add(IF297);

            	PushFollow(FOLLOW_expression_in_ifblock6163);
            	a = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(a.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1036:29: (qs= field_desc )*
            	do 
            	{
            	    int alt86 = 2;
            	    int LA86_0 = input.LA(1);

            	    if ( (LA86_0 == QSTRING || LA86_0 == ID) )
            	    {
            	        alt86 = 1;
            	    }


            	    switch (alt86) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: qs= field_desc
            			    {
            			    	PushFollow(FOLLOW_field_desc_in_ifblock6167);
            			    	qs = field_desc();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_field_desc.Add(qs.Tree);

            			    }
            			    break;

            			default:
            			    goto loop86;
            	    }
            	} while (true);

            	loop86:
            		;	// Stops C# compiler whining that label 'loop86' has no statements

            	THEN298=(IToken)Match(input,THEN,FOLLOW_THEN_in_ifblock6170); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_THEN.Add(THEN298);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1037:7: (ifs+= statement )*
            	do 
            	{
            	    int alt87 = 2;
            	    int LA87_0 = input.LA(1);

            	    if ( (LA87_0 == QSTRING || LA87_0 == NEWPAGE || LA87_0 == ERROR || (LA87_0 >= FOR && LA87_0 <= WHILE) || (LA87_0 >= SIGNAL && LA87_0 <= CHECK) || (LA87_0 >= CATI && LA87_0 <= CAPI) || (LA87_0 >= EMPTY && LA87_0 <= DK) || (LA87_0 >= DUMMY && LA87_0 <= NEWCOLUMN) || LA87_0 == RESERVECHECK || LA87_0 == IF || LA87_0 == NOT || LA87_0 == CHAR || (LA87_0 >= POSITION && LA87_0 <= MINUS) || LA87_0 == LPAREN || LA87_0 == INT || (LA87_0 >= SQSTRING && LA87_0 <= ID)) )
            	    {
            	        alt87 = 1;
            	    }


            	    switch (alt87) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: ifs+= statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_ifblock6177);
            			    	ifs = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(ifs.Tree);
            			    	if (list_ifs == null) list_ifs = new ArrayList();
            			    	list_ifs.Add(ifs.Tree);


            			    }
            			    break;

            			default:
            			    goto loop87;
            	    }
            	} while (true);

            	loop87:
            		;	// Stops C# compiler whining that label 'loop87' has no statements

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1038:4: (b+= elseifblock )*
            	do 
            	{
            	    int alt88 = 2;
            	    int LA88_0 = input.LA(1);

            	    if ( (LA88_0 == ELSEIF) )
            	    {
            	        alt88 = 1;
            	    }


            	    switch (alt88) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: b+= elseifblock
            			    {
            			    	PushFollow(FOLLOW_elseifblock_in_ifblock6184);
            			    	b = elseifblock();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_elseifblock.Add(b.Tree);
            			    	if (list_b == null) list_b = new ArrayList();
            			    	list_b.Add(b.Tree);


            			    }
            			    break;

            			default:
            			    goto loop88;
            	    }
            	} while (true);

            	loop88:
            		;	// Stops C# compiler whining that label 'loop88' has no statements

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1039:4: (c= elseblock )?
            	int alt89 = 2;
            	int LA89_0 = input.LA(1);

            	if ( (LA89_0 == ELSE) )
            	{
            	    alt89 = 1;
            	}
            	switch (alt89) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: c= elseblock
            	        {
            	        	PushFollow(FOLLOW_elseblock_in_ifblock6191);
            	        	c = elseblock();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_elseblock.Add(c.Tree);

            	        }
            	        break;

            	}

            	ENDIF299=(IToken)Match(input,ENDIF,FOLLOW_ENDIF_in_ifblock6196); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ENDIF.Add(ENDIF299);



            	// AST REWRITE
            	// elements:          qs, IF, c, a, THEN, ifs, b
            	// token labels:      
            	// rule labels:       retval, c, a, qs
            	// token list labels: 
            	// rule list labels:  b, ifs
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_c = new RewriteRuleSubtreeStream(adaptor, "rule c", c!=null ? c.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);
            	RewriteRuleSubtreeStream stream_qs = new RewriteRuleSubtreeStream(adaptor, "rule qs", qs!=null ? qs.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "token b", list_b);
            	RewriteRuleSubtreeStream stream_ifs = new RewriteRuleSubtreeStream(adaptor, "token ifs", list_ifs);
            	root_0 = (object)adaptor.GetNilNode();
            	// 1040:9: -> ^( IF ^( CONDITIONAL $a) ( $qs)* ^( THEN ( $ifs)* ) ( $b)* ( $c)? )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1040:12: ^( IF ^( CONDITIONAL $a) ( $qs)* ^( THEN ( $ifs)* ) ( $b)* ( $c)? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1040:17: ^( CONDITIONAL $a)
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITIONAL, "CONDITIONAL"), root_2);

            	    adaptor.AddChild(root_2, stream_a.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1040:35: ( $qs)*
            	    while ( stream_qs.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_qs.NextTree());

            	    }
            	    stream_qs.Reset();
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1040:40: ^( THEN ( $ifs)* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_THEN.NextNode(), root_2);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1040:47: ( $ifs)*
            	    while ( stream_ifs.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_ifs.NextTree());

            	    }
            	    stream_ifs.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1040:54: ( $b)*
            	    while ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextTree());

            	    }
            	    stream_b.Reset();
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1040:58: ( $c)?
            	    if ( stream_c.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_c.NextTree());

            	    }
            	    stream_c.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ifblock"

    public class elseifblock_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "elseifblock"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1042:1: elseifblock : ELSEIF a= expression (qs= field_desc )* THEN (elseifs+= statement )* -> ^( ELSEIF ^( CONDITIONAL $a) ( $qs)* ^( THEN ( $elseifs)* ) ) ;
    public BlaiseParser.elseifblock_return elseifblock() // throws RecognitionException [1]
    {   
        BlaiseParser.elseifblock_return retval = new BlaiseParser.elseifblock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ELSEIF300 = null;
        IToken THEN301 = null;
        IList list_elseifs = null;
        BlaiseParser.expression_return a = default(BlaiseParser.expression_return);

        BlaiseParser.field_desc_return qs = default(BlaiseParser.field_desc_return);

        BlaiseParser.statement_return elseifs = default(BlaiseParser.statement_return);
         elseifs = null;
        object ELSEIF300_tree=null;
        object THEN301_tree=null;
        RewriteRuleTokenStream stream_THEN = new RewriteRuleTokenStream(adaptor,"token THEN");
        RewriteRuleTokenStream stream_ELSEIF = new RewriteRuleTokenStream(adaptor,"token ELSEIF");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_field_desc = new RewriteRuleSubtreeStream(adaptor,"rule field_desc");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1043:2: ( ELSEIF a= expression (qs= field_desc )* THEN (elseifs+= statement )* -> ^( ELSEIF ^( CONDITIONAL $a) ( $qs)* ^( THEN ( $elseifs)* ) ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1043:4: ELSEIF a= expression (qs= field_desc )* THEN (elseifs+= statement )*
            {
            	ELSEIF300=(IToken)Match(input,ELSEIF,FOLLOW_ELSEIF_in_elseifblock6238); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ELSEIF.Add(ELSEIF300);

            	PushFollow(FOLLOW_expression_in_elseifblock6242);
            	a = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(a.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1043:26: (qs= field_desc )*
            	do 
            	{
            	    int alt90 = 2;
            	    int LA90_0 = input.LA(1);

            	    if ( (LA90_0 == QSTRING || LA90_0 == ID) )
            	    {
            	        alt90 = 1;
            	    }


            	    switch (alt90) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: qs= field_desc
            			    {
            			    	PushFollow(FOLLOW_field_desc_in_elseifblock6246);
            			    	qs = field_desc();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_field_desc.Add(qs.Tree);

            			    }
            			    break;

            			default:
            			    goto loop90;
            	    }
            	} while (true);

            	loop90:
            		;	// Stops C# compiler whining that label 'loop90' has no statements

            	THEN301=(IToken)Match(input,THEN,FOLLOW_THEN_in_elseifblock6249); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_THEN.Add(THEN301);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1044:11: (elseifs+= statement )*
            	do 
            	{
            	    int alt91 = 2;
            	    int LA91_0 = input.LA(1);

            	    if ( (LA91_0 == QSTRING || LA91_0 == NEWPAGE || LA91_0 == ERROR || (LA91_0 >= FOR && LA91_0 <= WHILE) || (LA91_0 >= SIGNAL && LA91_0 <= CHECK) || (LA91_0 >= CATI && LA91_0 <= CAPI) || (LA91_0 >= EMPTY && LA91_0 <= DK) || (LA91_0 >= DUMMY && LA91_0 <= NEWCOLUMN) || LA91_0 == RESERVECHECK || LA91_0 == IF || LA91_0 == NOT || LA91_0 == CHAR || (LA91_0 >= POSITION && LA91_0 <= MINUS) || LA91_0 == LPAREN || LA91_0 == INT || (LA91_0 >= SQSTRING && LA91_0 <= ID)) )
            	    {
            	        alt91 = 1;
            	    }


            	    switch (alt91) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: elseifs+= statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_elseifblock6256);
            			    	elseifs = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(elseifs.Tree);
            			    	if (list_elseifs == null) list_elseifs = new ArrayList();
            			    	list_elseifs.Add(elseifs.Tree);


            			    }
            			    break;

            			default:
            			    goto loop91;
            	    }
            	} while (true);

            	loop91:
            		;	// Stops C# compiler whining that label 'loop91' has no statements



            	// AST REWRITE
            	// elements:          elseifs, qs, a, THEN, ELSEIF
            	// token labels:      
            	// rule labels:       retval, a, qs
            	// token list labels: 
            	// rule list labels:  elseifs
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);
            	RewriteRuleSubtreeStream stream_qs = new RewriteRuleSubtreeStream(adaptor, "rule qs", qs!=null ? qs.Tree : null);
            	RewriteRuleSubtreeStream stream_elseifs = new RewriteRuleSubtreeStream(adaptor, "token elseifs", list_elseifs);
            	root_0 = (object)adaptor.GetNilNode();
            	// 1044:24: -> ^( ELSEIF ^( CONDITIONAL $a) ( $qs)* ^( THEN ( $elseifs)* ) )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1044:27: ^( ELSEIF ^( CONDITIONAL $a) ( $qs)* ^( THEN ( $elseifs)* ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_ELSEIF.NextNode(), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1044:36: ^( CONDITIONAL $a)
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITIONAL, "CONDITIONAL"), root_2);

            	    adaptor.AddChild(root_2, stream_a.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1044:54: ( $qs)*
            	    while ( stream_qs.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_qs.NextTree());

            	    }
            	    stream_qs.Reset();
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1044:59: ^( THEN ( $elseifs)* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_THEN.NextNode(), root_2);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1044:66: ( $elseifs)*
            	    while ( stream_elseifs.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_elseifs.NextTree());

            	    }
            	    stream_elseifs.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "elseifblock"

    public class elseblock_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "elseblock"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1046:1: elseblock : ELSE (elses+= statement )* -> ^( ELSE ( $elses)* ) ;
    public BlaiseParser.elseblock_return elseblock() // throws RecognitionException [1]
    {   
        BlaiseParser.elseblock_return retval = new BlaiseParser.elseblock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ELSE302 = null;
        IList list_elses = null;
        BlaiseParser.statement_return elses = default(BlaiseParser.statement_return);
         elses = null;
        object ELSE302_tree=null;
        RewriteRuleTokenStream stream_ELSE = new RewriteRuleTokenStream(adaptor,"token ELSE");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1047:2: ( ELSE (elses+= statement )* -> ^( ELSE ( $elses)* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1047:4: ELSE (elses+= statement )*
            {
            	ELSE302=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_elseblock6295); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ELSE.Add(ELSE302);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1048:9: (elses+= statement )*
            	do 
            	{
            	    int alt92 = 2;
            	    int LA92_0 = input.LA(1);

            	    if ( (LA92_0 == QSTRING || LA92_0 == NEWPAGE || LA92_0 == ERROR || (LA92_0 >= FOR && LA92_0 <= WHILE) || (LA92_0 >= SIGNAL && LA92_0 <= CHECK) || (LA92_0 >= CATI && LA92_0 <= CAPI) || (LA92_0 >= EMPTY && LA92_0 <= DK) || (LA92_0 >= DUMMY && LA92_0 <= NEWCOLUMN) || LA92_0 == RESERVECHECK || LA92_0 == IF || LA92_0 == NOT || LA92_0 == CHAR || (LA92_0 >= POSITION && LA92_0 <= MINUS) || LA92_0 == LPAREN || LA92_0 == INT || (LA92_0 >= SQSTRING && LA92_0 <= ID)) )
            	    {
            	        alt92 = 1;
            	    }


            	    switch (alt92) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: elses+= statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_elseblock6302);
            			    	elses = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(elses.Tree);
            			    	if (list_elses == null) list_elses = new ArrayList();
            			    	list_elses.Add(elses.Tree);


            			    }
            			    break;

            			default:
            			    goto loop92;
            	    }
            	} while (true);

            	loop92:
            		;	// Stops C# compiler whining that label 'loop92' has no statements



            	// AST REWRITE
            	// elements:          elses, ELSE
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  elses
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_elses = new RewriteRuleSubtreeStream(adaptor, "token elses", list_elses);
            	root_0 = (object)adaptor.GetNilNode();
            	// 1048:22: -> ^( ELSE ( $elses)* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1048:25: ^( ELSE ( $elses)* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1048:33: ( $elses)*
            	    while ( stream_elses.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_elses.NextTree());

            	    }
            	    stream_elses.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "elseblock"

    public class whiledoblock_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "whiledoblock"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1050:1: whiledoblock : WHILE a= expression DO (b+= statement )* ENDWHILE -> ^( WHILEDO ^( CONDITIONAL $a) ( $b)* ) ;
    public BlaiseParser.whiledoblock_return whiledoblock() // throws RecognitionException [1]
    {   
        BlaiseParser.whiledoblock_return retval = new BlaiseParser.whiledoblock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WHILE303 = null;
        IToken DO304 = null;
        IToken ENDWHILE305 = null;
        IList list_b = null;
        BlaiseParser.expression_return a = default(BlaiseParser.expression_return);

        BlaiseParser.statement_return b = default(BlaiseParser.statement_return);
         b = null;
        object WHILE303_tree=null;
        object DO304_tree=null;
        object ENDWHILE305_tree=null;
        RewriteRuleTokenStream stream_DO = new RewriteRuleTokenStream(adaptor,"token DO");
        RewriteRuleTokenStream stream_ENDWHILE = new RewriteRuleTokenStream(adaptor,"token ENDWHILE");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1051:2: ( WHILE a= expression DO (b+= statement )* ENDWHILE -> ^( WHILEDO ^( CONDITIONAL $a) ( $b)* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1051:4: WHILE a= expression DO (b+= statement )* ENDWHILE
            {
            	WHILE303=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_whiledoblock6324); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE303);

            	PushFollow(FOLLOW_expression_in_whiledoblock6328);
            	a = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(a.Tree);
            	DO304=(IToken)Match(input,DO,FOLLOW_DO_in_whiledoblock6330); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_DO.Add(DO304);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1052:5: (b+= statement )*
            	do 
            	{
            	    int alt93 = 2;
            	    int LA93_0 = input.LA(1);

            	    if ( (LA93_0 == QSTRING || LA93_0 == NEWPAGE || LA93_0 == ERROR || (LA93_0 >= FOR && LA93_0 <= WHILE) || (LA93_0 >= SIGNAL && LA93_0 <= CHECK) || (LA93_0 >= CATI && LA93_0 <= CAPI) || (LA93_0 >= EMPTY && LA93_0 <= DK) || (LA93_0 >= DUMMY && LA93_0 <= NEWCOLUMN) || LA93_0 == RESERVECHECK || LA93_0 == IF || LA93_0 == NOT || LA93_0 == CHAR || (LA93_0 >= POSITION && LA93_0 <= MINUS) || LA93_0 == LPAREN || LA93_0 == INT || (LA93_0 >= SQSTRING && LA93_0 <= ID)) )
            	    {
            	        alt93 = 1;
            	    }


            	    switch (alt93) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: b+= statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_whiledoblock6337);
            			    	b = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(b.Tree);
            			    	if (list_b == null) list_b = new ArrayList();
            			    	list_b.Add(b.Tree);


            			    }
            			    break;

            			default:
            			    goto loop93;
            	    }
            	} while (true);

            	loop93:
            		;	// Stops C# compiler whining that label 'loop93' has no statements

            	ENDWHILE305=(IToken)Match(input,ENDWHILE,FOLLOW_ENDWHILE_in_whiledoblock6342); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ENDWHILE.Add(ENDWHILE305);



            	// AST REWRITE
            	// elements:          a, b
            	// token labels:      
            	// rule labels:       retval, a
            	// token list labels: 
            	// rule list labels:  b
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "token b", list_b);
            	root_0 = (object)adaptor.GetNilNode();
            	// 1053:12: -> ^( WHILEDO ^( CONDITIONAL $a) ( $b)* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1053:15: ^( WHILEDO ^( CONDITIONAL $a) ( $b)* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(WHILEDO, "WHILEDO"), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1053:25: ^( CONDITIONAL $a)
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITIONAL, "CONDITIONAL"), root_2);

            	    adaptor.AddChild(root_2, stream_a.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1053:43: ( $b)*
            	    while ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextTree());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "whiledoblock"

    public class fordoblock_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "fordoblock"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1055:1: fordoblock : FOR var= ID ASSIGN start= simpleExpression TO until= simpleExpression DO (statements+= statement )* ENDDO -> ^( FORDO $var $start $until ( $statements)* ) ;
    public BlaiseParser.fordoblock_return fordoblock() // throws RecognitionException [1]
    {   
        BlaiseParser.fordoblock_return retval = new BlaiseParser.fordoblock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken var = null;
        IToken FOR306 = null;
        IToken ASSIGN307 = null;
        IToken TO308 = null;
        IToken DO309 = null;
        IToken ENDDO310 = null;
        IList list_statements = null;
        BlaiseParser.simpleExpression_return start = default(BlaiseParser.simpleExpression_return);

        BlaiseParser.simpleExpression_return until = default(BlaiseParser.simpleExpression_return);

        BlaiseParser.statement_return statements = default(BlaiseParser.statement_return);
         statements = null;
        object var_tree=null;
        object FOR306_tree=null;
        object ASSIGN307_tree=null;
        object TO308_tree=null;
        object DO309_tree=null;
        object ENDDO310_tree=null;
        RewriteRuleTokenStream stream_FOR = new RewriteRuleTokenStream(adaptor,"token FOR");
        RewriteRuleTokenStream stream_DO = new RewriteRuleTokenStream(adaptor,"token DO");
        RewriteRuleTokenStream stream_ENDDO = new RewriteRuleTokenStream(adaptor,"token ENDDO");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_TO = new RewriteRuleTokenStream(adaptor,"token TO");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        RewriteRuleSubtreeStream stream_simpleExpression = new RewriteRuleSubtreeStream(adaptor,"rule simpleExpression");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1056:2: ( FOR var= ID ASSIGN start= simpleExpression TO until= simpleExpression DO (statements+= statement )* ENDDO -> ^( FORDO $var $start $until ( $statements)* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1056:4: FOR var= ID ASSIGN start= simpleExpression TO until= simpleExpression DO (statements+= statement )* ENDDO
            {
            	FOR306=(IToken)Match(input,FOR,FOLLOW_FOR_in_fordoblock6368); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FOR.Add(FOR306);

            	var=(IToken)Match(input,ID,FOLLOW_ID_in_fordoblock6372); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(var);

            	ASSIGN307=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_fordoblock6374); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN307);

            	PushFollow(FOLLOW_simpleExpression_in_fordoblock6378);
            	start = simpleExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_simpleExpression.Add(start.Tree);
            	TO308=(IToken)Match(input,TO,FOLLOW_TO_in_fordoblock6380); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_TO.Add(TO308);

            	PushFollow(FOLLOW_simpleExpression_in_fordoblock6384);
            	until = simpleExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_simpleExpression.Add(until.Tree);
            	DO309=(IToken)Match(input,DO,FOLLOW_DO_in_fordoblock6386); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_DO.Add(DO309);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1057:14: (statements+= statement )*
            	do 
            	{
            	    int alt94 = 2;
            	    int LA94_0 = input.LA(1);

            	    if ( (LA94_0 == QSTRING || LA94_0 == NEWPAGE || LA94_0 == ERROR || (LA94_0 >= FOR && LA94_0 <= WHILE) || (LA94_0 >= SIGNAL && LA94_0 <= CHECK) || (LA94_0 >= CATI && LA94_0 <= CAPI) || (LA94_0 >= EMPTY && LA94_0 <= DK) || (LA94_0 >= DUMMY && LA94_0 <= NEWCOLUMN) || LA94_0 == RESERVECHECK || LA94_0 == IF || LA94_0 == NOT || LA94_0 == CHAR || (LA94_0 >= POSITION && LA94_0 <= MINUS) || LA94_0 == LPAREN || LA94_0 == INT || (LA94_0 >= SQSTRING && LA94_0 <= ID)) )
            	    {
            	        alt94 = 1;
            	    }


            	    switch (alt94) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: statements+= statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_fordoblock6393);
            			    	statements = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(statements.Tree);
            			    	if (list_statements == null) list_statements = new ArrayList();
            			    	list_statements.Add(statements.Tree);


            			    }
            			    break;

            			default:
            			    goto loop94;
            	    }
            	} while (true);

            	loop94:
            		;	// Stops C# compiler whining that label 'loop94' has no statements

            	ENDDO310=(IToken)Match(input,ENDDO,FOLLOW_ENDDO_in_fordoblock6398); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ENDDO.Add(ENDDO310);



            	// AST REWRITE
            	// elements:          var, until, start, statements
            	// token labels:      var
            	// rule labels:       retval, start, until
            	// token list labels: 
            	// rule list labels:  statements
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_var = new RewriteRuleTokenStream(adaptor, "token var", var);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_start = new RewriteRuleSubtreeStream(adaptor, "rule start", start!=null ? start.Tree : null);
            	RewriteRuleSubtreeStream stream_until = new RewriteRuleSubtreeStream(adaptor, "rule until", until!=null ? until.Tree : null);
            	RewriteRuleSubtreeStream stream_statements = new RewriteRuleSubtreeStream(adaptor, "token statements", list_statements);
            	root_0 = (object)adaptor.GetNilNode();
            	// 1058:9: -> ^( FORDO $var $start $until ( $statements)* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1058:12: ^( FORDO $var $start $until ( $statements)* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORDO, "FORDO"), root_1);

            	    adaptor.AddChild(root_1, stream_var.NextNode());
            	    adaptor.AddChild(root_1, stream_start.NextTree());
            	    adaptor.AddChild(root_1, stream_until.NextTree());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1058:39: ( $statements)*
            	    while ( stream_statements.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_statements.NextTree());

            	    }
            	    stream_statements.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fordoblock"

    public class caseofblock_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "caseofblock"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1061:1: caseofblock : CASE a= ID OF (b+= case_item )* (c= elseblock )? ENDCASE -> ^( CASE $a ( $b)* ( $c)? ) ;
    public BlaiseParser.caseofblock_return caseofblock() // throws RecognitionException [1]
    {   
        BlaiseParser.caseofblock_return retval = new BlaiseParser.caseofblock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken CASE311 = null;
        IToken OF312 = null;
        IToken ENDCASE313 = null;
        IList list_b = null;
        BlaiseParser.elseblock_return c = default(BlaiseParser.elseblock_return);

        BlaiseParser.case_item_return b = default(BlaiseParser.case_item_return);
         b = null;
        object a_tree=null;
        object CASE311_tree=null;
        object OF312_tree=null;
        object ENDCASE313_tree=null;
        RewriteRuleTokenStream stream_ENDCASE = new RewriteRuleTokenStream(adaptor,"token ENDCASE");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_OF = new RewriteRuleTokenStream(adaptor,"token OF");
        RewriteRuleTokenStream stream_CASE = new RewriteRuleTokenStream(adaptor,"token CASE");
        RewriteRuleSubtreeStream stream_case_item = new RewriteRuleSubtreeStream(adaptor,"rule case_item");
        RewriteRuleSubtreeStream stream_elseblock = new RewriteRuleSubtreeStream(adaptor,"rule elseblock");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1062:2: ( CASE a= ID OF (b+= case_item )* (c= elseblock )? ENDCASE -> ^( CASE $a ( $b)* ( $c)? ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1062:4: CASE a= ID OF (b+= case_item )* (c= elseblock )? ENDCASE
            {
            	CASE311=(IToken)Match(input,CASE,FOLLOW_CASE_in_caseofblock6427); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_CASE.Add(CASE311);

            	a=(IToken)Match(input,ID,FOLLOW_ID_in_caseofblock6431); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(a);

            	OF312=(IToken)Match(input,OF,FOLLOW_OF_in_caseofblock6433); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_OF.Add(OF312);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1063:5: (b+= case_item )*
            	do 
            	{
            	    int alt95 = 2;
            	    int LA95_0 = input.LA(1);

            	    if ( (LA95_0 == MINUS || LA95_0 == INT || LA95_0 == ID) )
            	    {
            	        alt95 = 1;
            	    }


            	    switch (alt95) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: b+= case_item
            			    {
            			    	PushFollow(FOLLOW_case_item_in_caseofblock6440);
            			    	b = case_item();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_case_item.Add(b.Tree);
            			    	if (list_b == null) list_b = new ArrayList();
            			    	list_b.Add(b.Tree);


            			    }
            			    break;

            			default:
            			    goto loop95;
            	    }
            	} while (true);

            	loop95:
            		;	// Stops C# compiler whining that label 'loop95' has no statements

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1064:5: (c= elseblock )?
            	int alt96 = 2;
            	int LA96_0 = input.LA(1);

            	if ( (LA96_0 == ELSE) )
            	{
            	    alt96 = 1;
            	}
            	switch (alt96) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: c= elseblock
            	        {
            	        	PushFollow(FOLLOW_elseblock_in_caseofblock6448);
            	        	c = elseblock();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_elseblock.Add(c.Tree);

            	        }
            	        break;

            	}

            	ENDCASE313=(IToken)Match(input,ENDCASE,FOLLOW_ENDCASE_in_caseofblock6453); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ENDCASE.Add(ENDCASE313);



            	// AST REWRITE
            	// elements:          c, b, a, CASE
            	// token labels:      a
            	// rule labels:       retval, c
            	// token list labels: 
            	// rule list labels:  b
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_a = new RewriteRuleTokenStream(adaptor, "token a", a);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_c = new RewriteRuleSubtreeStream(adaptor, "rule c", c!=null ? c.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "token b", list_b);
            	root_0 = (object)adaptor.GetNilNode();
            	// 1065:11: -> ^( CASE $a ( $b)* ( $c)? )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1065:14: ^( CASE $a ( $b)* ( $c)? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_CASE.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextNode());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1065:24: ( $b)*
            	    while ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextTree());

            	    }
            	    stream_b.Reset();
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1065:28: ( $c)?
            	    if ( stream_c.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_c.NextTree());

            	    }
            	    stream_c.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "caseofblock"

    public class case_item_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "case_item"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:1: case_item : a= ( id_list | var_list | int_list | realrange ) COLON (b+= statement )* -> ^( CASE_ITEM $a ( $b)* ) ;
    public BlaiseParser.case_item_return case_item() // throws RecognitionException [1]
    {   
        BlaiseParser.case_item_return retval = new BlaiseParser.case_item_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken COLON318 = null;
        IList list_b = null;
        BlaiseParser.id_list_return id_list314 = default(BlaiseParser.id_list_return);

        BlaiseParser.var_list_return var_list315 = default(BlaiseParser.var_list_return);

        BlaiseParser.int_list_return int_list316 = default(BlaiseParser.int_list_return);

        BlaiseParser.realrange_return realrange317 = default(BlaiseParser.realrange_return);

        BlaiseParser.statement_return b = default(BlaiseParser.statement_return);
         b = null;
        object a_tree=null;
        object COLON318_tree=null;
        RewriteRuleTokenStream stream_COLON = new RewriteRuleTokenStream(adaptor,"token COLON");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        RewriteRuleSubtreeStream stream_var_list = new RewriteRuleSubtreeStream(adaptor,"rule var_list");
        RewriteRuleSubtreeStream stream_int_list = new RewriteRuleSubtreeStream(adaptor,"rule int_list");
        RewriteRuleSubtreeStream stream_realrange = new RewriteRuleSubtreeStream(adaptor,"rule realrange");
        RewriteRuleSubtreeStream stream_id_list = new RewriteRuleSubtreeStream(adaptor,"rule id_list");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:11: (a= ( id_list | var_list | int_list | realrange ) COLON (b+= statement )* -> ^( CASE_ITEM $a ( $b)* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:13: a= ( id_list | var_list | int_list | realrange ) COLON (b+= statement )*
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:15: ( id_list | var_list | int_list | realrange )
            	int alt97 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case ID:
            		{
            	    int LA97_1 = input.LA(2);

            	    if ( (synpred164_Blaise()) )
            	    {
            	        alt97 = 1;
            	    }
            	    else if ( (synpred165_Blaise()) )
            	    {
            	        alt97 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d97s1 =
            	            new NoViableAltException("", 97, 1, input);

            	        throw nvae_d97s1;
            	    }
            	    }
            	    break;
            	case MINUS:
            		{
            	    int LA97_2 = input.LA(2);

            	    if ( (LA97_2 == INT) )
            	    {
            	        int LA97_3 = input.LA(3);

            	        if ( ((LA97_3 >= DOTDOT && LA97_3 <= DOT)) )
            	        {
            	            alt97 = 4;
            	        }
            	        else if ( (LA97_3 == COMMA || LA97_3 == COLON) )
            	        {
            	            alt97 = 3;
            	        }
            	        else 
            	        {
            	            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	            NoViableAltException nvae_d97s3 =
            	                new NoViableAltException("", 97, 3, input);

            	            throw nvae_d97s3;
            	        }
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d97s2 =
            	            new NoViableAltException("", 97, 2, input);

            	        throw nvae_d97s2;
            	    }
            	    }
            	    break;
            	case INT:
            		{
            	    int LA97_3 = input.LA(2);

            	    if ( ((LA97_3 >= DOTDOT && LA97_3 <= DOT)) )
            	    {
            	        alt97 = 4;
            	    }
            	    else if ( (LA97_3 == COMMA || LA97_3 == COLON) )
            	    {
            	        alt97 = 3;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d97s3 =
            	            new NoViableAltException("", 97, 3, input);

            	        throw nvae_d97s3;
            	    }
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    NoViableAltException nvae_d97s0 =
            		        new NoViableAltException("", 97, 0, input);

            		    throw nvae_d97s0;
            	}

            	switch (alt97) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:16: id_list
            	        {
            	        	PushFollow(FOLLOW_id_list_in_case_item6481);
            	        	id_list314 = id_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_id_list.Add(id_list314.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:26: var_list
            	        {
            	        	PushFollow(FOLLOW_var_list_in_case_item6485);
            	        	var_list315 = var_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_var_list.Add(var_list315.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:37: int_list
            	        {
            	        	PushFollow(FOLLOW_int_list_in_case_item6489);
            	        	int_list316 = int_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_int_list.Add(int_list316.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:48: realrange
            	        {
            	        	PushFollow(FOLLOW_realrange_in_case_item6493);
            	        	realrange317 = realrange();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_realrange.Add(realrange317.Tree);

            	        }
            	        break;

            	}

            	COLON318=(IToken)Match(input,COLON,FOLLOW_COLON_in_case_item6496); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_COLON.Add(COLON318);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:66: (b+= statement )*
            	do 
            	{
            	    int alt98 = 2;
            	    alt98 = dfa98.Predict(input);
            	    switch (alt98) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: b+= statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_case_item6500);
            			    	b = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(b.Tree);
            			    	if (list_b == null) list_b = new ArrayList();
            			    	list_b.Add(b.Tree);


            			    }
            			    break;

            			default:
            			    goto loop98;
            	    }
            	} while (true);

            	loop98:
            		;	// Stops C# compiler whining that label 'loop98' has no statements



            	// AST REWRITE
            	// elements:          a, b
            	// token labels:      a
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  b
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_a = new RewriteRuleTokenStream(adaptor, "token a", a);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "token b", list_b);
            	root_0 = (object)adaptor.GetNilNode();
            	// 1067:79: -> ^( CASE_ITEM $a ( $b)* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:82: ^( CASE_ITEM $a ( $b)* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CASE_ITEM, "CASE_ITEM"), root_1);

            	    adaptor.AddChild(root_1, stream_a.NextNode());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:97: ( $b)*
            	    while ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextTree());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "case_item"

    public class parameters_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parameters"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1073:1: parameters : PARAMETERS ( parameter_item )* ;
    public BlaiseParser.parameters_return parameters() // throws RecognitionException [1]
    {   
        BlaiseParser.parameters_return retval = new BlaiseParser.parameters_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PARAMETERS319 = null;
        BlaiseParser.parameter_item_return parameter_item320 = default(BlaiseParser.parameter_item_return);


        object PARAMETERS319_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1074:2: ( PARAMETERS ( parameter_item )* )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1074:4: PARAMETERS ( parameter_item )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PARAMETERS319=(IToken)Match(input,PARAMETERS,FOLLOW_PARAMETERS_in_parameters6529); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{PARAMETERS319_tree = (object)adaptor.Create(PARAMETERS319);
            		root_0 = (object)adaptor.BecomeRoot(PARAMETERS319_tree, root_0);
            	}
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1074:16: ( parameter_item )*
            	do 
            	{
            	    int alt99 = 2;
            	    int LA99_0 = input.LA(1);

            	    if ( ((LA99_0 >= IMPORT && LA99_0 <= TRANSIT) || LA99_0 == ID) )
            	    {
            	        alt99 = 1;
            	    }


            	    switch (alt99) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: parameter_item
            			    {
            			    	PushFollow(FOLLOW_parameter_item_in_parameters6532);
            			    	parameter_item320 = parameter_item();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parameter_item320.Tree);

            			    }
            			    break;

            			default:
            			    goto loop99;
            	    }
            	} while (true);

            	loop99:
            		;	// Stops C# compiler whining that label 'loop99' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parameters"

    public class parameter_item_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parameter_item"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1076:1: parameter_item : (a= ( IMPORT | EXPORT | TRANSIT ) )? b= id_list COLON c= typedef -> ^( PARAMETER_ITEM ( $a)? $b $c) ;
    public BlaiseParser.parameter_item_return parameter_item() // throws RecognitionException [1]
    {   
        BlaiseParser.parameter_item_return retval = new BlaiseParser.parameter_item_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken IMPORT321 = null;
        IToken EXPORT322 = null;
        IToken TRANSIT323 = null;
        IToken COLON324 = null;
        BlaiseParser.id_list_return b = default(BlaiseParser.id_list_return);

        BlaiseParser.typedef_return c = default(BlaiseParser.typedef_return);


        object a_tree=null;
        object IMPORT321_tree=null;
        object EXPORT322_tree=null;
        object TRANSIT323_tree=null;
        object COLON324_tree=null;
        RewriteRuleTokenStream stream_COLON = new RewriteRuleTokenStream(adaptor,"token COLON");
        RewriteRuleTokenStream stream_TRANSIT = new RewriteRuleTokenStream(adaptor,"token TRANSIT");
        RewriteRuleTokenStream stream_IMPORT = new RewriteRuleTokenStream(adaptor,"token IMPORT");
        RewriteRuleTokenStream stream_EXPORT = new RewriteRuleTokenStream(adaptor,"token EXPORT");
        RewriteRuleSubtreeStream stream_typedef = new RewriteRuleSubtreeStream(adaptor,"rule typedef");
        RewriteRuleSubtreeStream stream_id_list = new RewriteRuleSubtreeStream(adaptor,"rule id_list");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1077:2: ( (a= ( IMPORT | EXPORT | TRANSIT ) )? b= id_list COLON c= typedef -> ^( PARAMETER_ITEM ( $a)? $b $c) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1077:4: (a= ( IMPORT | EXPORT | TRANSIT ) )? b= id_list COLON c= typedef
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1077:5: (a= ( IMPORT | EXPORT | TRANSIT ) )?
            	int alt101 = 2;
            	int LA101_0 = input.LA(1);

            	if ( ((LA101_0 >= IMPORT && LA101_0 <= TRANSIT)) )
            	{
            	    alt101 = 1;
            	}
            	switch (alt101) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: a= ( IMPORT | EXPORT | TRANSIT )
            	        {
            	        	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1077:6: ( IMPORT | EXPORT | TRANSIT )
            	        	int alt100 = 3;
            	        	switch ( input.LA(1) ) 
            	        	{
            	        	case IMPORT:
            	        		{
            	        	    alt100 = 1;
            	        	    }
            	        	    break;
            	        	case EXPORT:
            	        		{
            	        	    alt100 = 2;
            	        	    }
            	        	    break;
            	        	case TRANSIT:
            	        		{
            	        	    alt100 = 3;
            	        	    }
            	        	    break;
            	        		default:
            	        		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        		    NoViableAltException nvae_d100s0 =
            	        		        new NoViableAltException("", 100, 0, input);

            	        		    throw nvae_d100s0;
            	        	}

            	        	switch (alt100) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1077:7: IMPORT
            	        	        {
            	        	        	IMPORT321=(IToken)Match(input,IMPORT,FOLLOW_IMPORT_in_parameter_item6545); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_IMPORT.Add(IMPORT321);


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1077:15: EXPORT
            	        	        {
            	        	        	EXPORT322=(IToken)Match(input,EXPORT,FOLLOW_EXPORT_in_parameter_item6548); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_EXPORT.Add(EXPORT322);


            	        	        }
            	        	        break;
            	        	    case 3 :
            	        	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1077:24: TRANSIT
            	        	        {
            	        	        	TRANSIT323=(IToken)Match(input,TRANSIT,FOLLOW_TRANSIT_in_parameter_item6552); if (state.failed) return retval; 
            	        	        	if ( (state.backtracking==0) ) stream_TRANSIT.Add(TRANSIT323);


            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_id_list_in_parameter_item6558);
            	b = id_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_id_list.Add(b.Tree);
            	COLON324=(IToken)Match(input,COLON,FOLLOW_COLON_in_parameter_item6561); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_COLON.Add(COLON324);

            	PushFollow(FOLLOW_typedef_in_parameter_item6565);
            	c = typedef();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_typedef.Add(c.Tree);


            	// AST REWRITE
            	// elements:          c, b, a
            	// token labels:      a
            	// rule labels:       retval, b, c
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleTokenStream stream_a = new RewriteRuleTokenStream(adaptor, "token a", a);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "rule b", b!=null ? b.Tree : null);
            	RewriteRuleSubtreeStream stream_c = new RewriteRuleSubtreeStream(adaptor, "rule c", c!=null ? c.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 1077:61: -> ^( PARAMETER_ITEM ( $a)? $b $c)
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1077:64: ^( PARAMETER_ITEM ( $a)? $b $c)
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMETER_ITEM, "PARAMETER_ITEM"), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1077:81: ( $a)?
            	    if ( stream_a.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_a.NextNode());

            	    }
            	    stream_a.Reset();
            	    adaptor.AddChild(root_1, stream_b.NextTree());
            	    adaptor.AddChild(root_1, stream_c.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parameter_item"

    public class externals_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "externals"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1079:1: externals : EXTERNALS ( external_item )* ;
    public BlaiseParser.externals_return externals() // throws RecognitionException [1]
    {   
        BlaiseParser.externals_return retval = new BlaiseParser.externals_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EXTERNALS325 = null;
        BlaiseParser.external_item_return external_item326 = default(BlaiseParser.external_item_return);


        object EXTERNALS325_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1080:2: ( EXTERNALS ( external_item )* )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1080:4: EXTERNALS ( external_item )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	EXTERNALS325=(IToken)Match(input,EXTERNALS,FOLLOW_EXTERNALS_in_externals6591); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EXTERNALS325_tree = (object)adaptor.Create(EXTERNALS325);
            		root_0 = (object)adaptor.BecomeRoot(EXTERNALS325_tree, root_0);
            	}
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1080:15: ( external_item )*
            	do 
            	{
            	    int alt102 = 2;
            	    int LA102_0 = input.LA(1);

            	    if ( (LA102_0 == ID) )
            	    {
            	        alt102 = 1;
            	    }


            	    switch (alt102) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: external_item
            			    {
            			    	PushFollow(FOLLOW_external_item_in_externals6594);
            			    	external_item326 = external_item();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, external_item326.Tree);

            			    }
            			    break;

            			default:
            			    goto loop102;
            	    }
            	} while (true);

            	loop102:
            		;	// Stops C# compiler whining that label 'loop102' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "externals"

    public class external_item_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "external_item"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1082:1: external_item : a= ID COLON b= ID LPAREN c= SQSTRING ( COMMA d= ID )? RPAREN ;
    public BlaiseParser.external_item_return external_item() // throws RecognitionException [1]
    {   
        BlaiseParser.external_item_return retval = new BlaiseParser.external_item_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken a = null;
        IToken b = null;
        IToken c = null;
        IToken d = null;
        IToken COLON327 = null;
        IToken LPAREN328 = null;
        IToken COMMA329 = null;
        IToken RPAREN330 = null;

        object a_tree=null;
        object b_tree=null;
        object c_tree=null;
        object d_tree=null;
        object COLON327_tree=null;
        object LPAREN328_tree=null;
        object COMMA329_tree=null;
        object RPAREN330_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1083:2: (a= ID COLON b= ID LPAREN c= SQSTRING ( COMMA d= ID )? RPAREN )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1083:4: a= ID COLON b= ID LPAREN c= SQSTRING ( COMMA d= ID )? RPAREN
            {
            	root_0 = (object)adaptor.GetNilNode();

            	a=(IToken)Match(input,ID,FOLLOW_ID_in_external_item6607); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{a_tree = (object)adaptor.Create(a);
            		adaptor.AddChild(root_0, a_tree);
            	}
            	COLON327=(IToken)Match(input,COLON,FOLLOW_COLON_in_external_item6609); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{COLON327_tree = (object)adaptor.Create(COLON327);
            		adaptor.AddChild(root_0, COLON327_tree);
            	}
            	b=(IToken)Match(input,ID,FOLLOW_ID_in_external_item6613); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{b_tree = (object)adaptor.Create(b);
            		adaptor.AddChild(root_0, b_tree);
            	}
            	LPAREN328=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_external_item6615); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LPAREN328_tree = (object)adaptor.Create(LPAREN328);
            		adaptor.AddChild(root_0, LPAREN328_tree);
            	}
            	c=(IToken)Match(input,SQSTRING,FOLLOW_SQSTRING_in_external_item6619); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{c_tree = (object)adaptor.Create(c);
            		adaptor.AddChild(root_0, c_tree);
            	}
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1083:38: ( COMMA d= ID )?
            	int alt103 = 2;
            	int LA103_0 = input.LA(1);

            	if ( (LA103_0 == COMMA) )
            	{
            	    alt103 = 1;
            	}
            	switch (alt103) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1083:39: COMMA d= ID
            	        {
            	        	COMMA329=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_external_item6622); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA329_tree = (object)adaptor.Create(COMMA329);
            	        		adaptor.AddChild(root_0, COMMA329_tree);
            	        	}
            	        	d=(IToken)Match(input,ID,FOLLOW_ID_in_external_item6626); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{d_tree = (object)adaptor.Create(d);
            	        		adaptor.AddChild(root_0, d_tree);
            	        	}

            	        }
            	        break;

            	}

            	RPAREN330=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_external_item6630); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{RPAREN330_tree = (object)adaptor.Create(RPAREN330);
            		adaptor.AddChild(root_0, RPAREN330_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "external_item"

    public class libraries_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "libraries"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1085:1: libraries : LIBRARIES ( library_item )* ;
    public BlaiseParser.libraries_return libraries() // throws RecognitionException [1]
    {   
        BlaiseParser.libraries_return retval = new BlaiseParser.libraries_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LIBRARIES331 = null;
        BlaiseParser.library_item_return library_item332 = default(BlaiseParser.library_item_return);


        object LIBRARIES331_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1086:2: ( LIBRARIES ( library_item )* )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1086:4: LIBRARIES ( library_item )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LIBRARIES331=(IToken)Match(input,LIBRARIES,FOLLOW_LIBRARIES_in_libraries6640); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LIBRARIES331_tree = (object)adaptor.Create(LIBRARIES331);
            		root_0 = (object)adaptor.BecomeRoot(LIBRARIES331_tree, root_0);
            	}
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1086:15: ( library_item )*
            	do 
            	{
            	    int alt104 = 2;
            	    int LA104_0 = input.LA(1);

            	    if ( (LA104_0 == ID) )
            	    {
            	        alt104 = 1;
            	    }


            	    switch (alt104) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: library_item
            			    {
            			    	PushFollow(FOLLOW_library_item_in_libraries6643);
            			    	library_item332 = library_item();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, library_item332.Tree);

            			    }
            			    break;

            			default:
            			    goto loop104;
            	    }
            	} while (true);

            	loop104:
            		;	// Stops C# compiler whining that label 'loop104' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "libraries"

    public class library_item_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "library_item"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1088:1: library_item : ID ( SQSTRING )? ;
    public BlaiseParser.library_item_return library_item() // throws RecognitionException [1]
    {   
        BlaiseParser.library_item_return retval = new BlaiseParser.library_item_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID333 = null;
        IToken SQSTRING334 = null;

        object ID333_tree=null;
        object SQSTRING334_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1089:2: ( ID ( SQSTRING )? )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1089:4: ID ( SQSTRING )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ID333=(IToken)Match(input,ID,FOLLOW_ID_in_library_item6654); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ID333_tree = (object)adaptor.Create(ID333);
            		adaptor.AddChild(root_0, ID333_tree);
            	}
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1089:7: ( SQSTRING )?
            	int alt105 = 2;
            	int LA105_0 = input.LA(1);

            	if ( (LA105_0 == SQSTRING) )
            	{
            	    alt105 = 1;
            	}
            	switch (alt105) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: SQSTRING
            	        {
            	        	SQSTRING334=(IToken)Match(input,SQSTRING,FOLLOW_SQSTRING_in_library_item6656); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{SQSTRING334_tree = (object)adaptor.Create(SQSTRING334);
            	        		adaptor.AddChild(root_0, SQSTRING334_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "library_item"

    public class auxfields_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "auxfields"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1094:1: auxfields : AUXFIELDS ( field )* -> ^( AUXFIELDS ( field )* ) ;
    public BlaiseParser.auxfields_return auxfields() // throws RecognitionException [1]
    {   
        BlaiseParser.auxfields_return retval = new BlaiseParser.auxfields_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken AUXFIELDS335 = null;
        BlaiseParser.field_return field336 = default(BlaiseParser.field_return);


        object AUXFIELDS335_tree=null;
        RewriteRuleTokenStream stream_AUXFIELDS = new RewriteRuleTokenStream(adaptor,"token AUXFIELDS");
        RewriteRuleSubtreeStream stream_field = new RewriteRuleSubtreeStream(adaptor,"rule field");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1095:2: ( AUXFIELDS ( field )* -> ^( AUXFIELDS ( field )* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1095:4: AUXFIELDS ( field )*
            {
            	AUXFIELDS335=(IToken)Match(input,AUXFIELDS,FOLLOW_AUXFIELDS_in_auxfields6670); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_AUXFIELDS.Add(AUXFIELDS335);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1095:14: ( field )*
            	do 
            	{
            	    int alt106 = 2;
            	    int LA106_0 = input.LA(1);

            	    if ( (LA106_0 == ID) )
            	    {
            	        alt106 = 1;
            	    }


            	    switch (alt106) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: field
            			    {
            			    	PushFollow(FOLLOW_field_in_auxfields6672);
            			    	field336 = field();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_field.Add(field336.Tree);

            			    }
            			    break;

            			default:
            			    goto loop106;
            	    }
            	} while (true);

            	loop106:
            		;	// Stops C# compiler whining that label 'loop106' has no statements



            	// AST REWRITE
            	// elements:          field, AUXFIELDS
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 1095:21: -> ^( AUXFIELDS ( field )* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1095:24: ^( AUXFIELDS ( field )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_AUXFIELDS.NextNode(), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1095:36: ( field )*
            	    while ( stream_field.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_field.NextTree());

            	    }
            	    stream_field.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "auxfields"

    public class lid_string_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "lid_string"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1100:1: lid_string : ( ID )? QSTRING -> ^( LID_STRING QSTRING ( ID )? ) ;
    public BlaiseParser.lid_string_return lid_string() // throws RecognitionException [1]
    {   
        BlaiseParser.lid_string_return retval = new BlaiseParser.lid_string_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID337 = null;
        IToken QSTRING338 = null;

        object ID337_tree=null;
        object QSTRING338_tree=null;
        RewriteRuleTokenStream stream_QSTRING = new RewriteRuleTokenStream(adaptor,"token QSTRING");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1101:2: ( ( ID )? QSTRING -> ^( LID_STRING QSTRING ( ID )? ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1101:4: ( ID )? QSTRING
            {
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1101:4: ( ID )?
            	int alt107 = 2;
            	int LA107_0 = input.LA(1);

            	if ( (LA107_0 == ID) )
            	{
            	    alt107 = 1;
            	}
            	switch (alt107) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: ID
            	        {
            	        	ID337=(IToken)Match(input,ID,FOLLOW_ID_in_lid_string6703); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ID.Add(ID337);


            	        }
            	        break;

            	}

            	QSTRING338=(IToken)Match(input,QSTRING,FOLLOW_QSTRING_in_lid_string6706); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_QSTRING.Add(QSTRING338);



            	// AST REWRITE
            	// elements:          ID, QSTRING
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 1101:16: -> ^( LID_STRING QSTRING ( ID )? )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1101:19: ^( LID_STRING QSTRING ( ID )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LID_STRING, "LID_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_QSTRING.NextNode());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1101:40: ( ID )?
            	    if ( stream_ID.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_ID.NextNode());

            	    }
            	    stream_ID.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "lid_string"

    public class fields_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "fields"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1103:1: fields : FIELDS ( field )* -> ^( FIELDS ( field )* ) ;
    public BlaiseParser.fields_return fields() // throws RecognitionException [1]
    {   
        BlaiseParser.fields_return retval = new BlaiseParser.fields_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FIELDS339 = null;
        BlaiseParser.field_return field340 = default(BlaiseParser.field_return);


        object FIELDS339_tree=null;
        RewriteRuleTokenStream stream_FIELDS = new RewriteRuleTokenStream(adaptor,"token FIELDS");
        RewriteRuleSubtreeStream stream_field = new RewriteRuleSubtreeStream(adaptor,"rule field");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1103:8: ( FIELDS ( field )* -> ^( FIELDS ( field )* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1103:10: FIELDS ( field )*
            {
            	FIELDS339=(IToken)Match(input,FIELDS,FOLLOW_FIELDS_in_fields6725); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FIELDS.Add(FIELDS339);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1103:17: ( field )*
            	do 
            	{
            	    int alt108 = 2;
            	    int LA108_0 = input.LA(1);

            	    if ( (LA108_0 == ID) )
            	    {
            	        alt108 = 1;
            	    }


            	    switch (alt108) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: field
            			    {
            			    	PushFollow(FOLLOW_field_in_fields6727);
            			    	field340 = field();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_field.Add(field340.Tree);

            			    }
            			    break;

            			default:
            			    goto loop108;
            	    }
            	} while (true);

            	loop108:
            		;	// Stops C# compiler whining that label 'loop108' has no statements



            	// AST REWRITE
            	// elements:          field, FIELDS
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 1103:24: -> ^( FIELDS ( field )* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1103:27: ^( FIELDS ( field )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_FIELDS.NextNode(), root_1);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1103:36: ( field )*
            	    while ( stream_field.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_field.NextTree());

            	    }
            	    stream_field.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fields"

    public class field_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "field"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1105:1: field : id_list ( field_tag )? ( field_text )* ( SLASH ( field_desc )* )? COLON typedef ( SEMI )? -> ^( FIELD id_list ( field_text )* ( field_desc )* typedef ( field_tag )? ) ;
    public BlaiseParser.field_return field() // throws RecognitionException [1]
    {   
        BlaiseParser.field_return retval = new BlaiseParser.field_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SLASH344 = null;
        IToken COLON346 = null;
        IToken SEMI348 = null;
        BlaiseParser.id_list_return id_list341 = default(BlaiseParser.id_list_return);

        BlaiseParser.field_tag_return field_tag342 = default(BlaiseParser.field_tag_return);

        BlaiseParser.field_text_return field_text343 = default(BlaiseParser.field_text_return);

        BlaiseParser.field_desc_return field_desc345 = default(BlaiseParser.field_desc_return);

        BlaiseParser.typedef_return typedef347 = default(BlaiseParser.typedef_return);


        object SLASH344_tree=null;
        object COLON346_tree=null;
        object SEMI348_tree=null;
        RewriteRuleTokenStream stream_COLON = new RewriteRuleTokenStream(adaptor,"token COLON");
        RewriteRuleTokenStream stream_SLASH = new RewriteRuleTokenStream(adaptor,"token SLASH");
        RewriteRuleTokenStream stream_SEMI = new RewriteRuleTokenStream(adaptor,"token SEMI");
        RewriteRuleSubtreeStream stream_field_desc = new RewriteRuleSubtreeStream(adaptor,"rule field_desc");
        RewriteRuleSubtreeStream stream_field_tag = new RewriteRuleSubtreeStream(adaptor,"rule field_tag");
        RewriteRuleSubtreeStream stream_field_text = new RewriteRuleSubtreeStream(adaptor,"rule field_text");
        RewriteRuleSubtreeStream stream_typedef = new RewriteRuleSubtreeStream(adaptor,"rule typedef");
        RewriteRuleSubtreeStream stream_id_list = new RewriteRuleSubtreeStream(adaptor,"rule id_list");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1105:7: ( id_list ( field_tag )? ( field_text )* ( SLASH ( field_desc )* )? COLON typedef ( SEMI )? -> ^( FIELD id_list ( field_text )* ( field_desc )* typedef ( field_tag )? ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1105:9: id_list ( field_tag )? ( field_text )* ( SLASH ( field_desc )* )? COLON typedef ( SEMI )?
            {
            	PushFollow(FOLLOW_id_list_in_field6745);
            	id_list341 = id_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_id_list.Add(id_list341.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1105:17: ( field_tag )?
            	int alt109 = 2;
            	int LA109_0 = input.LA(1);

            	if ( (LA109_0 == LPAREN) )
            	{
            	    alt109 = 1;
            	}
            	switch (alt109) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: field_tag
            	        {
            	        	PushFollow(FOLLOW_field_tag_in_field6747);
            	        	field_tag342 = field_tag();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_field_tag.Add(field_tag342.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1105:28: ( field_text )*
            	do 
            	{
            	    int alt110 = 2;
            	    int LA110_0 = input.LA(1);

            	    if ( (LA110_0 == QSTRING || LA110_0 == ID) )
            	    {
            	        alt110 = 1;
            	    }


            	    switch (alt110) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: field_text
            			    {
            			    	PushFollow(FOLLOW_field_text_in_field6750);
            			    	field_text343 = field_text();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_field_text.Add(field_text343.Tree);

            			    }
            			    break;

            			default:
            			    goto loop110;
            	    }
            	} while (true);

            	loop110:
            		;	// Stops C# compiler whining that label 'loop110' has no statements

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1105:40: ( SLASH ( field_desc )* )?
            	int alt112 = 2;
            	int LA112_0 = input.LA(1);

            	if ( (LA112_0 == SLASH) )
            	{
            	    alt112 = 1;
            	}
            	switch (alt112) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1105:41: SLASH ( field_desc )*
            	        {
            	        	SLASH344=(IToken)Match(input,SLASH,FOLLOW_SLASH_in_field6754); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_SLASH.Add(SLASH344);

            	        	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1105:47: ( field_desc )*
            	        	do 
            	        	{
            	        	    int alt111 = 2;
            	        	    int LA111_0 = input.LA(1);

            	        	    if ( (LA111_0 == QSTRING || LA111_0 == ID) )
            	        	    {
            	        	        alt111 = 1;
            	        	    }


            	        	    switch (alt111) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: field_desc
            	        			    {
            	        			    	PushFollow(FOLLOW_field_desc_in_field6756);
            	        			    	field_desc345 = field_desc();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_field_desc.Add(field_desc345.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop111;
            	        	    }
            	        	} while (true);

            	        	loop111:
            	        		;	// Stops C# compiler whining that label 'loop111' has no statements


            	        }
            	        break;

            	}

            	COLON346=(IToken)Match(input,COLON,FOLLOW_COLON_in_field6761); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_COLON.Add(COLON346);

            	PushFollow(FOLLOW_typedef_in_field6763);
            	typedef347 = typedef();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_typedef.Add(typedef347.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1105:75: ( SEMI )?
            	int alt113 = 2;
            	int LA113_0 = input.LA(1);

            	if ( (LA113_0 == SEMI) )
            	{
            	    alt113 = 1;
            	}
            	switch (alt113) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: SEMI
            	        {
            	        	SEMI348=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_field6765); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_SEMI.Add(SEMI348);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          field_tag, typedef, field_text, field_desc, id_list
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 1106:3: -> ^( FIELD id_list ( field_text )* ( field_desc )* typedef ( field_tag )? )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1106:6: ^( FIELD id_list ( field_text )* ( field_desc )* typedef ( field_tag )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FIELD, "FIELD"), root_1);

            	    adaptor.AddChild(root_1, stream_id_list.NextTree());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1106:22: ( field_text )*
            	    while ( stream_field_text.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_field_text.NextTree());

            	    }
            	    stream_field_text.Reset();
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1106:34: ( field_desc )*
            	    while ( stream_field_desc.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_field_desc.NextTree());

            	    }
            	    stream_field_desc.Reset();
            	    adaptor.AddChild(root_1, stream_typedef.NextTree());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1106:54: ( field_tag )?
            	    if ( stream_field_tag.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_field_tag.NextTree());

            	    }
            	    stream_field_tag.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "field"

    public class field_text_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "field_text"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1108:1: field_text : lid_string -> ^( FIELD_TEXT lid_string ) ;
    public BlaiseParser.field_text_return field_text() // throws RecognitionException [1]
    {   
        BlaiseParser.field_text_return retval = new BlaiseParser.field_text_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        BlaiseParser.lid_string_return lid_string349 = default(BlaiseParser.lid_string_return);


        RewriteRuleSubtreeStream stream_lid_string = new RewriteRuleSubtreeStream(adaptor,"rule lid_string");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1109:2: ( lid_string -> ^( FIELD_TEXT lid_string ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1109:4: lid_string
            {
            	PushFollow(FOLLOW_lid_string_in_field_text6796);
            	lid_string349 = lid_string();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_lid_string.Add(lid_string349.Tree);


            	// AST REWRITE
            	// elements:          lid_string
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 1109:15: -> ^( FIELD_TEXT lid_string )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1109:17: ^( FIELD_TEXT lid_string )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FIELD_TEXT, "FIELD_TEXT"), root_1);

            	    adaptor.AddChild(root_1, stream_lid_string.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "field_text"

    public class field_desc_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "field_desc"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1111:1: field_desc : lid_string -> ^( FIELD_DESC lid_string ) ;
    public BlaiseParser.field_desc_return field_desc() // throws RecognitionException [1]
    {   
        BlaiseParser.field_desc_return retval = new BlaiseParser.field_desc_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        BlaiseParser.lid_string_return lid_string350 = default(BlaiseParser.lid_string_return);


        RewriteRuleSubtreeStream stream_lid_string = new RewriteRuleSubtreeStream(adaptor,"rule lid_string");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1112:2: ( lid_string -> ^( FIELD_DESC lid_string ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1112:4: lid_string
            {
            	PushFollow(FOLLOW_lid_string_in_field_desc6813);
            	lid_string350 = lid_string();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_lid_string.Add(lid_string350.Tree);


            	// AST REWRITE
            	// elements:          lid_string
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 1112:15: -> ^( FIELD_DESC lid_string )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1112:17: ^( FIELD_DESC lid_string )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FIELD_DESC, "FIELD_DESC"), root_1);

            	    adaptor.AddChild(root_1, stream_lid_string.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "field_desc"

    public class field_tag_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "field_tag"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1114:1: field_tag : '(' id_list ')' -> ^( FIELD_TAG id_list ) ;
    public BlaiseParser.field_tag_return field_tag() // throws RecognitionException [1]
    {   
        BlaiseParser.field_tag_return retval = new BlaiseParser.field_tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal351 = null;
        IToken char_literal353 = null;
        BlaiseParser.id_list_return id_list352 = default(BlaiseParser.id_list_return);


        object char_literal351_tree=null;
        object char_literal353_tree=null;
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_id_list = new RewriteRuleSubtreeStream(adaptor,"rule id_list");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1115:2: ( '(' id_list ')' -> ^( FIELD_TAG id_list ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1115:4: '(' id_list ')'
            {
            	char_literal351=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_field_tag6830); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LPAREN.Add(char_literal351);

            	PushFollow(FOLLOW_id_list_in_field_tag6832);
            	id_list352 = id_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_id_list.Add(id_list352.Tree);
            	char_literal353=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_field_tag6834); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RPAREN.Add(char_literal353);



            	// AST REWRITE
            	// elements:          id_list
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 1115:20: -> ^( FIELD_TAG id_list )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1115:23: ^( FIELD_TAG id_list )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FIELD_TAG, "FIELD_TAG"), root_1);

            	    adaptor.AddChild(root_1, stream_id_list.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "field_tag"

    public class typedef_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "typedef"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1117:1: typedef : typespec (a= attribute_values )? ( COMMA b+= attribute_values )* -> ^( TYPEDEF typespec ( $a)? ( $b)* ) ;
    public BlaiseParser.typedef_return typedef() // throws RecognitionException [1]
    {   
        BlaiseParser.typedef_return retval = new BlaiseParser.typedef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA355 = null;
        IList list_b = null;
        BlaiseParser.attribute_values_return a = default(BlaiseParser.attribute_values_return);

        BlaiseParser.typespec_return typespec354 = default(BlaiseParser.typespec_return);

        BlaiseParser.attribute_values_return b = default(BlaiseParser.attribute_values_return);
         b = null;
        object COMMA355_tree=null;
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleSubtreeStream stream_typespec = new RewriteRuleSubtreeStream(adaptor,"rule typespec");
        RewriteRuleSubtreeStream stream_attribute_values = new RewriteRuleSubtreeStream(adaptor,"rule attribute_values");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1118:2: ( typespec (a= attribute_values )? ( COMMA b+= attribute_values )* -> ^( TYPEDEF typespec ( $a)? ( $b)* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1118:4: typespec (a= attribute_values )? ( COMMA b+= attribute_values )*
            {
            	PushFollow(FOLLOW_typespec_in_typedef6851);
            	typespec354 = typespec();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_typespec.Add(typespec354.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1118:14: (a= attribute_values )?
            	int alt114 = 2;
            	int LA114_0 = input.LA(1);

            	if ( ((LA114_0 >= EMPTY && LA114_0 <= DK)) )
            	{
            	    alt114 = 1;
            	}
            	switch (alt114) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: a= attribute_values
            	        {
            	        	PushFollow(FOLLOW_attribute_values_in_typedef6855);
            	        	a = attribute_values();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_attribute_values.Add(a.Tree);

            	        }
            	        break;

            	}

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1118:33: ( COMMA b+= attribute_values )*
            	do 
            	{
            	    int alt115 = 2;
            	    int LA115_0 = input.LA(1);

            	    if ( (LA115_0 == COMMA) )
            	    {
            	        alt115 = 1;
            	    }


            	    switch (alt115) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1118:34: COMMA b+= attribute_values
            			    {
            			    	COMMA355=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_typedef6859); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA355);

            			    	PushFollow(FOLLOW_attribute_values_in_typedef6863);
            			    	b = attribute_values();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_attribute_values.Add(b.Tree);
            			    	if (list_b == null) list_b = new ArrayList();
            			    	list_b.Add(b.Tree);


            			    }
            			    break;

            			default:
            			    goto loop115;
            	    }
            	} while (true);

            	loop115:
            		;	// Stops C# compiler whining that label 'loop115' has no statements



            	// AST REWRITE
            	// elements:          typespec, a, b
            	// token labels:      
            	// rule labels:       retval, a
            	// token list labels: 
            	// rule list labels:  b
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "token b", list_b);
            	root_0 = (object)adaptor.GetNilNode();
            	// 1119:3: -> ^( TYPEDEF typespec ( $a)? ( $b)* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1119:6: ^( TYPEDEF typespec ( $a)? ( $b)* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPEDEF, "TYPEDEF"), root_1);

            	    adaptor.AddChild(root_1, stream_typespec.NextTree());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1119:25: ( $a)?
            	    if ( stream_a.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_a.NextTree());

            	    }
            	    stream_a.Reset();
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1119:29: ( $b)*
            	    while ( stream_b.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_b.NextTree());

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "typedef"

    public class attribute_values_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "attribute_values"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1121:1: attribute_values : ( EMPTY | NOREFUSAL | NORF | NODONTKNOW | NODK | NOEMPTY | REFUSAL | RF | DONTKNOW | DK );
    public BlaiseParser.attribute_values_return attribute_values() // throws RecognitionException [1]
    {   
        BlaiseParser.attribute_values_return retval = new BlaiseParser.attribute_values_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set356 = null;

        object set356_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1122:2: ( EMPTY | NOREFUSAL | NORF | NODONTKNOW | NODK | NOEMPTY | REFUSAL | RF | DONTKNOW | DK )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set356 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= EMPTY && input.LA(1) <= DK) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set356));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "attribute_values"

    public class typespec_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "typespec"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1133:1: typespec : ( ( STRING ( '[' b= INT ']' )? ) -> ^( TYPE_STRING ( $b)? ) | OPEN -> ^( TYPE_OPEN ) | ( INTEGER ( '[' b= INT ']' )? ) -> ^( TYPE_INTEGER ( $b)? ) | realrange | ( 'REAL' ( '[' b= INT ( ',' c= INT )? ']' )? ) -> ^( TYPE_REAL ( $b)? ( $c)? ) | category_list -> ^( TYPE_CATEGORY category_list ) | SET ( '[' b= INT ']' )? OF category_list -> ^( TYPE_SETOF ( $b)? ^( TYPE_CATEGORY category_list ) ) | SET ( '[' b= INT ']' )? OF c= ID ( ',' d+= ID )* -> ^( TYPE_SETOF ( $b)? $c ( $d)* ) | DATETYPE -> ^( TYPE_DATETYPE ) | TIMETYPE -> ^( TYPE_TIMETYPE ) | ARRAY '[' realrange ( ',' realrange )* ']' OF typespec -> ^( TYPE_ARRAY ( realrange )* typespec ) | a= ID -> ^( TYPE_USERDEF $a) );
    public BlaiseParser.typespec_return typespec() // throws RecognitionException [1]
    {   
        BlaiseParser.typespec_return retval = new BlaiseParser.typespec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken b = null;
        IToken c = null;
        IToken a = null;
        IToken STRING357 = null;
        IToken char_literal358 = null;
        IToken char_literal359 = null;
        IToken OPEN360 = null;
        IToken INTEGER361 = null;
        IToken char_literal362 = null;
        IToken char_literal363 = null;
        IToken string_literal365 = null;
        IToken char_literal366 = null;
        IToken char_literal367 = null;
        IToken char_literal368 = null;
        IToken SET370 = null;
        IToken char_literal371 = null;
        IToken char_literal372 = null;
        IToken OF373 = null;
        IToken SET375 = null;
        IToken char_literal376 = null;
        IToken char_literal377 = null;
        IToken OF378 = null;
        IToken char_literal379 = null;
        IToken DATETYPE380 = null;
        IToken TIMETYPE381 = null;
        IToken ARRAY382 = null;
        IToken char_literal383 = null;
        IToken char_literal385 = null;
        IToken char_literal387 = null;
        IToken OF388 = null;
        IToken d = null;
        IList list_d = null;
        BlaiseParser.realrange_return realrange364 = default(BlaiseParser.realrange_return);

        BlaiseParser.category_list_return category_list369 = default(BlaiseParser.category_list_return);

        BlaiseParser.category_list_return category_list374 = default(BlaiseParser.category_list_return);

        BlaiseParser.realrange_return realrange384 = default(BlaiseParser.realrange_return);

        BlaiseParser.realrange_return realrange386 = default(BlaiseParser.realrange_return);

        BlaiseParser.typespec_return typespec389 = default(BlaiseParser.typespec_return);


        object b_tree=null;
        object c_tree=null;
        object a_tree=null;
        object STRING357_tree=null;
        object char_literal358_tree=null;
        object char_literal359_tree=null;
        object OPEN360_tree=null;
        object INTEGER361_tree=null;
        object char_literal362_tree=null;
        object char_literal363_tree=null;
        object string_literal365_tree=null;
        object char_literal366_tree=null;
        object char_literal367_tree=null;
        object char_literal368_tree=null;
        object SET370_tree=null;
        object char_literal371_tree=null;
        object char_literal372_tree=null;
        object OF373_tree=null;
        object SET375_tree=null;
        object char_literal376_tree=null;
        object char_literal377_tree=null;
        object OF378_tree=null;
        object char_literal379_tree=null;
        object DATETYPE380_tree=null;
        object TIMETYPE381_tree=null;
        object ARRAY382_tree=null;
        object char_literal383_tree=null;
        object char_literal385_tree=null;
        object char_literal387_tree=null;
        object OF388_tree=null;
        object d_tree=null;
        RewriteRuleTokenStream stream_RBRACK = new RewriteRuleTokenStream(adaptor,"token RBRACK");
        RewriteRuleTokenStream stream_OPEN = new RewriteRuleTokenStream(adaptor,"token OPEN");
        RewriteRuleTokenStream stream_INTEGER = new RewriteRuleTokenStream(adaptor,"token INTEGER");
        RewriteRuleTokenStream stream_LBRACK = new RewriteRuleTokenStream(adaptor,"token LBRACK");
        RewriteRuleTokenStream stream_TIMETYPE = new RewriteRuleTokenStream(adaptor,"token TIMETYPE");
        RewriteRuleTokenStream stream_214 = new RewriteRuleTokenStream(adaptor,"token 214");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_DATETYPE = new RewriteRuleTokenStream(adaptor,"token DATETYPE");
        RewriteRuleTokenStream stream_SET = new RewriteRuleTokenStream(adaptor,"token SET");
        RewriteRuleTokenStream stream_INT = new RewriteRuleTokenStream(adaptor,"token INT");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_OF = new RewriteRuleTokenStream(adaptor,"token OF");
        RewriteRuleTokenStream stream_ARRAY = new RewriteRuleTokenStream(adaptor,"token ARRAY");
        RewriteRuleTokenStream stream_STRING = new RewriteRuleTokenStream(adaptor,"token STRING");
        RewriteRuleSubtreeStream stream_typespec = new RewriteRuleSubtreeStream(adaptor,"rule typespec");
        RewriteRuleSubtreeStream stream_category_list = new RewriteRuleSubtreeStream(adaptor,"rule category_list");
        RewriteRuleSubtreeStream stream_realrange = new RewriteRuleSubtreeStream(adaptor,"rule realrange");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1134:2: ( ( STRING ( '[' b= INT ']' )? ) -> ^( TYPE_STRING ( $b)? ) | OPEN -> ^( TYPE_OPEN ) | ( INTEGER ( '[' b= INT ']' )? ) -> ^( TYPE_INTEGER ( $b)? ) | realrange | ( 'REAL' ( '[' b= INT ( ',' c= INT )? ']' )? ) -> ^( TYPE_REAL ( $b)? ( $c)? ) | category_list -> ^( TYPE_CATEGORY category_list ) | SET ( '[' b= INT ']' )? OF category_list -> ^( TYPE_SETOF ( $b)? ^( TYPE_CATEGORY category_list ) ) | SET ( '[' b= INT ']' )? OF c= ID ( ',' d+= ID )* -> ^( TYPE_SETOF ( $b)? $c ( $d)* ) | DATETYPE -> ^( TYPE_DATETYPE ) | TIMETYPE -> ^( TYPE_TIMETYPE ) | ARRAY '[' realrange ( ',' realrange )* ']' OF typespec -> ^( TYPE_ARRAY ( realrange )* typespec ) | a= ID -> ^( TYPE_USERDEF $a) )
            int alt124 = 12;
            alt124 = dfa124.Predict(input);
            switch (alt124) 
            {
                case 1 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1134:3: ( STRING ( '[' b= INT ']' )? )
                    {
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1134:3: ( STRING ( '[' b= INT ']' )? )
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1134:4: STRING ( '[' b= INT ']' )?
                    	{
                    		STRING357=(IToken)Match(input,STRING,FOLLOW_STRING_in_typespec6953); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_STRING.Add(STRING357);

                    		// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1134:11: ( '[' b= INT ']' )?
                    		int alt116 = 2;
                    		int LA116_0 = input.LA(1);

                    		if ( (LA116_0 == LBRACK) )
                    		{
                    		    alt116 = 1;
                    		}
                    		switch (alt116) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1134:12: '[' b= INT ']'
                    		        {
                    		        	char_literal358=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_typespec6956); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_LBRACK.Add(char_literal358);

                    		        	b=(IToken)Match(input,INT,FOLLOW_INT_in_typespec6960); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_INT.Add(b);

                    		        	char_literal359=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_typespec6962); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_RBRACK.Add(char_literal359);


                    		        }
                    		        break;

                    		}


                    	}



                    	// AST REWRITE
                    	// elements:          b
                    	// token labels:      b
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor, "token b", b);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 1134:29: -> ^( TYPE_STRING ( $b)? )
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1134:32: ^( TYPE_STRING ( $b)? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_STRING, "TYPE_STRING"), root_1);

                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1134:46: ( $b)?
                    	    if ( stream_b.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_b.NextNode());

                    	    }
                    	    stream_b.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1135:4: OPEN
                    {
                    	OPEN360=(IToken)Match(input,OPEN,FOLLOW_OPEN_in_typespec6980); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_OPEN.Add(OPEN360);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 1135:8: -> ^( TYPE_OPEN )
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1135:11: ^( TYPE_OPEN )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_OPEN, "TYPE_OPEN"), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1137:4: ( INTEGER ( '[' b= INT ']' )? )
                    {
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1137:4: ( INTEGER ( '[' b= INT ']' )? )
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1137:5: INTEGER ( '[' b= INT ']' )?
                    	{
                    		INTEGER361=(IToken)Match(input,INTEGER,FOLLOW_INTEGER_in_typespec6993); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_INTEGER.Add(INTEGER361);

                    		// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1137:13: ( '[' b= INT ']' )?
                    		int alt117 = 2;
                    		int LA117_0 = input.LA(1);

                    		if ( (LA117_0 == LBRACK) )
                    		{
                    		    alt117 = 1;
                    		}
                    		switch (alt117) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1137:14: '[' b= INT ']'
                    		        {
                    		        	char_literal362=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_typespec6996); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_LBRACK.Add(char_literal362);

                    		        	b=(IToken)Match(input,INT,FOLLOW_INT_in_typespec7000); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_INT.Add(b);

                    		        	char_literal363=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_typespec7002); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_RBRACK.Add(char_literal363);


                    		        }
                    		        break;

                    		}


                    	}



                    	// AST REWRITE
                    	// elements:          b
                    	// token labels:      b
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor, "token b", b);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 1137:31: -> ^( TYPE_INTEGER ( $b)? )
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1137:34: ^( TYPE_INTEGER ( $b)? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_INTEGER, "TYPE_INTEGER"), root_1);

                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1137:49: ( $b)?
                    	    if ( stream_b.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_b.NextNode());

                    	    }
                    	    stream_b.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1138:4: realrange
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_realrange_in_typespec7020);
                    	realrange364 = realrange();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, realrange364.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1139:4: ( 'REAL' ( '[' b= INT ( ',' c= INT )? ']' )? )
                    {
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1139:4: ( 'REAL' ( '[' b= INT ( ',' c= INT )? ']' )? )
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1139:5: 'REAL' ( '[' b= INT ( ',' c= INT )? ']' )?
                    	{
                    		string_literal365=(IToken)Match(input,214,FOLLOW_214_in_typespec7026); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_214.Add(string_literal365);

                    		// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1139:12: ( '[' b= INT ( ',' c= INT )? ']' )?
                    		int alt119 = 2;
                    		int LA119_0 = input.LA(1);

                    		if ( (LA119_0 == LBRACK) )
                    		{
                    		    alt119 = 1;
                    		}
                    		switch (alt119) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1139:13: '[' b= INT ( ',' c= INT )? ']'
                    		        {
                    		        	char_literal366=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_typespec7029); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_LBRACK.Add(char_literal366);

                    		        	b=(IToken)Match(input,INT,FOLLOW_INT_in_typespec7033); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_INT.Add(b);

                    		        	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1139:23: ( ',' c= INT )?
                    		        	int alt118 = 2;
                    		        	int LA118_0 = input.LA(1);

                    		        	if ( (LA118_0 == COMMA) )
                    		        	{
                    		        	    alt118 = 1;
                    		        	}
                    		        	switch (alt118) 
                    		        	{
                    		        	    case 1 :
                    		        	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1139:24: ',' c= INT
                    		        	        {
                    		        	        	char_literal367=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_typespec7036); if (state.failed) return retval; 
                    		        	        	if ( (state.backtracking==0) ) stream_COMMA.Add(char_literal367);

                    		        	        	c=(IToken)Match(input,INT,FOLLOW_INT_in_typespec7040); if (state.failed) return retval; 
                    		        	        	if ( (state.backtracking==0) ) stream_INT.Add(c);


                    		        	        }
                    		        	        break;

                    		        	}

                    		        	char_literal368=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_typespec7044); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_RBRACK.Add(char_literal368);


                    		        }
                    		        break;

                    		}


                    	}



                    	// AST REWRITE
                    	// elements:          b, c
                    	// token labels:      b, c
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor, "token b", b);
                    	RewriteRuleTokenStream stream_c = new RewriteRuleTokenStream(adaptor, "token c", c);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 1139:43: -> ^( TYPE_REAL ( $b)? ( $c)? )
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1139:46: ^( TYPE_REAL ( $b)? ( $c)? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_REAL, "TYPE_REAL"), root_1);

                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1139:58: ( $b)?
                    	    if ( stream_b.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_b.NextNode());

                    	    }
                    	    stream_b.Reset();
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1139:62: ( $c)?
                    	    if ( stream_c.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_c.NextNode());

                    	    }
                    	    stream_c.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 6 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1140:4: category_list
                    {
                    	PushFollow(FOLLOW_category_list_in_typespec7066);
                    	category_list369 = category_list();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_category_list.Add(category_list369.Tree);


                    	// AST REWRITE
                    	// elements:          category_list
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 1140:17: -> ^( TYPE_CATEGORY category_list )
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1140:20: ^( TYPE_CATEGORY category_list )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_CATEGORY, "TYPE_CATEGORY"), root_1);

                    	    adaptor.AddChild(root_1, stream_category_list.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 7 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1141:4: SET ( '[' b= INT ']' )? OF category_list
                    {
                    	SET370=(IToken)Match(input,SET,FOLLOW_SET_in_typespec7078); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_SET.Add(SET370);

                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1141:8: ( '[' b= INT ']' )?
                    	int alt120 = 2;
                    	int LA120_0 = input.LA(1);

                    	if ( (LA120_0 == LBRACK) )
                    	{
                    	    alt120 = 1;
                    	}
                    	switch (alt120) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1141:9: '[' b= INT ']'
                    	        {
                    	        	char_literal371=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_typespec7081); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_LBRACK.Add(char_literal371);

                    	        	b=(IToken)Match(input,INT,FOLLOW_INT_in_typespec7085); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_INT.Add(b);

                    	        	char_literal372=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_typespec7087); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_RBRACK.Add(char_literal372);


                    	        }
                    	        break;

                    	}

                    	OF373=(IToken)Match(input,OF,FOLLOW_OF_in_typespec7091); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_OF.Add(OF373);

                    	PushFollow(FOLLOW_category_list_in_typespec7093);
                    	category_list374 = category_list();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_category_list.Add(category_list374.Tree);


                    	// AST REWRITE
                    	// elements:          category_list, b
                    	// token labels:      b
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor, "token b", b);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 1141:42: -> ^( TYPE_SETOF ( $b)? ^( TYPE_CATEGORY category_list ) )
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1141:45: ^( TYPE_SETOF ( $b)? ^( TYPE_CATEGORY category_list ) )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_SETOF, "TYPE_SETOF"), root_1);

                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1141:58: ( $b)?
                    	    if ( stream_b.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_b.NextNode());

                    	    }
                    	    stream_b.Reset();
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1141:62: ^( TYPE_CATEGORY category_list )
                    	    {
                    	    object root_2 = (object)adaptor.GetNilNode();
                    	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_CATEGORY, "TYPE_CATEGORY"), root_2);

                    	    adaptor.AddChild(root_2, stream_category_list.NextTree());

                    	    adaptor.AddChild(root_1, root_2);
                    	    }

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 8 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1142:4: SET ( '[' b= INT ']' )? OF c= ID ( ',' d+= ID )*
                    {
                    	SET375=(IToken)Match(input,SET,FOLLOW_SET_in_typespec7114); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_SET.Add(SET375);

                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1142:8: ( '[' b= INT ']' )?
                    	int alt121 = 2;
                    	int LA121_0 = input.LA(1);

                    	if ( (LA121_0 == LBRACK) )
                    	{
                    	    alt121 = 1;
                    	}
                    	switch (alt121) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1142:9: '[' b= INT ']'
                    	        {
                    	        	char_literal376=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_typespec7117); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_LBRACK.Add(char_literal376);

                    	        	b=(IToken)Match(input,INT,FOLLOW_INT_in_typespec7121); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_INT.Add(b);

                    	        	char_literal377=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_typespec7123); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_RBRACK.Add(char_literal377);


                    	        }
                    	        break;

                    	}

                    	OF378=(IToken)Match(input,OF,FOLLOW_OF_in_typespec7127); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_OF.Add(OF378);

                    	c=(IToken)Match(input,ID,FOLLOW_ID_in_typespec7131); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_ID.Add(c);

                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1142:33: ( ',' d+= ID )*
                    	do 
                    	{
                    	    int alt122 = 2;
                    	    int LA122_0 = input.LA(1);

                    	    if ( (LA122_0 == COMMA) )
                    	    {
                    	        int LA122_2 = input.LA(2);

                    	        if ( (LA122_2 == ID) )
                    	        {
                    	            alt122 = 1;
                    	        }


                    	    }


                    	    switch (alt122) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1142:34: ',' d+= ID
                    			    {
                    			    	char_literal379=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_typespec7134); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_COMMA.Add(char_literal379);

                    			    	d=(IToken)Match(input,ID,FOLLOW_ID_in_typespec7138); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_ID.Add(d);

                    			    	if (list_d == null) list_d = new ArrayList();
                    			    	list_d.Add(d);


                    			    }
                    			    break;

                    			default:
                    			    goto loop122;
                    	    }
                    	} while (true);

                    	loop122:
                    		;	// Stops C# compiler whining that label 'loop122' has no statements



                    	// AST REWRITE
                    	// elements:          b, c, d
                    	// token labels:      b, c
                    	// rule labels:       retval
                    	// token list labels: d
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor, "token b", b);
                    	RewriteRuleTokenStream stream_c = new RewriteRuleTokenStream(adaptor, "token c", c);
                    	RewriteRuleTokenStream stream_d = new RewriteRuleTokenStream(adaptor,"token d", list_d);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 1142:46: -> ^( TYPE_SETOF ( $b)? $c ( $d)* )
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1142:49: ^( TYPE_SETOF ( $b)? $c ( $d)* )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_SETOF, "TYPE_SETOF"), root_1);

                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1142:62: ( $b)?
                    	    if ( stream_b.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_b.NextNode());

                    	    }
                    	    stream_b.Reset();
                    	    adaptor.AddChild(root_1, stream_c.NextNode());
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1142:69: ( $d)*
                    	    while ( stream_d.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_d.NextNode());

                    	    }
                    	    stream_d.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 9 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1143:4: DATETYPE
                    {
                    	DATETYPE380=(IToken)Match(input,DATETYPE,FOLLOW_DATETYPE_in_typespec7162); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DATETYPE.Add(DATETYPE380);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 1143:12: -> ^( TYPE_DATETYPE )
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1143:15: ^( TYPE_DATETYPE )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DATETYPE, "TYPE_DATETYPE"), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 10 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1144:4: TIMETYPE
                    {
                    	TIMETYPE381=(IToken)Match(input,TIMETYPE,FOLLOW_TIMETYPE_in_typespec7172); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_TIMETYPE.Add(TIMETYPE381);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 1144:12: -> ^( TYPE_TIMETYPE )
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1144:15: ^( TYPE_TIMETYPE )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_TIMETYPE, "TYPE_TIMETYPE"), root_1);

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 11 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1146:4: ARRAY '[' realrange ( ',' realrange )* ']' OF typespec
                    {
                    	ARRAY382=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_typespec7184); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_ARRAY.Add(ARRAY382);

                    	char_literal383=(IToken)Match(input,LBRACK,FOLLOW_LBRACK_in_typespec7186); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_LBRACK.Add(char_literal383);

                    	PushFollow(FOLLOW_realrange_in_typespec7188);
                    	realrange384 = realrange();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_realrange.Add(realrange384.Tree);
                    	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1146:24: ( ',' realrange )*
                    	do 
                    	{
                    	    int alt123 = 2;
                    	    int LA123_0 = input.LA(1);

                    	    if ( (LA123_0 == COMMA) )
                    	    {
                    	        alt123 = 1;
                    	    }


                    	    switch (alt123) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1146:25: ',' realrange
                    			    {
                    			    	char_literal385=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_typespec7191); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_COMMA.Add(char_literal385);

                    			    	PushFollow(FOLLOW_realrange_in_typespec7193);
                    			    	realrange386 = realrange();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_realrange.Add(realrange386.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop123;
                    	    }
                    	} while (true);

                    	loop123:
                    		;	// Stops C# compiler whining that label 'loop123' has no statements

                    	char_literal387=(IToken)Match(input,RBRACK,FOLLOW_RBRACK_in_typespec7198); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_RBRACK.Add(char_literal387);

                    	OF388=(IToken)Match(input,OF,FOLLOW_OF_in_typespec7200); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_OF.Add(OF388);

                    	PushFollow(FOLLOW_typespec_in_typespec7202);
                    	typespec389 = typespec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_typespec.Add(typespec389.Tree);


                    	// AST REWRITE
                    	// elements:          typespec, realrange
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 1146:58: -> ^( TYPE_ARRAY ( realrange )* typespec )
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1146:61: ^( TYPE_ARRAY ( realrange )* typespec )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_ARRAY, "TYPE_ARRAY"), root_1);

                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1146:74: ( realrange )*
                    	    while ( stream_realrange.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_realrange.NextTree());

                    	    }
                    	    stream_realrange.Reset();
                    	    adaptor.AddChild(root_1, stream_typespec.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 12 :
                    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1147:4: a= ID
                    {
                    	a=(IToken)Match(input,ID,FOLLOW_ID_in_typespec7220); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_ID.Add(a);



                    	// AST REWRITE
                    	// elements:          a
                    	// token labels:      a
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleTokenStream stream_a = new RewriteRuleTokenStream(adaptor, "token a", a);
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 1147:9: -> ^( TYPE_USERDEF $a)
                    	{
                    	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1147:12: ^( TYPE_USERDEF $a)
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_USERDEF, "TYPE_USERDEF"), root_1);

                    	    adaptor.AddChild(root_1, stream_a.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "typespec"

    public class category_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "category_list"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1150:1: category_list : '(' a= category ( ',' b+= category )* ')' ;
    public BlaiseParser.category_list_return category_list() // throws RecognitionException [1]
    {   
        BlaiseParser.category_list_return retval = new BlaiseParser.category_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal390 = null;
        IToken char_literal391 = null;
        IToken char_literal392 = null;
        IList list_b = null;
        BlaiseParser.category_return a = default(BlaiseParser.category_return);

        BlaiseParser.category_return b = default(BlaiseParser.category_return);
         b = null;
        object char_literal390_tree=null;
        object char_literal391_tree=null;
        object char_literal392_tree=null;

        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1151:2: ( '(' a= category ( ',' b+= category )* ')' )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1151:4: '(' a= category ( ',' b+= category )* ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal390=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_category_list7241); if (state.failed) return retval;
            	PushFollow(FOLLOW_category_in_category_list7246);
            	a = category();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, a.Tree);
            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1151:20: ( ',' b+= category )*
            	do 
            	{
            	    int alt125 = 2;
            	    int LA125_0 = input.LA(1);

            	    if ( (LA125_0 == COMMA) )
            	    {
            	        alt125 = 1;
            	    }


            	    switch (alt125) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1151:21: ',' b+= category
            			    {
            			    	char_literal391=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_category_list7249); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_category_in_category_list7254);
            			    	b = category();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, b.Tree);
            			    	if (list_b == null) list_b = new ArrayList();
            			    	list_b.Add(b.Tree);


            			    }
            			    break;

            			default:
            			    goto loop125;
            	    }
            	} while (true);

            	loop125:
            		;	// Stops C# compiler whining that label 'loop125' has no statements

            	char_literal392=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_category_list7258); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "category_list"

    public class category_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "category"
    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1154:1: category : ID ( '(' signedInteger ')' )? ( lid_string )* -> ^( CATEGORY ID ^( TYPE_CATEGORY_CODE ( signedInteger )? ) ( lid_string )* ) ;
    public BlaiseParser.category_return category() // throws RecognitionException [1]
    {   
        BlaiseParser.category_return retval = new BlaiseParser.category_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID393 = null;
        IToken char_literal394 = null;
        IToken char_literal396 = null;
        BlaiseParser.signedInteger_return signedInteger395 = default(BlaiseParser.signedInteger_return);

        BlaiseParser.lid_string_return lid_string397 = default(BlaiseParser.lid_string_return);


        object ID393_tree=null;
        object char_literal394_tree=null;
        object char_literal396_tree=null;
        RewriteRuleTokenStream stream_RPAREN = new RewriteRuleTokenStream(adaptor,"token RPAREN");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_LPAREN = new RewriteRuleTokenStream(adaptor,"token LPAREN");
        RewriteRuleSubtreeStream stream_signedInteger = new RewriteRuleSubtreeStream(adaptor,"rule signedInteger");
        RewriteRuleSubtreeStream stream_lid_string = new RewriteRuleSubtreeStream(adaptor,"rule lid_string");
        try 
    	{
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1155:2: ( ID ( '(' signedInteger ')' )? ( lid_string )* -> ^( CATEGORY ID ^( TYPE_CATEGORY_CODE ( signedInteger )? ) ( lid_string )* ) )
            // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1155:4: ID ( '(' signedInteger ')' )? ( lid_string )*
            {
            	ID393=(IToken)Match(input,ID,FOLLOW_ID_in_category7272); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID393);

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1155:7: ( '(' signedInteger ')' )?
            	int alt126 = 2;
            	int LA126_0 = input.LA(1);

            	if ( (LA126_0 == LPAREN) )
            	{
            	    alt126 = 1;
            	}
            	switch (alt126) 
            	{
            	    case 1 :
            	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1155:8: '(' signedInteger ')'
            	        {
            	        	char_literal394=(IToken)Match(input,LPAREN,FOLLOW_LPAREN_in_category7275); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_LPAREN.Add(char_literal394);

            	        	PushFollow(FOLLOW_signedInteger_in_category7277);
            	        	signedInteger395 = signedInteger();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_signedInteger.Add(signedInteger395.Tree);
            	        	char_literal396=(IToken)Match(input,RPAREN,FOLLOW_RPAREN_in_category7279); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_RPAREN.Add(char_literal396);


            	        }
            	        break;

            	}

            	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1155:32: ( lid_string )*
            	do 
            	{
            	    int alt127 = 2;
            	    int LA127_0 = input.LA(1);

            	    if ( (LA127_0 == QSTRING || LA127_0 == ID) )
            	    {
            	        alt127 = 1;
            	    }


            	    switch (alt127) 
            		{
            			case 1 :
            			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:0:0: lid_string
            			    {
            			    	PushFollow(FOLLOW_lid_string_in_category7283);
            			    	lid_string397 = lid_string();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_lid_string.Add(lid_string397.Tree);

            			    }
            			    break;

            			default:
            			    goto loop127;
            	    }
            	} while (true);

            	loop127:
            		;	// Stops C# compiler whining that label 'loop127' has no statements



            	// AST REWRITE
            	// elements:          signedInteger, lid_string, ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 1155:44: -> ^( CATEGORY ID ^( TYPE_CATEGORY_CODE ( signedInteger )? ) ( lid_string )* )
            	{
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1155:47: ^( CATEGORY ID ^( TYPE_CATEGORY_CODE ( signedInteger )? ) ( lid_string )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CATEGORY, "CATEGORY"), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1155:61: ^( TYPE_CATEGORY_CODE ( signedInteger )? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_CATEGORY_CODE, "TYPE_CATEGORY_CODE"), root_2);

            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1155:82: ( signedInteger )?
            	    if ( stream_signedInteger.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_signedInteger.NextTree());

            	    }
            	    stream_signedInteger.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1155:98: ( lid_string )*
            	    while ( stream_lid_string.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_lid_string.NextTree());

            	    }
            	    stream_lid_string.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "category"

    // $ANTLR start "synpred41_Blaise"
    public void synpred41_Blaise_fragment() {
        BlaiseParser.variable_return a = default(BlaiseParser.variable_return);


        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:671:5: (a= variable '=' )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:671:5: a= variable '='
        {
        	PushFollow(FOLLOW_variable_in_synpred41_Blaise4114);
        	a = variable();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,EQUAL,FOLLOW_EQUAL_in_synpred41_Blaise4116); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred41_Blaise"

    // $ANTLR start "synpred81_Blaise"
    public void synpred81_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:748:4: ( ID ASSIGN )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:748:5: ID ASSIGN
        {
        	Match(input,ID,FOLLOW_ID_in_synpred81_Blaise4655); if (state.failed) return ;
        	Match(input,ASSIGN,FOLLOW_ASSIGN_in_synpred81_Blaise4657); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred81_Blaise"

    // $ANTLR start "synpred82_Blaise"
    public void synpred82_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:750:4: ( variable ASSIGN )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:750:5: variable ASSIGN
        {
        	PushFollow(FOLLOW_variable_in_synpred82_Blaise4671);
        	variable();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,ASSIGN,FOLLOW_ASSIGN_in_synpred82_Blaise4673); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred82_Blaise"

    // $ANTLR start "synpred83_Blaise"
    public void synpred83_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:758:5: ( expression QSTRING )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:758:6: expression QSTRING
        {
        	PushFollow(FOLLOW_expression_in_synpred83_Blaise4702);
        	expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,QSTRING,FOLLOW_QSTRING_in_synpred83_Blaise4705); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred83_Blaise"

    // $ANTLR start "synpred84_Blaise"
    public void synpred84_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:764:3: ( '[' )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:764:4: '['
        {
        	Match(input,LBRACK,FOLLOW_LBRACK_in_synpred84_Blaise4747); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred84_Blaise"

    // $ANTLR start "synpred103_Blaise"
    public void synpred103_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:845:4: ( '[' realrange ( ',' realrange )* ']' )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:845:4: '[' realrange ( ',' realrange )* ']'
        {
        	Match(input,LBRACK,FOLLOW_LBRACK_in_synpred103_Blaise5161); if (state.failed) return ;
        	PushFollow(FOLLOW_realrange_in_synpred103_Blaise5163);
        	realrange();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:845:18: ( ',' realrange )*
        	do 
        	{
        	    int alt129 = 2;
        	    int LA129_0 = input.LA(1);

        	    if ( (LA129_0 == COMMA) )
        	    {
        	        alt129 = 1;
        	    }


        	    switch (alt129) 
        		{
        			case 1 :
        			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:845:19: ',' realrange
        			    {
        			    	Match(input,COMMA,FOLLOW_COMMA_in_synpred103_Blaise5166); if (state.failed) return ;
        			    	PushFollow(FOLLOW_realrange_in_synpred103_Blaise5168);
        			    	realrange();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop129;
        	    }
        	} while (true);

        	loop129:
        		;	// Stops C# compiler whining that label 'loop129' has no statements

        	Match(input,RBRACK,FOLLOW_RBRACK_in_synpred103_Blaise5172); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred103_Blaise"

    // $ANTLR start "synpred105_Blaise"
    public void synpred105_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:846:4: ( '[' signedNumberOrRange ( ',' signedNumberOrRange )* ']' )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:846:4: '[' signedNumberOrRange ( ',' signedNumberOrRange )* ']'
        {
        	Match(input,LBRACK,FOLLOW_LBRACK_in_synpred105_Blaise5177); if (state.failed) return ;
        	PushFollow(FOLLOW_signedNumberOrRange_in_synpred105_Blaise5179);
        	signedNumberOrRange();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:846:28: ( ',' signedNumberOrRange )*
        	do 
        	{
        	    int alt130 = 2;
        	    int LA130_0 = input.LA(1);

        	    if ( (LA130_0 == COMMA) )
        	    {
        	        alt130 = 1;
        	    }


        	    switch (alt130) 
        		{
        			case 1 :
        			    // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:846:29: ',' signedNumberOrRange
        			    {
        			    	Match(input,COMMA,FOLLOW_COMMA_in_synpred105_Blaise5182); if (state.failed) return ;
        			    	PushFollow(FOLLOW_signedNumberOrRange_in_synpred105_Blaise5184);
        			    	signedNumberOrRange();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop130;
        	    }
        	} while (true);

        	loop130:
        		;	// Stops C# compiler whining that label 'loop130' has no statements

        	Match(input,RBRACK,FOLLOW_RBRACK_in_synpred105_Blaise5189); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred105_Blaise"

    // $ANTLR start "synpred113_Blaise"
    public void synpred113_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:864:12: ( PLUS | MINUS )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:
        {
        	if ( (input.LA(1) >= PLUS && input.LA(1) <= MINUS) ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred113_Blaise"

    // $ANTLR start "synpred125_Blaise"
    public void synpred125_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:889:7: ( askOrVarOrFunctionDesignator )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:889:7: askOrVarOrFunctionDesignator
        {
        	PushFollow(FOLLOW_askOrVarOrFunctionDesignator_in_synpred125_Blaise5493);
        	askOrVarOrFunctionDesignator();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred125_Blaise"

    // $ANTLR start "synpred128_Blaise"
    public void synpred128_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:902:29: ( LPAREN parameterList RPAREN )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:902:29: LPAREN parameterList RPAREN
        {
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred128_Blaise5580); if (state.failed) return ;
        	PushFollow(FOLLOW_parameterList_in_synpred128_Blaise5583);
        	parameterList();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred128_Blaise5585); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred128_Blaise"

    // $ANTLR start "synpred129_Blaise"
    public void synpred129_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:917:24: ( LPAREN parameterList RPAREN )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:917:24: LPAREN parameterList RPAREN
        {
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred129_Blaise5624); if (state.failed) return ;
        	PushFollow(FOLLOW_parameterList_in_synpred129_Blaise5627);
        	parameterList();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred129_Blaise5629); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred129_Blaise"

    // $ANTLR start "synpred130_Blaise"
    public void synpred130_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:917:3: ( variable DOT KEEP ( LPAREN parameterList RPAREN )? )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:917:3: variable DOT KEEP ( LPAREN parameterList RPAREN )?
        {
        	PushFollow(FOLLOW_variable_in_synpred130_Blaise5615);
        	variable();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,DOT,FOLLOW_DOT_in_synpred130_Blaise5617); if (state.failed) return ;
        	Match(input,KEEP,FOLLOW_KEEP_in_synpred130_Blaise5620); if (state.failed) return ;
        	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:917:23: ( LPAREN parameterList RPAREN )?
        	int alt135 = 2;
        	int LA135_0 = input.LA(1);

        	if ( (LA135_0 == LPAREN) )
        	{
        	    alt135 = 1;
        	}
        	switch (alt135) 
        	{
        	    case 1 :
        	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:917:24: LPAREN parameterList RPAREN
        	        {
        	        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred130_Blaise5624); if (state.failed) return ;
        	        	PushFollow(FOLLOW_parameterList_in_synpred130_Blaise5627);
        	        	parameterList();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;
        	        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred130_Blaise5629); if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred130_Blaise"

    // $ANTLR start "synpred131_Blaise"
    public void synpred131_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:918:24: ( LPAREN parameterList RPAREN )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:918:24: LPAREN parameterList RPAREN
        {
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred131_Blaise5646); if (state.failed) return ;
        	PushFollow(FOLLOW_parameterList_in_synpred131_Blaise5649);
        	parameterList();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred131_Blaise5651); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred131_Blaise"

    // $ANTLR start "synpred132_Blaise"
    public void synpred132_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:918:4: ( variable DOT ASK ( LPAREN parameterList RPAREN )? )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:918:4: variable DOT ASK ( LPAREN parameterList RPAREN )?
        {
        	PushFollow(FOLLOW_variable_in_synpred132_Blaise5637);
        	variable();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,DOT,FOLLOW_DOT_in_synpred132_Blaise5639); if (state.failed) return ;
        	Match(input,ASK,FOLLOW_ASK_in_synpred132_Blaise5642); if (state.failed) return ;
        	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:918:23: ( LPAREN parameterList RPAREN )?
        	int alt136 = 2;
        	int LA136_0 = input.LA(1);

        	if ( (LA136_0 == LPAREN) )
        	{
        	    alt136 = 1;
        	}
        	switch (alt136) 
        	{
        	    case 1 :
        	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:918:24: LPAREN parameterList RPAREN
        	        {
        	        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred132_Blaise5646); if (state.failed) return ;
        	        	PushFollow(FOLLOW_parameterList_in_synpred132_Blaise5649);
        	        	parameterList();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;
        	        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred132_Blaise5651); if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred132_Blaise"

    // $ANTLR start "synpred133_Blaise"
    public void synpred133_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:919:25: ( LPAREN parameterList RPAREN )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:919:25: LPAREN parameterList RPAREN
        {
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred133_Blaise5669); if (state.failed) return ;
        	PushFollow(FOLLOW_parameterList_in_synpred133_Blaise5672);
        	parameterList();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred133_Blaise5674); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred133_Blaise"

    // $ANTLR start "synpred134_Blaise"
    public void synpred134_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:919:4: ( variable DOT SHOW ( LPAREN parameterList RPAREN )? )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:919:4: variable DOT SHOW ( LPAREN parameterList RPAREN )?
        {
        	PushFollow(FOLLOW_variable_in_synpred134_Blaise5660);
        	variable();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,DOT,FOLLOW_DOT_in_synpred134_Blaise5662); if (state.failed) return ;
        	Match(input,SHOW,FOLLOW_SHOW_in_synpred134_Blaise5665); if (state.failed) return ;
        	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:919:24: ( LPAREN parameterList RPAREN )?
        	int alt137 = 2;
        	int LA137_0 = input.LA(1);

        	if ( (LA137_0 == LPAREN) )
        	{
        	    alt137 = 1;
        	}
        	switch (alt137) 
        	{
        	    case 1 :
        	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:919:25: LPAREN parameterList RPAREN
        	        {
        	        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred134_Blaise5669); if (state.failed) return ;
        	        	PushFollow(FOLLOW_parameterList_in_synpred134_Blaise5672);
        	        	parameterList();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;
        	        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred134_Blaise5674); if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred134_Blaise"

    // $ANTLR start "synpred135_Blaise"
    public void synpred135_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:27: ( LPAREN lookupParameterList RPAREN )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:27: LPAREN lookupParameterList RPAREN
        {
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred135_Blaise5691); if (state.failed) return ;
        	PushFollow(FOLLOW_lookupParameterList_in_synpred135_Blaise5693);
        	lookupParameterList();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred135_Blaise5695); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred135_Blaise"

    // $ANTLR start "synpred137_Blaise"
    public void synpred137_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:4: ( variable DOT LOOKUP ( LPAREN lookupParameterList RPAREN )? ( DOT ID )? )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:4: variable DOT LOOKUP ( LPAREN lookupParameterList RPAREN )? ( DOT ID )?
        {
        	PushFollow(FOLLOW_variable_in_synpred137_Blaise5682);
        	variable();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,DOT,FOLLOW_DOT_in_synpred137_Blaise5684); if (state.failed) return ;
        	Match(input,LOOKUP,FOLLOW_LOOKUP_in_synpred137_Blaise5687); if (state.failed) return ;
        	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:26: ( LPAREN lookupParameterList RPAREN )?
        	int alt138 = 2;
        	int LA138_0 = input.LA(1);

        	if ( (LA138_0 == LPAREN) )
        	{
        	    alt138 = 1;
        	}
        	switch (alt138) 
        	{
        	    case 1 :
        	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:27: LPAREN lookupParameterList RPAREN
        	        {
        	        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred137_Blaise5691); if (state.failed) return ;
        	        	PushFollow(FOLLOW_lookupParameterList_in_synpred137_Blaise5693);
        	        	lookupParameterList();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;
        	        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred137_Blaise5695); if (state.failed) return ;

        	        }
        	        break;

        	}

        	// C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:63: ( DOT ID )?
        	int alt139 = 2;
        	int LA139_0 = input.LA(1);

        	if ( (LA139_0 == DOT) )
        	{
        	    alt139 = 1;
        	}
        	switch (alt139) 
        	{
        	    case 1 :
        	        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:920:64: DOT ID
        	        {
        	        	Match(input,DOT,FOLLOW_DOT_in_synpred137_Blaise5700); if (state.failed) return ;
        	        	Match(input,ID,FOLLOW_ID_in_synpred137_Blaise5702); if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred137_Blaise"

    // $ANTLR start "synpred138_Blaise"
    public void synpred138_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:921:4: ( variable DOT CLASSIFY )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:921:4: variable DOT CLASSIFY
        {
        	PushFollow(FOLLOW_variable_in_synpred138_Blaise5709);
        	variable();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,DOT,FOLLOW_DOT_in_synpred138_Blaise5711); if (state.failed) return ;
        	Match(input,CLASSIFY,FOLLOW_CLASSIFY_in_synpred138_Blaise5714); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred138_Blaise"

    // $ANTLR start "synpred139_Blaise"
    public void synpred139_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:922:16: ( LPAREN parameterList RPAREN )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:922:16: LPAREN parameterList RPAREN
        {
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred139_Blaise5725); if (state.failed) return ;
        	PushFollow(FOLLOW_parameterList_in_synpred139_Blaise5728);
        	parameterList();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred139_Blaise5730); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred139_Blaise"

    // $ANTLR start "synpred144_Blaise"
    public void synpred144_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:956:4: ( ID ASSIGN LPAREN ID RPAREN )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:956:4: ID ASSIGN LPAREN ID RPAREN
        {
        	Match(input,ID,FOLLOW_ID_in_synpred144_Blaise5843); if (state.failed) return ;
        	Match(input,ASSIGN,FOLLOW_ASSIGN_in_synpred144_Blaise5845); if (state.failed) return ;
        	Match(input,LPAREN,FOLLOW_LPAREN_in_synpred144_Blaise5847); if (state.failed) return ;
        	Match(input,ID,FOLLOW_ID_in_synpred144_Blaise5849); if (state.failed) return ;
        	Match(input,RPAREN,FOLLOW_RPAREN_in_synpred144_Blaise5851); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred144_Blaise"

    // $ANTLR start "synpred164_Blaise"
    public void synpred164_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:16: ( id_list )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:16: id_list
        {
        	PushFollow(FOLLOW_id_list_in_synpred164_Blaise6481);
        	id_list();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred164_Blaise"

    // $ANTLR start "synpred165_Blaise"
    public void synpred165_Blaise_fragment() {
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:26: ( var_list )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:26: var_list
        {
        	PushFollow(FOLLOW_var_list_in_synpred165_Blaise6485);
        	var_list();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred165_Blaise"

    // $ANTLR start "synpred167_Blaise"
    public void synpred167_Blaise_fragment() {
        IList list_b = null;
        BlaiseParser.statement_return b = default(BlaiseParser.statement_return);
         b = null;
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:66: (b+= statement )
        // C:\\Users\\jeremy\\svn\\algenta\\Algenta.Data.Parsing.Blaise\\Blaise.g:1067:66: b+= statement
        {
        	PushFollow(FOLLOW_statement_in_synpred167_Blaise6500);
        	b = statement();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	if (list_b == null) list_b = new ArrayList();
        	list_b.Add(b);


        }
    }
    // $ANTLR end "synpred167_Blaise"

    // Delegated rules

   	public bool synpred137_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred137_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred84_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred84_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred131_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred131_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred135_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred135_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred103_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred103_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred165_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred165_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred113_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred113_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred138_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred138_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred41_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred41_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred105_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred105_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred134_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred134_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred125_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred125_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred139_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred139_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred144_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred144_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred167_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred167_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred129_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred129_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred83_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred83_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred132_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred132_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred130_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred130_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred164_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred164_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred82_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred82_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred81_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred81_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred133_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred133_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred128_Blaise() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred128_Blaise_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA5 dfa5;
   	protected DFA9 dfa9;
   	protected DFA44 dfa44;
   	protected DFA45 dfa45;
   	protected DFA59 dfa59;
   	protected DFA62 dfa62;
   	protected DFA67 dfa67;
   	protected DFA69 dfa69;
   	protected DFA70 dfa70;
   	protected DFA71 dfa71;
   	protected DFA72 dfa72;
   	protected DFA73 dfa73;
   	protected DFA75 dfa75;
   	protected DFA79 dfa79;
   	protected DFA98 dfa98;
   	protected DFA124 dfa124;
	private void InitializeCyclicDFAs()
	{
    	this.dfa5 = new DFA5(this);
    	this.dfa9 = new DFA9(this);
    	this.dfa44 = new DFA44(this);
    	this.dfa45 = new DFA45(this);
    	this.dfa59 = new DFA59(this);
    	this.dfa62 = new DFA62(this);
    	this.dfa67 = new DFA67(this);
    	this.dfa69 = new DFA69(this);
    	this.dfa70 = new DFA70(this);
    	this.dfa71 = new DFA71(this);
    	this.dfa72 = new DFA72(this);
    	this.dfa73 = new DFA73(this);
    	this.dfa75 = new DFA75(this);
    	this.dfa79 = new DFA79(this);
    	this.dfa98 = new DFA98(this);
    	this.dfa124 = new DFA124(this);
	    this.dfa44.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA44_SpecialStateTransition);
	    this.dfa45.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA45_SpecialStateTransition);
	    this.dfa59.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA59_SpecialStateTransition);
	    this.dfa62.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA62_SpecialStateTransition);
	    this.dfa67.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA67_SpecialStateTransition);
	    this.dfa69.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA69_SpecialStateTransition);
	    this.dfa70.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA70_SpecialStateTransition);
	    this.dfa71.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA71_SpecialStateTransition);
	    this.dfa72.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA72_SpecialStateTransition);
	    this.dfa73.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA73_SpecialStateTransition);
	    this.dfa75.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA75_SpecialStateTransition);
	    this.dfa79.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA79_SpecialStateTransition);
	    this.dfa98.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA98_SpecialStateTransition);
	}

    const string DFA5_eotS =
        "\x0f\uffff";
    const string DFA5_eofS =
        "\x07\uffff\x01\x0a\x04\uffff\x01\x0e\x02\uffff";
    const string DFA5_minS =
        "\x01\u00bb\x01\u00d1\x01\u00cd\x01\u00d1\x01\u00bb\x01\u00cd\x01"+
        "\u00d1\x01\x58\x01\u00bb\x02\uffff\x01\u00d1\x01\x58\x02\uffff";
    const string DFA5_maxS =
        "\x02\u00d1\x01\u00ce\x02\u00d1\x01\u00cd\x01\u00d1\x01\u00d5\x01"+
        "\u00d1\x02\uffff\x01\u00d1\x01\u00d5\x02\uffff";
    const string DFA5_acceptS =
        "\x09\uffff\x01\x02\x01\x04\x02\uffff\x01\x01\x01\x03";
    const string DFA5_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x01\x01\x15\uffff\x01\x02",
            "\x01\x02",
            "\x01\x04\x01\x03",
            "\x01\x05",
            "\x01\x06\x15\uffff\x01\x07",
            "\x01\x08",
            "\x01\x07",
            "\x01\x0a\x03\uffff\x05\x0a\x05\uffff\x01\x0a\x01\uffff\x02"+
            "\x0a\x0a\uffff\x08\x0a\x04\uffff\x0c\x0a\x01\uffff\x01\x0a\x19"+
            "\uffff\x04\x0a\x14\uffff\x03\x0a\x09\uffff\x01\x0a\x02\uffff"+
            "\x01\x09\x06\uffff\x01\x0a",
            "\x01\x0b\x15\uffff\x01\x0c",
            "",
            "",
            "\x01\x0c",
            "\x01\x0e\x03\uffff\x05\x0e\x05\uffff\x01\x0e\x01\uffff\x02"+
            "\x0e\x0a\uffff\x08\x0e\x04\uffff\x0c\x0e\x01\uffff\x01\x0e\x19"+
            "\uffff\x04\x0e\x14\uffff\x03\x0e\x09\uffff\x01\x0e\x02\uffff"+
            "\x01\x0d\x06\uffff\x01\x0e",
            "",
            ""
    };

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "591:1: realrange : (a= signedReal DOTDOT b= signedReal -> ^( REALRANGE $a $b) | c= signedInteger DOTDOT d= signedReal -> ^( REALRANGE $c $d) | e= signedReal DOTDOT f= signedInteger -> ^( REALRANGE $e $f) | g= signedInteger DOTDOT h= signedInteger -> ^( INTRANGE $g $h) );"; }
        }

    }

    const string DFA9_eotS =
        "\x0e\uffff";
    const string DFA9_eofS =
        "\x01\x01\x0d\uffff";
    const string DFA9_minS =
        "\x01\x58\x01\uffff\x01\x66\x0b\uffff";
    const string DFA9_maxS =
        "\x01\u00aa\x01\uffff\x01\x68\x0b\uffff";
    const string DFA9_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01"+
        "\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b";
    const string DFA9_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x01\x01\x03\uffff\x02\x01\x01\uffff\x01\x04\x01\x01\x05\uffff"+
            "\x01\x05\x01\uffff\x01\x03\x01\x02\x0a\uffff\x01\x06\x01\x07"+
            "\x01\x08\x03\uffff\x01\x0b\x01\x0a\x0e\uffff\x01\x0c\x02\uffff"+
            "\x01\x01\x19\uffff\x01\x09\x02\x0d\x01\x01",
            "",
            "\x01\x05\x01\uffff\x01\x03",
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
            get { return "()* loopback of 610:11: ( block | procedure | table | parameters | externals | libraries | type | fields | auxfields | routerAlien | locals )*"; }
        }

    }

    const string DFA44_eotS =
        "\x16\uffff";
    const string DFA44_eofS =
        "\x16\uffff";
    const string DFA44_minS =
        "\x01\x38\x06\uffff\x01\x00\x0e\uffff";
    const string DFA44_maxS =
        "\x01\u00d5\x06\uffff\x01\x00\x0e\uffff";
    const string DFA44_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\uffff\x01\x09\x0b\uffff\x01\x07\x01\x08";
    const string DFA44_specialS =
        "\x07\uffff\x01\x00\x0e\uffff}>";
    static readonly string[] DFA44_transitionS = {
            "\x01\x08\x1d\uffff\x01\x04\x0c\uffff\x01\x08\x06\uffff\x01"+
            "\x03\x01\x02\x06\uffff\x02\x06\x09\uffff\x02\x08\x01\uffff\x0a"+
            "\x08\x16\uffff\x03\x04\x03\uffff\x01\x05\x06\uffff\x01\x01\x01"+
            "\uffff\x01\x08\x06\uffff\x01\x08\x01\uffff\x04\x08\x0c\uffff"+
            "\x01\x08\x08\uffff\x01\x08\x02\uffff\x01\x08\x01\x07",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
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
            "",
            "",
            ""
    };

    static readonly short[] DFA44_eot = DFA.UnpackEncodedString(DFA44_eotS);
    static readonly short[] DFA44_eof = DFA.UnpackEncodedString(DFA44_eofS);
    static readonly char[] DFA44_min = DFA.UnpackEncodedStringToUnsignedChars(DFA44_minS);
    static readonly char[] DFA44_max = DFA.UnpackEncodedStringToUnsignedChars(DFA44_maxS);
    static readonly short[] DFA44_accept = DFA.UnpackEncodedString(DFA44_acceptS);
    static readonly short[] DFA44_special = DFA.UnpackEncodedString(DFA44_specialS);
    static readonly short[][] DFA44_transition = DFA.UnpackEncodedStringArray(DFA44_transitionS);

    protected class DFA44 : DFA
    {
        public DFA44(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 44;
            this.eot = DFA44_eot;
            this.eof = DFA44_eof;
            this.min = DFA44_min;
            this.max = DFA44_max;
            this.accept = DFA44_accept;
            this.special = DFA44_special;
            this.transition = DFA44_transition;

        }

        override public string Description
        {
            get { return "740:1: statement : ( ifblock | whiledoblock | fordoblock | ruleslayoutstyle | RESERVECHECK | ( SIGNAL | CHECK ) | ( ID ASSIGN )=> assignment | ( variable ASSIGN )=> assignment | ask_or_check );"; }
        }

    }


    protected internal int DFA44_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA44_7 = input.LA(1);

                   	 
                   	int index44_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred81_Blaise()) ) { s = 20; }

                   	else if ( (synpred82_Blaise()) ) { s = 21; }

                   	else if ( (true) ) { s = 8; }

                   	 
                   	input.Seek(index44_7);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae44 =
            new NoViableAltException(dfa.Description, 44, _s, input);
        dfa.Error(nvae44);
        throw nvae44;
    }
    const string DFA45_eotS =
        "\x10\uffff";
    const string DFA45_eofS =
        "\x10\uffff";
    const string DFA45_minS =
        "\x01\x38\x0d\x00\x02\uffff";
    const string DFA45_maxS =
        "\x01\u00d5\x0d\x00\x02\uffff";
    const string DFA45_acceptS =
        "\x0e\uffff\x01\x01\x01\x02";
    const string DFA45_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x02\uffff}>";
    static readonly string[] DFA45_transitionS = {
            "\x01\x0a\x2a\uffff\x01\x01\x19\uffff\x02\x01\x01\uffff\x0a"+
            "\x0d\x25\uffff\x01\x04\x06\uffff\x01\x09\x01\uffff\x01\x05\x01"+
            "\x06\x01\x02\x01\x03\x0c\uffff\x01\x07\x08\uffff\x01\x08\x02"+
            "\uffff\x01\x0b\x01\x0c",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA45_eot = DFA.UnpackEncodedString(DFA45_eotS);
    static readonly short[] DFA45_eof = DFA.UnpackEncodedString(DFA45_eofS);
    static readonly char[] DFA45_min = DFA.UnpackEncodedStringToUnsignedChars(DFA45_minS);
    static readonly char[] DFA45_max = DFA.UnpackEncodedStringToUnsignedChars(DFA45_maxS);
    static readonly short[] DFA45_accept = DFA.UnpackEncodedString(DFA45_acceptS);
    static readonly short[] DFA45_special = DFA.UnpackEncodedString(DFA45_specialS);
    static readonly short[][] DFA45_transition = DFA.UnpackEncodedStringArray(DFA45_transitionS);

    protected class DFA45 : DFA
    {
        public DFA45(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 45;
            this.eot = DFA45_eot;
            this.eof = DFA45_eof;
            this.min = DFA45_min;
            this.max = DFA45_max;
            this.accept = DFA45_accept;
            this.special = DFA45_special;
            this.transition = DFA45_transition;

        }

        override public string Description
        {
            get { return "757:1: ask_or_check : ( ( expression QSTRING )=> expression a= QSTRING | expression );"; }
        }

    }


    protected internal int DFA45_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA45_1 = input.LA(1);

                   	 
                   	int index45_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA45_2 = input.LA(1);

                   	 
                   	int index45_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA45_3 = input.LA(1);

                   	 
                   	int index45_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA45_4 = input.LA(1);

                   	 
                   	int index45_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA45_5 = input.LA(1);

                   	 
                   	int index45_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA45_6 = input.LA(1);

                   	 
                   	int index45_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA45_7 = input.LA(1);

                   	 
                   	int index45_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA45_8 = input.LA(1);

                   	 
                   	int index45_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA45_9 = input.LA(1);

                   	 
                   	int index45_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA45_10 = input.LA(1);

                   	 
                   	int index45_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA45_11 = input.LA(1);

                   	 
                   	int index45_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA45_12 = input.LA(1);

                   	 
                   	int index45_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA45_13 = input.LA(1);

                   	 
                   	int index45_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred83_Blaise()) ) { s = 14; }

                   	else if ( (true) ) { s = 15; }

                   	 
                   	input.Seek(index45_13);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae45 =
            new NoViableAltException(dfa.Description, 45, _s, input);
        dfa.Error(nvae45);
        throw nvae45;
    }
    const string DFA59_eotS =
        "\x25\uffff";
    const string DFA59_eofS =
        "\x25\uffff";
    const string DFA59_minS =
        "\x01\u00ca\x01\x38\x03\uffff\x01\u00d1\x01\u00bf\x01\u00d1\x01"+
        "\u00bb\x01\uffff\x01\u00bf\x01\u00d1\x01\u00bf\x01\u00bb\x01\u00d1"+
        "\x01\u00bb\x01\x00\x01\u00d1\x02\u00bf\x01\u00d1\x01\u00bf\x01\uffff"+
        "\x02\u00d1\x01\u00bb\x02\u00bf\x01\u00d1\x01\u00bf\x01\u00bb\x02"+
        "\u00d1\x02\u00bf\x01\u00d1\x01\u00bf";
    const string DFA59_maxS =
        "\x02\u00d5\x03\uffff\x01\u00d1\x01\u00ce\x02\u00d1\x01\uffff\x01"+
        "\u00cd\x01\u00d1\x01\u00ce\x03\u00d1\x01\x00\x01\u00d1\x01\u00ce"+
        "\x01\u00cb\x01\u00d1\x01\u00ce\x01\uffff\x03\u00d1\x01\u00cb\x01"+
        "\u00cd\x01\u00d1\x01\u00ce\x03\u00d1\x01\u00ce\x01\u00cb\x01\u00d1"+
        "\x01\u00cb";
    const string DFA59_acceptS =
        "\x02\uffff\x01\x05\x01\x04\x01\x03\x04\uffff\x01\x02\x0c\uffff"+
        "\x01\x01\x0e\uffff";
    const string DFA59_specialS =
        "\x10\uffff\x01\x00\x14\uffff}>";
    static readonly string[] DFA59_transitionS = {
            "\x01\x01\x0a\uffff\x01\x02",
            "\x01\x04\x7d\uffff\x01\x04\x04\uffff\x01\x05\x15\uffff\x01"+
            "\x06\x02\uffff\x01\x04\x01\x03",
            "",
            "",
            "",
            "\x01\x06",
            "\x01\x09\x0b\uffff\x01\x09\x01\uffff\x01\x08\x01\x07",
            "\x01\x0a",
            "\x01\x0b\x15\uffff\x01\x0c",
            "",
            "\x01\x09\x0b\uffff\x01\x09\x01\uffff\x01\x0d",
            "\x01\x0c",
            "\x01\x0f\x0b\uffff\x01\x10\x02\uffff\x01\x0e",
            "\x01\x11\x15\uffff\x01\x12",
            "\x01\x13",
            "\x01\x14\x15\uffff\x01\x15",
            "\x01\uffff",
            "\x01\x12",
            "\x01\x0f\x0b\uffff\x01\x10\x02\uffff\x01\x17",
            "\x01\x0f\x0b\uffff\x01\x10",
            "\x01\x15",
            "\x01\x09\x0b\uffff\x01\x09\x01\uffff\x01\x19\x01\x18",
            "",
            "\x01\x1a",
            "\x01\x1b",
            "\x01\x1c\x15\uffff\x01\x1d",
            "\x01\x0f\x0b\uffff\x01\x10",
            "\x01\x09\x0b\uffff\x01\x09\x01\uffff\x01\x1e",
            "\x01\x1d",
            "\x01\x0f\x0b\uffff\x01\x10\x02\uffff\x01\x1f",
            "\x01\x20\x15\uffff\x01\x21",
            "\x01\x22",
            "\x01\x21",
            "\x01\x0f\x0b\uffff\x01\x10\x02\uffff\x01\x23",
            "\x01\x0f\x0b\uffff\x01\x10",
            "\x01\x24",
            "\x01\x0f\x0b\uffff\x01\x10"
    };

    static readonly short[] DFA59_eot = DFA.UnpackEncodedString(DFA59_eotS);
    static readonly short[] DFA59_eof = DFA.UnpackEncodedString(DFA59_eofS);
    static readonly char[] DFA59_min = DFA.UnpackEncodedStringToUnsignedChars(DFA59_minS);
    static readonly char[] DFA59_max = DFA.UnpackEncodedStringToUnsignedChars(DFA59_maxS);
    static readonly short[] DFA59_accept = DFA.UnpackEncodedString(DFA59_acceptS);
    static readonly short[] DFA59_special = DFA.UnpackEncodedString(DFA59_specialS);
    static readonly short[][] DFA59_transition = DFA.UnpackEncodedStringArray(DFA59_transitionS);

    protected class DFA59 : DFA
    {
        public DFA59(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 59;
            this.eot = DFA59_eot;
            this.eof = DFA59_eof;
            this.min = DFA59_min;
            this.max = DFA59_max;
            this.accept = DFA59_accept;
            this.special = DFA59_special;
            this.transition = DFA59_transition;

        }

        override public string Description
        {
            get { return "844:1: rightofin : ( '[' realrange ( ',' realrange )* ']' | '[' signedNumberOrRange ( ',' signedNumberOrRange )* ']' | '[' constantChr ( ',' constantChr )* ']' | '[' idOrIdRange ( ',' idOrIdRange )* ']' | variable );"; }
        }

    }


    protected internal int DFA59_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA59_16 = input.LA(1);

                   	 
                   	int index59_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred103_Blaise()) ) { s = 22; }

                   	else if ( (synpred105_Blaise()) ) { s = 9; }

                   	 
                   	input.Seek(index59_16);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae59 =
            new NoViableAltException(dfa.Description, 59, _s, input);
        dfa.Error(nvae59);
        throw nvae59;
    }
    const string DFA62_eotS =
        "\x33\uffff";
    const string DFA62_eofS =
        "\x01\x01\x32\uffff";
    const string DFA62_minS =
        "\x01\x38\x11\uffff\x02\x00\x1f\uffff";
    const string DFA62_maxS =
        "\x01\u00d5\x11\uffff\x02\x00\x1f\uffff";
    const string DFA62_acceptS =
        "\x01\uffff\x01\x02\x30\uffff\x01\x01";
    const string DFA62_specialS =
        "\x12\uffff\x01\x00\x01\x01\x1f\uffff}>";
    static readonly string[] DFA62_transitionS = {
            "\x01\x01\x1d\uffff\x01\x01\x01\uffff\x07\x01\x01\uffff\x04"+
            "\x01\x01\uffff\x01\x01\x01\uffff\x01\x01\x02\uffff\x02\x01\x06"+
            "\uffff\x02\x01\x09\uffff\x02\x01\x01\uffff\x0a\x01\x03\uffff"+
            "\x01\x01\x08\uffff\x01\x01\x09\uffff\x03\x01\x03\uffff\x01\x01"+
            "\x03\uffff\x02\x01\x01\uffff\x03\x01\x02\uffff\x02\x01\x02\uffff"+
            "\x04\x01\x01\x12\x01\x13\x03\uffff\x02\x01\x01\uffff\x08\x01"+
            "\x01\uffff\x01\x01\x05\uffff\x01\x01\x02\uffff\x02\x01",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA62_eot = DFA.UnpackEncodedString(DFA62_eotS);
    static readonly short[] DFA62_eof = DFA.UnpackEncodedString(DFA62_eofS);
    static readonly char[] DFA62_min = DFA.UnpackEncodedStringToUnsignedChars(DFA62_minS);
    static readonly char[] DFA62_max = DFA.UnpackEncodedStringToUnsignedChars(DFA62_maxS);
    static readonly short[] DFA62_accept = DFA.UnpackEncodedString(DFA62_acceptS);
    static readonly short[] DFA62_special = DFA.UnpackEncodedString(DFA62_specialS);
    static readonly short[][] DFA62_transition = DFA.UnpackEncodedStringArray(DFA62_transitionS);

    protected class DFA62 : DFA
    {
        public DFA62(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 62;
            this.eot = DFA62_eot;
            this.eof = DFA62_eof;
            this.min = DFA62_min;
            this.max = DFA62_max;
            this.accept = DFA62_accept;
            this.special = DFA62_special;
            this.transition = DFA62_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 864:10: ( ( PLUS | MINUS )=> ( PLUS | MINUS ) term )*"; }
        }

    }


    protected internal int DFA62_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA62_18 = input.LA(1);

                   	 
                   	int index62_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred113_Blaise()) ) { s = 50; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index62_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA62_19 = input.LA(1);

                   	 
                   	int index62_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred113_Blaise()) ) { s = 50; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index62_19);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae62 =
            new NoViableAltException(dfa.Description, 62, _s, input);
        dfa.Error(nvae62);
        throw nvae62;
    }
    const string DFA67_eotS =
        "\x0c\uffff";
    const string DFA67_eofS =
        "\x0c\uffff";
    const string DFA67_minS =
        "\x01\x38\x08\uffff\x01\x00\x02\uffff";
    const string DFA67_maxS =
        "\x01\u00d5\x08\uffff\x01\x00\x02\uffff";
    const string DFA67_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\uffff\x01\x03\x01\x04\x04\uffff"+
        "\x01\x05\x01\x06";
    const string DFA67_specialS =
        "\x09\uffff\x01\x00\x02\uffff}>";
    static readonly string[] DFA67_transitionS = {
            "\x01\x05\x76\uffff\x01\x01\x06\uffff\x01\x05\x01\uffff\x02"+
            "\x02\x0e\uffff\x01\x04\x08\uffff\x01\x05\x02\uffff\x01\x05\x01"+
            "\x09",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA67_eot = DFA.UnpackEncodedString(DFA67_eotS);
    static readonly short[] DFA67_eof = DFA.UnpackEncodedString(DFA67_eofS);
    static readonly char[] DFA67_min = DFA.UnpackEncodedStringToUnsignedChars(DFA67_minS);
    static readonly char[] DFA67_max = DFA.UnpackEncodedStringToUnsignedChars(DFA67_maxS);
    static readonly short[] DFA67_accept = DFA.UnpackEncodedString(DFA67_acceptS);
    static readonly short[] DFA67_special = DFA.UnpackEncodedString(DFA67_specialS);
    static readonly short[][] DFA67_transition = DFA.UnpackEncodedStringArray(DFA67_transitionS);

    protected class DFA67 : DFA
    {
        public DFA67(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 67;
            this.eot = DFA67_eot;
            this.eof = DFA67_eof;
            this.min = DFA67_min;
            this.max = DFA67_max;
            this.accept = DFA67_accept;
            this.special = DFA67_special;
            this.transition = DFA67_transition;

        }

        override public string Description
        {
            get { return "878:1: factor : ( NOT factor | builtinfuction | LPAREN expression ( ',' expression )* RPAREN -> ^( PARAMETERS_OR_EXPRESSION ( expression )* ) | unsignedConstant | askOrVarOrFunctionDesignator | search );"; }
        }

    }


    protected internal int DFA67_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA67_9 = input.LA(1);

                   	 
                   	int index67_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred125_Blaise()) ) { s = 10; }

                   	else if ( (true) ) { s = 11; }

                   	 
                   	input.Seek(index67_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae67 =
            new NoViableAltException(dfa.Description, 67, _s, input);
        dfa.Error(nvae67);
        throw nvae67;
    }
    const string DFA69_eotS =
        "\x37\uffff";
    const string DFA69_eofS =
        "\x01\x02\x36\uffff";
    const string DFA69_minS =
        "\x01\x38\x01\x00\x35\uffff";
    const string DFA69_maxS =
        "\x01\u00d5\x01\x00\x35\uffff";
    const string DFA69_acceptS =
        "\x02\uffff\x01\x02\x33\uffff\x01\x01";
    const string DFA69_specialS =
        "\x01\uffff\x01\x00\x35\uffff}>";
    static readonly string[] DFA69_transitionS = {
            "\x01\x02\x1d\uffff\x01\x02\x01\uffff\x07\x02\x01\uffff\x04"+
            "\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x02\uffff\x02\x02\x06"+
            "\uffff\x02\x02\x09\uffff\x02\x02\x01\uffff\x0a\x02\x03\uffff"+
            "\x01\x02\x08\uffff\x01\x02\x09\uffff\x03\x02\x03\uffff\x01\x02"+
            "\x03\uffff\x02\x02\x01\uffff\x07\x02\x02\uffff\x08\x02\x01\uffff"+
            "\x02\x02\x01\uffff\x06\x02\x01\x01\x01\x02\x01\uffff\x01\x02"+
            "\x05\uffff\x01\x02\x02\uffff\x02\x02",
            "\x01\uffff",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA69_eot = DFA.UnpackEncodedString(DFA69_eotS);
    static readonly short[] DFA69_eof = DFA.UnpackEncodedString(DFA69_eofS);
    static readonly char[] DFA69_min = DFA.UnpackEncodedStringToUnsignedChars(DFA69_minS);
    static readonly char[] DFA69_max = DFA.UnpackEncodedStringToUnsignedChars(DFA69_maxS);
    static readonly short[] DFA69_accept = DFA.UnpackEncodedString(DFA69_acceptS);
    static readonly short[] DFA69_special = DFA.UnpackEncodedString(DFA69_specialS);
    static readonly short[][] DFA69_transition = DFA.UnpackEncodedStringArray(DFA69_transitionS);

    protected class DFA69 : DFA
    {
        public DFA69(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 69;
            this.eot = DFA69_eot;
            this.eof = DFA69_eof;
            this.min = DFA69_min;
            this.max = DFA69_max;
            this.accept = DFA69_accept;
            this.special = DFA69_special;
            this.transition = DFA69_transition;

        }

        override public string Description
        {
            get { return "902:28: ( LPAREN parameterList RPAREN )?"; }
        }

    }


    protected internal int DFA69_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA69_1 = input.LA(1);

                   	 
                   	int index69_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred128_Blaise()) ) { s = 54; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index69_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae69 =
            new NoViableAltException(dfa.Description, 69, _s, input);
        dfa.Error(nvae69);
        throw nvae69;
    }
    const string DFA70_eotS =
        "\x37\uffff";
    const string DFA70_eofS =
        "\x01\x02\x36\uffff";
    const string DFA70_minS =
        "\x01\x38\x01\x00\x35\uffff";
    const string DFA70_maxS =
        "\x01\u00d5\x01\x00\x35\uffff";
    const string DFA70_acceptS =
        "\x02\uffff\x01\x02\x33\uffff\x01\x01";
    const string DFA70_specialS =
        "\x01\uffff\x01\x00\x35\uffff}>";
    static readonly string[] DFA70_transitionS = {
            "\x01\x02\x1d\uffff\x01\x02\x01\uffff\x07\x02\x01\uffff\x04"+
            "\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x02\uffff\x02\x02\x06"+
            "\uffff\x02\x02\x09\uffff\x02\x02\x01\uffff\x0a\x02\x03\uffff"+
            "\x01\x02\x08\uffff\x01\x02\x09\uffff\x03\x02\x03\uffff\x01\x02"+
            "\x03\uffff\x02\x02\x01\uffff\x07\x02\x02\uffff\x08\x02\x01\uffff"+
            "\x02\x02\x01\uffff\x06\x02\x01\x01\x01\x02\x01\uffff\x01\x02"+
            "\x05\uffff\x01\x02\x02\uffff\x02\x02",
            "\x01\uffff",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA70_eot = DFA.UnpackEncodedString(DFA70_eotS);
    static readonly short[] DFA70_eof = DFA.UnpackEncodedString(DFA70_eofS);
    static readonly char[] DFA70_min = DFA.UnpackEncodedStringToUnsignedChars(DFA70_minS);
    static readonly char[] DFA70_max = DFA.UnpackEncodedStringToUnsignedChars(DFA70_maxS);
    static readonly short[] DFA70_accept = DFA.UnpackEncodedString(DFA70_acceptS);
    static readonly short[] DFA70_special = DFA.UnpackEncodedString(DFA70_specialS);
    static readonly short[][] DFA70_transition = DFA.UnpackEncodedStringArray(DFA70_transitionS);

    protected class DFA70 : DFA
    {
        public DFA70(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 70;
            this.eot = DFA70_eot;
            this.eof = DFA70_eof;
            this.min = DFA70_min;
            this.max = DFA70_max;
            this.accept = DFA70_accept;
            this.special = DFA70_special;
            this.transition = DFA70_transition;

        }

        override public string Description
        {
            get { return "917:23: ( LPAREN parameterList RPAREN )?"; }
        }

    }


    protected internal int DFA70_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA70_1 = input.LA(1);

                   	 
                   	int index70_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred129_Blaise()) ) { s = 54; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index70_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae70 =
            new NoViableAltException(dfa.Description, 70, _s, input);
        dfa.Error(nvae70);
        throw nvae70;
    }
    const string DFA71_eotS =
        "\x37\uffff";
    const string DFA71_eofS =
        "\x01\x02\x36\uffff";
    const string DFA71_minS =
        "\x01\x38\x01\x00\x35\uffff";
    const string DFA71_maxS =
        "\x01\u00d5\x01\x00\x35\uffff";
    const string DFA71_acceptS =
        "\x02\uffff\x01\x02\x33\uffff\x01\x01";
    const string DFA71_specialS =
        "\x01\uffff\x01\x00\x35\uffff}>";
    static readonly string[] DFA71_transitionS = {
            "\x01\x02\x1d\uffff\x01\x02\x01\uffff\x07\x02\x01\uffff\x04"+
            "\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x02\uffff\x02\x02\x06"+
            "\uffff\x02\x02\x09\uffff\x02\x02\x01\uffff\x0a\x02\x03\uffff"+
            "\x01\x02\x08\uffff\x01\x02\x09\uffff\x03\x02\x03\uffff\x01\x02"+
            "\x03\uffff\x02\x02\x01\uffff\x07\x02\x02\uffff\x08\x02\x01\uffff"+
            "\x02\x02\x01\uffff\x06\x02\x01\x01\x01\x02\x01\uffff\x01\x02"+
            "\x05\uffff\x01\x02\x02\uffff\x02\x02",
            "\x01\uffff",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA71_eot = DFA.UnpackEncodedString(DFA71_eotS);
    static readonly short[] DFA71_eof = DFA.UnpackEncodedString(DFA71_eofS);
    static readonly char[] DFA71_min = DFA.UnpackEncodedStringToUnsignedChars(DFA71_minS);
    static readonly char[] DFA71_max = DFA.UnpackEncodedStringToUnsignedChars(DFA71_maxS);
    static readonly short[] DFA71_accept = DFA.UnpackEncodedString(DFA71_acceptS);
    static readonly short[] DFA71_special = DFA.UnpackEncodedString(DFA71_specialS);
    static readonly short[][] DFA71_transition = DFA.UnpackEncodedStringArray(DFA71_transitionS);

    protected class DFA71 : DFA
    {
        public DFA71(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 71;
            this.eot = DFA71_eot;
            this.eof = DFA71_eof;
            this.min = DFA71_min;
            this.max = DFA71_max;
            this.accept = DFA71_accept;
            this.special = DFA71_special;
            this.transition = DFA71_transition;

        }

        override public string Description
        {
            get { return "918:23: ( LPAREN parameterList RPAREN )?"; }
        }

    }


    protected internal int DFA71_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA71_1 = input.LA(1);

                   	 
                   	int index71_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred131_Blaise()) ) { s = 54; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index71_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae71 =
            new NoViableAltException(dfa.Description, 71, _s, input);
        dfa.Error(nvae71);
        throw nvae71;
    }
    const string DFA72_eotS =
        "\x37\uffff";
    const string DFA72_eofS =
        "\x01\x02\x36\uffff";
    const string DFA72_minS =
        "\x01\x38\x01\x00\x35\uffff";
    const string DFA72_maxS =
        "\x01\u00d5\x01\x00\x35\uffff";
    const string DFA72_acceptS =
        "\x02\uffff\x01\x02\x33\uffff\x01\x01";
    const string DFA72_specialS =
        "\x01\uffff\x01\x00\x35\uffff}>";
    static readonly string[] DFA72_transitionS = {
            "\x01\x02\x1d\uffff\x01\x02\x01\uffff\x07\x02\x01\uffff\x04"+
            "\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x02\uffff\x02\x02\x06"+
            "\uffff\x02\x02\x09\uffff\x02\x02\x01\uffff\x0a\x02\x03\uffff"+
            "\x01\x02\x08\uffff\x01\x02\x09\uffff\x03\x02\x03\uffff\x01\x02"+
            "\x03\uffff\x02\x02\x01\uffff\x07\x02\x02\uffff\x08\x02\x01\uffff"+
            "\x02\x02\x01\uffff\x06\x02\x01\x01\x01\x02\x01\uffff\x01\x02"+
            "\x05\uffff\x01\x02\x02\uffff\x02\x02",
            "\x01\uffff",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA72_eot = DFA.UnpackEncodedString(DFA72_eotS);
    static readonly short[] DFA72_eof = DFA.UnpackEncodedString(DFA72_eofS);
    static readonly char[] DFA72_min = DFA.UnpackEncodedStringToUnsignedChars(DFA72_minS);
    static readonly char[] DFA72_max = DFA.UnpackEncodedStringToUnsignedChars(DFA72_maxS);
    static readonly short[] DFA72_accept = DFA.UnpackEncodedString(DFA72_acceptS);
    static readonly short[] DFA72_special = DFA.UnpackEncodedString(DFA72_specialS);
    static readonly short[][] DFA72_transition = DFA.UnpackEncodedStringArray(DFA72_transitionS);

    protected class DFA72 : DFA
    {
        public DFA72(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 72;
            this.eot = DFA72_eot;
            this.eof = DFA72_eof;
            this.min = DFA72_min;
            this.max = DFA72_max;
            this.accept = DFA72_accept;
            this.special = DFA72_special;
            this.transition = DFA72_transition;

        }

        override public string Description
        {
            get { return "919:24: ( LPAREN parameterList RPAREN )?"; }
        }

    }


    protected internal int DFA72_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA72_1 = input.LA(1);

                   	 
                   	int index72_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred133_Blaise()) ) { s = 54; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index72_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae72 =
            new NoViableAltException(dfa.Description, 72, _s, input);
        dfa.Error(nvae72);
        throw nvae72;
    }
    const string DFA73_eotS =
        "\x08\uffff";
    const string DFA73_eofS =
        "\x01\x02\x07\uffff";
    const string DFA73_minS =
        "\x02\x38\x01\uffff\x01\u0096\x01\uffff\x01\x38\x01\x00\x01\u0096";
    const string DFA73_maxS =
        "\x02\u00d5\x01\uffff\x01\u00ce\x01\uffff\x01\u00d5\x01\x00\x01"+
        "\u00ce";
    const string DFA73_acceptS =
        "\x02\uffff\x01\x02\x01\uffff\x01\x01\x03\uffff";
    const string DFA73_specialS =
        "\x06\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA73_transitionS = {
            "\x01\x02\x1d\uffff\x01\x02\x01\uffff\x07\x02\x01\uffff\x04"+
            "\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x02\uffff\x02\x02\x06"+
            "\uffff\x02\x02\x09\uffff\x02\x02\x01\uffff\x0a\x02\x03\uffff"+
            "\x01\x02\x08\uffff\x01\x02\x09\uffff\x03\x02\x03\uffff\x01\x02"+
            "\x03\uffff\x02\x02\x01\uffff\x07\x02\x02\uffff\x08\x02\x01\uffff"+
            "\x02\x02\x01\uffff\x06\x02\x01\x01\x01\x02\x01\uffff\x01\x02"+
            "\x02\uffff\x01\x02\x02\uffff\x01\x02\x02\uffff\x02\x02",
            "\x01\x02\x2a\uffff\x01\x02\x19\uffff\x02\x02\x01\uffff\x0a"+
            "\x02\x25\uffff\x01\x02\x06\uffff\x01\x02\x01\uffff\x04\x02\x0c"+
            "\uffff\x01\x02\x08\uffff\x01\x02\x02\uffff\x01\x02\x01\x03",
            "",
            "\x01\x02\x17\uffff\x01\x02\x01\uffff\x04\x02\x06\uffff\x04"+
            "\x02\x01\x04\x01\x05\x02\uffff\x07\x02\x01\x06\x01\x02\x03\uffff"+
            "\x01\x02",
            "",
            "\x01\x02\x2a\uffff\x01\x02\x19\uffff\x02\x02\x01\uffff\x0a"+
            "\x02\x25\uffff\x01\x02\x06\uffff\x01\x02\x01\uffff\x04\x02\x0c"+
            "\uffff\x01\x02\x08\uffff\x01\x02\x02\uffff\x01\x02\x01\x07",
            "\x01\uffff",
            "\x01\x02\x17\uffff\x01\x02\x01\uffff\x04\x02\x06\uffff\x04"+
            "\x02\x01\x04\x01\x05\x02\uffff\x07\x02\x01\x06\x01\x02\x03\uffff"+
            "\x01\x02"
    };

    static readonly short[] DFA73_eot = DFA.UnpackEncodedString(DFA73_eotS);
    static readonly short[] DFA73_eof = DFA.UnpackEncodedString(DFA73_eofS);
    static readonly char[] DFA73_min = DFA.UnpackEncodedStringToUnsignedChars(DFA73_minS);
    static readonly char[] DFA73_max = DFA.UnpackEncodedStringToUnsignedChars(DFA73_maxS);
    static readonly short[] DFA73_accept = DFA.UnpackEncodedString(DFA73_acceptS);
    static readonly short[] DFA73_special = DFA.UnpackEncodedString(DFA73_specialS);
    static readonly short[][] DFA73_transition = DFA.UnpackEncodedStringArray(DFA73_transitionS);

    protected class DFA73 : DFA
    {
        public DFA73(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 73;
            this.eot = DFA73_eot;
            this.eof = DFA73_eof;
            this.min = DFA73_min;
            this.max = DFA73_max;
            this.accept = DFA73_accept;
            this.special = DFA73_special;
            this.transition = DFA73_transition;

        }

        override public string Description
        {
            get { return "920:26: ( LPAREN lookupParameterList RPAREN )?"; }
        }

    }


    protected internal int DFA73_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA73_6 = input.LA(1);

                   	 
                   	int index73_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred135_Blaise()) ) { s = 4; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index73_6);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae73 =
            new NoViableAltException(dfa.Description, 73, _s, input);
        dfa.Error(nvae73);
        throw nvae73;
    }
    const string DFA75_eotS =
        "\x37\uffff";
    const string DFA75_eofS =
        "\x01\x02\x36\uffff";
    const string DFA75_minS =
        "\x01\x38\x01\x00\x35\uffff";
    const string DFA75_maxS =
        "\x01\u00d5\x01\x00\x35\uffff";
    const string DFA75_acceptS =
        "\x02\uffff\x01\x02\x33\uffff\x01\x01";
    const string DFA75_specialS =
        "\x01\uffff\x01\x00\x35\uffff}>";
    static readonly string[] DFA75_transitionS = {
            "\x01\x02\x1d\uffff\x01\x02\x01\uffff\x07\x02\x01\uffff\x04"+
            "\x02\x01\uffff\x01\x02\x01\uffff\x01\x02\x02\uffff\x02\x02\x06"+
            "\uffff\x02\x02\x09\uffff\x02\x02\x01\uffff\x0a\x02\x03\uffff"+
            "\x01\x02\x08\uffff\x01\x02\x09\uffff\x03\x02\x03\uffff\x01\x02"+
            "\x03\uffff\x02\x02\x01\uffff\x07\x02\x02\uffff\x08\x02\x01\uffff"+
            "\x02\x02\x01\uffff\x06\x02\x01\x01\x01\x02\x01\uffff\x01\x02"+
            "\x05\uffff\x01\x02\x02\uffff\x02\x02",
            "\x01\uffff",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA75_eot = DFA.UnpackEncodedString(DFA75_eotS);
    static readonly short[] DFA75_eof = DFA.UnpackEncodedString(DFA75_eofS);
    static readonly char[] DFA75_min = DFA.UnpackEncodedStringToUnsignedChars(DFA75_minS);
    static readonly char[] DFA75_max = DFA.UnpackEncodedStringToUnsignedChars(DFA75_maxS);
    static readonly short[] DFA75_accept = DFA.UnpackEncodedString(DFA75_acceptS);
    static readonly short[] DFA75_special = DFA.UnpackEncodedString(DFA75_specialS);
    static readonly short[][] DFA75_transition = DFA.UnpackEncodedStringArray(DFA75_transitionS);

    protected class DFA75 : DFA
    {
        public DFA75(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 75;
            this.eot = DFA75_eot;
            this.eof = DFA75_eof;
            this.min = DFA75_min;
            this.max = DFA75_max;
            this.accept = DFA75_accept;
            this.special = DFA75_special;
            this.transition = DFA75_transition;

        }

        override public string Description
        {
            get { return "922:15: ( LPAREN parameterList RPAREN )?"; }
        }

    }


    protected internal int DFA75_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA75_1 = input.LA(1);

                   	 
                   	int index75_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred139_Blaise()) ) { s = 54; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index75_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae75 =
            new NoViableAltException(dfa.Description, 75, _s, input);
        dfa.Error(nvae75);
        throw nvae75;
    }
    const string DFA79_eotS =
        "\x0a\uffff";
    const string DFA79_eofS =
        "\x01\uffff\x01\x03\x08\uffff";
    const string DFA79_minS =
        "\x01\u00d5\x01\u00be\x01\u00c8\x01\uffff\x01\u00d4\x01\uffff\x01"+
        "\u00c9\x01\x00\x02\uffff";
    const string DFA79_maxS =
        "\x01\u00d5\x01\u00c9\x01\u00c8\x01\uffff\x01\u00d5\x01\uffff\x01"+
        "\u00ce\x01\x00\x02\uffff";
    const string DFA79_acceptS =
        "\x03\uffff\x01\x01\x01\uffff\x01\x02\x02\uffff\x01\x04\x01\x03";
    const string DFA79_specialS =
        "\x07\uffff\x01\x00\x02\uffff}>";
    static readonly string[] DFA79_transitionS = {
            "\x01\x01",
            "\x01\x02\x01\x03\x09\uffff\x01\x03",
            "\x01\x04",
            "",
            "\x01\x05\x01\x06",
            "",
            "\x01\x07\x01\x08\x03\uffff\x01\x08",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA79_eot = DFA.UnpackEncodedString(DFA79_eotS);
    static readonly short[] DFA79_eof = DFA.UnpackEncodedString(DFA79_eofS);
    static readonly char[] DFA79_min = DFA.UnpackEncodedStringToUnsignedChars(DFA79_minS);
    static readonly char[] DFA79_max = DFA.UnpackEncodedStringToUnsignedChars(DFA79_maxS);
    static readonly short[] DFA79_accept = DFA.UnpackEncodedString(DFA79_acceptS);
    static readonly short[] DFA79_special = DFA.UnpackEncodedString(DFA79_specialS);
    static readonly short[][] DFA79_transition = DFA.UnpackEncodedStringArray(DFA79_transitionS);

    protected class DFA79 : DFA
    {
        public DFA79(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 79;
            this.eot = DFA79_eot;
            this.eof = DFA79_eof;
            this.min = DFA79_min;
            this.max = DFA79_max;
            this.accept = DFA79_accept;
            this.special = DFA79_special;
            this.transition = DFA79_transition;

        }

        override public string Description
        {
            get { return "953:1: lookupParameter : ( ID | ID ASSIGN LPAREN SQSTRING RPAREN | ID ASSIGN LPAREN ID RPAREN | ID ASSIGN LPAREN variable RPAREN );"; }
        }

    }


    protected internal int DFA79_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA79_7 = input.LA(1);

                   	 
                   	int index79_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred144_Blaise()) ) { s = 9; }

                   	else if ( (true) ) { s = 8; }

                   	 
                   	input.Seek(index79_7);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae79 =
            new NoViableAltException(dfa.Description, 79, _s, input);
        dfa.Error(nvae79);
        throw nvae79;
    }
    const string DFA98_eotS =
        "\x17\uffff";
    const string DFA98_eofS =
        "\x01\x01\x16\uffff";
    const string DFA98_minS =
        "\x01\x38\x02\uffff\x03\x00\x11\uffff";
    const string DFA98_maxS =
        "\x01\u00d5\x02\uffff\x03\x00\x11\uffff";
    const string DFA98_acceptS =
        "\x01\uffff\x01\x02\x05\uffff\x01\x01\x0f\uffff";
    const string DFA98_specialS =
        "\x03\uffff\x01\x00\x01\x01\x01\x02\x11\uffff}>";
    static readonly string[] DFA98_transitionS = {
            "\x01\x07\x1d\uffff\x01\x07\x0b\uffff\x01\x01\x01\x07\x01\uffff"+
            "\x01\x01\x04\uffff\x02\x07\x06\uffff\x02\x07\x09\uffff\x02\x07"+
            "\x01\uffff\x0a\x07\x16\uffff\x03\x07\x03\uffff\x01\x07\x06\uffff"+
            "\x01\x07\x01\uffff\x01\x07\x06\uffff\x01\x07\x01\uffff\x03\x07"+
            "\x01\x04\x0c\uffff\x01\x07\x08\uffff\x01\x05\x02\uffff\x01\x07"+
            "\x01\x03",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
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
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA98_eot = DFA.UnpackEncodedString(DFA98_eotS);
    static readonly short[] DFA98_eof = DFA.UnpackEncodedString(DFA98_eofS);
    static readonly char[] DFA98_min = DFA.UnpackEncodedStringToUnsignedChars(DFA98_minS);
    static readonly char[] DFA98_max = DFA.UnpackEncodedStringToUnsignedChars(DFA98_maxS);
    static readonly short[] DFA98_accept = DFA.UnpackEncodedString(DFA98_acceptS);
    static readonly short[] DFA98_special = DFA.UnpackEncodedString(DFA98_specialS);
    static readonly short[][] DFA98_transition = DFA.UnpackEncodedStringArray(DFA98_transitionS);

    protected class DFA98 : DFA
    {
        public DFA98(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 98;
            this.eot = DFA98_eot;
            this.eof = DFA98_eof;
            this.min = DFA98_min;
            this.max = DFA98_max;
            this.accept = DFA98_accept;
            this.special = DFA98_special;
            this.transition = DFA98_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 1067:66: (b+= statement )*"; }
        }

    }


    protected internal int DFA98_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA98_3 = input.LA(1);

                   	 
                   	int index98_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred167_Blaise()) ) { s = 7; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index98_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA98_4 = input.LA(1);

                   	 
                   	int index98_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred167_Blaise()) ) { s = 7; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index98_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA98_5 = input.LA(1);

                   	 
                   	int index98_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred167_Blaise()) ) { s = 7; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index98_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae98 =
            new NoViableAltException(dfa.Description, 98, _s, input);
        dfa.Error(nvae98);
        throw nvae98;
    }
    const string DFA124_eotS =
        "\x12\uffff";
    const string DFA124_eofS =
        "\x12\uffff";
    const string DFA124_minS =
        "\x01\x6c\x06\uffff\x01\u00b5\x04\uffff\x01\u00d1\x01\u00c8\x01"+
        "\u00cb\x02\uffff\x01\u00b5";
    const string DFA124_maxS =
        "\x01\u00d6\x06\uffff\x01\u00ca\x04\uffff\x01\u00d1\x01\u00d5\x01"+
        "\u00cb\x02\uffff\x01\u00b5";
    const string DFA124_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\uffff\x01\x09\x01\x0a\x01\x0b\x01\x0c\x03\uffff\x01\x08\x01\x07"+
        "\x01\uffff";
    const string DFA124_specialS =
        "\x12\uffff}>";
    static readonly string[] DFA124_transitionS = {
            "\x01\x01\x01\x02\x01\x03\x01\x08\x01\x09\x01\x0a\x42\uffff"+
            "\x01\x07\x06\uffff\x01\x04\x0c\uffff\x01\x06\x08\uffff\x01\x04"+
            "\x03\uffff\x01\x0b\x01\x05",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0d\x14\uffff\x01\x0c",
            "",
            "",
            "",
            "",
            "\x01\x0e",
            "\x01\x10\x0c\uffff\x01\x0f",
            "\x01\x11",
            "",
            "",
            "\x01\x0d"
    };

    static readonly short[] DFA124_eot = DFA.UnpackEncodedString(DFA124_eotS);
    static readonly short[] DFA124_eof = DFA.UnpackEncodedString(DFA124_eofS);
    static readonly char[] DFA124_min = DFA.UnpackEncodedStringToUnsignedChars(DFA124_minS);
    static readonly char[] DFA124_max = DFA.UnpackEncodedStringToUnsignedChars(DFA124_maxS);
    static readonly short[] DFA124_accept = DFA.UnpackEncodedString(DFA124_acceptS);
    static readonly short[] DFA124_special = DFA.UnpackEncodedString(DFA124_specialS);
    static readonly short[][] DFA124_transition = DFA.UnpackEncodedStringArray(DFA124_transitionS);

    protected class DFA124 : DFA
    {
        public DFA124(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 124;
            this.eot = DFA124_eot;
            this.eof = DFA124_eof;
            this.min = DFA124_min;
            this.max = DFA124_max;
            this.accept = DFA124_accept;
            this.special = DFA124_special;
            this.transition = DFA124_transition;

        }

        override public string Description
        {
            get { return "1133:1: typespec : ( ( STRING ( '[' b= INT ']' )? ) -> ^( TYPE_STRING ( $b)? ) | OPEN -> ^( TYPE_OPEN ) | ( INTEGER ( '[' b= INT ']' )? ) -> ^( TYPE_INTEGER ( $b)? ) | realrange | ( 'REAL' ( '[' b= INT ( ',' c= INT )? ']' )? ) -> ^( TYPE_REAL ( $b)? ( $c)? ) | category_list -> ^( TYPE_CATEGORY category_list ) | SET ( '[' b= INT ']' )? OF category_list -> ^( TYPE_SETOF ( $b)? ^( TYPE_CATEGORY category_list ) ) | SET ( '[' b= INT ']' )? OF c= ID ( ',' d+= ID )* -> ^( TYPE_SETOF ( $b)? $c ( $d)* ) | DATETYPE -> ^( TYPE_DATETYPE ) | TIMETYPE -> ^( TYPE_TIMETYPE ) | ARRAY '[' realrange ( ',' realrange )* ']' OF typespec -> ^( TYPE_ARRAY ( realrange )* typespec ) | a= ID -> ^( TYPE_USERDEF $a) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_INHERIT_in_inherit3341 = new BitSet(new ulong[]{0x0000000000000000UL,0xA000000000000000UL});
    public static readonly BitSet FOLLOW_CATI_in_inherit3346 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IMGLINK_in_inherit3352 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_id_list3375 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_id_list3378 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_id_list3382 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_variable_in_var_list3406 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_var_list3409 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_variable_in_var_list3413 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_signedInteger_in_int_list3437 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_int_list3440 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_signedInteger_in_int_list3444 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_signedReal_in_realrange3472 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_DOTDOT_in_realrange3474 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_signedReal_in_realrange3478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signedInteger_in_realrange3497 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_DOTDOT_in_realrange3499 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_signedReal_in_realrange3503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signedReal_in_realrange3522 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_DOTDOT_in_realrange3524 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_signedInteger_in_realrange3528 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signedInteger_in_realrange3547 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_DOTDOT_in_realrange3549 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_signedInteger_in_realrange3553 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DATAMODEL_in_datamodel3591 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_datamodel3595 = new BitSet(new ulong[]{0x0300000000000000UL,0x1C70034181000000UL,0x000007800027E400UL});
    public static readonly BitSet FOLLOW_QSTRING_in_datamodel3599 = new BitSet(new ulong[]{0x0200000000000000UL,0x1C70034181000000UL,0x000007800027E400UL});
    public static readonly BitSet FOLLOW_model_settings_in_datamodel3603 = new BitSet(new ulong[]{0x0200000000000000UL,0x1C70034181000000UL,0x000007800027E400UL});
    public static readonly BitSet FOLLOW_submodel_in_datamodel3613 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000101000000UL});
    public static readonly BitSet FOLLOW_ENDMODEL_in_datamodel3618 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_END_in_datamodel3622 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_submodel3662 = new BitSet(new ulong[]{0x0000000000000002UL,0x0C70034080000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_procedure_in_submodel3669 = new BitSet(new ulong[]{0x0000000000000002UL,0x0C70034080000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_table_in_submodel3675 = new BitSet(new ulong[]{0x0000000000000002UL,0x0C70034080000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_parameters_in_submodel3681 = new BitSet(new ulong[]{0x0000000000000002UL,0x0C70034080000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_externals_in_submodel3688 = new BitSet(new ulong[]{0x0000000000000002UL,0x0C70034080000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_libraries_in_submodel3694 = new BitSet(new ulong[]{0x0000000000000002UL,0x0C70034080000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_type_in_submodel3700 = new BitSet(new ulong[]{0x0000000000000002UL,0x0C70034080000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_fields_in_submodel3707 = new BitSet(new ulong[]{0x0000000000000002UL,0x0C70034080000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_auxfields_in_submodel3714 = new BitSet(new ulong[]{0x0000000000000002UL,0x0C70034080000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_routerAlien_in_submodel3721 = new BitSet(new ulong[]{0x0000000000000002UL,0x0C70034080000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_locals_in_submodel3727 = new BitSet(new ulong[]{0x0000000000000002UL,0x0C70034080000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_rules_in_submodel3741 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000040000002000UL});
    public static readonly BitSet FOLLOW_layout_in_submodel3748 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000040000002000UL});
    public static readonly BitSet FOLLOW_datamodel_in_blaise_file3767 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_blaise_file3769 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_submodel_in_submodel_file3779 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_submodel_file3781 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primary_in_model_settings3799 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_secondary_in_model_settings3803 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_uses_in_model_settings3807 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inherit_in_model_settings3810 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parallel_in_model_settings3814 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_languages_in_model_settings3818 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_attributes_in_model_settings3822 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCLUDE_FILE_in_model_settings3826 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PRIMARY_in_primary3838 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_var_list_in_primary3840 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_USES_in_uses3856 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_uses_item_in_uses3860 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_uses3863 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_uses_item_in_uses3867 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_ID_in_uses_item3890 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_SQSTRING_in_uses_item3892 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LANGUAGES_in_languages3911 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EQUAL_in_languages3913 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_language_in_languages3917 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_languages3920 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_language_in_languages3924 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_ID_in_language3951 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_QSTRING_in_language3955 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ATTRIBUTES_in_attributes3979 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EQUAL_in_attributes3981 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x80000000000003FFUL});
    public static readonly BitSet FOLLOW_attribute_values_in_attributes3985 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_attributes3989 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_attribute_values_in_attributes3993 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_SECONDARY_in_secondary4018 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_secondary_key_in_secondary4020 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_secondary_key4042 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EQUAL_in_secondary_key4044 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_var_list_in_secondary_key4050 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_secondary_key4053 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_ALPHA_in_secondary_key4058 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_TRIGRAM_in_secondary_key4062 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_secondary_key4065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PARALLEL_in_parallel4091 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_parallel_item_in_parallel4093 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_variable_in_parallel_item4114 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EQUAL_in_parallel_item4116 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_variable_in_parallel_item4122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PROCEDURE_in_procedure4149 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_procedure4151 = new BitSet(new ulong[]{0x0000000000000000UL,0x0C700340C0000000UL,0x0000078000000C00UL});
    public static readonly BitSet FOLLOW_procedure_fields_in_procedure4153 = new BitSet(new ulong[]{0x0000000000000000UL,0x0C700340C0000000UL,0x0000078000000C00UL});
    public static readonly BitSet FOLLOW_alien_in_procedure4157 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_rules_in_procedure4161 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_ENDPROCEDURE_in_procedure4165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parameters_in_procedure_fields4196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_externals_in_procedure_fields4200 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fields_in_procedure_fields4204 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_auxfields_in_procedure_fields4208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_locals_in_procedure_fields4212 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ROUTER_in_routerAlien4227 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_routerAlien4229 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_alien_in_routerAlien4231 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ALIEN_in_alien4239 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_alien4241 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_SQSTRING_in_alien4243 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_alien4246 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000120000UL});
    public static readonly BitSet FOLLOW_SQSTRING_in_alien4249 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_unsignedInteger_in_alien4253 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_alien4257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EMBEDDED_in_block4265 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000010000000000UL});
    public static readonly BitSet FOLLOW_BLOCK_in_block4268 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_block4272 = new BitSet(new ulong[]{0x0100000000000000UL,0x0C700340B0000000UL,0x0000078000003400UL});
    public static readonly BitSet FOLLOW_QSTRING_in_block4276 = new BitSet(new ulong[]{0x0000000000000000UL,0x0C700340B0000000UL,0x0000078000003400UL});
    public static readonly BitSet FOLLOW_block_settings_in_block4282 = new BitSet(new ulong[]{0x0000000000000000UL,0x0C700340B0000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_submodel_in_block4288 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000030000000UL});
    public static readonly BitSet FOLLOW_ENDBLOCK_in_block4293 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENDTABLE_in_block4297 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EMBEDDED_in_table4325 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000004000000000UL});
    public static readonly BitSet FOLLOW_TABLE_in_table4328 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_table4332 = new BitSet(new ulong[]{0x0100000000000000UL,0x0C700340B0000000UL,0x0000078000003400UL});
    public static readonly BitSet FOLLOW_QSTRING_in_table4336 = new BitSet(new ulong[]{0x0000000000000000UL,0x0C700340B0000000UL,0x0000078000003400UL});
    public static readonly BitSet FOLLOW_block_settings_in_table4342 = new BitSet(new ulong[]{0x0000000000000000UL,0x0C700340B0000000UL,0x0000078000002400UL});
    public static readonly BitSet FOLLOW_submodel_in_table4348 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000030000000UL});
    public static readonly BitSet FOLLOW_ENDTABLE_in_table4353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENDBLOCK_in_table4357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SETTINGS_in_block_settings4386 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_attributes_in_block_settings4388 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LAYOUT_in_layout4396 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000103800000000UL});
    public static readonly BitSet FOLLOW_layoutspec_in_layout4398 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000103800000000UL});
    public static readonly BitSet FOLLOW_AFTER_in_layoutspec4419 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_BEFORE_in_layoutspec4424 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_AT_in_layoutspec4429 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_FROM_in_layoutspec4434 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_variable_in_layoutspec4437 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000080000000000UL});
    public static readonly BitSet FOLLOW_TO_in_layoutspec4439 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_variable_in_layoutspec4443 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000400000UL,0x00000007E0000000UL});
    public static readonly BitSet FOLLOW_layoutstyle_in_layoutspec4445 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000400000UL,0x00000007E0000000UL});
    public static readonly BitSet FOLLOW_ruleslayoutstyle_in_layoutstyle4458 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INFOPANE_in_layoutstyle4463 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_variable_in_layoutstyle4465 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GRID_in_layoutstyle4471 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_variable_in_layoutstyle4473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FIELDPANE_in_layoutstyle4479 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_variable_in_layoutstyle4481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_ruleslayoutstyle0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TYPE_in_type4520 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_type_item_in_type4522 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_type_item4540 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EQUAL_in_type_item4542 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003F00000000000UL,0x0810000000000000UL,0x0000000000620100UL});
    public static readonly BitSet FOLLOW_typedef_in_type_item4544 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOCALS_in_locals4564 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_VAR_in_locals4568 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_field_in_locals4571 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_RULES_in_rules4594 = new BitSet(new ulong[]{0x0100000000000002UL,0x600C0C0800400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_statement_in_rules4598 = new BitSet(new ulong[]{0x0100000000000002UL,0x600C0C0800400000UL,0x0F40A047000003FFUL,0x0000000000320101UL});
    public static readonly BitSet FOLLOW_SEMI_in_rules4600 = new BitSet(new ulong[]{0x0100000000000002UL,0x600C0C0800400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_ifblock_in_statement4613 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whiledoblock_in_statement4619 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fordoblock_in_statement4625 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ruleslayoutstyle_in_statement4631 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RESERVECHECK_in_statement4636 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_statement4641 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_statement4662 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_statement4678 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ask_or_check_in_statement4686 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_ask_or_check4710 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_QSTRING_in_ask_or_check4715 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_ask_or_check4723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment4738 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x4000000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment4740 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320500UL});
    public static readonly BitSet FOLLOW_rightofin_in_assignment4754 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleExpression_in_assignment4763 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_variable4798 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004400UL});
    public static readonly BitSet FOLLOW_variableSelector_in_variable4803 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004400UL});
    public static readonly BitSet FOLLOW_DOT_in_variableSelector4827 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_variableSelector4831 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_variableSelector4849 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_simpleExpression_in_variableSelector4851 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_variableSelector4853 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_POSITION_in_builtinfuction4884 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_builtinfuction4886 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_builtinfuction4890 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_builtinfuction4893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPERCASE_in_builtinfuction4899 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_builtinfuction4901 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_simpleExpression_in_builtinfuction4905 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_builtinfuction4908 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_builtinBools0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_noparenexpression_in_expression4961 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x000C000000400000UL});
    public static readonly BitSet FOLLOW_set_in_expression4967 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_noparenexpression_in_expression4975 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x000C000000400000UL});
    public static readonly BitSet FOLLOW_involving_in_expression4981 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INVOLVING_in_involving4996 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_involving4999 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_var_list_in_involving5002 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_involving5004 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_builtinBools_in_noparenexpression5033 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000400000000000UL,0x00000000000000FCUL});
    public static readonly BitSet FOLLOW_simpleExpression_in_noparenexpression5043 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000400000000000UL,0x00000000000000FCUL});
    public static readonly BitSet FOLLOW_EQUAL_in_noparenexpression5080 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_NOT_EQUAL_in_noparenexpression5085 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_LT_in_noparenexpression5090 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_LE_in_noparenexpression5095 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_GE_in_noparenexpression5100 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_GT_in_noparenexpression5105 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_simpleExpression_in_noparenexpression5109 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000400000000000UL,0x00000000000000FCUL});
    public static readonly BitSet FOLLOW_IN_in_noparenexpression5125 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200400UL});
    public static readonly BitSet FOLLOW_rightofin_in_noparenexpression5128 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000400000000000UL,0x00000000000000FCUL});
    public static readonly BitSet FOLLOW_LBRACK_in_rightofin5161 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_realrange_in_rightofin5163 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_COMMA_in_rightofin5166 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_realrange_in_rightofin5168 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_rightofin5172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_rightofin5177 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_signedNumberOrRange_in_rightofin5179 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_COMMA_in_rightofin5182 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_signedNumberOrRange_in_rightofin5184 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_rightofin5189 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_rightofin5195 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x0840000000000000UL,0x0000000000120000UL});
    public static readonly BitSet FOLLOW_constantChr_in_rightofin5197 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_COMMA_in_rightofin5200 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x0840000000000000UL,0x0000000000120000UL});
    public static readonly BitSet FOLLOW_constantChr_in_rightofin5202 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_rightofin5207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_rightofin5213 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_idOrIdRange_in_rightofin5215 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_COMMA_in_rightofin5218 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_idOrIdRange_in_rightofin5220 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_rightofin5225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_rightofin5231 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_idOrIdRange5246 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_idOrIdRange5251 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_DOTDOT_in_idOrIdRange5253 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_idOrIdRange5255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signedNumber_in_signedNumberOrRange5267 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signedNumber_in_signedNumberOrRange5272 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_DOTDOT_in_signedNumberOrRange5274 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_signedNumber_in_signedNumberOrRange5276 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_simpleExpression5294 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0C00000000000000UL});
    public static readonly BitSet FOLLOW_set_in_simpleExpression5308 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x0F40800000000000UL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_term_in_simpleExpression5317 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0C00000000000000UL});
    public static readonly BitSet FOLLOW_attribute_values_in_simpleExpression5328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signedFactor_in_term5354 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x3003000000000000UL});
    public static readonly BitSet FOLLOW_STAR_in_term5360 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x0F40800000000000UL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_SLASH_in_term5365 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x0F40800000000000UL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_DIV_in_term5370 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x0F40800000000000UL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_MOD_in_term5375 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x0F40800000000000UL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_signedFactor_in_term5379 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x3003000000000000UL});
    public static readonly BitSet FOLLOW_NOT_in_factor5406 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x0F40800000000000UL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_factor_in_factor5409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_builtinfuction_in_factor5419 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_factor5452 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_expression_in_factor5454 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_COMMA_in_factor5457 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_expression_in_factor5459 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_factor5463 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unsignedConstant_in_factor5485 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_askOrVarOrFunctionDesignator_in_factor5493 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_search_in_factor5501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_signedFactor5541 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x0F40800000000000UL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_MINUS_in_signedFactor5544 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x0F40800000000000UL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_factor_in_signedFactor5549 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_search5572 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_search5574 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_SEARCH_in_search5577 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_search5580 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_search5583 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_search5585 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_askOrVarOrFunctionDesignator5615 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_askOrVarOrFunctionDesignator5617 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_KEEP_in_askOrVarOrFunctionDesignator5620 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_askOrVarOrFunctionDesignator5624 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_askOrVarOrFunctionDesignator5627 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_askOrVarOrFunctionDesignator5629 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_askOrVarOrFunctionDesignator5637 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_askOrVarOrFunctionDesignator5639 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_ASK_in_askOrVarOrFunctionDesignator5642 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_askOrVarOrFunctionDesignator5646 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_askOrVarOrFunctionDesignator5649 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_askOrVarOrFunctionDesignator5651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_askOrVarOrFunctionDesignator5660 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_askOrVarOrFunctionDesignator5662 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_SHOW_in_askOrVarOrFunctionDesignator5665 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_askOrVarOrFunctionDesignator5669 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_askOrVarOrFunctionDesignator5672 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_askOrVarOrFunctionDesignator5674 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_askOrVarOrFunctionDesignator5682 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_askOrVarOrFunctionDesignator5684 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_LOOKUP_in_askOrVarOrFunctionDesignator5687 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_askOrVarOrFunctionDesignator5691 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_lookupParameterList_in_askOrVarOrFunctionDesignator5693 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_askOrVarOrFunctionDesignator5695 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_askOrVarOrFunctionDesignator5700 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_askOrVarOrFunctionDesignator5702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_askOrVarOrFunctionDesignator5709 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_askOrVarOrFunctionDesignator5711 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000008000000UL});
    public static readonly BitSet FOLLOW_CLASSIFY_in_askOrVarOrFunctionDesignator5714 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_askOrVarOrFunctionDesignator5721 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_askOrVarOrFunctionDesignator5725 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_askOrVarOrFunctionDesignator5728 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_askOrVarOrFunctionDesignator5730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleExpression_in_parameterList5766 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_parameterList5770 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_simpleExpression_in_parameterList5772 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_lookupParameter_in_lookupParameterList5804 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_lookupParameterList5808 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_lookupParameter_in_lookupParameterList5810 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_ID_in_lookupParameter5824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_lookupParameter5829 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x4000000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_lookupParameter5831 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_lookupParameter5833 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_SQSTRING_in_lookupParameter5835 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_lookupParameter5837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_lookupParameter5843 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x4000000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_lookupParameter5845 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_lookupParameter5847 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_lookupParameter5849 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_lookupParameter5851 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_lookupParameter5856 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x4000000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_lookupParameter5858 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_lookupParameter5860 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_variable_in_lookupParameter5862 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_lookupParameter5864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unsignedNumber_in_unsignedConstant5896 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constantChr_in_unsignedConstant5904 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHAR_in_constantChr5926 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_constantChr5929 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_expression_in_constantChr5933 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_constantChr5936 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QSTRING_in_constantChr5944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SQSTRING_in_constantChr5951 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unsignedReal_in_unsignedNumber5982 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unsignedInteger_in_unsignedNumber5990 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_signedInteger6010 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_unsignedInteger_in_signedInteger6013 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_signedReal6020 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_unsignedReal_in_signedReal6023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signedReal_in_signedNumber6036 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signedInteger_in_signedNumber6044 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_unsignedInteger6062 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_unsignedReal6084 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_unsignedReal6086 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_INT_in_unsignedReal6090 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_sign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_ifblock6159 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_expression_in_ifblock6163 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000008000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_field_desc_in_ifblock6167 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000008000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_THEN_in_ifblock6170 = new BitSet(new ulong[]{0x0100000000000000UL,0x600C0C0E02400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_statement_in_ifblock6177 = new BitSet(new ulong[]{0x0100000000000000UL,0x600C0C0E02400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_elseifblock_in_ifblock6184 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000602000000UL});
    public static readonly BitSet FOLLOW_elseblock_in_ifblock6191 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_ENDIF_in_ifblock6196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELSEIF_in_elseifblock6238 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_expression_in_elseifblock6242 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000008000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_field_desc_in_elseifblock6246 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000008000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_THEN_in_elseifblock6249 = new BitSet(new ulong[]{0x0100000000000002UL,0x600C0C0800400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_statement_in_elseifblock6256 = new BitSet(new ulong[]{0x0100000000000002UL,0x600C0C0800400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_ELSE_in_elseblock6295 = new BitSet(new ulong[]{0x0100000000000002UL,0x600C0C0800400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_statement_in_elseblock6302 = new BitSet(new ulong[]{0x0100000000000002UL,0x600C0C0800400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_WHILE_in_whiledoblock6324 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_expression_in_whiledoblock6328 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0080000000000000UL});
    public static readonly BitSet FOLLOW_DO_in_whiledoblock6330 = new BitSet(new ulong[]{0x0100000000000000UL,0x600C0C0804400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_statement_in_whiledoblock6337 = new BitSet(new ulong[]{0x0100000000000000UL,0x600C0C0804400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_ENDWHILE_in_whiledoblock6342 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_fordoblock6368 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_fordoblock6372 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x4000000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_fordoblock6374 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_simpleExpression_in_fordoblock6378 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000080000000000UL});
    public static readonly BitSet FOLLOW_TO_in_fordoblock6380 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_simpleExpression_in_fordoblock6384 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0080000000000000UL});
    public static readonly BitSet FOLLOW_DO_in_fordoblock6386 = new BitSet(new ulong[]{0x0100000000000000UL,0x600C0C0808400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_statement_in_fordoblock6393 = new BitSet(new ulong[]{0x0100000000000000UL,0x600C0C0808400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_ENDDO_in_fordoblock6398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CASE_in_caseofblock6427 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_caseofblock6431 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0020000000000000UL});
    public static readonly BitSet FOLLOW_OF_in_caseofblock6433 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002400000000UL,0x0800000000000000UL,0x0000000000220000UL});
    public static readonly BitSet FOLLOW_case_item_in_caseofblock6440 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002400000000UL,0x0800000000000000UL,0x0000000000220000UL});
    public static readonly BitSet FOLLOW_elseblock_in_caseofblock6448 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_ENDCASE_in_caseofblock6453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_id_list_in_case_item6481 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_list_in_case_item6485 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_list_in_case_item6489 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_realrange_in_case_item6493 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COLON_in_case_item6496 = new BitSet(new ulong[]{0x0100000000000002UL,0x600C0C0800400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_statement_in_case_item6500 = new BitSet(new ulong[]{0x0100000000000002UL,0x600C0C0800400000UL,0x0F40A047000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_PARAMETERS_in_parameters6529 = new BitSet(new ulong[]{0x0000000000000002UL,0x0380000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_parameter_item_in_parameters6532 = new BitSet(new ulong[]{0x0000000000000002UL,0x0380000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_IMPORT_in_parameter_item6545 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_EXPORT_in_parameter_item6548 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_TRANSIT_in_parameter_item6552 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_id_list_in_parameter_item6558 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COLON_in_parameter_item6561 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003F00000000000UL,0x0810000000000000UL,0x0000000000620100UL});
    public static readonly BitSet FOLLOW_typedef_in_parameter_item6565 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXTERNALS_in_externals6591 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_external_item_in_externals6594 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_external_item6607 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COLON_in_external_item6609 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_external_item6613 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_external_item6615 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_SQSTRING_in_external_item6619 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_COMMA_in_external_item6622 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_external_item6626 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_external_item6630 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LIBRARIES_in_libraries6640 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_library_item_in_libraries6643 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_library_item6654 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_SQSTRING_in_library_item6656 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AUXFIELDS_in_auxfields6670 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_field_in_auxfields6672 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_lid_string6703 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_QSTRING_in_lid_string6706 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FIELDS_in_fields6725 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_field_in_fields6727 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_id_list_in_field6745 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x2000000000000000UL,0x0000000000200102UL});
    public static readonly BitSet FOLLOW_field_tag_in_field6747 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x2000000000000000UL,0x0000000000200002UL});
    public static readonly BitSet FOLLOW_field_text_in_field6750 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x2000000000000000UL,0x0000000000200002UL});
    public static readonly BitSet FOLLOW_SLASH_in_field6754 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200002UL});
    public static readonly BitSet FOLLOW_field_desc_in_field6756 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200002UL});
    public static readonly BitSet FOLLOW_COLON_in_field6761 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003F00000000000UL,0x0810000000000000UL,0x0000000000620100UL});
    public static readonly BitSet FOLLOW_typedef_in_field6763 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_SEMI_in_field6765 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lid_string_in_field_text6796 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lid_string_in_field_desc6813 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_field_tag6830 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_id_list_in_field_tag6832 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_field_tag6834 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typespec_in_typedef6851 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x80000000000003FFUL});
    public static readonly BitSet FOLLOW_attribute_values_in_typedef6855 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_typedef6859 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_attribute_values_in_typedef6863 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_set_in_attribute_values0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_typespec6953 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LBRACK_in_typespec6956 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_INT_in_typespec6960 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_typespec6962 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPEN_in_typespec6980 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_in_typespec6993 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LBRACK_in_typespec6996 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_INT_in_typespec7000 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_typespec7002 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_realrange_in_typespec7020 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_214_in_typespec7026 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LBRACK_in_typespec7029 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_INT_in_typespec7033 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_COMMA_in_typespec7036 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_INT_in_typespec7040 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_typespec7044 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_category_list_in_typespec7066 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SET_in_typespec7078 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0020000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LBRACK_in_typespec7081 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_INT_in_typespec7085 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_typespec7087 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0020000000000000UL});
    public static readonly BitSet FOLLOW_OF_in_typespec7091 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_category_list_in_typespec7093 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SET_in_typespec7114 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0020000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LBRACK_in_typespec7117 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_INT_in_typespec7121 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_typespec7123 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0020000000000000UL});
    public static readonly BitSet FOLLOW_OF_in_typespec7127 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_typespec7131 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_typespec7134 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_typespec7138 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_DATETYPE_in_typespec7162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIMETYPE_in_typespec7172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_typespec7184 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LBRACK_in_typespec7186 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_realrange_in_typespec7188 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_COMMA_in_typespec7191 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_realrange_in_typespec7193 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_typespec7198 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0020000000000000UL});
    public static readonly BitSet FOLLOW_OF_in_typespec7200 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003F00000000000UL,0x0810000000000000UL,0x0000000000620100UL});
    public static readonly BitSet FOLLOW_typespec_in_typespec7202 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_typespec7220 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_category_list7241 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_category_in_category_list7246 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_COMMA_in_category_list7249 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_category_in_category_list7254 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_category_list7258 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_category7272 = new BitSet(new ulong[]{0x0100000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_category7275 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_signedInteger_in_category7277 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_category7279 = new BitSet(new ulong[]{0x0100000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_lid_string_in_category7283 = new BitSet(new ulong[]{0x0100000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_variable_in_synpred41_Blaise4114 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EQUAL_in_synpred41_Blaise4116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_synpred81_Blaise4655 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x4000000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_synpred81_Blaise4657 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_synpred82_Blaise4671 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x4000000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_synpred82_Blaise4673 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_synpred83_Blaise4702 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_QSTRING_in_synpred83_Blaise4705 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_synpred84_Blaise4747 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_synpred103_Blaise5161 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_realrange_in_synpred103_Blaise5163 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_COMMA_in_synpred103_Blaise5166 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_realrange_in_synpred103_Blaise5168 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_synpred103_Blaise5172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_synpred105_Blaise5177 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_signedNumberOrRange_in_synpred105_Blaise5179 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_COMMA_in_synpred105_Blaise5182 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_signedNumberOrRange_in_synpred105_Blaise5184 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x8000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_RBRACK_in_synpred105_Blaise5189 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_synpred113_Blaise5298 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_askOrVarOrFunctionDesignator_in_synpred125_Blaise5493 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred128_Blaise5580 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_synpred128_Blaise5583 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred128_Blaise5585 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred129_Blaise5624 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_synpred129_Blaise5627 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred129_Blaise5629 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_synpred130_Blaise5615 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_synpred130_Blaise5617 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_KEEP_in_synpred130_Blaise5620 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred130_Blaise5624 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_synpred130_Blaise5627 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred130_Blaise5629 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred131_Blaise5646 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_synpred131_Blaise5649 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred131_Blaise5651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_synpred132_Blaise5637 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_synpred132_Blaise5639 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_ASK_in_synpred132_Blaise5642 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred132_Blaise5646 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_synpred132_Blaise5649 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred132_Blaise5651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred133_Blaise5669 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_synpred133_Blaise5672 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred133_Blaise5674 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_synpred134_Blaise5660 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_synpred134_Blaise5662 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_SHOW_in_synpred134_Blaise5665 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred134_Blaise5669 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_synpred134_Blaise5672 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred134_Blaise5674 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred135_Blaise5691 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_lookupParameterList_in_synpred135_Blaise5693 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred135_Blaise5695 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_synpred137_Blaise5682 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_synpred137_Blaise5684 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_LOOKUP_in_synpred137_Blaise5687 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred137_Blaise5691 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_lookupParameterList_in_synpred137_Blaise5693 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred137_Blaise5695 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_synpred137_Blaise5700 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_synpred137_Blaise5702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_synpred138_Blaise5709 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DOT_in_synpred138_Blaise5711 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000008000000UL});
    public static readonly BitSet FOLLOW_CLASSIFY_in_synpred138_Blaise5714 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred139_Blaise5725 = new BitSet(new ulong[]{0x0100000000000000UL,0x6000000800000000UL,0x0F408000000003FFUL,0x0000000000320100UL});
    public static readonly BitSet FOLLOW_parameterList_in_synpred139_Blaise5728 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred139_Blaise5730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_synpred144_Blaise5843 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x4000000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_synpred144_Blaise5845 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LPAREN_in_synpred144_Blaise5847 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_ID_in_synpred144_Blaise5849 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_RPAREN_in_synpred144_Blaise5851 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_id_list_in_synpred164_Blaise6481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_list_in_synpred165_Blaise6485 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_synpred167_Blaise6500 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}