using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page124Drill
{
    class Employee : Person, IQuittable
    {
        public void Quit(Employee employee)
        {
            Console.WriteLine("Quitting program");
            Console.ReadLine();
            System.Environment.Exit(1);
        }
        
    }
    
        
}
