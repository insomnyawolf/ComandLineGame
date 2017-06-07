namespace ComandLineGame
{
    class Initialize
    {
        public static void Init()
        {
            Settings();
            Scores();
        }

        private static void Settings()
        {
            if (System.IO.File.Exists(Code.Settings.SettingsVar.SettingsFile))
            {
                Code.Settings.Load.Initialize();
            }
            else
            {
                Code.Settings.Save.Create();
            }

            Code.Settings.Settings.LoadConfig();
        }

        private static void Scores()
        {
            Code.Scores.Local.Id.LoadId();
        }
    }
}
