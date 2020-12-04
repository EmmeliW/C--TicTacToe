using System;
using TicTackToe.Class;


namespace TicTackToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instasiate classes
            Game game = new Game();
            Art art = new Art();
            string opponent = "";

            // Show greeting, rules and so on...
            art.Greeting();
            // Choose opponent
            opponent = Console.ReadLine();

            bool playing = true;
            while (playing)
            {                
                if (opponent == "1" || opponent == "2")
                {
                game.Play(opponent);
                }
                else
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    Console.WriteLine("You have to choose either 1, 2 or 3!");
                }   
            }
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
