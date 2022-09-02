using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_9B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declaring string arrays
        string[] my_Array;
        //Declaring var for a number of parlindromes
        int Parli = 0;
        public bool Palindrome(string my_String)
        {
            bool k = false;
            string Reversed = "";

            if (my_String != null)
            {
                for (int i = my_String.Length - 1; i >= 0; i--)
                {
                    Reversed += my_String[i].ToString();
                }
                if (Reversed == my_String)
                {
                    k = true;
                }
                else
                {
                    k = false;
                }
            }
            return k;
        }
        public string MarsSpeak(string my_String)
        {
            if (my_String != "" || my_String != null)
            {
                if (my_String[0] == 'A' || my_String[0] == 'E' || my_String[0] == 'I' || my_String[0] == 'O' || my_String[0] == 'U')
                {
                    my_String += "way";
                }
                else
                {
                    char first_char = my_String[0];
                    my_String = my_String.Substring(1, my_String.Length - 1) + my_String[0] + "ay";
                }
            }
            return my_String;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            rtbDisplayStuff.Clear();
            ofdLoadText.ShowDialog();
            rtbDisplayStuff.LoadFile(ofdLoadText.FileName);
            string the_data = rtbDisplayStuff.Text;
            my_Array = the_data.Split('\n');
            Parli = 0;
        }



        private void btnMarsspeak_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < my_Array.Length; k++)
            {
                my_Array[k] = MarsSpeak(my_Array[k]);
            }

            string Textt = "";
            for (int k = 0; k < my_Array.Length; k++)
            {
                Textt += my_Array[k]+"\n";
            }
            rtbDisplayStuff.Text = Textt;
            rtbDisplayStuff.SaveFile(ofdLoadText.FileName);

        }

        private void btnPalindrome_Click(object sender, EventArgs e)
        {
            Parli = 0;
            for (int k = 0; k < my_Array.Length; k++)
            {

                if (Palindrome(my_Array[k]))
                {
                    my_Array[k] += "*";
                    Parli += 1;
                }
            }
            string Textt = "";
            for (int k = 0; k < my_Array.Length; k++)
            {
                Textt += my_Array[k]+"\n";
            }
            rtbDisplayStuff.Text = Textt;
            rtbDisplayStuff.SaveFile(ofdLoadText.FileName);
            if (Parli == 1){
                MessageBox.Show("We have " + Parli + " Palindrome in the array");
            }
            else
            {
                MessageBox.Show("We have " + Parli + " Palindromes in the array");
            }
        }

        private void Load_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            rtbDisplayStuff.Clear();
            ofdLoadText.ShowDialog();
            rtbDisplayStuff.LoadFile(ofdLoadText.FileName);
            string the_data = rtbDisplayStuff.Text;
            my_Array = the_data.Split('\n');
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbDisplayStuff.Clear();
            ofdLoadText.ShowDialog();
            rtbDisplayStuff.LoadFile(ofdLoadText.FileName);
            string the_data = rtbDisplayStuff.Text;
            my_Array = the_data.Split('\n');
        }
    }
}
