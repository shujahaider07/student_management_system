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
    public partial class editteacher : Form
    {
        public editteacher()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");

        private void editteacher_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btndone_Click(object sender, EventArgs e)
        {
            ErrorProvider er = new ErrorProvider();
            if (nametxt.Text == "")
            {
                er.SetError(nametxt, "fill");
            }
            else if (qualitxt.Text == "")
            {
                er.SetError(qualitxt, "fill");
            }
            else if (subjecttxt.Text == "")
            {
                er.SetError(subjecttxt, "fill");
            }
            else
            {
                try
                {
                    sql.Open();
                    string qry = "update teacher set teachername= '" + nametxt.Text + "', qualification = '" + qualitxt.Text + "',subjectt = '" + subjecttxt.Text + "' where id ='" + idtxt.Text + "'";

                    SqlCommand cmd = new SqlCommand(qry, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("RECORD UPDATED!");
                    idtxt.Text = "";
                    nametxt.Text = "";
                    qualitxt.Text = "";
                    subjecttxt.Text = "";

                    sql.Close();
                }
                catch (Exception)
                {
                }
            }


        }
    }
}