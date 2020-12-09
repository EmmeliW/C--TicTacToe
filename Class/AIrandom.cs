using System;
using System.Collections.Generic;
using System.Text;

namespace TicTackToe.Class
{
    class AIrandom
    {
        // Methos for an AI that picks a random number
        public string[] Play(string[] gameArr)
        {
            // Run loop an long as the spot i occupied
            bool occupied = true;
            do
            {
                // Pick a random number
                Random rnd = new Random();
                int inputInt = rnd.Next(1, 10);
                   
                // Pick out what de curent mat is on that spot, take -1 because the array starts at 0
                string currentMark = gameArr[inputInt - 1];

                // If it is not an x or o at the place punt an o there.
                if (!currentMark.Equals("X") && !currentMark.Equals("O"))
                {
                    gameArr[inputInt - 1] = "O";
                    // End loop
                    occupied = false;
                }
            }
            while (occupied);

            // Rerutn the array
            return gameArr;
        }
    }
}
