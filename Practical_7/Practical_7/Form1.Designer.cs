
namespace Practical_7
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
            this.components = new System.ComponentModel.Container();
            this.gbShapes = new System.Windows.Forms.GroupBox();
            this.rtbShapes = new System.Windows.Forms.RichTextBox();
            this.btbShape4 = new System.Windows.Forms.Button();
            this.btbShape3 = new System.Windows.Forms.Button();
            this.btbShape2 = new System.Windows.Forms.Button();
            this.btbShape1 = new System.Windows.Forms.Button();
            this.gbStopWatch = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.rtbRecord = new System.Windows.Forms.RichTextBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrStopStart = new System.Windows.Forms.Timer(this.components);
            this.gbShapes.SuspendLayout();
            this.gbStopWatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbShapes
            // 
            this.gbShapes.Controls.Add(this.rtbShapes);
            this.gbShapes.Controls.Add(this.btbShape4);
            this.gbShapes.Controls.Add(this.btbShape3);
            this.gbShapes.Controls.Add(this.btbShape2);
            this.gbShapes.Controls.Add(this.btbShape1);
            this.gbShapes.Location = new System.Drawing.Point(70, 12);
            this.gbShapes.Name = "gbShapes";
            this.gbShapes.Size = new System.Drawing.Size(582, 182);
            this.gbShapes.TabIndex = 0;
            this.gbShapes.TabStop = false;
            this.gbShapes.Text = "Shape Drawer Section";
            // 
            // rtbShapes
            // 
            this.rtbShapes.Location = new System.Drawing.Point(286, 22);
            this.rtbShapes.Name = "rtbShapes";
            this.rtbShapes.Size = new System.Drawing.Size(268, 135);
            this.rtbShapes.TabIndex = 4;
            this.rtbShapes.Text = "";
            // 
            // btbShape4
            // 
            this.btbShape4.Location = new System.Drawing.Point(19, 125);
            this.btbShape4.Name = "btbShape4";
            this.btbShape4.Size = new System.Drawing.Size(223, 23);
            this.btbShape4.TabIndex = 3;
            this.btbShape4.Text = "4) PYRAMID";
            this.btbShape4.UseVisualStyleBackColor = true;
            this.btbShape4.Click += new System.EventHandler(this.btbShape4_Click);
            // 
            // btbShape3
            // 
            this.btbShape3.Location = new System.Drawing.Point(19, 96);
            this.btbShape3.Name = "btbShape3";
            this.btbShape3.Size = new System.Drawing.Size(223, 23);
            this.btbShape3.TabIndex = 2;
            this.btbShape3.Text = "3) LEFT ANGLE TRIANGLE";
            this.btbShape3.UseVisualStyleBackColor = true;
            this.btbShape3.Click += new System.EventHandler(this.btbShape3_Click);
            // 
            // btbShape2
            // 
            this.btbShape2.Location = new System.Drawing.Point(19, 67);
            this.btbShape2.Name = "btbShape2";
            this.btbShape2.Size = new System.Drawing.Size(223, 23);
            this.btbShape2.TabIndex = 1;
            this.btbShape2.Text = "2) RIGHT ANGLE TRIANGLE";
            this.btbShape2.UseVisualStyleBackColor = true;
            this.btbShape2.Click += new System.EventHandler(this.btbShape2_Click);
            // 
            // btbShape1
            // 
            this.btbShape1.Location = new System.Drawing.Point(19, 38);
            this.btbShape1.Name = "btbShape1";
            this.btbShape1.Size = new System.Drawing.Size(223, 23);
            this.btbShape1.TabIndex = 0;
            this.btbShape1.Text = "1) SQUARE";
            this.btbShape1.UseVisualStyleBackColor = true;
            this.btbShape1.Click += new System.EventHandler(this.btbShape1_Click);
            // 
            // gbStopWatch
            // 
            this.gbStopWatch.Controls.Add(this.lblTimer);
            this.gbStopWatch.Controls.Add(this.lblHeader);
            this.gbStopWatch.Controls.Add(this.rtbRecord);
            this.gbStopWatch.Controls.Add(this.btnRecord);
            this.gbStopWatch.Controls.Add(this.btnPause);
            this.gbStopWatch.Controls.Add(this.btnStart);
            this.gbStopWatch.Location = new System.Drawing.Point(70, 200);
            this.gbStopWatch.Name = "gbStopWatch";
            this.gbStopWatch.Size = new System.Drawing.Size(582, 238);
            this.gbStopWatch.TabIndex = 1;
            this.gbStopWatch.TabStop = false;
            this.gbStopWatch.Text = "Stop Watch Section";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(237, 41);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(132, 25);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "00 : 00 : 00";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(231, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(154, 25);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "HH : MM : SS";
            // 
            // rtbRecord
            // 
            this.rtbRecord.Location = new System.Drawing.Point(50, 98);
            this.rtbRecord.Name = "rtbRecord";
            this.rtbRecord.Size = new System.Drawing.Size(469, 115);
            this.rtbRecord.TabIndex = 3;
            this.rtbRecord.Text = "";
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(392, 69);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(127, 23);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "Record Lap Time";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(223, 69);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(133, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(50, 69);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrStopStart
            // 
            this.tmrStopStart.Interval = 1000;
            this.tmrStopStart.Tick += new System.EventHandler(this.tmrStopStart_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.gbStopWatch);
            this.Controls.Add(this.gbShapes);
            this.Name = "Form1";
            this.Text = "Practical 7c";
            this.gbShapes.ResumeLayout(false);
            this.gbStopWatch.ResumeLayout(false);
            this.gbStopWatch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbShapes;
        private System.Windows.Forms.RichTextBox rtbShapes;
        private System.Windows.Forms.Button btbShape4;
        private System.Windows.Forms.Button btbShape3;
        private System.Windows.Forms.Button btbShape2;
        private System.Windows.Forms.Button btbShape1;
        private System.Windows.Forms.GroupBox gbStopWatch;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.RichTextBox rtbRecord;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrStopStart;
    }
}

