using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Imaging.Filters;
using GTA_Farm_Bot.Classes;

namespace GTA_Farm_Bot.Scenes
{
    class Loser: Scene
    {
        public override string Name => "Round Loser";

        public static RectMap LoserText = new RectMap()
        {
            X = 157,
            Y = 239,
            Width = 696,
            Height = 237,
            Hash = 52500602273791
        };


        public override bool Match(ScriptBase script)
        {
            Helper.SceneDebugger(script, LoserText, this);
            return script.MatchTemplate(LoserText, 95);
        }

        public override void OnMatched(ScriptBase script)
        {

            var mainscript = script as Script;
            mainscript.IncreaseLossCount();
            mainscript.IncreaseRoundCount();
        }
    }
}
