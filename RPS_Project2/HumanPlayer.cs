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
        
        
        public override void SetName()
        {
            Console.WriteLine("Please type your name in!");
            userName = Console.ReadLine();
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("Please select your choice. Rock = 1 , Paper = 2 , Scissors = 3 , Lizard = 4 , Spock = 5");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case ("1"):
                    choice = gestures[0];
                    break;
                case ("2"):
                    choice = gestures[1];
                    break;
                case ("3"):
                    choice = gestures[2];
                    break;
                case ("4"):
                    choice = gestures[3];
                    break;
            }
        }




    }
}
        //switch (mode.ToUpper())
        //    {
        //        case "PLAYER VS PLAYER":
        //            AddPlayers();
        //            break;
        //        case "PLAYER VS COMPUTER":
        //            AddComputer();
        //            break;

        //    }
        //    if(mode == "PLAYER VS PLAYER")
        //    {
        //        PlayerVsPlayerStart();
        //    }
        //    else
        //    {
        //        PlayerVsComputerStart();
        //    }
