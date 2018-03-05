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
        public static Script MyScript { get; set; }
        private string SceneTitle { get; set;}

        public SceneSetupForm(string s)
        {
            InitializeComponent();
           
            SceneTitleLabel.Text = s;
            SceneTitle = s;
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
            Rectangle rect = new Rectangle(){
                X = Convert.ToInt32(RectMapXBox.Text),
                Y = Convert.ToInt32(RectMapYBox.Text),
                Width = Convert.ToInt32(RectMapWidthBox.Text),
                Height = Convert.ToInt32(RectMapHeightBox.Text),
                
            };
            Bitmap image = MyScript.CropFrame(rect);

            SceneSetupPictureBox.Image = image;
            ulong Hash = PS4MacroAPI.Internal.ImageHashing.AverageHash(image);
            if (RectMapHashBox.Text != Hash.ToString())
            {
                RectMapHashBox.Text = Hash.ToString();
                RectMapHashBox.ForeColor = Color.Red;

            }
            RectMapHashBox.Text = Hash.ToString();
            
            

        }

        private void SceneSetupSaveButton_Click(object sender, EventArgs e)
        {
            List<ConditionMap> NewSetting = Settings.Instance.Data.SceneConditions[SceneTitle];
            NewSetting.;
            Settings.Instance.Save(Helper.GetScriptFolder() + @"\profile.xml");
        }
    }
}
