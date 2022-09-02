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
            public static string name;
            public static string surname;
        }

        private void btnCapturedetails_Click(object sender, EventArgs e)
        {
            Global.name = txtName.Text;
            Global.surname = txtSurname.Text;

            gbxCalculations.Enabled = true;
            lblDisplay.Text = "BMI Calculation for " + Global.name + " " + Global.surname;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double height, weight;
            weight = Convert.ToInt32(nudWeightInKg.Text);
            height = Convert.ToInt32(nudHeightInCm.Text);
            height = ((height / 100) * (height / 100));
            double bmi = (weight / height);

            MessageBox.Show("BMI for " + Global.name + " " + Global.surname + " is = " + Math.Round(bmi, 2));
        }
    }
}