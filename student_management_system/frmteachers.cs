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
    public partial class frmteachers : Form
    {
        public frmteachers()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");
        private void frmteachers_Load(object sender, EventArgs e)
        {
            styleGridView4();
            teacher();
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

        private void button21_Click(object sender, EventArgs e)
        {
            teacher();
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

        private void button23_Click(object sender, EventArgs e)
        {
            teacher();
        }
    }
}
