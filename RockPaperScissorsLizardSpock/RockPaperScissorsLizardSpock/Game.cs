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
        public Game()
        {
            rng = new Random();
            DisplayRules();
            SetPlayers();
            player1.ChooseGesture();
            player2.ChooseGesture();
            Console.ReadKey();

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
                    Console.WriteLine("What is player 1's name? ");
                    player1 = new Human(Console.ReadLine());
                    player2 = new Computer(rng);
                    break;
                case '2':
                    Console.WriteLine("What is player 1's name? ");
                    player1 = new Human(Console.ReadLine());
                    Console.WriteLine("What is player 2's name? ");
                    player2 = new Human(Console.ReadLine());
                break;
            }
        }
        

    }
}
