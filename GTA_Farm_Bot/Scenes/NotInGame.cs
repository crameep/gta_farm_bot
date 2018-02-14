using GTA_Farm_Bot.Classes;
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
        public override string Name => "Not in game";

        public static RectMap AlertText = new RectMap()
        {
            X = 165,
            Y = 607,
            Width = 28,
            Height = 29,
            Hash = 3974178274049144
        };

        public static RectMap TimeText = new RectMap()
        {
            X = 876,
            Y = 621,
            Width = 27,
            Height = 12,
            Hash = 139080675237376
        };

        public static RectMap JoiningText = new RectMap()
        {
            X = 874,
            Y = 618,
            Width = 93,
            Height = 17,
            Hash = 122593390559232
        };


        public override bool Match(ScriptBase script)
        {
            Helper.SceneDebugger(script, AlertText, this, true, true);
            return script.MatchTemplate(AlertText, 80) && !script.MatchTemplate(TimeText, 95) && !script.MatchTemplate(JoiningText, 70);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { DPad_Up = true});


        }
    }
}
