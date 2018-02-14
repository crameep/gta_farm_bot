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
        class Freemode : Scene
        {
            
            public override string Name => "Freemode";

            public static RectMap Character = new RectMap()
            {
                X = 376,
                Y = 303,
                Width = 169,
                Height = 352,
                Hash = 38604374015
            };

        public static RectMap Character2 = new RectMap()
        {
            X = 376,
            Y = 303,
            Width = 169,
            Height = 352,
            Hash = 6951586385220108063
        };

        public static RectMap Character3 = new RectMap()
        {
            X = 275,
            Y = 303,
            Width = 300,
            Height = 352,
            Hash = 6876995561665791751
        };

        
        public static RectMap TimeText = new RectMap()
        {
            X = 876,
            Y = 621,
            Width = 27,
            Height = 12,
            Hash = 139080675237376
        };

        public static Rectangle TimeTextRect = new Rectangle()
        {
            X = 876,
            Y = 621,
            Width = 27,
            Height = 12,
            
        };

        public static RectMap PhoneMenu = new RectMap()
        {
            X = 842,
            Y = 459,
            Width = 126,
            Height = 21,
            Hash = 35887507612368896
        };

        public static Rectangle CharacterRect = new Rectangle()
        {
            X = 376,
            Y = 303,
            Width = 169,
            Height = 352,
        };

        public override bool Match(ScriptBase script)
            {

            Helper.SceneDebugger(script, Character3, this, true, true, 0, null, 60);
            return script.MatchTemplate(Character3, 76) && !script.MatchTemplate(TimeText, 50) && !script.MatchTemplate(PhoneMenu, 60);
            }


        public override void OnMatched(ScriptBase script)
            {
                
                script.Press(new DualShockState() { DPad_Up = true });
            script.Sleep(5000);
                
            }
        }
    }


