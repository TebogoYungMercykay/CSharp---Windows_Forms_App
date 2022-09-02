
namespace Prac6_Maths
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
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPrime = new System.Windows.Forms.RadioButton();
            this.radOdd = new System.Windows.Forms.RadioButton();
            this.radEven = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudLowest = new System.Windows.Forms.NumericUpDown();
            this.nudHighest = new System.Windows.Forms.NumericUpDown();
            this.rtxDisplay = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(16, 193);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(225, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show all the numbers and the sum";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPrime);
            this.groupBox1.Controls.Add(this.radOdd);
            this.groupBox1.Controls.Add(this.radEven);
            this.groupBox1.Location = new System.Drawing.Point(15, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 103);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Various Types of Numbers";
            // 
            // radPrime
            // 
            this.radPrime.AutoSize = true;
            this.radPrime.Location = new System.Drawing.Point(16, 69);
            this.radPrime.Name = "radPrime";
            this.radPrime.Size = new System.Drawing.Size(94, 17);
            this.radPrime.TabIndex = 2;
            this.radPrime.Text = "Prime numbers";
            this.radPrime.UseVisualStyleBackColor = true;
            // 
            // radOdd
            // 
            this.radOdd.AutoSize = true;
            this.radOdd.Location = new System.Drawing.Point(16, 46);
            this.radOdd.Name = "radOdd";
            this.radOdd.Size = new System.Drawing.Size(88, 17);
            this.radOdd.TabIndex = 1;
            this.radOdd.Text = "Odd numbers";
            this.radOdd.UseVisualStyleBackColor = true;
            // 
            // radEven
            // 
            this.radEven.AutoSize = true;
            this.radEven.Checked = true;
            this.radEven.Location = new System.Drawing.Point(16, 23);
            this.radEven.Name = "radEven";
            this.radEven.Size = new System.Drawing.Size(93, 17);
            this.radEven.TabIndex = 0;
            this.radEven.TabStop = true;
            this.radEven.Text = "Even numbers";
            this.radEven.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lowest Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Highest Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Find and show odd, even and prime numbers based on the following range of numbers" +
    " and selection";
            // 
            // nudLowest
            // 
            this.nudLowest.Location = new System.Drawing.Point(95, 46);
            this.nudLowest.Name = "nudLowest";
            this.nudLowest.Size = new System.Drawing.Size(120, 20);
            this.nudLowest.TabIndex = 10;
            // 
            // nudHighest
            // 
            this.nudHighest.Location = new System.Drawing.Point(366, 49);
            this.nudHighest.Name = "nudHighest";
            this.nudHighest.Size = new System.Drawing.Size(120, 20);
            this.nudHighest.TabIndex = 11;
            this.nudHighest.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rtxDisplay
            // 
            this.rtxDisplay.Location = new System.Drawing.Point(16, 232);
            this.rtxDisplay.Name = "rtxDisplay";
            this.rtxDisplay.Size = new System.Drawing.Size(470, 120);
            this.rtxDisplay.TabIndex = 12;
            this.rtxDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 380);
            this.Controls.Add(this.rtxDisplay);
            this.Controls.Add(this.nudHighest);
            this.Controls.Add(this.nudLowest);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Various Types of Numbers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOdd;
        private System.Windows.Forms.RadioButton radEven;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudLowest;
        private System.Windows.Forms.NumericUpDown nudHighest;
        private System.Windows.Forms.RichTextBox rtxDisplay;
        private System.Windows.Forms.RadioButton radPrime;
    }
}

