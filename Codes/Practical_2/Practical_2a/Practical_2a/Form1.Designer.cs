
namespace Practical_2a
{
    partial class frmDetails
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
            this.gbxPersonalDetails = new System.Windows.Forms.GroupBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.cbxTitles = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnFullDetails = new System.Windows.Forms.Button();
            this.rtbFullDetails = new System.Windows.Forms.RichTextBox();
            this.gbxPersonalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPersonalDetails
            // 
            this.gbxPersonalDetails.Controls.Add(this.nudAge);
            this.gbxPersonalDetails.Controls.Add(this.txtSurname);
            this.gbxPersonalDetails.Controls.Add(this.txtName);
            this.gbxPersonalDetails.Controls.Add(this.txtInitials);
            this.gbxPersonalDetails.Controls.Add(this.cbxTitles);
            this.gbxPersonalDetails.Controls.Add(this.label5);
            this.gbxPersonalDetails.Controls.Add(this.label4);
            this.gbxPersonalDetails.Controls.Add(this.label3);
            this.gbxPersonalDetails.Controls.Add(this.label2);
            this.gbxPersonalDetails.Controls.Add(this.label1);
            this.gbxPersonalDetails.Location = new System.Drawing.Point(66, 58);
            this.gbxPersonalDetails.Name = "gbxPersonalDetails";
            this.gbxPersonalDetails.Size = new System.Drawing.Size(379, 232);
            this.gbxPersonalDetails.TabIndex = 0;
            this.gbxPersonalDetails.TabStop = false;
            this.gbxPersonalDetails.Text = "Personal Details";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(131, 170);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(120, 20);
            this.nudAge.TabIndex = 9;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(131, 137);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtInitials
            // 
            this.txtInitials.Location = new System.Drawing.Point(131, 72);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(100, 20);
            this.txtInitials.TabIndex = 6;
            // 
            // cbxTitles
            // 
            this.cbxTitles.FormattingEnabled = true;
            this.cbxTitles.Items.AddRange(new object[] {
            "Mrs",
            "Ms",
            "Miss",
            "Mr",
            "Dr",
            "Prof"});
            this.cbxTitles.Location = new System.Drawing.Point(131, 39);
            this.cbxTitles.Name = "cbxTitles";
            this.cbxTitles.Size = new System.Drawing.Size(121, 21);
            this.cbxTitles.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Initials";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(214, 309);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(50, 13);
            this.lblSummary.TabIndex = 1;
            this.lblSummary.Text = "Summary";
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(66, 338);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(109, 23);
            this.btnSummary.TabIndex = 2;
            this.btnSummary.Text = "Show Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(197, 338);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(123, 23);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display Message Box";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnFullDetails
            // 
            this.btnFullDetails.Location = new System.Drawing.Point(337, 338);
            this.btnFullDetails.Name = "btnFullDetails";
            this.btnFullDetails.Size = new System.Drawing.Size(108, 23);
            this.btnFullDetails.TabIndex = 4;
            this.btnFullDetails.Text = "Display Full Details";
            this.btnFullDetails.UseVisualStyleBackColor = true;
            this.btnFullDetails.Click += new System.EventHandler(this.btnFullDetails_Click);
            // 
            // rtbFullDetails
            // 
            this.rtbFullDetails.Location = new System.Drawing.Point(496, 58);
            this.rtbFullDetails.Name = "rtbFullDetails";
            this.rtbFullDetails.Size = new System.Drawing.Size(241, 232);
            this.rtbFullDetails.TabIndex = 5;
            this.rtbFullDetails.Text = "";
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbFullDetails);
            this.Controls.Add(this.btnFullDetails);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.gbxPersonalDetails);
            this.Name = "frmDetails";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.frmDetails_Load);
            this.gbxPersonalDetails.ResumeLayout(false);
            this.gbxPersonalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPersonalDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnFullDetails;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.ComboBox cbxTitles;
        private System.Windows.Forms.RichTextBox rtbFullDetails;
    }
}

