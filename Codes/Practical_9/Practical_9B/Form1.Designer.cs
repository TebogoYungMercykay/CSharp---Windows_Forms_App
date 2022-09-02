
namespace Practical_9B
{
    partial class Form1
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
            this.rtbDisplayStuff = new System.Windows.Forms.RichTextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnMarsspeak = new System.Windows.Forms.Button();
            this.btnPalindrome = new System.Windows.Forms.Button();
            this.ofdLoadText = new System.Windows.Forms.OpenFileDialog();
            this.Load = new System.Windows.Forms.MenuStrip();
            this.sfdSaveText = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbDisplayStuff
            // 
            this.rtbDisplayStuff.Location = new System.Drawing.Point(166, 42);
            this.rtbDisplayStuff.Name = "rtbDisplayStuff";
            this.rtbDisplayStuff.Size = new System.Drawing.Size(452, 225);
            this.rtbDisplayStuff.TabIndex = 0;
            this.rtbDisplayStuff.Text = "";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(166, 304);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnMarsspeak
            // 
            this.btnMarsspeak.Location = new System.Drawing.Point(349, 303);
            this.btnMarsspeak.Name = "btnMarsspeak";
            this.btnMarsspeak.Size = new System.Drawing.Size(75, 23);
            this.btnMarsspeak.TabIndex = 2;
            this.btnMarsspeak.Text = "MarsSpeak";
            this.btnMarsspeak.UseVisualStyleBackColor = true;
            this.btnMarsspeak.Click += new System.EventHandler(this.btnMarsspeak_Click);
            // 
            // btnPalindrome
            // 
            this.btnPalindrome.Location = new System.Drawing.Point(543, 303);
            this.btnPalindrome.Name = "btnPalindrome";
            this.btnPalindrome.Size = new System.Drawing.Size(75, 23);
            this.btnPalindrome.TabIndex = 3;
            this.btnPalindrome.Text = "Palindrome";
            this.btnPalindrome.UseVisualStyleBackColor = true;
            this.btnPalindrome.Click += new System.EventHandler(this.btnPalindrome_Click);
            // 
            // ofdLoadText
            // 
            this.ofdLoadText.FileName = "LECTURE 1";
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(0, 24);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(800, 24);
            this.Load.TabIndex = 4;
            this.Load.Text = "msLoad";
            this.Load.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Load_ItemClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPalindrome);
            this.Controls.Add(this.btnMarsspeak);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.rtbDisplayStuff);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.Load;
            this.Name = "Form1";
            this.Text = "Practical9B";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplayStuff;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnMarsspeak;
        private System.Windows.Forms.Button btnPalindrome;
        private System.Windows.Forms.OpenFileDialog ofdLoadText;
        private System.Windows.Forms.MenuStrip Load;
        private System.Windows.Forms.SaveFileDialog sfdSaveText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

