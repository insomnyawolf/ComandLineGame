using System;
//using ConsoleGame.Properties;

namespace ConsoleGame.Game
{

    class Scores
    {
        public static void Calculate()
        {
            //Como le indic que modo es?
            switch (Game.Mode)
            {
                case "Std":
                    Standart();
                    break;
                case "Test":
                    Console.WriteLine("Test Sucess");
                    break;
                default:
                    Console.WriteLine("Default is here");
                    break;
            }
        }

        private static void Standart()
        {
            uint CalcuatedScore = Convert.ToUInt32((10 * (Game.combo * Game.combo)) / ((++Game.elapseds) * 2));
            Output(CalcuatedScore);
        }

        private static void Output(uint CalcuatedScore)
        {

            Console.WriteLine(Environment.NewLine +
                                    "You archived: " + Game.combo + " hits in " + Game.elapseds + " seconds." + Environment.NewLine +
                                    "Your score is: " + CalcuatedScore + Environment.NewLine);
            Console.WriteLine("Press any key to try again or escape to exit" + Environment.NewLine);
             
        }
    }
}
