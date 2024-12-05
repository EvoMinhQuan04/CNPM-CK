using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Controllers
{
    
    public class hopDongController
    {
        public readonly String connectionString;
        public hopDongController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<HopDong> LayDanhSachHopDong()
        {
            return HopDong.LayDanhSachHopDong(connectionString);
        }
         
        public bool ThemHopDong(HopDong hopDong)
        {
            return HopDong.ThemHopDong(connectionString, hopDong);
        }

        public bool CapNhatHopDong(HopDong hopDong)
        {
            return HopDong.CapNhatHopDong(connectionString, hopDong);
        }

        public List<HopDong> LocHopDong(string attribute, string value, DateTime? ngayLap, DateTime? ngayKetThuc)
        {
            // Gọi phương thức LocHopDong của lớp HopDong để thực hiện truy vấn
            return HopDong.LocHopDong(connectionString, attribute, value, ngayLap, ngayKetThuc);
        }

        public List<HopDong> LayHopDongTreHan()
        {
            return HopDong.LayHopDongTreHan(connectionString);
        }

        public List<DateTime> LayDanhSachNgay(string columnName)
        {
            return HopDong.LayDanhSachNgay(connectionString, columnName);
        }

        public void CapNhatTrangThaiTreHan()
        {
            HopDong.CapNhatTrangThaiTreHan(connectionString);
        }
        //kiểm tra mã hợp đồng tồn tại cả QLKH và QLHD
        public bool KiemTraMaHopDongTonTai(string maHopDong)
        {
            return HopDong.KiemTraMaHopDongTonTai(connectionString, maHopDong);
        }
        //kiểm tra mã hợp đồng tồn tại trong mỗi QLHD
        public bool KiemTraMaHopDongTonTaiTrongQLHD(string maHopDong)
        {
            return HopDong.KiemTraMaHopDongTonTaiTrongQLHD(connectionString, maHopDong);
        }
        public bool KiemTraMaNhanVienTonTai(string maNhanVien)
        {
            return HopDong.KiemTraMaNhanVienTonTai(connectionString, maNhanVien);
        }
        public bool KiemTraMaKhachHangTonTai(string maKhachHang)
        {
            return HopDong.KiemTraMaKhachHangTonTai(connectionString, maKhachHang);
        }
        //kiểm tra mã hợp đồng và mã kh phải trùng nhau khi đã có khách hàng này cùng với mã này trước đó
        public bool KiemTraMaHopDongVaMaKhachHangTonTai(string maHopDong, string maKhachHang)
        {
            return HopDong.KiemTraMaHopDongVaMaKhachHangTonTai(connectionString, maHopDong, maKhachHang);
        }
        public bool KiemTraHopDongKhongPhuHop(string maHopDong, string maKhachHang)
        {
            return HopDong.KiemTraHopDongKhongPhuHop(connectionString, maHopDong, maKhachHang);
        }

    }
}
