using System.Linq;

namespace ComandLineGame.Code.Scores.Local

{
    [System.Xml.Serialization.XmlType("score")]
    public class ScoreData
    {
        [System.Xml.Serialization.XmlAttribute("score")] public int Score { get; set; }
        [System.Xml.Serialization.XmlAttribute("combo")] public int Combo { get; set; }
        [System.Xml.Serialization.XmlAttribute("time")] public int Time { get; set; }
        [System.Xml.Serialization.XmlAttribute("name")] public string Name { get; set; }
        [System.Xml.Serialization.XmlAttribute("date")] public string Date { get; set; }
    }

    [System.Xml.Serialization.XmlType("scores")]
    public class Scores
    {
        [System.Xml.Serialization.XmlAttribute("name")] public string Name { get; set; }
        [System.Xml.Serialization.XmlElement("score")] public System.Collections.Generic.List<ScoreData> Score { get; set; }

        public string ToXMLString()
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Scores));
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                serializer.Serialize(memoryStream, this);
                return System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }

        public bool ToXMLFile(string FileName)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Scores));
            using (System.IO.FileStream s = new System.IO.FileStream(FileName, System.IO.FileMode.Create))
            {
                serializer.Serialize(s, this);
                s.Flush();
                s.Close();
                return true;
            }
        }

        public static Scores FromXMLString(string XML)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Scores));
            using (System.IO.TextReader reader = new System.IO.StringReader(XML))
            {
                Scores Obj = (Scores)serializer.Deserialize(reader);
                return Obj;
            }
        }

        public static Scores FromXMLFile(string FileName)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Scores));
            using (System.IO.FileStream reader = new System.IO.FileStream(FileName, System.IO.FileMode.Open))
            {
                Scores Obj = (Scores)serializer.Deserialize(reader);
                return Obj;
            }
        }

        public static void CreateSave()
        {
            Scores U = new Scores()
            {
                Score = new System.Collections.Generic.List<ScoreData>
                {
                    new ScoreData() { Score = Game.CalcuatedScore, Combo = Game.combo, Time = Game.elapseds, Name = Game.Name, Date = Game.Date }
                }
            };
            U.ToXMLFile(Settings.SettingsVar.ScoreFile);
        }
        public static void AddData()
        {
            Scores ReadUser = Scores.FromXMLFile(Settings.SettingsVar.ScoreFile);
            ReadUser.Score.Add(new ScoreData() { Score = Game.CalcuatedScore, Combo = Game.combo, Time = Game.elapseds, Name = Game.Name, Date = Game.Date });
            ReadUser.ToXMLFile(Settings.SettingsVar.ScoreFile);
        }

        public static void LoadBest()
        {
            Scores ReadUser = Scores.FromXMLFile(Settings.SettingsVar.ScoreFile);
            foreach(var score in ReadUser.Score)
            {
                if(score.Score > Game.topscore)
                {
                    Game.topscore = score.Score;
                }
            }
            System.Console.WriteLine("Your topscore is: " + Game.topscore);
        }
    }
}
