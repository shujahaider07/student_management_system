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
        public static int res = 0;

        private void ADMIN_Load(object sender, EventArgs e)
        {
         
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms) {
                if (f.Text == "frmadminstudent") {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {

                adminyear f = new adminyear();
                f.Show();
            }
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmadminteacher")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {


                frmadminteacher t = new frmadminteacher();
                t.Show();
              
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmadmincourses")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isopen == false)
            {

                frmadmincourses c = new frmadmincourses();
                c.Show();
            }



           
        }
    }
}