using System;
namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Info.Intro();
            bool done = false;
            while (!done)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        done = true;
                        break;
                    case ConsoleKey.A:
                        Game.Info.About();
                        break;
                    case ConsoleKey.P:
                        Game.Base.NoTimer();
                        break;
                    default:
                        Game.Base.Std();
                        break;
                }
            }
        }
    }
}