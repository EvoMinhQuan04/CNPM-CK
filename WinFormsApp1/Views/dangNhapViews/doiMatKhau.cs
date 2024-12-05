// Views/doiMatKhau.cs
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class doiMatKhau : Form
    {
        private readonly string _username;
        private readonly doiMatKhauController _controller;
        private readonly string _connectionString;

        public doiMatKhau(string username, string connectionString)
        {
            InitializeComponent();
            _username = username;
            _connectionString = connectionString;
            _controller = new doiMatKhauController(connectionString);
        }

        private async void xacNhanDoi_Click(object sender, EventArgs e)
        {
            string matKhauMoi = matKhau1.Text;
            string matKhauNhapLai = matKhau2.Text;
            string matKhauPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$";
            if (!Regex.IsMatch(matKhauMoi, matKhauPattern))
            {
                thongBaoLoi.Text = "Mật khẩu phải có ít nhất 6 ký tự, bao gồm chữ hoa, chữ thường và số.";
                thongBaoLoi.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (!Regex.IsMatch(matKhauNhapLai, matKhauPattern))
            {
                thongBaoLoi.Text = "Mật khẩu phải có ít nhất 6 ký tự, bao gồm chữ hoa, chữ thường và số.";
                thongBaoLoi.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (matKhauMoi != matKhauNhapLai)
            {
                thongBaoLoi.Text = "Hai lần nhập mật khẩu không trùng nhau.";
                thongBaoLoi.ForeColor = Color.Red;
                return;
            }

            if (matKhauMoi.Length < 6)
            {
                thongBaoLoi.Text = "Mật khẩu phải có ít nhất 6 ký tự.";
                thongBaoLoi.ForeColor = Color.Red;
                return;
            }
            if (matKhauMoi != matKhauNhapLai)
            {
                thongBaoLoi.Text = "2 lần nhập không trùng nhau.";
                thongBaoLoi.ForeColor = Color.Red;
                return;
            }

            // Thực hiện cập nhật mật khẩu qua controller
            bool doiMatKhauThanhCong = _controller.DoiMatKhau(_username, matKhauMoi);

            if (doiMatKhauThanhCong)
            {
                thongBaoLoi.Text = "Đổi mật khẩu thành công!";
                thongBaoLoi.ForeColor = Color.Green;
                await Task.Delay(3000);

                // Tạo đối tượng dangNhapTaiKhoan với các tham số cần thiết
                var dangNhapController = new dangNhapTaiKhoanController(_connectionString);
                var dangNhapLai = new dangNhapTaiKhoan(dangNhapController, _connectionString);
                dangNhapLai.Show();
                this.Hide();
            }
            else
            {
                thongBaoLoi.Text = "Có lỗi xảy ra. Vui lòng thử lại.";
                thongBaoLoi.ForeColor = Color.Red;
            }
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
