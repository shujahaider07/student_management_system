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


        public void fetchstudents()
        {
            sql.Open();
            string qry = "select id,studentname,contactno,email,college,course,fees,feespaid,feesrem,teacher,startdate,enddate from students where statuss is null";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Close();
        }


        private void ADMIN_Load(object sender, EventArgs e)
        {
            fetchstudents();
            //Edit link

            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Edit";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            dataGridView1.Columns.Add(Editlink);

            //Delete link
            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.HeaderText = "Delete";
            dataGridView1.Columns.Add(check);

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sql.Open();
                string qry = "select id,studentname,contactno,email,college,course,fees,feespaid,feesrem,teacher,startdate,enddate from students where statuss is null and studentname like '%" + stdsearchtxt.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(qry, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                sql.Close();
            }
            catch (Exception) { 
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12) {
                edit frm = new edit();
                frm.Show();
              frm.idtxt.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
              frm.nametxt.Text = dataGridView1.CurrentRow.Cells["studentname"].Value.ToString();
              frm.contacttxt.Text = dataGridView1.CurrentRow.Cells["contactno"].Value.ToString();
              frm.coursetxt.Text = dataGridView1.CurrentRow.Cells["course"].Value.ToString();
              frm.feestxt.Text = dataGridView1.CurrentRow.Cells["fees"].Value.ToString();
             frm.emailtxt.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            frm.feespaidtxt.Text = dataGridView1.CurrentRow.Cells["feespaid"].Value.ToString();
             frm.feesremtxt.Text = dataGridView1.CurrentRow.Cells["feesrem"].Value.ToString();
             frm.teachertxt.Text = dataGridView1.CurrentRow.Cells["teacher"].Value.ToString();
            frm.collegetxt.Text = dataGridView1.CurrentRow.Cells["college"].Value.ToString();



            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                drow = dataGridView1.Rows[i];
                if (Convert.ToBoolean(drow.Cells[13].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[0].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            sql.Open();
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                SqlCommand cmd = new SqlCommand("update students set statuss = 0 where id = '" + s + "'", sql);
                int result = cmd.ExecuteNonQuery();
            }
            sql.Close();
            dataGridView1.Refresh();
            fetchstudents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentpanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentpanel.Visible = true;
        }
    }
}