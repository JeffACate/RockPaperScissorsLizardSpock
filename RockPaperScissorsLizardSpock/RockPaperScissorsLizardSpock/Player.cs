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
        public int gesture;
        public List<string> gestures;

        public abstract void ChooseGesture();

        void SetPlayers()
        {

        }
    }
}
