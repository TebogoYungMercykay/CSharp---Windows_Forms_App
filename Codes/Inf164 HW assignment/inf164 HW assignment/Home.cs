using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace inf164_HW_assignment
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Tamagotchi User = new Tamagotchi();
            lblSleep.Text = "Sleep Time: " + Convert.ToString(User.mSleep);
        }
       
        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Points point = new Points();
            point.ShowDialog();*/
            this.Hide();
            var Points = new Points();
            Points.FormClosed += (s, args) => this.Close();
            Points.Show();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            /*Book_collection library = new Book_collection();
            library.ShowDialog();*/
            this.Hide();
            var Book_collection = new Book_collection();
            Book_collection.FormClosed += (s, args) => this.Close();
            Book_collection.Show();

        }

        private void btnArcade_Click(object sender, EventArgs e)
        {
            /*Arcade arcade = new Arcade();
            arcade.ShowDialog();*/
            this.Hide();
            var Arcade = new Arcade();
            Arcade.FormClosed += (s, args) => this.Close();
            Arcade.Show();

        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            Tamagotchi User = new Tamagotchi();
            lblSleep.Text = "Sleep Time: " + Convert.ToString(User.mSleep);
            if (timerStartStop.Enabled == true)
            {
                timerStartStop.Enabled = false;
            }
            else
            {
                timerStartStop.Enabled = true;
            }
        }

        private void timerStartStop_Tick(object sender, EventArgs e)
        {
            Tamagotchi User = new Tamagotchi();
            User.mSleep += 1; 
            lblSleep.Text = "Sleep Time: " + Convert.ToString(User.mSleep);
        }
    }
}
