using GTA_Farm_Bot.Classes;
using GTA_Farm_Bot.Forms;
using PS4MacroAPI;
using PS4MacroAPI.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_Farm_Bot.Scenes
    {
        class GameSetup : Scene
        {
            
            public override string Name => "Game Setup";

            public static RectMap SettingsText = new RectMap()
            {
                X = 252,
                Y = 187,
                Width = 53,
                Height = 17,
                Hash = 139081770018304
            };

         public override bool Match(ScriptBase script)
            {
            Helper.SceneDebugger(script, SettingsText, this);

            return script.MatchTemplate(SettingsText,92);
            }


        public override void OnMatched(ScriptBase script)
            {
                
                script.SetButtons(new DualShockState() { LX = 0 });
                script.Sleep(5000);
                script.SetButtons(new DualShockState() { LY = 128 });
                script.Sleep(1000);
            }
        }
    }


