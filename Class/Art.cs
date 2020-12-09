using System;
using System.Collections.Generic;
using System.Text;

namespace TicTackToe.Class
{
    class Art
    {
        // Ruels and choises
        public void Greeting()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("");
            Console.WriteLine("          .-----. _         .-----.             .-----.            ");
            Console.WriteLine("          `-. .-':_;        `-. .-'             `-. .-'            ");
            Console.WriteLine("            : :  .-. .--.     : : .--.   .--.     : : .--.  .--.   ");
            Console.WriteLine("            : :  : :'  ..'    : :' .; ; '  ..'    : :' .; :' '_.'  ");
            Console.WriteLine("            :_;  :_;`.__.'    :_;`.__,_;`.__.'    :_;`.__.'`.__.'  ");
            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine(" *****************************************************************************");
            Console.WriteLine("                       This is a game of Tic Tac Toe");
            Console.WriteLine(" *****************************************************************************");
            Console.WriteLine("");
            Console.WriteLine(" Rules:");
            Console.WriteLine(" 1. This is a turn based game, X moves first, you are X.");
            Console.WriteLine(" 2. A piece may be placed on any empty space.");
            Console.WriteLine(" 3. A player wins by being the first to connect a line of \n pieces from one side or corner of the board to the other.");
            Console.WriteLine(" 4. The game ends when either one player wins or it is no longer \n possible for a player to win(in which case the result is a draw).");
            Console.WriteLine("");
            Console.WriteLine(" You will first get to pick your opponent,");
            Console.WriteLine("");
            Console.WriteLine(" There are your choises:");
            Console.WriteLine(" 1.   IRL opponent, play with someone beside you");
            Console.WriteLine(" 2.   AI opponenet, this one vill play randomly");
            Console.WriteLine("");
            Console.WriteLine(" x.   To exit");
            Console.WriteLine("");
            Console.WriteLine(" Please write the number of the opponent of your choise.");
        }

        // The game board
        public void DrawBoard(int currentPlayer, string[] gameArr)
        {
            // Board
            Console.WriteLine("");
            Console.WriteLine(" *****************************************************************************");
            Console.WriteLine("                       This is a game of Tic Tac Toe");
            Console.WriteLine(" *****************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"                 It is player {currentPlayer}'s turn.");
            Console.WriteLine("");
            Console.WriteLine("                        |       |");
            Console.WriteLine($"                    {gameArr[0]}   |   {gameArr[1]}   |   {gameArr[2]} ");
            Console.WriteLine("                        |       |");
            Console.WriteLine("                 -------+-------+-------");
            Console.WriteLine("                        |       |");
            Console.WriteLine($"                    {gameArr[3]}   |   {gameArr[4]}   |   {gameArr[5]} ");
            Console.WriteLine("                        |       |");
            Console.WriteLine("                 -------+-------+-------");
            Console.WriteLine("                        |       |");
            Console.WriteLine($"                    {gameArr[6]}   |   {gameArr[7]}   |   {gameArr[8]} ");
            Console.WriteLine("                        |       |");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public void ItsATie()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("  °00000  °0000000000 °000  °000000       °000000      °0000000000 °00000  °0000000   ");
            Console.WriteLine("  °00000  °0000000000 °00 °000000000     °00000000     °0000000000 °00000  °0000000   ");
            Console.WriteLine("   °000       °000    °0 °0000          °000   °000       °000      °000   °000°°°    ");
            Console.WriteLine("   °000       °000       °000000        °000   °000       °000      °000   °0000000   ");
            Console.WriteLine("   °000       °000           °00000     °0000000000       °000      °000   °000°°°    ");
            Console.WriteLine("  °00000      °000       °000000000     °000°°°°000       °000     °00000  °0000000   ");
            Console.WriteLine("  °00000      °000        °000000       °000    000       °000     °00000  °0000000   ");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public void YouWon(int currentPlayer)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" ÛÛÛÛÛ ÛÛÛÛÛ                        ÛÛÛÛÛ   ÛÛÛ   ÛÛÛÛÛ                     ÛÛÛ ÛÛÛ     ");
            Console.WriteLine("°°ÛÛÛ °°ÛÛÛ                        °°ÛÛÛ   °ÛÛÛ  °°ÛÛÛ                     °ÛÛÛ°ÛÛÛ     ");
            Console.WriteLine(" °°ÛÛÛ ÛÛÛ    ÛÛÛÛÛÛ  ÛÛÛÛÛ ÛÛÛÛ    °ÛÛÛ   °ÛÛÛ   °ÛÛÛ   ÛÛÛÛÛÛ  ÛÛÛÛÛÛÛÛ  °ÛÛÛ°ÛÛÛ     ");
            Console.WriteLine("  °°ÛÛÛÛÛ    ÛÛÛ°°ÛÛÛ°°ÛÛÛ °ÛÛÛ     °ÛÛÛ   °ÛÛÛ   °ÛÛÛ  ÛÛÛ°°ÛÛÛ°°ÛÛÛ°°ÛÛÛ °ÛÛÛ°ÛÛÛ     ");
            Console.WriteLine("   °°ÛÛÛ    °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ     °°ÛÛÛ  ÛÛÛÛÛ  ÛÛÛ  °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ°ÛÛÛ     ");
            Console.WriteLine("    °ÛÛÛ    °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ      °°°ÛÛÛÛÛ°ÛÛÛÛÛ°   °ÛÛÛ °ÛÛÛ °ÛÛÛ °ÛÛÛ °°° °°°      ");
            Console.WriteLine("    ÛÛÛÛÛ   °°ÛÛÛÛÛÛ  °°ÛÛÛÛÛÛÛÛ       °°ÛÛÛ °°ÛÛÛ     °°ÛÛÛÛÛÛ  ÛÛÛÛ ÛÛÛÛÛ ÛÛÛ ÛÛÛ     ");
            Console.WriteLine("    °°°°°     °°°°°°    °°°°°°°°         °°°   °°°       °°°°°°  °°°° °°°°° °°° °°°     ");
            Console.WriteLine("");
            Console.WriteLine($"The Winner is player number {currentPlayer}!!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ResetColor();
        }
    }
}
