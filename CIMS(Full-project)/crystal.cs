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
    public partial class crystal : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SL358TR\SQLEXPRESS;Initial Catalog=CIMS_DB;Integrated Security=True;Pooling=False");

        public crystal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "SELECT * FROM add_DB where id =  '" + idtxt.Text + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataSet dt = new DataSet();
            SDA.Fill(dt, "add_DB");
            cryrpt.Load(@"C:\Users\MjK\Documents\Visual Studio 2010\Projects\CMS\WindowsFormsApplication3\CrystalReport2.rpt");
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = (cryrpt);
            sqlcon.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmMain objmain = new frmMain();
            this.Hide();
            objmain.Show();
        }

        private void showallbtn_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "SELECT * FROM add_DB";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataSet dt = new DataSet();
            SDA.Fill(dt, "add_DB");
            cryrpt.Load(@"C:\Users\MjK\Documents\Visual Studio 2010\Projects\CMS\WindowsFormsApplication3\CrystalReport2.rpt");
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = (cryrpt);
            sqlcon.Close();
        }

        private void crystal_Load(object sender, EventArgs e)
        {
        }
    }
}
