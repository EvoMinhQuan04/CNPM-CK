using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    
    public class HopDong()
    {
        public string? MaHopDong { get; set; }         
        public string? MaKhachHang { get; set; }        
        public string? MaNhanVien { get; set; }        
        public float Quy { get; set; }                
        public string? TrangThai { get; set; }       
        public DateTime NgayLap { get; set; }       
        public DateTime NgayTra { get; set; }        
        public string? ViecCanLam { get; set; }

        // Phương thức lấy danh sách hợp đồng
        public static List<HopDong> LayDanhSachHopDong(string connectionString)
        {
            var danhSachHopDong = new List<HopDong>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT Mahopdong, Makhachhang, Manhanvien, Quy, Trangthai, Ngaylap, Ngaytra, Vieccanlam FROM Quanlyhopdong";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var hd = new HopDong
                        {
                            MaHopDong = reader["Mahopdong"].ToString(),
                            MaKhachHang = reader["Makhachhang"].ToString(),
                            MaNhanVien = reader["Manhanvien"].ToString(),
                            Quy = Convert.ToSingle(reader["Quy"]),
                            TrangThai = reader["Trangthai"].ToString(),
                            NgayLap = Convert.ToDateTime(reader["Ngaylap"]).Date, 
                            NgayTra = Convert.ToDateTime(reader["Ngaytra"]).Date, 
                            ViecCanLam = reader["Vieccanlam"].ToString()
                        };
             
                        danhSachHopDong.Add(hd);
                    }
                }
            }
            return danhSachHopDong;
        }

        // Phương thức thêm hợp đồng mới
        public static bool ThemHopDong(string connectionString, HopDong hd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Quanlyhopdong (Mahopdong, Makhachhang, Manhanvien, Quy, Trangthai, Ngaylap, Ngaytra, Vieccanlam) " +
                             "VALUES (@Mahopdong, @Makhachhang, @Manhanvien, @Quy, @Trangthai, @Ngaylap, @Ngaytra, @Vieccanlam)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Mahopdong", hd.MaHopDong);
                    cmd.Parameters.AddWithValue("@Makhachhang", hd.MaKhachHang);
                    cmd.Parameters.AddWithValue("@Manhanvien", hd.MaNhanVien);
                    cmd.Parameters.AddWithValue("@Quy", hd.Quy);
                    cmd.Parameters.AddWithValue("@Trangthai", hd.TrangThai);
                    cmd.Parameters.AddWithValue("@Ngaylap", hd.NgayLap.Date);
                    cmd.Parameters.AddWithValue("@Ngaytra", hd.NgayTra.Date);
                    cmd.Parameters.AddWithValue("@Vieccanlam", hd.ViecCanLam);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Phương thức cập nhật hợp đồng
        public static bool CapNhatHopDong(string connectionString, HopDong hd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Quanlyhopdong SET Makhachhang = @Makhachhang, Manhanvien = @Manhanvien, " +
                             "Quy = @Quy, Trangthai = @Trangthai, Ngaylap = @Ngaylap, Ngaytra = @Ngaytra, Vieccanlam = @Vieccanlam " +
                             "WHERE Mahopdong = @Mahopdong";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Mahopdong", hd.MaHopDong);
                    cmd.Parameters.AddWithValue("@Makhachhang", hd.MaKhachHang);
                    cmd.Parameters.AddWithValue("@Manhanvien", hd.MaNhanVien);
                    cmd.Parameters.AddWithValue("@Quy", hd.Quy);
                    cmd.Parameters.AddWithValue("@Trangthai", hd.TrangThai);
                    cmd.Parameters.AddWithValue("@Ngaylap", hd.NgayLap.Date);
                    cmd.Parameters.AddWithValue("@Ngaytra", hd.NgayTra.Date);
                    cmd.Parameters.AddWithValue("@Vieccanlam", hd.ViecCanLam);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Phương thức lọc hợp đồng
        public static List<HopDong> LocHopDong(string connectionString, string attribute, string value, DateTime? ngayLap, DateTime? ngayKetThuc)
        {
            var ketQuaLoc = new List<HopDong>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Base SQL with dynamic WHERE clause based on the attribute selected
                string sql = "SELECT Mahopdong, Makhachhang, Manhanvien, Quy, Trangthai, Ngaylap, Ngaytra, Vieccanlam FROM Quanlyhopdong WHERE ";

                // Add the attribute-based filter
                switch (attribute)
                {
                    case "Mã khách hàng":
                        sql += "LOWER(Makhachhang) = @value";
                        break;
                    case "Mã nhân viên":
                        sql += "LOWER(Manhanvien) = @value";
                        break;
                    case "Mã hợp đồng":
                        sql += "LOWER(Mahopdong) = @value";
                        break;
                    case "Trạng thái hợp đồng":
                        sql += "LOWER(Trangthai) LIKE @value";
                        break;
                    default:
                        throw new ArgumentException("Lựa chọn lọc không hợp lệ.");
                }

                // Thêm điều kiện ngày nếu có giá trị
                if (ngayLap.HasValue)
                {
                    sql += " AND CONVERT(DATE, Ngaylap) >= @ngayLap"; // Sử dụng CONVERT để so sánh kiểu DATE
                }
                if (ngayKetThuc.HasValue)
                {
                    sql += " AND CONVERT(DATE, Ngaytra) <= @ngayKetThuc"; // Sử dụng CONVERT để so sánh kiểu DATE
                }

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (attribute == "Trạng thái hợp đồng")
                    {
                        cmd.Parameters.AddWithValue("@value", $"%{value.ToLower()}%"); // Tìm kiếm gần đúng chỉ cho trạng thái
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@value", value.ToLower()); // Tìm kiếm chính xác cho mã
                    }

                    if (ngayLap.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@ngayLap", ngayLap.Value.ToString("yyyy-MM-dd"));
                    }
                    if (ngayKetThuc.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@ngayKetThuc", ngayKetThuc.Value.ToString("yyyy-MM-dd"));
                    }

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var hopDong = new HopDong
                            {
                                MaHopDong = reader["Mahopdong"].ToString(),
                                MaKhachHang = reader["Makhachhang"].ToString(),
                                MaNhanVien = reader["Manhanvien"].ToString(),
                                Quy = reader["Quy"] != DBNull.Value ? Convert.ToSingle(reader["Quy"]) : 0,
                                TrangThai = reader["Trangthai"].ToString(),
                                NgayLap = Convert.ToDateTime(reader["Ngaylap"]).Date,
                                NgayTra = Convert.ToDateTime(reader["Ngaytra"]).Date,
                                ViecCanLam = reader["Vieccanlam"].ToString()
                            };
                            ketQuaLoc.Add(hopDong);
                        }
                    }
                }
            }
            return ketQuaLoc;
        }




        // Phương thức lấy danh sách hợp đồng trễ hạn
        public static List<HopDong> LayHopDongTreHan(string connectionString)
        {
            var danhSachHopDongTreHan = new List<HopDong>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Truy vấn kiểm tra ngày trả và trạng thái
                string sql = @"
                    SELECT Mahopdong, Makhachhang, Manhanvien, Quy, Trangthai, Ngaylap, Ngaytra, Vieccanlam
                    FROM Quanlyhopdong
                    WHERE (Ngaytra < @currentDate AND Trangthai = N'Đang hoạt động')
                       OR Trangthai = N'Đã trễ hạn'";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@currentDate", DateTime.Today);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var hd = new HopDong
                            {
                                MaHopDong = reader["Mahopdong"].ToString(),
                                MaKhachHang = reader["Makhachhang"].ToString(),
                                MaNhanVien = reader["Manhanvien"].ToString(),
                                Quy = Convert.ToSingle(reader["Quy"]),
                                TrangThai = reader["Trangthai"].ToString(),
                                NgayLap = Convert.ToDateTime(reader["Ngaylap"]).Date,
                                NgayTra = Convert.ToDateTime(reader["Ngaytra"]).Date,
                                ViecCanLam = reader["Vieccanlam"].ToString()
                            };

                            danhSachHopDongTreHan.Add(hd);
                        }
                    }
                }
            }

            return danhSachHopDongTreHan;
        }

        public static List<DateTime> LayDanhSachNgay(string connectionString, string columnName)
        {
            var danhSachNgay = new List<DateTime>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $"SELECT DISTINCT {columnName} FROM Quanlyhopdong ORDER BY {columnName} ASC";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhSachNgay.Add(Convert.ToDateTime(reader[columnName]));
                        }
                    }
                }
            }
            return danhSachNgay;
        }


        // Phương thức cập nhật trạng thái hợp đồng trễ hạn
        public static void CapNhatTrangThaiTreHan(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Quanlyhopdong SET Trangthai = 'Đã quá hạn' WHERE Ngaytra < @currentDate AND Trangthai = 'Đang hoạt động'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@currentDate", DateTime.Now.Date);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //các hàm kiểm tra dữ liệu
        public static bool KiemTraMaNhanVienTonTai(string connectionString, string maNhanVien)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(*) FROM Nhanvien WHERE Manhanvien = @Manhanvien";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Manhanvien", maNhanVien);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }
        //kiểm tra mã hợp đồng tồn tại cả QLKH và QLHD Quân sửa khi thêm khách hàng.
        public static bool KiemTraMaHopDongTonTai(string connectionString, string maHopDong)
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
                    return count > 0; // Trả về true nếu mã hợp đồng tồn tại trong ít nhất 1 bảng
                }
            }
        }

        public static bool KiemTraMaHopDongTonTaiTrongQLHD(string connectionString, string maHopDong)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(*) FROM Quanlyhopdong WHERE Mahopdong = @Mahopdong";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Mahopdong", maHopDong);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu mã hợp đồng đã tồn tại
                }
            }
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
                    return count > 0;
                }
            }
        }
        //kiểm tra khi thêm hợp đồng mà trước đó đã có khách hàng cùng với mã hợp đồng. Nhưng lúc
        //nhập mã hợp đồng thì trùng với mã hd của khách hàng mới thêm nhưng mã khách hàng thì khác 
        //vd: khi thêm khách hàng KH1 có mã hd là 24.001, thêm hợp đồng mới có mã hd là 24.001 nhưng mã khách hàng KH2 thì thông báo.(KH2 đã tồn tại)
        public static bool KiemTraMaHopDongVaMaKhachHangTonTai(string connectionString, string maHopDong, string maKhachHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Makhachhang FROM Quanlyhopdong WHERE Mahopdong = @Mahopdong";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Mahopdong", maHopDong);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string maKhachHangTonTai = result.ToString();
                        return maKhachHangTonTai == maKhachHang; // Trả về true nếu mã khách hàng khớp
                    }
                    return true; // Trả về true nếu không tìm thấy mã hợp đồng
                }
            }
        }
        //kiểm tra khi thêm hợp đồng mà chọn hợp đồng đã tồn tại với khách hàng khác
        public static bool KiemTraHopDongKhongPhuHop(string connectionString, string maHopDong, string maKhachHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                SELECT COUNT(*)
                FROM Quanlykhachhang
                WHERE Mahopdong = @Mahopdong AND Makhachhang != @Makhachhang";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Mahopdong", maHopDong);
                    cmd.Parameters.AddWithValue("@Makhachhang", maKhachHang);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu mã hợp đồng đã tồn tại với mã khách hàng khác
                }
            }
        }







    }
}
