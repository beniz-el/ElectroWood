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
    public partial class Form5 : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("ElectroWood");
        static IMongoCollection<Projet> collection = db.GetCollection<Projet>("ProjetPro");
        static IMongoCollection<Reservation> collection1 = db.GetCollection<Reservation>("Reservation");

        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string datedeb = textBox1.Text;
            string datefin = textBox2.Text;
            string cinprof = comboBox1.Text;
            string groupe = textBox3.Text;
            string projetpro = textBox4.Text;
            string projetpers = textBox5.Text;
            string existdate = collection1.AsQueryable().Any(d => d.Date_debut == datedeb).ToString();
            if (existdate == "True")
            {
                MessageBox.Show("L'atelier est déjà réservé à cette date ");

                return;
            }
            else
            {
                string existnom = collection.AsQueryable().Any(p => p.Nom == projetpro).ToString();
                if (existnom == "True" || textBox5.Text != "")
                {
                    if (existnom == "True")
                    {
                        MongoCRUD db = new MongoCRUD("ElectroWood");
                        db.InsertRecord("Reservation", new Reservation { Date_debut = datedeb , Date_fin = datefin, CIN_prof = cinprof, Groupe = groupe,  Projet = projetpro });
                        MessageBox.Show("Votre reservation est effectuee");
                        return;
                    }
                    if(textBox5.Text != "")
                    {
                        MongoCRUD db = new MongoCRUD("ElectroWood");
                        db.InsertRecord("Reservation", new Reservation { Date_debut = datedeb, Date_fin = datefin, CIN_prof = cinprof, Groupe = groupe, Projet = projetpers });

                        db.InsertRecord("ProjetPers", new ProjetPers { Nom = projetpers, CIN_prof = cinprof, Groupe = groupe });
                        MessageBox.Show("Votre reservation est effectuee");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Ce projet professionnel n'existe pas");
                    return;
                }
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }
    }
}
