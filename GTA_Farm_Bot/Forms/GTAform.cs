using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_Farm_Bot.Forms
{
    public partial class GTAform : Form
    {
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

        public void LogThis(string text)
        {
            LogBox.Text += text + Environment.NewLine;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetCurrentScene(string text)
        {
            CurrentScene.Text = text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void SetLoopNumber(int loops)
        {
            LoopBox.Text = loops.ToString();
        }

    }
}
