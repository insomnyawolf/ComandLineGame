using System;
namespace ComandLineGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Code.Info.Intro();
            bool done = false;
            while (!done)
            {
                var input = Console.ReadKey(true).Key;
                Code.OutputWriter.ClearCurrentConsole();
                switch (input)
                {
                    case ConsoleKey.Escape:
                        done = true;
                        break;
                    case ConsoleKey.A:
                        Code.Info.About();
                        break;
                    case ConsoleKey.P:
                        Code.Modes.NT.Base();
                        break;
                    case ConsoleKey.L:
                        Code.Scores.Local.Load.LoadData();
                        break;
                    default:
                        Code.Modes.Std.Base();
                        break;
                }
            }
        }
    }
}