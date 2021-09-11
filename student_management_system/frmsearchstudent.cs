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
    public partial class frmsearchstudent : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");
        public frmsearchstudent()
        {
            InitializeComponent();
            yearstxt.TextChanged += Yearstxt_TextChanged;
            coursesearchtxt.TextChanged += Coursesearchtxt_TextChanged;
            teachersearchtxt.TextChanged += Teachersearchtxt_TextChanged;
        }
        public void styleGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans serif", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        private void Teachersearchtxt_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select * from students where teacher = '" + teachersearchtxt.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Close();
           // count();
        }

        private void Coursesearchtxt_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select * from students where course = '" + coursesearchtxt.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Close();
           // count();

        }

        public void fetchyear()
        {

            sql.Open();
            string Sql = "select yearr from students  where statuss is null group by yearr";

            SqlCommand cmd = new SqlCommand(Sql, sql);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                yearstxt.Items.Add(DR[0]);

            }

            sql.Close();

        }

        private void Yearstxt_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
            if (yearstxt.Text == "ALL")
            {
                string qry1 = "select *  from students where statuss is null";
                SqlDataAdapter da1 = new SqlDataAdapter(qry1, db.con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                sql.Close();
               // count();

            }
            else
            {
            
                string qry = "select * from students where yearr = '" + yearstxt.Text + "' and statuss is null";
                SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                sql.Close();
               // count();
            }
        }
        public void fetchcourse()
        {

            coursesearchtxt.Items.Clear();

            sql.Open();
            string Sqll = "select coursename from course group by coursename";

            SqlCommand cmdd = new SqlCommand(Sqll, sql);
            SqlDataReader DRR = cmdd.ExecuteReader();

            while (DRR.Read())
            {
                coursesearchtxt.Items.Add(DRR[0]);

            }

            sql.Close();

        }
        public void fetchteacher()
        {

            sql.Open();
            string qry = "select teachername from teacher group by teachername";

            SqlCommand cmd = new SqlCommand(qry, sql);
            SqlDataReader DR = cmd.ExecuteReader();
            if (DR.HasRows)
            {
                while (DR.Read())
                {
                    teachersearchtxt.Items.Add(DR.GetString(0));

                }
            }
            DR.Close();

            sql.Close();

        }
        private void frmsearchstudent_Load(object sender, EventArgs e)
        {
            styleGridView();
            fetchyear();
            fetchcourse();
            fetchteacher();
        }

        private void studentnametxt_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select * from students where statuss is null and  studentname like '%" + studentnametxt.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sql.Close();
           // count();
        }
    }
}
