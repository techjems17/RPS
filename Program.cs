using System;

namespace Rps
{
    class Program
    {
        static void Main(string[] args)
        {
            //establish vars
            string authorName = "Jordan Smith";
            string version = "1.0.0";
            string gameName = "Rock Paper Scissors";

            //change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            //create app info
            Console.WriteLine("{0}: Version {1} by {2}", gameName, version, authorName);

            //reset text color
            Console.ResetColor();

            //ask for player name
            Console.WriteLine("What is your name?");

            //read players name
            string playerName = Console.ReadLine();

            //greet player
            Console.WriteLine("Hello {0}, let's play Rock Paper Scissors!", playerName);

            //run when playing
            while (true) {

                //keep track of wins
                int rounds = 0;
                int computerPoints = 0;
                int playerPoints = 0;
                string winner = "";

                while (rounds != 5)
                {

                    //computer randomly chooses object
                    string[] choices = { "rock", "paper", "scissors" };

                    Random random = new Random();

                    int totalChoices = random.Next(3);

                    string computerChoice = choices[totalChoices];

                    //initialize guess
                    string playerChoice = "";

                    //ask player to choose an object
                    Console.WriteLine("Rock, Paper, or Scissors?");

                    //determine winner of round
                    //display computer's choice and users choice
                    playerChoice = Console.ReadLine().ToLower();

                    if (playerChoice == "scissor") {
                        Console.WriteLine("scissor is a verb, please use the noun scissors.");
                        continue;
                    }

                    if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
                    {
                        Console.WriteLine("Please choose rock, paper, or scissors only!");

                        continue;
                    }

                    if (playerChoice == "rock" && computerChoice == "scissors")
                    {
                        Console.WriteLine("computer: " + computerChoice + "; your choice: " + playerChoice);
                        Console.WriteLine("Winner: " + playerName);
                        playerPoints++;
                    }

                    else if (playerChoice == "rock" && computerChoice == "paper")
                    {
                        Console.WriteLine("computer: " + computerChoice + "; your choice: " + playerChoice);
                        Console.WriteLine("Winner: computer");
                        computerPoints++;
                    }

                    else if (playerChoice == "paper" && computerChoice == "scissors")
                    {
                        Console.WriteLine("computer: " + computerChoice + "; your choice: " + playerChoice);
                        Console.WriteLine("Winner: computer");
                        computerPoints++;
                    }

                    else if (playerChoice == "paper" && computerChoice == "rock")
                    {
                        Console.WriteLine("computer: " + computerChoice + "; your choice: " + playerChoice);
                        Console.WriteLine("Winner: " + playerName);
                        playerPoints++;
                    }

                    else if (playerChoice == "scissors" && computerChoice == "rock")
                    {
                        Console.WriteLine("computer: " + computerChoice + "; your choice: " + playerChoice);
                        Console.WriteLine("Winner: computer");
                        computerPoints++;
                    }

                    else if (playerChoice == "scissors" && computerChoice == "paper")
                    {
                        Console.WriteLine("computer: " + computerChoice + "; your choice: " + playerChoice);
                        Console.WriteLine("Winner: " + playerName);
                        playerPoints++;
                    }

                    else
                    {
                        Console.WriteLine("computer: " + computerChoice + "; your choice: " + playerChoice);
                        Console.WriteLine("Winner: Draw");
                    }

                    rounds++;

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine("Computer: " + computerPoints + "; " + playerName + ": " + playerPoints + "; round: " + rounds + "/5");

                    Console.ResetColor();

                    continue;
                }

                //dislay winner of game
                if (computerPoints > playerPoints) 
                {
                    winner = "Computer";
                }

                else if (computerPoints < playerPoints)
                {
                    winner = playerName;
                }

                else {
                    winner = "Draw, no winner";
                }

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("The winner is " + winner + ".");

                Console.ResetColor();

                //ask if want to play again
                Console.WriteLine("Would you like to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }

                else if (answer == "N") {
                    Console.WriteLine("Thank you for playing!");
                    return;
                }

                else {
                    Console.WriteLine("Invalid answer!, Goodbye!");
                    return;
                }
            }
        }
    }
}