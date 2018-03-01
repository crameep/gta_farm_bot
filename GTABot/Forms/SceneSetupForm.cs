using GTABot.Classes;
using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTABot.Forms
{
    public partial class SceneSetupForm : Form
    {

        public RectMap selectedRectMap { get; private set; }
        public SceneSetupForm(string s)
        {
            InitializeComponent();
           
            SceneTitleLabel.Text = s;
            SceneDataGrid.DataSource = Settings.Instance.Data.SceneConditions[s];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
             var cellMap = SceneDataGrid[e.ColumnIndex, e.RowIndex].Value;
             RectMap map = (RectMap)cellMap;
            selectedRectMap = map;

            RectMapXBox.Text = map.X.ToString();
            RectMapYBox.Text = map.Y.ToString();
            RectMapWidthBox.Text = map.Width.ToString();
            RectMapHeightBox.Text = map.Height.ToString();
            RectMapHashBox.Text = map.Hash.ToString();



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
