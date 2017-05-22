using System;
namespace ConsoleGame.Game
{
    class Game
    {
        public static string Mode;// Std Test Others
        public static uint elapseds;
        public static uint combo;
        public static string output;
    }
    class Base
    {
        
        public static void Std()
        {
            Game.Mode = "Std";
            Game.combo = 0;
            bool hit = true;
            dynamic watch = System.Diagnostics.Stopwatch.StartNew();
            while (hit == true)
            {
                string key = Nextkey();
                string keyinfo = Convert.ToString(Console.ReadKey(true).Key);
                hit = keyinfo.Equals(key);
                if (hit == true)
                {
                    Game.combo++;
                }
            }
            OutputWriter.ClearCurrentConsole();
            OutputWriter.ClearLines();
            watch.Stop();
            Game.elapseds = Convert.ToUInt32(watch.ElapsedMilliseconds / 1000);
            Scores.Calculate();
        }

        private static string Nextkey()
        {
            Random rnd = new Random();
            switch (rnd.Next(1, 5))
            {
                case 1:
                    Game.output = "[Q]    [ ]    [ ]    [ ]";
                    OutputWriter.Output();
                    return "Q";
                case 2:
                    Game.output = "[ ]    [W]    [ ]    [ ]";
                    OutputWriter.Output();
                    return "W";
                case 3:
                    Game.output = "[ ]    [ ]    [E]    [ ]";
                    OutputWriter.Output();
                    return "E";
                case 4:
                    Game.output = "[ ]    [ ]    [ ]    [R]";
                    OutputWriter.Output();
                    return "R";
                default:
                    throw new System.ArgumentException("Go and fix this insomnya", "Newline");
            }
        }
    }
}
