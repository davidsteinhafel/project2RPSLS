﻿using System;
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
            ChooseNumberOfPlayers();
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
                ChooseNumberOfPlayers();
            }
            do
            {
                while(player1.choice == "Rock")
                {
                    if(player2.choice == "Scissors")
                    {
                        ++player1.score;
                    }
                    if (player2.choice == "Paper")
                    {
                        ++player2.score;
                    }
                    if (player2.choice == "Spock")
                    {
                        ++player2.score;
                    }
                    if (player2.choice == "Lizard")
                    {
                        ++player1.score;
                    }

                }
                while (player1.choice == "Scissors")
                {
                    if (player2.choice == "Rock")
                    {
                        ++player2.score;
                    }
                    if (player2.choice == "Paper")
                    {
                        ++player1.score;
                    }
                    if (player2.choice == "Spock")
                    {
                        ++player2.score;
                    }
                    if (player2.choice == "Lizard")
                    {
                        ++player1.score;
                    }

                }
                while (player1.choice == "Paper")
                {
                    if (player2.choice == "Scissors")
                    {
                        ++player2.score;
                    }
                    if (player2.choice == "Rock")
                    {
                        ++player1.score;
                    }
                    if (player2.choice == "Spock")
                    {
                        ++player1.score;
                    }
                    if (player2.choice == "Lizard")
                    {
                        ++player2.score;
                    }

                }
                while (player1.choice == "Spock")
                {
                    if (player2.choice == "Scissors")
                    {
                        ++player1.score;
                    }
                    if (player2.choice == "Paper")
                    {
                        ++player2.score;
                    }
                    if (player2.choice == "Rock")
                    {
                        ++player1.score;
                    }
                    if (player2.choice == "Lizard")
                    {
                        ++player2.score;
                    }

                }
                while (player1.choice == "Lizard")
                {
                    if (player2.choice == "Scissors")
                    {
                        ++player2.score;
                    }
                    if (player2.choice == "Paper")
                    {
                        ++player1.score;
                    }
                    if (player2.choice == "Spock")
                    {
                        ++player1.score;
                    }
                    if (player2.choice == "Rock")
                    {
                        ++player2.score;
                    }

                }

            } while (player1.score < 2 && player2.score < 2);
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
            
        //    switch (mode.ToUpper())
        //    {
        //        case "PLAYER VS PLAYER":
        //            AddPlayers();
        //            break;
        //        case "PLAYER VS COMPUTER":
        //            AddComputer();
        //            break;

        //    }
        //    if(mode == "PLAYER VS PLAYER")
        //    {
        //        PlayerVsPlayerStart();
        //    }
        //    else
        //    {
        //        PlayerVsComputerStart();
        //    }
            
        //}

        



        
    }
}
