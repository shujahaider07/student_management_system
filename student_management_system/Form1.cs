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
using System.Web;

namespace student_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            
            InitializeComponent();
            timer1.Start();
            countall();
            fetchyear();
            course();
            fetchcourse();
            fetchteacher();
            courses();
            teacher();
            stdgrid();
            countall();
            comboteacher();

            idtxt.KeyUp += Idtxt_KeyUp;
            stdaddtxt.KeyUp += Stdaddtxt_KeyUp;
            stdaddtxt.KeyUp += Stdaddtxt_KeyUp1;
            button10.KeyUp += Button10_KeyUp;
            yearstxt.KeyUp += Yearstxt_KeyUp;
            yearstxt.TextChanged += Yearstxt_TextChanged;
            studentnametxt.TextChanged += Studentnametxt_TextChanged;
            coursesearchtxt.TextChanged += Coursesearchtxt_TextChanged;
            teachersearchtxt.TextChanged += Teachersearchtxt_TextChanged;
            stdaddtxt.TextChanged += Stdaddtxt_TextChanged;
            nametxt.KeyUp += Nametxt_KeyUp;
            contacttxt.KeyUp += Contacttxt_KeyUp1;


            emailtxt.KeyUp += Emailtxt_KeyUp;
            contacttxt.KeyUp += Contacttxt_KeyUp;
            addresstxt.KeyUp += Addresstxt_KeyUp;
            searchfeestxt.KeyDown += TextBox1_KeyDown;
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
            yearstxt.KeyUp += Yearstxt_KeyUp1;
            studentnametxt.KeyUp += Studentnametxt_KeyUp;
            coursesearchtxt.KeyUp += Coursesearchtxt_KeyUp;
            feessearchtxt.KeyUp += Feessearchtxt_KeyUp;
            searchfeestxt.TextChanged += Searchfeestxt_TextChanged;
            searchfeestxt.KeyUp += Searchfeestxt_KeyUp;
            dataGridView4.KeyDown += DataGridView4_KeyDown1;
            cnametxt.KeyUp += Cnametxt_KeyUp;
            cfeestxt.KeyUp += Cfeestxt_KeyUp;
            durationtxt.KeyUp += Durationtxt_KeyUp;
            tnametxt.KeyUp += Tnametxt_KeyUp;
            tqualitxt.KeyUp += Tqualitxt_KeyUp;
            yeartxt.KeyUp += Yeartxt_KeyUp;
            subjectxt.KeyUp += Subjectxt_KeyUp;
            Feespaidgrid.KeyUp += Feespaidgrid_KeyUp;
            idtxt.KeyUp += Idtxt_KeyUp1;

        }

        private void Idtxt_KeyUp1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button13.Focus();
            }
        }

        private void Stdaddtxt_KeyUp1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button14.Focus();
            }
        }

        private void Feespaidgrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                Feespaidgrid.Hide();
            }
        }

        private void Subjectxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button19.Focus();
            }
        }

        private void Yeartxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enddatetxt.Focus();
            }
        }

        private void Tqualitxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                subjectxt.Focus();
            }
        }

        private void Tnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tqualitxt.Focus();
            }
        }

        private void Durationtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button15.Focus();
            }
        }

        private void Cfeestxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                durationtxt.Focus();
            }
        }

        private void Cnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cfeestxt.Focus();
            }
        }

        private void Contacttxt_KeyUp1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                emailtxt.Focus();
            }
        }

        private void DataGridView4_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                panel14.Visible = false;
            }
        }

        private void Searchfeestxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                panel14.Visible = false;
            }
        }

        private void Searchfeestxt_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select * from students where studentname like '%" + feessearchtxt.Text + "%' and statuss is  null";
            SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sql.Close();
        }

        private void Feessearchtxt_KeyUp(object sender, KeyEventArgs e)
        {
            teachersearchtxt.Focus();
        }

        private void Coursesearchtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                feessearchtxt.Focus();
            }
        }

        private void Studentnametxt_KeyUp(object sender, KeyEventArgs e)
        {
          
            
            if (e.KeyCode == Keys.Enter)


            {
                coursesearchtxt.Focus();
            }
        }

        private void Yearstxt_KeyUp1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                studentnametxt.Focus();

            }
        }

        private void Adpass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                button16.Focus();
            }
        }

        private void Aduser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adpass.Focus();

            }
        }

        private void Enddatetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button8.Focus();
            }
        }

        private void Startdatetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                yeartxt.Focus();
            }
        }

        private void Teachertxt_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                startdatetxt.Focus();

            }
        }

        private void Collegetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                teachertxt.Focus();
            }
        }

        private void Feestxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                collegetxt.Focus();

            }
        }

        private void Coursetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                feestxt.Focus();
            }
        }

        private void Button9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                coursetxt.Focus();
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

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                dataGridView4.Focus();
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
                emailtxt.Focus();
            }
        }

        private void Emailtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addresstxt.Focus();
            }
        }



        private void Nametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                contacttxt.Focus();
            }
        }

        SqlConnection sql = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");
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
            catch (Exception)
            {
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
            count();
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
            count();
        }

        private void Feessearchtxt_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Studentnametxt_TextChanged(object sender, EventArgs e)
        {
            db.con.Open();
            string qry = "select * from students where statuss is null and  studentname like '%" + studentnametxt.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            db.con.Close();
            count();




        }

        private void Yearstxt_TextChanged(object sender, EventArgs e)
        {
            db.con.Open();
            if (yearstxt.Text == "ALL")
            {
                string qry1 = "select *  from students where statuss is null";
                SqlDataAdapter da1 = new SqlDataAdapter(qry1, db.con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                db.con.Close();
                count();

            }
            else
            {

                string qry = "select * from students where yearr = '" + yearstxt.Text + "' and statuss is null";
                SqlDataAdapter da = new SqlDataAdapter(qry, db.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                db.con.Close();
                count();
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

            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;

            }
            else
            {

                e.Handled = true;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(contacttxt.Text))
            {
                MessageBox.Show("Fill properly");
                star1.Visible = true;
                star2.Visible = true;
                panel4.Enabled = false;

            }
            else if (string.IsNullOrEmpty(nametxt.Text))


            {
                MessageBox.Show("Fill properly");
                star1.Visible = true;
                star2.Visible = true;
                panel4.Enabled = false;

            }


            else
            {
                panel4.Enabled = true;

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


        public void comboteacher() {

            sql.Open();
            string Sqll = "select teachername from teacher";

            SqlCommand cmdd = new SqlCommand(Sqll, sql);
            SqlDataReader DRR = cmdd.ExecuteReader();

            while (DRR.Read())
            {
                teachertxt.Items.Add(DRR[0]);

            }

            sql.Close();

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            teacher();
            styleGridView();
            styleGridView1();
            styleGridView3();
            styleGridView2();
            styleGridView4();
            yeartxt.Text = "2021";

            String[] arr = {"2021","2022","2023","2024"};
            foreach (string item in arr)
            {
                yeartxt.Items.Add(item);
            }
           
          

           
            nametxt.Focus();


            //fetchyear();
            //course();
            //fetchcourse();
            //fetchteacher();
            //courses();
            //teacher();
            //stdgrid();
            //countall();
            //comboteacher();
            
           

            tabControl1.Visible = false;

        }

        public void teacher()
        {

            sql.Open();
            string qry = "select * from teacher";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
           

            sql.Close();
        }

        public void course()
        {


            sql.Open();
            string Sqll = "select coursename from course group by coursename";

            SqlCommand cmdd = new SqlCommand(Sqll, sql);
            SqlDataReader DRR = cmdd.ExecuteReader();

            while (DRR.Read())
            {
                coursetxt.Items.Add(DRR[0]);

            }

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
        private void button1_Click(object sender, EventArgs e)
        {
            nametxt.Focus();
            tabControl1.Visible = true;
            tabControl1.SelectTab(0);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Open();

                string start = startdatetxt.Text;
                string end = enddatetxt.Text;


                string qry = "insert into students(studentname,addresss,contactno,email,college,course,fees,teacher,yearr,startdate,enddate) values ('" + nametxt.Text + "','" + addresstxt.Text + "','" + contacttxt.Text + "','" + emailtxt.Text + "','" + collegetxt.Text + "','" + coursetxt.Text + "','" + feestxt.Text + "','" + teachertxt.Text + "','" + yeartxt.Text + "','" + start + "','" + end + "')";
                SqlCommand cmd = new SqlCommand(qry, sql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record added");
                label5.Visible = true;
                label5.Text = "STUDENT ADDED SUCCESSFULLY...!!";
                sql.Close();
                star1.Visible = false;
                star2.Visible = false;
                clear();
                ClearTextForm1();

                countall();


            }

            catch (Exception)
            {

            }


        }
        public void clear()
        {
            nametxt.Text = "";
            emailtxt.Text = "";
            contacttxt.Text = "";
            addresstxt.Text = "";
            coursetxt.Text = "";
            collegetxt.Text = "";
            feestxt.Text = "";
            teachertxt.Text = "";
            startdatetxt.Text = "";
            enddatetxt.Text = "";
            yeartxt.Text = "";


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

                MessageBox.Show("Invalid");
                panel6.Visible = false;
            }
            else
            {

                panel6.Visible = true;
                db.con.Open();
                sql.Open();

                try {

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
            string qry = "update  students set  feespaid = '" + stdpaidtxt.Text + "' ,feesrem = '" + stdremtxt.Text + "' where id = '" + idtxt.Text + "' ";

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
            contxt.Text = "";

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

        private void button15_Click(object sender, EventArgs e)
        {

            sql.Open();
            SqlCommand cmdd = new SqlCommand("Select coursename from course where coursename = '" + cnametxt.Text + "'", sql);
            SqlDataReader dr = cmdd.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("record already exists");

            }
            else
            {

                db.con.Open();
                string qry = "insert into course(coursename,coursefees,duration)values('" + cnametxt.Text + "','" + cfeestxt.Text + "','" + durationtxt.Text + "')";
                SqlCommand cmd = new SqlCommand(qry, db.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("COURSE ADDED");
                db.con.Close();

                cnametxt.Text = "";
                cfeestxt.Text = "";
                durationtxt.Text = "";

            }

            sql.Close();

            courses(); 
            fetchcourse();
            countall();
        }

        private void coursesearchtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
           // cnametxt.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            db.con.Open();
            string qry = "select * from admintrator where aduser = @User and adpassword = @Pass";
            SqlCommand cmd = new SqlCommand(qry, db.con);
            cmd.Parameters.AddWithValue("@User", aduser.Text);
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
        public void countall()
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
            string qry1 = "select count (id) from students where statuss is null";
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



        }

        private void button17_Click(object sender, EventArgs e)
        {
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
            try
            {
                feessearchtxt.Items.Clear();
                sql.Open();
                string qry = "insert into teacher values('" + tnametxt.Text + "','" + tqualitxt.Text + "','" + subjectxt.Text + "')";
                SqlCommand cmd = new SqlCommand(qry, sql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ADDED!");

                tnametxt.Text = "";
                tqualitxt.Text = "";
                subjectxt.Text = "";

                sql.Close();
                fetchteacher();
                countall();
                teacher();
            }
            catch (Exception) { 
            
            
            }
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sql.Open();

            string qry = "select id,studentname,email,fees,feespaid,contactno,course,college,feesrem from students where  statuss is null  and  studentname like '%" + searchfeestxt.Text + "%'  ";
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

        private void coursetxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coursetxt_TextChanged(object sender, EventArgs e)
        {
            sql.Open();
            string qry = "select coursefees from course where coursename = '" + coursetxt.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, sql);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                feestxt.Text = (dr["coursefees"].ToString());
            }

            sql.Close();
        }
        public void count()
        {

            label42.Text = dataGridView1.Rows.Count.ToString() + " RECORDS FOUND!";

        }

        private void teachersearchtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentnametxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
          {

            try
            {
                sql.Open();



                string qry = "select id,studentname, addresss, contactno, email, college, course,fees , feespaid,feesrem  from students where contactno = '" + contxt.Text + "' and statuss is null ";
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

        private void studentnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                dataGridView1.Focus();

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {

            countall();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
           // tnametxt.Focus();
        }

        private void contacttxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {





        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
       

        }

        public void ClearTextForm1()
        {
            nametxt.Text = "";
            contacttxt.Text = "";
            emailtxt.Text = "";
            addresstxt.Text = "";
            coursetxt.Text = "";
            collegetxt.Text = "";
            feestxt.Text = "";
            teachertxt.Text = "";
            startdatetxt.Text = "";
            enddatetxt.Text = "";
            yeartxt.Text = "";
        }

        private void contacttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;

            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;


            }
            else
            {
                e.Handled = true;
            }
            
        }

     

    
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { 
            string qry = "select id ,studentname,feespaid from students where fees = feespaid  and statuss is null";
            SqlDataAdapter da = new SqlDataAdapter(qry,sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Feespaidgrid.DataSource = dt;
            panel14.Visible = true; ;
            Feespaidgrid.Visible = true;

            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string qry = "select id,studentname,feesrem from students where statuss is null and feesrem > 0";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Feespaidgrid.DataSource = dt;
            panel14.Visible = true; ;
            Feespaidgrid.Visible = true;




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();

        }

        private void Feespaidgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


        public void styleGridView1()
        {
            Feespaidgrid.BorderStyle = BorderStyle.None;
            Feespaidgrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Feespaidgrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Feespaidgrid.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            Feespaidgrid.DefaultCellStyle.SelectionForeColor = Color.White;
            Feespaidgrid.BackgroundColor = Color.White;
            Feespaidgrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Feespaidgrid.EnableHeadersVisualStyles = false;
            Feespaidgrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Feespaidgrid.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans serif", 10);
            Feespaidgrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            Feespaidgrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
        public void styleGridView3()
        {
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans serif", 10);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void styleGridView4()
        {
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans serif", 10);
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void stdpaidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void stdremtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button21_Click_1(object sender, EventArgs e)
        {

        }

        private void button21_Click_2(object sender, EventArgs e)
        {
            teacher();
        }
    }


}