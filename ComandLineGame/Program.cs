namespace ComandLineGame
{
    class Program
    {
        static void Main()
        {
            Initialize.Init();
            Code.Info.Intro();
            bool done = false;
            while (!done)
            {
                System.ConsoleKey input = System.Console.ReadKey(true).Key;
                Code.OutputWriter.ClearCurrentConsole();
                switch (input)
                {
                    case System.ConsoleKey.Escape:
                        done = true;
                        break;
                    case System.ConsoleKey.A:
                        Code.Info.About();
                        break;
                    case System.ConsoleKey.P:
                        Code.Modes.NT.Base();
                        break;
                    case System.ConsoleKey.L:
                        Code.Scores.Local.Load.LoadData();
                        break;
                    default:
                        Code.Modes.Std.Base();
                        break;
                }
            }
        }
    }
}