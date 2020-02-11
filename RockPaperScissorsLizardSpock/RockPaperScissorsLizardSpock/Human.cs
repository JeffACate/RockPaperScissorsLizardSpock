using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
            score = 0;
        }
        public override void ChooseMove()
        {
            List<string> options = Game.gestures;
            bool invalidInput = true;
            char choice = '9';
            while (invalidInput)
            {
                Console.WriteLine("Please choose a move: ");
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine("{0}) {1} ", i,options[i]);
                }
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (choice == '0' ||
                    choice == '1' ||
                    choice == '2' ||
                    choice == '3' ||
                    choice == '4')
                {
                    invalidInput = false;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            switch (choice)
            {
                case '0':
                    move = 0;
                    break;
                case '1':
                    move = 1;
                    break;
                case '2':
                    move = 2;
                    break;
                case '3':
                    move = 3;
                    break;
                case '4':
                    move = 4;
                    break;
            }
        }
    }
}
