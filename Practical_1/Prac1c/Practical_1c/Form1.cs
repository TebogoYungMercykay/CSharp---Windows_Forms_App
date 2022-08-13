using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_1c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnInsta_Click(object sender, EventArgs e)
        {
            pbInsta.Visible = true;
            pbColourless.Visible = false;
            pbFacebook.Visible = false;
            pbTwitter.Visible = false;
            pbWhatsapp.Visible = false;
            btnInsta.Enabled = false;

        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            pbTwitter.Visible = true;
            pbWhatsapp.Visible = false;
            btnTwitter.Enabled = false;
            pbFacebook.Visible = false;
            pbInsta.Visible = false;
            pbColourless.Visible = false;
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            pbWhatsapp.Visible = true;
            btnWhatsapp.Enabled = false;
            pbFacebook.Visible = false;
            pbInsta.Visible = false;
            pbTwitter.Visible = false;
            pbColourless.Visible = false;
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            pbFacebook.Visible = true;
            pbInsta.Visible = false;
            pbTwitter.Visible = false;
            pbWhatsapp.Visible = false;
            btnFacebook.Enabled = false;
            pbColourless.Visible = false;
        }
    }
}
