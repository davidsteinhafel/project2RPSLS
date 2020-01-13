using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    class Simulation
    {
        public void StartGame() 
        {
            
            AiPlayer player3 = new AiPlayer();

            HumanPlayer player1 = new HumanPlayer();
            player1.ChooseName();

            HumanPlayer player2 = new HumanPlayer();
            player2.ChooseName();

            if (player2 == null)
            {
                player3.AddComputer();
            }
            else
            {
                player2.ChooseName();
            }

        }
        



        
    }
}
