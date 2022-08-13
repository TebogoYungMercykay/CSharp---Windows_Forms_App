using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace inf164_HW_assignment
{
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            /*Home home = new Home();
            home.ShowDialog();*/
            this.Hide();
            var Home = new Home();
            Home.FormClosed += (s, args) => this.Close();
            Home.Show();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the your very own tamagotchi!" + "\n" + "participate in activities to earn experience points shown in by EXP in the Home form"
                + " the longer you pley the experience you will earn");
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
