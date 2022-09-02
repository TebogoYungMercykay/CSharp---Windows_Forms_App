
namespace Practical_1a
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.btnChangeColour = new System.Windows.Forms.Button();
            this.btnChangeBackgroung = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblHelloMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(162, 163);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(138, 23);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // btnChangeColour
            // 
            this.btnChangeColour.Location = new System.Drawing.Point(354, 162);
            this.btnChangeColour.Name = "btnChangeColour";
            this.btnChangeColour.Size = new System.Drawing.Size(133, 23);
            this.btnChangeColour.TabIndex = 1;
            this.btnChangeColour.Text = "Change Colour";
            this.btnChangeColour.UseVisualStyleBackColor = true;
            this.btnChangeColour.Click += new System.EventHandler(this.btnChangeColour_Click);
            // 
            // btnChangeBackgroung
            // 
            this.btnChangeBackgroung.Location = new System.Drawing.Point(541, 162);
            this.btnChangeBackgroung.Name = "btnChangeBackgroung";
            this.btnChangeBackgroung.Size = new System.Drawing.Size(142, 23);
            this.btnChangeBackgroung.TabIndex = 2;
            this.btnChangeBackgroung.Text = "Select Color";
            this.btnChangeBackgroung.UseVisualStyleBackColor = true;
            this.btnChangeBackgroung.Click += new System.EventHandler(this.btnChangeBackgroung_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.DeepSkyBlue;
            // 
            // lblHelloMessage
            // 
            this.lblHelloMessage.AutoSize = true;
            this.lblHelloMessage.Location = new System.Drawing.Point(378, 98);
            this.lblHelloMessage.Name = "lblHelloMessage";
            this.lblHelloMessage.Size = new System.Drawing.Size(74, 13);
            this.lblHelloMessage.TabIndex = 3;
            this.lblHelloMessage.Text = "message label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHelloMessage);
            this.Controls.Add(this.btnChangeBackgroung);
            this.Controls.Add(this.btnChangeColour);
            this.Controls.Add(this.btnClickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Button btnChangeColour;
        private System.Windows.Forms.Button btnChangeBackgroung;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblHelloMessage;
    }
}

