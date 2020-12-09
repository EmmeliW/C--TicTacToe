using System;
using System.Collections.Generic;
using System.Text;

namespace TicTackToe.Class
{
    class HumanPlayer
    {
        // Methos for the humans turn
        public void Humaninput(int currentPlayer, string[] gameArr)
        {
            // Create variables
            string input;
            int inputInt;
            bool moveNotValid = true;

            // Do this as long as a move is invalid
            do
            {
                // Take input from player
                input = Console.ReadLine();

                // Convert to a int
                bool isNumber = Int32.TryParse(input, out inputInt);

                // Ckecj if convertion went fine, if the inpit is not empty and if it is a number between 1-9
                if (isNumber && !string.IsNullOrEmpty(input) && (inputInt >= 1) && (inputInt <= 9))
                {
                    string currentMark = gameArr[inputInt - 1];

                    // Check if the place is occupied with an x or a o
                    if (currentMark.Equals("X") || currentMark.Equals("O"))
                    {
                        Console.WriteLine("Oh, a little mistake has been made by you beautiful.");
                        Console.WriteLine("Looks like this place is already taken, choose an empty one...");
                    }
                    else
                    {
                        // If it is player 1 put an x on the spot, if player 2 put an o
                        if (currentPlayer == 1)
                        {
                            gameArr[inputInt - 1] = "X";
                        }
                        else
                        {
                            gameArr[inputInt - 1] = "O";
                        }
                        // Set to fale so the loop ends
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
    }
}
