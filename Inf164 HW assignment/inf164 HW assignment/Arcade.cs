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
    public partial class Arcade : Form
    {
        public Arcade()
        {
            InitializeComponent();
            scoreG = 0;
            Tamagotchi User = new Tamagotchi();
            lblHighScore.Text = "High Score: " + Convert.ToString(User.High);
            pbxImage1.Image = Properties.Resources.Card_Backside;
            pbxImage2.Image = Properties.Resources.Card_Backside;
            pbxImage3.Image = Properties.Resources.Card_Backside;
            
        }
        private void returnHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int scoreG = 0;
        public static int hScore = 0;
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            gbxSelectCard.Enabled = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Home = new Home();
            Home.FormClosed += (s, args) => this.Close();
            Home.Show();
            /*Home home_Object = new Home();
            home_Object. ShowDialog();
            this.Hide();
            this.Close();*/
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Tamagotchi User = new Tamagotchi();
            lblHighScore.Text = "High Score: " + Convert.ToString(User.High);

            Random numberGenerator = new Random();
            int x = numberGenerator.Next(1, 4);
            if(radCard1.Checked == true)
            {
                if(x == 2)
                {
                    pbxImage1.Image = Properties.Resources.Ace_Of_Spades;
                    pbxImage2.Image = Properties.Resources.Card_Backside;
                    pbxImage3.Image = Properties.Resources.Card_Backside;
                    gbxSelectCard.Enabled = false;
                    scoreG += 1;
                    if (scoreG > User.High)
                    {
                        User.High = scoreG;
                        lblHighScore.Text = "High Score: " + Convert.ToString(User.High);
                    }
                    lblScore.Text = "Current Score: "+Convert.ToString(scoreG);
                    lblHighScore.Text = "High Score: " + Convert.ToString(User.High);
                    MessageBox.Show("Well Done!, You Won (*_*)");
                    pbxImage1.Image = Properties.Resources.Card_Backside;
                    pbxImage2.Image = Properties.Resources.Card_Backside;
                    pbxImage3.Image = Properties.Resources.Card_Backside;
                }
                else
                {
                    pbxImage1.Image = Properties.Resources.You_Lost;
                    pbxImage2.Image = Properties.Resources.Card_Backside;
                    pbxImage3.Image = Properties.Resources.Card_Backside;
                    gbxSelectCard.Enabled = false;
                    lblScore.Text = "Current Score: " + Convert.ToString(scoreG);
                    lblHighScore.Text = "High Score: " + Convert.ToString(User.High);
                    MessageBox.Show("Incorrect, The correct Card was number " + Convert.ToString(x) + " (-_-)");
                    pbxImage1.Image = Properties.Resources.Card_Backside;
                    pbxImage2.Image = Properties.Resources.Card_Backside;
                    pbxImage3.Image = Properties.Resources.Card_Backside;
                }
            }
            else if(radCard2.Checked == true)
            {
                if (x == 1)
                {
                    pbxImage1.Image = Properties.Resources.Card_Backside;
                    pbxImage2.Image = Properties.Resources.Ace_Of_Spades;
                    pbxImage3.Image = Properties.Resources.Card_Backside;
                    gbxSelectCard.Enabled = false;
                    scoreG += 1;
                    if (scoreG > User.High)
                    {
                        User.High = scoreG;
                        lblHighScore.Text = "High Score: " + Convert.ToString(User.High);
                    }
                    lblScore.Text = "Current Score: " + Convert.ToString(scoreG);
                    lblHighScore.Text = "High Score: " + Convert.ToString(User.High);
                    MessageBox.Show("Well Done!, You Won (*_*)");
                    pbxImage1.Image = Properties.Resources.Card_Backside;
                    pbxImage2.Image = Properties.Resources.Card_Backside;
                    pbxImage3.Image = Properties.Resources.Card_Backside;
                }
                else
                {
                    pbxImage1.Image = Properties.Resources.Card_Backside;
                    pbxImage2.Image = Properties.Resources.You_Lost;
                    pbxImage3.Image = Properties.Resources.Card_Backside;
                    gbxSelectCard.Enabled = false;
                    lblScore.Text = "Current Score: " + Convert.ToString(scoreG);
                    lblHighScore.Text = "High Score: " + Convert.ToString(User.High);
                    MessageBox.Show("Incorrect, The correct Card was number " + Convert.ToString(x) + " (-_-)");
                    pbxImage1.Image = Properties.Resources.Card_Backside;
                    pbxImage2.Image = Properties.Resources.Card_Backside;
                    pbxImage3.Image = Properties.Resources.Card_Backside;
                }
            }
            else if(radCard3.Checked == true)
            {
                if (x == 3)
                {
                    pbxImage1.Image = Properties.Resources.Card_Backside;
                    pbxImage2.Image = Properties.Resources.Card_Backside;
                    pbxImage3.Image = Properties.Resources.Ace_Of_Spades;
                    gbxSelectCard.Enabled = false;
                    scoreG += 1;
                    if (scoreG > User.High)
                    {
                        User.High = scoreG;
                        lblHighScore.Text = "High Score: " + Convert.ToString(User.High);
                    }
                    lblScore.Text = "Current Score: " + Convert.ToString(scoreG);
                    lblHighScore.Text = "High Score: " + Convert.ToString(User.High);
                    MessageBox.Show("Well Done!, You Won (*_*)");
                    pbxImage1.Image = Properties.Resources.Card_Backside;
                    pbxImage2.Image = Properties.Resources.Card_Backside;
                    pbxImage3.Image = Properties.Resources.Card_Backside;
                }
                else
                {
                    pbxImage1.Image = Properties.Resources.Card_Backside;
                    pbxImage2.Image = Properties.Resources.Card_Backside;
                    pbxImage3.Image = Properties.Resources.You_Lost;
                    gbxSelectCard.Enabled = false;
                    lblScore.Text = "Current Score: " + Convert.ToString(scoreG);
                    lblHighScore.Text = "High Score: " + Convert.ToString(User.High);
                    MessageBox.Show("Incorrect, The correct Card was number " + Convert.ToString(x)+" (-_-)");
                    pbxImage1.Image = Properties.Resources.Card_Backside;
                    pbxImage2.Image = Properties.Resources.Card_Backside;
                    pbxImage3.Image = Properties.Resources.Card_Backside;
                }
            }
            
        }
    }
}
