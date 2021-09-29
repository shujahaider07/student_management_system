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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
            ADDFEESTXT.KeyPress += ADDFEESTXT_KeyPress;
            ADDFEESTXT.TextChanged += ADDFEESTXT_TextChanged;
        }

        private void ADDFEESTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ADDFEESTXT.Text) > Convert.ToInt32(feestxt.Text))
                {
                    MessageBox.Show("out of bound");
                    ADDFEESTXT.Text = "";
                    feesremtxt.Text = "";
                }

                feespaidtxt.Text = ADDFEESTXT.Text;
                int total = Convert.ToInt32(feestxt.Text) - Convert.ToInt32(feespaidtxt.Text);
                feesremtxt.Text = total.ToString();

            }
            catch (Exception)
            {
            }
        
    }

        private void ADDFEESTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;

            }
            e.Handled = true;
        }

        SqlConnection sql = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");

        private void edit_Load(object sender, EventArgs e)
        {

        }

        private void btndone_Click(object sender, EventArgs e)
        {
            ErrorProvider er = new ErrorProvider();

            if (idtxt.Text == "")
            {
                er.SetError(idtxt, "fill");
            }
            else if (nametxt.Text == "")
            {
                er.SetError(nametxt, "fill");
            }
            else if (contacttxt.Text == "")
            {
                er.SetError(contacttxt, "fill");
            }
            else if (emailtxt.Text == "")
            {
                er.SetError(emailtxt, "fill");
            }
            else if (collegetxt.Text == "")
            {
                er.SetError(collegetxt, "fill");
            }
            else if (coursetxt.Text == "")
            {
                er.SetError(coursetxt, "fill");
            }
            else if (teachertxt.Text == "")
            {
                er.SetError(teachertxt, "fill");
            }
            else if (feestxt.Text == "")
            {
                er.SetError(feestxt, "fill");
            }
            else if (feespaidtxt.Text == "")
            {
                er.SetError(feespaidtxt, "fill");
            }
            else if (feesremtxt.Text == "")
            {
                er.SetError(feesremtxt, "fill");
            }
           
            else
            {



                try
                {
                    sql.Open();
                    string qry = "update students set studentname = '" + nametxt.Text + "',contactno='" + contacttxt.Text + "',email = '" + emailtxt.Text + "',college='" + collegetxt.Text + "',course = '" + coursetxt.Text + "',fees='" + feestxt.Text + "',feespaid = '" + feespaidtxt.Text + "',feesrem = '" + feesremtxt.Text + "',teacher='" + teachertxt.Text + "' where id ='" + idtxt.Text + "'"
                        ;
                    SqlCommand cmd = new SqlCommand(qry, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("RECORD UPDATED", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sql.Close();


                    idtxt.Text = "";
                    nametxt.Text = "";
                    contacttxt.Text = "";
                    emailtxt.Text = "";
                    collegetxt.Text = "";
                    coursetxt.Text = "";
                    feestxt.Text = "";
                    feespaidtxt.Text = "";
                    feesremtxt.Text = "";
                    teachertxt.Text = "";
                    ADDFEESTXT.Text = "";

                }

                catch (Exception)
                {
                }
            }



        }

        private void feespaidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
