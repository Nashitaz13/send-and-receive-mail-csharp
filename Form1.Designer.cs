namespace Lab5Bai12
{
    partial class Bai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subjecttbx = new System.Windows.Forms.TextBox();
            this.totbx = new System.Windows.Forms.TextBox();
            this.fromtbx = new System.Windows.Forms.TextBox();
            this.bodytbx = new System.Windows.Forms.RichTextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.emailtbx = new System.Windows.Forms.TextBox();
            this.passwordtbx = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(484, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "From: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(484, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Body:";
            // 
            // subjecttbx
            // 
            this.subjecttbx.Enabled = false;
            this.subjecttbx.Location = new System.Drawing.Point(96, 139);
            this.subjecttbx.Name = "subjecttbx";
            this.subjecttbx.Size = new System.Drawing.Size(686, 22);
            this.subjecttbx.TabIndex = 4;
            this.subjecttbx.TextChanged += new System.EventHandler(this.subjecttbx_TextChanged);
            // 
            // totbx
            // 
            this.totbx.Enabled = false;
            this.totbx.Location = new System.Drawing.Point(542, 51);
            this.totbx.Name = "totbx";
            this.totbx.Size = new System.Drawing.Size(240, 22);
            this.totbx.TabIndex = 5;
            this.totbx.TextChanged += new System.EventHandler(this.totbx_TextChanged);
            // 
            // fromtbx
            // 
            this.fromtbx.Enabled = false;
            this.fromtbx.Location = new System.Drawing.Point(542, 20);
            this.fromtbx.Name = "fromtbx";
            this.fromtbx.Size = new System.Drawing.Size(240, 22);
            this.fromtbx.TabIndex = 6;
            this.fromtbx.TextChanged += new System.EventHandler(this.fromtbx_TextChanged);
            // 
            // bodytbx
            // 
            this.bodytbx.Enabled = false;
            this.bodytbx.Location = new System.Drawing.Point(96, 173);
            this.bodytbx.Name = "bodytbx";
            this.bodytbx.Size = new System.Drawing.Size(686, 316);
            this.bodytbx.TabIndex = 7;
            this.bodytbx.Text = "";
            this.bodytbx.TextChanged += new System.EventHandler(this.bodytbx_TextChanged);
            // 
            // sendbtn
            // 
            this.sendbtn.Enabled = false;
            this.sendbtn.Location = new System.Drawing.Point(617, 79);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(85, 52);
            this.sendbtn.TabIndex = 8;
            this.sendbtn.Text = "SEND";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // emailtbx
            // 
            this.emailtbx.Location = new System.Drawing.Point(96, 20);
            this.emailtbx.Name = "emailtbx";
            this.emailtbx.Size = new System.Drawing.Size(240, 22);
            this.emailtbx.TabIndex = 12;
            this.emailtbx.TextChanged += new System.EventHandler(this.emailtbx_TextChanged);
            // 
            // passwordtbx
            // 
            this.passwordtbx.Location = new System.Drawing.Point(96, 51);
            this.passwordtbx.Name = "passwordtbx";
            this.passwordtbx.PasswordChar = '*';
            this.passwordtbx.Size = new System.Drawing.Size(240, 22);
            this.passwordtbx.TabIndex = 11;
            this.passwordtbx.TextChanged += new System.EventHandler(this.passwordtbx_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.password.Location = new System.Drawing.Point(12, 51);
            this.password.Name = "password";
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password.Size = new System.Drawing.Size(79, 18);
            this.password.TabIndex = 10;
            this.password.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email:";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(169, 79);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(85, 52);
            this.loginbtn.TabIndex = 13;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 501);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.emailtbx);
            this.Controls.Add(this.passwordtbx);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.bodytbx);
            this.Controls.Add(this.fromtbx);
            this.Controls.Add(this.totbx);
            this.Controls.Add(this.subjecttbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Bai1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subjecttbx;
        private System.Windows.Forms.TextBox totbx;
        private System.Windows.Forms.TextBox fromtbx;
        private System.Windows.Forms.RichTextBox bodytbx;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.TextBox emailtbx;
        private System.Windows.Forms.TextBox passwordtbx;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button loginbtn;
    }
}

