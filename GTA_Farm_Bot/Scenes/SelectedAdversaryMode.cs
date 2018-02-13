using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA_Farm_Bot.Classes;
using PS4MacroAPI.Internal;
using GTA_Farm_Bot.Forms;

namespace GTA_Farm_Bot.Scenes
{
    class SelectAdversaryMode : Scene
    {
        public override string Name => "Selected Adversary Mode";

        public static RectMap QuickJobList = new RectMap()
        {
            X = 844,
            Y = 461,
            Width = 122,
            Height = 148, 
            Hash = 140183445929855

        };

        public static RectMap FeaturedQuickJobList = new RectMap()
        {
            X = 844,
            Y = 461,
            Width = 122,
            Height = 148,
            Hash = 140185576636160
        };

   
        public override bool Match(ScriptBase script)
        {
            
            Bitmap image = script.CropFrame(Helper.RectmapToRectangle(QuickJobList));
            image = Helper.PosterizeFilter(image, 90);
            image = Helper.BlurFilter(image);
            ulong hash = ImageHashing.AverageHash(image);          
            

            Helper.SceneDebugger(script, QuickJobList, this, true, true, 5000, null, 90);

            if (ImageHashing.Similarity(QuickJobList.Hash, hash) >= 99 || (ImageHashing.Similarity(FeaturedQuickJobList.Hash, hash) >= 99))
            {
               
                return true;
            }

            else return false;

        }

        public override void OnMatched(ScriptBase script)
        {

                script.Press(new DualShockState() { Cross = true });
                script.Sleep(250);
                script.Press(new DualShockState() { Cross = true });
                script.Sleep(250);
                script.Press(new DualShockState() { Cross = true });
                script.Sleep(250);
      

        }
    }
}
