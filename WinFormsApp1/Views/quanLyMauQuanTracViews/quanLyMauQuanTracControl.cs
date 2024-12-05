using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;
using WinFormsApp1.Views.quanLyMauQuanTracViews;
namespace WinFormsApp1.Views.quanLyMauQuanTracViews
{
    public partial class quanLyMauQuanTracControl : UserControl
    {
        private readonly string _tenTaiKhoan;
        private mauQuanTracController _mauQuanTracController;

        public quanLyMauQuanTracControl(string tenTaiKhoan, string connectionString)
        {
            InitializeComponent();
            _tenTaiKhoan = tenTaiKhoan;
            _mauQuanTracController = new mauQuanTracController(connectionString);
            labelUserName.Text = $"{_tenTaiKhoan}";
            duLieuMauQuanTrac();
            maHopDongTextBox.Enabled = false;
            maMauTextBox.Enabled = false;
            maNhanVienTextBox.Enabled = false;

        }



        private void duLieuMauQuanTrac()
        {
            // Lấy danh sách mẫu quan trắc từ Controller
            try
            {
                List<MauQuanTrac> danhSachMauQuanTrac = _mauQuanTracController.LayDanhSachMauQuanTrac();

                if (danhSachMauQuanTrac.Count == 0)
                {
                    lblThongBao.Text = "Không có dữ liệu để hiển thị!";
                    lblThongBao.ForeColor = Color.Red;
                    return;
                }

                // Thêm từng mẫu quan trắc vào DataGridView
                foreach (var mau in danhSachMauQuanTrac)
                {
                    dataGridViewMauQuanTrac.Rows.Add(
                        mau.MaMau,
                        mau.MaHopDong,
                        mau.TenMau,
                        mau.NoiDung,
                        mau.NgayLay.ToString("dd/MM/yyyy"),
                        mau.NgayTra.ToString("dd/MM/yyyy"),
                        mau.MaNhanVien
                    );
                }
            }
            catch (Exception ex)
            {
                lblThongBao.Text = $"Lỗi khi tải dữ liệu: {ex.Message}";
                lblThongBao.ForeColor = Color.Red;
            }
        }

        private void setEdit(bool enable)
        {
            maMauTextBox.Enabled = false;
            maHopDongTextBox.Enabled = false;
            tenMauTextBox.Enabled = enable;
            noiDungTextBox.Enabled = enable;
            dtpNgayLay.Enabled = enable;
            dtpNgayTra.Enabled = enable;
            maNhanVienTextBox.Enabled = enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;

        }

        private void dataGridViewMauQuanTrac_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMauQuanTrac.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewMauQuanTrac.SelectedRows[0];

                // Kiểm tra nếu hàng không có dữ liệu
                if (selectedRow.Cells["MaMau"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["MaMau"].Value.ToString()))
                {
                    // Gọi hàm để reset các TextBox
                    troVeBanDau();
                    return;
                }

                // Gán giá trị từ hàng được chọn vào các TextBox
                maMauTextBox.Text = selectedRow.Cells["MaMau"].Value?.ToString();
                maHopDongTextBox.Text = selectedRow.Cells["MaHopDong"].Value?.ToString();
                tenMauTextBox.Text = selectedRow.Cells["TenMau"].Value?.ToString();
                noiDungTextBox.Text = selectedRow.Cells["NoiDung"].Value?.ToString();
                dtpNgayLay.Value = DateTime.ParseExact(selectedRow.Cells["NgayLay"].Value?.ToString(), "dd/MM/yyyy", null);
                dtpNgayTra.Value = DateTime.ParseExact(selectedRow.Cells["NgayTra"].Value?.ToString(), "dd/MM/yyyy", null);
                maNhanVienTextBox.Text = selectedRow.Cells["MaNhanVien"].Value?.ToString();
            }
            else
            {
                // Nếu không có hàng nào được chọn, xóa nội dung các TextBox
                troVeBanDau();
            }

