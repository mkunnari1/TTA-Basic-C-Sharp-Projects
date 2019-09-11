using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page111Drill
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hail and well met weary user.  \nYou have arrived at the kingdom of random math operations. " +
               "\nPlease supply me with a number!");

                int userInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("I hath taken the number you bestowed upon me and added 10 to it! \nThe answer is: " +Calculations.Additions(userInput));
                //Console.WriteLine("\nI have yet to show you my true numeric powers! \nGIVE ME ANOTHER NUMBER!!!!!!");
                Console.WriteLine("Your number has been multiplied by a random number between 0 and 100!!! \nBehold the glory of math: "
                   + Calculations.Multiply(userInput));
                //Console.WriteLine("\nStill don't see the majestic nature of mathmatics?\nANOTHER NUMBER NAIVE!!!!!!");
                Console.WriteLine("GAZE UPON MY MIGHT!!!! MATHHHHHHH HAS BEEN DONE!\nBOW BEFORE OUR NUMBERS PEASANT!\n" + Calculations.wholeLottaMath(userInput));
                Console.WriteLine("Thank you for visiting the kingdom of random math operations have a great day!");


                

            }
            catch (FormatException)
            {
                Console.WriteLine("Bruh... those are letters. Please leave my kingdom... \nYOU HAVE DIED\nGAME OVER");
            }
            finally
            {
                Console.ReadLine();
            }
           
        }
    }
}
