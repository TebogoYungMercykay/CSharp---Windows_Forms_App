
namespace inf164_HW_assignment
{
    partial class Book_collection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refundABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfBooksPerGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::inf164_HW_assignment.Properties.Resources.pink_bright_gradient_wallpaper_mural_Plain;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCollectionToolStripMenuItem,
            this.refundABookToolStripMenuItem,
            this.numberOfBooksPerGameToolStripMenuItem,
            this.returnHomeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editCollectionToolStripMenuItem
            // 
            this.editCollectionToolStripMenuItem.Name = "editCollectionToolStripMenuItem";
            this.editCollectionToolStripMenuItem.Size = new System.Drawing.Size(114, 21);
            this.editCollectionToolStripMenuItem.Text = "Edit collection";
            this.editCollectionToolStripMenuItem.Click += new System.EventHandler(this.editCollectionToolStripMenuItem_Click);
            // 
            // refundABookToolStripMenuItem
            // 
            this.refundABookToolStripMenuItem.Name = "refundABookToolStripMenuItem";
            this.refundABookToolStripMenuItem.Size = new System.Drawing.Size(113, 21);
            this.refundABookToolStripMenuItem.Text = "Refund a book";
            this.refundABookToolStripMenuItem.Click += new System.EventHandler(this.refundABookToolStripMenuItem_Click);
            // 
            // numberOfBooksPerGameToolStripMenuItem
            // 
            this.numberOfBooksPerGameToolStripMenuItem.Name = "numberOfBooksPerGameToolStripMenuItem";
            this.numberOfBooksPerGameToolStripMenuItem.Size = new System.Drawing.Size(122, 21);
            this.numberOfBooksPerGameToolStripMenuItem.Text = "Number of books per game";
            this.numberOfBooksPerGameToolStripMenuItem.Click += new System.EventHandler(this.numberOfBooksPerGameToolStripMenuItem_Click);
            // 
            // returnHomeToolStripMenuItem
            // 
            this.returnHomeToolStripMenuItem.Name = "returnHomeToolStripMenuItem";
            this.returnHomeToolStripMenuItem.Size = new System.Drawing.Size(102, 21);
            this.returnHomeToolStripMenuItem.Text = "Return home";
            this.returnHomeToolStripMenuItem.Click += new System.EventHandler(this.returnHomeToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(506, 115);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Garamond", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAdd.Location = new System.Drawing.Point(245, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add to collection";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxdateTimePicker1
            // 
            this.cbxdateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxdateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbxdateTimePicker1.Location = new System.Drawing.Point(326, 130);
            this.cbxdateTimePicker1.Name = "cbxdateTimePicker1";
            this.cbxdateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.cbxdateTimePicker1.TabIndex = 18;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTitle.Location = new System.Drawing.Point(326, 76);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTitle.TabIndex = 15;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAuthor.Location = new System.Drawing.Point(326, 101);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(200, 20);
            this.txtAuthor.TabIndex = 16;
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCost.Location = new System.Drawing.Point(326, 189);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(200, 20);
            this.txtCost.TabIndex = 17;
            // 
            // cbxGenre
            // 
            this.cbxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Items.AddRange(new object[] {
            "Comedy",
            "Romance",
            "Action",
            "Adventure",
            "Fantasy"});
            this.cbxGenre.Location = new System.Drawing.Point(326, 156);
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(200, 21);
            this.cbxGenre.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Book cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Purchase date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Purchase a new book";
            // 
            // Book_collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::inf164_HW_assignment.Properties.Resources.aed3af228ae0e1caf10c838aa36829ed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxdateTimePicker1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.cbxGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Book_collection";
            this.Text = "Book_collection";
            this.Load += new System.EventHandler(this.Book_collection_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem editCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refundABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfBooksPerGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnHomeToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker cbxdateTimePicker1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}