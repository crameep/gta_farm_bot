using GTA_Farm_Bot.Forms;
using GTA_Farm_Bot.Scenes;
using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot
{
    public class Script : ScriptBase
    {
        private int loopNumber;
        private int BadLoops;
        private int lostRounds = 0;
   

        public GTAform GTAform { get; private set; } 
        public bool Debugs { get; private set; }
 


        /* Constructor */
        public Script()
        {
            Debugs = true;
            Config.Name = "Example Script";
            Config.LoopDelay = 2000;
            Config.ShowFormOnStart = true;

            Config.Scenes = new List<Scene>()
            {
                new PhoneMenu(),
                new PreFeaturedQuickJobList(),
                new SelectAdversaryMode(),
                new WaitingForTeam(),
                new TheJump(),
                new VoteNextJob(),
                new Alert(),
                new Offline(),
                new Loading(), 
                new NotInGame(),
                new Loser()
            };
            ScriptForm = GTAform = new GTAform();

        }

        

        // Called when the user pressed play
        public override void Start()
        {
            base.Start();
            
        }

        // Called every interval set by LoopDelay
        public override void Update()
        {
            Scene scene = null;
            
            int loopNumber = this.loopNumber++;
            GTAform.SetLoopNumber(loopNumber);
            HandleScenes(s =>
            {
                scene = s;
                GTAform.SetCurrentScene(s.Name);
                if (GTAform.GetDebugging())
                {
                    GTAform.LogThis(s.Name);
                }

            });
           
            if (scene == null)
            {
                int BadLoops = this.BadLoops++;
                GTAform.SetCurrentScene("Can't Detect Scene");
                if (this.BadLoops >= 20)
                {
                    if (GTAform.GetDebugging()) GTAform.LogThis("Moving to prevent AFK");
                    SetButtons(new DualShockState() { LX = 0 });
                    SetButtons(new DualShockState() { LY = 0 });
                    Sleep(3000);
                    SetButtons(new DualShockState() { LX = 128 });
                    SetButtons(new DualShockState() { LY = 128 });

                }
            }

            if (this.BadLoops >= 100)
            {
                BadLoops = 0;
                GTAform.LogThis("A whole lot of bad loops detected are we in a game?");
                Press(new DualShockState() { DPad_Up = true });
            }


            if (scene != null)
            {


                BadLoops = 0;
                if (scene.Name == "Loser")
                {

                    lostRounds++;
                    GTAform.LogThis("Lost " + lostRounds + " rounds.");
                }
            }


            }
        }
}
