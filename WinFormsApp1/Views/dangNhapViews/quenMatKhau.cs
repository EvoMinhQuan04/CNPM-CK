// Views/quenMatKhau.cs
using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class quenMatKhau : Form
    {
        private readonly string _connectionString;
        private int verificationCode;
        private string userEmail;
        private string _username; // Thêm biến _username để lưu tên tài khoản

        public quenMatKhau(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void quenMatKhau_Load(object sender, EventArgs e)
        {
            thongBaoLoi.Text = "";
        }

        private async void btnGetVerificationCode_Click(object sender, EventArgs e)
        {
            _username = txtUsername.Text.Trim(); // Gán giá trị từ txtUsername.Text vào _username
            var nguoiDung = new NguoiDungModel(_username, "");

            if (string.IsNullOrEmpty(_username))
            {
                thongBaoLoi.Text = "Vui lòng nhập tên tài khoản hoặc email của bạn.";
                thongBaoLoi.ForeColor = Color.Red;
                return;
            }
            // Kiểm tra định dạng mã người dùng hoặc email
            bool isUsernameValid = Regex.IsMatch(_username, @"^[A-Z0-9]{3,5}$"); // 3-5 ký tự viết hoa
            bool isEmailValid = Regex.IsMatch(_username, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"); // Định dạng email

            if (!isUsernameValid && !isEmailValid)
            {
                thongBaoLoi.Text = "Nhập đúng định dạng tài khoản hoặc email.";
                thongBaoLoi.ForeColor = Color.Red;
                thongBaoLoi.Visible = true; // Hiển thị thông báo lỗi
                return;
            }
            try
            {
                // Hiển thị thông báo "Đang gửi mail..."
                thongBaoLoi.Text = "Đang gửi mail, vui lòng chờ...";
                thongBaoLoi.ForeColor = Color.Green;
                thongBaoLoi.Visible = true;

                // Lấy email từ bảng Quanlydangnhap bằng tên tài khoản hoặc email
                var (email, _) = nguoiDung.LayEmailVaMatKhau(_connectionString, _username);
                userEmail = email;

                // Tạo mã xác nhận
                verificationCode = new Random().Next(100000, 999999);

                // Gửi email (thực hiện bất đồng bộ)
                await Task.Run(() => GuiEmailXacNhan(userEmail, verificationCode));

                // Thông báo gửi thành công
                thongBaoLoi.Text = "Mã xác nhận đã được gửi đến email của bạn.";
                thongBaoLoi.ForeColor = Color.Green;
                thongBaoLoi.Visible = true;
            }
            catch (Exception ex)
            {
                thongBaoLoi.Text = ex.Message;
                thongBaoLoi.ForeColor = Color.Red;
            }
        }

        private void GuiEmailXacNhan(string toEmail, int verificationCode)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("vuonghades2004@gmail.com", "acpp wnqh qkdk ppzy"),
                    EnableSsl = true,
                };

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("vuonghades2004@gmail.com", "MÃ XÁC NHẬN ĐỔI MẬT KHẨU"),
                    Subject = "Mã xác nhận của bạn",
                    Body = $"Mã xác nhận của bạn là: {verificationCode}",
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(toEmail);

                // Gửi email
                client.Send(mailMessage);
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể gửi email. Lỗi: " + ex.Message);
            }
        }

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int enteredCode) && enteredCode == verificationCode)
            {
                // Mã xác thực đúng, mở form doiMatKhau
                var formDoiMatKhau = new doiMatKhau(_username, _connectionString);
                formDoiMatKhau.Show();
                this.Hide(); // Ẩn form quenMatKhau
            }
            else
            {
                thongBaoLoi.Text = "Mã xác nhận không đúng.";
                thongBaoLoi.ForeColor = Color.Red;
            }
        }

        private void quenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var loginController = new dangNhapTaiKhoanController(_connectionString);
            var loginForm = new dangNhapTaiKhoan(loginController, _connectionString);
            loginForm.Show(); // Show the login form as a dialog
            this.Hide();
        }
    }
}
