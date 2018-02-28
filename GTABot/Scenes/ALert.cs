using GTABot.Classes;
using PS4MacroAPI;
using static GTABot.Classes.SettingsData;

namespace GTABot.Scenes
{
    class Alert : Scene
    {
        public override string Name => "Alert";


        public override bool Match(ScriptBase script)
        {
            return SceneConditionHandler.HandleConditions(Settings.Instance.Data.SceneMapDictionary["Alert"], script);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { Cross = true });
        }
    }
}