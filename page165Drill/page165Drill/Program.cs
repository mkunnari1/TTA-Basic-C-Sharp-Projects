using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page165Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there user, I forget how old you are. What age did you turn or will turn this year?");

            try
            {
                uint userAge = Convert.ToUInt32(Console.ReadLine());
                if (userAge == 0)
                {
                    Console.WriteLine("ummmm excuse me, but there is no way that you are 0 years old. get outta here.");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    int yearOfBirth = DateTime.Now.Year - Convert.ToInt32(userAge);
                    Console.WriteLine("So that means you were born in " + yearOfBirth + "!");
                    Console.ReadLine();
                        
                }

            }
            catch (OverflowException)
            {
                Console.WriteLine("Positive numbers only, you can't be born in the future and be using this program today.");
                Console.ReadLine();
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter your age in digits only.");
                Console.ReadLine();
                return;
            }
        }
    }
}
