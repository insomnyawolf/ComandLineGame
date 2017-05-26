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
                        Code.Info.About();
                        break;
                    case ConsoleKey.P:
                        Code.Modes.NT.Base();
                        break;
                    default:
                        Code.Modes.Std.Base();
                        break;
                }
            }
        }
    }
}