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
        class TheJump : Scene
        {
            
            public override string Name => "Ready to Jump";

            public static RectMap PlayerInHangar = new RectMap()
            {
                X = 396,
                Y = 611,
                Width = 217,
                Height = 28,
                Hash = 1695857090985750
            };

        public static RectMap PlayerInHangar2 = new RectMap()
        {
            X = 41,
            Y = 255,
            Width = 137,
            Height = 104,
            Hash = 15526828916543
        };

        public static RectMap TimeText = new RectMap()
        {
            X = 876,
            Y = 621,
            Width = 27,
            Height = 12,
            Hash = 139080675237376
        };

 

        public static RectMap SpectatingText = new RectMap()
        {
            X = 23,
            Y = 93,
            Width = 90,
            Height = 20,
            Hash = 1099511611392
        };

        public override bool Match(ScriptBase script)
            {
            return !script.MatchTemplate(SpectatingText,95) && script.MatchTemplate(TimeText, 95);
            }


        public override void OnMatched(ScriptBase script)
            {
                script.CaptureFrame();
                script.SetButtons(new DualShockState() { LY = 0 });
                script.Sleep(15000);
                script.Press(new DualShockState() { Cross = true });
                script.Sleep(15000);
                script.SetButtons(new DualShockState() { LY = 255 });
                script.Sleep(5000);
                script.SetButtons(new DualShockState() { LY = 128 });
                script.Sleep(1000);

            }
        }
    }


