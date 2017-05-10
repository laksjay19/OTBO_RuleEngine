using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Configuration;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;




namespace OTBO_RuleEngine
{
    public class RuleEngine
    {
        protected string m_strRuleAction;
        protected string m_strError;
        protected EvalVisitor m_Visitor;

        /*Constructor
         * Initialize m_pVisitor by creating EvalVisitor object
         * 
         * 
        */
        public RuleEngine()
        {
            m_Visitor = new EvalVisitor();
        }
        public string getRuleAction()
        {
            return m_strRuleAction;
        }

        public string getError()
        {
            return m_strError;
        }

        public void setRuleParams( string strParamName, string strParamValue)
        {
            if(m_Visitor != null)
            {
                m_Visitor.AddToDictionary(strParamName, strParamValue);
            }
        }

        public void updateRuleParams(string strParamName, string strParamValue)
        {
            if (m_Visitor != null)
            {
                m_Visitor.UpdateDictionary(strParamName, strParamValue);
            }
        }
        public void evaluate(string strRuleBody, bool bFile=false)
        {
            try {
                AntlrInputStream inputStream;
                if (bFile)
                {
                    // convert string to stream
                    byte[] byteArray = Encoding.UTF8.GetBytes(strRuleBody);
                    //byte[] byteArray = Encoding.ASCII.GetBytes(contents);
                    MemoryStream stream = new MemoryStream(byteArray);


                    StreamReader fileStream = new StreamReader(stream);
                    inputStream = new AntlrInputStream(fileStream);
                }
                else
                    inputStream = new AntlrInputStream(strRuleBody);

                AbstractIfStmtLexer lexer = new AbstractIfStmtLexer(inputStream);
                AbstractIfStmtParser parser = new AbstractIfStmtParser(new CommonTokenStream(lexer));
                IParseTree tree = parser.parse();

                m_Visitor.Visit(tree);
                m_strRuleAction = m_Visitor.strReturnValue;
            }
            catch (Exception e) {
                m_strError = "Rule Evaluation error";
            }            

        }

    }
    public class CMSConfigurationManager
    {
        /*public string getValue(string strInputParam)
        {
           

            //Open the configuration file using the dll location
           Configuration myDllConfig = ConfigurationManager.OpenExeConfiguration(this.GetType().Assembly.Location);

            // Get the appSettings section
            AppSettingsSection myDllConfigAppSettings =
           (AppSettingsSection)myDllConfig.GetSection("appSettings");

            // return the desired field 
            return myDllConfigAppSettings.Settings[strInputParam].Value;

            

            // return strOutputParam;
        }
        */

    }
}
