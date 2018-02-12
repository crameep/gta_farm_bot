using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Imaging.Filters;

namespace GTA_Farm_Bot.Scenes
{
    class Winner: Scene
    {
        public override string Name => "Round Winner";

        public static RectMap WinnerText = new RectMap()
        {
            X = 157,
            Y = 239,
            Width = 696,
            Height = 237,
            Hash = 137438953471871
        };


        public override bool Match(ScriptBase script)
        {

            return script.MatchTemplate(WinnerText, 95);
        }

        public override void OnMatched(ScriptBase script)
        {
            var mainscript = script as Script;
            mainscript.IncreaseWinCount();
            mainscript.IncreaseRoundCount();

        }
    }
}
