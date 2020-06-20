using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace test
{
    public partial class Administration : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("ElectroWood");
        static IMongoCollection<Projet> collection = db.GetCollection<Projet>("ProjetPro");
        static IMongoCollection<profs> collection1 = db.GetCollection<profs>("Profs");

        public void ReadAllDocuments1()
        {
            
            List<Projet> list = collection.AsQueryable().ToList<Projet>();
            List<profs> list1 = collection1.AsQueryable().ToList<profs>();
            dataGridView1.DataSource = list;
            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textBox10.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            dataGridView2.DataSource = list1;
          

        }
        public void ReadAllDocuments2()
        {

            List<Projet> list = collection.AsQueryable().ToList<Projet>();
            List<profs> list1 = collection1.AsQueryable().ToList<profs>();
            dataGridView1.DataSource = list;
            dataGridView2.DataSource = list1;
            textBox8.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
            textBox4.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
            textBox5.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
            textBox6.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
            textBox7.Text = dataGridView2.Rows[0].Cells[4].Value.ToString();
            textBox9.Text = dataGridView2.Rows[0].Cells[5].Value.ToString();


        }
        public Administration()
        {
            InitializeComponent();
            ReadAllDocuments1();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox10.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string nom = textBox2.Text;
            string cinprof = comboBox1.Text;
            string filiere = textBox3.Text;
            string groupe = textBox10.Text;
            MongoCRUD db = new MongoCRUD("ElectroWood");
            db.InsertRecord("ProjetPro", new Projet {  Nom = nom, Filiere = filiere, CIN_prof = cinprof,  Groupe = groupe });
            ReadAllDocuments1();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<Projet>.Update.Set("Nom", textBox2.Text).Set("Cin_prof", comboBox1.Text).Set("Filiere", textBox3.Text).Set("Groupe", textBox10.Text);
            collection.UpdateOne(s => s.Id == ObjectId.Parse(textBox1.Text), updateDef);
            ReadAllDocuments1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(s => s.Id == ObjectId.Parse(textBox1.Text));
            ReadAllDocuments1();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cin = textBox4.Text;
            string nom = textBox5.Text;
            string prenom = textBox6.Text;
            string filiere = textBox7.Text;
            string email = textBox9.Text;
            MongoCRUD db = new MongoCRUD("ElectroWood");
            db.InsertRecord("Profs", new profs { CIN = cin, Nom = nom, Prenom = prenom, Filiere = filiere,  Email=email});
            ReadAllDocuments2();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox7.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox9.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<profs>.Update.Set("CIN", textBox4.Text).Set("Nom", textBox5.Text).Set("Prenom", textBox6.Text).Set("Filiere", textBox7.Text).Set("Email", textBox9.Text);
            collection1.UpdateOne(s => s.Id == ObjectId.Parse(textBox8.Text), updateDef);
            ReadAllDocuments2();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            collection1.DeleteOne(s => s.Id == ObjectId.Parse(textBox8.Text));
            ReadAllDocuments2();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////foreach (int x in dataGridView2.Rows) {
            ////    comboBox1.Items.Add(dataGridView2.Rows[x].Cells[1].Value.ToString());
            ////} 
            //List<profs> list1 = collection1.AsQueryable().ToList<profs>();
            //for (int i=0; i<list1.Count; i++)
            //{
            //    comboBox1.Items.Add(list1[i]);
            //}
        }
    }
}
