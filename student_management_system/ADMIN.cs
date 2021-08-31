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
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectTab(0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectTab(1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectTab(2);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectTab(3);

        }

        private void button6_Click(object sender, EventArgs e)
        {

            
            sql.Open();
            string qry = "select id,studentname,addresss,email,fees,feespaid,contactno,course,college,feesrem,YEARr,teacher,startdate,enddate from students where id = '" + sidtxt.Text + "' and  statuss is null ";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.Visible = true;
            dataGridView1.DataSource = dt;



            sql.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete row from database or datagridview...
                sql.Open();
                string qry = "update students set statuss = 0 where id = '" + sidtxt.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, sql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted");
                dataGridView1.Visible = false;
            }
            else if (DialogResult == DialogResult.No)
            {
                
            }


          





            sql.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select TEACHERNAME,QUALIFICATION,SUBJECT where id = '" + tidtxt.Text + "'  ";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.Visible = true;
            dataGridView2.DataSource = dt;



            sql.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ADMIN_Load(object sender, EventArgs e)
        {

        }
    }
}
