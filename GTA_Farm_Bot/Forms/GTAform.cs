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


                str =  SceneDebugComboBox.SelectedItem.ToString();
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
                RoundsPlayed = RoundsPlayed++;
                RoundsPlayedText.Text = RoundsPlayed.ToString();
            }));
        }
        public void IncreaseWinCount()
        {
            BeginInvoke(new Action(() => {
                int RoundsWon = Convert.ToInt32(RoundsWonText.Text);
                RoundsWon = RoundsWon++;
                RoundsWonText.Text = RoundsWon.ToString();
            }));
        }
        public void IncreaseLossCount()
        {
            BeginInvoke(new Action(() => {
                int RoundsLost = Convert.ToInt32(RoundsLostText.Text);
                RoundsLost = RoundsLost++;
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
    }
}
