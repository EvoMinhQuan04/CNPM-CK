using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WinFormsApp1.Models
{
    public class NhanVien
    {
        public string? MaNhanVien { get; set; }
        public string? HoVaTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? SoDienThoai { get; set; }
        public string? ChucVu { get; set; }
        public string? Email { get; set; }
        public int SoHoanThanh { get; set; }
        public int SoDangHoatDong { get; set; }
        public int SoTreHan { get; set; }
        public int TongHopDong => SoHoanThanh + SoDangHoatDong + SoTreHan;


        public static List<NhanVien> LayDanhSachNhanVien(string connectionString)
        {
            List<NhanVien> danhSachNhanVien = new List<NhanVien>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT Manhanvien, Hovaten, Ngaysinh, Sodienthoai, Chucvu, Email FROM Nhanvien";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSachNhanVien.Add(new NhanVien
                        {
                            MaNhanVien = reader["Manhanvien"].ToString(),
                            HoVaTen = reader["Hovaten"].ToString(),
                            NgaySinh = Convert.ToDateTime(reader["Ngaysinh"]),
                            SoDienThoai = reader["Sodienthoai"].ToString(),                          
                            ChucVu = reader["Chucvu"].ToString(),
                            Email = reader["Email"].ToString()
                        });
                    }
                }
            }

            return danhSachNhanVien;
        }

        public static bool ThemNhanVien(NhanVien nhanVien, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Nhanvien (Manhanvien, Hovaten, Ngaysinh , Sodienthoai, Chucvu,Email) " +
                             "VALUES (@Manhanvien, @Hovaten, @Ngaysinh, @Sodienthoai,  @Chucvu,@Email)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Manhanvien", nhanVien.MaNhanVien);
                    cmd.Parameters.AddWithValue("@Hovaten", nhanVien.HoVaTen);
                    cmd.Parameters.AddWithValue("@Ngaysinh", nhanVien.NgaySinh);               
                    cmd.Parameters.AddWithValue("@Sodienthoai", nhanVien.SoDienThoai);
                    cmd.Parameters.AddWithValue("@Chucvu", nhanVien.ChucVu);
                    cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
               

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool CapNhatNhanVien(NhanVien nhanVien, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Nhanvien SET Hovaten = @Hovaten, Email = @Email, Sodienthoai = @Sodienthoai, " +
                             "Ngaysinh = @Ngaysinh, Chucvu = @Chucvu WHERE Manhanvien = @Manhanvien";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Hovaten", nhanVien.HoVaTen);
                    cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
                    cmd.Parameters.AddWithValue("@Sodienthoai", nhanVien.SoDienThoai);
                    cmd.Parameters.AddWithValue("@Ngaysinh", nhanVien.NgaySinh);
                    cmd.Parameters.AddWithValue("@Chucvu", nhanVien.ChucVu);
                    cmd.Parameters.AddWithValue("@Manhanvien", nhanVien.MaNhanVien);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        //lọc thông tin nhân viên
        public static List<NhanVien> LocNhanVien(string connectionString, string attribute, string value)
        {
            var danhSachNhanVien = new List<NhanVien>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Xác định tên cột dựa trên attribute
                string columnName;
                switch (attribute)
                {
                    case "Mã nhân viên":
                        columnName = "Manhanvien";
                        break;
                    case "Tên nhân viên":
                        columnName = "Hovaten";
                        break;
                    case "Ngày sinh":
                        columnName = "Ngaysinh";
                        break;
                    case "Số điện thoại":
                        columnName = "Sodienthoai";
                        break;
                    case "Email":
                        columnName = "Email";
                        break;
                    case "Chức vụ":
                        columnName = "Chucvu";
                        break;
                    default:
                        throw new ArgumentException("Thuộc tính không hợp lệ.");
                }

                // Tạo câu lệnh SQL động
                var queryBuilder = new StringBuilder($"SELECT * FROM Nhanvien WHERE 1=1");

                if (attribute == "Tên nhân viên" || attribute == "Chức vụ")
                {
                    // Tìm kiếm mờ với từ khóa
                    var keywords = value.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var keyword in keywords)
                    {
                        queryBuilder.Append($" AND {columnName} LIKE @keyword_{keyword}");
                    }
                }
                else
                {
                    // Tìm kiếm chính xác
                    queryBuilder.Append($" AND {columnName} = @value");
                }

                using (SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn))
                {
                    if (attribute == "Tên nhân viên" || attribute == "Chức vụ")
                    {
                        // Gán tham số tìm kiếm mờ
                        var keywords = value.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        foreach (var keyword in keywords)
                        {
                            cmd.Parameters.AddWithValue($"@keyword_{keyword}", $"%{keyword}%");
                        }
                    }
                    else
                    {
                        // Gán tham số tìm kiếm chính xác
                        cmd.Parameters.AddWithValue("@value", value);
                    }

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var nv = new NhanVien
                            {
                                MaNhanVien = reader["Manhanvien"].ToString(),
                                HoVaTen = reader["Hovaten"].ToString(),
                                NgaySinh = reader["Ngaysinh"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["Ngaysinh"]),
                                SoDienThoai = reader["Sodienthoai"].ToString(),
                                ChucVu = reader["Chucvu"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                            danhSachNhanVien.Add(nv);
                        }
                    }
                }
            }
            return danhSachNhanVien;
        }




        public static bool KiemTraMaNhanVienTonTai(string maNhanVien, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(1) FROM Nhanvien WHERE Manhanvien = @Manhanvien";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Manhanvien", maNhanVien);
                    conn.Open();
                    int exists = (int)cmd.ExecuteScalar();
                    return exists > 0; // Trả về true nếu mã nhân viên đã tồn tại
                }
            }
        }
        //kiểm tra trùng số điện thoại của nhân viên khi thêm nhân viên
        public static bool KiemTraSoDienThoaiTonTai(string soDienThoai, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(1) FROM Nhanvien WHERE Sodienthoai = @Sodienthoai";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Sodienthoai", soDienThoai);
                    conn.Open();
                    int exists = (int)cmd.ExecuteScalar();
                    return exists > 0; // Trả về true nếu số điện thoại đã tồn tại
                }
            }
        }
        //kiểm tra trùng số điện thoại khi sửa thông tin nhân viên(trừ nhân viên đó)
        public static bool KiemTraSoDienThoaiTonTaiTruNhanVien(string soDienThoai, string maNhanVien, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(1) FROM Nhanvien WHERE Sodienthoai = @Sodienthoai AND Manhanvien != @Manhanvien";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Sodienthoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@Manhanvien", maNhanVien);
                    conn.Open();
                    int exists = (int)cmd.ExecuteScalar();
                    return exists > 0; // Trả về true nếu số điện thoại đã tồn tại và thuộc nhân viên khác
                }
            }
        }


        public static bool GuiThongBaoQuaEmail(string recipientEmail, string subject, string messageBody, List<string> attachmentPaths)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("vuonghades2004@gmail.com", "acpp wnqh qkdk ppzy"),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("vuonghades2004@gmail.com", "THÔNG BÁO CỦA CÔNG TY"),
                    Subject = subject,
                    Body = messageBody,
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(recipientEmail);
                foreach (string path in attachmentPaths)
                {
                    mailMessage.Attachments.Add(new Attachment(path));
                }

                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public static NhanVien TimKiemNhanVienTheoMaHoacTen(string connectionString, string tuKhoa)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
        SELECT TOP 1 * 
        FROM Nhanvien
        WHERE Manhanvien = @TuKhoa
           OR Hovaten LIKE '%' + @TuKhoa + '%'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Trả về đối tượng NhanVien từ kết quả truy vấn
                        return new NhanVien
                        {
                            MaNhanVien = reader["Manhanvien"].ToString(),
                            HoVaTen = reader["Hovaten"].ToString(),
                            Email = reader["Email"].ToString(),
                            SoDienThoai = reader["Sodienthoai"].ToString(),
                            NgaySinh = reader["Ngaysinh"] != DBNull.Value ? (DateTime?)reader["Ngaysinh"] : null,
                            ChucVu = reader["Chucvu"].ToString()
                        };
                    }
                }
            }

            return null; // Trả về null nếu không tìm thấy
        }


        public static List<(int Thang, int SoHoanThanh, int SoDangHoatDong, int SoTreHan)> LayThongKeTheoQuy(string connectionString, string maNhanVien, int quy, int nam)
        {
            List<(int Thang, int SoHoanThanh, int SoDangHoatDong, int SoTreHan)> thongKe = new List<(int, int, int, int)>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                SELECT 
                    MONTH(hd.NgayLap) AS Thang,
                    COUNT(CASE WHEN hd.TrangThai = N'Đã hoàn thành' THEN 1 END) AS SoHoanThanh,
                    COUNT(CASE WHEN hd.TrangThai = N'Đang hoạt động' THEN 1 END) AS SoDangHoatDong,
                    COUNT(CASE WHEN hd.TrangThai = N'Đã quá hạn' THEN 1 END) AS SoTreHan
                FROM Quanlyhopdong hd
                WHERE hd.MaNhanVien = @MaNhanVien
                    AND YEAR(hd.NgayLap) = @Nam
                    AND MONTH(hd.NgayLap) BETWEEN @ThangBatDau AND @ThangKetThuc
                GROUP BY MONTH(hd.NgayLap)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                cmd.Parameters.AddWithValue("@Nam", nam);
                cmd.Parameters.AddWithValue("@ThangBatDau", (quy - 1) * 3 + 1);
                cmd.Parameters.AddWithValue("@ThangKetThuc", quy * 3);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int thang = reader.GetInt32(0);
                        int soHoanThanh = reader.GetInt32(1);
                        int soDangHoatDong = reader.GetInt32(2);
                        int soTreHan = reader.GetInt32(3);

                        thongKe.Add((thang, soHoanThanh, soDangHoatDong, soTreHan));
                    }
                }
            }

            return thongKe;
        }

        public static List<(int Thang, int SoHoanThanh, int SoDangHoatDong, int SoTreHan)> LayThongKeCtyTheoQuy(string connectionString, int quy, int nam)
        {
            List<(int Thang, int SoHoanThanh, int SoDangHoatDong, int SoTreHan)> thongKe = new List<(int, int, int, int)>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                SELECT 
                    MONTH(hd.NgayLap) AS Thang,
                    COUNT(CASE WHEN hd.TrangThai = N'Đã hoàn thành' THEN 1 END) AS SoHoanThanh,
                    COUNT(CASE WHEN hd.TrangThai = N'Đang hoạt động' THEN 1 END) AS SoDangHoatDong,
                    COUNT(CASE WHEN hd.TrangThai = N'Đã quá hạn' THEN 1 END) AS SoTreHan
                FROM Quanlyhopdong hd
                WHERE YEAR(hd.NgayLap) = @Nam
                    AND MONTH(hd.NgayLap) BETWEEN @ThangBatDau AND @ThangKetThuc
                GROUP BY MONTH(hd.NgayLap)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nam", nam);
                cmd.Parameters.AddWithValue("@ThangBatDau", (quy - 1) * 3 + 1);
                cmd.Parameters.AddWithValue("@ThangKetThuc", quy * 3);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int thang = reader.GetInt32(0);
                        int soHoanThanh = reader.GetInt32(1);
                        int soDangHoatDong = reader.GetInt32(2);
                        int soTreHan = reader.GetInt32(3);

                        thongKe.Add((thang, soHoanThanh, soDangHoatDong, soTreHan));
                    }
                }
            }

            return thongKe;
        }


        public static int TinhTongHopDong(string connectionString)
        {
            int tongHopDong = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(*) FROM Quanlyhopdong";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    tongHopDong = (int)cmd.ExecuteScalar();
                }
            }

            return tongHopDong;
        }

        public static int TinhTongHopDongTrongQuyCuaCongTy(string connectionString, int quy, int nam)
        {
            if (quy < 1 || quy > 4)
                throw new ArgumentOutOfRangeException(nameof(quy), "Quý phải nằm trong khoảng từ 1 đến 4.");

            if (nam <= 0)
                throw new ArgumentOutOfRangeException(nameof(nam), "Năm phải lớn hơn 0.");

            int tongSoHopDong = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
            SELECT COUNT(*) 
            FROM Quanlyhopdong
            WHERE YEAR(NgayLap) = @Nam 
            AND MONTH(NgayLap) BETWEEN @ThangBatDau AND @ThangKetThuc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Tính tháng bắt đầu và kết thúc của quý
                    int thangBatDau = (quy - 1) * 3 + 1;
                    int thangKetThuc = thangBatDau + 2;

                    // Gán tham số
                    cmd.Parameters.AddWithValue("@Nam", nam);
                    cmd.Parameters.AddWithValue("@ThangBatDau", thangBatDau);
                    cmd.Parameters.AddWithValue("@ThangKetThuc", thangKetThuc);

                    // Thực thi câu lệnh SQL
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    tongSoHopDong = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }

            return tongSoHopDong;
        }

        //phần lịch sử
        public static DataTable LayLichSuTheoThoiGian(string tableName, TimeSpan timeSpan, string connectionString)
        {
            if (string.IsNullOrEmpty(tableName))
                throw new ArgumentNullException(nameof(tableName));

            DateTime startTime = DateTime.Now.Subtract(timeSpan);
            string query = $@"
                SELECT * 
                FROM {tableName}
                WHERE Ngaychinhsua >= @StartTime
                ORDER BY Ngaychinhsua DESC";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartTime", startTime);

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public static DataTable LayLichSuHopDong(DateTime startTime, DateTime endTime, string connectionString)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT * FROM QuanLyHopDong_History
                         WHERE Ngaychinhsua BETWEEN @StartTime AND @EndTime";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);

                    var adapter = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable LayLichSuKhachHang(DateTime startTime, DateTime endTime, string connectionString)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT * FROM QuanLyKhachHang_History
                         WHERE Ngaychinhsua BETWEEN @StartTime AND @EndTime";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);

                    var adapter = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public static DataTable LayLichSuMauQuanTrac(DateTime startTime, DateTime endTime, string connectionString)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT * FROM QuanLyMauQuanTrac_History
                         WHERE Ngaychinhsua BETWEEN @StartTime AND @EndTime";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);

                    var adapter = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public static DataTable LayLichSuPhieuKetQua(DateTime startTime, DateTime endTime, string connectionString)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT * FROM PhieuKetQua_History
                         WHERE Ngaychinhsua  BETWEEN @StartTime AND @EndTime";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);

                    var adapter = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }



    }
}
