using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    class Scissor : Gesture
    {
        public Scissor()
        {
            name = "Scissor";
              
        }
        public void CheckScissor()
        {
            switch ("Scissor")
            {
                case "ROCK":
                    Console.WriteLine("YOU LOSE");
                    break;
                case "PAPER":
                    Console.WriteLine("YOU WIN");
                    break;
                case "Lizard":
                    Console.WriteLine("YOU WIN");
                    break;
                case "SPOCK":
                    Console.WriteLine("YOU LOSE");
                    break;

            }
        }

        
    }
}
