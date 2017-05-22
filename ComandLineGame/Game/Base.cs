using System;
namespace ConsoleGame.Game
{
    class Base
    {
        public static uint elapseds;
        public static uint combo;
        public static string output;
        public static void Basegame()
        {
            dynamic watch = System.Diagnostics.Stopwatch.StartNew();
            combo = 0;
            bool game = true;
            while (game == true)
            {
                string key = Nextkey();
                string keyinfo = Convert.ToString(Console.ReadKey(true).Key);
                game = Correct(keyinfo, key);
                switch (game)
                {
                    case true:
                        combo++;
                        break;
                    default:
                        OutputWriter.ClearCurrentConsole();
                        break;
                }
            }
            watch.Stop();
            elapseds = Convert.ToUInt32(watch.ElapsedMilliseconds / 1000);
            Game.Scores.Calculate("Std");
            OutputWriter.ClearLines();
        }

        private static bool Correct(string keyinfo, string key)
        {
            return keyinfo == key;
        }

        private static string Nextkey()
        {
            Random rnd = new Random();
            switch (rnd.Next(1, 5))
            {
                case 1:
                    output = "[Q]    [ ]    [ ]    [ ]";
                    OutputWriter.Output();
                    return "Q";
                case 2:
                    output = "[ ]    [W]    [ ]    [ ]";
                    OutputWriter.Output();
                    return "W";
                case 3:
                    output = "[ ]    [ ]    [E]    [ ]";
                    OutputWriter.Output();
                    return "E";
                case 4:
                    output = "[ ]    [ ]    [ ]    [R]";
                    OutputWriter.Output();
                    return "R";
                default:
                    throw new System.ArgumentException("Go and fix this insomnya", "Newline");
            }
        }
    }
}
