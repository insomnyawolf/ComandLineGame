namespace ComandLineGame.Code.Scores.Local
{
    class Load
    {
        
        public static void LoadData()
        {
            if(System.IO.File.Exists(Settings.Settings.Savefile))
            {
                Scores.LoadBest();
            }
            else
            {
                System.Console.WriteLine("Save something first");
            }
        }
    }
}
