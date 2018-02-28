using GTA_Farm_Bot.Classes;
using PS4MacroAPI;
using PS4MacroAPI.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Scenes
{
    class NotInGame : Scene
    {
        public override string Name => "Not in game";

        public static RectMap AlertText = new RectMap()
        {
            X = 165,
            Y = 607,
            Width = 28,
            Height = 29,
            Hash = 3974178274049144
        };

        public static RectMap TimeText = new RectMap()
        {
            X = 876,
            Y = 621,
            Width = 27,
            Height = 12,
            Hash = 139080675237376
        };

        public static RectMap JoiningText = new RectMap()
        {
            X = 874,
            Y = 618,
            Width = 93,
            Height = 17,
            Hash = 122593390559232
        };


        public override bool Match(ScriptBase script)
        {
            Helper.SceneDebugger(script, TimeText, this, true);
            Helper.SceneDebugger(script, JoiningText, this, true);
            Bitmap image = Helper.BlurFilter(script.CropFrame(Helper.RectmapToRectangle(JoiningText)));
            ulong hash = ImageHashing.AverageHash(image);

            double sim = ImageHashing.Similarity(hash, JoiningText.Hash);

            if ( !script.MatchTemplate(TimeText,90) && !script.MatchTemplate(AlertText,90))
            {
                if (sim >= 92)
                {
                    return false;
                }
                else return true;
            }

            else return true;
        }
       

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { Options = true});
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Right = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(250);

            for (int i = 1; i <= 98; i++)
            {
                script.Press(new DualShockState() { DPad_Down = true });
                script.Sleep(50);
            }
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(30000);
        }
    }
}
