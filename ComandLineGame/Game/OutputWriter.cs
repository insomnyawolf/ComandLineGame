using System;

namespace ConsoleGame.Game
{
    class OutputWriter
    {
        static string outputline1, outputline2, outputline3, outputline4, outputline5, outputline6, outputline7, outputline8, outputline9, outputline10;
        static string outputline;

        public static void ClearLines()
        {
            outputline1 = outputline2 = outputline3 = outputline4 = outputline5 = outputline6 = outputline7 = outputline8 = outputline9 = outputline10 = String.Empty;
        }

        public static void Output()
        {
            //This works but needs a rework
            outputline1 = outputline2;
            outputline2 = outputline3;
            outputline3 = outputline4;
            outputline4 = outputline5;
            outputline5 = outputline6;
            outputline6 = outputline7;
            outputline7 = outputline8;
            outputline8 = outputline9;
            outputline9 = "        " + outputline10;
            outputline10 = Game.output;
            outputline =
                outputline1 +
                Environment.NewLine +
                outputline2 +
                Environment.NewLine +
                outputline3 +
                Environment.NewLine +
                outputline4 +
                Environment.NewLine + 
                outputline5 +
                Environment.NewLine + 
                outputline6 +
                Environment.NewLine + 
                outputline7 +
                Environment.NewLine +
                outputline8 +
                Environment.NewLine +
                outputline9 +
                Environment.NewLine +
                "========" + outputline10 + "========";
            ClearCurrentConsole();
            Console.WriteLine(outputline);
        }

        public static void ClearCurrentConsole()
        {
            int currentLineCursor = ++Console.CursorTop;
            int targetLine = currentLineCursor - 100;
            while (currentLineCursor > targetLine  && currentLineCursor > 2)
            {
                Console.SetCursorPosition(0, currentLineCursor);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLineCursor);
                currentLineCursor--;
            }
        }
    }
}
