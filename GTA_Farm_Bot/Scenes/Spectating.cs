using GTA_Farm_Bot.Classes;
using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Scenes
{
    class Spectating : Scene

    {
        public override string Name => "Spectating";

        public static RectMap SpectatingText = new RectMap()
        {
            X = 23,
            Y = 93,
            Width = 90,
            Height = 20,
            Hash = 1099511611392
        };


        public override bool Match(ScriptBase script)
        {
            Helper.SceneDebugger(script, SpectatingText, this);
            return script.MatchTemplate(SpectatingText, 93);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.SetButtons(new DualShockState() { RX = 0 });
            script.SetButtons(new DualShockState() { RY = 0 });
            script.Sleep(1000);
            script.SetButtons(new DualShockState() { RX = 128 });
            script.SetButtons(new DualShockState() { RY = 128 });


        }
    }
}
