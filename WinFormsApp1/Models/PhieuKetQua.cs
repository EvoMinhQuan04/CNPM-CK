using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WinFormsApp1.Views.quanLyPhieuTraHangViews;
namespace WinFormsApp1.Models
{
    public class PhieuKetQua
    {
        public int? MaPhieuKetQua { get; set; }
        public string? MaMauThu { get; set; }
        public string? MaHopDong { get; set; }
        public DateTime NgayLayMau { get; set; }
        public DateTime NgayTraKetQua { get; set; }
        public string? TrangThaiKetQuaPhanTich { get; set; }
        public string? TrangThaiXuLy { get; set; }

        // Lấy danh sách phiếu kết quả từ database
        public static List<PhieuKetQua> LayDanhSachPhieuKetQua(string connectionString)
        {
            var danhSach = new List<PhieuKetQua>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Phieuketqua";
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new PhieuKetQua
                        {
                            MaPhieuKetQua = Convert.ToInt32(reader["Maphieuketqua"]),
                            MaMauThu = reader["Mamauthu"].ToString(),
                            MaHopDong = reader["Mahopdong"].ToString(),
                            NgayLayMau = Convert.ToDateTime(reader["Ngaylaymau"]),
                            NgayTraKetQua = Convert.ToDateTime(reader["Ngaytraketqua"]),
                            TrangThaiKetQuaPhanTich = reader["Trangthaiketquaphantich"].ToString(),
                            TrangThaiXuLy = reader["Trangthaixuly"].ToString()
                        });
                    }
                }
            }
            return danhSach;
        }

        // Cập nhật phiếu kết quả
        public static bool CapNhatKetQuaPhieuTraHang(string connectionString, int maPhieuKetQua)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                UPDATE Phieuketqua
                SET Trangthaiketquaphantich = N'Đã có kết quả', Trangthaixuly = N'Đã xử lý'
                WHERE Maphieuketqua = @MaPhieuKetQua";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuKetQua", maPhieuKetQua);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        
        //tự động tạo phiếu trả hàng khi có mẫu quan trắc được tạo
        public static bool ThemPhieuKetQuaTuMauQuanTrac(string connectionString, MauQuanTrac mauQuanTrac)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                INSERT INTO Phieuketqua (Mamauthu, Mahopdong, Ngaylaymau, Ngaytraketqua, Trangthaiketquaphantich, Trangthaixuly)
                VALUES (@Mamauthu, @Mahopdong, @Ngaylaymau, @Ngaytraketqua, @Trangthaiketquaphantich, @Trangthaixuly)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Mamauthu", mauQuanTrac.MaMau);
                    cmd.Parameters.AddWithValue("@Mahopdong", mauQuanTrac.MaHopDong);
                    cmd.Parameters.AddWithValue("@Ngaylaymau", mauQuanTrac.NgayLay);
                    cmd.Parameters.AddWithValue("@Ngaytraketqua", mauQuanTrac.NgayTra);
                    cmd.Parameters.AddWithValue("@Trangthaiketquaphantich", "Chưa có kết quả"); 
                    cmd.Parameters.AddWithValue("@Trangthaixuly", "Chưa xử lý"); 

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            }
        }
        //kiểm tra phiếu kết quả đã tồn tại hay chưa
        public static bool KiemTraPhieuKetQuaTonTai(string connectionString, string maMauThu)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(*) FROM Phieuketqua WHERE Mamauthu = @Mamauthu";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Mamauthu", maMauThu);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; 
                }
            }
        }
        //thêm dữ liệu vào bảng chi tiết thông số
        public static bool ThemChiTietThongSo(
            string connectionString,
            int maPhieuKetQua,
            string thongSo,
            string donVi,
            string phuongPhap,
            string ketQuaPTN,
            string ketQuaHT,
            string quyChuanSoSanh)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                INSERT INTO Chitietthongso (Maphieuketqua, Thongso, Donvi, KetquaPTN, KetquaHT, Phuongphapphantich, Quychuansosanh)
                VALUES (@MaPhieuKetQua, @ThongSo, @DonVi, @KetquaPTN, @KetquaHT, @PhuongPhapPhanTich, @QuychuanSoSanh)";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuKetQua", maPhieuKetQua);
                    cmd.Parameters.AddWithValue("@ThongSo", thongSo);
                    cmd.Parameters.AddWithValue("@DonVi", donVi);
                    cmd.Parameters.AddWithValue("@KetquaPTN", ketQuaPTN);
                    cmd.Parameters.AddWithValue("@KetquaHT", ketQuaHT);
                    cmd.Parameters.AddWithValue("@PhuongPhapPhanTich", phuongPhap);
                    cmd.Parameters.AddWithValue("@QuychuanSoSanh", quyChuanSoSanh);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        //cập nhật dữ liệu vào bảng chi tiết thông số
        public static bool CapNhatChiTietThongSo(
            string connectionString,
            int maPhieuKetQua,
            string thongSo,
            string donVi,
            string phuongPhap,
            string ketQuaPTN,
            string ketQuaHT,
            string quyChuanSoSanh)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                UPDATE Chitietthongso
                SET Thongso = @ThongSo,
                    Donvi = @DonVi,
                    Phuongphapphantich = @PhuongPhap,
                    KetquaPTN = @KetquaPTN,
                    KetquaHT = @KetquaHT,
                    Quychuansosanh = @QuychuanSoSanh
                 WHERE Maphieuketqua = @MaPhieuKetQua AND Thongso = @Thongso;";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ThongSo", thongSo);
                    cmd.Parameters.AddWithValue("@DonVi", donVi);
                    cmd.Parameters.AddWithValue("@PhuongPhap", phuongPhap);
                    cmd.Parameters.AddWithValue("@KetquaPTN", ketQuaPTN);
                    cmd.Parameters.AddWithValue("@KetquaHT", ketQuaHT);
                    cmd.Parameters.AddWithValue("@QuychuanSoSanh", quyChuanSoSanh);
                    cmd.Parameters.AddWithValue("@MaPhieuKetQua", maPhieuKetQua);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        //lấy dữ liệu từ bảng Chitietthongso
        public static DataTable LayChiTietThongSo(string connectionString, int maPhieuKetQua)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT Thongso, Donvi, Phuongphapphantich, KetquaPTN, KetquaHT, Quychuansosanh
                FROM Chitietthongso
                WHERE Maphieuketqua = @MaPhieuKetQua";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuKetQua", maPhieuKetQua);
                    var adapter = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        //kiểm tra thuộc tính trong bảng chi tiết thông số đã được lưu hay chưa
        public static bool KiemTraThuocTinhDaTonTai(string connectionString, int maPhieuKetQua, string thongSo)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT COUNT(*) 
                FROM Chitietthongso 
                WHERE Maphieuketqua = @MaPhieuKetQua AND Thongso = @ThongSo";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuKetQua", maPhieuKetQua);
                    cmd.Parameters.AddWithValue("@ThongSo", thongSo);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        //kiểm tra hợp lý đơn vị của thuộc tính
        public static bool KiemTraDonViHopLe(string thongSo, string donVi)
        {
            
            // Danh sách các thông số và đơn vị hợp lệ cho từng loại mẫu
            var thongSoDonViHopLe = new Dictionary<string, string[]>
            {
                // Nước thải
                { "Lưu lượng", new[] { "m³/h" } },
                { "Nhiệt độ", new[] { "°C" } },
                { "Độ màu", new[] { "Pt-Co" } },
                { "pH", new[] { "-" } },
                { "TSS", new[] { "mg/L" } },
                { "COD", new[] { "mg/L" } },
                { "NH₄⁺", new[] { "mg/L" } },
                { "Tổng Phốtpho", new[] { "mg/L" } },
                { "Tổng Nito", new[] { "mg/L" } },
                { "TOC", new[] { "mg/L" } },
                { "Clo dư", new[] { "mg/L" } },

                // Nước mặt
                { "DO", new[] { "mg/L" } },
                { "NO₃⁻", new[] { "mg/L" } },
                { "PO₄³⁻", new[] { "mg/L" } },
                { "Tổng P", new[] { "mg/L" } },
                { "Tổng N", new[] { "mg/L" } },

                // Không khí
                { "NO₂", new[] { "µg/Nm³", "ppb" } },
                { "CO", new[] { "µg/Nm³", "ppb" } },
                { "SO₂", new[] { "µg/Nm³", "ppb" } },
                { "O₃", new[] { "µg/Nm³", "ppb" } },
                { "Bụi PM₁₀", new[] { "µg/Nm³"} },
                { "Bụi PM₂.₅", new[] { "µg/Nm³"} },

                // Đất
                { "Độ ẩm", new[] { "%" } },
                { "Kim loại nặng", new[] { "mg/kg" } },
                { "Độ dẫn điện", new[] { "µS/cm" } }
            };

            // Kiểm tra tính hợp lệ của đơn vị
            if (thongSoDonViHopLe.TryGetValue(thongSo, out string[] donViHopLe))
            {
                return donViHopLe.Contains(donVi);
            }

            return false;
        }
        //các hàm cho xuất phiếu kết quả ra file pdf
        // Lấy thông tin phiếu kết quả từ database
        public static DataTable GetPhieuKetQua(int maPhieuKetQua ,string _connectionString)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = @"
                SELECT 
                    pk.Maphieuketqua, pk.Mamauthu, pk.Mahopdong, pk.Ngaylaymau, pk.Ngaytraketqua,
                    pk.Trangthaiketquaphantich, pk.Trangthaixuly, mq.Tenmau, mq.Noidung,  
                    kh.Tencongty, kh.Diachi, kh.Nguoidaidien
                FROM Phieuketqua pk
                INNER JOIN Quanlymauquantrac mq ON pk.Mamauthu = mq.Mamau
                INNER JOIN Quanlyhopdong hd ON pk.Mahopdong = hd.Mahopdong
                INNER JOIN Quanlykhachhang kh ON hd.Makhachhang = kh.Makhachhang
                WHERE pk.Maphieuketqua = @Maphieuketqua";


                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Maphieuketqua", maPhieuKetQua);

                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Lấy chi tiết thông số cho phiếu kết quả
        public static DataTable GetChiTietThongSo(int maPhieuKetQua, string _connectionString)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = @"
                SELECT Thongso, Donvi, Phuongphapphantich, KetquaPTN, KetquaHT, Quychuansosanh
                FROM Chitietthongso
                WHERE Maphieuketqua = @Maphieuketqua";

                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Maphieuketqua", maPhieuKetQua);

                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }



    }
}
