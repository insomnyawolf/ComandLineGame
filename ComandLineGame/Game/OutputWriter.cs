using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleGame.Game
{
    class OutputWriter
    {
        static List<string> outputbuffer = new List<string>();
        static string outputline;
        static int outformat;

        public static void ClearLines()
        {
            outputbuffer.Clear();
        }

        public static void Output()
        {
            ClearCurrentConsole();

            if (outputbuffer.ElementAtOrDefault(9) == null)
            {
                for (int x = 0; x < 10; x++)
                {
                    outputbuffer.Add(String.Empty);
                }
            }
            outputbuffer.RemoveAt(0);
            outputbuffer.Add(Game.output);
            foreach (string thing in outputbuffer)
            {
                if(outformat <= 8)
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
            Console.WriteLine(outputline);
            outputline = null;
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
