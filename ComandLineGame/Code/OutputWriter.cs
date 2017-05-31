using System;
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

            if (outputbuffer.ElementAtOrDefault(Game.lines - 1) == null)
            {
                for (int x = 0; x < Game.lines; x++)
                {
                    outputbuffer.Add(String.Empty);
                }
            }
            outputbuffer.RemoveAt(0);
            outputbuffer.Add(Game.output);
            outputbuffer.Reverse();
            foreach (string thing in outputbuffer)
            {
                if(outformat <= Game.lines - 2)
                {
                    outputline += Environment.NewLine + "        " + thing + "        ";
                    outformat++;
                }
                else
                {
                    outputline += Environment.NewLine + "========" + thing + "========";
                    outformat = 0;
                }
            }
            outputbuffer.Reverse();
            Console.WriteLine(outputline);
            outputline = null;
        }

        public static void ClearLines()
        {
            outputbuffer.Clear();
        }

        public static void ClearCurrentConsole()
        {
            int currentLineCursor = ++Console.CursorTop;
            int targetLine = currentLineCursor - 100;
            while (currentLineCursor > targetLine && currentLineCursor > 3)
            {
                Console.SetCursorPosition(0, currentLineCursor);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLineCursor);
                currentLineCursor--;
            }
        }
    }
}
