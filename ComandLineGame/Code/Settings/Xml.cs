namespace ComandLineGame.Code.Settings

{
    [System.Xml.Serialization.XmlType("config")]
    public class Config
    {
        [System.Xml.Serialization.XmlAttribute("k1")] public string K1 { get; set; }
        [System.Xml.Serialization.XmlAttribute("k2")] public string K2 { get; set; }
        [System.Xml.Serialization.XmlAttribute("k3")] public string K3 { get; set; }
        [System.Xml.Serialization.XmlAttribute("k4")] public string K4 { get; set; }
        [System.Xml.Serialization.XmlAttribute("lines")] public int Lines { get; set; }
    }

    [System.Xml.Serialization.XmlType("settings")]
    public class Settings
    {
        [System.Xml.Serialization.XmlAttribute("name")] public string Name { get; set; }
        [System.Xml.Serialization.XmlElement("configs")] public System.Collections.Generic.List<Config> Config { get; set; }

        public string ToXMLString()
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                serializer.Serialize(memoryStream, this);
                return System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }

        public bool ToXMLFile(string FileName)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            using (System.IO.FileStream s = new System.IO.FileStream(FileName, System.IO.FileMode.Create))
            {
                serializer.Serialize(s, this);
                s.Flush();
                s.Close();
                return true;
            }
        }

        public static Settings FromXMLString(string XML)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            using (System.IO.TextReader reader = new System.IO.StringReader(XML))
            {
                Settings Obj = (Settings)serializer.Deserialize(reader);
                return Obj;
            }
        }

        public static Settings FromXMLFile(string FileName)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            using (System.IO.FileStream reader = new System.IO.FileStream(FileName, System.IO.FileMode.Open))
            {
                Settings Obj = (Settings)serializer.Deserialize(reader);
                return Obj;
            }
        }

        public static void CreateConfig()
        {
            Settings Write = new Settings()
            {
                Config = new System.Collections.Generic.List<Config>
                {
                    new Config() { K1 = "D", K2 = "F", K3 = "J", K4 = "K", Lines = 10, }
                }
            };
            Write.ToXMLFile(SettingsVar.SettingsFile);
        }

        //Fix This

        //public static void OverwriteConfig()
        //{
        //    Settings Overwrite = Settings.FromXMLFile(SettingsVar.SettingsFile);
        //    Overwrite.Config.RemoveAt(); 
        //    Overwrite.Config.Add (new Config() { K1 = SettingsVar.key1, K2 = SettingsVar.key2, K3 = SettingsVar.key3, K4 = SettingsVar.key4, Lines = SettingsVar.lines });
        //    Overwrite.ToXMLFile(SettingsVar.SettingsFile);
        //}

        public static void AddConfig()
        {
            Settings Overwrite = Settings.FromXMLFile(SettingsVar.SettingsFile);
            Overwrite.Config.Add(new Config() { K1 = SettingsVar.key1, K2 = SettingsVar.key2, K3 = SettingsVar.key3, K4 = SettingsVar.key4, Lines = SettingsVar.lines });
            Overwrite.ToXMLFile(SettingsVar.SettingsFile);
        }

        public static void LoadConfig()
        {
            Settings Read = Settings.FromXMLFile(SettingsVar.SettingsFile);
            SettingsVar.key1 = Read.Config[0].K1;
            SettingsVar.key2 = Read.Config[0].K2;
            SettingsVar.key3 = Read.Config[0].K3;
            SettingsVar.key4 = Read.Config[0].K4;
            SettingsVar.lines = Read.Config[0].Lines;

        }
    }
}