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
                int ai = random.Next(1, 4);
                pc = Convert.ToString(ai);

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
                switch (usr)
                {
                    case "ROCK":
                        if (pc == "PAPER") Console.WriteLine("You Lose!");
                        if (pc == "SCISSORS") Console.WriteLine("You Win!");
                        if (pc == "ROCK") Console.WriteLine("It's a draw!");
                        break;

                    case "SCISSORS":
                        if (pc == "PAPER") Console.WriteLine("You Win!");
                        if (pc == "SCISSORS") Console.WriteLine("It's a draw!");
                        if (pc == "ROCK") Console.WriteLine("You Lose!");
                        break;

                    case "PAPER":
                        if (pc == "PAPER") Console.WriteLine("It's a draw!");
                        if (pc == "SCISSORS") Console.WriteLine("You Lose!");
                        if (pc == "ROCK") Console.WriteLine("You Win!");
                        break;
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