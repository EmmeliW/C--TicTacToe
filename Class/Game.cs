using System;
using static System.Net.Mime.MediaTypeNames;

namespace TicTackToe.Class
{
    class Game
    {
        // Instasiate classes
        AIrandom randomOpponent = new AIrandom();
        HumanPlayer humanPlayer = new HumanPlayer();
        Art art = new Art();
        // Array
        string[] gameArr;
        // Vrables
        int currentPlayer;
        int status;

        public void Play(string opponent)
        {
            // Asign valies to array and varalbles
            currentPlayer = 2;
            status = 0;
            gameArr = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            // Let the game roll like this after each players round
            do 
            {
                Console.Clear();
                //Get next player
                currentPlayer = NextPlayer(currentPlayer);           
                //Draw gameboard
                art.DrawBoard(currentPlayer, gameArr);
                // Play the game
                Engine(gameArr, currentPlayer, opponent);
                // Check if anyone won
                CheckWin();
            } while (status.Equals(0));

            // If status changes to 1 or 2 
            if (status.Equals(1)) 
            {
                // Present winner
                Winner(currentPlayer);
            }
            else if (status.Equals(2))
            {
                // Send message its a tie
                Tie();
            }
        }

        // Thos method checks vitch player is active
        private void Engine(string[] gameArr, int currentPlayer, string opponent)
        {
            // check witch opponent i active
            if (currentPlayer == 1 || opponent == "1")
            {
                Console.WriteLine(" Enter the number of the spot where you want to play your filthy move.");
                // Go to method for human round
                humanPlayer.Humaninput(currentPlayer, gameArr);
            }
            else if (opponent == "2")
            {
                // Go to method for AI round
                randomOpponent.Play(gameArr);
            }
        }                   


        // Get the next player
        public int NextPlayer(int currentPlayer)
        {
            int result = (currentPlayer == 1) ? 2 : 1;
            return result;
        }

        // Methods to look for winning line
        public bool FullLine(int index0, int index1, int index2, string piece)
        {
            return gameArr[index0] == piece && gameArr[index1] == piece && gameArr[index2] == piece;
        }
        public bool IsLineFull(int index0, int index1, int index2)
        {
            return FullLine(index0, index1, index2, gameArr[index0]);
        }
        // Check all the difftent lines
        public bool CheckWin()
        {
            if (IsLineFull(0, 1, 2) ||
                    IsLineFull(3, 4, 5) ||
                    IsLineFull(6, 7, 8) ||
                    IsLineFull(0, 4, 8) ||
                    IsLineFull(2, 4, 6) ||
                    IsLineFull(0, 3, 6) ||
                    IsLineFull(1, 4, 7) ||
                    IsLineFull(2, 5, 8))
            {
                status = 1;
                return true;
            }
            else if (IsItATie(gameArr))
            {

            }
            return false;
        }

        // When there is a winner
        public void Winner(int currentPlayer)
        {
            Console.Clear();
            // Draw the winnin board and present the winner
            art.DrawBoard(currentPlayer, gameArr);
            art.YouWon(currentPlayer);
            Console.WriteLine("Press X if you want to exit and any other key to restart änd play again.");

            // Check if player wants to play again or exit
            if (Console.ReadLine() == "x")
            {
                Console.Clear();
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }

        // Check all the lines if all the lines are full with x and o, it is a tie
        public bool IsItATie(string[] gameArr)
        {
                if (gameArr[0] != "1" &&
                    gameArr[1] != "2" &&
                    gameArr[2] != "3" &&
                    gameArr[3] != "4" &&
                    gameArr[4] != "5" &&
                    gameArr[5] != "6" &&
                    gameArr[6] != "7" &&
                    gameArr[7] != "8" &&
                    gameArr[8] != "9") 
                {
                    status = 2;
                    return true;
                }
            return false;            
        }

        // When it is a tie
        public void Tie()
        {
            Console.Clear();
            // Draw the board and tell its a tie
            art.DrawBoard(currentPlayer, gameArr);
            art.ItsATie();
            Console.WriteLine("Press X if you want to exit and any other key to restart and play again.");

            // Check if player wants to play again or exit
            if (Console.ReadLine() == "x")
            {
                Console.Clear();
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }
    }
}
