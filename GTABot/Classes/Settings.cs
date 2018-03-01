using GTABot.Scenes;
using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace GTABot.Classes
{
    public class SceneConditionCollection
    {
        public SceneConditionMap Freemode { get; set; }
        public SceneConditionMap Freemode_Bed { get; set; }
        public SceneConditionMap AFK { get; set; }
        public SceneConditionMap Game { get; set; }
        public SceneConditionMap Alert { get; set; }

        // Constructor
        public SceneConditionCollection() { }

        // Shortcut operator to access the value using '[]'
        public List<ConditionMap> this[string key]
        {
            get
            {
                return GetType().GetProperty(key).GetValue(this, null) as List<ConditionMap>;
            }
        }

        // Shortcut method for creating enumerable
        public List<string> GetPropertyNames()
        {
            var result = new List<string>();
            foreach (var pi in GetType().GetProperties())
            {
                result.Add(pi.Name);
            }
            return result;
        }
    }

    public class SceneConditionMap
    {
        public List<ConditionMap> Conditions { get; set; }

        // Constructor
        public SceneConditionMap() { }
    }

    public class SettingsData
    {

        public List<ConditionMap> Alert { get; set; }
        public List<ConditionMap> AFK { get; set; }
        public List<ConditionMap> Game { get; set; }

        public SceneConditionCollection SceneConditions { get; set; }


        public SettingsData()
        {
            Init();
        }

        public void Init()
        {

            SceneConditions = new SceneConditionCollection();

            ///////////// Freemode searches for the tiny icon saying you have an invite ///////////
            SceneConditions.Freemode = new SceneConditionMap()
            {
                Conditions = new List<ConditionMap>()
                {
                    new ConditionMap()
                    {
                        Name = "InviteIcon",
                        RectMap = new RectMap() {  X = 167, Y = 609, Width = 21, Height = 27, Hash = 17873110456848383 },
                        Match = 88,
                        Required = true
                    },

                        new ConditionMap()
                    {
                        Name = "TimeText",
                        RectMap = new RectMap() { X = 876, Y = 621, Width = 27, Height = 12, Hash = 3974178274049144 },
                        Match = 95,
                        Required = false
                    },

                    new ConditionMap()
                    {
                        Name = "LoadingText",
                        RectMap = new RectMap() { X = 874, Y = 618, Width = 93, Height = 17, Hash = 122593390559232 },
                        Match = 92,
                        Required = false
                    },
                }
            };

            ///////////////// Freemode in Facility Spawn/////////////////////
            SceneConditions.Freemode_Bed = new SceneConditionMap()
            {
                Conditions = new List<ConditionMap>()
                {
                    new ConditionMap()
                    {
                        Name = "GetInBed",
                        RectMap = new RectMap() {  X = 23, Y = 97, Width = 147, Height = 20, Hash = 246288448684032 },
                        Match = 88,
                        Required = true
                    },

                        new ConditionMap()
                    {
                        Name = "TimeText",
                        RectMap = new RectMap() { X = 876, Y = 621, Width = 27, Height = 12, Hash = 3974178274049144 },
                        Match = 95,
                        Required = false
                    },

                    new ConditionMap()
                    {
                        Name = "LoadingText",
                        RectMap = new RectMap() { X = 874, Y = 618, Width = 93, Height = 17, Hash = 122593390559232 },
                        Match = 92,
                        Required = false
                    },
                }
            };

            ///////////////// AFK Scene /////////////////////
            SceneConditions.AFK = new SceneConditionMap()
            {
                Conditions = new List<ConditionMap>()
                {
                    new ConditionMap()
                    {
                        Name = "KickText",
                        RectMap = new RectMap() { X = 24, Y = 494, Width = 55, Height = 29, Hash = 33635173148884736},
                        Match = 93,
                        Required = true
                    },
                }
            };


            ///////////////// Game Scene /////////////////////
            SceneConditions.Game = new SceneConditionMap()
            {
                Conditions = new List<ConditionMap>()
                {
                    new ConditionMap()
                    {
                        Name = "TimeText",
                        RectMap = new RectMap() {  X = 910, Y = 617, Width = 26, Height = 18, Hash = 547599892224},
                        Match = 95,
                        Required = true
                    },
                }
            };

            ///////////////// Alert Scene /////////////////////
            SceneConditions.Alert = new SceneConditionMap()
            {
                Conditions = new List<ConditionMap>()
                {
                    new ConditionMap()
                    {
                        Name = "AlertText",
                        RectMap = new RectMap() { X = 413, Y = 297, Width = 176, Height = 66, Hash = 122593390591744 },
                        Match = 95,
                        Required = true
                    },
                }
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