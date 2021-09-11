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

namespace student_management_system
{
    public partial class frmaddteacher : Form
    {
        public frmaddteacher()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");
        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                //feessearchtxt.Items.Clear();
                sql.Open();
                string qry = "insert into teacher values('" + tnametxt.Text + "','" + tqualitxt.Text + "','" + subjectxt.Text + "')";
                SqlCommand cmd = new SqlCommand(qry, sql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ADDED!");

                tnametxt.Text = "";
                tqualitxt.Text = "";
                subjectxt.Text = "";

                sql.Close();
                //fetchteacher();
                //countall();
               // teacher();
            }
            catch (Exception)
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmteachers t = new frmteachers();
            t.Show();
        }
    }
}
