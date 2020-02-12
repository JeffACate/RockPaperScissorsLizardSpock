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
    public Computer(Random rng)
        {
            name = "Computer";
            score = 0;
            
            this.rng = rng;
        }
        public override void ChooseGesture()
        {
            int choice = rng.Next(0, 5);
            gesture = gestures[choice];
        }
    }
}
