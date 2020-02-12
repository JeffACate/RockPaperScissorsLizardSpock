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
        public override void ChooseGesture()
        {
            bool invalidInput = true;
            char choice = '9';
            while (invalidInput)
            {
                Console.WriteLine("Please choose a gesture: ");
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
                    gesture = 0;
                    break;
                case '1':
                    gesture = 1;
                    break;
                case '2':
                    gesture = 2;
                    break;
                case '3':
                    gesture = 3;
                    break;
                case '4':
                    gesture = 4;
                    break;
            }
        }
    }
}
