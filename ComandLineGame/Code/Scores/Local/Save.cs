using System;
using System.Xml;

namespace ComandLineGame.Code.Scores.Local
{
    class Save
    {
        public static void SaveData(int CalcuatedScore)
        {
            XmlWriter w = XmlWriter.Create(Environment.UserName + ".xml");
            w.WriteStartElement(Environment.UserName);
            w.WriteElementString("Date", Convert.ToString(DateTime.Now));
            w.WriteElementString("Score", Convert.ToString(CalcuatedScore));
            w.WriteElementString("Combo", Convert.ToString(Game.combo));
            w.WriteElementString("Time", Convert.ToString(Game.elapseds));
            w.WriteEndElement();
            w.Close();
        }
    }
}
