namespace ComandLineGame.Code.Settings
{
    class Settings
    {
        public static string Savefile = "core.cgs";
        public static int lines = 10; //Lines shown in screen
        public static string key1;
        public static string key2;
        public static string key3;
        public static string key4;
    }

    class SettingsInitialize
    {
        public static void Initialize()
        {
            KeyBinds.Keybinds();
        }
    }
}
