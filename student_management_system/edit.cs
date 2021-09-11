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
        }
        SqlConnection sql = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");

        private void edit_Load(object sender, EventArgs e)
        {

        }

        private void btndone_Click(object sender, EventArgs e)
        {
            //sql.Open();
            //string qry = "update students set studentname = '" + nametxt.Text + "',contactno='"+contacttxt.Text+"',email = '"+emailtxt.Text+"',college='"+collegetxt.Text+"',course = '"+coursetxt.Text+"',fees='"+feestxt.Text+"',feespaid = '"+feespaidtxt.Text+"',feesrem = '"+feesremtxt.Text+"',teacher='"+teachertxt.Text+"' where id ='"+idtxt.Text+"'"
            //    ;             
            //SqlCommand cmd = new SqlCommand(qry, sql);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("RECORD UPDATED", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //sql.Close();
            //ADMIN ad = new ADMIN();
            //ad.fetchstudents();
        }

        private void feespaidtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
