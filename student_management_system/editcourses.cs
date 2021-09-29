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
    public partial class editcourses : Form
    {
        public editcourses()
        {
            InitializeComponent();
        }

        private void editcourses_Load(object sender, EventArgs e)
        {

        }
        SqlConnection sql = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");
        private void btndone_Click(object sender, EventArgs e)
        {
            ErrorProvider er = new ErrorProvider();
            if (coursetxt.Text == "")
            {
                er.SetError(coursetxt, "fill");
            }
            else if (cfeestxt.Text == "")
            {
                er.SetError(cfeestxt, "fill");
            }
            else if (durationtxt.Text == "")
            {
                er.SetError(durationtxt, "fill");
            }
            else
            {
                try
                {
                    sql.Open();
                    string qry = "update course set coursename= '" + coursetxt.Text + "', coursefees = '" + cfeestxt.Text + "',duration = '" + durationtxt.Text + "' where cid ='" + idtxt.Text + "'";

                    SqlCommand cmd = new SqlCommand(qry, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("RECORD UPDATED!");
                    idtxt.Text = "";
                   coursetxt.Text = "";
                    cfeestxt.Text = "";
                    durationtxt.Text = "";

                    sql.Close();
                }
                catch (Exception)
                {
                }
            }

        }
    }
}
