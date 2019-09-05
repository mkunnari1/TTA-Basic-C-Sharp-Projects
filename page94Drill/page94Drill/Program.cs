using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page94Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There would you like to play a game?");
            string playGame = Console.ReadLine();
            do
            {
                if (playGame == "no" || playGame == "No")
                {
                    Console.WriteLine("I see... Well that is disapointing...");
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }
                else if (playGame != "yes" || playGame != "Yes")
                {
                    Console.WriteLine("I didn't understand that, please answer yes or no.");
                    playGame = Console.ReadLine();
                }
            }
            while (playGame != "Yes" || playGame != "yes");

            Console.WriteLine("Wonderful! Let's get started.");
            Console.WriteLine("First pick a number between 48 and 70");
            int pickNum = Convert.ToInt32(Console.ReadLine());
            bool winStip = pickNum == 47;

            while (winStip != true)
            {
                switch() 
                
            }
        }
    }
}
