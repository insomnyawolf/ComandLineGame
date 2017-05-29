using System;

namespace ComandLineGame.Code.Modes
{
    class Std
    {
        public static void Base()
        {
            Game.Mode = "Std";
            Game.combo = 0;
            bool hit = true;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (hit == true)
            {
                string key = Shared.Shared.Nextkey();
                string keyinfo = Convert.ToString(Console.ReadKey(true).Key);
                hit = keyinfo.Equals(key);
                if (hit == true)
                {
                    Game.combo++;
                }
            }
            watch.Stop();
            Game.elapseds = Convert.ToInt32(watch.ElapsedMilliseconds / 1000);
            Scores.Scores.Calculate();
        }
    }
}
