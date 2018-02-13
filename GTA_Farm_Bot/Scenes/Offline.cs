using GTA_Farm_Bot.Classes;
using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Scenes
{
    class Offline : Scene
    {
        public override string Name => "Offline";

        public static RectMap OfflinePhone = new RectMap()
        {
            X = 832,
            Y = 607,
            Width = 143,
            Height = 44,
            Hash = 9223230783970365440
        };
        public static RectMap OfflineSpecialBar = new RectMap()
        {
            X = 129,
            Y = 628,
            Width = 35,
            Height = 5,
            Hash = 8138278274871095408
        };


        public override bool Match(ScriptBase script)
        {
            Helper.SceneDebugger(script, OfflineSpecialBar, this);
            return script.MatchTemplate(OfflineSpecialBar, 95);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { Circle = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Options = true });
            script.Sleep(250);
            script.Press(new DualShockState() { R1 = true });
            script.Sleep(250);
            script.Press(new DualShockState() { R1 = true });
            script.Sleep(250);
            script.Press(new DualShockState() { R1 = true });
            script.Sleep(250);
            script.Press(new DualShockState() { R1 = true });
            script.Sleep(250);
            script.Press(new DualShockState() { R1 = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(250);
            script.Press(new DualShockState() { Cross = true });
        }
    }
}
