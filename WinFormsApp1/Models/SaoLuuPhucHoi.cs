using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1.Models
{
    public class SaoLuuPhucHoiModel
    {
        private readonly string _connectionString;
        private readonly Dictionary<string, string> _primaryKeyMapping = new Dictionary<string, string>
    {
        { "QuanLyHopDong", "Mahopdong" },
        { "QuanLyKhachHang", "Makhachhang" },
        { "QuanLyMauQuanTrac", "Mamau" },
        { "PhieuKetQua", "Maphieuketqua" }
    };


        // Constructor
        public SaoLuuPhucHoiModel(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }

        /// <summary>
        /// Lấy dữ liệu lịch sử từ bảng cụ thể và lọc theo khoảng thời gian.
        /// </summary>
        /// <param name="tableName">Tên bảng lịch sử</param>
        /// <param name="timeSpan">Khoảng thời gian cần lọc</param>
        /// <returns>DataTable chứa dữ liệu lịch sử</returns>
        public DataTable LayLichSuTheoThoiGian(string tableName, TimeSpan timeSpan)
        {
            if (string.IsNullOrEmpty(tableName))
                throw new ArgumentNullException(nameof(tableName));

            DateTime startTime = DateTime.Now.Subtract(timeSpan);
            string query = $@"
                SELECT * 
                FROM {tableName}
                WHERE Ngaychinhsua >= @StartTime
                ORDER BY Ngaychinhsua DESC";

            using (var connection = new SqlConnection(_connectionString))
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
        public DataTable LayLichSuHopDong(DateTime startTime, DateTime endTime)
        {
            using (var conn = new SqlConnection(_connectionString))
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

        public DataTable LayLichSuKhachHang(DateTime startTime, DateTime endTime)
        {
            using (var conn = new SqlConnection(_connectionString))
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
        public DataTable LayLichSuMauQuanTrac(DateTime startTime, DateTime endTime)
        {
            using (var conn = new SqlConnection(_connectionString))
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
        public DataTable LayLichSuPhieuKetQua(DateTime startTime, DateTime endTime)
        {
            using (var conn = new SqlConnection(_connectionString))
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

        public void PhucHoiDuLieu(string sourceTable, string targetTable, string primaryKeyColumn, object primaryKeyValue)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();

                try
                {
                    // Vô hiệu hóa tất cả ràng buộc khóa ngoại
                    var disableConstraintsQuery = "EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'";
                    using (var disableCommand = new SqlCommand(disableConstraintsQuery, connection, transaction))
                    {
                        disableCommand.ExecuteNonQuery();
                    }

                    // Lấy tên cột khóa chính thực từ bảng ánh xạ
                    if (!_primaryKeyMapping.TryGetValue(targetTable, out var realPrimaryKeyColumn))
                    {
                        throw new Exception($"Không tìm thấy ánh xạ cột khóa chính cho bảng {targetTable}.");
                    }

                    // Truy vấn bảng lịch sử
                    var historyTable = $"{sourceTable}_History";
                    var historyQuery = $@"
            SELECT * 
            FROM {historyTable} 
            WHERE Khoachinh = @primaryKeyValue";

                    DataTable historyData;
                    using (var historyCommand = new SqlCommand(historyQuery, connection, transaction))
                    {
                        historyCommand.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                        using (var adapter = new SqlDataAdapter(historyCommand))
                        {
                            historyData = new DataTable();
                            adapter.Fill(historyData);
                        }
                    }

                    if (historyData.Rows.Count == 0)
                        throw new Exception($"Không tìm thấy dữ liệu cần phục hồi trong bảng {historyTable}.");

                    // Chuẩn bị dữ liệu để phục hồi
                    DataRow rowToRestore = historyData.Rows[0];
                    string[] columns = historyData.Columns.Cast<DataColumn>()
                                        .Where(col => col.ColumnName != "Hanhdong" &&
                                                      col.ColumnName != "Ngaychinhsua" &&
                                                      col.ColumnName != "Banggoc" &&
                                                      col.ColumnName != "Khoachinh")
                                        .Select(col => col.ColumnName)
                                        .ToArray();
                    object[] values = columns.Select(col => rowToRestore[col]).ToArray();

                    // Sử dụng giá trị khóa chính thực tế từ cột khóa chính trong bảng lịch sử
                    object realPrimaryKeyValue = rowToRestore[realPrimaryKeyColumn];

                    // Kiểm tra trước khi xóa trong bảng gốc
                    var checkQuery = $"SELECT COUNT(*) FROM {targetTable} WHERE {realPrimaryKeyColumn} = @realPrimaryKeyValue";
                    using (var checkCommand = new SqlCommand(checkQuery, connection, transaction))
                    {
                        checkCommand.Parameters.AddWithValue("@realPrimaryKeyValue", realPrimaryKeyValue);
                        var exists = (int)checkCommand.ExecuteScalar() > 0;
                        if (!exists)
                            throw new Exception($"Không tìm thấy dòng dữ liệu tương ứng trong bảng gốc {targetTable} để xóa.");
                    }

                    // Xóa dữ liệu hiện tại trong bảng gốc
                    var deleteQuery = $"DELETE FROM {targetTable} WHERE {realPrimaryKeyColumn} = @realPrimaryKeyValue";
                    using (var deleteCommand = new SqlCommand(deleteQuery, connection, transaction))
                    {
                        deleteCommand.Parameters.AddWithValue("@realPrimaryKeyValue", realPrimaryKeyValue);
                        deleteCommand.ExecuteNonQuery();
                    }

                    // Chèn lại dữ liệu từ bảng lịch sử vào bảng gốc
                    var insertQuery = $"INSERT INTO {targetTable} ({string.Join(", ", columns)}) VALUES ({string.Join(", ", columns.Select(c => "@" + c))})";
                    using (var insertCommand = new SqlCommand(insertQuery, connection, transaction))
                    {
                        for (int i = 0; i < columns.Length; i++)
                        {
                            insertCommand.Parameters.AddWithValue("@" + columns[i], values[i] ?? DBNull.Value);
                        }
                        insertCommand.ExecuteNonQuery();
                    }

                    // Xóa dữ liệu đã phục hồi khỏi bảng lịch sử
                    var deleteHistoryQuery = $@"
                    DELETE FROM {historyTable} 
                    WHERE Khoachinh = @primaryKeyValue 
                    AND Ngaychinhsua = @ActionDate";
                    using (var deleteHistoryCommand = new SqlCommand(deleteHistoryQuery, connection, transaction))
                    {
                        deleteHistoryCommand.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);
                        deleteHistoryCommand.Parameters.AddWithValue("@ActionDate", rowToRestore["Ngaychinhsua"]); // Sử dụng giá trị "Ngaychinhsua" từ dòng đã chọn
                        deleteHistoryCommand.ExecuteNonQuery();
                    }

                    // Kích hoạt lại tất cả ràng buộc khóa ngoại
                    var enableConstraintsQuery = "EXEC sp_MSforeachtable 'ALTER TABLE ? CHECK CONSTRAINT ALL'";
                    using (var enableCommand = new SqlCommand(enableConstraintsQuery, connection, transaction))
                    {
                        enableCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    // Đảm bảo bật lại ràng buộc nếu lỗi xảy ra
                    var enableConstraintsQuery = "EXEC sp_MSforeachtable 'ALTER TABLE ? CHECK CONSTRAINT ALL'";
                    using (var enableCommand = new SqlCommand(enableConstraintsQuery, connection))
                    {
                        enableCommand.ExecuteNonQuery();
                    }

                    throw new Exception($"Lỗi khi phục hồi dữ liệu: {ex.Message}", ex);
                }
            }
        }

    }
}
