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
            X = 149,
            Y = 121,
            Width = 190,
            Height = 43,
            Hash = 35887507618886465
        };

        public override bool Match(ScriptBase script)
        {
            
            return script.MatchTemplate(NextJobText, 95);
        }

        public override void OnMatched(ScriptBase script)
        {

            script.SetButtons(new DualShockState() { LY = 0 });
            script.Sleep(10000);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(15000);
            script.SetButtons(new DualShockState() { LY = 255 });
            script.Sleep(5000);
            script.SetButtons(new DualShockState() { LY = 128 });
            script.Sleep(1000);

        }
    
    }
}
