using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            //show facebook logo and disable btn lastly disable other picture boxes
            pbFacebook.Visible = true;
            pbInsta.Visible = false;
            pbTwitter.Visible = false;
            pbWhatsapp.Visible = false;
            btnFacebook.Enabled = false;
        }

        private void btnInsta_Click(object sender, EventArgs e)
        {
            //show Instagram logo and disable btn lastly disable other picture boxes
            pbInsta.Visible = true;
            pbTwitter.Visible = false;
            pbWhatsapp.Visible = false;
            pbFacebook.Visible = false;
            btnInsta.Enabled = false;
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            //show twitter logo and disable btn lastly disable other picture boxes
            pbTwitter.Visible = true;
            pbInsta.Visible = false;
            pbFacebook.Visible = false;
            pbWhatsapp.Visible = false;
            btnTwitter.Enabled = false;
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            //show whatsapp logo and disable btn lastly disable other picture boxes
            pbWhatsapp.Visible = true;
            pbInsta.Visible = false;
            pbTwitter.Visible = false;
            pbFacebook.Visible = false;
            btnWhatsapp.Enabled = false;
        }
    }
}
