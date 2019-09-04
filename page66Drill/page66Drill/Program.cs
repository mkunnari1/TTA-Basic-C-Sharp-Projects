using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page66Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number.");
            long multNum = long.Parse(Console.ReadLine());
            long multNum2 = multNum * 50;
            Console.WriteLine("your number " + multNum + " multiplied by 50 is = " + multNum2);
            Console.WriteLine("Please give me another number.");
            long addNum = long.Parse(Console.ReadLine());
            long addNum2 = addNum + 25;
            Console.WriteLine("Your number " + addNum + " plus 25 is = " + addNum2);
            Console.WriteLine("Please give me another number.");
            decimal divNum = decimal.Parse(Console.ReadLine());
            decimal divNum2 = divNum / (decimal)(12.5);
            Console.WriteLine("Your number " + divNum + " divided by 12.5 is = " + divNum2);
            Console.WriteLine("Please give me another number.");
            long greaterNum = long.Parse(Console.ReadLine());
            bool greaterNum2 = greaterNum > 50;
            Console.WriteLine("Was the number you provided greater than 50? " + greaterNum2);
            Console.WriteLine("Please give me one final number.");
            long remNum = long.Parse(Console.ReadLine());
            int remNum2 = (int)remNum % 7;
            Console.WriteLine("If we take that final number and divide it by 7 it gives us a remainer of " + remNum2);
            Console.ReadLine();


        }
    }
}
