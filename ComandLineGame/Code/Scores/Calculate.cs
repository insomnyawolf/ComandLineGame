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
            Game.CalcuatedScore = Convert.ToInt32((10 * (Game.combo * Game.combo)) / ((++Game.elapseds) * 2));
            Print.Print.Base();
            Code.Scores.Local.Save.SaveData();
        }

        private static void NoTimmer()
        {
            Game.CalcuatedScore = Game.combo;
            Print.Print.Base();
            Code.Scores.Local.Save.SaveData();
        }
    }
}
