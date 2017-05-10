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
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="AbstractIfStmtParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5-SNAPSHOT")]
//[System.CLSCompliant(false)]
public interface IIfStmtListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>notExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpr([NotNull] AbstractIfStmtParser.NotExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpr([NotNull] AbstractIfStmtParser.NotExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>unaryMinusExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryMinusExpr([NotNull] AbstractIfStmtParser.UnaryMinusExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>unaryMinusExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryMinusExpr([NotNull] AbstractIfStmtParser.UnaryMinusExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicationExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicationExpr([NotNull] AbstractIfStmtParser.MultiplicationExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicationExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicationExpr([NotNull] AbstractIfStmtParser.MultiplicationExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>orExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrExpr([NotNull] AbstractIfStmtParser.OrExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>orExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrExpr([NotNull] AbstractIfStmtParser.OrExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>atomExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtomExpr([NotNull] AbstractIfStmtParser.AtomExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>atomExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtomExpr([NotNull] AbstractIfStmtParser.AtomExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>additiveExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpr([NotNull] AbstractIfStmtParser.AdditiveExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>additiveExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpr([NotNull] AbstractIfStmtParser.AdditiveExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>relationalExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationalExpr([NotNull] AbstractIfStmtParser.RelationalExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>relationalExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationalExpr([NotNull] AbstractIfStmtParser.RelationalExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>equalityExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqualityExpr([NotNull] AbstractIfStmtParser.EqualityExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>equalityExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqualityExpr([NotNull] AbstractIfStmtParser.EqualityExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>andExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAndExpr([NotNull] AbstractIfStmtParser.AndExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>andExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAndExpr([NotNull] AbstractIfStmtParser.AndExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParExpr([NotNull] AbstractIfStmtParser.ParExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parExpr</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParExpr([NotNull] AbstractIfStmtParser.ParExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanAtom</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanAtom([NotNull] AbstractIfStmtParser.BooleanAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanAtom</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanAtom([NotNull] AbstractIfStmtParser.BooleanAtomContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>idAtom</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdAtom([NotNull] AbstractIfStmtParser.IdAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>idAtom</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdAtom([NotNull] AbstractIfStmtParser.IdAtomContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>stringAtom</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringAtom([NotNull] AbstractIfStmtParser.StringAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stringAtom</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringAtom([NotNull] AbstractIfStmtParser.StringAtomContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>nilAtom</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNilAtom([NotNull] AbstractIfStmtParser.NilAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>nilAtom</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNilAtom([NotNull] AbstractIfStmtParser.NilAtomContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>numberAtom</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberAtom([NotNull] AbstractIfStmtParser.NumberAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numberAtom</c>
	/// labeled alternative in <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberAtom([NotNull] AbstractIfStmtParser.NumberAtomContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbstractIfStmtParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParse([NotNull] AbstractIfStmtParser.ParseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbstractIfStmtParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParse([NotNull] AbstractIfStmtParser.ParseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbstractIfStmtParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] AbstractIfStmtParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbstractIfStmtParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] AbstractIfStmtParser.BlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbstractIfStmtParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStat([NotNull] AbstractIfStmtParser.StatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbstractIfStmtParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStat([NotNull] AbstractIfStmtParser.StatContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbstractIfStmtParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] AbstractIfStmtParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbstractIfStmtParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] AbstractIfStmtParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbstractIfStmtParser.if_stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf_stat([NotNull] AbstractIfStmtParser.If_statContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbstractIfStmtParser.if_stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf_stat([NotNull] AbstractIfStmtParser.If_statContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbstractIfStmtParser.condition_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition_block([NotNull] AbstractIfStmtParser.Condition_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbstractIfStmtParser.condition_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition_block([NotNull] AbstractIfStmtParser.Condition_blockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbstractIfStmtParser.stat_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStat_block([NotNull] AbstractIfStmtParser.Stat_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbstractIfStmtParser.stat_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStat_block([NotNull] AbstractIfStmtParser.Stat_blockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] AbstractIfStmtParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbstractIfStmtParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] AbstractIfStmtParser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom([NotNull] AbstractIfStmtParser.AtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbstractIfStmtParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom([NotNull] AbstractIfStmtParser.AtomContext context);
}
} // namespace MyProject.Folder
