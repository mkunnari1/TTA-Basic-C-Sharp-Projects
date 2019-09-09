using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page103Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] adLibs = { "This is an interesting word: ", "but ", "is also a not interesting word, or at least not as much so as " };
            Console.WriteLine("Hey there, can I get a word?");
            string userWord = Console.ReadLine();

            for (int i = 0; i < adLibs.Length; i++)
            {
                adLibs[i] = adLibs[i] + userWord;
            }

            for (int j = 0; j < adLibs.Length; j++)
            {
                Console.WriteLine(adLibs[j]);
            }

            Console.ReadLine();

            //2
            bool cool = true; //could have just used "while(true)" but wanted to have some fun with it, also could have just done an infite for loop but again just having fun with the course.
            while (cool)
            {
                for (int k = 1; k > 0; k++)
                {
                    Console.WriteLine("i like dogs");
                }
                Console.ReadLine();
            }

            //3
            bool cool = true;
            while (cool)
            {
                for (int k = 1; k < 10; k++) //changed the 0 to a 10 so the loop will stop.
                {
                    Console.WriteLine("i like dogs");

                }
                Console.ReadLine();
            }

            //4
            for (int k = 1; k < 10; k++)
            {
                Console.WriteLine("i like dogs");

            }
            Console.ReadLine();

            //5
            for (int k = 1; k <= 10; k++)
            {
                Console.WriteLine("i like dogs a lot");

            }
            Console.ReadLine();

            //6 7 8
            List<string> names = new List<string>() { "joe", "tony", "tyler", "john", "matt", "alicia", "jane", "nancy", "tim" };

            Console.WriteLine("I have a list of names can you guess any of them? Please give me a name.");
            string guess = Console.ReadLine();

            foreach (string name in names)
            {
                if (guess == name)
                {
                    Console.WriteLine("you guessed " + guess + " that name is on the list in index: " + names.IndexOf(name));
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("you guessed " + guess + " that name is not on the list please try again.");
                    break;
                }
            }
            Console.ReadLine();

            //9 10 couldnt get it to list the index of both occurences, always just prints the first occurence of the duplicate, used Index of but I know there must be a better way that works

            List<string> names2 = new List<string>() { "joe", "tony", "tyler", "john", "matt", "alicia", "jane", "nancy", "tim", "joe" };
            Console.WriteLine("User, Please enter a name to search for.");
            string guess2 = Console.ReadLine();

            foreach (string name2 in names2)
            {
                if (name2 == guess2)
                {
                    Console.WriteLine(guess2 + guess2.IndexOf(name2));
                }
            }

            Console.ReadLine();

            //11

            List<string> names3 = new List<string>()
            {
                "joe", "tony", "tyler", "john", "matt", "alicia", "jane", "nancy", "tim", "joe"
            };
            var hashset = new HashSet<string>();

            foreach( string name3 in names3)
            {
                if (!hashset.Add(name3))
                {
                    Console.WriteLine("List contains duplicate value \"" + name3 + "\"");
                    break;
                }
               
            }
            Console.ReadLine();
        }
    }
}
