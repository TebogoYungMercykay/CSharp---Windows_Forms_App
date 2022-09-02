using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inf164_HW_assignment
{
    public partial class Points : Form
    {
        public class myPoints
        {
            public int currentScore = 0;
            public static int HighScore;


        }
        public Points()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Home = new Home();
            Home.FormClosed += (s, args) => this.Close();
            Home.Show();
        }

        private void Points_Load(object sender, EventArgs e)
        {

        }
    }
}
