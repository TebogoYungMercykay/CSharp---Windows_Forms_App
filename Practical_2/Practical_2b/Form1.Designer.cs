
namespace Practical_2b
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRand = new System.Windows.Forms.TextBox();
            this.rbPound = new System.Windows.Forms.GroupBox();
            this.rbUS = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbEuro = new System.Windows.Forms.RadioButton();
            this.rbPound.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Rand value to convert here: R";
            // 
            // txtRand
            // 
            this.txtRand.Location = new System.Drawing.Point(365, 94);
            this.txtRand.Name = "txtRand";
            this.txtRand.Size = new System.Drawing.Size(100, 20);
            this.txtRand.TabIndex = 1;
            // 
            // rbPound
            // 
            this.rbPound.Controls.Add(this.rbEuro);
            this.rbPound.Controls.Add(this.radioButton2);
            this.rbPound.Controls.Add(this.rbUS);
            this.rbPound.Location = new System.Drawing.Point(198, 172);
            this.rbPound.Name = "rbPound";
            this.rbPound.Size = new System.Drawing.Size(243, 180);
            this.rbPound.TabIndex = 2;
            this.rbPound.TabStop = false;
            this.rbPound.Text = "Choose Currency";
            // 
            // rbUS
            // 
            this.rbUS.AutoSize = true;
            this.rbUS.Location = new System.Drawing.Point(65, 36);
            this.rbUS.Name = "rbUS";
            this.rbUS.Size = new System.Drawing.Size(70, 17);
            this.rbUS.TabIndex = 0;
            this.rbUS.TabStop = true;
            this.rbUS.Text = "US Dollar";
            this.rbUS.UseVisualStyleBackColor = true;
            this.rbUS.CheckedChanged += new System.EventHandler(this.rbUS_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(65, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pound";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbEuro
            // 
            this.rbEuro.AutoSize = true;
            this.rbEuro.Location = new System.Drawing.Point(65, 122);
            this.rbEuro.Name = "rbEuro";
            this.rbEuro.Size = new System.Drawing.Size(47, 17);
            this.rbEuro.TabIndex = 2;
            this.rbEuro.TabStop = true;
            this.rbEuro.Text = "Euro";
            this.rbEuro.UseVisualStyleBackColor = true;
            this.rbEuro.CheckedChanged += new System.EventHandler(this.rbEuro_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbPound);
            this.Controls.Add(this.txtRand);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.rbPound.ResumeLayout(false);
            this.rbPound.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRand;
        private System.Windows.Forms.GroupBox rbPound;
        private System.Windows.Forms.RadioButton rbEuro;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbUS;
    }
}

