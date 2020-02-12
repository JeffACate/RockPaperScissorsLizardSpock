using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        List<string> gestures;
        Random rng;
    public Computer(Random rng)
        {
            name = "Computer";
            score = 0;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
            this.rng = rng;
        }
        public override void ChooseGesture()
        {
            gesture = rng.Next(0, 5);
        }
    }
}
