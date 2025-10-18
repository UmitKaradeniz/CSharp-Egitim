using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Egitim.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        Entities2 db = new Entities2();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(numCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.DayNight = txtDayNight.Text;
            location.Price = decimal.Parse(textPrice.Text);
            location.GuideId = int.Parse(comboContacs.SelectedValue.ToString());
           
            db.Location.Add(location);
            db.SaveChanges();

            MessageBox.Show("Lokasyon Ekleme başarılı.");
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var delete = db.Location.Find(id);
            db.Location.Remove(delete);
            db.SaveChanges();   
            MessageBox.Show("Lokasyon Silme başarılı.");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var update = db.Location.Find(id);
            update.DayNight = txtDayNight.Text;
            update.Capacity = byte.Parse(numCapacity.Value.ToString());
            update.City = txtCity.Text;
            update.Country = txtCountry.Text;
            update.Price = decimal.Parse(textPrice.Text);
            update.GuideId = int.Parse(comboContacs.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Lokasyon Güncelleme başarılı.");

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            comboContacs.DisplayMember = "FullName";
            comboContacs.ValueMember = "GuideId";
            comboContacs.DataSource = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId

            }).ToList();
        }

        private void textDayNight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
