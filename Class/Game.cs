using System;

namespace TicTackToe.Class
{
    class Game
    {
        // Instasiate classes
        AIrandom randomOpponent = new AIrandom();
        Art art = new Art()
;
        // Skapa en array
        string[] gameArr = { "1", "2", "3", "4", "5", "6", "7", "8", "9"};
        // Vrables
        int currentPlayer = 2;
        string input;
        int inputInt;
        int status = 0;
        bool moveNotValid = true;

        //********************************************************************************* THE GAME
        public void Play(string opponent)
        {
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

            if (status.Equals(1)) 
            {
                Winner(currentPlayer);
            }
            else if (status.Equals(2))
            {
                Tie();
            }
        }

        //************************************************************************************************ ENGINE
        private void Engine(string[] gameArr, int currentPlayer, string opponent)
        {
            // check witch opponent i active
            if (currentPlayer == 1 || opponent == "1")
            {
            Console.WriteLine(" Enter the number of the spot where you want to play your filthy move.");
                Humaninput(currentPlayer);
                return;
            }
            else if (opponent == "2")
            {
                randomOpponent.Play(gameArr);
                return;
            }
        }            
        //************************************************************************************************ Human input 
        public void Humaninput(int currentPlayer)
        {                 
            // gör detta så länge det är ett ogiltigt numer
            do
            {
                input = Console.ReadLine();                
                // input = Console.ReadLine();
                bool isNumber = Int32.TryParse(input, out inputInt);
                // Kolla om input är tomt eller om det är något annat tal än 1-9
                if (isNumber && !string.IsNullOrEmpty(input) && (inputInt >= 1) && (inputInt <= 9))
                {
                    string currentMark = gameArr[inputInt - 1];

                    // kolla om den platsen är uppdagen av ett X eller ett O i arrayen.
                    if (currentMark.Equals("X") || currentMark.Equals("O"))
                    {
                        Console.WriteLine("Oh, a little mistake has been made by you beautiful.");
                        Console.WriteLine("Looks like this place is already taken, choose an empty one...");
                    }
                    else
                    {
                        //sätt X om det är spelare 1 och O om det äst spelare 2
                        if (currentPlayer == 1)
                        {
                            gameArr[inputInt - 1] = "X"; 
                        }
                        else
                        {
                            gameArr[inputInt - 1] = "O";
                        }
                        // sätt not valid move till falskt så att loopen slutar
                        moveNotValid = false;
                    }
                }
                else
                {
                    Console.WriteLine("Oh my, no no no. You can't do that.");
                    Console.WriteLine("That's an invalid input, please select a valid number...");
                }
            } while (moveNotValid);
            
        }


        //************************************************************************************************ NENEXR PLAYER
        public int NextPlayer(int currentPlayer)
        {
            int result = (currentPlayer == 1) ? 2 : 1;
            return result;
        }

        //************************************************************************************************ CHECK WINNER
        // Method to look for winning line
        public bool FullLine(int index0, int index1, int index2, string piece)
        {
            return gameArr[index0] == piece && gameArr[index1] == piece && gameArr[index2] == piece;
        }
        public bool IsLineFull(int index0, int index1, int index2)
        {
            return FullLine(index0, index1, index2, gameArr[index0]);
        }
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

        //***************************************************************************************************** IF THERE IS A WINNER

        public void Winner(int currentPlayer)
        {
            Console.Clear();
            art.DrawBoard(currentPlayer, gameArr);
            art.YouWon(currentPlayer);
            Console.WriteLine("Press X if you want to exit and any other key to restart änd play again.");
            
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

        //**************************************************************************************************** ChECK IF IT IS A TIE
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

        //***************************************************************************************************** IF IT IS A TIE
        public void Tie()
        {
            Console.Clear();
            art.DrawBoard(currentPlayer, gameArr);
            art.ItsATie();
            Console.WriteLine("Press X if you want to exit and any other key to restart and play again.");

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
