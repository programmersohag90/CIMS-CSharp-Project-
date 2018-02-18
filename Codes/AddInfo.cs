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
    public partial class AddInfo : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SL358TR\SQLEXPRESS;Initial Catalog=CIMS_DB;Integrated Security=True;Pooling=False");

        public AddInfo()
        {
            InitializeComponent();
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                //sqlcon.Close();
                sqlcon.Open();

                String fname = txtfirst.Text.ToString();
                String lname = txtlast.Text.ToString();

                String phone = txtphone.Text.ToString();

                String email = txtemail.Text.ToString();
                String gender = cbgen.SelectedItem.ToString();

                String road = txtroad.Text.ToString();
                int roadno = Int32.Parse(road);

                String house = txthouse.Text.ToString();
                int houseno = Int32.Parse(house);

                String mailAdd = txtmadd.Text.ToString();
                String mailAdd2 = txtmadd2.Text.ToString();




                //MessageBox.Show("Name: "+fname+" "+lname+", Phone: "+iphone+"");

                String qry = "insert into add_DB values('" + fname + "','" + lname + "'," + phone + ",'" + email + "','" + gender + "'," + roadno + "," + houseno + ",'" + mailAdd + "','" + mailAdd2 + "')";

                SqlDataAdapter sc = new SqlDataAdapter(qry, sqlcon);

                int i =sc.SelectCommand.ExecuteNonQuery();
                    

                if(i>=1)
                    MessageBox.Show("Recoard added successfully");
                else
                    MessageBox.Show("Recoard is not added");


                button1_Click_1(sender, e);
                sqlcon.Close();

            }
            catch(System.Exception)
            {
                MessageBox.Show("Please fill all the information!");
            }
            

        }

        private void AddInfo_Load(object sender, EventArgs e)
        {
        }
    }
}
