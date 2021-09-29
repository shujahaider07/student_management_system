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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            usertxt.KeyUp += Usertxt_KeyUp;
            passwordtxt.KeyUp += Passwordtxt_KeyUp;
        }

        private void Passwordtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                loginbtn.Focus();
            }
        }

        private void Usertxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordtxt.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
    }

        private void loginbtn_Click(object sender, EventArgs e)
        {
           db.con.Open();
            String qry = "select * from userinfo where username = @User and Passwordd = @pass";
            SqlCommand cmd = new SqlCommand(qry,db.con);
            cmd.Parameters.AddWithValue("@User", usertxt.Text);
            cmd.Parameters.AddWithValue("@Pass", passwordtxt.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("LOGIN SUCCESSFULL");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();

            }
            else
            {
                infolbl.Visible = true;
            }


          db.con.Close();



        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            passwordtxt.PasswordChar = '●';

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
