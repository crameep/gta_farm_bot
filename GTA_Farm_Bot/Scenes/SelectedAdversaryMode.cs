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

        List<RectMapObj> mapList = new List<RectMapObj>()
        {
            new RectMapObj()
            {
                Name = "QuickJobList",
                RectMap = new RectMap() { X = 844, Y = 461, Width = 122, Height = 148, Hash = 140183445929855 },
                Match = 99,
                Operator = "OR"
            },

              new RectMapObj()
            {
                Name = "FeaturedQuickJobListt",
                RectMap = new RectMap() { X = 844, Y = 461, Width = 122, Height = 148, Hash = 140185576636160 },
                Match = 99
            },


        };
        public override bool Match(ScriptBase script)
        {
            bool lastMatched = false;
            bool lastOperation = false;

            foreach (RectMapObj map in mapList)
            {


                // Going to replace this line with the new SceneDebugger class soon as a finish it
                Helper.SceneDebugger(script, map.RectMap, this, true, true, 5000, map.Name, 90);

                Bitmap image = script.CropFrame(Helper.RectmapToRectangle(map.RectMap));
                image = Helper.PosterizeFilter(image, 90);
                image = Helper.BlurFilter(image);
                ulong hash = ImageHashing.AverageHash(image);       
                

                if (ImageHashing.Similarity(map.RectMap.Hash, hash) >= map.Match )
                {
                    map.Matched = true;
                    lastMatched = true;
                }

                if (map.Operator == "OR")
                {
                    if (map.Matched || lastMatched && lastOperation == true) { lastOperation = true; }
                }


                //So i need to figure out how to deal with different operators, I made a place in the new RectMapObj to store the operator I want to use maybe


                //figure out operators and weather or not all the matches are as intended and return true or false.

            }



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
