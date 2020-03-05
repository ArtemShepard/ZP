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

        }
    }
}
