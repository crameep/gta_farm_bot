using GTA_Farm_Bot.Classes;
using GTA_Farm_Bot.Forms;
using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_Farm_Bot.Scenes
    {
        class Parachute : Scene
        {
            
            public override string Name => "Parachuting";

            public static RectMap PlayerParachute = new RectMap()
            {
                X = 264,
                Y = 104,
                Width = 464,
                Height = 380,
                Hash = 9786268144528488310
            };

        public static RectMap TimeText = new RectMap()
        {
            X = 876,
            Y = 621,
            Width = 27,
            Height = 12,
            Hash = 139080675237376
        };



        public override bool Match(ScriptBase script)
            {
            Helper.SceneDebugger(script, PlayerParachute, this, true, true);
            return script.MatchTemplate(PlayerParachute,65) && script.MatchTemplate(TimeText, 90);
            }


        public override void OnMatched(ScriptBase script)
            {
                script.CaptureFrame();
                script.SetButtons(new DualShockState() { LX = 0 });
                script.Sleep(5000);
                script.SetButtons(new DualShockState() { LY = 128 });
                script.Sleep(1000);
            }
        }
    }


