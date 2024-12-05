using System;
using System.Windows.Forms;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class dangNhap : Form // Kế thừa từ Form
    {
        private readonly dangNhapController _controller;

        public dangNhap(dangNhapController controller)
        {
            InitializeComponent(); // Gọi InitializeComponent để thiết lập giao diện form
            _controller = controller;
        }

        // Sự kiện khi người dùng nhấn vào nút Đăng nhập tài khoản
        private void btnDangNhapTaiKhoan_Click(object sender, EventArgs e)
        {
            _controller.MoFormDangNhapTaiKhoan(); // Gọi controller để mở form đăng nhập tài khoản
            this.Hide(); // Ẩn form hiện tại
        }

        private void dangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Khi form đăng nhập đóng thì thoát ứng dụng 
        }
    }
}
