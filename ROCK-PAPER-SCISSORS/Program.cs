using System;

namespace MatiApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data
            String usr;
            String pc;
            bool plyAgain=false;

            //Main loop to repeat the game
            do
            {
                //Users move
                Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                do
                {
                    usr = Console.ReadLine();
                    usr = usr.ToUpper();
                } while (usr != "ROCK" && usr != "PAPER" && usr != "SCISSORS");

                //AI move
                Random random = new Random();
                random.Next(1, 4);
                pc = Convert.ToString(random);

                switch (pc)
                {
                    case "1":
                        pc = "ROCK";
                        break;

                    case "2":
                        pc = "PAPER";
                        break;

                    case "3":
                        pc = "SCISSORS";
                        break;
                }

                //Output
                Console.WriteLine("Player: " + usr);
                Console.WriteLine("Computer " + pc);

                //Win condition
                if (usr == pc)
                {
                    Console.WriteLine("It's a draw!");
                }
                if (usr == "ROCK" && pc == "SCISSORS")
                {
                    Console.WriteLine("You win!");
                }
                if (usr == "ROCK" && pc == "PAPER")
                {
                    Console.WriteLine("You lose!");
                }
                if (usr == "SCISSORS" && pc == "PAPER")
                {
                    Console.WriteLine("You win!");
                }
                if (usr == "SCISSORS" && pc == "ROCK")
                {
                    Console.WriteLine("You lose!");
                }
                if (usr == "PAPER" && pc == "SCISSORS")
                {
                    Console.WriteLine("You lose!");
                }
                if (usr == "PAPER" && pc == "ROCK")
                {
                    Console.WriteLine("You win!");
                }

                //Asks if want to play again
                Console.Write("Would you like to play again? (Y/N): ");
                String play;
                do
                {
                    play = Console.ReadLine();
                } while (play != "y" && play !="n");

                if (play == "y")
                {
                    plyAgain = true;
                }
                else if (play == "n")
                {
                    plyAgain = false;
                }
            } while(plyAgain==true);
        }
    }
}