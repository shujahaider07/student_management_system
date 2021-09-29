
namespace student_management_system
{
    partial class frmaddfees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddfees));
            this.panel14 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.ComboBox();
            this.batch = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label60 = new System.Windows.Forms.Label();
            this.searchfeestxt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.msglbl = new System.Windows.Forms.Label();
            this.stdaddtxt = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.stdcollegetxt = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.stdremtxt = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.stdpaidtxt = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.stdfeestxt = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.stdcoursetxt = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.stdemailtxt = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.stdmobtxt = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.stdnametxt = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label2);
            this.panel14.Controls.Add(this.label1);
            this.panel14.Controls.Add(this.year);
            this.panel14.Controls.Add(this.batch);
            this.panel14.Controls.Add(this.dataGridView4);
            this.panel14.Controls.Add(this.label60);
            this.panel14.Controls.Add(this.searchfeestxt);
            this.panel14.Location = new System.Drawing.Point(6, 173);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(763, 378);
            this.panel14.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "YEAR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "COURSE:";
            // 
            // year
            // 
            this.year.FormattingEnabled = true;
            this.year.Location = new System.Drawing.Point(322, 32);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(143, 21);
            this.year.TabIndex = 9;
            this.year.SelectedIndexChanged += new System.EventHandler(this.year_SelectedIndexChanged);
            // 
            // batch
            // 
            this.batch.FormattingEnabled = true;
            this.batch.Location = new System.Drawing.Point(91, 31);
            this.batch.Name = "batch";
            this.batch.Size = new System.Drawing.Size(143, 21);
            this.batch.TabIndex = 8;
            this.batch.SelectedIndexChanged += new System.EventHandler(this.batch_SelectedIndexChanged);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 75);
            this.dataGridView4.Name = "dataGridView4";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView4.Size = new System.Drawing.Size(757, 351);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(556, 50);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(63, 19);
            this.label60.TabIndex = 6;
            this.label60.Text = "search:";
            // 
            // searchfeestxt
            // 
            this.searchfeestxt.Location = new System.Drawing.Point(625, 49);
            this.searchfeestxt.Name = "searchfeestxt";
            this.searchfeestxt.Size = new System.Drawing.Size(113, 20);
            this.searchfeestxt.TabIndex = 1;
            this.searchfeestxt.TextChanged += new System.EventHandler(this.searchfeestxt_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(12, -3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 19);
            this.label24.TabIndex = 7;
            this.label24.Text = "PAY FEES";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label25.Font = new System.Drawing.Font("Rockwell", 21.75F);
            this.label25.Location = new System.Drawing.Point(637, 34);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(218, 32);
            this.label25.TabIndex = 10;
            this.label25.Text = "STUDENT FEES";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel6.Controls.Add(this.button14);
            this.panel6.Controls.Add(this.msglbl);
            this.panel6.Controls.Add(this.stdaddtxt);
            this.panel6.Controls.Add(this.label36);
            this.panel6.Controls.Add(this.stdcollegetxt);
            this.panel6.Controls.Add(this.label35);
            this.panel6.Controls.Add(this.stdremtxt);
            this.panel6.Controls.Add(this.label34);
            this.panel6.Controls.Add(this.stdpaidtxt);
            this.panel6.Controls.Add(this.label33);
            this.panel6.Controls.Add(this.stdfeestxt);
            this.panel6.Controls.Add(this.label32);
            this.panel6.Controls.Add(this.stdcoursetxt);
            this.panel6.Controls.Add(this.label31);
            this.panel6.Controls.Add(this.stdemailtxt);
            this.panel6.Controls.Add(this.label30);
            this.panel6.Controls.Add(this.stdmobtxt);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Controls.Add(this.stdnametxt);
            this.panel6.Controls.Add(this.label28);
            this.panel6.Controls.Add(this.label27);
            this.panel6.Location = new System.Drawing.Point(775, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(551, 659);
            this.panel6.TabIndex = 9;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Black;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(298, 458);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 6;
            this.button14.Text = "PAY";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // msglbl
            // 
            this.msglbl.AutoSize = true;
            this.msglbl.Font = new System.Drawing.Font("Calibri", 22.75F);
            this.msglbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.msglbl.Location = new System.Drawing.Point(160, 21);
            this.msglbl.Name = "msglbl";
            this.msglbl.Size = new System.Drawing.Size(246, 38);
            this.msglbl.TabIndex = 33;
            this.msglbl.Text = "Fees Already Paid!";
            this.msglbl.Visible = false;
            // 
            // stdaddtxt
            // 
            this.stdaddtxt.Enabled = false;
            this.stdaddtxt.Location = new System.Drawing.Point(276, 396);
            this.stdaddtxt.Name = "stdaddtxt";
            this.stdaddtxt.Size = new System.Drawing.Size(130, 20);
            this.stdaddtxt.TabIndex = 21;
            this.stdaddtxt.TextChanged += new System.EventHandler(this.stdaddtxt_TextChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(183, 395);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(91, 19);
            this.label36.TabIndex = 22;
            this.label36.Text = "ADD FEES:";
            // 
            // stdcollegetxt
            // 
            this.stdcollegetxt.FormattingEnabled = true;
            this.stdcollegetxt.Location = new System.Drawing.Point(383, 246);
            this.stdcollegetxt.Name = "stdcollegetxt";
            this.stdcollegetxt.Size = new System.Drawing.Size(130, 21);
            this.stdcollegetxt.TabIndex = 20;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(313, 241);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 19);
            this.label35.TabIndex = 19;
            this.label35.Text = "College:";
            // 
            // stdremtxt
            // 
            this.stdremtxt.Location = new System.Drawing.Point(383, 294);
            this.stdremtxt.Name = "stdremtxt";
            this.stdremtxt.ReadOnly = true;
            this.stdremtxt.Size = new System.Drawing.Size(130, 20);
            this.stdremtxt.TabIndex = 17;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(294, 294);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(92, 19);
            this.label34.TabIndex = 18;
            this.label34.Text = "Remaining:";
            // 
            // stdpaidtxt
            // 
            this.stdpaidtxt.Location = new System.Drawing.Point(153, 294);
            this.stdpaidtxt.Name = "stdpaidtxt";
            this.stdpaidtxt.ReadOnly = true;
            this.stdpaidtxt.Size = new System.Drawing.Size(130, 20);
            this.stdpaidtxt.TabIndex = 15;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(60, 293);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 19);
            this.label33.TabIndex = 16;
            this.label33.Text = "Paid Fees:";
            // 
            // stdfeestxt
            // 
            this.stdfeestxt.Location = new System.Drawing.Point(153, 246);
            this.stdfeestxt.Name = "stdfeestxt";
            this.stdfeestxt.ReadOnly = true;
            this.stdfeestxt.Size = new System.Drawing.Size(130, 20);
            this.stdfeestxt.TabIndex = 13;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(56, 244);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(88, 19);
            this.label32.TabIndex = 14;
            this.label32.Text = "Total Fees:";
            // 
            // stdcoursetxt
            // 
            this.stdcoursetxt.FormattingEnabled = true;
            this.stdcoursetxt.Location = new System.Drawing.Point(383, 202);
            this.stdcoursetxt.Name = "stdcoursetxt";
            this.stdcoursetxt.Size = new System.Drawing.Size(130, 21);
            this.stdcoursetxt.TabIndex = 12;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(313, 201);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 19);
            this.label31.TabIndex = 11;
            this.label31.Text = "Course:";
            // 
            // stdemailtxt
            // 
            this.stdemailtxt.Location = new System.Drawing.Point(154, 202);
            this.stdemailtxt.Name = "stdemailtxt";
            this.stdemailtxt.ReadOnly = true;
            this.stdemailtxt.Size = new System.Drawing.Size(130, 20);
            this.stdemailtxt.TabIndex = 9;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(84, 203);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(61, 19);
            this.label30.TabIndex = 10;
            this.label30.Text = "E-Mail:";
            // 
            // stdmobtxt
            // 
            this.stdmobtxt.Location = new System.Drawing.Point(383, 155);
            this.stdmobtxt.Name = "stdmobtxt";
            this.stdmobtxt.ReadOnly = true;
            this.stdmobtxt.Size = new System.Drawing.Size(130, 20);
            this.stdmobtxt.TabIndex = 7;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(313, 156);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 19);
            this.label29.TabIndex = 8;
            this.label29.Text = "Mobile:";
            // 
            // stdnametxt
            // 
            this.stdnametxt.Location = new System.Drawing.Point(154, 154);
            this.stdnametxt.Name = "stdnametxt";
            this.stdnametxt.ReadOnly = true;
            this.stdnametxt.Size = new System.Drawing.Size(130, 20);
            this.stdnametxt.TabIndex = 6;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(30, 154);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(118, 19);
            this.label28.TabIndex = 6;
            this.label28.Text = "Student Name:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 87);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(157, 19);
            this.label27.TabIndex = 3;
            this.label27.Text = "Student Fees Details";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.button13);
            this.panel5.Controls.Add(this.idtxt);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Location = new System.Drawing.Point(6, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 74);
            this.panel5.TabIndex = 8;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(265, 26);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 5;
            this.button13.Text = "VIEW";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(109, 29);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(134, 20);
            this.idtxt.TabIndex = 4;
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(12, 25);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 19);
            this.label26.TabIndex = 3;
            this.label26.Text = "Student ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(570, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 56);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 87);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmaddfees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "frmaddfees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmaddfees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmaddfees_Load);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox searchfeestxt;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox stdaddtxt;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox stdcollegetxt;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox stdremtxt;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox stdpaidtxt;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox stdfeestxt;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox stdcoursetxt;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox stdemailtxt;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox stdmobtxt;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox stdnametxt;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox batch;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.Label msglbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}