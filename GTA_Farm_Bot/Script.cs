using Accord.Imaging.Filters;
using GTA_Farm_Bot.Classes;
using GTA_Farm_Bot.Forms;
using GTA_Farm_Bot.Scenes;
using PS4MacroAPI;
using PS4MacroAPI.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GTA_Farm_Bot
{
    public class Script : ScriptBase
    {
        private int loopNumber;
        private int BadLoops;
        private int duplicateSceneCount;
        private int verybadloops;

        public GTAform GTAform { get; private set; }
        public bool Debugs { get; private set; }

        

        /* Constructor */
        public Script()
        {
            Config.Name = "GTA Farm Bot";
            Config.LoopDelay = 800;
            Config.ShowFormOnStart = true;

            Config.Scenes = new List<Scene>()
            {
                new PhoneMenu(), //SceneDebugger Working
                new FeaturedQuickJobList(),//SceneDebugger Working
                new PreFeaturedQuickJobList(), //SceneDebugger Working
                new SelectAdversaryMode(), // SceneDebugger Working
                new Spectating(), // SceneDebugger Working
                new TheJump(), //SceneDebugger Working
                new Parachute(), //SceneDebugger Working
                new VoteNextJob(), //SceneDebugger Working
                new Alert(), //SceneDebugger Working
                new Offline(), //SceneDebugger Working
                new GameSetup(), //SceneDebugger Working
                new Loading(), //SceneDebugger Working
                new Loser(), //SceneDebugger Working
                //new Freemode(), //SceneDebugger Working  screw this scene never works right.
                new NotInGame(), //SceneDebugger Working
                new Winner(),  //SceneDebugger Working
                new BlueError(), // Uses PixelMaps, no Debug for that yet. Detection part works well, restarting game not so much
                new Wasted(), //Scene Debugger Working
                
            };
            ScriptForm = GTAform = new GTAform();

        }



        // Called when the user pressed play
        public override void Start()
        {
            base.Start();
            Press(new DualShockState() { DPad_Up = true });

        }

        public override void OnStopped()
        {
            base.OnStopped();
            loopNumber = 0;
            BadLoops = 0;
            GTAform.SetCurrentScene("Stopped");
        }

        // Called every interval set by LoopDelay
        public override void Update()
        {
            Scene scene = null;

            int loopNumber = this.loopNumber++;
            GTAform.SetLoopNumber(loopNumber);
            GTAform.SetBadLoopNumber(this.BadLoops);
            HandleScenes(s =>
            {
                scene = s;
                GTAform.SetCurrentScene(s.Name);
                if (GTAform.GetDebugging())
                {
                    GTAform.LogThis(s.Name);
                }

            });


            if (scene != null)
            {
                String LastScene = scene.Name;
                BadLoops = 0;

                if (LastScene == scene.Name)
                {

                    duplicateSceneCount = duplicateSceneCount++;

                }
                else
                {
                    duplicateSceneCount = 0;
                }
                if (duplicateSceneCount >= 50)
                {
                    Press(new DualShockState() { DPad_Up = true });
                }

            }




            if (scene == null)
            {

                int BadLoops = this.BadLoops++;
                GTAform.SetCurrentScene("Can't Detect Scene");
                if (this.BadLoops >= 20)
                {
                    if (GTAform.GetDebugging()) GTAform.LogThis("Moving to prevent AFK");
                    //SetButtons(new DualShockState() { RX = 0 });
                    SetButtons(new DualShockState() { LY = 0 });
                    Sleep(250);
                    //SetButtons(new DualShockState() { RX = 128 });

                    SetButtons(new DualShockState() { LY = 128 });
                    Sleep(250);

                }
            }

            if (this.BadLoops >= 21 && GTAform.GetDebugging()) GTAform.SetBadLoopNumber(this.BadLoops);

            if (this.BadLoops >= 300)
            {

                verybadloops = verybadloops++;
                if (verybadloops >= 5)
                {
                    GTAform.LogThis("Shutting down the bot too many verybadloops");
                    StopMacro();
                }
                BadLoops = 0;
                GTAform.LogThis("A whole lot of bad loops detected are we in a game?");
                CaptureFrame();
                Sleep(3000);
                if (verybadloops >= 2)
                {
                    GTAform.LogThis("Trying to Relaunch a game");
                    Press(new DualShockState() { DPad_Up = true });
                }
            }




        }

        public void updateImage(Bitmap image)
        {
            GTAform.DisplayImage(image);
        }

        public void IncreaseRoundCount()
        {
            GTAform.IncreaseRoundCount();
        }

        public void IncreaseWinCount()
        {
            GTAform.IncreaseWinCount();
        }

        public void IncreaseLossCount()
        {
            GTAform.IncreaseLossCount();
        }

        public void IncreaseDeathCount()
        {
            GTAform.IncreaseDeathCount();
        }

        public void increaseAFKCount()
        {
            GTAform.IncreaseAFKCount();
        }
    }
}
