using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a simpe program

            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("your name is " + yourName + "!");
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite nubmer?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("your favorite number + 5 is " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 47;
            sbyte currentTemp = -23;
            char questionMark = '\u2103'; //this is the unicode character for a question mark.

            decimal moneyInBank = 100.5m;

            double heightinCm = 211.30202092;

            float secondsLeft = 2.62f;

            short temponMars = -341;


            int currentAge = 30;
            string yearsOld = currentAge.ToString();
            bool isRaining = true;
            string rainStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainStatus);
            Console.ReadLine();

        }
    }
}
