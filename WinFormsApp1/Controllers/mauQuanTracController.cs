using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
namespace WinFormsApp1.Controllers
{
    
    public class mauQuanTracController
    {
        public string connectionString;
        public mauQuanTracController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Models.MauQuanTrac> LayDanhSachMauQuanTrac()
        {
            return Models.MauQuanTrac.LayDanhSachMauQuanTrac(connectionString);
        }

        public bool ThemMauQuanTrac(MauQuanTrac mauQuanTrac)
        {
            return MauQuanTrac.ThemMauQuanTrac(connectionString, mauQuanTrac);
        }

        public List<MauQuanTrac> LocMauQuanTrac(string? maHopDong, string? maMau, string? maNhanVien, DateTime? ngayLay, DateTime? ngayTra)
        {
            return MauQuanTrac.LocMauQuanTrac(connectionString, maHopDong, maMau, maNhanVien, ngayLay, ngayTra);
        }

        public bool CapNhatMauQuanTrac(MauQuanTrac mauQuanTrac)
        {
            return MauQuanTrac.CapNhatMauQuanTrac(connectionString, mauQuanTrac);
        }


        //kiểm tra tồn tại mã hợp đồng khi thêm mẫu quan trắc
        public bool KiemTraMaHopDongTonTai(string maHopDong)
        {
            return MauQuanTrac.KiemTraMaHopDongTonTai(maHopDong, connectionString);
        }
        //kiểm tra tồn tại mã nhân viên khi thêm mẫu quan trắc
        public bool KiemTraMaNhanVienTonTai(string maNhanVien)
        {
            return MauQuanTrac.KiemTraMaNhanVienTonTai(maNhanVien, connectionString);
        }
        //kiểm tra tồn tại mã mẫu khi thêm mẫu quan trắc
        public bool KiemTraMaMauTonTai(string maMau)
        {
            return MauQuanTrac.KiemTraMaMauTonTai(connectionString, maMau);
        }







    }
}
