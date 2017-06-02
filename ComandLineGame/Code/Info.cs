namespace ComandLineGame.Code
{
    class Info
    {
        public static void Intro()
        {
                System.Console.WriteLine(
                "Press Ctrl + C To Stop" + System.Environment.NewLine +
                "Default keys are:  " + 
                Settings.Settings.key1 + "  " +
                Settings.Settings.key2 + "  " +
                Settings.Settings.key3 + "  " +
                Settings.Settings.key4 + System.Environment.NewLine +
                "Press P key to start without timmer or" + System.Environment.NewLine +
                "any other key to start the default mode" + System.Environment.NewLine);
        }

        public static void About()
        {
            OutputWriter.ClearCurrentConsole();
            System.Console.WriteLine(
                System.Environment.NewLine + System.Environment.NewLine +
                "This game was coded by insomnyawolf" + System.Environment.NewLine +
                "And ths is the about function example");
        }
    }
}
