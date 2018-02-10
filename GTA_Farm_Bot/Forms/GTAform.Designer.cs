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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.CurrentScene = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoopBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DebuggingCheckBox
            // 
            this.DebuggingCheckBox.AutoSize = true;
            this.DebuggingCheckBox.Location = new System.Drawing.Point(12, 126);
            this.DebuggingCheckBox.Name = "DebuggingCheckBox";
            this.DebuggingCheckBox.Size = new System.Drawing.Size(78, 17);
            this.DebuggingCheckBox.TabIndex = 0;
            this.DebuggingCheckBox.Text = "Debugging";
            this.DebuggingCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogBox);
            this.panel1.Location = new System.Drawing.Point(12, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 100);
            this.panel1.TabIndex = 1;
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(3, 4);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(254, 93);
            this.LogBox.TabIndex = 0;
            // 
            // CurrentScene
            // 
            this.CurrentScene.Location = new System.Drawing.Point(172, 123);
            this.CurrentScene.Name = "CurrentScene";
            this.CurrentScene.ReadOnly = true;
            this.CurrentScene.Size = new System.Drawing.Size(100, 20);
            this.CurrentScene.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Scene";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loop Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoopBox
            // 
            this.LoopBox.Location = new System.Drawing.Point(172, 99);
            this.LoopBox.Name = "LoopBox";
            this.LoopBox.ReadOnly = true;
            this.LoopBox.Size = new System.Drawing.Size(100, 20);
            this.LoopBox.TabIndex = 0;
            
            // 
            // GTAform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LoopBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentScene);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DebuggingCheckBox);
            this.Name = "GTAform";
            this.Text = "GTA Farm Bot";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DebuggingCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox CurrentScene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoopBox;
    }
}