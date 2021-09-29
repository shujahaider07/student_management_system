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
    public partial class frmaddcourse : Form
    {
        public frmaddcourse()
        {
            InitializeComponent();
            cnametxt.KeyUp += Cnametxt_KeyUp;
            cfeestxt.KeyUp += Cfeestxt_KeyUp;
            durationtxt.KeyUp += Durationtxt_KeyUp;
            cfeestxt.KeyPress += Cfeestxt_KeyPress;
                }

        private void Cfeestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
                label1.Visible = false;
            }

            else if (char.IsLetter(e.KeyChar))
            {
                label1.Visible = true;

            }
           
            
            e.Handled = true;
        }

        private void Durationtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button15.Focus();
            }
        }

        private void Cfeestxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                durationtxt.Focus();
            }
        }

        private void Cnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cfeestxt.Focus();
            }
        }

        SqlConnection sql = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");

        private void button15_Click(object sender, EventArgs e)
        {

            sql.Open();
            SqlCommand cmdd = new SqlCommand("Select coursename from course where coursename = '" + cnametxt.Text + "'", sql);
            SqlDataReader dr = cmdd.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("record already exists");

            }
            if (cnametxt.Text == "")
            {
                MessageBox.Show("fill properly");
            }
            else if (cfeestxt.Text == "")
            {
                MessageBox.Show("fill properly");
            }
            else if (durationtxt.Text == "")
            {
                MessageBox.Show("fill properly");
            }
            else
            {
                try {
                    db.con.Open();
                    string qry = "insert into course(coursename,coursefees,duration)values('" + cnametxt.Text + "','" + cfeestxt.Text + "','" + durationtxt.Text + "')";
                    SqlCommand cmd = new SqlCommand(qry, db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("COURSE ADDED");
                    db.con.Close();

                    cnametxt.Text = "";
                    cfeestxt.Text = "";
                    durationtxt.Text = "";

                }
                catch(Exception)
                {

                }
                }
            
            sql.Close();
                     
            //courses();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmcourses f = new frmcourses();
            f.Show();
        }

        private void frmaddcourse_Load(object sender, EventArgs e)
        {

        }

        private void cfeestxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
