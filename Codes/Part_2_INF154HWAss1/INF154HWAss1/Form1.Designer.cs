
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
            this.gbxOrders = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.gbxAdditionalOptions = new System.Windows.Forms.GroupBox();
            this.chbApplyDiscount = new System.Windows.Forms.CheckBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.txtFinalCost = new System.Windows.Forms.TextBox();
            this.txtCostOfItem = new System.Windows.Forms.TextBox();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.pbFinalOrder = new System.Windows.Forms.GroupBox();
            this.rtbFinalOrder = new System.Windows.Forms.RichTextBox();
            this.gbxClientDetails = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitClient = new System.Windows.Forms.Button();
            this.nudYearOfBirth = new System.Windows.Forms.NumericUpDown();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbxOrders.SuspendLayout();
            this.gbxAdditionalOptions.SuspendLayout();
            this.pbFinalOrder.SuspendLayout();
            this.gbxClientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearOfBirth)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxOrders
            // 
            this.gbxOrders.Controls.Add(this.label6);
            this.gbxOrders.Controls.Add(this.label5);
            this.gbxOrders.Controls.Add(this.label4);
            this.gbxOrders.Controls.Add(this.btnSubmitOrder);
            this.gbxOrders.Controls.Add(this.gbxAdditionalOptions);
            this.gbxOrders.Controls.Add(this.txtFinalCost);
            this.gbxOrders.Controls.Add(this.txtCostOfItem);
            this.gbxOrders.Controls.Add(this.cbxItems);
            this.gbxOrders.Enabled = false;
            this.gbxOrders.Location = new System.Drawing.Point(373, 29);
            this.gbxOrders.Name = "gbxOrders";
            this.gbxOrders.Size = new System.Drawing.Size(374, 218);
            this.gbxOrders.TabIndex = 6;
            this.gbxOrders.TabStop = false;
            this.gbxOrders.Text = "Orders";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Final Cost (R)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cost of item (R)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Items";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(123, 178);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(148, 23);
            this.btnSubmitOrder.TabIndex = 4;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // gbxAdditionalOptions
            // 
            this.gbxAdditionalOptions.Controls.Add(this.chbApplyDiscount);
            this.gbxAdditionalOptions.Controls.Add(this.radLarge);
            this.gbxAdditionalOptions.Controls.Add(this.radMedium);
            this.gbxAdditionalOptions.Controls.Add(this.radSmall);
            this.gbxAdditionalOptions.Enabled = false;
            this.gbxAdditionalOptions.Location = new System.Drawing.Point(39, 72);
            this.gbxAdditionalOptions.Name = "gbxAdditionalOptions";
            this.gbxAdditionalOptions.Size = new System.Drawing.Size(289, 74);
            this.gbxAdditionalOptions.TabIndex = 3;
            this.gbxAdditionalOptions.TabStop = false;
            this.gbxAdditionalOptions.Text = "Additional Options";
            // 
            // chbApplyDiscount
            // 
            this.chbApplyDiscount.AutoSize = true;
            this.chbApplyDiscount.Location = new System.Drawing.Point(25, 42);
            this.chbApplyDiscount.Name = "chbApplyDiscount";
            this.chbApplyDiscount.Size = new System.Drawing.Size(97, 17);
            this.chbApplyDiscount.TabIndex = 3;
            this.chbApplyDiscount.Text = "Apply Discount";
            this.chbApplyDiscount.UseVisualStyleBackColor = true;
            this.chbApplyDiscount.CheckedChanged += new System.EventHandler(this.chbApplyDiscount_CheckedChanged);
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(200, 19);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(52, 17);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Location = new System.Drawing.Point(112, 19);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(62, 17);
            this.radMedium.TabIndex = 1;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(25, 19);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(50, 17);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // txtFinalCost
            // 
            this.txtFinalCost.Location = new System.Drawing.Point(139, 152);
            this.txtFinalCost.Name = "txtFinalCost";
            this.txtFinalCost.Size = new System.Drawing.Size(121, 20);
            this.txtFinalCost.TabIndex = 2;
            // 
            // txtCostOfItem
            // 
            this.txtCostOfItem.Location = new System.Drawing.Point(139, 46);
            this.txtCostOfItem.Name = "txtCostOfItem";
            this.txtCostOfItem.Size = new System.Drawing.Size(121, 20);
            this.txtCostOfItem.TabIndex = 1;
            // 
            // cbxItems
            // 
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Items.AddRange(new object[] {
            "Milkshake",
            "Chips",
            "Pizza"});
            this.cbxItems.Location = new System.Drawing.Point(139, 19);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(121, 21);
            this.cbxItems.TabIndex = 0;
            this.cbxItems.SelectedIndexChanged += new System.EventHandler(this.cbxItems_SelectedIndexChanged);
            // 
            // pbFinalOrder
            // 
            this.pbFinalOrder.Controls.Add(this.rtbFinalOrder);
            this.pbFinalOrder.Location = new System.Drawing.Point(128, 253);
            this.pbFinalOrder.Name = "pbFinalOrder";
            this.pbFinalOrder.Size = new System.Drawing.Size(453, 169);
            this.pbFinalOrder.TabIndex = 5;
            this.pbFinalOrder.TabStop = false;
            this.pbFinalOrder.Text = "Final Order";
            // 
            // rtbFinalOrder
            // 
            this.rtbFinalOrder.Location = new System.Drawing.Point(48, 19);
            this.rtbFinalOrder.Name = "rtbFinalOrder";
            this.rtbFinalOrder.Size = new System.Drawing.Size(358, 132);
            this.rtbFinalOrder.TabIndex = 0;
            this.rtbFinalOrder.Text = "";
            // 
            // gbxClientDetails
            // 
            this.gbxClientDetails.Controls.Add(this.label3);
            this.gbxClientDetails.Controls.Add(this.label2);
            this.gbxClientDetails.Controls.Add(this.label1);
            this.gbxClientDetails.Controls.Add(this.btnSubmitClient);
            this.gbxClientDetails.Controls.Add(this.nudYearOfBirth);
            this.gbxClientDetails.Controls.Add(this.txtSurname);
            this.gbxClientDetails.Controls.Add(this.txtName);
            this.gbxClientDetails.Location = new System.Drawing.Point(54, 29);
            this.gbxClientDetails.Name = "gbxClientDetails";
            this.gbxClientDetails.Size = new System.Drawing.Size(284, 180);
            this.gbxClientDetails.TabIndex = 4;
            this.gbxClientDetails.TabStop = false;
            this.gbxClientDetails.Text = "Client Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year of birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // btnSubmitClient
            // 
            this.btnSubmitClient.Location = new System.Drawing.Point(94, 133);
            this.btnSubmitClient.Name = "btnSubmitClient";
            this.btnSubmitClient.Size = new System.Drawing.Size(99, 23);
            this.btnSubmitClient.TabIndex = 3;
            this.btnSubmitClient.Text = "Submit client";
            this.btnSubmitClient.UseVisualStyleBackColor = true;
            this.btnSubmitClient.Click += new System.EventHandler(this.btnSubmitClient_Click);
            // 
            // nudYearOfBirth
            // 
            this.nudYearOfBirth.Location = new System.Drawing.Point(94, 91);
            this.nudYearOfBirth.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudYearOfBirth.Name = "nudYearOfBirth";
            this.nudYearOfBirth.Size = new System.Drawing.Size(133, 20);
            this.nudYearOfBirth.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(94, 56);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(120, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxOrders);
            this.Controls.Add(this.pbFinalOrder);
            this.Controls.Add(this.gbxClientDetails);
            this.Name = "Form1";
            this.Text = "Part 2 - u20748052";
            this.gbxOrders.ResumeLayout(false);
            this.gbxOrders.PerformLayout();
            this.gbxAdditionalOptions.ResumeLayout(false);
            this.gbxAdditionalOptions.PerformLayout();
            this.pbFinalOrder.ResumeLayout(false);
            this.gbxClientDetails.ResumeLayout(false);
            this.gbxClientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearOfBirth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOrders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.GroupBox gbxAdditionalOptions;
        private System.Windows.Forms.CheckBox chbApplyDiscount;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.TextBox txtFinalCost;
        private System.Windows.Forms.TextBox txtCostOfItem;
        private System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.GroupBox pbFinalOrder;
        private System.Windows.Forms.RichTextBox rtbFinalOrder;
        private System.Windows.Forms.GroupBox gbxClientDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitClient;
        private System.Windows.Forms.NumericUpDown nudYearOfBirth;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
    }
}

