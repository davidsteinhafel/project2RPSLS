using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    class Computer : Player
    {
        

        public Computer()
        {
            
        }
        public override void SetName()
        {
            name = "Computer";
        }
        public override void ChooseGesture()
        {
            Random rand = new Random();
            choice = (gestures[rand.Next(0, 5)]);
            
            
        }



    }
}
