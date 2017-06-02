namespace ComandLineGame.Code.Settings
{
    class KeyBinds
    {
        public static void Keybinds()
        {
            if (System.IO.File.Exists("config.xml"))
            {
                Load();
            }
            else
            {
                Create();
                Load();
            }
        }

        public static void Load()
        {
            System.Xml.XmlReader keys = System.Xml.XmlReader.Create("config.xml");
            keys.ReadStartElement("KeyBinds");
            Settings.key1 = keys.ReadElementContentAsString();
            Settings.key2 = keys.ReadElementContentAsString();
            Settings.key3 = keys.ReadElementContentAsString();
            Settings.key4 = keys.ReadElementContentAsString();
            keys.Close();
            keys.Dispose();
        }

        public static void Create()
        {
            System.Xml.XmlWriter keys = System.Xml.XmlWriter.Create("config.xml");
            keys.WriteStartElement("KeyBinds");
            keys.WriteElementString("key1", "D");
            keys.WriteElementString("key2", "F");
            keys.WriteElementString("key3", "J");
            keys.WriteElementString("key4", "K");
            keys.WriteEndElement();
            keys.Close();
            keys.Dispose();
        }
    }
}
