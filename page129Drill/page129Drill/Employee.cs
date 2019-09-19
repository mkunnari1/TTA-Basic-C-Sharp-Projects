using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page129Drill
{
    public class Employee
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int empId { get; set; }

        public static Employee operator ==(Employee employee, Employee employee2)
        {
            if (employee.empId == employee2.empId)
            {
                Console.WriteLine("The employee ID's are a match");
                Console.ReadLine();
                System.Environment.Exit(1);
                return employee;
            }
            else
            {
                Console.WriteLine("The employee ID's are NOT a match");
                Console.ReadLine();
                System.Environment.Exit(1);
                return employee;
            }
        }

        public static Employee operator !=(Employee employee, Employee employee2)
        {
            if (employee.empId != employee2.empId)
            {
                Console.WriteLine("The employee ID's are NOT a match");
                Console.ReadLine();
                System.Environment.Exit(1);
                return employee;
            }
            else
            {
                Console.WriteLine("The employee ID's are a match");
                Console.ReadLine();
                System.Environment.Exit(1);
                return employee;
            }
        }

    }
}
