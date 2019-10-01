using System;
using System.IO;
using Casino;
using Casino.TwentyOne;



namespace blackJack
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Gumbo and Marleau's Seaside Casino.  Let's start by getting your name.");
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}.  Would you like to join a game of Black Jack?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.ID = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\HP\OneDrive\Documents\C#-Projects\TTA-Basic-C-Sharp-Projects\blackJack\playerGUIDLog.txt", true))
                {
                    file.WriteLine(player.Name +" "+ player.ID);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security has been alerted to your fraudulent behavior, I think it's best you leave.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An Error occurred.  Please contact system administrator.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }
            Console.WriteLine("Feel free to look around the casino! Bye Felicia");
            Console.Read();


        }   
    }
}
