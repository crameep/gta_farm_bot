using GTABot.Classes;
using PS4MacroAPI;
using static GTABot.Classes.SettingsData;

namespace GTABot.Scenes
{
    class Game : Scene
    {
        public override string Name => "Game";

        public override bool Match(ScriptBase script)
        {
            return SceneConditionHandler.HandleConditions(Settings.Instance.Data.SceneConditions["Game"], script);

        }

        public override void OnMatched(ScriptBase script)
        {
            int index = 0;
            while (SceneConditionHandler.HandleConditions(Settings.Instance.Data.Game, script))
            {
                int value = ++index;
                if (value > 50)
                {
                    break;
                }
                script.SetButtons(new DualShockState() { LX = 0 });
                script.Sleep(1000);
            }
            script.SetButtons(new DualShockState() { LX = 128 });

        }
    }
}