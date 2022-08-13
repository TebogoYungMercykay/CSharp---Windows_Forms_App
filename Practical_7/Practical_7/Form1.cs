using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Global
        {
            public static int seconds = 0;
            public static int minutes = 0;
            public static int hours = 0;
        }

        private void btbShape1_Click(object sender, EventArgs e)
        {
            rtbShapes.Text = ""; 
            string shape = "";
            for(int k = 1; k <= 5; k++)
            {
                for(int p = 1; p <= 6; p++)
                {
                    shape += "* ";
                }
                rtbShapes.Text += shape + "\n";
                shape = "";
            }
        }

        private void btbShape2_Click(object sender, EventArgs e)
        {
            rtbShapes.Text = "";
            string shape = "";
            for (int k = 1; k <= 5; k++)
            {
                for (int p = 1; p <= k; p++)
                {
                    shape += "* ";
                }
                rtbShapes.Text += shape + "\n";
                shape = "";
            }
        }

        private void btbShape3_Click(object sender, EventArgs e)
        {
            rtbShapes.Text = "";
            string shape = "";
            int u = 5;
            for (int k = 1; k <= 5; k++)
            {
                for(int t=1; t<u; t++)
                {
                    shape += "  ";
                }
                for (int p = 1; p <= k; p++)
                {
                    shape += "* ";
                }
                rtbShapes.Text += shape + "\n";
                shape = "";
                u--;
            }
        }

        private void btbShape4_Click(object sender, EventArgs e)
        {
            rtbShapes.Text = "";
            string shape = "";
            int u = 5;
            for (int k = 1; k <= 9; k+=2)
            {
                for (int t = 1; t < u; t++)
                {
                    shape += "  ";
                }
                for (int p = 1; p <= k; p++)
                {
                    shape += "* ";
                }
                rtbShapes.Text += shape + "\n";
                shape = "";
                u--;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrStopStart.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tmrStopStart.Stop();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            rtbRecord.Text += Global.hours + ":" + Global.minutes + ":" + Global.seconds + " was the lap recorded time" + "\n";
        }

        private void tmrStopStart_Tick(object sender, EventArgs e)
        {
            string min="0", sec="0", houur="0";
            Global.seconds += 1;
            if (Global.seconds == 60)
            {
                Global.seconds = 0;
                Global.minutes += 1;
            }
            else if(Global.minutes == 60)
            {
                Global.minutes = 0;
                Global.hours += 1;
            }
            
            sec = Convert.ToString(Global.seconds);
            min = Convert.ToString(Global.minutes);
            houur = Convert.ToString(Global.hours);
            lblTimer.Text = houur + " : " + min + " : " + sec;
        }
    }
}
