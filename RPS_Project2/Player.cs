using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    public abstract class Player
    {
        public string name;
        public int score;
        public Gesture choice;
        public List<Gesture> gestures;

        public Player()
        {
            gestures = new List<Gesture>
            {
                new Gesture("Rock", new List<string>() { "Paper", "Spock" }),
                new Gesture("Paper", new List<string>() {"Scissors", "Lizard"}),
                new Gesture("Scissors", new List<string>() {"Rock", "Spock" }),
                new Gesture("Lizard", new List<string>() {"Rock", "Scissors" }),
                new Gesture("Spock", new List<string>() {"Paper", "Lizard"}),

            };
        }


        public abstract void SetName();
        public abstract void ChooseGesture();
    }
}