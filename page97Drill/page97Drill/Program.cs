using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page97Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            string begg = "This is the ";
            string mid = "beginning of ";
            string end = " story!";

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + begg + mid + name + "'s" + end);
             string capName = name.ToUpper();
            Console.WriteLine("Hello " + capName + ". The time has come for you to write your own adventure.\nPlease write your first sentence.");
            string firSent = Console.ReadLine();
            Console.WriteLine("Alright " + name + " that's a fun first sentence but I need more to complete this.");
            string secSent = Console.ReadLine();
            Console.WriteLine("Cool stuff " + name + " keep it coming!");
            string thrSent = Console.ReadLine();
            Console.WriteLine(capName + " Give it to meeee!!!!");
            string fourSent = Console.ReadLine();
            Console.WriteLine("Wow " + name + " this is one craaaazy story, hit me with the finisher.");
            string finSent = Console.ReadLine();
            Console.WriteLine("That was crazy, let's see what you came up with.");

            StringBuilder story = new StringBuilder();

            story.Append(firSent);
            story.AppendLine(secSent);
            story.AppendLine(thrSent);
            story.AppendLine(fourSent);
            story.AppendLine(finSent);

            Console.WriteLine(story);

            Console.WriteLine("Alllllrrrright " + name + " seeing that all put together has inspired some feelings for sure...\n" +
                "I think we got what we needed, we'll call you don't worry about calling us.  Thank you... Bye");

            Console.ReadLine();


        }
    }
}
