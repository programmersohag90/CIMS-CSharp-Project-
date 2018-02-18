using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class view : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SL358TR\SQLEXPRESS;Initial Catalog=CIMS_DB;Integrated Security=True;Pooling=False");

        public view()
        {
            InitializeComponent();
            sqlcon.Open();
            string query = "SELECT * FROM add_DB";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlcon.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMain objmain = new frmMain();
            this.Hide();
            objmain.Show();
        }
    }
}
