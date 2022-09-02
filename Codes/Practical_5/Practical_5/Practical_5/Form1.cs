using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Names, Surnames, stage;
        int Ages, Plans;

        private void cbxDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cbxDuration.Text) == "One")
            {
                Plans = 1;
            }
            else if (Convert.ToString(cbxDuration.Text) == "Two")
            {
                Plans = 2;
            }
            else if (Convert.ToString(cbxDuration.Text) == "Three")
            {
                Plans = 3;
            }
            else if (Convert.ToString(cbxDuration.Text) == "Four")
            {
                Plans = 4;
            }
            else if (Convert.ToString(cbxDuration.Text) == "Five")
            {
                Plans = 5;
            }
            else if (Convert.ToString(cbxDuration.Text) == "Six")
            {
                Plans = 6;
            }
            else if (Convert.ToString(cbxDuration.Text) == "Seven")
            {
                Plans = 7;
            }
            else if (Convert.ToString(cbxDuration.Text) == "Eight")
            {
                Plans = 8;
            }
            else if (Convert.ToString(cbxDuration.Text) == "Nine")
            {
                Plans = 9;
            }
            else if (Convert.ToString(cbxDuration.Text) == "Ten")
            {
                Plans = 10;
            }
            else if (Convert.ToString(cbxDuration.Text) == "Eleven")
            {
                Plans = 11;
            }
            else if (Convert.ToString(cbxDuration.Text) == "Twelve")
            {
                Plans = 12;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Ages = Convert.ToInt32(nudAge.Text);
            Names = txtName.Text;
            Surnames = txtSurname.Text;
            int Price;
            String Membership_plan;
            if (Ages < 18)
            {
                Membership_plan = "C-2021";
                stage = "Child";
            }
            else if (Ages > 17 && Ages <= 50)
            {
                Membership_plan = "A-2021";
                stage = "Adult";
            }
            else
            {
                Membership_plan = "S-2021";
                stage = "Senior";
            }
            switch (Membership_plan)
            {
                case "C-2021":
                    Price = 20 * Plans;
                    break;
                case "A-2021":
                    Price = 40 * Plans;
                    break;
                case "S-2021":
                    Price = 30 * Plans;
                    break;
                default:
                    Price = 0;
                    break;
            }
            int randomNumber;
            Random numberGenerator = new Random();
            randomNumber = numberGenerator.Next(1, 10000);

            rtbDisplay.Text = "Your policy number is " + Membership_plan + Convert.ToString(randomNumber) + "\n" + "Welcome " + Names + " " + Surnames + " to the " + stage + " Membership Policy" + "\n" + "Your expected payment: " + Price + "\n";
        }
    }
}
