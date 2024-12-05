using System;
using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1.Controllers
{
    public class saoLuuPhucHoiController
    {
        private readonly SaoLuuPhucHoiModel _model;

        public saoLuuPhucHoiController(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _model = new SaoLuuPhucHoiModel(connectionString);
        }
        public DataTable LayLichSuTongHop(DateTime startTime, DateTime endTime, bool includeHopDong, bool includeKhachHang, bool includeMauQuanTrac)
        {
            var dataTable = new DataTable();

            // Lấy lịch sử hợp đồng
            if (includeHopDong)
                dataTable.Merge(_model.LayLichSuHopDong(startTime, endTime));

            // Lấy lịch sử khách hàng
            if (includeKhachHang)
                dataTable.Merge(_model.LayLichSuKhachHang(startTime, endTime));

            if (includeMauQuanTrac)
                dataTable.Merge(_model.LayLichSuMauQuanTrac(startTime, endTime));

            //// Lấy lịch sử phiếu kết quả
            //if (includePhieuKetQua)
            //    dataTable.Merge(_model.LayLichSuPhieuKetQua(startTime, endTime));

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
        /// <summary>
        /// Lấy dữ liệu tổng hợp dựa trên thời gian và các checkbox được chọn.
        /// </summary>
        /// <param name="selectedTime">Thời gian được chọn từ ComboBox.</param>
        /// <param name="includeHopDong">Có bao gồm lịch sử hợp đồng không?</param>
        /// <param name="includeKhachHang">Có bao gồm lịch sử khách hàng không?</param>
        /// <param name="includeMauQuanTrac">Có bao gồm lịch sử mẫu kiểm định không?</param>
        /// <param name="includePhieuKetQua">Có bao gồm lịch sử phiếu kết quả không?</param>
        /// <returns>Bảng dữ liệu tổng hợp để hiển thị.</returns>
        public DataTable LayDuLieuTongHop(string selectedTime, bool includeHopDong, bool includeKhachHang, bool includeMauQuanTrac)
        {
            // Gọi phương thức static LayKhoangThoiGian thông qua tên lớp
            var (startTime, endTime) =LayKhoangThoiGian(selectedTime);

            // Gọi hàm Model để lấy dữ liệu tổng hợp
            return LayLichSuTongHop(startTime, endTime, includeHopDong, includeKhachHang, includeMauQuanTrac);
        }
        public void PhucHoiDuLieu(string sourceTable, string targetTable, string primaryKeyColumn, object primaryKeyValue)
        {
            try
            {
                _model.PhucHoiDuLieu(sourceTable, targetTable, primaryKeyColumn, primaryKeyValue);
                MessageBox.Show("Phục hồi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi phục hồi dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
