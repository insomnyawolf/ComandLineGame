using System;
namespace ConsoleGame.Game
{
    class Base
    {
        static string output;
        public static void Basegame()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            bool game = true;
            uint combo = 0;
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
            uint elapseds = Convert.ToUInt32(watch.ElapsedMilliseconds / 1000);
            Game.Scores.Standard(combo, elapseds);
            OutputWriter.ClearLines();
        }

        public static string OutString()
        {
            return output;
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
