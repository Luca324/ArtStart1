namespace ArtStart
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
            menuStrip2 = new MenuStrip();
            colorMixToolStripMenuItem = new ToolStripMenuItem();
            challengesToolStripMenuItem = new ToolStripMenuItem();
            paintToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { colorMixToolStripMenuItem, challengesToolStripMenuItem, paintToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 42);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // colorMixToolStripMenuItem
            // 
            colorMixToolStripMenuItem.Name = "colorMixToolStripMenuItem";
            colorMixToolStripMenuItem.Size = new Size(132, 38);
            colorMixToolStripMenuItem.Text = "color mix";
            colorMixToolStripMenuItem.Click += colorMixToolStripMenuItem_Click_1;
            // 
            // challengesToolStripMenuItem
            // 
            challengesToolStripMenuItem.Name = "challengesToolStripMenuItem";
            challengesToolStripMenuItem.Size = new Size(147, 38);
            challengesToolStripMenuItem.Text = "challenges";
            challengesToolStripMenuItem.Click += challengesToolStripMenuItem_Click;
            // 
            // paintToolStripMenuItem
            // 
            paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            paintToolStripMenuItem.Size = new Size(88, 38);
            paintToolStripMenuItem.Text = "paint";
            paintToolStripMenuItem.Click += paintToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 124);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip2);
            Name = "MainForm";
            RightToLeftLayout = true;
            Text = "С чего начнём?";
            Load += MainForm_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem colorMixToolStripMenuItem;
        private ToolStripMenuItem challengesToolStripMenuItem;
        private ToolStripMenuItem paintToolStripMenuItem;
        private Label label1;
    }
}