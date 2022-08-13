using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] my_array;
        int seconds = 60;
        int score = 0;
        Random numberGenerator = new Random();
        public int RandomNumber(int min, int max)
        {
            return numberGenerator.Next(min, max);
        }
        public string Reversed_Word(string my_String)
        {

            string Reversed = "";

            if (my_String != null)
            {
                for (int i = my_String.Length - 1; i >= 0; i--)
                {
                    Reversed += my_String[i].ToString();
                }
            }
            return Reversed;
        }
        public void Timeleft(int k)
        {
            if (k == 0)
            {
                gbxGameOver.Visible = true;
                gbxGameSettings.Visible = false;
                gbxGameMenu.Visible = false;
                gbxGameStarted.Visible = false;
                timerStartStop.Stop();
                lblErrorMessages.Text = "";
            }
            lblYourScore.Text = "Your score was: " + score;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            gbxGameSettings.Visible = false;
            gbxGameOver.Visible = false;
            gbxGameMenu.Visible = false;
            gbxGameStarted.Visible = true;

            timerStartStop.Start();
            int p = RandomNumber(0, my_array.Length);
            lblRandomWord.Text = my_array[p];
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            gbxGameSettings.Visible = true;
            gbxGameOver.Visible = false;
            gbxGameMenu.Visible = true;
            gbxGameStarted.Visible = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Instructions:" + "\n" + " " + "Save words from the game settings, Press Play, Then For every word apearing on the screen write it in reverse to gain points, You have 60 Seconds to complete the game, 10 points will be awarded each time you get the reversed word right.");
        }

        private void btnSaveWords_Click(object sender, EventArgs e)
        {
            string the_words = rtbSaveWords.Text;
            my_array = the_words.Split('\n');
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            score = 0;
            seconds = 60;
            gbxGameOver.Visible = false;
            gbxGameSettings.Visible = false;
            gbxGameMenu.Visible = true;
            gbxGameStarted.Visible = false;

            lblScorePoints.Text = "Score: " + score + " points";
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            score = 0;
            seconds = 60;
            txtRandomWord.Text = "";

            gbxGameOver.Visible = false;
            gbxGameSettings.Visible = false;
            gbxGameMenu.Visible = false;
            gbxGameStarted.Visible = true;

            timerStartStop.Start();
            int p = RandomNumber(0, my_array.Length);
            lblRandomWord.Text = my_array[p];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtRandomWord.Text.ToUpper() == Reversed_Word(lblRandomWord.Text).ToUpper())
            {
                if (seconds > 0)
                {
                    score += 10;
                }
                lblScorePoints.Text = "Score " + score + " points";
                int p = RandomNumber(0, my_array.Length);
                lblRandomWord.Text = my_array[p];
                lblErrorMessages.Text = "";
            }
            else
            {
                lblErrorMessages.Text = ("Try again to enter a correct reversed word for " + lblRandomWord.Text);
            }
        }

        private void timerStartStop_Tick(object sender, EventArgs e)
        {
            lblTimeLeft.Text = "Time Left: " + seconds + " seconds";
            Timeleft(seconds);
            seconds -= 1;
        }
    }
}
