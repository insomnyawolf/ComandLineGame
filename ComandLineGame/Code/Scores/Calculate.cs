using System;

namespace ComandLineGame.Code.Scores
{
    class Scores
    {
        public static void Calculate()
        {
            switch (Game.Mode)
            {
                case "Std":
                    Standard();
                    break;
                case "NT":
                    NoTimmer();
                    break;
            }
        }

        private static void Standard()
        {
            uint CalcuatedScore = Convert.ToUInt32((10 * (Game.combo * Game.combo)) / ((++Game.elapseds) * 2));
            Print.Print.Base(CalcuatedScore);
        }

        private static void NoTimmer()
        {
            uint CalcuatedScore = Game.combo;
            Print.Print.Base(CalcuatedScore);
        }
    }
}
