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
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        done = true;
                        break;
                    case ConsoleKey.A:
                        Code.OutputWriter.ClearCurrentConsole();
                        Code.OutputWriter.ClearLines();
                        Code.Info.About();
                        break;
                    case ConsoleKey.P:
                        Code.OutputWriter.ClearCurrentConsole();
                        Code.OutputWriter.ClearLines();
                        Code.Modes.NT.Base();
                        break;
                    case ConsoleKey.L:
                        Code.OutputWriter.ClearCurrentConsole();
                        Code.OutputWriter.ClearLines();
                        Code.Scores.Local.Load.LoadData();
                        break;
                    default:
                        Code.OutputWriter.ClearCurrentConsole();
                        Code.OutputWriter.ClearLines();
                        Code.Modes.Std.Base();
                        break;
                }
            }
        }
    }
}