using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154HWAss1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Global
        {
            //Variables for the Client Details GroupBox data.
            public static string Name;
            public static string Surname;
            public static int Yearofbirth;
            //Variables for the Oders GroupBox data.
            public static string Discount_Applied;
            public static string Size;
            public static double total;
            public static double price;
            public const double discount = 0.1;
        }

        private void btnSubmitClient_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please fill in the name");
            }
            else if (txtSurname.Text == "")
            {
                MessageBox.Show("Please fill in the surname");
            }
            else if (Convert.ToInt32(nudYearOfBirth.Text) < 1922 || Convert.ToInt32(nudYearOfBirth.Text) > 2021)
            {
                MessageBox.Show("Please enter correct year of birth");
            }
            else
            {
                Global.Name = txtName.Text;
                Global.Surname = txtSurname.Text;
                Global.Yearofbirth = Convert.ToInt32(nudYearOfBirth.Text);
                gbxOrders.Enabled = true;
                txtFinalCost.Enabled = false;
                txtCostOfItem.Enabled = false;
            }
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            rtbFinalOrder.Text = "Name: " + Global.Name + " " + Global.Surname + "\n" + "Age: " + (2021 - Global.Yearofbirth) + "\n" + "Order: " + cbxItems.Text + "\n" + "Size: " + Global.Size + "\n" + "Discount Applied: " + Global.Discount_Applied + "\n" + "Final Cost: " + Math.Round(Global.total, 2) + "\n";
        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cbxItems.Text) == "Milkshake")
            {
                Global.price = 50;
                txtCostOfItem.Text = Convert.ToString(Global.price);
                txtFinalCost.Text = Convert.ToString(Global.price);
            }
            else if (Convert.ToString(cbxItems.Text) == "Chips")
            {
                Global.price = 100;
                txtCostOfItem.Text = Convert.ToString(Global.price);
                txtFinalCost.Text = Convert.ToString(Global.price);
            }
            else if (Convert.ToString(cbxItems.Text) == "Pizza")
            {
                Global.price = 150;
                txtCostOfItem.Text = Convert.ToString(Global.price);
                txtFinalCost.Text = Convert.ToString(Global.price);
            }
            gbxAdditionalOptions.Enabled = true;
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (radSmall.Checked == true)
            {
                Global.Size = "Small";
                if (Convert.ToString(cbxItems.Text) == "Milkshake")
                {
                    Global.price = 50;
                    txtFinalCost.Text = Convert.ToString(Global.price);
                }
                else if (Convert.ToString(cbxItems.Text) == "Chips")
                {
                    Global.price = 100;
                    txtFinalCost.Text = Convert.ToString(Global.price);
                }
                else if (Convert.ToString(cbxItems.Text) == "Pizza")
                {
                    Global.price = 150;
                    txtFinalCost.Text = Convert.ToString(Global.price);
                }
            }
        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (radMedium.Checked == true)
            {
                Global.Size = "Medium";
                if (Convert.ToString(cbxItems.Text) == "Milkshake")
                {
                    Global.price = 62.5;
                    txtFinalCost.Text = Convert.ToString(Global.price);
                }
                else if (Convert.ToString(cbxItems.Text) == "Chips")
                {
                    Global.price = 125;
                    txtFinalCost.Text = Convert.ToString(Global.price);
                }
                else if (Convert.ToString(cbxItems.Text) == "Pizza")
                {
                    Global.price = 187.5;
                    txtFinalCost.Text = Convert.ToString(Global.price);
                }
            }
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (radLarge.Checked == true)
            {
                Global.Size = "Large";
                if (Convert.ToString(cbxItems.Text) == "Milkshake")
                {
                    Global.price = 75;
                    txtFinalCost.Text = Convert.ToString(Global.price);
                }
                else if (Convert.ToString(cbxItems.Text) == "Chips")
                {
                    Global.price = 150;
                    txtFinalCost.Text = Convert.ToString(Global.price);
                }
                else if (Convert.ToString(cbxItems.Text) == "Pizza")
                {
                    Global.price = 225;
                    txtFinalCost.Text = Convert.ToString(Global.price);
                }
            }
        }

        private void chbApplyDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chbApplyDiscount.Checked == true)
            {
                Global.Discount_Applied = "Yes";
                Global.total = Global.price - Global.price * Global.discount;
                txtFinalCost.Text = Convert.ToString(Global.total);
            }
            else
            {
                Global.Discount_Applied = "No";
            }
        }
    }
}
