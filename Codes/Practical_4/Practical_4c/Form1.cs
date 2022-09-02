using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_4c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClaculate_Click(object sender, EventArgs e)
        {
            int area = Convert.ToInt32(nudLength.Text);
            area *= Convert.ToInt32(nudWidth.Text);
            int tfee = 0;
            int wfee = 0;
            int total;

            int Len = Convert.ToInt32(nudLength.Text);
            int Wit = Convert.ToInt32(nudWidth.Text);


            if (cbxTransport.Text == "" || Len == 0 || Wit == 0)
            {
                MessageBox.Show("Please fill out all fields");
            }
            else
            {
                if (area < 400)
                {
                    wfee = 250;
                    if (cbxTransport.Text == "Pta-East")
                    {
                        tfee = 50;
                    }
                    else if (cbxTransport.Text == "Pta-West" || cbxTransport.Text == "Pta-North")
                    {
                        tfee = 100;
                    }
                    else if (cbxTransport.Text == "Centurion")
                    {
                        tfee = 80;
                    }
                }
                else if (area >= 400 && area <= 600)
                {
                    wfee = 350;
                    if (cbxTransport.Text == "Pta-East")
                    {
                        tfee = 50;
                    }
                    else if (cbxTransport.Text == "Pta-West" || cbxTransport.Text == "Pta-North")
                    {
                        tfee = 100;
                    }
                    else if (cbxTransport.Text == "Centurion")
                    {
                        tfee = 80;
                    }
                }
                else if (area > 600)
                {
                    wfee = 500;
                    if (cbxTransport.Text == "Pta-East")
                    {
                        tfee = 50;
                    }
                    else if (cbxTransport.Text == "Pta-West" || cbxTransport.Text == "Pta-North")
                    {
                        tfee = 100;
                    }
                    else if (cbxTransport.Text == "Centurion")
                    {
                        tfee = 80;
                    }
                }
                total = tfee * 20 + wfee * 20;
                rtbDisplayal.Text = "Lawn mowing fee R" + wfee + "\n" + "Total fee including transport for 20 weeks R" + total;
            }
        } 
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbDisplayal.Text = " ";
        }
    }
}