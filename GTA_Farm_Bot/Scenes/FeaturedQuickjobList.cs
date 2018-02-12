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
        public override string Name => "Featured QuickJoblist";


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

          //  if (mainscript.GTAform.GetDebugging())
          //  {
          //      ulong lastHash = mainscript.GTAform.GetImageHash();
          //      Bitmap image = script.CropFrame(QuickJobList);
          //      double comparedHashes = ImageHashing.Similarity(547608297343, ImageHashing.AverageHash(image));
          //      mainscript.GTAform.LogThis("Compared FQJL Images with a " + comparedHashes + "% similarity");
          //      mainscript.updateImage(image);
          //  }

            if (bluredHash == 547608297343)
            {
                
                return true;

            }

            else
            {
               // Console.WriteLine(bluredHash);
                return false;
            }

        }

        public override void OnMatched(ScriptBase script)
        {
            //Console.WriteLine("Adversary Mode Selected Matched");

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

        }
    }
}
