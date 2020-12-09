using System;
using TicTackToe.Class;


namespace TicTackToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop for the game
            bool GameIsPlayed = true;
            do
            {
                PlayTheGame();
            }
            while (GameIsPlayed);
        }

        static void PlayTheGame()
        { 
            // Instansiate classes
            Art art = new Art();
            Game game = new Game();

            // This is ruels and menu
            art.Greeting();

            // Loop for checking opponent or exit
            bool playing = true;
            while (playing)
            {                
                string opponent = "";
                // Choose opponent
                opponent = Console.ReadLine();

                // Play the game if opponent 1 or 2 and exit if x
                if (opponent == "1" || opponent == "2")
                {
                    game.Play(opponent);
                    playing = false;
                }
                else if (opponent == "x") 
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                else
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();

                    art.Greeting();
                    Console.WriteLine("You have to choose either 1 or 2! (Or exit wirh x)");
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
