
namespace student_management_system
{
    partial class frmsearchstudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsearchstudent));
            this.label42 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teachersearchtxt = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.coursesearchtxt = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.studentnametxt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.yearstxt = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Rockwell", 14F);
            this.label42.ForeColor = System.Drawing.Color.LimeGreen;
            this.label42.Location = new System.Drawing.Point(518, 76);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(0, 21);
            this.label42.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 367);
            this.dataGridView1.TabIndex = 28;
            // 
            // teachersearchtxt
            // 
            this.teachersearchtxt.FormattingEnabled = true;
            this.teachersearchtxt.Location = new System.Drawing.Point(590, 150);
            this.teachersearchtxt.Name = "teachersearchtxt";
            this.teachersearchtxt.Size = new System.Drawing.Size(119, 21);
            this.teachersearchtxt.TabIndex = 27;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(535, 151);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 15);
            this.label23.TabIndex = 26;
            this.label23.Text = "Teacher:";
            // 
            // coursesearchtxt
            // 
            this.coursesearchtxt.FormattingEnabled = true;
            this.coursesearchtxt.Location = new System.Drawing.Point(373, 148);
            this.coursesearchtxt.Name = "coursesearchtxt";
            this.coursesearchtxt.Size = new System.Drawing.Size(119, 21);
            this.coursesearchtxt.TabIndex = 23;
            this.coursesearchtxt.SelectedIndexChanged += new System.EventHandler(this.coursesearchtxt_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(318, 149);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 15);
            this.label21.TabIndex = 22;
            this.label21.Text = "Course:";
            // 
            // studentnametxt
            // 
            this.studentnametxt.Location = new System.Drawing.Point(151, 149);
            this.studentnametxt.Name = "studentnametxt";
            this.studentnametxt.Size = new System.Drawing.Size(159, 20);
            this.studentnametxt.TabIndex = 21;
            this.studentnametxt.TextChanged += new System.EventHandler(this.studentnametxt_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(59, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 15);
            this.label20.TabIndex = 20;
            this.label20.Text = "Student Name";
            // 
            // yearstxt
            // 
            this.yearstxt.FormattingEnabled = true;
            this.yearstxt.Items.AddRange(new object[] {
            "ALL"});
            this.yearstxt.Location = new System.Drawing.Point(106, 91);
            this.yearstxt.Name = "yearstxt";
            this.yearstxt.Size = new System.Drawing.Size(119, 21);
            this.yearstxt.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(59, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "YEAR";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Rockwell", 21.75F);
            this.label18.Location = new System.Drawing.Point(401, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(265, 32);
            this.label18.TabIndex = 17;
            this.label18.Text = "SEARCH STUDENT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 56);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // frmsearchstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.teachersearchtxt);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.coursesearchtxt);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.studentnametxt);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.yearstxt);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Name = "frmsearchstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsearchstudent";
            this.Load += new System.EventHandler(this.frmsearchstudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox teachersearchtxt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox coursesearchtxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox studentnametxt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox yearstxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}