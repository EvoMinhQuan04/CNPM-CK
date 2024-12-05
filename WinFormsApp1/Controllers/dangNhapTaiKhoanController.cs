// Controllers/dangNhapTaiKhoanController.cs
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.UI;
using WinFormsApp1.Views;

namespace WinFormsApp1.Controllers
{
    public class dangNhapTaiKhoanController
    {
        private readonly string _connectionString;

        public dangNhapTaiKhoanController(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            var nguoiDung = new NguoiDungModel(taiKhoan, matKhau);
            return nguoiDung.KiemTraDangNhap(_connectionString, taiKhoan, matKhau);
        }
        public void MoTrangChu(Form formHienTai, string taiKhoanHoacEmail, string vaiTro)
        {
            // Mở trang chủ với các tham số cần thiết
            string tenNhanVien = LayTenHienThiGiaoDien(taiKhoanHoacEmail);

            var formTrangChu = new trangChu(tenNhanVien, _connectionString, vaiTro); // Sử dụng đúng tên lớp
            formTrangChu.Show();
            formHienTai.Hide(); 
        }

        public string LayTenHienThiGiaoDien(string taiKhoanHoacEmail)
        {
            var nguoiDung = new NguoiDungModel(taiKhoanHoacEmail, string.Empty); // Không cần mật khẩu để lấy tên
            return nguoiDung.LayTenHienThiGiaoDien(_connectionString, taiKhoanHoacEmail);
        }

        public string LayVaiTro(string taiKhoan)
        { 
            return NguoiDungModel.LayVaiTro(_connectionString, taiKhoan);
        }

    }
}
