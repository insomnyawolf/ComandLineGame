namespace ComandLineGame.Code.Scores.Local
{
    class Save
    {
        public static void Checks()
        {
            if(Game.CalcuatedScore > 100)
            {
                try
                {
                    Scores.AddData();
                }
                catch (System.InvalidOperationException)
                {
                    Scores.CreateSave();
                    Scores.AddData();
                }
                Game.Id++;
            }
        }
    }
}
