using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    class Game
    {
        public Player player1;
        public Player player2;
        public void StartGame()
        {
            Console.WriteLine("Welcome to RPSLS!!!\n");
            string numberOfPlayers = ChooseNumberOfPlayers();
            SetNumberOfPlayers(numberOfPlayers);
            player1.SetName();
            player2.SetName();
            PlayerGestures();
        }
        public void RestartGame()
        {
            Console.WriteLine("Play Again? YES = 1 or NO = 2");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.Clear();
                StartGame();
            }
        }
        public string ChooseNumberOfPlayers()
        {
            Console.WriteLine("How many players?\n");
            string numberOfPlayers = Console.ReadLine();
            return numberOfPlayers;
        }
        public void SetNumberOfPlayers(string numberOfPlayers)
        {
            if (numberOfPlayers == "1")
            {
                player1 = new HumanPlayer();
                player2 = new Computer();
            }
            else if (numberOfPlayers == "2")
            {
                player1 = new HumanPlayer();
                player2 = new HumanPlayer();
            }
            else
            {
                StartGame();
            }
        }
        public void PlayerGestures()
        {
            while (player1.score < 2 && player2.score < 2)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();
            }
            if (player1.score >= 2)
            {
                Console.WriteLine("\nP1 WINS Game!!!");
                RestartGame();
            }
            else if (player2.score >= 2)
            {
                Console.WriteLine("\nP1 Wins Game!!!");
                RestartGame();
            }
        }
        public void CompareGestures()
        {

            if (player1.choice.losesTo.Contains(player2.choice.name))
            {
                Console.WriteLine("Player 1 Loses!");
                player2.score++;
            }
            else if (player2.choice.losesTo.Contains(player1.choice.name))
            {
                Console.WriteLine("Player 2 Loses");
                player1.score++;
            }
            else
            {
                Console.WriteLine("DRAW!");
            }
        }
    }
}
