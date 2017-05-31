using System;
using System.Xml;

namespace ComandLineGame.Code.Scores.Local
{
    class Save
    {
        public static void SaveData()
        {
            if (System.IO.File.Exists(Environment.UserName + ".xml"))
            {
                XmlReader r = XmlReader.Create(Environment.UserName + ".xml");
                r.ReadStartElement(Environment.UserName);
                int oldscore = r.ReadElementContentAsInt();
                r.Close();
                if (oldscore <= Game.CalcuatedScore)
                {
                    Write();
                }
            }
            else
            {
                Write();
            }
        }
        private static void Write()
        {
            XmlWriter w = XmlWriter.Create(Environment.UserName + ".xml");
            w.WriteStartElement(Environment.UserName);
            w.WriteElementString("Score", Convert.ToString(Game.CalcuatedScore));
            w.WriteElementString("Combo", Convert.ToString(Game.combo));
            w.WriteElementString("Time", Convert.ToString(Game.elapseds));
            w.WriteElementString("Date", Convert.ToString(DateTime.Now));
            w.WriteEndElement();
            w.Close();
        }
    }
}
