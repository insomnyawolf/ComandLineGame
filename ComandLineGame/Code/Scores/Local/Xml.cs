using System.Linq;

namespace ComandLineGame.Code.Scores.Local

{
    [System.Xml.Serialization.XmlType("score")]
    public class ScoreData
    {
        [System.Xml.Serialization.XmlAttribute("id")] public int Id { get; set; }
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
                    new ScoreData() { Id = Game.Id, Score = Game.CalcuatedScore, Combo = Game.combo, Time = Game.elapseds, Name = Game.Name, Date = Game.Date }
                }
            };
            U.ToXMLFile(Settings.SettingsVar.ScoreFile);
        }
        public static void AddData()
        {
            Scores ReadScore = Scores.FromXMLFile(Settings.SettingsVar.ScoreFile);
            ReadScore.Score.Add(new ScoreData() { Id = Game.Id, Score = Game.CalcuatedScore, Combo = Game.combo, Time = Game.elapseds, Name = Game.Name, Date = Game.Date });
            ReadScore.ToXMLFile(Settings.SettingsVar.ScoreFile);
        }

        public static void LoadId()
        {
            Scores ReadScore = Scores.FromXMLFile(Settings.SettingsVar.ScoreFile);
            int Load = ReadScore.Score.Max(x => (int)x.Id);
            Game.Id = ++Load;
        }

        public static void LoadBest()
        {
            Scores ReadScore = Scores.FromXMLFile(Settings.SettingsVar.ScoreFile);
            int Load = ReadScore.Score.Max(x => (int)x.Score);
            //Game.LoadId = ReadScore.Score.Find.Score
            System.Console.WriteLine(ReadScore.Score[Game.LoadId].Name);
        }
    }
}
