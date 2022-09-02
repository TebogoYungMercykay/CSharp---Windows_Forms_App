
namespace Practical_1c
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInsta = new System.Windows.Forms.Button();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.btnWhatsapp = new System.Windows.Forms.Button();
            this.pbFacebook = new System.Windows.Forms.PictureBox();
            this.pbWhatsapp = new System.Windows.Forms.PictureBox();
            this.pbTwitter = new System.Windows.Forms.PictureBox();
            this.pbInsta = new System.Windows.Forms.PictureBox();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.pbColourless = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhatsapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColourless)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsta
            // 
            this.btnInsta.Location = new System.Drawing.Point(425, 261);
            this.btnInsta.Name = "btnInsta";
            this.btnInsta.Size = new System.Drawing.Size(75, 23);
            this.btnInsta.TabIndex = 2;
            this.btnInsta.Text = "Instagram";
            this.btnInsta.UseVisualStyleBackColor = true;
            this.btnInsta.Click += new System.EventHandler(this.btnInsta_Click);
            // 
            // btnTwitter
            // 
            this.btnTwitter.Location = new System.Drawing.Point(246, 315);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(75, 23);
            this.btnTwitter.TabIndex = 3;
            this.btnTwitter.Text = "Twitter";
            this.btnTwitter.UseVisualStyleBackColor = true;
            this.btnTwitter.Click += new System.EventHandler(this.btnTwitter_Click);
            // 
            // btnWhatsapp
            // 
            this.btnWhatsapp.Location = new System.Drawing.Point(425, 315);
            this.btnWhatsapp.Name = "btnWhatsapp";
            this.btnWhatsapp.Size = new System.Drawing.Size(75, 23);
            this.btnWhatsapp.TabIndex = 4;
            this.btnWhatsapp.Text = "Whatsapp";
            this.btnWhatsapp.UseVisualStyleBackColor = true;
            this.btnWhatsapp.Click += new System.EventHandler(this.btnWhatsapp_Click);
            // 
            // pbFacebook
            // 
            this.pbFacebook.Image = ((System.Drawing.Image)(resources.GetObject("pbFacebook.Image")));
            this.pbFacebook.Location = new System.Drawing.Point(246, 28);
            this.pbFacebook.Name = "pbFacebook";
            this.pbFacebook.Size = new System.Drawing.Size(254, 196);
            this.pbFacebook.TabIndex = 5;
            this.pbFacebook.TabStop = false;
            // 
            // pbWhatsapp
            // 
            this.pbWhatsapp.Image = global::Practical_1c.Properties.Resources.Whatsapp;
            this.pbWhatsapp.Location = new System.Drawing.Point(246, 28);
            this.pbWhatsapp.Name = "pbWhatsapp";
            this.pbWhatsapp.Size = new System.Drawing.Size(254, 196);
            this.pbWhatsapp.TabIndex = 6;
            this.pbWhatsapp.TabStop = false;
            // 
            // pbTwitter
            // 
            this.pbTwitter.Image = global::Practical_1c.Properties.Resources.Twitter;
            this.pbTwitter.Location = new System.Drawing.Point(246, 28);
            this.pbTwitter.Name = "pbTwitter";
            this.pbTwitter.Size = new System.Drawing.Size(254, 196);
            this.pbTwitter.TabIndex = 7;
            this.pbTwitter.TabStop = false;
            // 
            // pbInsta
            // 
            this.pbInsta.Image = global::Practical_1c.Properties.Resources.Insta;
            this.pbInsta.Location = new System.Drawing.Point(246, 28);
            this.pbInsta.Name = "pbInsta";
            this.pbInsta.Size = new System.Drawing.Size(254, 196);
            this.pbInsta.TabIndex = 8;
            this.pbInsta.TabStop = false;
            // 
            // btnFacebook
            // 
            this.btnFacebook.Location = new System.Drawing.Point(246, 261);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(75, 23);
            this.btnFacebook.TabIndex = 9;
            this.btnFacebook.Text = "Facebook";
            this.btnFacebook.UseVisualStyleBackColor = true;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // pbColourless
            // 
            this.pbColourless.Location = new System.Drawing.Point(246, 28);
            this.pbColourless.Name = "pbColourless";
            this.pbColourless.Size = new System.Drawing.Size(254, 196);
            this.pbColourless.TabIndex = 10;
            this.pbColourless.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbColourless);
            this.Controls.Add(this.btnFacebook);
            this.Controls.Add(this.pbInsta);
            this.Controls.Add(this.pbTwitter);
            this.Controls.Add(this.pbWhatsapp);
            this.Controls.Add(this.pbFacebook);
            this.Controls.Add(this.btnWhatsapp);
            this.Controls.Add(this.btnTwitter);
            this.Controls.Add(this.btnInsta);
            this.Name = "Form1";
            this.Text = "Logo Swap";
            ((System.ComponentModel.ISupportInitialize)(this.pbFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhatsapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColourless)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInsta;
        private System.Windows.Forms.Button btnTwitter;
        private System.Windows.Forms.Button btnWhatsapp;
        private System.Windows.Forms.PictureBox pbFacebook;
        private System.Windows.Forms.PictureBox pbWhatsapp;
        private System.Windows.Forms.PictureBox pbTwitter;
        private System.Windows.Forms.PictureBox pbInsta;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.PictureBox pbColourless;
    }
}

