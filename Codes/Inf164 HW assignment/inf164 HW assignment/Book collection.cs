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
    public partial class Book_collection : Form
    {
        public Book_collection()
        {
            InitializeComponent();
        }


        BindingList<Tamagotchi> Bookings = new BindingList<Tamagotchi>();
        private void editCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedindexRow = dataGridView1.CurrentCell.RowIndex;
            Tamagotchi Editing2 = Bookings[selectedindexRow];

            Edit_collection myform = new Edit_collection();

            myform.BookingEdit = Editing2;

            myform.ShowDialog();
            Bookings[selectedindexRow] = myform.BookingEdit;
        }

        private void returnHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Hide();
            var Home = new Home();
            Home.FormClosed += (s, args) => this.Close();
            Home.Show();
            //this.Close();
        }

        private void Book_collection_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bookings;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tamagotchi User = new Tamagotchi();
            User.Name = txtTitle.Text;
            User.Author = txtAuthor.Text;
            User.Genre = cbxGenre.Text;
            User.Date = cbxdateTimePicker1.Value;
            User.Cost = Convert.ToDouble(txtCost.Text);
            Bookings.Add(User);

        }

        private void refundABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedindexRow = dataGridView1.CurrentCell.RowIndex;
            Tamagotchi productstoDelete = Bookings[selectedindexRow];
            Bookings.Remove(productstoDelete);
            MessageBox.Show(Convert.ToString(txtTitle.Text) + " has been refunded and removed");

        }

        private void numberOfBooksPerGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int comedy = 0;
            int Action = 0;
            int Adventure = 0;
            int Romance = 0;
            int Fantasy = 0;
            int Total = 0;
           
            dataGridView1.Refresh();
             for ( int i=0; i< dataGridView1.Rows.Count;i++)
            {
                if(Convert.ToString(dataGridView1.Rows[i].Cells[2].Value)=="Comedy")
                {
                   comedy += 1;
                }
               else if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Action") 
                {
                   Action += 1;
                }
               else if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Romance")
                {
                    Romance += 1;
                }
                else if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Fantasy")
                {
                    Fantasy += 1;
                }
                else if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Adventure")
                {
                    Adventure += 1;
                }
                Total = comedy + Action + Romance + Fantasy + Adventure;

            } 
                MessageBox.Show(Convert.ToString("Collection Statistics"+"\n"+"\n"+ "There are"+" "+ comedy+" "+ "Comedy Books"+ "\n" + "There are"+" "+ Action+" " +"Action Books"+"\n "+"There are"+" "+Romance+" "+" Romance books"+"\n"+" There are" +" "+Fantasy+ " Fantasy Books" +" \n"+ " There are" +" "+ Adventure+" " +"Adventure Books"+"\n"+"\n"+ "Total Number of Books in Collection: "+" "+ Total ));
             
        }
    }
}
