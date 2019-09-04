using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page67Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            int p1Hourly = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            int p1Hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            int p2Hourly = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            int p2Hours = int.Parse(Console.ReadLine());
            int p1Weekly = p1Hourly * p1Hours;
            int p2Weekly = p2Hourly * p2Hours;
            Console.WriteLine("Weekly salary of Person1:\n " + p1Weekly);
            Console.WriteLine("Weekly salary of Person2:\n " + p2Weekly);
            bool highSal = p1Weekly > p2Weekly;
            Console.WriteLine("Does Person 1 make more money than Person2?\n" + highSal);
            Console.ReadLine();

        }
    }
}
