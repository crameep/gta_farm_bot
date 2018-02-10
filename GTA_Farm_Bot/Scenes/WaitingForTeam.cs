using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Scenes
{
    class WaitingForTeam : Scene

    {
        public override string Name => "Spectating";

        public static RectMap WaitingTeam = new RectMap()
        {
            X = 23,
            Y = 93,
            Width = 90,
            Height = 20,
            Hash = 1099511611392
        };


        public override bool Match(ScriptBase script)
        {
            
            return script.MatchTemplate(WaitingTeam, 93);
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
          

        }
    }
}
