using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    class Player
    {
        public string choice;
        
        
        
        public List<Gesture> gestures;
        
        public Player()
        {
            gestures = new List<Gesture> { new Rock("ROCK"), new Paper(), new Scissor(), new Lizard(), new Spock() };

            choice = Console.ReadLine();


        }
        public void ChooseGesture()
        {
            Console.WriteLine("CHOOSE YOUR MOVE!");
            string result = Console.ReadLine();
            result = choice;

            switch (choice.ToUpper())
            {
                case "ROCK":
                    Console.WriteLine(gestures[0]);
                    break;
                case "PAPER":
                    Console.WriteLine(gestures[1]);
                    break;
                case "SCISSOR":
                    Console.WriteLine(gestures[2]);
                    break;
                case "LIZARD":
                    Console.WriteLine(gestures[3]);
                    break;
                case "SPOCK":
                    Console.WriteLine(gestures[4]);
                    break;

            }
        }
    } 
}    