using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page156Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("\nHey There can i get a number?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In {0} hours it will be " + DateTime.Now.AddHours(userInput), userInput);
            Console.ReadLine();
        }
    }
}
