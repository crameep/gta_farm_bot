namespace GTA_Farm_Bot.Forms
{
    partial class GTAform
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
            this.DebuggingCheckBox = new System.Windows.Forms.CheckBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.CurrentScene = new System.Windows.Forms.TextBox();
            this.currentSceneLabel = new System.Windows.Forms.Label();
            this.LoopNumberLabel = new System.Windows.Forms.Label();
            this.LoopBox = new System.Windows.Forms.TextBox();
            this.DisplayImageBox = new System.Windows.Forms.PictureBox();
            this.BadLoopsLabel = new System.Windows.Forms.Label();
            this.BadLoopsTextBox = new System.Windows.Forms.TextBox();
            this.ImageHashLabel = new System.Windows.Forms.Label();
            this.HashBox = new System.Windows.Forms.TextBox();
            this.RoundsPlayedLabel = new System.Windows.Forms.Label();
            this.RoundsPlayedText = new System.Windows.Forms.Label();
            this.RoundsWonText = new System.Windows.Forms.Label();
            this.RoundsWonLabel = new System.Windows.Forms.Label();
            this.RoundsLostText = new System.Windows.Forms.Label();
            this.RoundsLostLabel = new System.Windows.Forms.Label();
            this.SceneDebugComboBox = new System.Windows.Forms.ComboBox();
            this.SceneDebugLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DebuggingCheckBox
            // 
            this.DebuggingCheckBox.AutoSize = true;
            this.DebuggingCheckBox.Location = new System.Drawing.Point(439, 569);
            this.DebuggingCheckBox.Name = "DebuggingCheckBox";
            this.DebuggingCheckBox.Size = new System.Drawing.Size(78, 17);
            this.DebuggingCheckBox.TabIndex = 0;
            this.DebuggingCheckBox.Text = "Debugging";
            this.DebuggingCheckBox.UseVisualStyleBackColor = true;
            this.DebuggingCheckBox.CheckedChanged += new System.EventHandler(this.DebuggingCheckBox_CheckedChanged_1);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(12, 470);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(505, 93);
            this.LogBox.TabIndex = 0;
            // 
            // CurrentScene
            // 
            this.CurrentScene.Location = new System.Drawing.Point(86, 221);
            this.CurrentScene.Name = "CurrentScene";
            this.CurrentScene.ReadOnly = true;
            this.CurrentScene.Size = new System.Drawing.Size(100, 20);
            this.CurrentScene.TabIndex = 2;
            // 
            // currentSceneLabel
            // 
            this.currentSceneLabel.AutoSize = true;
            this.currentSceneLabel.Location = new System.Drawing.Point(9, 224);
            this.currentSceneLabel.Name = "currentSceneLabel";
            this.currentSceneLabel.Size = new System.Drawing.Size(75, 13);
            this.currentSceneLabel.TabIndex = 3;
            this.currentSceneLabel.Text = "Current Scene";
            // 
            // LoopNumberLabel
            // 
            this.LoopNumberLabel.AutoSize = true;
            this.LoopNumberLabel.Location = new System.Drawing.Point(12, 569);
            this.LoopNumberLabel.Name = "LoopNumberLabel";
            this.LoopNumberLabel.Size = new System.Drawing.Size(71, 13);
            this.LoopNumberLabel.TabIndex = 4;
            this.LoopNumberLabel.Text = "Loop Number";
            // 
            // LoopBox
            // 
            this.LoopBox.Location = new System.Drawing.Point(86, 566);
            this.LoopBox.Name = "LoopBox";
            this.LoopBox.ReadOnly = true;
            this.LoopBox.Size = new System.Drawing.Size(100, 20);
            this.LoopBox.TabIndex = 0;
            // 
            // DisplayImageBox
            // 
            this.DisplayImageBox.Location = new System.Drawing.Point(12, 279);
            this.DisplayImageBox.Name = "DisplayImageBox";
            this.DisplayImageBox.Size = new System.Drawing.Size(505, 185);
            this.DisplayImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayImageBox.TabIndex = 5;
            this.DisplayImageBox.TabStop = false;
            // 
            // BadLoopsLabel
            // 
            this.BadLoopsLabel.AutoSize = true;
            this.BadLoopsLabel.Location = new System.Drawing.Point(192, 569);
            this.BadLoopsLabel.Name = "BadLoopsLabel";
            this.BadLoopsLabel.Size = new System.Drawing.Size(61, 13);
            this.BadLoopsLabel.TabIndex = 6;
            this.BadLoopsLabel.Text = "Bad Loops:";
            // 
            // BadLoopsTextBox
            // 
            this.BadLoopsTextBox.Location = new System.Drawing.Point(254, 566);
            this.BadLoopsTextBox.Name = "BadLoopsTextBox";
            this.BadLoopsTextBox.ReadOnly = true;
            this.BadLoopsTextBox.Size = new System.Drawing.Size(100, 20);
            this.BadLoopsTextBox.TabIndex = 7;
            // 
            // ImageHashLabel
            // 
            this.ImageHashLabel.AutoSize = true;
            this.ImageHashLabel.Location = new System.Drawing.Point(9, 257);
            this.ImageHashLabel.Name = "ImageHashLabel";
            this.ImageHashLabel.Size = new System.Drawing.Size(64, 13);
            this.ImageHashLabel.TabIndex = 8;
            this.ImageHashLabel.Text = "Image Hash";
            // 
            // HashBox
            // 
            this.HashBox.Location = new System.Drawing.Point(86, 254);
            this.HashBox.Name = "HashBox";
            this.HashBox.ReadOnly = true;
            this.HashBox.Size = new System.Drawing.Size(431, 20);
            this.HashBox.TabIndex = 9;
            this.HashBox.Text = "122593390591744";
            // 
            // RoundsPlayedLabel
            // 
            this.RoundsPlayedLabel.AutoSize = true;
            this.RoundsPlayedLabel.Location = new System.Drawing.Point(15, 13);
            this.RoundsPlayedLabel.Name = "RoundsPlayedLabel";
            this.RoundsPlayedLabel.Size = new System.Drawing.Size(85, 13);
            this.RoundsPlayedLabel.TabIndex = 10;
            this.RoundsPlayedLabel.Text = "Rounds Played: ";
            // 
            // RoundsPlayedText
            // 
            this.RoundsPlayedText.AutoSize = true;
            this.RoundsPlayedText.Location = new System.Drawing.Point(95, 13);
            this.RoundsPlayedText.Name = "RoundsPlayedText";
            this.RoundsPlayedText.Size = new System.Drawing.Size(13, 13);
            this.RoundsPlayedText.TabIndex = 11;
            this.RoundsPlayedText.Text = "0";
            // 
            // RoundsWonText
            // 
            this.RoundsWonText.AutoSize = true;
            this.RoundsWonText.Location = new System.Drawing.Point(95, 36);
            this.RoundsWonText.Name = "RoundsWonText";
            this.RoundsWonText.Size = new System.Drawing.Size(13, 13);
            this.RoundsWonText.TabIndex = 13;
            this.RoundsWonText.Text = "0";
            // 
            // RoundsWonLabel
            // 
            this.RoundsWonLabel.AutoSize = true;
            this.RoundsWonLabel.Location = new System.Drawing.Point(15, 36);
            this.RoundsWonLabel.Name = "RoundsWonLabel";
            this.RoundsWonLabel.Size = new System.Drawing.Size(76, 13);
            this.RoundsWonLabel.TabIndex = 12;
            this.RoundsWonLabel.Text = "Rounds Won: ";
            this.RoundsWonLabel.UseWaitCursor = true;
            // 
            // RoundsLostText
            // 
            this.RoundsLostText.AutoSize = true;
            this.RoundsLostText.Location = new System.Drawing.Point(95, 58);
            this.RoundsLostText.Name = "RoundsLostText";
            this.RoundsLostText.Size = new System.Drawing.Size(13, 13);
            this.RoundsLostText.TabIndex = 15;
            this.RoundsLostText.Text = "0";
            // 
            // RoundsLostLabel
            // 
            this.RoundsLostLabel.AllowDrop = true;
            this.RoundsLostLabel.AutoSize = true;
            this.RoundsLostLabel.Location = new System.Drawing.Point(15, 58);
            this.RoundsLostLabel.Name = "RoundsLostLabel";
            this.RoundsLostLabel.Size = new System.Drawing.Size(73, 13);
            this.RoundsLostLabel.TabIndex = 14;
            this.RoundsLostLabel.Text = "Rounds Lost: ";
            // 
            // SceneDebugComboBox
            // 
            this.SceneDebugComboBox.FormattingEnabled = true;
            this.SceneDebugComboBox.Items.AddRange(new object[] {
            "Loading",
            "Offline",
            "Phone Menu",
            "Pre Featured Adversary",
            "Featured Adversary",
            "Adversary Mode Selected",
            "Winner",
            "Loser",
            "Game Setup",
            "Freemode"});
            this.SceneDebugComboBox.Location = new System.Drawing.Point(320, 219);
            this.SceneDebugComboBox.Name = "SceneDebugComboBox";
            this.SceneDebugComboBox.Size = new System.Drawing.Size(196, 21);
            this.SceneDebugComboBox.TabIndex = 16;
            this.SceneDebugComboBox.Text = "Choose a scene to debug";
            // 
            // SceneDebugLabel
            // 
            this.SceneDebugLabel.AutoSize = true;
            this.SceneDebugLabel.Location = new System.Drawing.Point(243, 223);
            this.SceneDebugLabel.Name = "SceneDebugLabel";
            this.SceneDebugLabel.Size = new System.Drawing.Size(73, 13);
            this.SceneDebugLabel.TabIndex = 17;
            this.SceneDebugLabel.Text = "Scene Debug";
            // 
            // GTAform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 593);
            this.Controls.Add(this.SceneDebugLabel);
            this.Controls.Add(this.SceneDebugComboBox);
            this.Controls.Add(this.RoundsLostText);
            this.Controls.Add(this.RoundsLostLabel);
            this.Controls.Add(this.RoundsWonText);
            this.Controls.Add(this.RoundsWonLabel);
            this.Controls.Add(this.RoundsPlayedText);
            this.Controls.Add(this.RoundsPlayedLabel);
            this.Controls.Add(this.HashBox);
            this.Controls.Add(this.ImageHashLabel);
            this.Controls.Add(this.BadLoopsTextBox);
            this.Controls.Add(this.BadLoopsLabel);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.DisplayImageBox);
            this.Controls.Add(this.LoopBox);
            this.Controls.Add(this.LoopNumberLabel);
            this.Controls.Add(this.currentSceneLabel);
            this.Controls.Add(this.CurrentScene);
            this.Controls.Add(this.DebuggingCheckBox);
            this.Name = "GTAform";
            this.Text = "GTA Farm Bot";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DebuggingCheckBox;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox CurrentScene;
        private System.Windows.Forms.Label currentSceneLabel;
        private System.Windows.Forms.Label LoopNumberLabel;
        private System.Windows.Forms.TextBox LoopBox;
        private System.Windows.Forms.PictureBox DisplayImageBox;
        private System.Windows.Forms.Label BadLoopsLabel;
        private System.Windows.Forms.TextBox BadLoopsTextBox;
        private System.Windows.Forms.Label ImageHashLabel;
        private System.Windows.Forms.TextBox HashBox;
        private System.Windows.Forms.Label RoundsPlayedLabel;
        private System.Windows.Forms.Label RoundsPlayedText;
        private System.Windows.Forms.Label RoundsWonText;
        private System.Windows.Forms.Label RoundsWonLabel;
        private System.Windows.Forms.Label RoundsLostText;
        private System.Windows.Forms.Label RoundsLostLabel;
        private System.Windows.Forms.ComboBox SceneDebugComboBox;
        private System.Windows.Forms.Label SceneDebugLabel;
    }
}