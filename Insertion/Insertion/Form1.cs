using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Insertion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = NameTB.Text;
            string code = CodeTB.Text;

            string connectionString = @"Server=DESKTOP-V9FTOHK\SQLEXPRESS;Database=course;User Id=sa;Password=12345;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = string.Format("insert into course values('{0}','{1}')", name, code);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Data inserted");
            }
            else
            {
                MessageBox.Show("Cannot inserted");
            }
        }

        private void CodeTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
