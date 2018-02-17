﻿using GTA_Farm_Bot.Classes;
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
            Hash = 9223217281671519320
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


            Bitmap image = script.CropFrame(Helper.RectmapToRectangle(Character3));
            image = Helper.PosterizeFilter(image);
            image = Helper.BlurFilter(image);
            ulong hash = ImageHashing.AverageHash(image);


            Helper.SceneDebugger(script, Character3, this, true, true, 5000, null, 70);

            if (ImageHashing.Similarity(Character3.Hash, hash) >= 73 && !script.MatchTemplate(TimeText, 50) && !script.MatchTemplate(PhoneMenu, 60))
            {

                return true;
            }

            else return false;
        }


        public override void OnMatched(ScriptBase script)
        {

            script.Press(new DualShockState() { DPad_Up = true });
            script.Sleep(5000);

        }
    }
}


