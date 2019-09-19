using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page129Drill
{
    class Program
    {

        static void Main(string[] args)
        {

            Employee employee = new Employee();
            employee.empId = 1;

            Employee employee2 = new Employee();
            employee2.empId = 2;

            Console.WriteLine(employee == employee2);
            Console.ReadLine();
        }
           
           
      
    }
}
