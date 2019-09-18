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
        public void Quit()
        {
            Console.WriteLine("Hello there friend Welcome to the end of the program, \nPlease give us a rating, 1-5");
            int rating = Convert.ToInt32(Console.ReadLine());
            if (rating >= 3 && rating <= 5)
            {
                Console.WriteLine("Thank you for your feedback we appreciate it");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            else if (rating < 3)
            {
                Console.WriteLine("Sorry that we did not meet your expectations, leave a review so next time we know what to do better!");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("So I can see that you don't like following directions. Your feedback has been discarded, thanks for nothing.");
                Console.ReadLine();
                System.Environment.Exit(1);
            }

        }
        
    }
    
        
}
