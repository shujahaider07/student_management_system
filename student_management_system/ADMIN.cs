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
           
            dataGridView3.KeyUp += DataGridView3_KeyUp1;
            tidtxt.KeyUp += Tidtxt_KeyUp1;
            Teachersearchttxt.KeyDown += Teachersearchttxt_KeyDown;
            dataGridView4.KeyDown += DataGridView4_KeyDown;
            sidtxt.KeyDown += Sidtxt_KeyDown;
            dataGridView3.KeyDown += DataGridView3_KeyDown;
            dataGridView3.CellClick += DataGridView3_CellClick;
            cstxt.KeyUp += Cstxt_KeyUp;
            dataGridView4.KeyUp += DataGridView4_KeyUp1;
            Teachersearchttxt.KeyUp += Teachersearchttxt_KeyUp;
            coursetxtchange.KeyUp += Coursetxtchange_KeyUp;
        }

        private void Coursetxtchange_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {

                panel4.Visible = false;
            }
        }

        private void Teachersearchttxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                panel3.Visible = false;
            }
        }

        private void DataGridView4_KeyUp1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                panel3.Visible = false;
               
            }
        }

        private void Cstxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2)
            {

                sql.Open();
                string qry = "select * from course";
                SqlDataAdapter da = new SqlDataAdapter(qry, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                courseGrid.DataSource = dt;
                panel4.Visible = true;
                coursetxtchange.Focus();

                sql.Close();


            }
        }

        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Form1 frm = new Form1();
          
            DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete row from database or datagridview...
                sql.Open();
                string qry = "update students set statuss = 0 where id= '" + dataGridView3.Rows[0].Cells["id"].Value.ToString() + "'";
                
                SqlCommand cmd = new SqlCommand(qry, sql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted");
                
                

            }
            else if (DialogResult == DialogResult.No)
            {

            }


            sql.Close();
            frm.teacher();
        }

        private void DataGridView3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                sidtxt.Text = dataGridView3.CurrentRow.Cells["studentname"].Value.ToString();
                

            
            }
        }

        private void Sidtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                dataGridView3.Focus();

            }


        }

        private void DataGridView4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panel2.Visible = true;

                tnametxt.Text = dataGridView4.CurrentRow.Cells["teachername"].Value.ToString();
                subjecttxt.Text = dataGridView4.CurrentRow.Cells["subjectt"].Value.ToString();
                panel3.Visible = false;


            }
        }

        private void DataGridView4_KeyUp(object sender, KeyEventArgs e)
        {
            

        }

        private void Teachersearchttxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) {
                dataGridView4.Focus();
            
            
            }



        }

        private void Tidtxt_KeyUp1(object sender, KeyEventArgs e)
        {
           
        }

        private void DataGridView3_KeyUp1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

            }
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) {

                dataGridView3.Focus();
            
            
            }
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
            dataGridView3.Focus();

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
            
            dataGridView4.DataSource = dt;



            sql.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete row from database or datagridview...
                sql.Open();
                string qry = "update students set statuss = 0 where studentname= '" + sidtxt.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, sql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted");
                
            }
            else if (DialogResult == DialogResult.No)
            {
                
            }



            sql.Close();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void fetchstudents() {
            sql.Open();
            string qry = "select  id,studentname,email,fees,feespaid,contactno,course,college,feesrem,teacher,yearr from students where statuss = 0";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            sql.Close();
        }
        public void fetchrecord() {
            sql.Open();
            string qry = "select id,studentname,email,fees,feespaid,contactno,course,college,feesrem from students where  statuss = 0  and  id like'%" + sidtxt.Text + "%'  ";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            sql.Close();

        }


        private void ADMIN_Load(object sender, EventArgs e)
        {

            


            
            
            
            teachergrid();
            fetchstudents();
            tidtxt.KeyUp += Tidtxt_KeyUp;


          

        }

        private void Tidtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sql.Open();
                string qry = "select teachername,subjectt from teacher where id = '" + tidtxt.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(qry, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tnametxt.Text = dt.Rows[0]["teachername"].ToString();
                subjecttxt.Text = dt.Rows[0]["subjectt"].ToString();
                panel2.Visible = true;
                Teachersearchttxt.Focus();


                sql.Close();

            }
            else if (e.KeyCode == Keys.F2)
            {

                panel3.Visible = true;
                Teachersearchttxt.Focus();



            }
        }
        public void teachergrid() {
            string qry = "select * from teacher";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
        
        }
        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

       

       
          
        

       

       
        

       

        private void sidtxt_KeyPress(object sender, KeyPressEventArgs e)
        {

           
            

        }

        private void sidtxt_TextChanged(object sender, EventArgs e)
        {
            
            sql.Open();

            string qry = "select * from students where statuss is null and  studentname like '%" + sidtxt.Text + "%'";

            SqlDataAdapter da = new SqlDataAdapter(qry, sql);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;

            sql.Close();


        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sql.Open();

            string qry = "select * from teacher where teachername like '%" + Teachersearchttxt.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;

            sql.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      
          
            
        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void update() {
            sql.Open();
            string qry = "update teacher set teachername = '" + tnametxt.Text + "' , subjectt = '" + subjecttxt.Text + "' where id = '" + tidtxt.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, sql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record updated");



            sql.Close();
            Form1 frm = new Form1();
            frm.teacher();


        }
        private void button9_Click(object sender, EventArgs e)
        {
            update();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete row from database or datagridview...
                sql.Open();
                string qry = "delete from teacher where id = '" + dataGridView4.Rows[0].Cells["id"].Value.ToString() + "'";
                //string qry = "delete from students  where id = '"+dataGridView3.Rows[0].Cells["id"].Value.ToString()+"'";
                //string qry = "delete from students where id =  '" + dataGridView3.Rows[0].Cells["id"].Value.ToString() +"'   ";

                SqlCommand cmd = new SqlCommand(qry, sql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted");

            }
            else if (DialogResult == DialogResult.No)
            {

            }


            sql.Close();

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
          
        }

        private void coursetxtchange_TextAlignChanged(object sender, EventArgs e)
        {
                    }

        private void coursetxtchange_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select * from course where coursename like  '%" + coursetxtchange.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            courseGrid.DataSource = dt;


            sql.Close();


        }

        private void courseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sql.Open();


            DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete row from database or datagridview...
                
                string qry = "delete from course where cid = '" + courseGrid.Rows[0].Cells["cid"].Value.ToString() + "'";
               
                SqlCommand cmd = new SqlCommand(qry, sql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted");

            }
            else if (DialogResult == DialogResult.No)
            {

            }

            sql.Close();




        }
    }
}
