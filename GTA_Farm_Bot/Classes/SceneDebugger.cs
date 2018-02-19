using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Classes
{
    class SceneDebugger
    {

        
        /// Instance of the script?????        
        public ScriptBase Script { get; set;}

        // Area we are debuging
        public RectMap RectMap { get; set; }

        // The scene we are working with
        public Scene Scene { get; set; }

        //to blur or not to blur
        public bool Blur { get; set; }

        //to posterize or not to posterize
        public bool Posterize { get; set; }

        //Interval to set on the posterize method
        public byte PosterInterval { get; set; }

        //to grayWorld or not to grayWorld
        public bool GrayWorld { get; set; }

        //Add a delay to the process so were not seing images in the debugger lightning fast
        public int Interval { get; set; }

        //String to overide Log with incase we are debugging multiple images in one scene.
        public String String { get; set; }

        

        
        public SceneDebugger(ScriptBase script, RectMap rectMap, Scene scene)
        {
            Script = script;
            RectMap = rectMap;
            Scene = scene;
            Blur = false;
            Posterize = false;
            PosterInterval = 190;
            GrayWorld = false;
            Interval = 0;
            String = scene.Name;
        }

    }
}
