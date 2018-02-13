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
            Helper.SceneDebugger(script, JobList, this);
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
