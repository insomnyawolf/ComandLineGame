using System;
namespace ConsoleGame.Game
{
    class Info
    {
        public static void Intro()
        {
            Console.WriteLine(
                "Press Ctrl + C To Stop" + Environment.NewLine +
                "Default keys are: Q,W,E,R" + Environment.NewLine +
                "Press any key to start" + Environment.NewLine);
        }
    }
}
