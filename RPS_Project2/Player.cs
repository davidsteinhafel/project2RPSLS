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
            gestures = new List<string>() {"ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };
            choice = Console.ReadLine();
        }
        public abstract void SetName();
        public abstract void ChooseGesture();
        //{
        //    Console.WriteLine("CHOOSE YOUR MOVE!");
        //    choice = Console.WriteLine();

        //    //switch (choice.ToUpper())
        //    //{
        //    //    case "ROCK":
        //    //        Console.WriteLine(gestures[0]);
        //    //        break;
        //    //    case "PAPER":
        //    //        Console.WriteLine(gestures[1]);
        //    //        break;
        //    //    case "SCISSOR":
        //    //        Console.WriteLine(gestures[2]);
        //    //        break;
        //    //    case "LIZARD":
        //    //        Console.WriteLine(gestures[3]);
        //    //        break;
        //    //    case "SPOCK":
        //    //        Console.WriteLine(gestures[4]);
        //    //        break;

        //    //}
        //}
        
    } 
}    