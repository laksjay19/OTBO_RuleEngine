//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Lakshmi\otbo-master\otbo\CMS\CMS_Desktop_Client\CMS_Desktop_Client\IfStmt.g4 by ANTLR 4.5-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace OTBO_RuleEngine
{
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
//[System.CLSCompliant(false)]
public partial class AbstractIfStmtLexer : Lexer {
	public const int
		OR=1, AND=2, EQ=3, NEQ=4, GT=5, LT=6, GTEQ=7, LTEQ=8, PLUS=9, MINUS=10, 
		MULT=11, DIV=12, MOD=13, POW=14, NOT=15, SCOL=16, ASSIGN=17, OPAR=18, 
		CPAR=19, OBRACE=20, CBRACE=21, TRUE=22, FALSE=23, NIL=24, IF=25, ELSE=26, 
		ID=27, INT=28, FLOAT=29, STRING=30, COMMENT=31, SPACE=32, OTHER=33;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"OR", "AND", "EQ", "NEQ", "GT", "LT", "GTEQ", "LTEQ", "PLUS", "MINUS", 
		"MULT", "DIV", "MOD", "POW", "NOT", "SCOL", "ASSIGN", "OPAR", "CPAR", 
		"OBRACE", "CBRACE", "TRUE", "FALSE", "NIL", "IF", "ELSE", "ID", "INT", 
		"FLOAT", "STRING", "COMMENT", "SPACE", "OTHER"
	};


	public AbstractIfStmtLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'||'", "'&&'", "'=='", "'!='", "'>'", "'<'", "'>='", "'<='", "'+'", 
		"'-'", "'*'", "'/'", "'%'", "'^'", "'!'", "';'", "'='", "'('", "')'", 
		"'{'", "'}'", "'true'", "'false'", "'nil'", "'if'", "'else'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "OR", "AND", "EQ", "NEQ", "GT", "LT", "GTEQ", "LTEQ", "PLUS", "MINUS", 
		"MULT", "DIV", "MOD", "POW", "NOT", "SCOL", "ASSIGN", "OPAR", "CPAR", 
		"OBRACE", "CBRACE", "TRUE", "FALSE", "NIL", "IF", "ELSE", "ID", "INT", 
		"FLOAT", "STRING", "COMMENT", "SPACE", "OTHER"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "IfStmt.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2#\xC6\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3"+
		"\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3"+
		"\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3"+
		"\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3\x14\x3\x15\x3"+
		"\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3"+
		"\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3"+
		"\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\a\x1C\x8F\n\x1C"+
		"\f\x1C\xE\x1C\x92\v\x1C\x3\x1D\x6\x1D\x95\n\x1D\r\x1D\xE\x1D\x96\x3\x1E"+
		"\x6\x1E\x9A\n\x1E\r\x1E\xE\x1E\x9B\x3\x1E\x3\x1E\a\x1E\xA0\n\x1E\f\x1E"+
		"\xE\x1E\xA3\v\x1E\x3\x1E\x3\x1E\x6\x1E\xA7\n\x1E\r\x1E\xE\x1E\xA8\x5\x1E"+
		"\xAB\n\x1E\x3\x1F\x3\x1F\x3\x1F\x3\x1F\a\x1F\xB1\n\x1F\f\x1F\xE\x1F\xB4"+
		"\v\x1F\x3\x1F\x3\x1F\x3 \x3 \a \xBA\n \f \xE \xBD\v \x3 \x3 \x3!\x3!\x3"+
		"!\x3!\x3\"\x3\"\x2\x2\x2#\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2"+
		"\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D"+
		"\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2"+
		"\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2"+
		"\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x3\x2\b\x5\x2\x43\\\x61\x61\x63|\x6\x2"+
		"\x32;\x43\\\x61\x61\x63|\x3\x2\x32;\x5\x2\f\f\xF\xF$$\x4\x2\f\f\xF\xF"+
		"\x5\x2\v\f\xF\xF\"\"\xCE\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2"+
		"\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2"+
		"\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17"+
		"\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2"+
		"\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2"+
		"\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3"+
		"\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2"+
		"\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2"+
		"?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x3\x45\x3\x2\x2\x2"+
		"\x5H\x3\x2\x2\x2\aK\x3\x2\x2\x2\tN\x3\x2\x2\x2\vQ\x3\x2\x2\x2\rS\x3\x2"+
		"\x2\x2\xFU\x3\x2\x2\x2\x11X\x3\x2\x2\x2\x13[\x3\x2\x2\x2\x15]\x3\x2\x2"+
		"\x2\x17_\x3\x2\x2\x2\x19\x61\x3\x2\x2\x2\x1B\x63\x3\x2\x2\x2\x1D\x65\x3"+
		"\x2\x2\x2\x1Fg\x3\x2\x2\x2!i\x3\x2\x2\x2#k\x3\x2\x2\x2%m\x3\x2\x2\x2\'"+
		"o\x3\x2\x2\x2)q\x3\x2\x2\x2+s\x3\x2\x2\x2-u\x3\x2\x2\x2/z\x3\x2\x2\x2"+
		"\x31\x80\x3\x2\x2\x2\x33\x84\x3\x2\x2\x2\x35\x87\x3\x2\x2\x2\x37\x8C\x3"+
		"\x2\x2\x2\x39\x94\x3\x2\x2\x2;\xAA\x3\x2\x2\x2=\xAC\x3\x2\x2\x2?\xB7\x3"+
		"\x2\x2\x2\x41\xC0\x3\x2\x2\x2\x43\xC4\x3\x2\x2\x2\x45\x46\a~\x2\x2\x46"+
		"G\a~\x2\x2G\x4\x3\x2\x2\x2HI\a(\x2\x2IJ\a(\x2\x2J\x6\x3\x2\x2\x2KL\a?"+
		"\x2\x2LM\a?\x2\x2M\b\x3\x2\x2\x2NO\a#\x2\x2OP\a?\x2\x2P\n\x3\x2\x2\x2"+
		"QR\a@\x2\x2R\f\x3\x2\x2\x2ST\a>\x2\x2T\xE\x3\x2\x2\x2UV\a@\x2\x2VW\a?"+
		"\x2\x2W\x10\x3\x2\x2\x2XY\a>\x2\x2YZ\a?\x2\x2Z\x12\x3\x2\x2\x2[\\\a-\x2"+
		"\x2\\\x14\x3\x2\x2\x2]^\a/\x2\x2^\x16\x3\x2\x2\x2_`\a,\x2\x2`\x18\x3\x2"+
		"\x2\x2\x61\x62\a\x31\x2\x2\x62\x1A\x3\x2\x2\x2\x63\x64\a\'\x2\x2\x64\x1C"+
		"\x3\x2\x2\x2\x65\x66\a`\x2\x2\x66\x1E\x3\x2\x2\x2gh\a#\x2\x2h \x3\x2\x2"+
		"\x2ij\a=\x2\x2j\"\x3\x2\x2\x2kl\a?\x2\x2l$\x3\x2\x2\x2mn\a*\x2\x2n&\x3"+
		"\x2\x2\x2op\a+\x2\x2p(\x3\x2\x2\x2qr\a}\x2\x2r*\x3\x2\x2\x2st\a\x7F\x2"+
		"\x2t,\x3\x2\x2\x2uv\av\x2\x2vw\at\x2\x2wx\aw\x2\x2xy\ag\x2\x2y.\x3\x2"+
		"\x2\x2z{\ah\x2\x2{|\a\x63\x2\x2|}\an\x2\x2}~\au\x2\x2~\x7F\ag\x2\x2\x7F"+
		"\x30\x3\x2\x2\x2\x80\x81\ap\x2\x2\x81\x82\ak\x2\x2\x82\x83\an\x2\x2\x83"+
		"\x32\x3\x2\x2\x2\x84\x85\ak\x2\x2\x85\x86\ah\x2\x2\x86\x34\x3\x2\x2\x2"+
		"\x87\x88\ag\x2\x2\x88\x89\an\x2\x2\x89\x8A\au\x2\x2\x8A\x8B\ag\x2\x2\x8B"+
		"\x36\x3\x2\x2\x2\x8C\x90\t\x2\x2\x2\x8D\x8F\t\x3\x2\x2\x8E\x8D\x3\x2\x2"+
		"\x2\x8F\x92\x3\x2\x2\x2\x90\x8E\x3\x2\x2\x2\x90\x91\x3\x2\x2\x2\x91\x38"+
		"\x3\x2\x2\x2\x92\x90\x3\x2\x2\x2\x93\x95\t\x4\x2\x2\x94\x93\x3\x2\x2\x2"+
		"\x95\x96\x3\x2\x2\x2\x96\x94\x3\x2\x2\x2\x96\x97\x3\x2\x2\x2\x97:\x3\x2"+
		"\x2\x2\x98\x9A\t\x4\x2\x2\x99\x98\x3\x2\x2\x2\x9A\x9B\x3\x2\x2\x2\x9B"+
		"\x99\x3\x2\x2\x2\x9B\x9C\x3\x2\x2\x2\x9C\x9D\x3\x2\x2\x2\x9D\xA1\a\x30"+
		"\x2\x2\x9E\xA0\t\x4\x2\x2\x9F\x9E\x3\x2\x2\x2\xA0\xA3\x3\x2\x2\x2\xA1"+
		"\x9F\x3\x2\x2\x2\xA1\xA2\x3\x2\x2\x2\xA2\xAB\x3\x2\x2\x2\xA3\xA1\x3\x2"+
		"\x2\x2\xA4\xA6\a\x30\x2\x2\xA5\xA7\t\x4\x2\x2\xA6\xA5\x3\x2\x2\x2\xA7"+
		"\xA8\x3\x2\x2\x2\xA8\xA6\x3\x2\x2\x2\xA8\xA9\x3\x2\x2\x2\xA9\xAB\x3\x2"+
		"\x2\x2\xAA\x99\x3\x2\x2\x2\xAA\xA4\x3\x2\x2\x2\xAB<\x3\x2\x2\x2\xAC\xB2"+
		"\a$\x2\x2\xAD\xB1\n\x5\x2\x2\xAE\xAF\a$\x2\x2\xAF\xB1\a$\x2\x2\xB0\xAD"+
		"\x3\x2\x2\x2\xB0\xAE\x3\x2\x2\x2\xB1\xB4\x3\x2\x2\x2\xB2\xB0\x3\x2\x2"+
		"\x2\xB2\xB3\x3\x2\x2\x2\xB3\xB5\x3\x2\x2\x2\xB4\xB2\x3\x2\x2\x2\xB5\xB6"+
		"\a$\x2\x2\xB6>\x3\x2\x2\x2\xB7\xBB\a%\x2\x2\xB8\xBA\n\x6\x2\x2\xB9\xB8"+
		"\x3\x2\x2\x2\xBA\xBD\x3\x2\x2\x2\xBB\xB9\x3\x2\x2\x2\xBB\xBC\x3\x2\x2"+
		"\x2\xBC\xBE\x3\x2\x2\x2\xBD\xBB\x3\x2\x2\x2\xBE\xBF\b \x2\x2\xBF@\x3\x2"+
		"\x2\x2\xC0\xC1\t\a\x2\x2\xC1\xC2\x3\x2\x2\x2\xC2\xC3\b!\x2\x2\xC3\x42"+
		"\x3\x2\x2\x2\xC4\xC5\v\x2\x2\x2\xC5\x44\x3\x2\x2\x2\f\x2\x90\x96\x9B\xA1"+
		"\xA8\xAA\xB0\xB2\xBB\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace MyProject.Folder
