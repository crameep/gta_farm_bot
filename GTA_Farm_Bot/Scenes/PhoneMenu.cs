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
    class PhoneMenu : Scene
    {
        public override string Name => "Phone Menu";

        public static RectMap JobList = new RectMap()
        {
            X = 842,
            Y = 459,
            Width = 126,
            Height = 21,
            Hash = 35887507612368896
        };


        public override bool Match(ScriptBase script)
        {

            var mainscript = script as Script;

            if (mainscript.GTAform.GetDebugging() && mainscript.GTAform.GetSceneDebug() == this.Name)
            {
                ulong lastHash = mainscript.GTAform.GetImageHash();
                Bitmap image = script.CropFrame(Helper.RectmapToRectangle(JobList));
                double comparedHashes = ImageHashing.Similarity(JobList.Hash, ImageHashing.AverageHash(image));
                mainscript.GTAform.LogThis("Compared Freemode Images with our character hash " + comparedHashes + "% similarity");
                mainscript.updateImage(image);
            }


            return script.MatchTemplate(JobList, 98); 
            
        }

        public override void OnMatched(ScriptBase script)
        {
            
            script.Press(new DualShockState() { DPad_Left = true });
            script.Sleep(1000);
            script.Press(new DualShockState() { Cross = true });
        }
    }
}
