
namespace INF154HWAss1
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
            this.gbxPersonaldetails = new System.Windows.Forms.GroupBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCapturedetails = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBmi = new System.Windows.Forms.Label();
            this.gbxCalculations = new System.Windows.Forms.GroupBox();
            this.nudHeightInCm = new System.Windows.Forms.NumericUpDown();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudWeightInKg = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxPersonaldetails.SuspendLayout();
            this.gbxCalculations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightInCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightInKg)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPersonaldetails
            // 
            this.gbxPersonaldetails.Controls.Add(this.txtSurname);
            this.gbxPersonaldetails.Controls.Add(this.txtName);
            this.gbxPersonaldetails.Controls.Add(this.btnCapturedetails);
            this.gbxPersonaldetails.Controls.Add(this.label2);
            this.gbxPersonaldetails.Controls.Add(this.label1);
            this.gbxPersonaldetails.Location = new System.Drawing.Point(70, 120);
            this.gbxPersonaldetails.Name = "gbxPersonaldetails";
            this.gbxPersonaldetails.Size = new System.Drawing.Size(293, 191);
            this.gbxPersonaldetails.TabIndex = 1;
            this.gbxPersonaldetails.TabStop = false;
            this.gbxPersonaldetails.Text = "Personal Details";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(86, 100);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(144, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnCapturedetails
            // 
            this.btnCapturedetails.Location = new System.Drawing.Point(100, 139);
            this.btnCapturedetails.Name = "btnCapturedetails";
            this.btnCapturedetails.Size = new System.Drawing.Size(109, 23);
            this.btnCapturedetails.TabIndex = 2;
            this.btnCapturedetails.Text = "CaptureDetails";
            this.btnCapturedetails.UseVisualStyleBackColor = true;
            this.btnCapturedetails.Click += new System.EventHandler(this.btnCapturedetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lblBmi
            // 
            this.lblBmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmi.Location = new System.Drawing.Point(216, 56);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(299, 26);
            this.lblBmi.TabIndex = 6;
            this.lblBmi.Text = "BMI Calculator - u";
            this.lblBmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxCalculations
            // 
            this.gbxCalculations.Controls.Add(this.nudHeightInCm);
            this.gbxCalculations.Controls.Add(this.lblDisplay);
            this.gbxCalculations.Controls.Add(this.btnCalculate);
            this.gbxCalculations.Controls.Add(this.nudWeightInKg);
            this.gbxCalculations.Controls.Add(this.label4);
            this.gbxCalculations.Controls.Add(this.label5);
            this.gbxCalculations.Enabled = false;
            this.gbxCalculations.Location = new System.Drawing.Point(392, 120);
            this.gbxCalculations.Name = "gbxCalculations";
            this.gbxCalculations.Size = new System.Drawing.Size(317, 191);
            this.gbxCalculations.TabIndex = 7;
            this.gbxCalculations.TabStop = false;
            this.gbxCalculations.Text = "Calculations";
            // 
            // nudHeightInCm
            // 
            this.nudHeightInCm.Location = new System.Drawing.Point(127, 99);
            this.nudHeightInCm.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudHeightInCm.Name = "nudHeightInCm";
            this.nudHeightInCm.Size = new System.Drawing.Size(133, 20);
            this.nudHeightInCm.TabIndex = 15;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(95, 31);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(153, 13);
            this.lblDisplay.TabIndex = 14;
            this.lblDisplay.Text = "Please Confirm personal details";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(115, 137);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 23);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudWeightInKg
            // 
            this.nudWeightInKg.Location = new System.Drawing.Point(127, 59);
            this.nudWeightInKg.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudWeightInKg.Name = "nudWeightInKg";
            this.nudWeightInKg.Size = new System.Drawing.Size(133, 20);
            this.nudWeightInKg.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Height in cm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Weight in Kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxCalculations);
            this.Controls.Add(this.lblBmi);
            this.Controls.Add(this.gbxPersonaldetails);
            this.Name = "Form1";
            this.Text = "BMI Calculator - u";
            this.gbxPersonaldetails.ResumeLayout(false);
            this.gbxPersonaldetails.PerformLayout();
            this.gbxCalculations.ResumeLayout(false);
            this.gbxCalculations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightInCm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightInKg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPersonaldetails;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCapturedetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.GroupBox gbxCalculations;
        private System.Windows.Forms.NumericUpDown nudHeightInCm;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudWeightInKg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

