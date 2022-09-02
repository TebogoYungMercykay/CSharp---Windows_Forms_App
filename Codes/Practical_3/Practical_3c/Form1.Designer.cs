
namespace Practical_3c
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRevisionTests = new System.Windows.Forms.TextBox();
            this.txtQuiz = new System.Windows.Forms.TextBox();
            this.txtHomeworkAssignments = new System.Windows.Forms.TextBox();
            this.txtClassTest = new System.Windows.Forms.TextBox();
            this.txtSemesterTest = new System.Windows.Forms.TextBox();
            this.txtSemesterAve = new System.Windows.Forms.Label();
            this.btnCalculateSemesterMark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculateSemesterMark);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(44, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 370);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Semester_Mark_Calculation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(73, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 37);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.53107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.46893F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtRevisionTests, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtQuiz, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHomeworkAssignments, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtClassTest, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSemesterTest, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSemesterAve, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(73, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.94805F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.05195F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(531, 224);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Revision Tests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Homework Assignments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Class Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quiz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Semester Test";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Final year/semester average[30% to write exam]";
            // 
            // txtRevisionTests
            // 
            this.txtRevisionTests.Location = new System.Drawing.Point(419, 3);
            this.txtRevisionTests.Name = "txtRevisionTests";
            this.txtRevisionTests.Size = new System.Drawing.Size(62, 20);
            this.txtRevisionTests.TabIndex = 6;
            // 
            // txtQuiz
            // 
            this.txtQuiz.Location = new System.Drawing.Point(419, 43);
            this.txtQuiz.Name = "txtQuiz";
            this.txtQuiz.Size = new System.Drawing.Size(62, 20);
            this.txtQuiz.TabIndex = 7;
            // 
            // txtHomeworkAssignments
            // 
            this.txtHomeworkAssignments.Location = new System.Drawing.Point(419, 80);
            this.txtHomeworkAssignments.Name = "txtHomeworkAssignments";
            this.txtHomeworkAssignments.Size = new System.Drawing.Size(62, 20);
            this.txtHomeworkAssignments.TabIndex = 8;
            // 
            // txtClassTest
            // 
            this.txtClassTest.Location = new System.Drawing.Point(419, 115);
            this.txtClassTest.Name = "txtClassTest";
            this.txtClassTest.Size = new System.Drawing.Size(62, 20);
            this.txtClassTest.TabIndex = 9;
            // 
            // txtSemesterTest
            // 
            this.txtSemesterTest.Location = new System.Drawing.Point(419, 152);
            this.txtSemesterTest.Name = "txtSemesterTest";
            this.txtSemesterTest.Size = new System.Drawing.Size(62, 20);
            this.txtSemesterTest.TabIndex = 10;
            // 
            // txtSemesterAve
            // 
            this.txtSemesterAve.AutoSize = true;
            this.txtSemesterAve.Location = new System.Drawing.Point(419, 184);
            this.txtSemesterAve.Name = "txtSemesterAve";
            this.txtSemesterAve.Size = new System.Drawing.Size(16, 13);
            this.txtSemesterAve.TabIndex = 11;
            this.txtSemesterAve.Text = "---";
            // 
            // btnCalculateSemesterMark
            // 
            this.btnCalculateSemesterMark.Location = new System.Drawing.Point(263, 335);
            this.btnCalculateSemesterMark.Name = "btnCalculateSemesterMark";
            this.btnCalculateSemesterMark.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateSemesterMark.TabIndex = 4;
            this.btnCalculateSemesterMark.Text = "Calculate";
            this.btnCalculateSemesterMark.UseVisualStyleBackColor = true;
            this.btnCalculateSemesterMark.Click += new System.EventHandler(this.btnCalculateSemesterMark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Average[as calculated at the end of the year/semeter]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculation of Semester Mark";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculateSemesterMark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRevisionTests;
        private System.Windows.Forms.TextBox txtQuiz;
        private System.Windows.Forms.TextBox txtHomeworkAssignments;
        private System.Windows.Forms.TextBox txtClassTest;
        private System.Windows.Forms.TextBox txtSemesterTest;
        private System.Windows.Forms.Label txtSemesterAve;
        private System.Windows.Forms.Label label1;
    }
}

