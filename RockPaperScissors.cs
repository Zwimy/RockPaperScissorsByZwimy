using System.Runtime.CompilerServices;

namespace Rock_Paper_Scissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play a game?");
            string request = Console.ReadLine()!;
            bool playGame = true;
            int gamesPlayed = 0;
            int gamesWon = 0;

            while (playGame)
            {

                if (request == "n" || request == "no" || request == "N" || request == "NO")
                {
                    playGame = false;
                    Thread.Sleep(500);
                    Console.WriteLine($"You played {gamesPlayed} and won {gamesWon} game(s).\nGoodbye! ");
                    Thread.Sleep(2000);
                    break;
                }
                const string rock = "rock";
                const string paper = "paper";
                const string scissors = "scissors";
                Thread.Sleep(500);
                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                string playerSelection = Console.ReadLine()!;
                gamesPlayed++;
                if (playerSelection == "r" || playerSelection == "rock")
                {
                    playerSelection = rock;
                }
                else if (playerSelection == "p" || playerSelection == "paper")
                {
                    playerSelection = paper;
                }
                else if (playerSelection == "s" || playerSelection == "scissors")
                {
                    playerSelection = scissors;
                }
                else
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Invalid input. Try again...");
                    gamesPlayed--;
                }
                Random random = new Random();
                int ComputerNum = random.Next(1, 4);
                string ComputerMove = "";
                switch (ComputerNum)
                {
                    case 1:
                        ComputerMove = rock;
                        break;
                    case 2:
                        ComputerMove = paper;
                        break;
                    case 3:
                        ComputerMove = scissors;
                        break;
                    default:
                        break;
                }
                Thread.Sleep(500);
                Console.WriteLine($"Computer chose {ComputerMove}.");
                Thread.Sleep(500);
                if (playerSelection == rock && ComputerMove == scissors || playerSelection == paper && ComputerMove == rock || playerSelection == scissors && ComputerMove == paper)
                {
                    Console.WriteLine("You win!");
                    gamesWon++;
                }
                else if (playerSelection == rock && ComputerMove == paper || playerSelection == paper && ComputerMove == scissors || playerSelection == scissors && ComputerMove == rock)
                {
                    Console.WriteLine("You lose!");
                }
                else if (playerSelection == rock && ComputerMove == rock || playerSelection == paper && ComputerMove == paper || playerSelection == scissors && ComputerMove == scissors)
                {
                    Console.WriteLine("Draw game!");
                }
                Thread.Sleep(500);
                Console.WriteLine("Do you want to play again?");
                request = Console.ReadLine()!;
                Thread.Sleep(1000);
            }
        }
    }
}