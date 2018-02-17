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
            Helper.SceneDebugger(script, JoiningText, this, true);
            Bitmap image = Helper.BlurFilter(script.CropFrame(Helper.RectmapToRectangle(JoiningText)));
            ulong hash = ImageHashing.AverageHash(image);

            double sim = ImageHashing.Similarity(hash, JoiningText.Hash);


            if (sim >= 92)
            {
                return true;
            }
            else return false;
        }

        public override void OnMatched(ScriptBase script)
        {

            script.Sleep(60000);


        }
    }
}
