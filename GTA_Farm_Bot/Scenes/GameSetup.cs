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

            public static RectMap Settings = new RectMap()
            {
                X = 252,
                Y = 187,
                Width = 53,
                Height = 17,
                Hash = 139081770018304
            };

        public static Rectangle SettingsRect = new Rectangle()
        {
            X = 252,
            Y = 187,
            Width = 53,
            Height = 17,
       
        };



        public override bool Match(ScriptBase script)
            {
            var mainscript = script as Script;
           if (mainscript.GTAform.GetDebugging() && mainscript.GTAform.GetSceneDebug() == this.Name)
           {
               ulong lastHash = mainscript.GTAform.GetImageHash();
               Bitmap image = script.CropFrame(SettingsRect);
               double comparedHashes = ImageHashing.Similarity(Settings.Hash, ImageHashing.AverageHash(image));
               mainscript.GTAform.LogThis("Compared Game Setup Image Images with a " + comparedHashes + "% similarity");
               mainscript.updateImage(image);
           }

            return script.MatchTemplate(Settings,92);
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


