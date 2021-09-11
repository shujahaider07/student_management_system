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
    public partial class frmaddfees : Form
    {
        public frmaddfees()
        {
            InitializeComponent();
            dataGridView4.KeyDown += DataGridView4_KeyDown;
            idtxt.KeyUp += Idtxt_KeyUp;
            searchfeestxt.KeyUp += Searchfeestxt_KeyUp;
            searchfeestxt.TextChanged += Searchfeestxt_TextChanged;
            searchfeestxt.KeyDown += Searchfeestxt_KeyDown;
            stdaddtxt.KeyUp += Stdaddtxt_KeyUp;
        }

        private void Stdaddtxt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button14.Focus();

                }
                    if (Convert.ToInt32(stdaddtxt.Text) > Convert.ToInt32(stdfeestxt.Text))
                    {
                        MessageBox.Show("Out of Bound");
                        stdaddtxt.Text = "";

                    
                }
                
            }
            catch (Exception)
            {
                stdremtxt.Text = "";

            }
        }

        private void Searchfeestxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                dataGridView4.Focus();
            }
        }

        public void stdgrid()
        {
            sql.Open();
            string qry = "select  id,studentname,email,fees,feespaid,feesrem,contactno,course,college  from students where statuss is null";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;

            sql.Close();

        }



        private void Searchfeestxt_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select  id,studentname,email,fees,feespaid,feesrem,contactno,course,college  from students where statuss is null and studentname like '%"+searchfeestxt.Text+"%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;

            sql.Close();
        }

        private void Searchfeestxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                panel14.Visible = false;
            }
        }

        private void Idtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                panel14.Visible = true;
                searchfeestxt.Focus();

            }
        }

        private void DataGridView4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panel14.Visible = false;
                panel6.Visible = true;

                idtxt.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
                stdnametxt.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
                stdcoursetxt.Text = dataGridView4.CurrentRow.Cells[7].Value.ToString();
                stdfeestxt.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
                stdpaidtxt.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
                stdremtxt.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();
                stdemailtxt.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
                stdcollegetxt.Text = dataGridView4.CurrentRow.Cells[8].Value.ToString();
                stdmobtxt.Text = dataGridView4.CurrentRow.Cells[6].Value.ToString();


            }
            if (e.KeyCode == Keys.Escape)
            {
                panel14.Visible = false;
            }

        }

        SqlConnection sql = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");

        private void button13_Click(object sender, EventArgs e)
        {
            if (idtxt.Text == "")
            {

                MessageBox.Show("Invalid");
                panel6.Visible = false;
            }
            else
            {

                panel6.Visible = true;
                
                sql.Open();

                try
                {

                    string qry = "select id,studentname, addresss, contactno, email, college, course, fees,feesrem,feespaid  from students where id = '" + idtxt.Text + "' and statuss is null ";
                    SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    stdnametxt.Text = dt.Rows[0]["studentname"].ToString();
                    stdemailtxt.Text = dt.Rows[0]["email"].ToString();
                    stdmobtxt.Text = dt.Rows[0]["contactno"].ToString();
                    stdcoursetxt.Text = dt.Rows[0]["course"].ToString();
                    stdfeestxt.Text = dt.Rows[0]["fees"].ToString();
                    stdcollegetxt.Text = dt.Rows[0]["college"].ToString();
                    stdpaidtxt.Text = dt.Rows[0]["feespaid"].ToString();
                    stdremtxt.Text = dt.Rows[0]["feesrem"].ToString();
                    panel6.Visible = true;
                }
                catch (Exception)

                {
                    MessageBox.Show("RECORD NOT FOUND!");
                }



                sql.Close();
                
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {

            try
            {
                sql.Open();



                string qry = "select id,studentname, addresss, contactno, email, college, course, fees,feesrem,feespaid  from students where contactno = '" + contxt.Text + "' and statuss is null ";
                SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                stdnametxt.Text = dt.Rows[0]["studentname"].ToString();
                stdemailtxt.Text = dt.Rows[0]["email"].ToString();
                stdmobtxt.Text = dt.Rows[0]["contactno"].ToString();
                stdcoursetxt.Text = dt.Rows[0]["course"].ToString();
                stdfeestxt.Text = dt.Rows[0]["fees"].ToString();
                stdcollegetxt.Text = dt.Rows[0]["college"].ToString();
                stdpaidtxt.Text = dt.Rows[0]["feespaid"].ToString();
                stdremtxt.Text = dt.Rows[0]["feesrem"].ToString();
                panel6.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("RECORD NOT FOUND!");
            }



            sql.Close();


        }

        private void searchfeestxt_TextChanged(object sender, EventArgs e)
        {
            sql.Open();

            string qry = "select id,studentname,email,fees,feespaid,contactno,course,college,feesrem from students where  statuss is null  and  studentname like '%" + searchfeestxt.Text + "%'  ";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;

            sql.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "update  students set  feespaid = '" + stdpaidtxt.Text + "' ,feesrem = '" + stdremtxt.Text + "' where id = '" + idtxt.Text + "' or contactno = '" + contxt.Text + "' ";

            SqlCommand cmd = new SqlCommand(qry, sql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("fees paid");

            sql.Close();

            idtxt.Text = "";
            stdaddtxt.Text = "";
            stdnametxt.Text = "";
            stdmobtxt.Text = "";
            stdemailtxt.Text = "";
            stdcollegetxt.Text = "";
            stdremtxt.Text = "";
            stdfeestxt.Text = "";
            stdcoursetxt.Text = "";
            contxt.Text = "";

        }

        private void frmaddfees_Load(object sender, EventArgs e)
        {
            stdgrid();
            styleGridView2();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select id ,studentname,feespaid from students where fees = feespaid  and statuss is null";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            panel14.Visible = true; ;
            dataGridView4.Visible = true;
            sql.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select id,studentname,feesrem from students where statuss is null and feesrem > 0";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            sql.Close();

        }

        private void stdaddtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                stdpaidtxt.Text = stdaddtxt.Text;
                int total = Convert.ToInt32(stdfeestxt.Text) - Convert.ToInt32(stdpaidtxt.Text);
                stdremtxt.Text = total.ToString();




                if (Convert.ToInt32(stdaddtxt.Text) > Convert.ToInt32(stdfeestxt.Text))
                {
                    MessageBox.Show("Out of Bound");
                    stdaddtxt.Text = "";

                }


            }
            catch (Exception)
            {
                stdremtxt.Text = "";

            }
        }

        public void styleGridView2()
        {
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView4.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView4.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView4.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView4.BackgroundColor = Color.White;
            dataGridView4.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans serif", 10);
            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

    }

}
