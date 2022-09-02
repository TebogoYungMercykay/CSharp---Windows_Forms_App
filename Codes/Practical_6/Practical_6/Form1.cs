using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Global
        {
            public static int Tables;
            public static int Printing = 1;
        }

        private void btnShowTables_Click(object sender, EventArgs e)
        {
            rtbShowTable.Text = "";
            Global.Tables = Convert.ToInt32(txtTables.Text);
            while(Global.Tables > 0)
            {
                rtbShowTable.Text += "Multiplication table for " + Global.Tables + "\n";
                rtbShowTable.Text += "....................................." + "\n";
                while (Global.Printing <= 4)
                {
                    rtbShowTable.Text += Global.Printing + " X " + Global.Tables + " = " + Global.Printing * Global.Tables + "\n";
                    Global.Printing += 1;
                }
                rtbShowTable.Text += "\n";
                Global.Tables -= 1;
                Global.Printing = 1;
            }  
        }
    }
}
