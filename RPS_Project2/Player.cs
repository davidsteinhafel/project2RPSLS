using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    class Player
    {
        public string name;
        
        


        public List<Gesture> gestures = new List<Gesture>();



        public Player()
        {
            

            

            Gesture gesture1 = new Rock();
            Gesture gesture2 = new Paper();
            Gesture gesture3 = new Scissor();
            Gesture gesture4 = new Spock();
            Gesture gesture5 = new Lizard();
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
