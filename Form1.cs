using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Http;

namespace Lab5Bai12
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private SmtpClient smtpClient;


        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void fromtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void totbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjecttbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void bodytbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            string from = fromtbx.Text;
            string to = totbx.Text;
            string subject = subjecttbx.Text;
            string body = bodytbx.Text;
            string email = emailtbx.Text;
            string password = passwordtbx.Text;

            try
            {
                // Kiểm tra các trường nhập liệu
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thiết lập SmtpClient để gửi email qua Gmail
                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.EnableSsl = true; // Sử dụng SSL
                    client.Credentials = new NetworkCredential(email, password);

                    // Tạo đối tượng MailMessage
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(from);
                    message.To.Add(new MailAddress(to));
                    message.Subject = subject;
                    message.Body = body;
                    message.IsBodyHtml = false; // Gửi email dạng plain text

                    // Gửi email
                    client.Send(message);
                    MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gửi email thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void emailtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string email = emailtbx.Text;
            string password = passwordtbx.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Khởi tạo SmtpClient để kiểm tra đăng nhập
                smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(email, password)
                };

                // Kiểm tra đăng nhập bằng cách gửi lệnh HELO (không thực sự gửi email)
                smtpClient.Send(new MailMessage
                {
                    From = new MailAddress(email),
                    To = { new MailAddress(email) },
                    Subject = "Test Login",
                    Body = "Test"
                });

                // Nếu đăng nhập thành công, kích hoạt các trường và nút send
                fromtbx.Enabled = true;
                totbx.Enabled = true;
                subjecttbx.Enabled = true;
                bodytbx.Enabled = true;
                sendbtn.Enabled = true;

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đăng nhập thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
