using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page120Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee student1 = new Employee();
            student1.FirstName = "Sample";
            student1.LastName = "Student";

            student1.SayName();
            Console.ReadLine();
        }
    }
}
