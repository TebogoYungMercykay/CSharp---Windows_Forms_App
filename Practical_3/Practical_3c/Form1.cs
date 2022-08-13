using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_3c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculateSemesterMark_Click(object sender, EventArgs e)
        {
            if(txtClassTest.Text!="" && txtHomeworkAssignments.Text!="" && txtQuiz.Text!="" && txtRevisionTests.Text!="" && txtSemesterAve.Text!="" && txtSemesterTest.Text != "")
            {
                int rTest, Quiz, hAssignments, cTest, sTest;
                rTest = ((Convert.ToInt32(txtRevisionTests.Text))*15)/100;
                Quiz = ((Convert.ToInt32(txtQuiz.Text))*1)/100;
                hAssignments = ((Convert.ToInt32(txtHomeworkAssignments.Text))*14)/100;
                cTest = ((Convert.ToInt32(txtClassTest.Text))*20)/100;
                sTest = ((Convert.ToInt32(txtSemesterTest.Text))*50)/100;

                int k = rTest + Quiz + hAssignments + cTest + sTest;
                txtSemesterAve.Text = Convert.ToString(k);
            }
        }
    }
}
