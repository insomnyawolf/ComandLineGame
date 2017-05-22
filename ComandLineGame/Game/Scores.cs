using System;
//using ConsoleGame.Properties;  //Maybe i can use this to store locally the higest score

namespace ConsoleGame.Game
{

    class Scores
    {
        public static void Calculate()
        {
            switch (Game.Mode)
            {
                case "Standard":
                    Standard();
                    break;
                case "NoTimer":
                    NoTimmer();
                    break;
                default:
                    Console.WriteLine("Default is here");
                    break;
            }
        }

        private static void Standard()
        {
            uint CalcuatedScore = Convert.ToUInt32((10 * (Game.combo * Game.combo)) / ((++Game.elapseds) * 2));
            Output(CalcuatedScore);
        }

        private static void NoTimmer()
        {
            uint CalcuatedScore = Game.combo;
            Output(CalcuatedScore);
        }

        private static void Output(uint CalcuatedScore)
        {
            string post;
                post = 
                   Environment.NewLine +
                   "Game Mode: " + Game.Mode +
                   Environment.NewLine +
                   "You archived: " + Game.combo +
                   " hits";
            if (Game.Mode == "Standard")
            {
                post +=  " in " + Game.elapseds +" seconds.";
            }
                post +=  Environment.NewLine + "Your score is: " + CalcuatedScore +
               Environment.NewLine +
               "Press any key to try again or escape to exit" + Environment.NewLine;

            Console.WriteLine(post);
        }
    }
}
