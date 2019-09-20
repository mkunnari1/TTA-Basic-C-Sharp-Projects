using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page134Drill
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there user, What day of the week is it?");
            string day = Console.ReadLine();
            DaysOfTheWeek weekDay;
            try
            {

                if (Enum.TryParse(day, true, out weekDay))
                {
                    if (Enum.IsDefined(typeof(DaysOfTheWeek), weekDay))
                    {
                        Console.WriteLine("Wow I can't believe it's {0} already", weekDay); 
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
                
                
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
