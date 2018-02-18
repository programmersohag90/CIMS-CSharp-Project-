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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddInfo objmain = new AddInfo();
            this.Hide();
            objmain.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnallcust_Click(object sender, EventArgs e)
        {
            view objmain = new view();
            this.Hide();
            objmain.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateInfo objmain = new UpdateInfo();
            this.Hide();
            objmain.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deleteinfo objmain = new Deleteinfo();
            this.Hide();
            objmain.Show();
        }

        private void cryrptbtn_Click(object sender, EventArgs e)
        {
            crystal objmain = new crystal();
            this.Hide();
            objmain.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search objmain = new Search();
            this.Hide();
            objmain.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
