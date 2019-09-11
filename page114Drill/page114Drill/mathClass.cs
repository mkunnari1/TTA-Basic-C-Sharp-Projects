using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page114Drill
{
    public class mathClass
    {
        public static int DoIT (int num1)
        {
            int num2 = num1 / 2;
            return num2;
        }

        public static decimal DoIT( decimal num1)
        {
            int num2 = Decimal.ToInt32(num1 * 2);
            return num2;
        }

        public static string DoIT( string num1)
        {
            int num2 = Convert.ToInt32(num1);
            int num3 = num2 + 5;
            string num4 = Convert.ToString(num3);
            return num4;
            
        }
    }
}
