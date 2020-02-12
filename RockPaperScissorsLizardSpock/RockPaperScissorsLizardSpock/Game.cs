using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        List<string> gestures;

        public Game()
        {
            gestures = new List<string> { "rock", "paper","scissors", "lizard", "spock" };
        }

        void displayOptions()
        {
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine("{0}) {1} ", i, gestures[i]);
            }
        }

    }
}
