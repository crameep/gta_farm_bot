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
            this.RectMapXLabel = new System.Windows.Forms.Label();
            this.RectMapXBox = new System.Windows.Forms.TextBox();
            this.RectMapYBox = new System.Windows.Forms.TextBox();
            this.RectMapYLabel = new System.Windows.Forms.Label();
            this.RectMapWidthBox = new System.Windows.Forms.TextBox();
            this.RectMapWidthLabel = new System.Windows.Forms.Label();
            this.RectMapHeightBox = new System.Windows.Forms.TextBox();
            this.RectMapHeightLabel = new System.Windows.Forms.Label();
            this.RectMapHashBox = new System.Windows.Forms.TextBox();
            this.RectMapHashLabel = new System.Windows.Forms.Label();
            this.RectMapLabel = new System.Windows.Forms.Label();
            this.CaptureButton = new System.Windows.Forms.Button();
            this.SceneSetupPictureBox = new System.Windows.Forms.PictureBox();
            this.SceneSetupSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SceneDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SceneSetupPictureBox)).BeginInit();
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
            // RectMapXLabel
            // 
            this.RectMapXLabel.AutoSize = true;
            this.RectMapXLabel.Location = new System.Drawing.Point(10, 251);
            this.RectMapXLabel.Name = "RectMapXLabel";
            this.RectMapXLabel.Size = new System.Drawing.Size(14, 13);
            this.RectMapXLabel.TabIndex = 2;
            this.RectMapXLabel.Text = "X";
            // 
            // RectMapXBox
            // 
            this.RectMapXBox.Location = new System.Drawing.Point(55, 248);
            this.RectMapXBox.Name = "RectMapXBox";
            this.RectMapXBox.Size = new System.Drawing.Size(100, 20);
            this.RectMapXBox.TabIndex = 3;
            // 
            // RectMapYBox
            // 
            this.RectMapYBox.Location = new System.Drawing.Point(55, 277);
            this.RectMapYBox.Name = "RectMapYBox";
            this.RectMapYBox.Size = new System.Drawing.Size(100, 20);
            this.RectMapYBox.TabIndex = 5;
            // 
            // RectMapYLabel
            // 
            this.RectMapYLabel.AutoSize = true;
            this.RectMapYLabel.Location = new System.Drawing.Point(10, 280);
            this.RectMapYLabel.Name = "RectMapYLabel";
            this.RectMapYLabel.Size = new System.Drawing.Size(14, 13);
            this.RectMapYLabel.TabIndex = 4;
            this.RectMapYLabel.Text = "Y";
            // 
            // RectMapWidthBox
            // 
            this.RectMapWidthBox.Location = new System.Drawing.Point(55, 307);
            this.RectMapWidthBox.Name = "RectMapWidthBox";
            this.RectMapWidthBox.Size = new System.Drawing.Size(100, 20);
            this.RectMapWidthBox.TabIndex = 7;
            // 
            // RectMapWidthLabel
            // 
            this.RectMapWidthLabel.AutoSize = true;
            this.RectMapWidthLabel.Location = new System.Drawing.Point(10, 310);
            this.RectMapWidthLabel.Name = "RectMapWidthLabel";
            this.RectMapWidthLabel.Size = new System.Drawing.Size(35, 13);
            this.RectMapWidthLabel.TabIndex = 6;
            this.RectMapWidthLabel.Text = "Width";
            // 
            // RectMapHeightBox
            // 
            this.RectMapHeightBox.Location = new System.Drawing.Point(55, 337);
            this.RectMapHeightBox.Name = "RectMapHeightBox";
            this.RectMapHeightBox.Size = new System.Drawing.Size(100, 20);
            this.RectMapHeightBox.TabIndex = 9;
            // 
            // RectMapHeightLabel
            // 
            this.RectMapHeightLabel.AutoSize = true;
            this.RectMapHeightLabel.Location = new System.Drawing.Point(10, 340);
            this.RectMapHeightLabel.Name = "RectMapHeightLabel";
            this.RectMapHeightLabel.Size = new System.Drawing.Size(38, 13);
            this.RectMapHeightLabel.TabIndex = 8;
            this.RectMapHeightLabel.Text = "Height";
            // 
            // RectMapHashBox
            // 
            this.RectMapHashBox.Location = new System.Drawing.Point(55, 366);
            this.RectMapHashBox.Name = "RectMapHashBox";
            this.RectMapHashBox.Size = new System.Drawing.Size(100, 20);
            this.RectMapHashBox.TabIndex = 11;
            // 
            // RectMapHashLabel
            // 
            this.RectMapHashLabel.AutoSize = true;
            this.RectMapHashLabel.Location = new System.Drawing.Point(10, 369);
            this.RectMapHashLabel.Name = "RectMapHashLabel";
            this.RectMapHashLabel.Size = new System.Drawing.Size(32, 13);
            this.RectMapHashLabel.TabIndex = 10;
            this.RectMapHashLabel.Text = "Hash";
            // 
            // RectMapLabel
            // 
            this.RectMapLabel.AutoSize = true;
            this.RectMapLabel.Location = new System.Drawing.Point(76, 232);
            this.RectMapLabel.Name = "RectMapLabel";
            this.RectMapLabel.Size = new System.Drawing.Size(51, 13);
            this.RectMapLabel.TabIndex = 12;
            this.RectMapLabel.Text = "RectMap";
            this.RectMapLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // CaptureButton
            // 
            this.CaptureButton.Location = new System.Drawing.Point(13, 397);
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.Size = new System.Drawing.Size(75, 23);
            this.CaptureButton.TabIndex = 13;
            this.CaptureButton.Text = "Capture";
            this.CaptureButton.UseVisualStyleBackColor = true;
            this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // SceneSetupPictureBox
            // 
            this.SceneSetupPictureBox.Location = new System.Drawing.Point(198, 248);
            this.SceneSetupPictureBox.Name = "SceneSetupPictureBox";
            this.SceneSetupPictureBox.Size = new System.Drawing.Size(339, 172);
            this.SceneSetupPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SceneSetupPictureBox.TabIndex = 14;
            this.SceneSetupPictureBox.TabStop = false;
            // 
            // SceneSetupSaveButton
            // 
            this.SceneSetupSaveButton.Location = new System.Drawing.Point(94, 397);
            this.SceneSetupSaveButton.Name = "SceneSetupSaveButton";
            this.SceneSetupSaveButton.Size = new System.Drawing.Size(75, 23);
            this.SceneSetupSaveButton.TabIndex = 15;
            this.SceneSetupSaveButton.Text = "Save";
            this.SceneSetupSaveButton.UseVisualStyleBackColor = true;
            this.SceneSetupSaveButton.Click += new System.EventHandler(this.SceneSetupSaveButton_Click);
            // 
            // SceneSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 432);
            this.Controls.Add(this.SceneSetupSaveButton);
            this.Controls.Add(this.SceneSetupPictureBox);
            this.Controls.Add(this.CaptureButton);
            this.Controls.Add(this.RectMapLabel);
            this.Controls.Add(this.RectMapHashBox);
            this.Controls.Add(this.RectMapHashLabel);
            this.Controls.Add(this.RectMapHeightBox);
            this.Controls.Add(this.RectMapHeightLabel);
            this.Controls.Add(this.RectMapWidthBox);
            this.Controls.Add(this.RectMapWidthLabel);
            this.Controls.Add(this.RectMapYBox);
            this.Controls.Add(this.RectMapYLabel);
            this.Controls.Add(this.RectMapXBox);
            this.Controls.Add(this.RectMapXLabel);
            this.Controls.Add(this.SceneTitleLabel);
            this.Controls.Add(this.SceneDataGrid);
            this.Name = "SceneSetupForm";
            this.Text = "SceneSetup";
            ((System.ComponentModel.ISupportInitialize)(this.SceneDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SceneSetupPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SceneDataGrid;
        private System.Windows.Forms.Label SceneTitleLabel;
        private System.Windows.Forms.Label RectMapXLabel;
        private System.Windows.Forms.TextBox RectMapXBox;
        private System.Windows.Forms.TextBox RectMapYBox;
        private System.Windows.Forms.Label RectMapYLabel;
        private System.Windows.Forms.TextBox RectMapWidthBox;
        private System.Windows.Forms.Label RectMapWidthLabel;
        private System.Windows.Forms.TextBox RectMapHeightBox;
        private System.Windows.Forms.Label RectMapHeightLabel;
        private System.Windows.Forms.TextBox RectMapHashBox;
        private System.Windows.Forms.Label RectMapHashLabel;
        private System.Windows.Forms.Label RectMapLabel;
        private System.Windows.Forms.Button CaptureButton;
        private System.Windows.Forms.PictureBox SceneSetupPictureBox;
        private System.Windows.Forms.Button SceneSetupSaveButton;
    }
}