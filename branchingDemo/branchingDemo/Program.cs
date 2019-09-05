using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branchingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int curtemp = 71;
            int roomtemp = 70;

            if(curtemp == roomtemp)
            {
                Console.WriteLine("it is exactly room temp.");
            }
            else if(curtemp > roomtemp)
            {
                Console.WriteLine("it is warmer than room temp.");
            }
            else
            {
                Console.WriteLine("it is not exactly room temp.");
            }

            Console.ReadLine();

            //one line if statement where the left side of the : is for true and the right side is for false see below for details.
            string compResult = curtemp == roomtemp ? "It is room temp" : "it is not room temp";
            Console.WriteLine(compResult);
            Console.ReadLine();
        }
    }
}
