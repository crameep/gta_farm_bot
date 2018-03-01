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

            // Load or use default settings
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
            foreach (var pair in Settings.Instance.Data.SceneMapDictionary)
            {

                ToolStripItem item = new ToolStripMenuItem();
                item.Click += SceneSetupMenuItem_Click;
                item.Text = pair.Key;
                item.Name = pair.Key;
                this.SceneSetupMenu.DropDownItems.Add(item);
            }
        }

        private void SceneSetupMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            Log(item.Name);
            new SceneSetupForm(item.Name).Show();
        }

        private void LoadSettings()
        {
            Settings.Instance.Load(Helper.GetScriptFolder() + @"\profile.xml");


        }


        private void SaveSettings()
        {
            Settings.Instance.Save(Helper.GetScriptFolder() + @"\profile.xml");
        }

        // Update the Status Label with string
        public void SetStatus(string s, Color c)
        {
            BeginInvoke(new Action(() =>
            {
                StatusText.Text = s;
                StatusText.ForeColor = c;
            }));
        }

        // Update the Lap Count
        public void SetLap(int i)
        {
            BeginInvoke(new Action(() =>
            {
                LapText.Text = i.ToString();
            }));
        }

        //Add a string to the logbox with timestamp newest first.
        public void Log(string text)
        {
            BeginInvoke(new Action(() =>
            {
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
