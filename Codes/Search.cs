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
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApplication3
{
    public partial class Search : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SL358TR\SQLEXPRESS;Initial Catalog=CIMS_DB;Integrated Security=True;Pooling=False");

        public Search()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "SELECT * FROM add_DB where ID = '" + idtxt.Text + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlcon.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmMain objmain = new frmMain();
            this.Hide();
            objmain.Show();
        }

        private void search_Load(object sender, EventArgs e)
        {

        }
    }
}
