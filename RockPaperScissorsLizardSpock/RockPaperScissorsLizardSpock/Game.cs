using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        public static List<string> gestures;

        public Game()
        {
            gestures = new List<string> { "rock", "paper","scissors", "lizard", "spock" };
        }

    }
}
