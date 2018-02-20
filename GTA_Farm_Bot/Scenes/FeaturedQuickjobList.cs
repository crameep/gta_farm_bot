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
    class FeaturedQuickJobList : Scene
    {
        public override string Name => "Featured QuickJobList";

        List<RectMapObj> mapList = new List<RectMapObj>()
        {
            new RectMapObj()
            {
                Name = "FeaturedQuickJoblist",
                RectMap = new RectMap() { X = 844, Y = 461, Width = 122, Height = 148, Hash = 547599908735 },
                Match = 95                
            }
        };
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
            Bitmap image = script.CropFrame(Helper.RectmapToRectangle(QuickJobList));
            image = Helper.PosterizeFilter(image, 90);
            image = Helper.BlurFilter(image);
            ulong hash = ImageHashing.AverageHash(image);

            SceneDebugger debugger = new SceneDebugger(script, QuickJobList, this)
            {
                Blur = false
            };

            debugger.Run();

            Helper.SceneDebugger(script, QuickJobList, this, true, true, 5000, null, 90, true);

            if (hash == QuickJobList.Hash)
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
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });

        }
    }
}
