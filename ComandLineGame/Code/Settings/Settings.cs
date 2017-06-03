namespace ComandLineGame.Code.Settings
{
    class SettingsVar
    {
        public static string ScoreFile = "core.cgs";
        public static string SettingsFile = "core.cfg";
        public static int lines = 10; //Lines shown in screen
        public static string key1;
        public static string key2;
        public static string key3;
        public static string key4;
    }

    class SettingsIO
    {
        public static void Initialize()
        {
            if (System.IO.File.Exists(SettingsVar.SettingsFile))
            {
                Load.Initialize();
            }
            else
            {
                Save.Create();
            }

            Settings.LoadConfig();
        }
    }
}
