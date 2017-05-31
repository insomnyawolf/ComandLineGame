using System;
using System.Linq;

namespace ComandLineGame.Code.Modes
{
    class Std
    {
        static System.Collections.Generic.List<string> keybuffer = new System.Collections.Generic.List<string>();
        public static void Base()
        {
            Game.Mode = "Std";
            Game.combo = 0;
            bool hit = true;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (hit == true)
            {
                if (keybuffer.ElementAtOrDefault(Game.lines - 1) == null)
                {
                    for (int x = 0; x < Game.lines; x++)
                    {
                        keybuffer.Add(Shared.Shared.Nextkey());
                        OutputWriter.Output();
                    }
                }
                keybuffer.Add(Shared.Shared.Nextkey());
                OutputWriter.Output();
                string keyinfo = Convert.ToString(Console.ReadKey(true).Key);
                hit = keyinfo.Equals(keybuffer[1].ToString());
                keybuffer.RemoveAt(0);
                if (hit == true)
                {
                    Game.combo++;
                }
                else
                {
                    keybuffer.Clear();
                }
            }
            watch.Stop();
            Game.elapseds = Convert.ToInt32(watch.ElapsedMilliseconds / 1000);
            Scores.Scores.Calculate();
        }
    }
}
