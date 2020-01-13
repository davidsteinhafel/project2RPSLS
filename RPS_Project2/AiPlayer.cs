using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    class AiPlayer : Player
    {
        public string name;
        public AiPlayer computer;
        


        public AiPlayer()
        {

            
            name = "Computer";

            



        }
        public void AddComputer()
        {
            computer = new AiPlayer();
            Console.WriteLine(name + " added");
            
        }
        
        
    }
}
