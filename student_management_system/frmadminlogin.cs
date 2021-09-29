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
    public partial class frmadminlogin : Form
    {
        public frmadminlogin()
        {
            InitializeComponent();
            aduser.KeyUp += Aduser_KeyUp;
            adpass.KeyUp += Adpass_KeyUp;
        }

        private void Adpass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              loginbtn.Focus();

            }
        }

        private void Aduser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adpass.Focus();
            }
        }

        SqlConnection sql = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");

        private void loginbtn_Click(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select * from admintrator where aduser = @User and adpassword = @Pass";
            SqlCommand cmd = new SqlCommand(qry, sql);
            cmd.Parameters.AddWithValue("@User", aduser.Text);
            cmd.Parameters.AddWithValue("@Pass", adpass.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == true)
            {
                MessageBox.Show("Login Administrator form");
                ADMIN a = new ADMIN();
                this.Hide();
                a.ShowDialog();
               
                aduser.Text = "";
                adpass.Text = "";
               

            }
            else
            {
                MessageBox.Show("Failed");
            }

           sql.Close();

        }

        private void adpass_TextChanged(object sender, EventArgs e)
        {
            adpass.PasswordChar = '●';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmadminlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
