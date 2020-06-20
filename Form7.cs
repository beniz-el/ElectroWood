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
    public partial class Form7 : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("ElectroWood");
        static IMongoCollection<Reservation> collection1 = db.GetCollection<Reservation>("Reservation");
        public Form7()
        {
            InitializeComponent();
            List<Reservation> list1 = collection1.AsQueryable().ToList<Reservation>();
            dataGridView1.DataSource = list1;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
