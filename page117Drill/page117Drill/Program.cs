using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page117Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number.");
            mathClass.Divisor();
            Console.ReadLine();

            int m;
            int k;

            mathClass.Divisor(out m, out k);

            Console.WriteLine("The value of m is now {0}", m);
            Console.WriteLine("The value of k is now {0}", k);
            Console.ReadLine();
        }
    }
}
