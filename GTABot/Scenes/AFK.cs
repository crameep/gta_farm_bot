using GTABot.Classes;
using PS4MacroAPI;
using static GTABot.Classes.SettingsData;

namespace GTABot.Scenes
{
    class AFK : Scene
    {
        public override string Name => "AFK";

        public override bool Match(ScriptBase script)
        {
            return SceneConditionHandler.HandleConditions(Settings.Instance.Data.SceneMapDictionary["AFK"], script);

        }

        public override void OnMatched(ScriptBase script)
        {

            script.SetButtons(new DualShockState() { LX = 0 });
            script.Sleep(4000);
            script.SetButtons(new DualShockState() { LX = 128 });

        }
    }
}