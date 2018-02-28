using GTABot.Classes;
using System.Collections.Generic;

namespace GTABot.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ConfigMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DebuggingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SceneSetupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.LapLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LapText = new System.Windows.Forms.ToolStripStatusLabel();
            this.Logs = new System.Windows.Forms.GroupBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.oNeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.Logs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ConfigMenu
            // 
            this.ConfigMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DebuggingMenu,
            this.SceneSetupMenu});
            this.ConfigMenu.Name = "ConfigMenu";
            this.ConfigMenu.Size = new System.Drawing.Size(55, 20);
            this.ConfigMenu.Text = "Config";
            // 
            // DebuggingMenu
            // 
            this.DebuggingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enabledToolStripMenuItem,
            this.disabledToolStripMenuItem});
            this.DebuggingMenu.Name = "DebuggingMenu";
            this.DebuggingMenu.Size = new System.Drawing.Size(152, 22);
            this.DebuggingMenu.Text = "Debuging";
            // 
            // enabledToolStripMenuItem
            // 
            this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
            this.enabledToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.enabledToolStripMenuItem.Text = "Enabled";
            // 
            // disabledToolStripMenuItem
            // 
            this.disabledToolStripMenuItem.Name = "disabledToolStripMenuItem";
            this.disabledToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.disabledToolStripMenuItem.Text = "Disabled";
            // 
            // SceneSetupMenu
            // 
            this.SceneSetupMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNeToolStripMenuItem});
            this.SceneSetupMenu.Name = "SceneSetupMenu";
            this.SceneSetupMenu.Size = new System.Drawing.Size(152, 22);
            this.SceneSetupMenu.Text = "Scene Setup";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.StatusText,
            this.LapLabel,
            this.LapText});
            this.StatusBar.Location = new System.Drawing.Point(0, 508);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(458, 22);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.StatusLabel.Size = new System.Drawing.Size(47, 17);
            this.StatusLabel.Text = "Status:";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusText
            // 
            this.StatusText.ForeColor = System.Drawing.Color.Red;
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(51, 17);
            this.StatusText.Text = "Stopped";
            this.StatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LapLabel
            // 
            this.LapLabel.Name = "LapLabel";
            this.LapLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.LapLabel.Size = new System.Drawing.Size(39, 17);
            this.LapLabel.Text = "Laps:";
            this.LapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LapText
            // 
            this.LapText.Name = "LapText";
            this.LapText.Size = new System.Drawing.Size(13, 17);
            this.LapText.Text = "0";
            // 
            // Logs
            // 
            this.Logs.Controls.Add(this.LogBox);
            this.Logs.Location = new System.Drawing.Point(12, 322);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(434, 183);
            this.Logs.TabIndex = 2;
            this.Logs.TabStop = false;
            this.Logs.Text = "Logs";
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(6, 19);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(422, 158);
            this.LogBox.TabIndex = 0;
            // 
            // oNeToolStripMenuItem
            // 
            this.oNeToolStripMenuItem.Name = "oNeToolStripMenuItem";
            this.oNeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oNeToolStripMenuItem.Text = "ONe";
            this.oNeToolStripMenuItem.Click += new System.EventHandler(this.oNeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 530);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.Logs.ResumeLayout(false);
            this.Logs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ConfigMenu;
        private System.Windows.Forms.ToolStripMenuItem DebuggingMenu;
        private System.Windows.Forms.ToolStripMenuItem SceneSetupMenu;
        private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabledToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.GroupBox Logs;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private System.Windows.Forms.ToolStripStatusLabel LapLabel;
        private System.Windows.Forms.ToolStripStatusLabel LapText;
        private System.Windows.Forms.ToolStripMenuItem oNeToolStripMenuItem;
    }
}