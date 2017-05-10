using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBO_RuleEngine
{
    public class Value
    {
        Object value;

        public Value(Object value)
        {
            this.value = value;
        }

        public Boolean asBoolean()
        {
         //return (Boolean)value;
            
         return (value is Boolean);
        }

        public bool asBool()
        {
            return (value is bool);
        }

        public Boolean isDouble()
        {
            return (value is Double);
        }

        public Boolean isNumeric()
        {
            double dbl;
            string strVal = this.ToString();
            bool isNumerical = double.TryParse(strVal, out dbl);
            return isNumerical;

        }

        public Double asDouble()
        {
            string strDbl = value.ToString();
            Double dblVal = System.Convert.ToDouble(strDbl);
;

            return dblVal;

           
        }

        public String asString()
        {
            // ????? String.valueOf(value)
            return value.ToString();
        }

       

        public override bool Equals(object obj)
        {
            if (value == obj)
            {
                return true;
            }

            if (value == null || obj == null)
            {
                return false;
            }

            string strThat = obj.ToString();

           

            Value that = new Value(strThat);

            return this.value.Equals(that.value);

        }

        public override int GetHashCode()
        {
            if (value == null)
            {
                return 0;
            }

            return base.GetHashCode();
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
