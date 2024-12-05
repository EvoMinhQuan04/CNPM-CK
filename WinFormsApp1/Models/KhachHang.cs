using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class KhachHang
    {
        public string? MaKhachHang { get; set; }
        public string? TenCongTy { get; set; }
        public string? DiaChi { get; set; }
        public string? NguoiDaiDien { get; set; }
        public string? MaHopDong { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }

        // Phương thức lấy danh sách khách hàng
        public static List<KhachHang> LayDanhSachKhachHang(string connectionString)
        {
            var danhSachKhachHang = new List<KhachHang>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT Makhachhang, Tencongty, Email, Diachi, Mahopdong, Sodienthoai, Nguoidaidien  FROM Quanlykhachhang";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var kh = new KhachHang
                        {
                            MaKhachHang = reader["Makhachhang"].ToString(),
                            TenCongTy = reader["Tencongty"].ToString(),
                            Email = reader["Email"].ToString(),
                            DiaChi = reader["Diachi"].ToString(),
                            
                            MaHopDong = reader["Mahopdong"].ToString(),
                            SoDienThoai = reader["Sodienthoai"].ToString(),
                            NguoiDaiDien = reader["Nguoidaidien"].ToString()

                        };
                        danhSachKhachHang.Add(kh);
                    }
                }
            }
            return danhSachKhachHang;
        }
        // Phương thức lấy danh sách công ty.
        public static List<string> LayDanhSachTenCongTy(string connectionString)
        {
            var danhSachTenCongTy = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT DISTINCT Tencongty FROM Quanlykhachhang";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tenCongTy = reader["Tencongty"]?.ToString();
                        if (!string.IsNullOrEmpty(tenCongTy))
                        {
                            danhSachTenCongTy.Add(tenCongTy);
                        }
                    }
                }
            }
            return danhSachTenCongTy;
        }

        // cập nhật khách hàng.
        public static bool CapNhatKhachHang(string connectionString, KhachHang kh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Quanlykhachhang SET Tencongty = @Tencongty, Diachi = @Diachi, Nguoidaidien = @Nguoidaidien, " +
                             "Mahopdong = @Mahopdong, Sodienthoai = @Sodienthoai, Email = @Email WHERE Makhachhang = @Makhachhang";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Tencongty", kh.TenCongTy);
                    cmd.Parameters.AddWithValue("@Diachi", kh.DiaChi);
                    cmd.Parameters.AddWithValue("@Nguoidaidien", kh.NguoiDaiDien);
                    cmd.Parameters.AddWithValue("@Mahopdong", kh.MaHopDong);
                    cmd.Parameters.AddWithValue("@Sodienthoai", kh.SoDienThoai);
                    cmd.Parameters.AddWithValue("@Email", kh.Email);
                    cmd.Parameters.AddWithValue("@Makhachhang", kh.MaKhachHang);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // thêm khách hàng.
        public static bool ThemKhachHang(string connectionString, KhachHang kh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Quanlykhachhang (Makhachhang, Tencongty, Diachi, Nguoidaidien, Mahopdong, Sodienthoai, Email) " +
                             "VALUES (@Makhachhang, @Tencongty, @Diachi, @Kyhieucongty, @Mahopdong, @Sodienthoai, @Email)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Makhachhang", kh.MaKhachHang);
                    cmd.Parameters.AddWithValue("@Tencongty", kh.TenCongTy);
                    cmd.Parameters.AddWithValue("@Diachi", kh.DiaChi);
                    cmd.Parameters.AddWithValue("@Kyhieucongty", kh.NguoiDaiDien);
                    cmd.Parameters.AddWithValue("@Mahopdong", kh.MaHopDong);
                    cmd.Parameters.AddWithValue("@Sodienthoai", kh.SoDienThoai);
                    cmd.Parameters.AddWithValue("@Email", kh.Email);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }

        //lọc khách hàng
        public static List<KhachHang> LocKhachHang(string connectionString, string attribute, string value)
        {
            var danhSachKhachHang = new List<KhachHang>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Xác định tên cột dựa trên attribute
                string columnName;
                switch (attribute)
                {
                    //chia tìm kiếm chính xác và tìm kiếm mờ
                    case "Mã khách hàng":
                        columnName = "Makhachhang";
                        break;
                    case "Tên công ty":
                        columnName = "Tencongty";
                        value = "%" + value + "%"; 
                        break;
                    case "Địa chỉ":
                        columnName = "Diachi";
                        value = "%" + value + "%";
                        break;
                    case "Người đại diện":
                        columnName = "Nguoidaidien";
                        value = "%" + value + "%";
                        break;
                    case "Mã hợp đồng":
                        columnName = "Mahopdong";
                        break;
                    case "Số điện thoại":
                        columnName = "Sodienthoai";
                        break;
                    case "Email":
                        columnName = "Email";
                        value = "%" + value + "%";
                        break;
                    default:
                        throw new ArgumentException("Thuộc tính không hợp lệ.");
                }

                string sql = $"SELECT * FROM Quanlykhachhang WHERE {columnName} LIKE @value";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@value", value);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var kh = new KhachHang
                            {
                                MaKhachHang = reader["Makhachhang"].ToString(),
                                TenCongTy = reader["Tencongty"].ToString(),
                                DiaChi = reader["Diachi"].ToString(),
                                NguoiDaiDien = reader["Nguoidaidien"].ToString(),
                                MaHopDong = reader["Mahopdong"].ToString(),
                                SoDienThoai = reader["Sodienthoai"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                            danhSachKhachHang.Add(kh);
                        }
                    }
                }
            }
            return danhSachKhachHang;
        }

        public static bool KiemTraMaKhachHangTonTai(string connectionString, string maKhachHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(*) FROM Quanlykhachhang WHERE Makhachhang = @Makhachhang";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Makhachhang", maKhachHang);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu mã khách hàng tồn tại
                }
            }
        }
        //kiểm tra trùng lặp số điện thoại của khách hàng
        public static bool KiemTraSoDienThoaiTonTai(string connectionString, string soDienThoai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Quanlykhachhang WHERE Sodienthoai = @SoDienThoai";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu số điện thoại đã tồn tại
                }
            }
        }
        //kiểm tra trùng lặp số điện thoại trừ chính khách hàng đó, áp dụng cho khi lưu thông tin khách hàng
        public static bool KiemTraSoDienThoaiTonTaiTruKhachHang(string connectionString, string soDienThoai, string maKhachHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Quanlykhachhang WHERE Sodienthoai = @Sodienthoai AND Makhachhang != @Makhachhang";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Sodienthoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@Makhachhang", maKhachHang);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu số điện thoại đã tồn tại
                }
            }
        }


    }
}
