using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page124Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee student = new Employee();
            student.FirstName = "Sample";
            student.LastName = "Student";

            student.SayName();
            Console.ReadLine();
        }
    }
}
