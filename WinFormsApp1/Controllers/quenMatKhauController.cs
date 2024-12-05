// Controllers/quenMatKhauController.cs
namespace WinFormsApp1.Controllers
{
    public class quenMatKhauController
    {
        private readonly string _connectionString;

        public quenMatKhauController(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Cung cấp phương thức lấy chuỗi kết nối
        public string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
