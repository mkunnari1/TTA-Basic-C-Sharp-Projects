using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page115Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Well hello there user! I'd like to get some numbers from you. \nYou can either provide me with one number or two, \nit's all up to you");
            Console.WriteLine("Let's get that first number.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nAlright time for a second number if you'd like. \nRemember you can either leave it blank or provide a number!");
            
            try
            {
                int input2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(mathClass.DoIt(input1, input2));

            }
            catch (FormatException)
            {
                Console.WriteLine(mathClass.DoIt(input1));
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
