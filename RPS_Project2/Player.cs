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
        public string choice;
        public List<string> gestures;
        public Player()
        {
            gestures = new List<string>() { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };
        }
        public abstract void SetName();
        public abstract void ChooseGesture();
    }
}