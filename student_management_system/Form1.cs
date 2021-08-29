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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            idtxt.KeyUp += Idtxt_KeyUp;
            stdaddtxt.KeyUp += Stdaddtxt_KeyUp;
            pincodetxt.KeyPress += Pincodetxt_KeyPress;
            button10.KeyUp += Button10_KeyUp;
            yearstxt.KeyUp += Yearstxt_KeyUp;
            yearstxt.TextChanged += Yearstxt_TextChanged;
            studentnametxt.TextChanged += Studentnametxt_TextChanged;
            coursesearchtxt.TextChanged += Coursesearchtxt_TextChanged;
            teachersearchtxt.TextChanged += Teachersearchtxt_TextChanged;
            stdaddtxt.TextChanged += Stdaddtxt_TextChanged;
            nametxt.KeyUp += Nametxt_KeyUp;
            pincodetxt.KeyUp += Pincodetxt_KeyUp;
            emailtxt.KeyUp += Emailtxt_KeyUp;
            contacttxt.KeyUp += Contacttxt_KeyUp;
            addresstxt.KeyUp += Addresstxt_KeyUp;
            textBox1.KeyDown += TextBox1_KeyDown;
            dataGridView4.KeyDown += DataGridView4_KeyDown;
            button9.KeyUp += Button9_KeyUp;
            coursetxt.KeyUp += Coursetxt_KeyUp;
            feestxt.KeyUp += Feestxt_KeyUp;
            collegetxt.KeyUp += Collegetxt_KeyUp;
            teachertxt.KeyUp += Teachertxt_KeyUp;
            startdatetxt.KeyUp += Startdatetxt_KeyUp;
            enddatetxt.KeyUp += Enddatetxt_KeyUp;
            aduser.KeyUp += Aduser_KeyUp;
            adpass.KeyUp += Adpass_KeyUp;

        }

        private void Adpass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                button16.Focus();
            }
        }

        private void Aduser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                adpass.Focus();
            
            }
        }

        private void Enddatetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button8.Focus();
            }
        }

        private void Startdatetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                enddatetxt.Focus();
            }
        }

        private void Teachertxt_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode==Keys.Enter)
            {
                startdatetxt.Focus();

            }
        }

        private void Collegetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                teachertxt.Focus();
            }
        }

        private void Feestxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                collegetxt.Focus();

            }
        }

        private void Coursetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                feestxt.Focus();
            }
        }

        private void Button9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                coursetxt.Focus();
            }
        }

        private void DataGridView4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                panel14.Visible = false;
                panel6.Visible = true;

                idtxt.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
                stdnametxt.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
                stdcoursetxt.Text= dataGridView4.CurrentRow.Cells[7].Value.ToString();
                stdfeestxt.Text= dataGridView4.CurrentRow.Cells[3].Value.ToString();
                stdpaidtxt.Text= dataGridView4.CurrentRow.Cells[4].Value.ToString();
                stdremtxt.Text= dataGridView4.CurrentRow.Cells[5].Value.ToString();
                stdemailtxt.Text= dataGridView4.CurrentRow.Cells[2].Value.ToString();
                stdcollegetxt.Text= dataGridView4.CurrentRow.Cells[8].Value.ToString();
                stdmobtxt.Text= dataGridView4.CurrentRow.Cells[6].Value.ToString();
            }

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) {

                dataGridView4.Focus();
            }
        }

        private void Idtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) {
                panel14.Visible = true;
                textBox1.Focus();

            
            }
        }

        private void Addresstxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button9.Focus();
            }
        }

        private void Contacttxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addresstxt.Focus();
            }
        }

        private void Emailtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                contacttxt.Focus();
            }
        }

        private void Pincodetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                emailtxt.Focus();
            }
        }

        private void Nametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                pincodetxt.Focus();
            }
        }

        SqlConnection sql = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");
        private void Stdaddtxt_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    stdpaidtxt.Text = stdaddtxt.Text;
                    int total = Convert.ToInt32(stdpaidtxt.Text) - Convert.ToInt32(stdfeestxt.Text);
                    stdremtxt.Text = total.ToString();
                    if (Convert.ToInt32(stdaddtxt.Text) > Convert.ToInt32(stdfeestxt.Text))
                    {
                        MessageBox.Show("Out of Bound");
                        stdaddtxt.Text = "";


                    }
                    



                }
            }
            catch (Exception) {
                stdremtxt.Text = "";

            }

        }

        private void Stdaddtxt_TextChanged(object sender, EventArgs e)
        {



        }

        private void Teachersearchtxt_TextChanged(object sender, EventArgs e)
        {
            db.con.Open();
            string qry = "select * from students where teacher = '" + teachersearchtxt.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            db.con.Close();
        }

        private void Coursesearchtxt_TextChanged(object sender, EventArgs e)
        {
            db.con.Open();
            string qry = "select * from students where course = '" + coursesearchtxt.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            db.con.Close();
        }

        private void Feessearchtxt_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Studentnametxt_TextChanged(object sender, EventArgs e)
        {
            db.con.Open();
            string qry = "select * from students where studentname like '%" + studentnametxt.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;




            db.con.Close();
        }

        private void Yearstxt_TextChanged(object sender, EventArgs e)
        {
            db.con.Open();
            if (yearstxt.Text == "ALL")
            {
                string qry1 = "select *  from students";
                SqlDataAdapter da1 = new SqlDataAdapter(qry1, db.con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                db.con.Close();

            }
            else {

                string qry = "select * from students where yearr = '" + yearstxt.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                db.con.Close();
            }


        }

        private void Yearstxt_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Button10_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Pincodetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;

            } else if (e.KeyChar == 8)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled =  true;
                MessageBox.Show("Invalid value");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Enabled = true;
        }


        public void fetchcourse()
        {
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



        public void stdgrid() {
            sql.Open();
            string qry = "select  id,studentname,email,fees,feespaid,feesrem,contactno,course,college  from students";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;


            sql.Close();
        
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
            sql.Open();
            string qry = "select count (cid) from course";
            SqlCommand cmd = new SqlCommand(qry, sql);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                label45.Text = reader[0].ToString();

            }

            sql.Close();


            sql.Open();
            string qry1 = "select count (id) from students";
            SqlCommand cmdd = new SqlCommand(qry1, sql);
            SqlDataReader readerr = cmdd.ExecuteReader();
            while (readerr.Read())
            {

                label46.Text = readerr[0].ToString();

            }
            sql.Close();


            sql.Open();
            string qry2 = "select count (id) from TEACHER";
            SqlCommand cmd2 = new SqlCommand(qry2, sql);
            SqlDataReader reader1 = cmd2.ExecuteReader();
            while (reader1.Read())
            {

                label48.Text = reader1[0].ToString();

            }
            sql.Close();


            nametxt.Focus();
            fetchcourse();
            fetchyear();
            fetchteacher();
            courses();
            teacher();
            stdgrid();


            tabControl1.Visible = false;
        }

        public void teacher()
        {
           
            string qry = "select * from teacher";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;

            sql.Close();
        }
        public void courses()
        {
            sql.Open();
            string qry = "select * from course";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;


            sql.Close();


        }



        public void fetchyear() {

            sql.Open();
            string Sql = "select yearr from students group by yearr";

            SqlCommand cmd = new SqlCommand(Sql, sql);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                yearstxt.Items.Add(DR[0]);

            }

            sql.Close();


        }

        public void fetchteacher()
        {

            sql.Open();
            string Sql = "select teachername from teacher group by teachername";



            SqlCommand cmd = new SqlCommand(Sql, sql);
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
        private void button1_Click(object sender, EventArgs e)
        {
            nametxt.Focus();
            tabControl1.Visible = true;
            tabControl1.SelectTab(0);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string start = startdatetxt.Text;
            string end = enddatetxt.Text;



            db.con.Open();
            string qry = "insert into students(studentname,addresss,pincode,contactno,email,college,course,fees,teacher,yearr,startdate,enddate) values ('" + nametxt.Text + "','" + addresstxt.Text + "','" + pincodetxt.Text + "','" + contacttxt.Text + "','" + emailtxt.Text + "','" + collegetxt.Text + "','" + coursetxt.Text + "','" + feestxt.Text + "','" + teachertxt.Text + "','" + yeartxt.Text + "','" + start + "','" + end + "')";
            SqlCommand cmd = new SqlCommand(qry, db.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record added");
            label5.Visible = true;
            label5.Text = "STUDENT ADDED SUCCESSFULLY...!!";




            db.con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {





            tabControl1.Visible = true;
            tabControl1.SelectTab(1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectTab(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectTab(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;

            tabControl1.SelectTab(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectTab(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectTab(6);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {



        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            

            if (idtxt.Text == "")
            {

                MessageBox.Show("invalid");
                panel6.Visible = false;
            }
            else
            {

                panel6.Visible = true;

                db.con.Open();
                string qry = "select * from students where id = '" + idtxt.Text + "' ";
                SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                stdnametxt.Text = dt.Rows[0][1].ToString();
                stdemailtxt.Text = dt.Rows[0][5].ToString();
                stdmobtxt.Text = dt.Rows[0][4].ToString();
                stdcoursetxt.Text = dt.Rows[0][7].ToString();
                stdfeestxt.Text = dt.Rows[0][8].ToString();
                stdcollegetxt.Text = dt.Rows[0][6].ToString();
                stdpaidtxt.Text = dt.Rows[0][9].ToString();
                stdremtxt.Text = dt.Rows[0][10].ToString();

                db.con.Close();




            }
            





        }
        private void stdfeestxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {


            db.con.Open();
            string qry = "update  students set  feespaid = '"+stdpaidtxt.Text+"',feesrem = '"+stdremtxt.Text+"' where id = '"+idtxt.Text+"'";
             SqlCommand cmd = new SqlCommand(qry, db.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("fees paid");

            db.con.Close();


            idtxt.Text = "";
            stdaddtxt.Text = "";
            stdnametxt.Text = "";
            stdmobtxt.Text = "";
            stdemailtxt.Text = "";
            stdcollegetxt.Text = "";
            stdremtxt.Text = "";
            stdfeestxt.Text = "";
            stdcoursetxt.Text = "";


        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stdaddtxt_TextChanged_1(object sender, EventArgs e)
        {
            
            try
            {

                stdpaidtxt.Text = stdaddtxt.Text;
                int total = Convert.ToInt32(stdfeestxt.Text) - Convert.ToInt32(stdpaidtxt.Text);
                stdremtxt.Text = total.ToString();

               if (Convert.ToInt32(stdaddtxt.Text) > Convert.ToInt32(stdfeestxt.Text)) {
                    MessageBox.Show("Out of Bound");
                    stdaddtxt.Text = "";

                }
               
            }
            catch (Exception) {
                stdremtxt.Text = "";
            
            }



        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            
            sql.Open();
            SqlCommand cmdd = new SqlCommand("Select coursename from course where coursename = '" + cnametxt.Text + "'",sql);
            SqlDataReader dr = cmdd.ExecuteReader();
          
            if (dr.HasRows) {
                MessageBox.Show("record already exists");
               
            }
           
            else  {

                db.con.Open();
                string qry = "insert into course(coursename,coursefees,duration)values('" + cnametxt.Text + "','" + cfeestxt.Text + "','" + durationtxt.Text + "')";
                SqlCommand cmd = new SqlCommand(qry,db.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("COURSE ADDED");
                db.con.Close();
            }


            sql.Close();
        }



       

        

        private void coursesearchtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            db.con.Open();
            string qry = "select * from admintrator where aduser = @User and adpassword = @Pass";
            SqlCommand cmd = new SqlCommand(qry,db.con);
            cmd.Parameters.AddWithValue("@User",aduser.Text);
            cmd.Parameters.AddWithValue("@Pass", adpass.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            
            
            if (dr.HasRows == true)
            {
                MessageBox.Show("Login Adminstrator form");
                ADMIN a = new ADMIN();
                a.Show();
                aduser.Text = "";
                adpass.Text = "";

            }
            else
            {
                MessageBox.Show("Failed");
            }


                         





            db.con.Close();


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select count (cid) from course";
            SqlCommand cmd = new SqlCommand(qry, sql);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                label45.Text = reader[0].ToString();

            }

            sql.Close();


            sql.Open();
            string qry1 = "select count (id) from students";
            SqlCommand cmdd = new SqlCommand(qry1, sql);
            SqlDataReader readerr = cmdd.ExecuteReader();
            while (readerr.Read())
            {

                label46.Text = readerr[0].ToString();

            }
            sql.Close();


            sql.Open();
            string qry2 = "select count (id) from TEACHER";
            SqlCommand cmd2 = new SqlCommand(qry2, sql);
            SqlDataReader reader1 = cmd2.ExecuteReader();
            while (reader1.Read())
            {

                label48.Text = reader1[0].ToString();

            }
            sql.Close();








            tabControl1.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
         }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "insert into teacher values('" + tnametxt.Text + "','" + tqualitxt.Text + "','" + subjectxt.Text + "')";
            SqlCommand cmd = new SqlCommand(qry, sql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ADDED!");

            tnametxt.Text = "";
            tqualitxt.Text = "";
            subjectxt.Text = "";



            sql.Close();

               
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
          
            string qry = "select id,studentname,email,fees,feespaid,contactno,course,college,feesrem from students where studentname like '%" + textBox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;


            sql.Close();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
         

            

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yearstxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adpass_TextChanged(object sender, EventArgs e)
        {
            adpass.PasswordChar = '●';
        }
    }
}
