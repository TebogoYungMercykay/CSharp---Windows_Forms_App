
namespace inf164_HW_assignment
{
    partial class Arcade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arcade));
            this.pbxImage1 = new System.Windows.Forms.PictureBox();
            this.pbxImage2 = new System.Windows.Forms.PictureBox();
            this.pbxImage3 = new System.Windows.Forms.PictureBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.gbxSelectCard = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.radCard3 = new System.Windows.Forms.RadioButton();
            this.radCard2 = new System.Windows.Forms.RadioButton();
            this.radCard1 = new System.Windows.Forms.RadioButton();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage3)).BeginInit();
            this.gbxSelectCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxImage1
            // 
            this.pbxImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxImage1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxImage1.ErrorImage")));
            this.pbxImage1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxImage1.InitialImage")));
            this.pbxImage1.Location = new System.Drawing.Point(87, 49);
            this.pbxImage1.Name = "pbxImage1";
            this.pbxImage1.Size = new System.Drawing.Size(158, 173);
            this.pbxImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage1.TabIndex = 1;
            this.pbxImage1.TabStop = false;
            // 
            // pbxImage2
            // 
            this.pbxImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxImage2.Location = new System.Drawing.Point(328, 49);
            this.pbxImage2.Name = "pbxImage2";
            this.pbxImage2.Size = new System.Drawing.Size(158, 173);
            this.pbxImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage2.TabIndex = 2;
            this.pbxImage2.TabStop = false;
            // 
            // pbxImage3
            // 
            this.pbxImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxImage3.Location = new System.Drawing.Point(568, 49);
            this.pbxImage3.Name = "pbxImage3";
            this.pbxImage3.Size = new System.Drawing.Size(158, 173);
            this.pbxImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage3.TabIndex = 3;
            this.pbxImage3.TabStop = false;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(278, 235);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(269, 41);
            this.btnShuffle.TabIndex = 4;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // gbxSelectCard
            // 
            this.gbxSelectCard.BackgroundImage = global::inf164_HW_assignment.Properties.Resources.JOker_;
            this.gbxSelectCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxSelectCard.Controls.Add(this.btnSelect);
            this.gbxSelectCard.Controls.Add(this.radCard3);
            this.gbxSelectCard.Controls.Add(this.radCard2);
            this.gbxSelectCard.Controls.Add(this.radCard1);
            this.gbxSelectCard.Enabled = false;
            this.gbxSelectCard.Location = new System.Drawing.Point(200, 282);
            this.gbxSelectCard.Name = "gbxSelectCard";
            this.gbxSelectCard.Size = new System.Drawing.Size(426, 147);
            this.gbxSelectCard.TabIndex = 5;
            this.gbxSelectCard.TabStop = false;
            this.gbxSelectCard.Text = "Select Card";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(128, 75);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(137, 39);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // radCard3
            // 
            this.radCard3.AutoSize = true;
            this.radCard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCard3.Location = new System.Drawing.Point(296, 31);
            this.radCard3.Name = "radCard3";
            this.radCard3.Size = new System.Drawing.Size(71, 20);
            this.radCard3.TabIndex = 2;
            this.radCard3.TabStop = true;
            this.radCard3.Text = "Card 3";
            this.radCard3.UseVisualStyleBackColor = true;
            // 
            // radCard2
            // 
            this.radCard2.AutoSize = true;
            this.radCard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCard2.Location = new System.Drawing.Point(165, 31);
            this.radCard2.Name = "radCard2";
            this.radCard2.Size = new System.Drawing.Size(71, 20);
            this.radCard2.TabIndex = 1;
            this.radCard2.TabStop = true;
            this.radCard2.Text = "Card 2";
            this.radCard2.UseVisualStyleBackColor = true;
            // 
            // radCard1
            // 
            this.radCard1.AutoSize = true;
            this.radCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCard1.Location = new System.Drawing.Point(37, 31);
            this.radCard1.Name = "radCard1";
            this.radCard1.Size = new System.Drawing.Size(71, 20);
            this.radCard1.TabIndex = 0;
            this.radCard1.TabStop = true;
            this.radCard1.Text = "Card 1";
            this.radCard1.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(661, 390);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(109, 39);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(23, 382);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(118, 16);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Current Score: 0";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(23, 416);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(101, 16);
            this.lblHighScore.TabIndex = 8;
            this.lblHighScore.Text = "High Score: 0";
            // 
            // Arcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::inf164_HW_assignment.Properties.Resources.CArds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gbxSelectCard);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.pbxImage3);
            this.Controls.Add(this.pbxImage2);
            this.Controls.Add(this.pbxImage1);
            this.Name = "Arcade";
            this.Text = "Arcade";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage3)).EndInit();
            this.gbxSelectCard.ResumeLayout(false);
            this.gbxSelectCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxImage1;
        private System.Windows.Forms.PictureBox pbxImage2;
        private System.Windows.Forms.PictureBox pbxImage3;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.GroupBox gbxSelectCard;
        private System.Windows.Forms.RadioButton radCard3;
        private System.Windows.Forms.RadioButton radCard2;
        private System.Windows.Forms.RadioButton radCard1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHighScore;
    }
}