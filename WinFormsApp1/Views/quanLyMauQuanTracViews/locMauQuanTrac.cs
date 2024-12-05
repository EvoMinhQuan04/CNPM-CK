using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views.quanLyMauQuanTracViews
{
    public partial class locMauQuanTrac : Form
    {
        private mauQuanTracController _mauQuanTracController;
        public locMauQuanTrac(string connectionString)
        {
            InitializeComponent();
            _mauQuanTracController = new mauQuanTracController(connectionString);
            duLieuComboBox();
        }

        private void duLieuComboBox()
        {
            // Lấy danh sách ngày lấy và ngày trả từ database
            var danhSachMau = _mauQuanTracController.LayDanhSachMauQuanTrac();

            var ngayLay = danhSachMau.Select(m => m.NgayLay).Distinct().OrderBy(d => d).ToList();
            var ngayTra = danhSachMau.Select(m => m.NgayTra).Distinct().OrderBy(d => d).ToList();

            cbBoxNgayLay.Items.Clear();
            cbBoxNgayLay.Items.AddRange(ngayLay.Select(d => d.ToString("dd/MM/yyyy")).ToArray());

            cbBoxNgayTra.Items.Clear();
            cbBoxNgayTra.Items.AddRange(ngayTra.Select(d => d.ToString("dd/MM/yyyy")).ToArray());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuLieu(out string? maHopDong, out string? maMau, out string? maNhanVien, out DateTime? ngayLay, out DateTime? ngayTra))
            {
                return;
            }

            try
            {
                var danhSachLoc = _mauQuanTracController.LocMauQuanTrac(maMau, maNhanVien, maHopDong, ngayLay, ngayTra);
                if (danhSachLoc == null)
                {
                    lblThongBao.Text = "Không tìm thấy mẫu quan trắc nào.";
                    lblThongBao.ForeColor = Color.Red;
                    return;
                }

                // Hiển thị kết quả lọc trong DataGridView
                dataGridViewMauQuanTrac.Rows.Clear();
                foreach (var mau in danhSachLoc)
                {
                    dataGridViewMauQuanTrac.Rows.Add(
                        mau.MaMau ?? string.Empty,
                        mau.MaHopDong ?? string.Empty,
                        mau.TenMau ?? string.Empty,
                        mau.NoiDung ?? string.Empty,
                        mau.NgayLay.ToString("dd/MM/yyyy"),
                        mau.NgayTra.ToString("dd/MM/yyyy"),
                        mau.MaNhanVien ?? string.Empty
                    );
                }


                // Thông báo kết quả
                if (danhSachLoc.Count == 0)
                {
                    lblThongBao.Text = "Không tìm thấy mẫu quan trắc nào thỏa mãn điều kiện.";
                    lblThongBao.ForeColor = Color.Red;
                }
                else
                {
                    lblThongBao.Text = $"Tìm thấy {danhSachLoc.Count} mẫu quan trắc.";
                    lblThongBao.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                lblThongBao.Text = "Đã xảy ra lỗi: " + ex.Message;
                lblThongBao.ForeColor = Color.Red;
            }
        }

        //validate dữ liệu
        private bool kiemTraDuLieu(out string? maHopDong, out string? maMau, out string? maNhanVien, out DateTime? ngayLay, out DateTime? ngayTra)
        {
            // Lấy dữ liệu từ các ô nhập
            maHopDong = string.IsNullOrWhiteSpace(txtMaHopDong.Text) ? null : txtMaHopDong.Text.Trim();
            ngayLay = cbBoxNgayLay.SelectedItem != null && cbBoxNgayLay.SelectedItem.ToString() != null
                ? DateTime.ParseExact(cbBoxNgayLay.SelectedItem.ToString(), "dd/MM/yyyy", null).Date
                : (DateTime?)null;
            ngayTra = cbBoxNgayTra.SelectedItem != null && cbBoxNgayTra.SelectedItem.ToString() != null
                ? DateTime.ParseExact(cbBoxNgayTra.SelectedItem.ToString(), "dd/MM/yyyy", null).Date
                : (DateTime?)null;
            maMau = string.IsNullOrWhiteSpace(txtMaMau.Text) ? null : txtMaMau.Text.Trim();
            maNhanVien = string.IsNullOrWhiteSpace(txtMaNhanVien.Text) ? null : txtMaNhanVien.Text.Trim();

            // Reset thông báo
            lblThongBao.Text = string.Empty;
            lblThongBao.ForeColor = Color.Red;

            // 1. Kiểm tra nếu tất cả các trường đều trống
            if (string.IsNullOrWhiteSpace(maHopDong) && ngayLay == null && ngayTra == null && string.IsNullOrWhiteSpace(maMau) && string.IsNullOrWhiteSpace(maNhanVien) )
            {
                lblThongBao.Text = "Vui lòng nhập ít nhất một thuộc tính để lọc.";
                return false;
            }

            // 2. Kiểm tra nếu chỉ chọn Ngày lấy mà không chọn Ngày trả
            if (ngayLay != null && ngayTra == null)
            {
                lblThongBao.Text = "Vui lòng chọn cả ngày trả khi đã chọn ngày lấy.";
                return false;
            }

            if (ngayLay == null && ngayTra != null)
            {
                lblThongBao.Text = "Vui lòng chọn cả ngày lấy khi đã chọn ngày trả.";
                return false;
            }
            if (ngayLay.HasValue && ngayTra.HasValue && ngayLay > ngayTra)
            {
                lblThongBao.Text = "Ngày lấy phải nhỏ hơn hoặc bằng ngày trả.";
                return false;

            }
            // Kiểm tra định dạng mã hợp đồng (chỉ kiểm tra nếu giá trị không rỗng)
            if (!string.IsNullOrWhiteSpace(maHopDong) &&
                !System.Text.RegularExpressions.Regex.IsMatch(maHopDong, @"^\d{2}\.\d{3}$"))
            {
                lblThongBao.Text = "Mã hợp đồng không đúng định dạng. Định dạng hợp lệ: 24.xxx. 24 đại diện cho năm, xxx là số có 3 chữ số";
                return false;
            }

            // Kiểm tra định dạng mã mẫu (chỉ kiểm tra nếu giá trị không rỗng)
            if (!string.IsNullOrWhiteSpace(maMau) &&
                !System.Text.RegularExpressions.Regex.IsMatch(maMau, @"^(NM|KK|NT|D)\d+$"))
            {
                lblThongBao.Text = "Mã mẫu không đúng định dạng. Định dạng hợp lệ: NMx, KKx, NTx, Dx. Với x là số hoặc nhiều số";
                return false;
            }

            // Kiểm tra định dạng mã nhân viên (chỉ kiểm tra nếu giá trị không rỗng)
            if (!string.IsNullOrWhiteSpace(maNhanVien) &&
                (!System.Text.RegularExpressions.Regex.IsMatch(maNhanVien, @"^[A-Z]+[0-9]*$") || maNhanVien.Contains(' ')))
            {
                lblThongBao.Text = "Mã nhân viên phải viết hoa và có thể chứa số phía sau nếu trùng tên, nhưng không có khoảng cách.";
                return false;
            }


            // Kiểm tra nếu mã hợp đồng không tồn tại
            if (!string.IsNullOrWhiteSpace(maHopDong) && !_mauQuanTracController.KiemTraMaHopDongTonTai(maHopDong))
            {
                lblThongBao.Text = $"Mã hợp đồng '{maHopDong}' không tồn tại.";
                lblThongBao.ForeColor = Color.Red;
                txtMaHopDong.Focus();
                return false;
            }
            //kiểm tra nếu mã mẫu không tồn tại
            if (!string.IsNullOrWhiteSpace(maMau) && !_mauQuanTracController.KiemTraMaMauTonTai(maMau))
            {
                lblThongBao.Text = $"Mã mẫu '{maMau}' không tồn tại.";
                lblThongBao.ForeColor = Color.Red;
                txtMaMau.Focus();
                return false;
            }
            //kiểm tra nếu mã nhân viên không tồn tại
            if (!string.IsNullOrWhiteSpace(maNhanVien) && !_mauQuanTracController.KiemTraMaNhanVienTonTai(maNhanVien))
            {
                lblThongBao.Text = $"Mã nhân viên '{maNhanVien}' không tồn tại.";
                lblThongBao.ForeColor = Color.Red;
                txtMaNhanVien.Focus();
                return false;
            }

            return true;
        }
    }
}
