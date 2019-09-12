using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page124Drill
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static void SayName(string FirstName, string LastName)
        {
            Console.WriteLine("Name: {0} {1}" + FirstName + LastName);
        }
    }
}
