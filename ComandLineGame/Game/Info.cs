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
                "Press P key to start without timmer or" + Environment.NewLine +
                "any other key to start the default mode" + Environment.NewLine);
        }

        public static void About()
        {
            OutputWriter.ClearCurrentConsole();
            Console.WriteLine(
                Environment.NewLine + Environment.NewLine +
                "This game was coded by insomnyawolf" + Environment.NewLine +
                "And ths is the about function example");
        }
    }
}
