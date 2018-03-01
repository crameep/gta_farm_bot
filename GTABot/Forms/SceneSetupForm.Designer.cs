namespace GTABot.Forms
{
    partial class SceneSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SceneDataGrid = new System.Windows.Forms.DataGridView();
            this.SceneTitleLabel = new System.Windows.Forms.Label();
            this.RectMapDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SceneDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectMapDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SceneDataGrid
            // 
            this.SceneDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SceneDataGrid.Location = new System.Drawing.Point(13, 61);
            this.SceneDataGrid.MultiSelect = false;
            this.SceneDataGrid.Name = "SceneDataGrid";
            this.SceneDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SceneDataGrid.Size = new System.Drawing.Size(524, 150);
            this.SceneDataGrid.TabIndex = 0;
            this.SceneDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SceneTitleLabel
            // 
            this.SceneTitleLabel.AutoSize = true;
            this.SceneTitleLabel.Location = new System.Drawing.Point(106, 22);
            this.SceneTitleLabel.Name = "SceneTitleLabel";
            this.SceneTitleLabel.Size = new System.Drawing.Size(35, 13);
            this.SceneTitleLabel.TabIndex = 1;
            this.SceneTitleLabel.Text = "label1";
            // 
            // RectMapDataGrid
            // 
            this.RectMapDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RectMapDataGrid.Location = new System.Drawing.Point(12, 228);
            this.RectMapDataGrid.MultiSelect = false;
            this.RectMapDataGrid.Name = "RectMapDataGrid";
            this.RectMapDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.RectMapDataGrid.Size = new System.Drawing.Size(525, 150);
            this.RectMapDataGrid.TabIndex = 2;
            // 
            // SceneSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 432);
            this.Controls.Add(this.RectMapDataGrid);
            this.Controls.Add(this.SceneTitleLabel);
            this.Controls.Add(this.SceneDataGrid);
            this.Name = "SceneSetupForm";
            this.Text = "SceneSetup";
            ((System.ComponentModel.ISupportInitialize)(this.SceneDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectMapDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SceneDataGrid;
        private System.Windows.Forms.Label SceneTitleLabel;
        private System.Windows.Forms.DataGridView RectMapDataGrid;
    }
}