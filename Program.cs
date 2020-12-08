using System;
using TicTackToe.Class;


namespace TicTackToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Art art = new Art();
            // Show greeting, rules and so on...
            art.Greeting();
                // Instasiate classes
                Game game = new Game();
                string opponent = "";

            bool playing = true;
            while (playing)
            {

                
                // Choose opponent
                opponent = Console.ReadLine();

                if (opponent == "1" || opponent == "2")
                {
                    string[] gameArr = { "1", "2", "3", "4", "5", "6", "7", "8", "9"};
                    game.Play(opponent, gameArr);
                }
                else
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();

                    art.Greeting();
                    Console.WriteLine("You have to choose either 1 or 2!");
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
