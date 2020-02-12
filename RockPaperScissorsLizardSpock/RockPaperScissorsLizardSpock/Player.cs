using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    abstract class Player
    {
        public int score;
        public string name;
        public string gesture;
        public List<string> gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };

        public abstract void ChooseGesture();

    }
}
