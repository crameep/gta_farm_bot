using GTABot.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTABot.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSettings();
                Log("Loading Settings...");
            }
            catch
            {
                Settings.Instance.InitData();
                Log("Defaults Loaded");
                SaveSettings();
            }

            BindSceneSetupMenu();
        }



        public void BindSceneSetupMenu()
        {
            foreach (var name in Settings.Instance.Data.SceneConditions.GetPropertyNames())
            {
                // var value = Settings.Instance.Data.SceneConditions[name];

                ToolStripItem item = new ToolStripMenuItem();
                item.Click += SceneSetupMenuItem_Click;
                item.Text = name;
                item.Name = name;
                this.SceneSetupMenu.DropDownItems.Add(item);
            }
        }

        private void LoadSettings()
        {
            Settings.Instance.Load(Helper.GetScriptFolder() + @"\profile.xml");


        }


        private void SaveSettings()
        {
            Settings.Instance.Save(Helper.GetScriptFolder() + @"\profile.xml");
        }


        private void SceneSetupMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            Log(item.Name);
            new SceneSetupForm(item.Name).Show();
        }


        // Update the Status Label with string
        public void SetStatus(string s, Color c)
        {
            BeginInvoke(new Action(() => {
                StatusText.Text = s;
                StatusText.ForeColor = c;
            }));
        }

        // Update the Lap Count
        public void SetLap(int i)
        {
            BeginInvoke(new Action(() => {
                LapText.Text = i.ToString();
            }));
        }

        //Add a string to the logbox with timestamp newest first.
        public void Log(string text)
        {
            BeginInvoke(new Action(() => {
                DateTime dt = DateTime.Now;
                string s = dt.ToString("HH:mm:ss");
                LogBox.Text = s + ": " + text + Environment.NewLine + LogBox.Text;
            }));
        }

        private void oNeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}