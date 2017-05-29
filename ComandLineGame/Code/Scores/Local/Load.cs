using System;
using System.Xml;

namespace ComandLineGame.Code.Scores.Local
{
    class Load
    {
        
        public static void LoadData()
        {
            if (System.IO.File.Exists(Environment.UserName + ".xml"))
            {
                int CalcuatedScore;
                XmlReader r = XmlReader.Create(Environment.UserName + ".xml");
                r.ReadStartElement(Environment.UserName);
                Console.WriteLine(Environment.NewLine + r.ReadElementContentAsString());
                CalcuatedScore = r.ReadElementContentAsInt();
                Game.combo = r.ReadElementContentAsInt();
                Game.elapseds = r.ReadElementContentAsInt();
                r.Close();
                Print.Print.Base(CalcuatedScore);
                
            }
            else
            {
                Console.WriteLine("Save something first");
            }
        }
    }
}
