using GTA_Farm_Bot.Scenes;
using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GTA_Farm_Bot.Classes
{
    public class SettingsData
    {
        public List<RectMapObj> GameModeSelected { get; set; }

        public SettingsData()
        {
            Init();
        }

        public void Init()
        { 
           
            GameModeSelected = new List<RectMapObj>()
        {
            new RectMapObj()
            {
                Name = "QuickJobList",
                RectMap = new RectMap() { X = 844, Y = 461, Width = 122, Height = 148, Hash = 140183445929855 },
                Match = 99,
                Operator = "OR"
            },

              new RectMapObj()
            {
                Name = "FeaturedQuickJobListt",
                RectMap = new RectMap() { X = 844, Y = 461, Width = 122, Height = 148, Hash = 140185576636160 },
                Match = 99
            },


        };

        }

        public static void Serialize(string path, SettingsData data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SettingsData));
            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static SettingsData Deserialize(string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(SettingsData));
            using (TextReader reader = new StreamReader(path))
            {
                object obj = deserializer.Deserialize(reader);
                SettingsData data = obj as SettingsData;
                return data;
            }
        }
    }

    public class Settings
    {
        #region Singleton
        private static Settings instance;
        public static Settings Instance => instance ?? (instance = new Settings());
        #endregion


        public SettingsData Data { get; set; }

        private Settings()
        {
            Data = new SettingsData();
        }

        public void InitData()
        {
            if (Data == null) return;
            Data.Init();
        }

        public void Load(string path)
        {
            Data = SettingsData.Deserialize(path);
        }

        public void Save(string path)
        {
            SettingsData.Serialize(path, Data);
        }
    }
}
