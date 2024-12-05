using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Controllers
{
    public class nhanVienController
    {
        private readonly string _connectionString;

        public nhanVienController(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<NhanVien> LayDanhSachNhanVien()
        {
            return NhanVien.LayDanhSachNhanVien(_connectionString);
        }

        public bool ThemNhanVien(NhanVien nhanVien)
        {
            return NhanVien.ThemNhanVien(nhanVien, _connectionString);
        }

        public bool CapNhatNhanVien(NhanVien nhanVien)
        {
            return NhanVien.CapNhatNhanVien(nhanVien, _connectionString);
        }

        public List<NhanVien> LocNhanVien(string attribute, string value)
        {
            return NhanVien.LocNhanVien(_connectionString, attribute, value);
        }

        public bool kiemTraMaNhanVienTonTai(string maNhanVien)
        {
            return NhanVien.KiemTraMaNhanVienTonTai(maNhanVien, _connectionString);
        }

        public bool kiemTraSoDienThoaiTonTai(string soDienThoai)
        {
            return NhanVien.KiemTraSoDienThoaiTonTai(soDienThoai, _connectionString);
        }
        //kiểm tra số điện thoại trùng khi chỉnh sửa nhân viên
        public bool kiemTraSoDienThoaiTonTaiTruNhanVien(string soDienThoai, string maNhanVien)
        {
            return NhanVien.KiemTraSoDienThoaiTonTaiTruNhanVien(soDienThoai, maNhanVien, _connectionString);
        }

        public bool GuiThongBaoQuaEmail(string email, string subject, string messageBody, List<string> attachmentPaths)
        {
            return NhanVien.GuiThongBaoQuaEmail(email, subject, messageBody, attachmentPaths);
        }

        public List<(int Thang, int SoHoanThanh, int SoDangHoatDong, int SoTreHan)> LayThongKeTheoQuy(string maNhanVien, int quy, int nam)
        {
            return NhanVien.LayThongKeTheoQuy(_connectionString, maNhanVien, quy, nam);
        }

        public List<(int Thang, int SoHoanThanh, int SoDangHoatDong, int SoTreHan)> LayThongKeCtyTheoQuy(int quy, int nam)
        {
            return NhanVien.LayThongKeCtyTheoQuy(_connectionString, quy, nam);
        }

        public NhanVien TimKiemNhanVienTheoMaHoacTen(string tuKhoa)
        {
            // Gọi hàm từ lớp Model (ví dụ: lớp NhanVien)
            return NhanVien.TimKiemNhanVienTheoMaHoacTen(_connectionString, tuKhoa);
        }


        public int TinhTongHopDongCongTy()
        {
            return NhanVien.TinhTongHopDong(_connectionString);
        }

        public int TinhTongHopDongTrongQuyCuaCongTy(int quy, int nam)
        {
            return NhanVien.TinhTongHopDongTrongQuyCuaCongTy(_connectionString, quy, nam);
        }
        //lịch sử
        public DataTable LayLichSuTongHop(DateTime startTime, DateTime endTime, bool includeHopDong, bool includeKhachHang, bool includeMauQuanTrac, bool includePhieuKetQua)
        {
            var dataTable = new DataTable();

            // Lấy lịch sử hợp đồng
            if (includeHopDong)
                dataTable.Merge(NhanVien.LayLichSuHopDong(startTime, endTime, _connectionString));

            // Lấy lịch sử khách hàng
            if (includeKhachHang)
                dataTable.Merge(NhanVien.LayLichSuKhachHang(startTime, endTime, _connectionString));

            // Lấy lịch sử mẫu quan trắc
            if (includeMauQuanTrac)
                dataTable.Merge(NhanVien.LayLichSuMauQuanTrac(startTime, endTime, _connectionString));

            // Lấy lịch sử phiếu kết quả
            if (includePhieuKetQua)
                dataTable.Merge(NhanVien.LayLichSuPhieuKetQua(startTime, endTime, _connectionString));

            return dataTable;
        }

        public (DateTime startTime, DateTime endTime) LayKhoangThoiGian(string selectedTimeRange)
        {
            var now = DateTime.Now;
            switch (selectedTimeRange)
            {
                case "1 giờ trước":
                    return (now.AddHours(-1), now);
                case "1 ngày trước":
                    return (now.AddDays(-1), now);
                case "1 tuần trước":
                    return (now.AddDays(-7), now);
                case "4 tuần trước":
                    return (now.AddDays(-28), now);
                default:
                    throw new ArgumentException("Khoảng thời gian không hợp lệ.");
            }
        }


    }
}
