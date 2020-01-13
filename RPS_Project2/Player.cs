using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    class Player
    {
        
        
        
        public List<Gesture> gestures;

        public Player()
        {
            gestures = new List<Gesture> { new Rock(), new Paper(), new Scissor(), new Lizard(), new Spock() };

            
        }
        

        public void ChooseGesture()
        {
            Console.WriteLine("Choose your move!");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "Rock":
                    Console.WriteLine(gestures[0]);
                    break;
                case "Paper":
                    Console.WriteLine(gestures[1]);
                    break;
                case "Scissors":
                    Console.WriteLine(gestures[2]);
                    break;
                case "Lizard":
                    Console.WriteLine(gestures[3]);
                    break;
                case "Spock":
                    Console.WriteLine(gestures[4]);
                    break;

            }

        }


    } 
}    