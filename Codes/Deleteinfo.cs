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
    public partial class Deleteinfo : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SL358TR\SQLEXPRESS;Initial Catalog=CIMS_DB;Integrated Security=True;Pooling=False");

        public Deleteinfo()
        {
            InitializeComponent();

            sqlcon.Open();
            string query = "SELECT * FROM add_DB";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView.DataSource = dt;
            sqlcon.Close();
        }

        

        private void btnexit_Click(object sender, EventArgs e)
        {
            frmMain objmain = new frmMain();
            this.Hide();
            objmain.Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {

            String DelID = delID.Text;
            sqlcon.Open();
            String qry = "DELETE FROM Add_DB WHERE ID = '" + DelID + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(qry, sqlcon);
            SDA.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Recoard Successfully Deleted");

            sqlcon.Open();
            string query = "SELECT * FROM add_DB";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            SDA1.Fill(dt);
            dataGridView.DataSource = dt;
            sqlcon.Close();
            
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            delID.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void Deleteinfo_Load(object sender, EventArgs e)
        {

        }

    }
}
