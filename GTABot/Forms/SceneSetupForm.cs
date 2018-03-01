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
        public SceneSetupForm(string s)
        {
            InitializeComponent();
           
            SceneTitleLabel.Text = s;
            SceneDataGrid.DataSource = Settings.Instance.Data.SceneMapDictionary[s];
            RectMapDataGrid.Columns.Add("rectmapX", "X");
            RectMapDataGrid.Columns.Add("rectmapY", "X");
            RectMapDataGrid.Columns.Add("rectmapWidth", "Width");
            RectMapDataGrid.Columns.Add("rectmapHeight", "Height");
            RectMapDataGrid.Columns.Add("rectmapHash", "Hash");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
             var cellMap = SceneDataGrid[e.ColumnIndex, e.RowIndex].Value;
             RectMap map = (RectMap)cellMap;

             RectMapDataGrid.Rows.Add(map.X, map.Y, map.Width, map.Height, map.Hash);



        }
    }
}
