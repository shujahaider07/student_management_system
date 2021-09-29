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
            tnametxt.KeyUp += Tnametxt_KeyUp;
            tqualitxt.KeyUp += Tqualitxt_KeyUp;
            subjectxt.KeyUp += Subjectxt_KeyUp;
        }

        private void Subjectxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button19.Focus();
            }
        }

        private void Tqualitxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               subjectxt.Focus();
            }
        }
        private void Tnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                tqualitxt.Focus();
            
            }
        }

        SqlConnection sql = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");
        private void button19_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmteachers t = new frmteachers();
            t.Show();
        }

        private void frmaddteacher_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            if (tnametxt.Text == "")
            {
                MessageBox.Show("fill properly");
            }
            else if (tqualitxt.Text == "")
            {
                MessageBox.Show("fill properly");
            }
            else if (subjectxt.Text == "")
            {
                MessageBox.Show("fill properly");
            }
            else
            {

                try
                {
                    //feessearchtxt.Items.Clear();
                    sql.Open();
                    string qry = "insert into teacher (teachername,qualification,subjectt)values('" + tnametxt.Text + "','" + tqualitxt.Text + "','" + subjectxt.Text + "')";
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
        }
    }
}
