namespace ComandLineGame.Code.Scores.Print
{
    class Print
    {
        public static void Base()
        {
            string post;
            post =
               System.Environment.NewLine +
               "Game Mode: " + Game.Mode +
               System.Environment.NewLine +
               "You archived: " + Game.combo +
               " hits";
            if (Game.Mode == "Std")
            {
                post += " in " + Game.elapseds + " seconds.";
            }
            post += System.Environment.NewLine + "Your score is: " + Game.CalcuatedScore +
           System.Environment.NewLine +
           "Press any key to try again or escape to exit" + System.Environment.NewLine;

            System.Console.WriteLine(post);
            
        }
    }
}
