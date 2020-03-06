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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         
        SqlConnection conn = new SqlConnection("Data Source = 303-13; Initial Catalog = Practica_3; Integrated Security=true;");

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand com = new SqlCommand($"SELECT id FROM grade", conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read()) {
                comboBox1.Items.Add(dr[0]);
            }
           
            
            conn.Close();
            dr.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
