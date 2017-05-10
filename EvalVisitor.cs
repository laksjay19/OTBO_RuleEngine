using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;


namespace OTBO_RuleEngine
{
    public class EvalVisitor : IfStmtBaseVisitor<Value>
    {
        private IDictionary<string, Value> memory = new Dictionary<string, Value>();
        public static Double SMALL_VALUE = 0.00000000001;

        public string strReturnValue;
        public override Value VisitAssignment(AbstractIfStmtParser.AssignmentContext context)
        {
            string id = context.ID().GetText();
            Value value = this.Visit(context.expr());
            memory.Add(id, value);
            return value;
        }

        public void AddToDictionary(string strParamName, string strParamValue)
        {
            Value paramVal = new Value(strParamValue);
            memory.Add(strParamName, paramVal);
        }

        public void UpdateDictionary(string strParamName, string strParamValue)
        {
            memory.Remove(strParamName);
            AddToDictionary(strParamName, strParamValue);
        }


        public override Value VisitStat_block(AbstractIfStmtParser.Stat_blockContext context)
        {
            strReturnValue = context.GetText();
            return base.VisitStat_block(context);
        }

      
        public override Value VisitIdAtom(AbstractIfStmtParser.IdAtomContext context)
        {
            //return base.VisitIdAtom(context);

            string id = context.GetText();
            string strVal = "false";
            bool bKeyPresent = false;
            if (memory.ContainsKey(id))
            {
                Value memVal = memory[id];
                if (memVal != null)
                    strVal = memVal.ToString();
                bKeyPresent = true;
            }

            double dbl;
           

            bool isNumerical = double.TryParse(strVal, out dbl);

            bool isBoolean = (strVal == "False" || strVal == "false" || strVal == "True" || strVal =="true");


            if (!isNumerical  && !isBoolean && bKeyPresent)
              strVal = strVal.Substring(1, strVal.Length - 1).Replace("\"\"", "\"");

            Value value = new Value(strVal);
            
            return value;
        }

        public override Value VisitStringAtom(AbstractIfStmtParser.StringAtomContext context)
        {
            
            string str = context.GetText();
            str = str.Substring(1, str.Length - 1).Replace("\"\"", "\"");
            return new Value(str);
        }

        public override Value VisitNumberAtom(AbstractIfStmtParser.NumberAtomContext context)
        {
            return new Value(double.Parse(context.GetText()));
        }

        public override Value VisitBooleanAtom(AbstractIfStmtParser.BooleanAtomContext context)
        {
            string strVal;
            bool bVal = bool.Parse(context.GetText());
            if (bVal)
                strVal = "true";
            else
                strVal = "false";
            return new Value(strVal);
        }

        public override Value VisitNilAtom(AbstractIfStmtParser.NilAtomContext context)
        {
            return new Value(null);
        }

        public override Value VisitParExpr(AbstractIfStmtParser.ParExprContext context)
        {
            
            return this.Visit(context.expr());

        }

        public override Value VisitEqualityExpr(AbstractIfStmtParser.EqualityExprContext ctx)
        {

        Value left = this.Visit(ctx.expr(0));
        Value right = this.Visit(ctx.expr(1));

        switch (ctx.op.Type) {
            case AbstractIfStmtParser.EQ:
                return left.isDouble() && right.isDouble() ?
                        new Value(Math.Abs(left.asDouble() - right.asDouble()) < SMALL_VALUE) :
                        new Value(left.Equals(right));
            case AbstractIfStmtParser.NEQ:
                return left.isDouble() && right.isDouble() ?
                        new Value(Math.Abs(left.asDouble() - right.asDouble()) >= SMALL_VALUE) :
                        new Value(!left.Equals(right));
            
        }

            return new Value(false);
    }
         
    public override Value VisitRelationalExpr(AbstractIfStmtParser.RelationalExprContext ctx) {

        Value left = this.Visit(ctx.expr(0));
        Value right = this.Visit(ctx.expr(1));

        if ((!left.isNumeric()) && right.isNumeric())
          return new Value(false);//Condition where double values are not defined
        if ((left.isNumeric()) && !right.isNumeric())
           return new Value(false);


       int ctxType = ctx.op.Type;

        switch(ctxType)
        {
            case AbstractIfStmtParser.LT:
                return new Value(left.asDouble() < right.asDouble());
            case AbstractIfStmtParser.LTEQ:
                return new Value(left.asDouble() <= right.asDouble());
            case AbstractIfStmtParser.GT:
                return new Value(left.asDouble() > right.asDouble());
            case AbstractIfStmtParser.GTEQ:
                return new Value(left.asDouble() >= right.asDouble());
            default:
                return new Value(false);

        }

        
       
                
        
    }

        
    public override Value VisitNotExpr(AbstractIfStmtParser.NotExprContext ctx) {
        Value value = this.Visit(ctx.expr());
        bool bVal = getBoolValue(value);
        return new Value(!bVal);
        //return new Value(!value.asBoolean());
    }

        public bool getBoolValue(Value evaluated)
        {
            bool bVal = true;
            string evalStr = evaluated.asString();
            string falseStr = "false\"";
            string strFalse = "False";

            int retVal = System.String.Compare(evalStr, strFalse, true);

            if (retVal == 0)
            {
                return false;
            }
            else
            {
                int newRetVal = System.String.Compare(evalStr, falseStr, true);
                if (newRetVal == 0)
                {
                    return false;
                }
            }

              return bVal;
         }
        
        public override Value VisitAndExpr(AbstractIfStmtParser.AndExprContext ctx) {
            Value left = this.Visit(ctx.expr(0));
            Value right = this.Visit(ctx.expr(1));
            bool leftBoolVal = getBoolValue(left);
            bool rightBoolVal = getBoolValue(right);
            bool andExprVal = leftBoolVal && rightBoolVal;
            return new Value(andExprVal);
        }


        public override Value VisitOrExpr(AbstractIfStmtParser.OrExprContext ctx)
        {
            Value left = this.Visit(ctx.expr(0));
            Value right = this.Visit(ctx.expr(1));

            bool leftBoolVal = getBoolValue(left);
            bool rightBoolVal = getBoolValue(right);
            bool orExprVal = leftBoolVal || rightBoolVal;
            return new Value(orExprVal);
            //return new Value(left.asBoolean() || right.asBoolean());
        }

        // log override
        
     
        public override Value VisitIf_stat(AbstractIfStmtParser.If_statContext context)
        {
            AbstractIfStmtParser.Condition_blockContext[] conditions =  context.condition_block();
            bool evaluatedBlock = false;
            int i = 0;
            int size = conditions.GetLength(0);
            while(i < size) 
            {
               AbstractIfStmtParser.Condition_blockContext condition = conditions[i++];
                
               Value evaluated = this.Visit(condition.expr());
                
               bool evalVal = getBoolValue(evaluated);
                              
                                           
                if(evalVal)  {
                    evaluatedBlock = true;
                    // evaluate this block whose expr==true
                   this.Visit(condition.stat_block());
                    
                    break;
                }
            }

            if(!evaluatedBlock && context.stat_block() != null) {
                // evaluate the else-stat_block (if present == not null)
                this.Visit(context.stat_block());
             }

            return new Value(false);
    }


 }
    
}
