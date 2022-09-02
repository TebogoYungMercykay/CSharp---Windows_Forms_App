
namespace inf164_HW_assignment
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnArcade = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playMusicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSleep = new System.Windows.Forms.Label();
            this.timerStartStop = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSleep
            // 
            this.btnSleep.Font = new System.Drawing.Font("Garamond", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSleep.Location = new System.Drawing.Point(123, 311);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(140, 45);
            this.btnSleep.TabIndex = 12;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.Font = new System.Drawing.Font("Garamond", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.Location = new System.Drawing.Point(123, 215);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(140, 45);
            this.btnLibrary.TabIndex = 11;
            this.btnLibrary.Text = "Library";
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // btnArcade
            // 
            this.btnArcade.Font = new System.Drawing.Font("Garamond", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcade.Location = new System.Drawing.Point(123, 113);
            this.btnArcade.Name = "btnArcade";
            this.btnArcade.Size = new System.Drawing.Size(140, 45);
            this.btnArcade.TabIndex = 10;
            this.btnArcade.Text = "Arcade";
            this.btnArcade.UseVisualStyleBackColor = true;
            this.btnArcade.Click += new System.EventHandler(this.btnArcade_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inf164_HW_assignment.Properties.Resources.d62d7b86951eee40e7527d29cf434864;
            this.pictureBox1.Location = new System.Drawing.Point(307, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::inf164_HW_assignment.Properties.Resources.pink_bright_gradient_wallpaper_mural_Plain;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPointsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.playMusicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 25);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewPointsToolStripMenuItem
            // 
            this.viewPointsToolStripMenuItem.Name = "viewPointsToolStripMenuItem";
            this.viewPointsToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.viewPointsToolStripMenuItem.Text = "View points";
            this.viewPointsToolStripMenuItem.Click += new System.EventHandler(this.viewPointsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // playMusicToolStripMenuItem
            // 
            this.playMusicToolStripMenuItem.Name = "playMusicToolStripMenuItem";
            this.playMusicToolStripMenuItem.Size = new System.Drawing.Size(12, 21);
            // 
            // playMusicToolStripMenuItem1
            // 
            this.playMusicToolStripMenuItem1.Name = "playMusicToolStripMenuItem1";
            this.playMusicToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // stopMusicToolStripMenuItem
            // 
            this.stopMusicToolStripMenuItem.Name = "stopMusicToolStripMenuItem";
            this.stopMusicToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // lblSleep
            // 
            this.lblSleep.AutoSize = true;
            this.lblSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSleep.Location = new System.Drawing.Point(307, 63);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(104, 16);
            this.lblSleep.TabIndex = 15;
            this.lblSleep.Text = "Sleep Time: 0";
            // 
            // timerStartStop
            // 
            this.timerStartStop.Interval = 1000;
            this.timerStartStop.Tick += new System.EventHandler(this.timerStartStop_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(684, 457);
            this.Controls.Add(this.lblSleep);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnLibrary);
            this.Controls.Add(this.btnArcade);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnArcade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playMusicToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stopMusicToolStripMenuItem;
        private System.Windows.Forms.Label lblSleep;
        private System.Windows.Forms.Timer timerStartStop;
    }
}