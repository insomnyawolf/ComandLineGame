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
                XmlReader r = XmlReader.Create(Environment.UserName + ".xml");
                r.ReadStartElement(Environment.UserName);
                Game.CalcuatedScore = r.ReadElementContentAsInt();
                Game.combo = r.ReadElementContentAsInt();
                Game.elapseds = r.ReadElementContentAsInt();
                Console.WriteLine(Environment.NewLine + r.ReadElementContentAsString());
                r.Close();
                Print.Print.Base();
                
            }
            else
            {
                Console.WriteLine("Save something first");
            }
        }
    }
}
