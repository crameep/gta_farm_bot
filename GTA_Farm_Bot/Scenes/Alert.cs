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


        public override bool Match(ScriptBase script)
        {

            return script.MatchTemplate(AlertText, 95);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { DPad_Right = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Right = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Right = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(30000);

        }
    }
}
