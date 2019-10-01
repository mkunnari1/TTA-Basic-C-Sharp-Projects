using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page165Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there user, I forget how old you are. What age did you turn or will turn this year?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            int yearOfBirth = DateTime.Now.Year - userAge;
            Console.WriteLine("Okay cool so you were born in " + yearOfBirth + " right?");
            Console.ReadLine();
        }
    }
}
