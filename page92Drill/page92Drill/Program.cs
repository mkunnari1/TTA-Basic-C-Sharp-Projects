using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page92Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight.");
            int pckwght = Convert.ToInt32(Console.ReadLine());
            if(pckwght > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            Console.WriteLine("Please enter the package width.");
            int pckwdth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height");
            int pckhght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height");
            int pcklen = Convert.ToInt32(Console.ReadLine());
            if ((pckwdth + pckhght + pcklen) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            int totalCost = ((pckwdth + pckhght + pcklen) * pckwght) / 100;
            Console.WriteLine("Estimated shipping cost for this package is: $" + totalCost);
            Console.ReadLine();
        }
    }
}
