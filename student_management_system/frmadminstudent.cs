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
    public partial class adminyear : Form
    {
        public adminyear()
        {   
            InitializeComponent();

            adminbatch.TextChanged += Adminbatch_TextChanged;
            year.TextChanged += Year_TextChanged;
            activity.TextChanged += Activity_TextChanged;
            adminbatch.KeyUp += Adminbatch_KeyUp;
            year.KeyUp += Year_KeyUp;
            activity.KeyUp += Activity_KeyUp;
            activity.TextChanged += Activity_TextChanged1;
            year.TextChanged += Year_TextChanged1;
        }

        private void Year_TextChanged1(object sender, EventArgs e)
        {
           
        }

        private void Activity_TextChanged1(object sender, EventArgs e)
        {
            

        }

        private void Activity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView2.Focus();
            }
        }

        private void Activity_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Year_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                activity.Focus();
            }
        }

        private void Adminbatch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                year.Focus();
            }

        }

        private void Activity_TextChanged(object sender, EventArgs e)
        {
            if (activity.Text == "Active")
            {
                sql.Open();
                string qry = "select id,studentname,contactno,email,college,course,fees,feespaid,feesrem,teacher,yearr,startdate,enddate from students where statuss is null";
                SqlDataAdapter da = new SqlDataAdapter(qry, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

            }
            else if (activity.Text == "Deactive")
            {
                string qry = "select id,studentname,contactno,email,college,course,fees,feespaid,feesrem,teacher,yearr,startdate,enddate from students where statuss = 0";
                SqlDataAdapter da = new SqlDataAdapter(qry, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            sql.Close();


            
        }

        private void Year_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
            
            string qry = "select id,studentname,contactno,email,college,course,fees,feespaid,feesrem,teacher,yearr,startdate,enddate from students where statuss is null and yearr = '" + year.Text + "'  and course = '" + adminbatch.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            
            sql.Close();
        }

        SqlConnection sql = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");
        private void Adminbatch_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select id,studentname,contactno,email,college,course,fees,feespaid,feesrem,teacher,yearr,startdate,enddate from students where statuss is null and course = '" + adminbatch.Text + "' ";

            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            
            sql.Close();
       

    }
        public void fetchyear()
        {

            sql.Open();
            year.Items.Clear();
            string Sql = "select yearr from students  where statuss is null group by yearr";

            SqlCommand cmd = new SqlCommand(Sql, sql);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                year.Items.Add(DR[0]);

            }

            sql.Close();

        }
        public void fetchcourse()
        {

           adminbatch.Items.Clear();

            sql.Open();
            string Sqll = "select coursename from course group by coursename";

            SqlCommand cmdd = new SqlCommand(Sqll, sql);
            SqlDataReader DRR = cmdd.ExecuteReader();

            while (DRR.Read())
            {
                adminbatch.Items.Add(DRR[0]);

            }

            sql.Close();

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Edit"].Index)
            {

                edit frm = new edit();
                frm.Show();
                frm.idtxt.Text = dataGridView2.CurrentRow.Cells["id"].Value.ToString();
                frm.nametxt.Text = dataGridView2.CurrentRow.Cells["studentname"].Value.ToString();

                frm.contacttxt.Text = dataGridView2.CurrentRow.Cells["contactno"].Value.ToString();
                frm.coursetxt.Text = dataGridView2.CurrentRow.Cells["course"].Value.ToString();
                frm.feestxt.Text = dataGridView2.CurrentRow.Cells["fees"].Value.ToString();
                frm.emailtxt.Text = dataGridView2.CurrentRow.Cells["email"].Value.ToString();
                frm.feespaidtxt.Text = dataGridView2.CurrentRow.Cells["feespaid"].Value.ToString();
                frm.feesremtxt.Text = dataGridView2.CurrentRow.Cells["feesrem"].Value.ToString();
                frm.teachertxt.Text = dataGridView2.CurrentRow.Cells["teacher"].Value.ToString();
                frm.collegetxt.Text = dataGridView2.CurrentRow.Cells["college"].Value.ToString();



            }
            else if (e.ColumnIndex==dataGridView2.Columns["Delete"].Index)
            {
                sql.Open();
                DialogResult result = MessageBox.Show("Are you sure you want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string qry = "update students set statuss=0 where id = '" + dataGridView2.CurrentRow.Cells["id"].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(qry, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record deleted");
                    
                }

                sql.Close();
                fetchstudents();
            }
        }

        private void frmadminstudent_Load(object sender, EventArgs e)
        {
           
            fetchstudents();
            links();
            style();
            fetchcourse();
            fetchyear();
        }
        public void fetchstudents()
        {
            sql.Open();
            string qry = "select id,studentname,contactno,email,college,course,fees,feespaid,feesrem,teacher,yearr,startdate,enddate from students where statuss is null";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            sql.Close();
        }

        public void links()
        {
            //edit link
            DataGridViewLinkColumn Edit = new DataGridViewLinkColumn();
            Edit.UseColumnTextForLinkValue = true;
            Edit.HeaderText = "Edit";
            Edit.DataPropertyName = "lnkColumn";
            Edit.LinkBehavior = LinkBehavior.SystemDefault;
            Edit.Text = "Edit";
            Edit.Name = "Edit";
            dataGridView2.Columns.Add(Edit);


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            fetchstudents();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmaddstudent frm = new frmaddstudent();
            frm.ShowDialog();
        }

        private void activity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        
            sql.Open();
            
            string qry = "select id,studentname,contactno,email,college,course,fees,feespaid,feesrem,teacher,yearr,startdate,enddate from students where statuss is null and studentname like '%" + searchtxt.Text + "%'" ;
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;


            sql.Close();
        }

        private void adminbatch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
