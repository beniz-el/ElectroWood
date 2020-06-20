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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pseudo = textBox1.Text;
            string password = textBox2.Text;
            if (pseudo == "admin" && password == "admin") {
                Admin con = new Admin();
                con.Show();
            }
            else
            {
                MessageBox.Show("Pseudo ou password incorrect ");

                return;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
