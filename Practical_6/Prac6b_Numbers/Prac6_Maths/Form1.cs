using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac6_Maths
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //clear rtx
            rtxDisplay.Text = "";

            //declare variables
            decimal LowestRange, HighestRange, Sum = 0;

            //inputs
            LowestRange = nudLowest.Value;
            HighestRange = nudHighest.Value;

            //process
            if (radEven.Checked == true)
            {
                while (LowestRange <= HighestRange)
                {
                    if (LowestRange % 2 == 0)
                    {
                        rtxDisplay.Text = rtxDisplay.Text + LowestRange.ToString() + " ";
                        Sum = Sum + LowestRange;
                    }
                    LowestRange++;                    
                }

                rtxDisplay.Text = rtxDisplay.Text + "\n";
                rtxDisplay.Text = rtxDisplay.Text + "The sum of all the numbers is : " +Sum.ToString() + "\n";
            }
            else if(radOdd.Checked == true)
            {
                while (LowestRange <= HighestRange)
                {
                    if (LowestRange % 2 != 0)
                    {
                        rtxDisplay.Text = rtxDisplay.Text + LowestRange.ToString() + " ";
                        Sum = Sum + LowestRange;
                    }
                    LowestRange++;
                }

                rtxDisplay.Text = rtxDisplay.Text + "\n";
                rtxDisplay.Text = rtxDisplay.Text + "The sum of all the numbers is : " + Sum.ToString() + "\n";
            }
            else
            {
                /*while (LowestRange < HighestRange)
                {
                    //rtxDisplay.Text += LowestRange;                
                    int divisors = 0;
                    int i = 1;
                    while (i <= LowestRange)
                    {
                        if (LowestRange % i == 0)
                        {
                            divisors++;
                        }
                        i++;
                    }
                    if (divisors == 2)
                    {
                        rtxDisplay.Text = rtxDisplay.Text + LowestRange.ToString() + " ";
                        Sum = Sum + LowestRange;
                    }
                    else
                    {
                        
                    }
                    LowestRange++;
                }
                rtxDisplay.Text = rtxDisplay.Text + "\n";
                rtxDisplay.Text = rtxDisplay.Text + "The sum of all the numbers is : " + Sum.ToString() + "\n";
            }*/
                while (LowestRange < HighestRange)
                {
                    bool k = false;
                    int i = 2;
                    while (i < LowestRange)
                    {
                        if (LowestRange % i == 0)
                        {
                            k = true;
                        }
                        i++;
                    }
                    k = false;
                    if (!k)
                    {
                        rtxDisplay.Text = rtxDisplay.Text + LowestRange.ToString() + " ";
                        Sum = Sum + LowestRange;
                    }
                    LowestRange++;
                }
                rtxDisplay.Text = rtxDisplay.Text + "\n";
                rtxDisplay.Text = rtxDisplay.Text + "The sum of all the numbers is : " + Sum.ToString() + "\n";
            }
        }      
    }
}
