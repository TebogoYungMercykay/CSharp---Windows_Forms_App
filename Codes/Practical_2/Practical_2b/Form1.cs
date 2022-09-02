using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbUS_CheckedChanged(object sender, EventArgs e)
        {
            double Zar;
            double Dollarr;
            const double Convert_Zar_to_D_Rate = 0.068;//As on 02/04/2021
            string Out_Put;

            Zar = Convert.ToDouble(txtRand.Text);//Convert
            Dollarr = Zar * Convert_Zar_to_D_Rate;
            Dollarr = Math.Round(Dollarr, 2);//Rounding Off

            Out_Put = "R" + txtRand.Text + " " + "is Worth" + " " + Dollarr.ToString() + " " + "Dollars";
            MessageBox.Show(Out_Put);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double Zar;
            double Poundd;
            const double Convert_Zar_to_Poundd_Rate = 0.049;//As on 02/04/2021
            string Out_Put;

            Zar = Convert.ToDouble(txtRand.Text);//Convert
            Poundd = Zar * Convert_Zar_to_Poundd_Rate;
            Poundd = Math.Round(Poundd, 2);//Rounding Off

            Out_Put = "R" + txtRand.Text + " " + "is Worth" + " " + Poundd.ToString() + " " + "Pounds";
            MessageBox.Show(Out_Put);
        }

        private void rbEuro_CheckedChanged(object sender, EventArgs e)
        {
            double Zar;
            double Euroh;
            const double Convert_Zar_to_Euroh_Rate = 0.058;//As on 02/04/2021
            string Out_Put;

            Zar = Convert.ToDouble(txtRand.Text);//Convert
            Euroh = Zar * Convert_Zar_to_Euroh_Rate;
            Euroh = Math.Round(Euroh, 2);//Rounding Off

            Out_Put = "R" + txtRand.Text + " " + "is Worth" + " " + Euroh.ToString() + " " + "Euros";
            MessageBox.Show(Out_Put);
        }
    }
}
