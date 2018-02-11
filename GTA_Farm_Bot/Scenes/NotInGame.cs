using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Scenes
{
    class NotInGame : Scene
    {
        public override string Name => "NotInGame";

        public static RectMap AlertText = new RectMap()
        {
            X = 165,
            Y = 607,
            Width = 28,
            Height = 29,
            Hash = 26492179951079295
        };


        public override bool Match(ScriptBase script)
        {

            return script.MatchTemplate(AlertText, 95);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { DPad_Up = true});


        }
    }
}
