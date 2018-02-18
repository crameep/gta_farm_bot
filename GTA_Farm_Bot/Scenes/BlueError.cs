using Accord.Imaging.Filters;
using GTA_Farm_Bot.Classes;
using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Scenes
{
    class BlueError : Scene
    {
        public override string Name => "Blue Error";

        #region Mappings
        public static PixelMap PreCheck = new PixelMap
        {
            ID = "BlueError|PreCheck",
            X = 148,
            Y = 591,
            Color = 0x152F62
        };

        public static PixelMap BlueBackground_1 = new PixelMap
        {
            ID = "BlueError|BlueBackground_1",
            X = 107,
            Y = 174,
            Color = 0x7D7DFB
        };

        public static PixelMap BlueBackground_2 = new PixelMap
        {
            ID = "BlueError|BlueBackground_2",
            X = 880,
            Y = 372,
            Color = 0x7D7DFB
        };

        public static PixelMap EnterButton = new PixelMap
        {
            ID = "BlueError|EnterButton",
            X = 66,
            Y = 586,
            Color = 0x7D7D7D
        };

        public static PixelMap BackButton = new PixelMap
        {
            ID = "BlueError|BackButton",
            X = 147,
            Y = 591,
            Color = 0x7D7D7D
        };
        #endregion

        public override bool Match(ScriptBase script)
        {
            if (script.MatchTemplate(PreCheck, 20))
            {
                var filter = new SimplePosterization(SimplePosterization.PosterizationFillingType.Max);
                filter.PosterizationInterval = 126;

                var bmp = filter.Apply(new Bitmap(script.CurrentFrame));
                return script.MatchTemplate(bmp, BlueBackground_1) && script.MatchTemplate(bmp, BlueBackground_2) &&
                       script.MatchTemplate(bmp, EnterButton) && script.MatchTemplate(bmp, BackButton);
            }

            return false;
        }

        public override void OnMatched(ScriptBase script)
        {
            Console.WriteLine("BlueError ENTER");

            // Update UI
           // ((Script)script).IncreaseCrashCount();

            // Wait
            script.Sleep(60000);

            // Exit blue error
            script.Press(new DualShockState() { Circle = true });
            script.Sleep(SleepTime.L);
            // Restart game
            script.Press(new DualShockState() { Cross = true });
            // Long sleep (2 minutes)
            script.Sleep(120000);
            // Pause game
            script.Press(new DualShockState() { Options = true });
            script.Sleep(SleepTime.XL);

            // Select online tab
            for (var i = 0; i < 5; i++)
            {
                script.Press(new DualShockState() { R1 = true });
                script.Sleep(SleepTime.M);
            }

            // Select solo session
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(SleepTime.XL);
            script.Press(new DualShockState() { DPad_Up = true });
            script.Sleep(SleepTime.L);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(SleepTime.L);
            script.Press(new DualShockState() { DPad_Up = true });
            script.Sleep(SleepTime.L);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(SleepTime.L);

            // Quit singleplayer
            script.Press(new DualShockState() { Cross = true });

            // Long sleep (1.5 minutes)
            script.Sleep(90000);
            Console.WriteLine("BlueError END");
        }
    }
}
