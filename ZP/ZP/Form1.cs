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

namespace ZP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source = 303-13; Initial Catalog = Practica_3; Integrated Security=true;");
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             conn.Open();
            SqlCommand com = new SqlCommand($"SELECT Login_manager FROM [login-manager] where Login_manager = '{textBox1.Text}' and password = '{textBox2.Text}' UNION SELECT [Логин_исполнителя] FROM [dbo].[Ispoln] where [Логин_исполнителя] = '{textBox1.Text}' and password = '{textBox2.Text}'",conn);
            SqlDataReader dr = com.ExecuteReader();

            if(dr.HasRows)
            {
                this.Hide();
                Form2 form = new Form2();
                form.Show();
                conn.Close();
                dr.Close();
            }
            else
            {
                conn.Close();
                dr.Close();
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
