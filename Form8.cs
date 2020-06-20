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
    public partial class Form8 : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("ElectroWood");
        static IMongoCollection<Projet> collection2 = db.GetCollection<Projet>("ProjetPro");
        public Form8()
        {
            InitializeComponent();
            List<Projet> list2 = collection2.AsQueryable().ToList<Projet>();
            dataGridView1.DataSource = list2;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
