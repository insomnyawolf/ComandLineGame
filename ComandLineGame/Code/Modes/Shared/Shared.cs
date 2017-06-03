namespace ComandLineGame.Code.Modes.Shared
{
    class Shared
    {
        public static string Nextkey()
        {
            System.Random rnd = new System.Random(System.DateTime.Now.Millisecond);
            switch (rnd.Next(1, 5))
            {
                case 1:
                    Game.output = "[█" + Settings.SettingsVar.key1 + "█]  [   ]  [   ]  [   ]";
                    return Settings.SettingsVar.key1;
                case 2:
                    Game.output = "[   ]  [█" + Settings.SettingsVar.key2 + "█]  [   ]  [   ]";
                    return Settings.SettingsVar.key2;
                case 3:
                    Game.output = "[   ]  [   ]  [█" + Settings.SettingsVar.key3 + "█]  [   ]";
                    return Settings.SettingsVar.key3;
                case 4:
                    Game.output = "[   ]  [   ]  [   ]  [█" + Settings.SettingsVar.key4 + "█]";
                    return Settings.SettingsVar.key4;
                default:
                    throw new System.ArgumentException("Go and fix this insomnya", "Newline");
            }
        }
    }
}
