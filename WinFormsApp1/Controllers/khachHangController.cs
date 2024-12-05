using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Controllers
{
    public class khachHangController
    {
        private string connectionString;

        public khachHangController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Models.KhachHang> LayDanhSachKhachHang()
        {
            return Models.KhachHang.LayDanhSachKhachHang(connectionString);
        }

        public List<string> LayDanhSachTenCongTy()
        {
            return Models.KhachHang.LayDanhSachTenCongTy(connectionString);
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            return KhachHang.ThemKhachHang(connectionString, khachHang);
        }

        public bool CapNhatKhachHang(KhachHang khachHang)
        {
            return KhachHang.CapNhatKhachHang(connectionString, khachHang);
        }

        public List<KhachHang> LocKhachHang(string attribute, string value)
        {
            return KhachHang.LocKhachHang(connectionString, attribute, value);
        }
        //kiểm tra mã hợp đồng tồn tại cả QLKH và QLHD
        public bool KiemTraMaHopDongTonTai(string maHopDong)
        {
            return HopDong.KiemTraMaHopDongTonTai(connectionString, maHopDong);
        }

        public bool KiemTraMaKhachHangTonTai(string maKhachHang)
        {
            return KhachHang.KiemTraMaKhachHangTonTai(connectionString, maKhachHang);
        }
        //kiểm tra số điện thoại trùng nhau khi thêm khách hàng
        public bool KiemTraSoDienThoaiTonTai(string soDienThoai)
        {
            return KhachHang.KiemTraSoDienThoaiTonTai(connectionString, soDienThoai);
        }
        //kiểm tra số điện thoại trùng nhau khi cập nhật khách hàng
        public bool KiemTraSoDienThoaiTonTaiTruKhachHang(string soDienThoai, string maKhachHang)
        {
            return KhachHang.KiemTraSoDienThoaiTonTaiTruKhachHang(connectionString, soDienThoai, maKhachHang);
        }


    }
}
