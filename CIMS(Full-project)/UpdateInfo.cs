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
    public partial class UpdateInfo : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SL358TR\SQLEXPRESS;Initial Catalog=CIMS_DB;Integrated Security=True;Pooling=False");

        public UpdateInfo()
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.txtfirst.Text = "";
            this.txtlast.Text = "";
            this.txtphone.Text = "";
            this.txtemail.Text = "";
            this.txtroad.Text = "";
            this.txthouse.Text = "";
            this.txtmadd.Text = "";
            this.txtmadd2.Text = "";
            cbgen.SelectedIndex = 0;

            sqlcon.Close();
        }

        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idbox.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtfirst.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtlast.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtphone.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtemail.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();

            cbgen.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();

            txtroad.Text = dataGridView.SelectedRows[0].Cells[6].Value.ToString();
            txthouse.Text = dataGridView.SelectedRows[0].Cells[7].Value.ToString();
            txtmadd.Text = dataGridView.SelectedRows[0].Cells[8].Value.ToString();
            txtmadd2.Text = dataGridView.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            String ID = idbox.Text;
            String fname = txtfirst.Text;
            String lname = txtlast.Text;

            String phone = txtphone.Text;

            String email = txtemail.Text;
            String gender = cbgen.SelectedItem.ToString();

            String road = txtroad.Text;
            int roadno = Int32.Parse(road);

            String house = txthouse.Text;
            int houseno = Int32.Parse(house);

            String mailAdd = txtmadd.Text;
            String mailAdd2 = txtmadd2.Text;




            //MessageBox.Show("Name: "+fname+" "+lname+", Phone: "+iphone+"");

            String qry = "UPDATE add_DB SET First_Name = '" + fname + "', Last_Name = '" + lname + "', Phone = '" + phone + "', Email = '" + email + "', Gender = '" + gender + "', Road_No = " + roadno + ", House_No = " + houseno + ", Mailing_Address1 = '" + mailAdd + "',  Mailing_Address2 = '" + mailAdd2 + "' WHERE  ID = '" + ID + "' ";

            //String qry = "UPDATE add_DB SET First_name = '" + fname + "', Email = '" + email + "' WHERE  ID = '" + ID + "' ";


            SqlDataAdapter SDA = new SqlDataAdapter(qry, sqlcon);

            SDA.SelectCommand.ExecuteNonQuery();

            sqlcon.Close();

            MessageBox.Show("Recoard Successfully Updated");

            sqlcon.Open();
            string query = "SELECT * FROM add_DB";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            SDA1.Fill(dt);
            dataGridView.DataSource = dt;
            sqlcon.Close();
        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {

        }

    }
}
