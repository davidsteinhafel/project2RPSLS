using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    class HumanPlayer : Player
    {
        public string userName;
        

        public HumanPlayer()
        {
            
  

        }
        public override void ChooseGesture()
        {
            Console.WriteLine("Please select your choice. Rock = 1 , Paper = 2 , Scissors = 3 , Lizard = 4 , Spock = 5");
            choice = Console.ReadLine();
            gestures[0] = "1";
            gestures[1] = "2";
            gestures[2] = "3";
            gestures[3] = "4";
            gestures[4] = "5";

        }
        public override void SetName()
        {
            Console.WriteLine("Please type your name in!");
            userName = Console.ReadLine();
        }

        
        
        
    }
}
