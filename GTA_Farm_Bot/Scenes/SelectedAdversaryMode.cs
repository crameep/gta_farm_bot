using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Scenes
{
    class SelectedAdversaryMode : Scene
    {
        public override string Name => "Selected Adversary Mode";

        public static RectMap QuickJobList1 = new RectMap()
        {
            X = 841,
            Y = 460,
            Width = 126,
            Height = 150,
            Hash = 547599908735
        };

        public static RectMap QJ1AMSelected = new RectMap()
        {
            X = 843,
            Y = 461,
            Width = 123,
            Height = 147,
            Hash = 140183445733247
        };

        public override bool Match(ScriptBase script)
        {
            

            if (script.MatchTemplate(QuickJobList1, 98))
            {
                
                script.Press(new DualShockState() { DPad_Down = true });
                script.Sleep(250);
                script.Press(new DualShockState() { DPad_Down = true });
                script.Sleep(250);
                
                
            }
            

            if (script.MatchTemplate(QJ1AMSelected, 95))
            {
                
                return true;
            }

            else return false;

        }

        public override void OnMatched(ScriptBase script)
        {
            //Console.WriteLine("Adversary Mode Selected Matched");

            script.Press(new DualShockState() { Cross = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(250);
        }
    }
}
