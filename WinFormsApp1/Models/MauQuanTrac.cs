using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace WinFormsApp1.Models
{
    public class MauQuanTrac
    {
        public string? MaMau { get; set; }
        public string? MaHopDong { get; set; }
        public string? TenMau { get; set; }
        public string? NoiDung { get; set; }
        public DateTime NgayLay { get; set; }
        public DateTime NgayTra { get; set; }
        public string? MaNhanVien { get; set; }
    

        //lấy danh sách mẫu quan trắc
        public static List<MauQuanTrac> LayDanhSachMauQuanTrac(string connectionString)
        {
                var danhSachMauQuanTrac = new List<MauQuanTrac>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT Mamau, Mahopdong, Tenmau, Noidung, Ngaylay, Ngaytra, Manhanvien FROM Quanlymauquantrac";
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var mq = new MauQuanTrac
                            {
                                MaMau = reader["Mamau"].ToString(),
                                MaHopDong = reader["Mahopdong"].ToString(),
                                TenMau = reader["Tenmau"].ToString(),
                                NoiDung = reader["Noidung"].ToString(),
                                NgayLay = Convert.ToDateTime(reader["Ngaylay"]),
                                NgayTra = Convert.ToDateTime(reader["Ngaytra"]),
                                MaNhanVien = reader["Manhanvien"].ToString()
                            };
                            danhSachMauQuanTrac.Add(mq);
                        }
                    }
                }
                return danhSachMauQuanTrac;
        }
        //cập nhât mẫu quan trắc
        public static bool CapNhatMauQuanTrac(string connectionString, MauQuanTrac mau)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                UPDATE Quanlymauquantrac
                SET 
                    Mahopdong = @MaHopDong,
                    Tenmau = @TenMau,
                    Noidung = @NoiDung,
                    Ngaylay = @NgayLay,
                    Ngaytra = @NgayTra,
                    Manhanvien = @MaNhanVien
                WHERE Mamau = @MaMau";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaMau", mau.MaMau);
                    cmd.Parameters.AddWithValue("@MaHopDong", mau.MaHopDong);
                    cmd.Parameters.AddWithValue("@TenMau", mau.TenMau);
                    cmd.Parameters.AddWithValue("@NoiDung", mau.NoiDung);
                    cmd.Parameters.AddWithValue("@NgayLay", mau.NgayLay);
                    cmd.Parameters.AddWithValue("@NgayTra", mau.NgayTra);
                    cmd.Parameters.AddWithValue("@MaNhanVien", mau.MaNhanVien);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            }
        }

        // Phương thức thêm mẫu quan trắc
        public static bool ThemMauQuanTrac(string connectionString, MauQuanTrac mau)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Quanlymauquantrac (Mamau, Mahopdong, Tenmau, Noidung, Ngaylay, Ngaytra, Manhanvien) " +
                             "VALUES (@Mamau, @Mahopdong, @Tenmau, @Noidung, @Ngaylay, @Ngaytra, @Manhanvien)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Mamau", mau.MaMau);
                cmd.Parameters.AddWithValue("@Mahopdong", mau.MaHopDong);
                cmd.Parameters.AddWithValue("@Tenmau", mau.TenMau);
                cmd.Parameters.AddWithValue("@Noidung", mau.NoiDung);
                cmd.Parameters.AddWithValue("@Ngaylay", mau.NgayLay);
                cmd.Parameters.AddWithValue("@Ngaytra", mau.NgayTra);
                cmd.Parameters.AddWithValue("@Manhanvien", mau.MaNhanVien);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        //lọc dữ liệu
        public static List<MauQuanTrac> LocMauQuanTrac(string connectionString, string? maMau, string? maNhanVien, string? maHopDong, DateTime? ngayLay, DateTime? ngayTra)
        {
            var danhSachMauQuanTrac = new List<MauQuanTrac>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                var query = new StringBuilder("SELECT Mamau, Mahopdong, Tenmau, Noidung, Ngaylay, Ngaytra, Manhanvien FROM Quanlymauquantrac WHERE 1=1");
                var parameters = new List<SqlParameter>();

                if (!string.IsNullOrWhiteSpace(maHopDong))
                {
                    query.Append(" AND Mahopdong = @MaHopDong");
                    parameters.Add(new SqlParameter("@MaHopDong", maHopDong.Trim()));
                }
                if (!string.IsNullOrWhiteSpace(maMau))
                {
                    query.Append(" AND Mamau = @MaMau");
                    parameters.Add(new SqlParameter("@MaMau", maMau.Trim())); // Xóa khoảng trắng thừa
                }

                if (!string.IsNullOrWhiteSpace(maNhanVien))
                {
                    query.Append(" AND Manhanvien = @MaNhanVien");
                    parameters.Add(new SqlParameter("@MaNhanVien", maNhanVien.Trim())); // Xóa khoảng trắng thừa
                }
                if (ngayLay.HasValue)
                {
                    query.Append(" AND Ngaylay >= @NgayLay"); // Thay đổi để lọc từ ngày lấy
                    parameters.Add(new SqlParameter("@NgayLay", ngayLay.Value));
                }

                if (ngayTra.HasValue)
                {
                    query.Append(" AND Ngaytra <= @NgayTra"); // Thay đổi để lọc đến ngày trả
                    parameters.Add(new SqlParameter("@NgayTra", ngayTra.Value));
                }



                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query.ToString(), conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var mq = new MauQuanTrac
                            {
                                MaMau = reader["Mamau"].ToString(),
                                MaHopDong = reader["Mahopdong"].ToString(),
                                TenMau = reader["Tenmau"].ToString(),
                                NoiDung = reader["Noidung"].ToString(),
                                NgayLay = Convert.ToDateTime(reader["Ngaylay"]),
                                NgayTra = Convert.ToDateTime(reader["Ngaytra"]),
                                MaNhanVien = reader["Manhanvien"].ToString()
                            };
                            danhSachMauQuanTrac.Add(mq);
                        }
                    }
                }
            }

            return danhSachMauQuanTrac;
        }


        //kiểm tra dữ liệu
        //kiểm tra mã hợp đồng không tồn tại cả trong qlkh, qlhd khi nhập thêm mẫu quan trắc, mỗi mẫu quan trắc phải có mã hợp đồng tương ứng có thể trùng mã hợp đồng nhưng phải khác mã mẫu thử.
        public static bool KiemTraMaHopDongTonTai(string maHopDong, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                SELECT COUNT(*) 
                FROM (
                    SELECT Mahopdong FROM Quanlyhopdong WHERE Mahopdong = @Mahopdong
                    UNION
                    SELECT Mahopdong FROM Quanlykhachhang WHERE Mahopdong = @Mahopdong
                ) AS Combined";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Mahopdong", maHopDong);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static bool KiemTraMaNhanVienTonTai(string maNhanVien, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(*) FROM Nhanvien WHERE Manhanvien = @MaNhanVien";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static bool KiemTraMaMauTonTai(string connectionString, string maMau)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(*) FROM Quanlymauquantrac WHERE Mamau = @MaMau";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaMau", maMau);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }






    }
}
