using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTABot.Classes
{
    class SceneConditionHandler
    {

        public bool Passed { get; private set; }

        // Handle all of the scene matching conditions 

        // Pass in list of Rectmaps that have conditionals set
        // ie RectMap Scene Name Required Match and Passing Requiremetn, ie true or false.

        public static bool HandleConditions(List<ConditionMap> conditions, ScriptBase script)
        {
            var mainscript = script as Script;

            bool Passed = true;
            foreach (ConditionMap condition in conditions )
            {
               
                if (script.MatchTemplate(condition.RectMap, condition.Match) != condition.Required)
                {
                    Passed = false;
                    Bitmap image = script.CropFrame(Helper.RectmapToRectangle(condition.RectMap));
                    image.Save(condition.Name + "_" + condition.RectMap.Hash.ToString() + ".png");
                }
                
            }

            if (Passed != true) return false;
            else return true;

        }
    }
}
