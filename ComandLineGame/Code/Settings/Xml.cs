namespace ComandLineGame.Code.Settings

{
    [System.Xml.Serialization.XmlType("keys")]
    public class Keys
    {
        [System.Xml.Serialization.XmlAttribute("k1")] public string K1 { get; set; }
        [System.Xml.Serialization.XmlAttribute("k2")] public string K2 { get; set; }
        [System.Xml.Serialization.XmlAttribute("k3")] public string K3 { get; set; }
        [System.Xml.Serialization.XmlAttribute("k4")] public string K4 { get; set; }
    }

    [System.Xml.Serialization.XmlType("settings")]
    public class Settings
    {
        [System.Xml.Serialization.XmlAttribute("name")] public string Name { get; set; }
        [System.Xml.Serialization.XmlElement("keys")] public System.Collections.Generic.List<Keys> Keys { get; set; }

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
            Settings Binds = new Settings()
            {
                Keys = new System.Collections.Generic.List<Keys>
                {
                    new Keys() { K1 = "D", K2 = "F", K3 = "J", K4 = "K" }
                }
            };
            Binds.ToXMLFile(SettingsVar.SettingsFile);
        }

        public static void OverwriteConfig()
        {
            Settings Binds = new Settings()
            {
                Keys = new System.Collections.Generic.List<Keys>
                {
                    new Keys() { K1 = SettingsVar.key1, K2 = SettingsVar.key2, K3 = SettingsVar.key3, K4 = SettingsVar.key4 }
                }
            };
            Binds.ToXMLFile(SettingsVar.SettingsFile);
        }

        public static void LoadConfig()
        {
            Settings ReadKeys = Settings.FromXMLFile(SettingsVar.SettingsFile);
            SettingsVar.key1 = ReadKeys.Keys[0].K1;
            SettingsVar.key2 = ReadKeys.Keys[0].K2;
            SettingsVar.key3 = ReadKeys.Keys[0].K3;
            SettingsVar.key4 = ReadKeys.Keys[0].K4;
        }
    }
}