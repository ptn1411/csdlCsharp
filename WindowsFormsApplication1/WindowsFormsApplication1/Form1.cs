using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;  
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection _connection;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
        
            string _connectionString = "server= " + textBox1.Text + ";database=" + textBox2.Text + ";integrated security=true";


            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;" + "Data Source=" + Application.StartupPath + "\\test.accdb");
  
             conn.Open();
 

            _connection = new SqlConnection();
            try
            {
                if (radioButton1.Checked == true)
                {
                    _connection.ConnectionString = _connectionString;
                }
                else
                {
                    _connectionString = "server= " + textBox1.Text + ";database=" + textBox2.Text + ";uid=" + textBox3.Text + ";pwd=" + textBox4.Text;
                    _connection.ConnectionString = _connectionString;
                }
                _connection.Open();
                MessageBox.Show("Connection Success");
                _connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("erro");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
