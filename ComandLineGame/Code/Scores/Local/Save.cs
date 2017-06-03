﻿namespace ComandLineGame.Code.Scores.Local
{
    class Save
    {
        public static void Checks()
        {
            if(Game.CalcuatedScore > 100)
            {
                if (System.IO.File.Exists(Settings.SettingsVar.ScoreFile))
                {
                    try
                    {
                        Scores.AddData();
                    }
                    catch (System.InvalidOperationException)
                    {
                        Scores.CreateSave();
                    }
                }
                else
                {
                    Scores.CreateSave();
                }
            }
        }
    }
}
