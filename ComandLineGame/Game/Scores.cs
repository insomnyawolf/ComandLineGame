using System;
//using ConsoleGame.Properties;
using System.IO;

namespace ConsoleGame.Game
{

    class Scores
    {
        public static void Calculate(string mode)
        {
            switch (mode)
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
            uint CalcuatedScore = Convert.ToUInt32((10 * (Base.combo * Base.combo)) / ((++Base.elapseds) * 2));
            Output(CalcuatedScore);
        }

        private static void Output(uint CalcuatedScore)
        {

            Console.WriteLine(Environment.NewLine +
                                    "You archived: " + Base.combo + " hits in " + Base.elapseds + " seconds." + Environment.NewLine +
                                    "Your score is: " + CalcuatedScore + Environment.NewLine);
            Console.WriteLine("Press any key to try again or escape to exit" + Environment.NewLine);
             
        }
    }
}
