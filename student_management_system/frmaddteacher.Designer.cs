
namespace student_management_system
{
    partial class frmaddteacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddteacher));
            this.panel13 = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.subjectxt = new System.Windows.Forms.TextBox();
            this.tqualitxt = new System.Windows.Forms.TextBox();
            this.tnametxt = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.SHOWTEACHER = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.button19);
            this.panel13.Controls.Add(this.subjectxt);
            this.panel13.Controls.Add(this.tqualitxt);
            this.panel13.Controls.Add(this.tnametxt);
            this.panel13.Controls.Add(this.label58);
            this.panel13.Controls.Add(this.label57);
            this.panel13.Controls.Add(this.label56);
            this.panel13.Location = new System.Drawing.Point(161, 99);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(533, 353);
            this.panel13.TabIndex = 3;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Black;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(230, 279);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(98, 34);
            this.button19.TabIndex = 8;
            this.button19.Text = "ADD";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click_1);
            // 
            // subjectxt
            // 
            this.subjectxt.Location = new System.Drawing.Point(230, 220);
            this.subjectxt.Name = "subjectxt";
            this.subjectxt.Size = new System.Drawing.Size(195, 20);
            this.subjectxt.TabIndex = 2;
            // 
            // tqualitxt
            // 
            this.tqualitxt.Location = new System.Drawing.Point(230, 159);
            this.tqualitxt.Name = "tqualitxt";
            this.tqualitxt.Size = new System.Drawing.Size(195, 20);
            this.tqualitxt.TabIndex = 1;
            // 
            // tnametxt
            // 
            this.tnametxt.Location = new System.Drawing.Point(230, 89);
            this.tnametxt.Name = "tnametxt";
            this.tnametxt.Size = new System.Drawing.Size(195, 20);
            this.tnametxt.TabIndex = 0;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(129, 219);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(79, 19);
            this.label58.TabIndex = 4;
            this.label58.Text = "SUBJECT:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(76, 158);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(138, 19);
            this.label57.TabIndex = 3;
            this.label57.Text = "QUALIFICATION:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(76, 89);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(138, 19);
            this.label56.TabIndex = 2;
            this.label56.Text = "TEACHER NAME:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Rockwell", 21.75F);
            this.label55.Location = new System.Drawing.Point(335, 26);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(218, 32);
            this.label55.TabIndex = 2;
            this.label55.Text = "ADD TEACHER";
            // 
            // SHOWTEACHER
            // 
            this.SHOWTEACHER.BackColor = System.Drawing.Color.Black;
            this.SHOWTEACHER.FlatAppearance.BorderSize = 0;
            this.SHOWTEACHER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SHOWTEACHER.ForeColor = System.Drawing.Color.White;
            this.SHOWTEACHER.Location = new System.Drawing.Point(700, 399);
            this.SHOWTEACHER.Name = "SHOWTEACHER";
            this.SHOWTEACHER.Size = new System.Drawing.Size(98, 34);
            this.SHOWTEACHER.TabIndex = 9;
            this.SHOWTEACHER.Text = "show teachers";
            this.SHOWTEACHER.UseVisualStyleBackColor = false;
            this.SHOWTEACHER.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 65);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmaddteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SHOWTEACHER);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.label55);
            this.Name = "frmaddteacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmaddteacher";
            this.Load += new System.EventHandler(this.frmaddteacher_Load);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox subjectxt;
        private System.Windows.Forms.TextBox tqualitxt;
        private System.Windows.Forms.TextBox tnametxt;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button SHOWTEACHER;
    }
}