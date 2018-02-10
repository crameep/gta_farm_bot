using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Scenes
{
    class Loading : Scene
    {
        public override string Name => "Loading";

        public static RectMap LoadingText = new RectMap()
        {
            X = 861,
            Y = 618,
            Width = 75,
            Height = 17,
            Hash = 4945646389248
        };
        public static RectMap JoiningText = new RectMap()
        {
            X = 874,
            Y = 618,
            Width = 93,
            Height = 17,
            Hash = 122593390559232
        };

        public override bool Match(ScriptBase script)
        {

            return script.MatchTemplate(LoadingText, 97) || script.MatchTemplate(JoiningText, 97);
        }

        public override void OnMatched(ScriptBase script)
        {
            
            script.Sleep(30000);


        }
    }
}
