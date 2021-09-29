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
    public partial class frmadminteacher : Form
    {
        public frmadminteacher()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");
        private void frmadminteacher_Load(object sender, EventArgs e)
        {
            fetchteacher();
            links();
            style();
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
        public void fetchteacher()
        {
            try
            {
                sql.Open();
                string qry = "select id,teachername,qualification,subjectt from teacher where status is null ";
                SqlDataAdapter da = new SqlDataAdapter(qry, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;


                sql.Close();
            }
            catch (Exception) { 
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == dataGridView2.Columns["Edit"].Index)
            {
                editteacher frmm = new editteacher();
                frmm.Show();
                frmm.idtxt.Text = dataGridView2.CurrentRow.Cells["id"].Value.ToString();
                frmm.nametxt.Text = dataGridView2.CurrentRow.Cells["teachername"].Value.ToString();
                frmm.qualitxt.Text = dataGridView2.CurrentRow.Cells["qualification"].Value.ToString();
                frmm.subjecttxt.Text = dataGridView2.CurrentRow.Cells["subjectt"].Value.ToString();


            }
            else if (e.ColumnIndex == dataGridView2.Columns["Delete"].Index)
            {
                sql.Open();
                DialogResult result = MessageBox.Show("Are you sure you want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string qry = "update teacher set status=0 where id = '" + dataGridView2.CurrentRow.Cells["id"].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(qry, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record deleted");
               

                }
                sql.Close();
                fetchteacher();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            fetchteacher();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> selectedItem = new List<string>();
                DataGridViewRow drow = new DataGridViewRow();
                for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                {
                    drow = dataGridView2.Rows[i];
                    if (Convert.ToBoolean(drow.Cells[5].Value) == true) //checking if  checked or not.  
                    {
                        string id = drow.Cells[0].Value.ToString();
                        selectedItem.Add(id); //If checked adding it to the list  
                    }
                }
                sql.Open();
                foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
                {
                    SqlCommand cmd = new SqlCommand("update teacher set status = 0 where id = '" + s + "'", sql);
                    int result = cmd.ExecuteNonQuery();
                }
                sql.Close();
                dataGridView2.Refresh();
                fetchteacher();
            }
            catch (Exception)
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmaddteacher frm = new frmaddteacher();
            frm.ShowDialog();
        }

        private void stdsearchtxt_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
            string qry=  "select id, teachername, qualification, subjectt from teacher where status is null  and teachername like '%"+stdsearchtxt.Text+"%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            sql.Close();
        }
    }
    }

