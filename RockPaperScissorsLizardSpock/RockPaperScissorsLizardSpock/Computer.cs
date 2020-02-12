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
        public Computer()
        {
            name = "Computer";
            score = 0;
            rng = new Random();
        }
        public override void ChooseGesture()
        {
            gesture = rng.Next(0, 5);
        }
    }
}
