using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_8c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random numberGenerator = new Random();
        public int RandomNumber(int min, int max)
        {
            return numberGenerator.Next(min, max);
        }
          
        private void btnRandom_Click(object sender, EventArgs e)
        {
            lstNumbers.Items.Clear();
            for(int k = 0; k < 10; k++)
            {
                int p = RandomNumber(1,31);
                this.lstNumbers.Items.Add(Convert.ToString(p));
            }    
        }

        private void btnAscending_Click(object sender, EventArgs e)
        {
            int i, j, n=10;
            for (i = 0; i < n-1; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                    if (Convert.ToInt32(lstNumbers.Items[j]) > Convert.ToInt32(lstNumbers.Items[j + 1]))
                    {
                        int temp = Convert.ToInt32(lstNumbers.Items[j]);
                        lstNumbers.Items[j] = lstNumbers.Items[j + 1];
                        lstNumbers.Items[j + 1] = Convert.ToString(temp);
                    }       
            }
        }

        private void btnDescending_Click(object sender, EventArgs e)
        {
            int i, j, n = 10;
            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                    if (Convert.ToInt32(lstNumbers.Items[j]) < Convert.ToInt32(lstNumbers.Items[j + 1]))
                    {
                        int temp = Convert.ToInt32(lstNumbers.Items[j]);
                        lstNumbers.Items[j] = lstNumbers.Items[j + 1];
                        lstNumbers.Items[j + 1] = Convert.ToString(temp);
                    }
            }
        }    
    }
}

   
