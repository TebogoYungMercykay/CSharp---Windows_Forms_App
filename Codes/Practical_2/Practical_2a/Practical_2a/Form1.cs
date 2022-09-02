using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_2a
{
    public partial class frmDetails : Form
    {
        public frmDetails()
        {
            InitializeComponent();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            string combo;
            combo = cbxTitles.Text + " " + txtInitials.Text + " " + txtSurname.Text;

            lblSummary.Text = combo;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string combo;
            combo = cbxTitles.Text + " " + txtInitials.Text + " " + txtSurname.Text;

            MessageBox.Show("Summary Details" + "\n" + combo);
        }

        private void btnFullDetails_Click(object sender, EventArgs e)
        {
            rtbFullDetails.AppendText("Full Personal Details" + "\n");
            rtbFullDetails.AppendText("Title: " + cbxTitles.Text + "\n");
            rtbFullDetails.AppendText("Name: " + txtName.Text + "\n");
            rtbFullDetails.AppendText("Surname: " + txtSurname.Text + "\n");
            rtbFullDetails.AppendText("Age: " + nudAge.Value.ToString());
        }
    }
}
/*private void btnSummary_Click(object sender, EventArgs e)
{
    string combo;
    combo = cbxTitles.Text + " " + txtInitials.Text + " " + txtSurname.Text;

    lblSummary.Text = combo;
}

private void btnDisplay_Click(object sender, EventArgs e)
{
    string combo;
    combo = cbxTitles.Text + " " + txtInitials.Text + " " + txtSurname.Text;

    MessageBox.Show("Summary Details" + "\n" + combo);
}

private void btnFullDetails_Click(object sender, EventArgs e)
{
    rtbFullDetails.AppendText("Full Personal Details" + "\n");
    rtbFullDetails.AppendText("Title: " + cbxTitles.Text + "\n");
    rtbFullDetails.AppendText("Name: " + txtName.Text + "\n");
    rtbFullDetails.AppendText("Surname: " + txtSurname.Text + "\n");
    rtbFullDetails.AppendText("Age: " + nudAge.Value.ToString());
}
    }
}*/