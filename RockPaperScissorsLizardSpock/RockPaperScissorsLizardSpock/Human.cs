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
        void DisplayOptions()
        {
            Console.WriteLine("     Gestures(0 - 4): ");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine("          {0} = {1} ", i, gestures[i]);
            }
        }
        public override void ChooseGesture()
        {
            bool invalidInput = true;
            int choice = '9';
            DisplayOptions();
            while (invalidInput)
            {
                Console.Write($"     {name} Please choose a gesture: ");
                choice = Console.ReadKey().KeyChar - '0' ;

                Console.WriteLine();
                if (choice == 0 ||
                    choice == 1 ||
                    choice == 2 ||
                    choice == 3 ||
                    choice == 4)  
                {
                    invalidInput = false;
                }
                else
                {
                    Console.WriteLine("     Invalid Choice");
                    DisplayOptions();
                }

            }
            switch (choice)
            {
                case 0:
                    gesture = gestures[choice];
                    break;
                case 1:
                    gesture = gestures[choice];
                    break;
                case 2:
                    gesture = gestures[choice];
                    break;
                case 3:
                    gesture = gestures[choice];
                    break;
                case 4:
                    gesture = gestures[choice];
                    break;
            }
        }
    }
}
