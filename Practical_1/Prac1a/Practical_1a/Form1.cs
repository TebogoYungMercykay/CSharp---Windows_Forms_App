using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_1a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            //This Button changes the message label txt (*_*)..
            lblHelloMessage.Text = "Nice to meet you all.";
            Color blue = Color.Blue;
            btnClickMe.ForeColor = blue;
        }

        private void btnChangeColour_Click(object sender, EventArgs e)
        {
            //This Button changes the "Hello" message label colour (^_^)..
            lblHelloMessage.ForeColor = Color.Red;
        }

        private void btnChangeBackgroung_Click(object sender, EventArgs e)
        {
            //This Button enables you to choose your Backround colour (-_-)..
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }
    }
}
