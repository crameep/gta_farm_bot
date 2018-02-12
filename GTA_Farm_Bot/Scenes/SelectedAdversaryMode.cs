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

        public static Rectangle QuickJobList = new Rectangle()
        {
            X = 844,
            Y = 461,
            Width = 122,
            Height = 148
        };
        

        public override bool Match(ScriptBase script)
        {
            ulong bluredHash = ImageHashing.AverageHash(Helper.BlurFilter(script.CropFrame(QuickJobList)));
            var mainscript = script as Script;
            Bitmap posterizedimage = Helper.PosterizeFilter(script.CropFrame(QuickJobList));

           // mainscript.GTAform.DisplayImage(Helper.BlurFilter(posterizedimage));

            if (bluredHash == 140183445929855 || bluredHash == 140185576636160)
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
