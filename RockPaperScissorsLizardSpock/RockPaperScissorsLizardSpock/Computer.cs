using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        Random rng;
        List<string> gestures;
    public Computer()
        {
            name = "Computer";
            score = 0;
            rng = new Random();
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        }
        public override void ChooseGesture()
        {
            gesture = rng.Next(0, 5);
        }
    }
}
