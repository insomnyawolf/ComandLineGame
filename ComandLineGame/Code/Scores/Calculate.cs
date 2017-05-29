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
            int CalcuatedScore = Convert.ToInt32((10 * (Game.combo * Game.combo)) / ((++Game.elapseds) * 2));
            Print.Print.Base(CalcuatedScore);
            Code.Scores.Local.Save.SaveData(CalcuatedScore);
        }

        private static void NoTimmer()
        {
            int CalcuatedScore = Game.combo;
            Print.Print.Base(CalcuatedScore);
            Code.Scores.Local.Save.SaveData(CalcuatedScore);
        }
    }
}
