using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    class Player
    {


        public List<Gesture> gestures = new List<Gesture>();



        public Player()
        {
            Gesture gesture1 = new Gesture("Rock");
            Gesture gesture2 = new Gesture("Paper");
            Gesture gesture3 = new Gesture("Scissors");
            Gesture gesture4 = new Gesture("Spock");
            Gesture gesture5 = new Gesture("Lizard");
            gestures.Add(gesture1);
            gestures.Add(gesture2);
            gestures.Add(gesture3);
            gestures.Add(gesture4);
            gestures.Add(gesture5);

        }
        public void ChooseGesture()
        {
            Console.WriteLine("Please choose a move");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "Rock":
                    Console.WriteLine("Rock");
                    break;
                case "Paper":
                    Console.WriteLine("Paper");
                    break;
                case "Scissors":
                    Console.WriteLine("Scissors");
                    break;
                case "Lizard":
                    Console.WriteLine("Lizard");
                    break;
                case "Spock":
                    Console.WriteLine("Spock");
                    break;
                    Console.ReadLine();
            }
            
        }
    }
}
