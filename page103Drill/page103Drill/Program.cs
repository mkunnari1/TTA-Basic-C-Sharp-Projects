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
                cool = false;
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

            for (int j = 0; j < names.Count; j++)
            {
                string name = names[j];
                if (name == guess)
                {
                    Console.WriteLine("Nice work! " + name + " is on my list! It resides in index: " + j);
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }

            }
            Console.WriteLine("Sorry but the name you guessed was not on my list.");
            Console.ReadLine();

            //9 10  

            List<string> names2 = new List<string>() { "joe", "tony", "tyler", "john", "matt", "alicia", "jane", "nancy", "tim", "joe" };
            List<string> names3 = new List<string>();
            Console.WriteLine("User, Please enter a name to search for.");
            string guess2 = Console.ReadLine();

            for (int i = 0; i < names2.Count; i++)
            {
                string name2 = names2[i];
                string name3 = name2 + " " + i;

                if (name2 == guess2)
                {
                    names3.Add(name3);
                }
            }

            foreach (string name in names3)
            {
                Console.WriteLine(name);
            }
            if (names3.Count == 0)
            {
                Console.WriteLine("Sorry but " + guess2.ToUpper() + " is not contained in this database");
            }



            Console.ReadLine();

            //11

            List<string> names4 = new List<string>()
            {
                "joe", "tony", "tyler", "john", "matt", "alicia", "jane", "nancy", "tim", "joe"
            };
            List<string> unique = new List<string>();
            List<string> duplicates = new List<string>();

            foreach ( string name in names4)
            {
                if (!unique.Contains(name))
                {
                    unique.Add(name);
                }
                else
                {
                    duplicates.Add(name);
                }
            }

            foreach (string j in unique)
            {
                Console.WriteLine(j);
            }

            foreach (string k in duplicates)
            {
                Console.WriteLine(k + " is a duplicate value");
            }
           
            Console.ReadLine();
        }
    }
}
