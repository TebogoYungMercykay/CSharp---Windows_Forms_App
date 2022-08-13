
namespace Practical_6
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
            this.btnShowTables = new System.Windows.Forms.Button();
            this.txtTables = new System.Windows.Forms.TextBox();
            this.rtbShowTable = new System.Windows.Forms.RichTextBox();
            this.lblTables = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowTables
            // 
            this.btnShowTables.Location = new System.Drawing.Point(385, 36);
            this.btnShowTables.Name = "btnShowTables";
            this.btnShowTables.Size = new System.Drawing.Size(230, 23);
            this.btnShowTables.TabIndex = 0;
            this.btnShowTables.Text = "Show";
            this.btnShowTables.UseVisualStyleBackColor = true;
            this.btnShowTables.Click += new System.EventHandler(this.btnShowTables_Click);
            // 
            // txtTables
            // 
            this.txtTables.Location = new System.Drawing.Point(134, 39);
            this.txtTables.Name = "txtTables";
            this.txtTables.Size = new System.Drawing.Size(217, 20);
            this.txtTables.TabIndex = 1;
            // 
            // rtbShowTable
            // 
            this.rtbShowTable.Location = new System.Drawing.Point(134, 78);
            this.rtbShowTable.Name = "rtbShowTable";
            this.rtbShowTable.Size = new System.Drawing.Size(481, 331);
            this.rtbShowTable.TabIndex = 2;
            this.rtbShowTable.Text = "";
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTables.Location = new System.Drawing.Point(157, 9);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(437, 24);
            this.lblTables.TabIndex = 3;
            this.lblTables.Text = "How many Multiplication Tables would like to view?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.rtbShowTable);
            this.Controls.Add(this.txtTables);
            this.Controls.Add(this.btnShowTables);
            this.Name = "Form1";
            this.Text = "Maths";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowTables;
        private System.Windows.Forms.TextBox txtTables;
        private System.Windows.Forms.RichTextBox rtbShowTable;
        private System.Windows.Forms.Label lblTables;
    }
}

