using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page75Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? please answer yes or no");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = int.Parse(Console.ReadLine());
            bool qual = age > 15 && (dui == "no" || dui == "No") && tickets <= 3;
            Console.WriteLine("Qualified? \n" + qual);
            Console.ReadLine();
        }
    }
}
