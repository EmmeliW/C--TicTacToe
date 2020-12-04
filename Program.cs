using System;
using TicTackToe.Class;


namespace TicTackToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Begin();
        }


        static void Begin()
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
                    game.Play(opponent);
                }
                else
                {
                    //Console.SetCursorPosition(0, Console.CursorTop - 1);
                    //ClearCurrentConsoleLine();


                    art.Greeting();
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
