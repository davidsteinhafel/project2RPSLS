using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Project2
{
    class Simulation
    {
        //public HumanPlayer player1 = new HumanPlayer();
        //public HumanPlayer player2 = new HumanPlayer();
        //public AiPlayer player3 = new AiPlayer();

        public Player player1;
        public Player player2;


        public void StartGame()
        {
            Console.WriteLine("Welcome to RPSLS!!!");
            string numberOfPlayers = ChooseNumberOfPlayers();
            SetNumberOfPlayers(numberOfPlayers);
            player1.SetName();
            player2.SetName();
            PlayerGestures();

        }
        public string ChooseNumberOfPlayers()
        {
            Console.WriteLine("How many players?");
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
            do
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();
            } while (player1.score < 2 && player2.score < 2);
        }
        public void CompareGestures()
        {

            if (player1.choice == "ROCK")
            {
                if (player2.choice == "SCISSORS")
                {
                    ++player1.score;
                    Console.WriteLine("P1 Wins");
                }
                else if (player2.choice == "PAPER")
                {
                    Console.WriteLine("P2 Wins");
                    ++player2.score;
                }
                else if (player2.choice == "SPOCK")
                {
                    Console.WriteLine("P2 Wins");
                    ++player2.score;
                }
                else if (player2.choice == "LIZARD")
                {
                    Console.WriteLine("P1 Wins");
                    ++player1.score;
                }
                else if (player2.choice == "ROCK")
                {
                    Console.WriteLine("Draw");
                    PlayerGestures();
                }

            }
            if (player1.choice == "SCISSORS")
            {
                if (player2.choice == "ROCK")
                {
                    Console.WriteLine("P2 Wins");
                    ++player2.score;
                }
                else if (player2.choice == "PAPER")
                {
                    Console.WriteLine("P1 Wins");
                    ++player1.score;
                }
                else if (player2.choice == "SPOCK")
                {
                    Console.WriteLine("P2 Wins");
                    ++player2.score;
                }
                else if (player2.choice == "LIZARD")
                {
                    Console.WriteLine("P1 Wins");
                    ++player1.score;
                }
                else if (player2.choice == "SCISSORS")
                {
                    Console.WriteLine("Draw");
                    PlayerGestures();
                }

            }
            if (player1.choice == "PAPER")
            {
                if (player2.choice == "SCISSORS")
                {
                    Console.WriteLine("P2 Wins");
                    ++player2.score;
                }
                else if (player2.choice == "ROCK")
                {
                    Console.WriteLine("P1 Wins");
                    ++player1.score;
                }
                else if (player2.choice == "SPOCK")
                {
                    Console.WriteLine("P1 Wins");
                    ++player1.score;
                }
                else if (player2.choice == "LIZARD")
                {
                    Console.WriteLine("P2 Wins");
                    ++player2.score;
                }
                else if (player2.choice == "PAPER")
                {
                    Console.WriteLine("Draw");
                    PlayerGestures();
                }

            }
            if (player1.choice == "SPOCK")
            {
                if (player2.choice == "SCISSORS")
                {
                    Console.WriteLine("P1 Wins");
                    ++player1.score;
                }
                else if (player2.choice == "PAPER")
                {
                    Console.WriteLine("P2 Wins");
                    ++player2.score;
                }
                else if (player2.choice == "ROCK")
                {
                    Console.WriteLine("P1 Wins");
                    ++player1.score;
                }
                else if (player2.choice == "LIZARD")
                {
                    Console.WriteLine("P2 Wins");
                    ++player2.score;
                }
                else if (player2.choice == "SPOCK")
                {
                    Console.WriteLine("Draw");
                    PlayerGestures();
                }

            }
            if (player1.choice == "LIZARD")
            {
                if (player2.choice == "SCISSORS")
                {
                    Console.WriteLine("P2 Wins");
                    ++player2.score;
                }
                else if (player2.choice == "PAPER")
                {
                    Console.WriteLine("P1 Wins");
                    ++player1.score;
                }
                else if (player2.choice == "SPOCK")
                {
                    Console.WriteLine("P1 Wins");
                    ++player1.score;
                }
                else if (player2.choice == "ROCK")
                {
                    Console.WriteLine("P2 Wins");
                    ++player2.score;
                }
                else if (player2.choice == "LIZARD")
                {
                    Console.WriteLine("Draw");
                    PlayerGestures();
                }
            }


        }
        public void PointCounter()
        {
            if (player1.score >= 2)
            {
                Console.WriteLine("PLAYER 1 WINS!!!");
                Console.WriteLine("PLAY AGAIN? YES = 1 NO = 2");
                string playAgainChoice = Console.ReadLine();
                if (playAgainChoice == "1")
                {
                    StartGame();
                }

            }
            if (player2.score >= 2)
            {
                Console.WriteLine("PLAYER 2 WINS!!!");
                Console.WriteLine("PLAY AGAIN? YES = 1 NO = 2");
                string playAgainChoice = Console.ReadLine();
                if (playAgainChoice == "1")
                {
                    StartGame();
                }
            }
        }
    }
}

//public void AddComputer()
//{
//    player3 = new AiPlayer();


//}
//public void PlayerVsPlayerStart()
//{
//    player1.ChooseGesture();
//    player2.ChooseGesture();
//    Console.ReadLine();
//}
//public void PlayerVsComputerStart()
//{
//    player1.ChooseGesture();
//    player3.ChooseGesture();
//}

//public void AddPlayers()
//{
//    player1.ChooseName();
//    player2.ChooseName();
//}
//public void SelectGameMode()
//{
//    Console.WriteLine("SELECT GAME MODE:");
//    Console.WriteLine("PLAYER VS PLAYER");
//    Console.WriteLine("PLAYER VS COMPUTER?");
//    string mode = Console.ReadLine();

//    

//}








