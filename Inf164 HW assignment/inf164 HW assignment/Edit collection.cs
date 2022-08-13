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
    public partial class Edit_collection : Form
    {
        public Edit_collection()
        {
            InitializeComponent();
        }
        public Tamagotchi BookingEdit;
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            BookingEdit.Name = txtTitle.Text;
            BookingEdit.Author = txtAuthor.Text;
            BookingEdit.Date = dateTimePicker1.Value;
            BookingEdit.Genre = Convert.ToString(cbxGenre.Text);
            BookingEdit.Cost = Convert.ToDouble(txtCost.Text);
            this.Close();

        }

        private void Edit_collection_Load(object sender, EventArgs e)
        {
           txtTitle.Text = BookingEdit.Name;
            txtAuthor.Text = BookingEdit.Author;
            dateTimePicker1.Value = BookingEdit.Date;
            cbxGenre.Text = Convert.ToString( BookingEdit.Genre);
            txtCost.Text = Convert.ToString(BookingEdit.Cost);
        }
    }
}
