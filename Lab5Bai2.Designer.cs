namespace Lab5Bai12
{
    partial class Lab5Bai2
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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.loginbtn = new System.Windows.Forms.Button();
            this.emailtbx = new System.Windows.Forms.TextBox();
            this.passwordtbx = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totallb = new System.Windows.Forms.Label();
            this.recentlb = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datatime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(598, 28);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(159, 52);
            this.loginbtn.TabIndex = 18;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // emailtbx
            // 
            this.emailtbx.Location = new System.Drawing.Point(102, 31);
            this.emailtbx.Name = "emailtbx";
            this.emailtbx.Size = new System.Drawing.Size(276, 22);
            this.emailtbx.TabIndex = 17;
            this.emailtbx.TextChanged += new System.EventHandler(this.emailtbx_TextChanged);
            // 
            // passwordtbx
            // 
            this.passwordtbx.Location = new System.Drawing.Point(102, 62);
            this.passwordtbx.Name = "passwordtbx";
            this.passwordtbx.PasswordChar = '*';
            this.passwordtbx.Size = new System.Drawing.Size(276, 22);
            this.passwordtbx.TabIndex = 16;
            this.passwordtbx.TextChanged += new System.EventHandler(this.passwordtbx_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.password.Location = new System.Drawing.Point(18, 62);
            this.password.Name = "password";
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password.Size = new System.Drawing.Size(79, 18);
            this.password.TabIndex = 15;
            this.password.Text = "Password:";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(18, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // totallb
            // 
            this.totallb.AutoSize = true;
            this.totallb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.totallb.Location = new System.Drawing.Point(18, 121);
            this.totallb.Name = "totallb";
            this.totallb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totallb.Size = new System.Drawing.Size(45, 18);
            this.totallb.TabIndex = 20;
            this.totallb.Text = "Total:";
            this.totallb.Click += new System.EventHandler(this.totallb_Click);
            // 
            // recentlb
            // 
            this.recentlb.AutoSize = true;
            this.recentlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.recentlb.Location = new System.Drawing.Point(301, 121);
            this.recentlb.Name = "recentlb";
            this.recentlb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.recentlb.Size = new System.Drawing.Size(55, 18);
            this.recentlb.TabIndex = 22;
            this.recentlb.Text = "Recent";
            this.recentlb.Click += new System.EventHandler(this.recentlb_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Email,
            this.From,
            this.Datatime});
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "Email";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 167);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(756, 271);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 280;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 249;
            // 
            // Datatime
            // 
            this.Datatime.Text = "Thời gian";
            this.Datatime.Width = 363;
            // 
            // Lab5Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.recentlb);
            this.Controls.Add(this.totallb);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.emailtbx);
            this.Controls.Add(this.passwordtbx);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label6);
            this.Name = "Lab5Bai2";
            this.Text = "Bài 2";
            this.Load += new System.EventHandler(this.Lab5Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox emailtbx;
        private System.Windows.Forms.TextBox passwordtbx;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totallb;
        private System.Windows.Forms.Label recentlb;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader Datatime;
    }
}