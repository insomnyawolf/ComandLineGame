using System;

namespace ComandLineGame.Code.Modes.Shared
{
    class Shared
    {
        public static string Nextkey()
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
