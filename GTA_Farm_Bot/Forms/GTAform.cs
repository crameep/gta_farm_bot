using GTA_Farm_Bot.Classes;
using PS4MacroAPI.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_Farm_Bot.Forms
{
    public partial class GTAform : Form
    {
        private string str;

        public GTAform()
        {
            InitializeComponent();
        }

        private void GTAform_Load(object sender, EventArgs e)
        {

        }

        private void DebuggingCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        public bool GetDebugging()
        {
            return DebuggingCheckBox.Checked;
        }

        public ulong GetImageHash()
        {

                return Convert.ToUInt64(HashBox.Text);

               
           
        }

        public string GetSceneDebug()
        {
            
            BeginInvoke(new Action(() => {

                if (SceneDebugComboBox.SelectedItem != null) { str = SceneDebugComboBox.SelectedItem.ToString(); }
                
            }));

            return str;
        }

        public void LogThis(string text)
        {
            BeginInvoke(new Action(() => {
                DateTime dt = DateTime.Now;
                string s = dt.ToString("HH:mm:ss");
                LogBox.Text = s + ": " + text + Environment.NewLine + LogBox.Text;
             }));            
        }

        public void SetCurrentScene(string text)
        {
            BeginInvoke(new Action(() => {
                CurrentScene.Text = text;
            }));
            
        }

        public void SetLoopNumber(int loops)
        {
            BeginInvoke(new Action(() => {
                LoopBox.Text = loops.ToString();
            }));
            
        }

        public void SetBadLoopNumber(int loops)
        {
            BeginInvoke(new Action(() => {
                BadLoopsTextBox.Text = loops.ToString();
            }));
        }

        public void IncreaseRoundCount()
        {
            BeginInvoke(new Action(() => {
                int RoundsPlayed = Convert.ToInt32(RoundsPlayedText.Text);
                RoundsPlayed = RoundsPlayed + 1;
                RoundsPlayedText.Text = RoundsPlayed.ToString();
                RoundsPlayedText.Refresh();
            }));
        }
        public void IncreaseWinCount()
        {
            BeginInvoke(new Action(() => {
                int RoundsWon = Convert.ToInt32(RoundsWonText.Text);
                RoundsWon = RoundsWon + 1;
                RoundsWonText.Text = RoundsWon.ToString();
            }));
        }
        public void IncreaseLossCount()
        {
            BeginInvoke(new Action(() => {
                int RoundsLost = Convert.ToInt32(RoundsLostText.Text);
                RoundsLost = RoundsLost + 1;
                RoundsLostText.Text = RoundsLost.ToString();
            }));
        }

        public void DisplayImage(Bitmap bmp)
        {
            BeginInvoke(new Action(() => {
                DisplayImageBox.Image = bmp;
                ulong bluredHash = ImageHashing.AverageHash(Helper.BlurFilter(bmp));
                HashBox.Text = bluredHash.ToString();
            }));
        }

        private void DebuggingCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        internal void IncreaseDeathCount()
        {
            BeginInvoke(new Action(() => {
                int DeathCount = Convert.ToInt32(DeathCountText.Text);
                DeathCount = DeathCount + 1;
                DeathCountText.Text = DeathCount.ToString();
            }));
        }

        internal void IncreaseAFKCount()
        {
            BeginInvoke(new Action(() => {
                int AFKCount = Convert.ToInt32(AFKCountText.Text);
                AFKCount = AFKCount + 1;
                AFKCountText.Text = AFKCount.ToString();
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SetupForm().Show(this);
        }
    }
}
