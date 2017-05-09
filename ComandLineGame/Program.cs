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
                    default:
                        Game.Base.Basegame();
                        break;
                }
            }
        }
    }
}