using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_1b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTransferText_Click(object sender, EventArgs e)
        {
            //The below code enables us to transfer data between the textboxes(*_*).
            textBox2.Text = textBox1.Text;
            textBox1.Text = "";
        }

        private void btnHideTextboxes_Click(object sender, EventArgs e)
        {
            //The below code enables us to Hide the textboxes(^_^).
            textBox1.Visible = false;
            textBox2.Visible = false;
        }
    }
}
