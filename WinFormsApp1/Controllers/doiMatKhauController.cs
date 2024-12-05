// Controllers/doiMatKhauController.cs
using WinFormsApp1.Models;

namespace WinFormsApp1.Controllers
{
    public class doiMatKhauController
    {
        private readonly string _connectionString;

        public doiMatKhauController(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Phương thức đổi mật khẩu
        public bool DoiMatKhau(string taiKhoanHoacEmail, string matKhauMoi)
        {
            var nguoiDung = new NguoiDungModel(taiKhoanHoacEmail, "");
            return nguoiDung.CapNhatMatKhau(_connectionString, taiKhoanHoacEmail, matKhauMoi);
        }
    }
}
