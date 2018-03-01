using GTABot.Classes;
using PS4MacroAPI;
using PS4MacroAPI.Internal;
using System.Drawing;
using static GTABot.Classes.SettingsData;

namespace GTABot.Scenes
{
    class Freemode : Scene
    {
        public override string Name => "Freemode";

      
        public override bool Match(ScriptBase script)
        {
            
            
            return SceneConditionHandler.HandleConditions(Settings.Instance.Data.SceneConditions["freemode"], script) ||
                   SceneConditionHandler.HandleConditions(Settings.Instance.Data.SceneConditions["freemode_bed"], script);
        }


        public override void OnMatched(ScriptBase script)
        {
            var mainscript = script as Script;
            mainscript.MainForm.Log("Entered Freemode");
            script.Press(new DualShockState() { Options = true });
            script.Sleep(400);
            script.Press(new DualShockState() { DPad_Right = true });
            script.Sleep(350);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(350);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(350);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(350);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(350);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(350);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(350);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(350);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(350);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(350);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(350);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(350);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(350);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(350);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(350);
            script.Press(new DualShockState() { DPad_Down = true });
            script.Sleep(350);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(350);

            for (int i = 1; i <= 98; i++)
            {
                script.Press(new DualShockState() { DPad_Down = true });
                script.Sleep(50);
            }
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(350);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(30000);
        }
    }
}