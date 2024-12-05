using WinFormsApp1.UI;
using WinFormsApp1.Views;
using WinFormsApp1.Models;
using WinFormsApp1.Controllers;
namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuanLyMauKiemDinhMoiTruong;Integrated Security=True";
            var controller = new dangNhapController(connectionString);
            var formDangNhap = new dangNhap(controller);
   
            Application.Run(formDangNhap);

        }
    }
}