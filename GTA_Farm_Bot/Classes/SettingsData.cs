using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Classes
{
    class SettingsData
    {

        public static int SleepTime { get; set; }
        public static int SleepTimeM { get; set; }
        public static int SleepTimeL { get; set; }
        public static int SleepTimeXL { get; set; }
        

        public SettingsData()
        {
            Init();
        }

        public void Init()
        {
            SleepTime = 250;
            SleepTimeM = 1000;
            SleepTimeL = 5000;
            SleepTimeXL = 10000;
        }
    }
}
