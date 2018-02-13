using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA_Farm_Bot.Classes;
using PS4MacroAPI.Internal;

namespace GTA_Farm_Bot.Scenes
{
    class PreFeaturedQuickJobList : Scene
    {
        public override string Name => "Pre Featured Job List";


        public static RectMap QuickJobList = new RectMap()
        {
            X = 844,
            Y = 461,
            Width = 122,
            Height = 148,
            Hash = 547599908735
        };

        public override bool Match(ScriptBase script)
        {
            ulong bluredHash = ImageHashing.AverageHash(Helper.BlurFilter(script.CropFrame(Helper.RectmapToRectangle(QuickJobList))));
            Helper.SceneDebugger(script, QuickJobList, this);

            if (bluredHash == 547599908735)
            {
                
                return true;

            }

            else
            {
                
                return false;
            }

        }

        public override void OnMatched(ScriptBase script)
        {
           

            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
        }
    }
}
