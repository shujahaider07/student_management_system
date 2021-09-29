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

        }

        public void countall()
        {
            sql.Open();
            string qry = "select count (cid) from course where status is null";
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
            string qry2 = "select count (id) from TEACHER where status is null";
            SqlCommand cmd2 = new SqlCommand(qry2, sql);
            SqlDataReader reader1 = cmd2.ExecuteReader();
            while (reader1.Read())
            {

                label48.Text = reader1[0].ToString();

            }
            sql.Close();



        }


        SqlConnection sql = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");



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











        private void button1_Click(object sender, EventArgs e)
        {

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmaddstudent")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {
                frmaddstudent add = new frmaddstudent();

                add.Show();
            }


            

        }




        private void button3_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmsearchstudent")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {
                frmsearchstudent f = new frmsearchstudent();
                f.Show();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {


            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == " frmaddfees")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {
                frmaddfees add = new frmaddfees();
                add.Show();
            }


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmaddcourse")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {

                frmaddcourse course = new frmaddcourse();
                course.Show();
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmcourses")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {

                frmcourses c = new frmcourses();
                c.Show();



            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == " frmaddteacher")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {


                frmaddteacher t = new frmaddteacher();
                t.Show();
            }

           
        }

   private void button7_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == " frmteachers ")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {


                frmteachers t = new frmteachers();
                t.Show();
            }



           
        }



        private void button16_Click(object sender, EventArgs e)
        {
            
        }


        private void adpass_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void coursetxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coursetxt_TextChanged(object sender, EventArgs e)
        {

        }
        public void count()
        {

           // label42.Text = dataGridView1.Rows.Count.ToString() + " RECORDS FOUND!";

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

        private void button8_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmadminlogin")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {


                frmadminlogin f = new frmadminlogin();
                f.Show();
            }



           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countall();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            countall();
        }
    }
}

    
        
 