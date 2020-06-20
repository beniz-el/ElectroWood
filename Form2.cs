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
    public partial class Form2 : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("ElectroWood");
        static IMongoCollection<Materiels> collection = db.GetCollection<Materiels>("Materiels");
        public Form2()
        {
            InitializeComponent();
        }

        public void ReadAllDocuments()
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Materiels> list = collection.AsQueryable().ToList<Materiels>();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
