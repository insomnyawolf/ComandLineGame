using System.Linq;

namespace ComandLineGame.Code
{
    class OutputWriter
    {
        static System.Collections.Generic.List<string> outputbuffer = new System.Collections.Generic.List<string>();
        static string outputline;
        static int outformat;

        public static void Output()
        {
            ClearCurrentConsole();

            if (outputbuffer.ElementAtOrDefault(Settings.SettingsVar.lines - 1) == null)
            {
                for (int x = 0; x < Settings.SettingsVar.lines; x++)
                {
                    outputbuffer.Add(System.String.Empty);
                }
            }
            outputbuffer.RemoveAt(0);
            outputbuffer.Add(Game.output);
            outputbuffer.Reverse();
            foreach (string thing in outputbuffer)
            {
                if(outformat <= Settings.SettingsVar.lines - 2)
                {
                    outputline += System.Environment.NewLine + "        " + thing + "        ";
                    outformat++;
                }
                else
                {
                    outputline += System.Environment.NewLine + "========" + thing + "========";
                    outformat = 0;
                }
            }
            outputbuffer.Reverse();
            System.Console.WriteLine(outputline);
            outputline = null;
        }

        public static void ClearLines()
        {
            outputbuffer.Clear();
        }

        public static void ClearCurrentConsole()
        {
            int currentLineCursor = ++System.Console.CursorTop;
            int targetLine = currentLineCursor - 100;
            while (currentLineCursor > targetLine && currentLineCursor > 3)
            {
                System.Console.SetCursorPosition(0, currentLineCursor);
                System.Console.Write(new string(' ', System.Console.WindowWidth));
                System.Console.SetCursorPosition(0, currentLineCursor);
                currentLineCursor--;
            }
        }
    }
}
