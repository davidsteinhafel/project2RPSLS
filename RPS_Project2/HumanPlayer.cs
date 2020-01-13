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

        public void ChooseName()
        {
            Console.WriteLine("Please put your name in");
            userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);
            Console.ReadLine();
        }
        
        
    }
}
