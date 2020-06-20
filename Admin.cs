using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace test
{
    public partial class Admin : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("ElectroWood");
        static IMongoCollection<Materiels> collection = db.GetCollection<Materiels>("Materiels");
      

        public void ReadAllDocuments()
        {
            List<Materiels> list = collection.AsQueryable().ToList<Materiels>();
            dataGridView3.DataSource = list;
            textBox1.Text = dataGridView3.Rows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView3.Rows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView3.Rows[0].Cells[1].Value.ToString();
        }
        public Admin()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nom = textBox2.Text;
            string description = textBox3.Text;
            MongoCRUD db = new MongoCRUD("ElectroWood");
            db.InsertRecord("Materiels", new Materiels {Id = id, Nom = nom , Description=description });
            ReadAllDocuments();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<Materiels>.Update.Set("Id", textBox1.Text).Set("Nom", textBox2.Text).Set("Description", textBox3.Text);
            collection.UpdateOne(s => s.Id == textBox1.Text, updateDef);
            ReadAllDocuments();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(s => s.Id == textBox1.Text);
            ReadAllDocuments();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
        }
    }
}
