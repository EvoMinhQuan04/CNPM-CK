// Models/NguoiDungModel.cs
using System;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1.Models
{
    public class NguoiDungModel
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

        public NguoiDungModel(string taiKhoan, string matKhau)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
        }

        // Phương thức kiểm tra đăng nhập
        public bool KiemTraDangNhap(string connectionString, string taiKhoanHoacEmail, string matKhau)
        {
            using (SqlConnection ketNoi = new SqlConnection(connectionString))
            {
                try
                {
                    ketNoi.Open();
                    string sql = @"
                        SELECT COUNT(1) 
                        FROM Quanlydangnhap 
                        WHERE (Taikhoan = @TaiKhoanHoacEmail OR Email = @TaiKhoanHoacEmail) 
                          AND Matkhau = @MatKhau";
                    using (SqlCommand lenh = new SqlCommand(sql, ketNoi))
                    {
                        lenh.Parameters.AddWithValue("@TaiKhoanHoacEmail", taiKhoanHoacEmail);
                        lenh.Parameters.AddWithValue("@MatKhau", matKhau);
                        int dem = Convert.ToInt32(lenh.ExecuteScalar());
                        return dem == 1;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        // Phương thức lấy vai trò của người dùng
        public static string LayVaiTro(string connectionString, string taiKhoan)
        {
            using (SqlConnection ketNoi = new SqlConnection(connectionString))
            {
                ketNoi.Open();
                string truyVanNhanVien = "SELECT COUNT(1) FROM Nhanvien WHERE Manhanvien = @TaiKhoan";
                using (SqlCommand lenhNhanVien = new SqlCommand(truyVanNhanVien, ketNoi))
                {
                    lenhNhanVien.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    if (Convert.ToInt32(lenhNhanVien.ExecuteScalar()) == 1)
                        return "Nhanvien";
                }

                string truyVanQuanLy = "SELECT COUNT(1) FROM QuanLy WHERE Maquanly = @TaiKhoan";
                using (SqlCommand lenhQuanLy = new SqlCommand(truyVanQuanLy, ketNoi))
                {
                    lenhQuanLy.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    if (Convert.ToInt32(lenhQuanLy.ExecuteScalar()) == 1)
                        return "QuanLy";
                }

                return string.Empty; // Không xác định vai trò
            }
        }
        //lấy tên nhân viên hiện thị lên giao diện khi đăng nhập
        public string LayTenHienThiGiaoDien(string connectionString,string taiKhoanHoacEmail)
        {
            using (SqlConnection ketNoi = new SqlConnection(connectionString))
            {
                ketNoi.Open();
                string truyVan = @"
                    SELECT nv.Hovaten 
                    FROM Nhanvien nv
                    JOIN Quanlydangnhap qldn ON nv.Manhanvien = qldn.Taikhoan
                    WHERE qldn.Taikhoan = @TaiKhoan OR qldn.Email = @TaiKhoan
                    UNION
                    SELECT ql.Hovaten 
                    FROM Quanly ql
                    JOIN Quanlydangnhap qldn ON ql.Maquanly = qldn.Taikhoan
                    WHERE qldn.Taikhoan = @TaiKhoan OR qldn.Email = @TaiKhoan";

                using (SqlCommand lenh = new SqlCommand(truyVan, ketNoi))
                {
                    lenh.Parameters.AddWithValue("@TaiKhoan", taiKhoanHoacEmail);
                    object ketQua = lenh.ExecuteScalar();
                    return ketQua != null ? ketQua.ToString() : "Không xác định";
                }
            }
        }


        // Phương thức lấy email và mật khẩu của người dùng để hỗ trợ tính năng quên mật khẩu
        public (string Email, string MatKhau) LayEmailVaMatKhau(string connectionString, string taiKhoanHoacEmail)
        {
            using (SqlConnection ketNoi = new SqlConnection(connectionString))
            {
                ketNoi.Open();
                string truyVan = @"
            SELECT Email, Matkhau 
            FROM Quanlydangnhap 
            WHERE Taikhoan = @TaiKhoanHoacEmail OR Email = @TaiKhoanHoacEmail";

                using (SqlCommand lenh = new SqlCommand(truyVan, ketNoi))
                {
                    lenh.Parameters.AddWithValue("@TaiKhoanHoacEmail", taiKhoanHoacEmail);
                    using (SqlDataReader reader = lenh.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string email = reader["Email"]?.ToString() ?? throw new Exception("Email không tồn tại.");
                            string matKhau = reader["Matkhau"]?.ToString() ?? throw new Exception("Mật khẩu không tồn tại.");
                            return (email, matKhau);
                        }
                        else
                        {
                            throw new Exception("Tài khoản hoặc email không tồn tại.");
                        }
                    }
                }
            }
        }
        public bool CapNhatMatKhau(string connectionString, string taiKhoanHoacEmail, string matKhauMoi)
        {
            using (SqlConnection ketNoi = new SqlConnection(connectionString))
            {
                ketNoi.Open();
                string sql = @"
            UPDATE Quanlydangnhap
            SET Matkhau = @Matkhau
            WHERE Taikhoan = @TaiKhoanHoacEmail OR Email = @TaiKhoanHoacEmail";

                using (SqlCommand lenh = new SqlCommand(sql, ketNoi))
                {
                    lenh.Parameters.AddWithValue("@Matkhau", matKhauMoi);
                    lenh.Parameters.AddWithValue("@TaiKhoanHoacEmail", taiKhoanHoacEmail);

                    int hangBiAnhHuong = lenh.ExecuteNonQuery();
                    return hangBiAnhHuong > 0;
                }
            }
        }
    }
}
