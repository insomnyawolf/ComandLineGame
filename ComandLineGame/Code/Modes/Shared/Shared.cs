using System;

namespace ComandLineGame.Code.Modes.Shared
{
    class Shared
    {
        public static string Nextkey()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            switch (rnd.Next(1, 5))
            {
                case 1:
                    Game.output = "[" + Settings.Settings.key1 + "]    [ ]    [ ]    [ ]";
                    return Settings.Settings.key1;
                case 2:
                    Game.output = "[ ]    [" + Settings.Settings.key2 + "]    [ ]    [ ]";
                    return Settings.Settings.key2;
                case 3:
                    Game.output = "[ ]    [ ]    [" + Settings.Settings.key3 + "]    [ ]";
                    return Settings.Settings.key3;
                case 4:
                    Game.output = "[ ]    [ ]    [ ]    [" + Settings.Settings.key4 + "]";
                    return Settings.Settings.key4;
                default:
                    throw new System.ArgumentException("Go and fix this insomnya", "Newline");
            }
        }
    }
}
