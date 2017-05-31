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
                    Game.output = "[Q]    [ ]    [ ]    [ ]";
                    return "Q";
                case 2:
                    Game.output = "[ ]    [W]    [ ]    [ ]";
                    return "W";
                case 3:
                    Game.output = "[ ]    [ ]    [E]    [ ]";
                    return "E";
                case 4:
                    Game.output = "[ ]    [ ]    [ ]    [R]";
                    return "R";
                default:
                    throw new System.ArgumentException("Go and fix this insomnya", "Newline");
            }
        }
    }
}
