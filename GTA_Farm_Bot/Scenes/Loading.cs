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
    class Loading : Scene
    {
        public override string Name => "Loading";

        public static RectMap LoadingText = new RectMap()
        {
            X = 861,
            Y = 618,
            Width = 75,
            Height = 17,
            Hash = 4945646389248
        };
        public static RectMap JoiningText = new RectMap()
        {
            X = 874,
            Y = 618,
            Width = 93,
            Height = 17,
            Hash = 122593390559232
        };
        public static Rectangle JoiningRect = new Rectangle()
        {
            X = 861,
            Y = 618,
            Width = 75,
            Height = 17,
        };

        public override bool Match(ScriptBase script)
        {
            var mainscript = script as Script;


            if (mainscript.GTAform.GetDebugging() && mainscript.GTAform.GetSceneDebug() == this.Name)
            {
                ulong lastHash = mainscript.GTAform.GetImageHash();
                Bitmap image = script.CropFrame(JoiningRect);
                double comparedHashes = ImageHashing.Similarity(mainscript.GTAform.GetImageHash(), ImageHashing.AverageHash(image));
                mainscript.GTAform.LogThis("Compared Loading Images with a " + comparedHashes + "% similarity");
                mainscript.updateImage(image);
            }

            ulong bluredHash = ImageHashing.AverageHash(Helper.BlurFilter(script.CropFrame(JoiningRect)));            
            Bitmap blurredImage= Helper.BlurFilter(script.CropFrame(JoiningRect));
           
            double sim = ImageHashing.Similarity(bluredHash, 123145302249472);
            

            if (sim >= 92)
            {
                return true;
            }
            else return false;
        }

        public override void OnMatched(ScriptBase script)
        {
            
            script.Sleep(1000);


        }
    }
}
