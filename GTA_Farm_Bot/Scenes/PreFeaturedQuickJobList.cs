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
           /// Console.WriteLine(bluredHash);

            if (bluredHash == 547599908735)
            {
                //Console.WriteLine("Pre Featured Adversary QuickJobList");
                return true;

            }

            else
            {
                //Console.WriteLine(bluredHash);
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
        }
    }
}
