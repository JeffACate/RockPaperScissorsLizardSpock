using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        Player player1;
        Player player2;
        Random rng;
        int round;
        bool winner;
        bool playAgain;
        List<string> history;

        public Game()
        {
            history = new List<string>();
            rng = new Random();
            winner = false;
            playAgain = true;
            round = 0;
        }

        public void RunGame()
        {

            Console.WriteLine();
            DisplayGame();
            SetPlayers();
            while (playAgain == true)
            {

                while (winner == false)
                {

                    round++;
                    Console.Clear();
                    DisplayHistory();
                    player1.ChooseGesture();
                    Console.Clear();
                    DisplayHistory();
                    player2.ChooseGesture();
                    CompareChoices();
                    winner = CheckGameWinner();
                }
                Console.Clear();
                DisplayHistory();
                playAgain = AskPlayAgain();

                winner = false;
                round = 0;
                Console.Clear();
                history.Clear();
            }
            void DisplayGame()
            {
                Console.WriteLine("     Welcome to Rock Paper Scissors Lizard Spock!!" + "\n\n" +
                                    "     These Are the rules to the game:\n");
                Console.WriteLine(
                                    "     +-------------------------------------+" + "\n" +
                                    "     | Rock      | crushes     |  Scissors |" + "\n" +
                                    "     |-----------|-------------|-----------|" + "\n" +
                                    "     | Scissors  | cuts        |  Paper    |" + "\n" +
                                    "     |-----------|-------------|-----------|" + "\n" +
                                    "     | Paper     | covers      |  Rock     |" + "\n" +
                                    "     |-----------|-------------|-----------|" + "\n" +
                                    "     |  Rock     | crushes     |  Lizard   |" + "\n" +
                                    "     |-----------|-------------|-----------|" + "\n" +
                                    "     |  Lizard   | poisons     |  Spock    |" + "\n" +
                                    "     |-----------|-------------|-----------|" + "\n" +
                                    "     |  Spock    | smashes     |  Scissors |" + "\n" +
                                    "     |-----------|-------------|-----------|" + "\n" +
                                    "     |  Scissors | decapitates |  Lizard   |" + "\n" +
                                    "     |-----------|-------------|-----------|" + "\n" +
                                    "     |  Lizard   | eats        |  Paper    |" + "\n" +
                                    "     |-----------|-------------|-----------|" + "\n" +
                                    "     |  Paper    | disproves   |  Spock    |" + "\n" +
                                    "     |-----------|-------------|-----------|" + "\n" +
                                    "     |  Spock    | vaporizes   |  Rock     |" + "\n" +
                                    "     +-------------------------------------+" + "\n");
            }

            void DisplayHistory()
            {
                DisplayGame();
                Console.WriteLine("     Round {0}  | {1}: {2} | {3}: {4}\n", round, player1.name, player1.score, player2.name, player2.score);
                foreach (string round in history)
                {
                    Console.WriteLine(round);
                }
                Console.WriteLine();
            }
            void SetPlayers()
            {
                Console.Write("     How many players are playing? ");
                bool invalidInput = true;
                char players = Console.ReadKey().KeyChar;
                Console.WriteLine();
                while (invalidInput)
                {
                    if (players == '0' ||
                        players == '1' ||
                        players == '2')

                    {
                        invalidInput = false;
                    }
                    else
                    {
                        Console.Clear();
                        DisplayGame();
                        Console.WriteLine("     How many players are playing? " + players.ToString());
                        Console.WriteLine("     Invalid number of players");
                        Console.Write("     How many players are playing? ");
                        players = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                    }
                }

                Console.Clear();
                DisplayGame();
                Console.WriteLine("     How many players are playing? " + players.ToString());
                switch (players)
                {
                    case '0':
                        player1 = new Computer("Computer 1", rng);
                        player2 = new Computer("Computer 2", rng);
                        break;
                    case '1':
                        Console.Write("     What is Player 1's name? ");
                        player1 = new Human(Console.ReadLine());
                        player2 = new Computer("Computer 1", rng);
                        break;
                    case '2':
                        Console.Write("     What is Player 1's name? ");
                        player1 = new Human(Console.ReadLine());
                        Console.Write("     What is player 2's name? ");
                        player2 = new Human(Console.ReadLine());
                        break;
                }
            }

            void CompareChoices()
            {

                //Rock
                if (player1.gesture == "rock" && (player2.gesture == "scissors" || player2.gesture == "lizard"))
                {
                    history.Add($"     {player1.name} wins round {round}!! {player1.name} chose {player1.gesture} | {player2.name} chose {player2.gesture}");
                    player1.score++;
                }
                //Paper
                else if (player1.gesture == "paper" && (player2.gesture == "spock" || player2.gesture == "rock"))
                {
                    Console.WriteLine($"     {player1.name} wins this round!!");
                    history.Add($"     {player1.name} wins round {round}!! {player1.name} chose {player1.gesture} | {player2.name} chose {player2.gesture}");
                    player1.score++;
                }
                //Scissors
                else if (player1.gesture == "scissors" && (player2.gesture == "paper" || player2.gesture == "lizard"))
                {
                    Console.WriteLine($"     {player1.name} wins this round!!");
                    history.Add($"     {player1.name} wins round {round}!! {player1.name} chose {player1.gesture} | {player2.name} chose {player2.gesture}");
                    player1.score++;
                }
                //Lizard
                else if (player1.gesture == "lizard" && (player2.gesture == "spock" || player2.gesture == "paper"))
                {
                    Console.WriteLine($"     {player1.name} wins this round {round}!!");
                    history.Add($"     {player1.name} wins round {round}!! {player1.name} chose {player1.gesture} | {player2.name} chose {player2.gesture}");
                    player1.score++;
                }
                //Spock
                else if (player1.gesture == "spock" && (player2.gesture == "rock" || player2.gesture == "scissors"))
                {
                    Console.WriteLine("     {player1.name} wins this round!!");
                    history.Add($"     {player1.name} wins round {round}!! {player1.name} chose {player1.gesture} | {player2.name} chose {player2.gesture}");
                    player1.score++;
                }
                //tie
                else if (player1.gesture == player2.gesture)
                {

                    history.Add($"     Round {round} is a tie!!");
                    Console.WriteLine("     Tie");
                }
                else
                {
                    Console.WriteLine("     Player 2 wins this round!!");
                    history.Add($"     {player2.name} wins round {round}!! {player1.name} chose {player1.gesture} | {player2.name} chose {player2.gesture}");
                    player2.score++;
                }


            }

            bool CheckGameWinner()
            {
                if (player1.score == 3)
                {
                    history.Add($"\n     {player1.name} wins the game!!");
                    return true;
                }
                else if (player2.score == 3)
                {
                    history.Add($"\n     {player2.name} wins the game!!");
                    return true;
                }
                return false;
            }

            bool AskPlayAgain()
            {
                bool validInput = false;
                char choice = '1';
                Console.Clear();
                DisplayHistory();
                Console.Write("     Would you like to play again (y/n)? ");
                choice = Console.ReadKey().KeyChar;
                while (validInput == false)
                {
                    if (choice == 'y' ||
                        choice == 'Y' ||
                        choice == 'n' ||
                        choice == 'N')
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Clear();
                        DisplayHistory();
                        Console.WriteLine("     Would you like to play again? " + choice);
                        Console.WriteLine("     Invalid choice!!");
                        Console.Write("     Would you like to play again? ");
                        choice = Console.ReadKey().KeyChar;
                    }


                }
                switch (choice)
                {
                    case 'y':
                    case 'Y':
                        player1.score = 0;
                        player2.score = 0;
                        winner = false;
                        round = 1;
                        return true;
                }
                return false;

            }

        }
    }
}
