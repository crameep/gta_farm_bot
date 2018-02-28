using GTABot.Forms;
using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GTABot.Scenes;

namespace GTABot
{
    public class Script : ScriptBase
    {

        public MainForm MainForm { get; private set; }
        public int Lap { get; private set; }

        
        public Script()
        {
            Config.Name = "GTA Bot";
            Config.LoopDelay = 500;
            Config.ShowFormOnStart = true;
            Lap = 0;

            ScriptForm = MainForm = new MainForm();


            Config.Scenes = new List<Scene>()
            {
                new Alert(),
                new Freemode(),
                new AFK(),
                new Game()
            };
        }

        public override void Start()
        {
            base.Start();
            MainForm.SetStatus("Running", Color.Green);
        }

        public override void Update()
        {
            base.Update();
            HandleScenes();

            //Increases Lap Count
            MainForm.SetLap(Lap++);
        }

        public override void OnStopped()
        {
            base.OnStopped();
            Lap = 0;
           MainForm.SetStatus("Stopped", Color.Red);
        }

        public override void OnPaused()
        {
            base.OnPaused();
            MainForm.SetStatus("Paused", Color.Blue);
        }

        public override void OnMacroLapEnter(object sender)
        {
            base.OnMacroLapEnter(sender);

        }
    }
}
