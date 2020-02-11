using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Player
    {
        public int score;
        public string name;

        public Player()
        {
            name = "Computer";
            score = 0;
        }
        public Player(string name)
        {
            this.name = name;
            score = 0;
        }
        
    }
}
