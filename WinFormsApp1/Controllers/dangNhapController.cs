// Controllers/dangNhapController.cs
using System.Windows.Forms;
using WinFormsApp1.Views;
using WinFormsApp1.Controllers; // Đảm bảo rằng bạn có tham chiếu đến các controller cần thiết

namespace WinFormsApp1.Controllers
{
    public class dangNhapController
    {
        private readonly string _connectionString;

        public dangNhapController(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Phương thức để mở form đăng nhập tài khoản
        public void MoFormDangNhapTaiKhoan()
        {
            // Tạo một instance của dangNhapTaiKhoanController và truyền vào dangNhapTaiKhoan
            var dangNhapTaiKhoanCtrl = new dangNhapTaiKhoanController(_connectionString);
            var formDangNhapTaiKhoan = new dangNhapTaiKhoan(dangNhapTaiKhoanCtrl, _connectionString);
            formDangNhapTaiKhoan.Show();
        }
    }
}
