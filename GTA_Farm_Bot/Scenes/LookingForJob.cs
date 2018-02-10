using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Scenes
{
    class LookingForJob : Scene
    {
        public override string Name => "Looking For Job / Populating Lobby";

        public static RectMap LookingForJobText = new RectMap()
        {
            X = 856,
            Y = 615,
            Width = 83,
            Height = 20,
            Hash = 547599882240
        };

        public static RectMap PoplulatingLobby = new RectMap()
        {
            X = 859,
            Y = 616,
            Width = 84,
            Height = 19,
            Hash = 549747362816
        };

        public override bool Match(ScriptBase script)
        {
           
            return script.MatchTemplate(LookingForJobText, 95) || script.MatchTemplate(PoplulatingLobby, 95);
        }

        public override void OnMatched(ScriptBase script)
        {

            script.SetButtons(new DualShockState() { LY = 0 });
            script.Sleep(10000);
            script.SetButtons(new DualShockState() { LY = 128 });
            script.Sleep(1000);

        }

    }
}
