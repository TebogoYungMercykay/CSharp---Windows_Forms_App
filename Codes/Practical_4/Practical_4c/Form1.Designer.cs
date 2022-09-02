
namespace Practical_4c
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.cbxTransport = new System.Windows.Forms.ComboBox();
            this.rtbDisplayal = new System.Windows.Forms.RichTextBox();
            this.btnClaculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transport";
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(157, 102);
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(120, 20);
            this.nudLength.TabIndex = 3;
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(157, 161);
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 20);
            this.nudWidth.TabIndex = 4;
            // 
            // cbxTransport
            // 
            this.cbxTransport.FormattingEnabled = true;
            this.cbxTransport.Items.AddRange(new object[] {
            "Pta-East",
            "Pta-West",
            "Pta-North",
            "Centurion"});
            this.cbxTransport.Location = new System.Drawing.Point(157, 221);
            this.cbxTransport.Name = "cbxTransport";
            this.cbxTransport.Size = new System.Drawing.Size(121, 21);
            this.cbxTransport.TabIndex = 5;
            // 
            // rtbDisplayal
            // 
            this.rtbDisplayal.Location = new System.Drawing.Point(325, 102);
            this.rtbDisplayal.Name = "rtbDisplayal";
            this.rtbDisplayal.Size = new System.Drawing.Size(362, 140);
            this.rtbDisplayal.TabIndex = 6;
            this.rtbDisplayal.Text = "";
            // 
            // btnClaculate
            // 
            this.btnClaculate.Location = new System.Drawing.Point(251, 293);
            this.btnClaculate.Name = "btnClaculate";
            this.btnClaculate.Size = new System.Drawing.Size(75, 23);
            this.btnClaculate.TabIndex = 7;
            this.btnClaculate.Text = "Calculate";
            this.btnClaculate.UseVisualStyleBackColor = true;
            this.btnClaculate.Click += new System.EventHandler(this.btnClaculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(433, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClaculate);
            this.Controls.Add(this.rtbDisplayal);
            this.Controls.Add(this.cbxTransport);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lawn Mowing Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.ComboBox cbxTransport;
        private System.Windows.Forms.RichTextBox rtbDisplayal;
        private System.Windows.Forms.Button btnClaculate;
        private System.Windows.Forms.Button btnClear;
    }
}

