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
            bool startGame = playGame == "Yes" || playGame == "yes";
            do
            {
                if (playGame == "no" || playGame == "No")
                {
                    Console.WriteLine("I see... Well that is disapointing...");
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }
                else if (playGame == "yes" || playGame == "Yes")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("I didn't understand that, please answer yes or no.");
                    playGame = Console.ReadLine();
                }
            }
            while (!startGame);

            Console.WriteLine("Wonderful! Let's get started.");
            Console.WriteLine("First pick a number between 48 and 70");
            int pickNum = Convert.ToInt32(Console.ReadLine());
            bool winStip = pickNum == 47;

            while (!winStip)
            {
                switch (pickNum)
                {
                    case 49:
                        Console.WriteLine("49 is barely between 48 and 70 but you're so close to the answer. Try again!");
                        Console.WriteLine("Please guess another number.");
                        pickNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 59:
                        Console.WriteLine("Wow we have a literalist in the house, nice try but you can't win that easy. Try again!");
                        Console.WriteLine("Please guess another number.");
                        pickNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 69:
                        Console.WriteLine("Get your mind out of the gutter, who are you? Rob Gronkowski (Still an amazing TE by the way even if he is juvenille)");
                        Console.WriteLine("Please guess another number.");
                        pickNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Have you tried 47? I know it's not in the range but it is a great number.");
                        Console.WriteLine("Please guess another number.");
                        pickNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 47:
                        Console.WriteLine("You were bound to arrive here eventually! good job you have won the game! \n(insert victory noises here or something...)");
                        Console.ReadLine();
                        System.Environment.Exit(1);
                        break;
                } 
                
            }
        }
    }
}
