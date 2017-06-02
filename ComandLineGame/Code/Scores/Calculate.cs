namespace ComandLineGame.Code.Scores
{
    class Scores
    {
        public static void Calculate()
        {
            Game.Date = System.Convert.ToString(System.DateTime.UtcNow);
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
            Game.CalcuatedScore = System.Convert.ToInt32((10 * (Game.combo * Game.combo)) / ((++Game.elapseds) * 2));
            Print.Print.Base();
            Code.Scores.Local.Save.Checks();
        }

        private static void NoTimmer()
        {
            Game.CalcuatedScore = Game.combo;
            Print.Print.Base();
            Code.Scores.Local.Save.Checks();
        }
    }
}
