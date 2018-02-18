using GTA_Farm_Bot.Classes;
using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Scenes
{
    class Alert : Scene
    {
        public override string Name => "Alert";

        public static RectMap AlertText = new RectMap()
        {
            X = 413,
            Y = 297,
            Width = 176,
            Height = 66,
            Hash = 122593390591744
        };

        public static RectMap AlertText2 = new RectMap()
        {
            X = 413,
            Y = 297,
            Width = 176,
            Height = 66,
            Hash = 31383907991486464
        };
        


        public override bool Match(ScriptBase script)
        {

            Helper.SceneDebugger(script, AlertText, this, false, false,2000);
            Helper.SceneDebugger(script, AlertText2, this);
            return script.MatchTemplate(AlertText, 95) || script.MatchTemplate(AlertText2, 95);
        }

        public override void OnMatched(ScriptBase script)
        {
            var mainscript = script as Script;
            mainscript.increaseAFKCount();
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(60000);

        }
    }
}
