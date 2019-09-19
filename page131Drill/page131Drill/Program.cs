using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page131Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things.Add("joe");
            employee.Things.Add("john");
            employee.Things.Add("joan");
            employee.Things.Add("joey");
            employee.Things.Add("joseph");
            employee.Things.Add("tony");

            Employee<int> employee1 = new Employee<int>();
            employee1.Things.Add(1);
            employee1.Things.Add(2);
            employee1.Things.Add(3);
            employee1.Things.Add(4);
            employee1.Things.Add(7);
            employee1.Things.Add(96);

            foreach(string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            foreach(int thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
