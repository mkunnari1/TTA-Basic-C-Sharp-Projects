using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page117Drill
{
    public class mathClass
    {
        public static void Divisor()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = num1 / 2;
            Console.WriteLine("You entered " + num1 + ", divide that by 2 and we get: " + num2);
        }

        public static void Divisor(out int a, out int b)
        {
            a = 15;
            b = 25;
            a += a;
            b += b;
        }
    }
}
