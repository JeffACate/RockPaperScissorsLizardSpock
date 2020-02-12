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
        public Game()
        {

            DisplayRules();
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
        

    }
}
