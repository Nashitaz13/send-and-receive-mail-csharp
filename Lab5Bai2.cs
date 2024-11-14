using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;


//install nuget MailKit and MimeKit to use IMAP 

namespace Lab5Bai12
{
    public partial class Lab5Bai2 : Form
    {
        public Lab5Bai2()
        {
            InitializeComponent();
        }
        private SmtpClient smtpClient;
        private void emailtbx_TextChanged(object sender, EventArgs e)
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
                // Kết nối tới IMAP server
                using (var client = new ImapClient())
                {
                    // Kết nối đến server IMAP của Gmail (Sử dụng SSL)
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(email, password);  // Sử dụng app password cho Gmail

                    // Truy cập Inbox
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);  // Mở Inbox ở chế độ chỉ đọc

                    // Cập nhật thông tin tổng số email và số email chưa đọc
                    totallb.Text = $"Total Emails: {inbox.Count}";
                    recentlb.Text = $"Recent Emails: {inbox.Recent}";

                    // Lấy danh sách email (giới hạn lấy 10 email gần nhất)
                    int limit = Math.Min(inbox.Count, 10); // Giới hạn số lượng email cần lấy
                    listView1.Items.Clear();  // Xóa danh sách cũ trước khi tải mới
                    for (int i = inbox.Count - 1; i >= inbox.Count - limit; i--)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem item = new ListViewItem(message.From.ToString());
                        item.SubItems.Add(message.Subject);
                        item.SubItems.Add(message.Date.ToString("dd/MM/yyyy HH:mm:ss"));
                        listView1.Items.Add(item);
                    }

                    // Đóng kết nối
                    client.Disconnect(true);

                    MessageBox.Show("Đăng nhập thành công và tải email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đăng nhập hoặc tải email thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void totallb_Click(object sender, EventArgs e)
        {

        }

        private void recentlb_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lab5Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
