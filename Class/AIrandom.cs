using System;
using System.Collections.Generic;
using System.Text;

namespace TicTackToe.Class
{
    class AIrandom
    {
        bool occupied = true;
        public string[] Play(string[] gameArr)
        {
            do
            {
                Random rnd = new Random();
                int inputInt = rnd.Next(1, 9);
                                
                string currentMark = gameArr[inputInt - 1];

                if (!currentMark.Equals("X") || !currentMark.Equals("O"))
                {
                    gameArr[inputInt - 1] = "O";
                    occupied = false;
                }
            }
            while (occupied);

            return gameArr;
        }
    }
}
