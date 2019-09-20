using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page140Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.fName = "joe";
            employee.lName = "smith";
            employee.empId = 1;

            Employee employee1 = new Employee();
            employee1.fName = "tony";
            employee1.lName = "montana";
            employee1.empId = 2;

            Employee employee2 = new Employee();
            employee2.fName = "jim";
            employee2.lName = "bob";
            employee2.empId = 3;

            Employee employee3 = new Employee();
            employee3.fName = "joe";
            employee3.lName = "shmo";
            employee3.empId = 4;

            Employee employee4 = new Employee();
            employee4.fName = "jimbo";
            employee4.lName = "browflowski";
            employee4.empId = 5;

            Employee employee5 = new Employee();
            employee5.fName = "johnathan";
            employee5.lName = "van ness";
            employee5.empId = 6;

            Employee employee6 = new Employee();
            employee6.fName = "bobby";
            employee6.lName = "burk";
            employee6.empId = 7;

            Employee employee7 = new Employee();
            employee7.fName = "latrice";
            employee7.lName = "royale";
            employee7.empId = 8;

            Employee employee8 = new Employee();
            employee8.fName = "ru";
            employee8.lName = "paul";
            employee8.empId = 9;

            Employee employee9 = new Employee();
            employee9.fName = "michelle";
            employee9.lName = "visage";
            employee9.empId = 10;

            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);

            List<Employee> joes = new List<Employee>();

            foreach ( Employee emp in employees)
            {
                if(emp.fName == "joe")
                {
                    joes.Add(emp);
                }
            }
            foreach (Employee joe in joes)
            {
                Console.WriteLine("First Name: "+joe.fName+" Last Name: "+joe.lName+" Employee ID#: "+joe.empId);
                
            }
            Console.ReadLine();



        }
    }
}