            setEdit(false);
        }

        private void troVeBanDau()
        {
            // Reset nội dung các TextBox
            maMauTextBox.Text = string.Empty;
            maHopDongTextBox.Text = string.Empty;
            tenMauTextBox.Text = string.Empty;
            noiDungTextBox.Text = string.Empty;
            maNhanVienTextBox.Text = string.Empty;

            // Đặt giá trị mặc định cho các DateTimePicker
            dtpNgayLay.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;

            // Ẩn thông báo lỗi hoặc thông tin
            lblThongBao.Text = string.Empty;
            lblThongBao.Visible = false;

            // Reset màu sắc hoặc trạng thái khác 
            lblThongBao.ForeColor = Color.Black;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "Bạn đã hủy chỉnh sửa!";
            lblThongBao.ForeColor = Color.Red;
            setEdit(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


            // Tạo đối tượng MauQuanTrac với dữ liệu từ các TextBox và ComboBox
            var mau = new MauQuanTrac
            {
                MaMau = maMauTextBox.Text.Trim(),
                MaHopDong = maHopDongTextBox.Text.Trim(),
                TenMau = tenMauTextBox.Text.Trim(),
                NoiDung = noiDungTextBox.Text.Trim(),
                NgayLay = dtpNgayLay.Value,
                NgayTra = dtpNgayTra.Value,
                MaNhanVien = maNhanVienTextBox.Text.Trim()
            };

            if (!kiemTraDuLieu())
            {
                return;
            }

            // Gọi hàm cập nhật từ model MauQuanTrac
            if (_mauQuanTracController.CapNhatMauQuanTrac(mau))
            {
                dataGridViewMauQuanTrac.Rows.Clear();
                duLieuMauQuanTrac();
                lblThongBao.Text = "Cập nhật thông tin mẫu quan trắc thành công.";
                lblThongBao.ForeColor = Color.Green;
                lblThongBao.Visible = true;

                setEdit(false);
            }
            else
            {
                lblThongBao.Text = "Lỗi khi cập nhật thông tin mẫu quan trắc.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
            }
        }

        //kiểm tra dữ liệu trước khi cập nhật
        private bool kiemTraDuLieu()
        {
            lblThongBao.Text = string.Empty;
            lblThongBao.ForeColor = Color.Red;

            if (string.IsNullOrWhiteSpace(maMauTextBox.Text))
            {
                lblThongBao.Text = "Mã mẫu không được để trống.";
                maMauTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(maHopDongTextBox.Text))
            {
                lblThongBao.Text = "Mã hợp đồng không được để trống.";
                maHopDongTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tenMauTextBox.Text))
            {
                lblThongBao.Text = "Tên mẫu không được để trống.";
                tenMauTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(noiDungTextBox.Text))
            {
                lblThongBao.Text = "Nội dung không được để trống.";
                noiDungTextBox.Focus();
                return false;
            }

            if (dtpNgayLay.Value > dtpNgayTra.Value)
            {
                lblThongBao.Text = "Ngày lấy không được lớn hơn ngày trả.";
                dtpNgayLay.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(maNhanVienTextBox.Text))
            {
                lblThongBao.Text = "Mã nhân viên không được để trống.";
                maNhanVienTextBox.Focus();
                return false;
            }
            //kiểm tra định dạng mã nhân viên phải viết hoa và có thể chứa số phía sau nếu trùng tên, nhưng không có khoảng cách.
            if (!Regex.IsMatch(maNhanVienTextBox.Text.Trim(), @"^[A-Z]+[0-9]*$") || maNhanVienTextBox.Text.Trim().Contains(' '))
            {
                lblThongBao.Text = "Mã nhân viên phải viết hoa và có thể chứa số phía sau nếu trùng tên, nhưng không có khoảng cách.";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }





            // Kiểm tra nếu mã hợp đồng không tồn tại
            if (!_mauQuanTracController.KiemTraMaHopDongTonTai(maHopDongTextBox.Text.Trim()))
            {
                lblThongBao.Text = "Mã hợp đồng không tồn tại.";
                maHopDongTextBox.Focus();
                return false;
            }
            
            // Kiểm tra nếu mã nhân viên không tồn tại
            if (!_mauQuanTracController.KiemTraMaNhanVienTonTai(maNhanVienTextBox.Text.Trim()))
            {
                lblThongBao.Text = "Mã nhân viên không tồn tại.";
                maNhanVienTextBox.Focus();
                return false;
            }

            return true;
        }


        private void menuItemThem_Click(object sender, EventArgs e)
        {
            var formThemMauQuanTrac = new themMauQuanTrac(_mauQuanTracController.connectionString);

            formThemMauQuanTrac.luuDuLieu += (s, args) =>
            {
                dataGridViewMauQuanTrac.Rows.Clear();
                duLieuMauQuanTrac();
            };

            formThemMauQuanTrac.ShowDialog();

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            setEdit(true);
        }

        private void menuItemLoc_Click(object sender, EventArgs e)
        {
            Form locMauQuanTrac = new locMauQuanTrac(_mauQuanTracController.connectionString);
            locMauQuanTrac.ShowDialog();

        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form lienHeTroGiup = new lienHeTroGiup();
            lienHeTroGiup.ShowDialog();
        }

        
    }
}
