using GTA_Farm_Bot.Classes;
using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Scenes
{
    class VoteNextJob : Scene
    {
        public override string Name => "Vote For Next Map";

        public static RectMap NextJobText = new RectMap()
        {
            X = 758,
            Y = 436,
            Width = 83,
            Height = 31,
            Hash = 54147713794048
        };

        public override bool Match(ScriptBase script)
        {
            Helper.SceneDebugger(script, NextJobText, this);
            return script.MatchTemplate(NextJobText, 95);
        }

        public override void OnMatched(ScriptBase script)
        {

            script.Press(new DualShockState() { Cross = true });
            script.Sleep(15000);

        }
    
    }
}
