using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Egitim.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Entities2 db = new Entities2();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guide g = new Guide();
            g.GuideName=txtName.Text;
            g.GuideSurname = txtSurname.Text;
            db.Guide.Add(g);
            db.SaveChanges();
            MessageBox.Show("Kayıt Eklendi");
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values= db.Guide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse (txtId.Text);
            var value = db.Guide.Find(id);
            db.Guide.Remove(value);
            db.SaveChanges();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Kayıt Güncellendi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);


        }
    }
}
