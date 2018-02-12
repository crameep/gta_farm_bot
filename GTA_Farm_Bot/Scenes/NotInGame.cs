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

        public static RectMap TimeText = new RectMap()
        {
            X = 876,
            Y = 621,
            Width = 27,
            Height = 12,
            Hash = 139080675237376
        };


        public override bool Match(ScriptBase script)
        {

            return script.MatchTemplate(AlertText, 95) && !script.MatchTemplate(TimeText, 95);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { DPad_Up = true});


        }
    }
}
