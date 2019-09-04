using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page57drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            Console.ReadLine();
            Console.WriteLine("What course are you on?\n");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number are you on?\n");
            ushort coursePageNum = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".\n");
            bool needsHelp = bool.Parse(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.\n");
            string posExper = Console.ReadLine();
            Console.WriteLine("Is there any other feecback you'd like to provide? Please be specific.\n");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?\n");
            ushort studyHours = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.ReadLine();

            
        }
    }
}
