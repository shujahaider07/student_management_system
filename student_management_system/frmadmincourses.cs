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
    public partial class frmadmincourses : Form
    {
        public frmadmincourses()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fetchcourses() {

            sql.Open();
            string qry = "select cid ,coursename,coursefees,duration from course where status is null";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;


            sql.Close();
        }

        public void style()
        {

            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans serif", 10);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }
        private void frmadmincourses_Load(object sender, EventArgs e)
        {
            style();
            fetchcourses();
            links();

        }
        public void links()
        {
            //Edit link

            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Edit";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            Editlink.Name = "Edit";
            dataGridView2.Columns.Add(Editlink);

            //Delete link

            //Delete link
            DataGridViewLinkColumn Delete = new DataGridViewLinkColumn();
            Delete.UseColumnTextForLinkValue = true;
            Delete.HeaderText = "Delete";
            Delete.DataPropertyName = "Delete";
            Delete.LinkBehavior = LinkBehavior.SystemDefault;
            Delete.Text = "Delete";
            Delete.Name = "Delete";
            dataGridView2.Columns.Add(Delete);


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Edit"].Index)
            {
                editcourses co = new editcourses();
                co.Show();
               co.idtxt.Text = dataGridView2.CurrentRow.Cells["cid"].Value.ToString();
                co.coursetxt.Text = dataGridView2.CurrentRow.Cells["coursename"].Value.ToString();
                co.cfeestxt.Text = dataGridView2.CurrentRow.Cells["coursefees"].Value.ToString();
                co.durationtxt.Text = dataGridView2.CurrentRow.Cells["duration"].Value.ToString();


            }
            else if (e.ColumnIndex == dataGridView2.Columns["Delete"].Index)
            {
                sql.Open();
                DialogResult result = MessageBox.Show("Are you sure you want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string qry = "update course set status=0 where cid = '" + dataGridView2.CurrentRow.Cells["cid"].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(qry, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record deleted");


                }
                sql.Close();
                fetchcourses();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            fetchcourses();
        }

        private void stdsearchtxt_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select cid,coursename,coursefees,duration from course where status is null and coursename like '%" + stdsearchtxt.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            sql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmcourses f = new frmcourses();
            f.ShowDialog();

        }
    }
}
