using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page115Drill
{
    public class mathClass
    {
        public static int DoIt(int num1, int optionalNum = 0)
        {
            int num2 = ((num1 + optionalNum) * 2) / 3;
            return num2;
        }
    }
}
