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
    public partial class Form6 : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("ElectroWood");
        static IMongoCollection<profs> collection = db.GetCollection<profs>("Profs");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            List<profs> list = collection.AsQueryable().ToList<profs>();
            dataGridView1.DataSource = list;

        }
    }
}
