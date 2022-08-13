
namespace Practical_1b
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTransferText = new System.Windows.Forms.Button();
            this.btnHideTextboxes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(449, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 1;
            // 
            // btnTransferText
            // 
            this.btnTransferText.Location = new System.Drawing.Point(245, 193);
            this.btnTransferText.Name = "btnTransferText";
            this.btnTransferText.Size = new System.Drawing.Size(125, 23);
            this.btnTransferText.TabIndex = 2;
            this.btnTransferText.Text = "Transfer Text";
            this.btnTransferText.UseVisualStyleBackColor = true;
            this.btnTransferText.Click += new System.EventHandler(this.btnTransferText_Click);
            // 
            // btnHideTextboxes
            // 
            this.btnHideTextboxes.Location = new System.Drawing.Point(449, 193);
            this.btnHideTextboxes.Name = "btnHideTextboxes";
            this.btnHideTextboxes.Size = new System.Drawing.Size(122, 23);
            this.btnHideTextboxes.TabIndex = 3;
            this.btnHideTextboxes.Text = "Hide Textboxes";
            this.btnHideTextboxes.UseVisualStyleBackColor = true;
            this.btnHideTextboxes.Click += new System.EventHandler(this.btnHideTextboxes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHideTextboxes);
            this.Controls.Add(this.btnTransferText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Buttons & Textboxes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTransferText;
        private System.Windows.Forms.Button btnHideTextboxes;
    }
}

