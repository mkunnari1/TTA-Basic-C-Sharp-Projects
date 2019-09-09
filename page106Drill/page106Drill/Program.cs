using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page106Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, 55, 66, 77, 88, 99, 123, 456, 789, 741, 852, 963 };

                Console.WriteLine("Welcome user to the Thuder Dome!!! \noh... I see, yes yes I got it. \nWhat I meant to say was \nWelcome user to the division game!!! \nProvide me with a number and I will use it to divide all the numbers on my list by. \nPretty neat yes?");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You provided me with the number " + userInput + " I will now do great math!");
                foreach(int number in numbers)
                {
                    int answer = number / userInput;
                    Console.WriteLine(answer);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("My dude that is not a number, please input a number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero friend, that is not how math works");
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("I have emerged from the try/catch block and continued with the program execution! That's basically a win.");
            Console.ReadLine();
            
        }
    }
}
