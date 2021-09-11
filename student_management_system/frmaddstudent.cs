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
    public partial class frmaddstudent : Form
    {
        public frmaddstudent()
        {
            InitializeComponent();
            teachertxt.KeyUp += Teachertxt_KeyUp;
            coursetxt.TextChanged += Coursetxt_TextChanged;
            nametxt.KeyUp += Nametxt_KeyUp;
            contacttxt.KeyUp += Contacttxt_KeyUp;
            emailtxt.KeyUp += Emailtxt_KeyUp;
            button9.KeyUp += Button9_KeyUp;
            feestxt.KeyUp += Feestxt_KeyUp;
            collegetxt.KeyUp += Collegetxt_KeyUp;
            startdatetxt.KeyUp += Startdatetxt_KeyUp;
            yeartxt.KeyUp += Yeartxt_KeyUp;
            enddatetxt.KeyUp += Enddatetxt_KeyUp;
            addresstxt.KeyUp += Addresstxt_KeyUp;
            coursetxt.KeyUp += Coursetxt_KeyUp;
        }

        private void Coursetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                feestxt.Focus();
            }
        }

        private void Addresstxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button9.Focus();
            }
        }

        private void Enddatetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button8.Focus();
            }
        }

        private void Yeartxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enddatetxt.Focus();
            }
        }

        private void Startdatetxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                yeartxt.Focus();
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

        private void Button9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                coursetxt.Focus();
            }
        }

        private void Emailtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addresstxt.Focus();
            }
        }

        private void Contacttxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                emailtxt.Focus();
            }
        }

        private void Nametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                contacttxt.Focus();
            }
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

        private void Coursetxt_TextChanged(object sender, EventArgs e)
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

        public void comboteacher()
        {

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


        private void Teachertxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startdatetxt.Focus();

            }
        }

        SqlConnection sql = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");
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

               // countall();


            }

            catch (Exception)
            {

            }


        }
       

        private void frmaddstudent_Load(object sender, EventArgs e)
        {
            comboteacher();
            course();
            yeartxt.Text = "2021";

            String[] arr = { "2021", "2022", "2023", "2024" };
            foreach (string item in arr)
            {
                yeartxt.Items.Add(item);
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
