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
            Employee employee = new Employee();
            Console.WriteLine("Pick a number any number");
            int numPick = Convert.ToInt32(Console.ReadLine());
            if(numPick < 15)
            {
                employee.Quit();
            }
            else
            {
                employee.Quit(employee);
            }
            
            
        }
    }
}
