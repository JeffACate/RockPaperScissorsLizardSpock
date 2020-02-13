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
        public Game()
        {
            rng = new Random();
            winner = false;
            playAgain = true;
            round = 1;
            while (playAgain == true)
            {
                DisplayRules();
                SetPlayers();
                while (winner == false)
                {
                    round++;
                    player1.ChooseGesture();
                    Console.WriteLine("Round {0}  | {1}: {2} | {3}: {4}\n", round, player1.name, player1.score, player2.name, player2.score);
                    Console.WriteLine("player 1 chose: {0}", player1.gesture);
                    player2.ChooseGesture();
                    Console.WriteLine("player 2 chose: {0}", player2.gesture);
                    CompareChoices();

                    winner = CheckGameWinner();
                    Console.WriteLine();
                    
                 }
                playAgain = AskPlayAgain();
            }

        }

        void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!!"    + "\n" +
                                  "These Are the rules to the game:\n");
            Console.WriteLine(
                              "     +-------------------------------------+"    + "\n" +
                              "     | Rock      | crushes     |  Scissors |"    + "\n" +
                              "     |-----------|-------------|-----------|"    + "\n" +
                              "     | Scissors  | cuts        |  Paper    |"    + "\n" +
                              "     |-----------|-------------|-----------|"    + "\n" +
                              "     | Paper     | covers      |  Rock     |"    + "\n" +
                              "     |-----------|-------------|-----------|"    + "\n" +    
                              "     |  Rock     | crushes     |  Lizard   |"    + "\n" +
                              "     |-----------|-------------|-----------|"    + "\n" +
                              "     |  Lizard   | poisons     |  Spock    |"    + "\n" +
                              "     |-----------|-------------|-----------|"    + "\n" +
                              "     |  Spock    | smashes     |  Scissors |"    + "\n" +
                              "     |-----------|-------------|-----------|"    + "\n" +
                              "     |  Scissors | decapitates |  Lizard   |"    + "\n" +
                              "     |-----------|-------------|-----------|"    + "\n" +
                              "     |  Lizard   | eats        |  Paper    |"    + "\n" +
                              "     |-----------|-------------|-----------|"    + "\n" +
                              "     |  Paper    | disproves   |  Spock    |"    + "\n" +
                              "     |-----------|-------------|-----------|"    + "\n" +
                              "     |  Spock    | vaporizes   |  Rock     |"    + "\n" +
                              "     +-------------------------------------+"    + "\n" );
        }
        void SetPlayers()
        {
            Console.Write("How many players are playing? ");
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
                    Console.WriteLine("Invalid number of players");
                    Console.Write("How many players are playing? ");
                    players = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
            }
            switch (players)
            {
                case '0':
                    player1 = new Computer(rng);
                    player2 = new Computer(rng);
                    break;
                case '1':
                    Console.Write("What is Player 1's name? ");
                    player1 = new Human(Console.ReadLine());
                    player2 = new Computer(rng);
                    break;
                case '2':
                    Console.Write($"What is {player1.name}'s name? ");
                    player1 = new Human(Console.ReadLine());
                    Console.Write("What is player 2's name? ");
                    player2 = new Human(Console.ReadLine());
                break;
            }
        }
        void CompareChoices()
        {
            
            //Rock
            if(player1.gesture == "rock" && (player2.gesture == "scissors" || player2.gesture == "lizard"))
            {
                Console.WriteLine("Player 1 wins this round!!");
                player1.score++;
            }
            //Paper
            else if (player1.gesture == "paper" && (player2.gesture == "spock" || player2.gesture == "rock"))
            {
                Console.WriteLine("Player 1 wins this round!!");
                player1.score++;
            }
            //Scissors
            else if (player1.gesture == "scissors" && (player2.gesture == "paper" || player2.gesture == "lizard"))
            {
                Console.WriteLine("Player 1 wins this round!!");
                player1.score++;
            }
            //Lizard
            else if (player1.gesture == "lizard" && (player2.gesture == "spock" || player2.gesture == "paper"))
            {
                Console.WriteLine("Player 1 wins this round!!");
                player1.score++;
            }
            //Spock
            else if (player1.gesture == "spock" && (player2.gesture == "rock" || player2.gesture == "scissors"))
            {
                Console.WriteLine("Player 1 wins this round!!");
                player1.score++;
            }
            //tie
            else if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("Tie");
            }
            else
            {
                Console.WriteLine("Player 2 wins this round!!");
                player2.score++;
            }


        }

        bool CheckGameWinner()
        {
            if (player1.score == 2)
            {
                //p1win++;
                Console.WriteLine("Player 1 wins the Game");
                Console.WriteLine("Round {0}  | Player 1: {1} | Player 2: {2}\n", round, player1.score, player2.score);
                return true;
            }
            else if (player2.score == 2)
            {
               // p2win++;
                Console.WriteLine("Player 2 wins the Game ");
                Console.WriteLine("Player 1: {1} | Player 2: {2}\n", round, player1.score, player2.score);
                return true;
            }
            return false;
        }

        bool AskPlayAgain()
        {
            bool validInput = false;
            char choice = '1';
            while (validInput == false)
            {

                Console.Write("Would you like to play again? ");
                choice = Console.ReadKey().KeyChar;
                if (choice == 'y' ||
                    choice == 'Y' ||
                    choice == 'n' ||  
                    choice == 'N')
                {
                    validInput = true;
                }
                Console.WriteLine();
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
