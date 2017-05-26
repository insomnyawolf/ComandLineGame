using System;

namespace ComandLineGame.Code.Scores.Print
{
    class Print
    {
        public static void Base(uint CalcuatedScore)
        {
            string post;
            post =
               Environment.NewLine +
               "Game Mode: " + Game.Mode +
               Environment.NewLine +
               "You archived: " + Game.combo +
               " hits";
            if (Game.Mode == "Std")
            {
                post += " in " + Game.elapseds + " seconds.";
            }
            post += Environment.NewLine + "Your score is: " + CalcuatedScore +
           Environment.NewLine +
           "Press any key to try again or escape to exit" + Environment.NewLine;

            Console.WriteLine(post);
        }
    }
}
