using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Imaging.Filters;
using GTA_Farm_Bot.Classes;
using System.Drawing;
using PS4MacroAPI.Internal;

namespace GTA_Farm_Bot.Scenes
{
    class Wasted: Scene
    {
        public override string Name => "Wasted";

        public static RectMap WastedText = new RectMap()
        {
            X = 157,
            Y = 239,
            Width = 696,
            Height = 237,
            Hash = 9187201402970077439
        };


        public override bool Match(ScriptBase script)
        {
       
            Bitmap image = script.CropFrame(Helper.RectmapToRectangle(WastedText));
            image = Helper.PosterizeFilter(image);
            ulong hash = ImageHashing.AverageHash(image);


            Helper.SceneDebugger(script, WastedText, this, false, true);

            if (ImageHashing.Similarity(WastedText.Hash, hash) >= 86)
            {

                return true;
            }

            else return false;
        }

        public override void OnMatched(ScriptBase script)
        {

            var mainscript = script as Script;
            mainscript.IncreaseDeathCount();
            script.Sleep(2000);
            script.Press(new DualShockState() { Cross = true });
            script.Press(new DualShockState() { Cross = true });
            script.Press(new DualShockState() { Cross = true });
            script.Press(new DualShockState() { Cross = true });

        }
    }
}
