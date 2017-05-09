using System;
//using ConsoleGame.Properties;
using System.IO;

namespace ConsoleGame.Game
{

    class Scores
    {

        public static void Standard(uint combo, uint elapseds)
        {
            uint score = Convert.ToUInt32((10 * (combo * combo)) / (++elapseds * 2));
            Console.WriteLine(Environment.NewLine +
                                    "You archived: " + combo + " hits in " + elapseds + " seconds." + Environment.NewLine +
                                    "Your score is: " + score + Environment.NewLine);
            Console.WriteLine("Press any key to try again or escape to exit" + Environment.NewLine);
             
        }
    }
}
