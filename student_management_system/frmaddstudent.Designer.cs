
namespace student_management_system
{
    partial class frmaddstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddstudent));
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.yeartxt = new System.Windows.Forms.ComboBox();
            this.teachertxt = new System.Windows.Forms.ComboBox();
            this.feestxt = new System.Windows.Forms.TextBox();
            this.enddatetxt = new System.Windows.Forms.DateTimePicker();
            this.startdatetxt = new System.Windows.Forms.DateTimePicker();
            this.collegetxt = new System.Windows.Forms.ComboBox();
            this.coursetxt = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contacttxt = new System.Windows.Forms.TextBox();
            this.star2 = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.addresstxt = new System.Windows.Forms.RichTextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(-82, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1248, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "ADD NEW STUDENT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(545, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Education Detail";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.yeartxt);
            this.panel4.Controls.Add(this.teachertxt);
            this.panel4.Controls.Add(this.feestxt);
            this.panel4.Controls.Add(this.enddatetxt);
            this.panel4.Controls.Add(this.startdatetxt);
            this.panel4.Controls.Add(this.collegetxt);
            this.panel4.Controls.Add(this.coursetxt);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(549, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(468, 265);
            this.panel4.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Teal;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(321, 188);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 36);
            this.button8.TabIndex = 14;
            this.button8.Text = "SUBMIT";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // yeartxt
            // 
            this.yeartxt.FormattingEnabled = true;
            this.yeartxt.Location = new System.Drawing.Point(302, 120);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(121, 21);
            this.yeartxt.TabIndex = 12;
            // 
            // teachertxt
            // 
            this.teachertxt.FormattingEnabled = true;
            this.teachertxt.Location = new System.Drawing.Point(302, 75);
            this.teachertxt.Name = "teachertxt";
            this.teachertxt.Size = new System.Drawing.Size(121, 21);
            this.teachertxt.TabIndex = 10;
            // 
            // feestxt
            // 
            this.feestxt.Location = new System.Drawing.Point(302, 37);
            this.feestxt.Name = "feestxt";
            this.feestxt.Size = new System.Drawing.Size(121, 20);
            this.feestxt.TabIndex = 8;
            // 
            // enddatetxt
            // 
            this.enddatetxt.Location = new System.Drawing.Point(94, 155);
            this.enddatetxt.Name = "enddatetxt";
            this.enddatetxt.Size = new System.Drawing.Size(121, 20);
            this.enddatetxt.TabIndex = 13;
            // 
            // startdatetxt
            // 
            this.startdatetxt.Location = new System.Drawing.Point(94, 117);
            this.startdatetxt.Name = "startdatetxt";
            this.startdatetxt.Size = new System.Drawing.Size(121, 20);
            this.startdatetxt.TabIndex = 11;
            // 
            // collegetxt
            // 
            this.collegetxt.FormattingEnabled = true;
            this.collegetxt.Items.AddRange(new object[] {
            "IBA",
            "SZABIST",
            "DEGREE COLLEGE",
            "CITY"});
            this.collegetxt.Location = new System.Drawing.Point(94, 70);
            this.collegetxt.Name = "collegetxt";
            this.collegetxt.Size = new System.Drawing.Size(121, 21);
            this.collegetxt.TabIndex = 9;
            // 
            // coursetxt
            // 
            this.coursetxt.FormattingEnabled = true;
            this.coursetxt.Location = new System.Drawing.Point(94, 33);
            this.coursetxt.Name = "coursetxt";
            this.coursetxt.Size = new System.Drawing.Size(121, 21);
            this.coursetxt.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(254, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 16);
            this.label17.TabIndex = 6;
            this.label17.Text = "Year:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(234, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Teacher:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(254, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Fees:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "End Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Start Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "College:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 21.75F);
            this.label1.Location = new System.Drawing.Point(389, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADD NEW STUDENT";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.contacttxt);
            this.panel3.Controls.Add(this.star2);
            this.panel3.Controls.Add(this.star1);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.addresstxt);
            this.panel3.Controls.Add(this.emailtxt);
            this.panel3.Controls.Add(this.nametxt);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(11, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 265);
            this.panel3.TabIndex = 7;
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(314, 26);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(111, 20);
            this.contacttxt.TabIndex = 2;
            // 
            // star2
            // 
            this.star2.AutoSize = true;
            this.star2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star2.ForeColor = System.Drawing.Color.Red;
            this.star2.Location = new System.Drawing.Point(429, 31);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(15, 20);
            this.star2.TabIndex = 12;
            this.star2.Text = "*";
            this.star2.Visible = false;
            // 
            // star1
            // 
            this.star1.AutoSize = true;
            this.star1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star1.ForeColor = System.Drawing.Color.Red;
            this.star1.Location = new System.Drawing.Point(237, 27);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(15, 20);
            this.star1.TabIndex = 6;
            this.star1.Text = "*";
            this.star1.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Teal;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(345, 188);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 36);
            this.button9.TabIndex = 6;
            this.button9.Text = "NEXT";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(73, 137);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(250, 96);
            this.addresstxt.TabIndex = 5;
            this.addresstxt.Text = "";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(73, 69);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(163, 20);
            this.emailtxt.TabIndex = 3;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(73, 27);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(163, 20);
            this.nametxt.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Contact:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Personal Detail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 71);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmaddstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Name = "frmaddstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmaddstudent";
            this.Load += new System.EventHandler(this.frmaddstudent_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox yeartxt;
        private System.Windows.Forms.ComboBox teachertxt;
        private System.Windows.Forms.TextBox feestxt;
        private System.Windows.Forms.DateTimePicker enddatetxt;
        private System.Windows.Forms.DateTimePicker startdatetxt;
        private System.Windows.Forms.ComboBox collegetxt;
        private System.Windows.Forms.ComboBox coursetxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox contacttxt;
        private System.Windows.Forms.Label star2;
        private System.Windows.Forms.Label star1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.RichTextBox addresstxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}