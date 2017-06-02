namespace ComandLineGame.Code.Modes
{
    class NT
    {
        public static void Base()
        {
            Game.Mode = "NT";
            Game.combo = 0;
            bool hit = true;
            while (hit == true)
            {
                string key = Shared.Shared.Nextkey();
                string keyinfo = System.Convert.ToString(System.Console.ReadKey(true).Key);
                hit = keyinfo.Equals(key);
                if (hit == true)
                {
                    Game.combo++;
                }
            }
            Scores.Scores.Calculate();
        }
    }
}
