using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Views;
using WinFormsApp1.Controllers;
using WinFormsApp1.UI;
using System.Text.RegularExpressions;
namespace WinFormsApp1.Controllers
{
    public partial class quanLyKhachHangControl : UserControl
    {
        private khachHangController? khachHangController;
        private string? connectionString;
        private readonly string _tenTaiKhoan;


        public quanLyKhachHangControl(string tenTaiKhoan, string connectionString)
        {
            InitializeComponent();
            _tenTaiKhoan = tenTaiKhoan;
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            khachHangController = new khachHangController(connectionString);
            labelUsername.Text = $"{_tenTaiKhoan}";
            LoadCustomers();
            SetEditingMode(false);
        }

        private void LoadCustomers()
        {

            if (khachHangController == null)
            {
                lblThongBao.Text = "Không thể kết nối đến cơ sở dữ liệu!";
                return;
            }

            dataGridViewKhachHang.Rows.Clear();
            var danhSachKhachHang = khachHangController.LayDanhSachKhachHang();

            foreach (var kh in danhSachKhachHang)
            {
                dataGridViewKhachHang.Rows.Add(
                    kh.MaKhachHang,
                    kh.TenCongTy,
                    kh.Email,
                    kh.DiaChi,
                    kh.MaHopDong,
                    kh.SoDienThoai,
                    kh.NguoiDaiDien
                );
            }
        }


        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView hay không
            if (dataGridViewKhachHang.SelectedRows.Count == 0 || dataGridViewKhachHang.CurrentRow == null)
            {
                // Hiển thị thông báo lỗi nếu không có hàng nào được chọn
                lblThongBao.Text = "Vui lòng chọn một khách hàng để chỉnh sửa.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                return;
            }
            SetEditingMode(true);
        }

        private void SetEditingMode(bool enable)
        {
            maKhachHangTextBox.Enabled = false;
            txtTenCongTy.Enabled = enable;
            diaChiTextBox.Enabled = enable;
            nguoiDaiDienTextBox.Enabled = enable;
            maHopDongTextBox.Enabled = false;
            soDienThoaiTextBox.Enabled = enable;
            emailTextBox.Enabled = enable;

            btnChinhSua.Enabled = !enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            if (!enable)
            {
                lblThongBao.Visible = true; // Đảm bảo thông báo không bị ẩn khi tắt chế độ chỉnh sửa
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maKhachHang = maKhachHangTextBox.Text.Trim();
            string maHopDong = maHopDongTextBox.Text.Trim();
            if (string.IsNullOrEmpty(connectionString))
            {
                return;
            }

            if (string.IsNullOrEmpty(connectionString))
            {
                lblThongBao.Text = "Kết nối cơ sở dữ liệu không khả dụng.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                return;
            }
            //kiểm tra nhập đầy đủ thông tin trước khi lưu
            if (!KiemTraThongTin(maKhachHangTextBox, txtTenCongTy, diaChiTextBox, nguoiDaiDienTextBox, maHopDongTextBox, soDienThoaiTextBox, emailTextBox))
            {
                return;
            }
            // Kiểm tra định dạng dữ liệu trước khi lưu
            if (!kiemTraDinhDang())
            {
                return;
            }

            var kh = new KhachHang
            {
                MaKhachHang = maKhachHangTextBox.Text.Trim(),
                TenCongTy = txtTenCongTy.Text.Trim(),
                DiaChi = diaChiTextBox.Text.Trim(),
                NguoiDaiDien = nguoiDaiDienTextBox.Text.Trim(),
                MaHopDong = maHopDongTextBox.Text.Trim(),
                SoDienThoai = soDienThoaiTextBox.Text.Trim(),
                Email = emailTextBox.Text.Trim()
            };
            bool capNhat = KhachHang.CapNhatKhachHang(connectionString, kh);
            if (capNhat)
            {
                dataGridViewKhachHang.Rows.Clear();
                LoadCustomers();           
                lblThongBao.Text = "Cập nhật thông tin khách hàng thành công!";
                lblThongBao.ForeColor = Color.Green;
                lblThongBao.Visible = true;

                SetEditingMode(false);
            }
            else
            {
                lblThongBao.Text = "Cập nhật thất bại.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
            }
        }
        //kiểm tra nhập đầy đủ thông tin
        private bool KiemTraThongTin(TextBox maKhachHangTextBox, TextBox tenCongTyTextBox, TextBox diaChiTextBox, TextBox nguoiDaiDienTextBox, TextBox maHopDongTextBox, TextBox soDienThoaiTextBox, TextBox emailTextBox)
        {
            if (string.IsNullOrEmpty(maKhachHangTextBox.Text.Trim()))
            {
                lblThongBao.Text = "Vui lòng nhập mã khách hàng.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                maKhachHangTextBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tenCongTyTextBox.Text.Trim()))
            {
                lblThongBao.Text = "Vui lòng nhập tên công ty.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                tenCongTyTextBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(diaChiTextBox.Text.Trim()))
            {
                lblThongBao.Text = "Vui lòng nhập địa chỉ.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                diaChiTextBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(nguoiDaiDienTextBox.Text.Trim()))
            {
                lblThongBao.Text = "Vui lòng nhập người đại diện.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                nguoiDaiDienTextBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(maHopDongTextBox.Text.Trim()))
            {
                lblThongBao.Text = "Vui lòng nhập mã hợp đồng.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                maHopDongTextBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(soDienThoaiTextBox.Text.Trim()))
            {
                lblThongBao.Text = "Vui lòng nhập số điện thoại.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                soDienThoaiTextBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(emailTextBox.Text.Trim()))
            {
                lblThongBao.Text = "Vui lòng nhập email.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                emailTextBox.Focus();
                return false;
            }

            return true;
        }

        //kiểm tra định dạng dữ liệu trước khi lưu
        private bool kiemTraDinhDang()
        {
            // Kiểm tra mã khách hàng: Tiền tố luôn là KH (in hoa) + số (ít nhất 1 chữ số)
            if (!Regex.IsMatch(maKhachHangTextBox.Text, @"^KH\d+$"))
            {
                lblThongBao.Text = "Mã khách hàng sai định dạng. Định dạng hợp lệ là KHx với x là số.";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            if (!Regex.IsMatch(maHopDongTextBox.Text, @"^\d{2}\.\d{3}$"))
            {
                lblThongBao.Text = "Mã hợp đồng sai định dạng. Định dạng hợp lệ xx.y với xx đại diện năm, y là số gồm 3 chữ số";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            int xxPart = int.Parse(maHopDongTextBox.Text.Split('.')[0]);
            if (xxPart < 24)
            {
                lblThongBao.Text = "Phần xx của mã hợp đồng phải lớn hơn hoặc bằng 24.";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            // Kiểm tra số điện thoại
            if (!Regex.IsMatch(soDienThoaiTextBox.Text, @"^0\d{9,10}$"))
            {
                lblThongBao.Text = "Số điện thoại không hợp lệ.";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            // kiểm tra số điện thoại k trùng trừ chính khách hàng đó
            if (khachHangController.KiemTraSoDienThoaiTonTaiTruKhachHang(soDienThoaiTextBox.Text, maKhachHangTextBox.Text))
            {
                lblThongBao.Text = "Số điện thoại đã tồn tại.";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            // Kiểm tra định dạng email
            if (!Regex.IsMatch(emailTextBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblThongBao.Text = "Email không hợp lệ.";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            return true;
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (khachHangController == null)
            {
                return;
            }
            using (var themKhachHangForm = new themKhachHang(khachHangController))
            {
                themKhachHangForm.khachHangThem += (s, args) => LoadCustomers();
                if (themKhachHangForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomers();
                }
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có hàng nào được chọn
            if (dataGridViewKhachHang.SelectedRows.Count > 0 || dataGridViewKhachHang.CurrentRow != null)
            {
                // Lấy giá trị mã khách hàng từ hàng được chọn
                string maKhachHang = dataGridViewKhachHang.CurrentRow.Cells["MaKhachHang"].Value?.ToString() ?? "";

                lblThongBao.Text = "Hủy chỉnh sửa thành công!";
                lblThongBao.ForeColor = Color.Green;
                lblThongBao.Visible = true;
            }
            SetEditingMode(false);
        }


        private void MenuItemLocKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHangController == null || string.IsNullOrEmpty(connectionString))
            {
                return;
            }

            // Khởi tạo form locThongTinKhachHang và truyền vào connectionString và instance của quanLyKhachHangControl
            using (var locForm = new locThongTinKhachHang(connectionString, this))
            {
                locForm.ShowDialog();
            }

        }

        private void troGiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lienHeTroGiup = new lienHeTroGiup();
            lienHeTroGiup.ShowDialog();
        }

        
        private void troVeBanDau()
        {
            // Xóa nội dung của tất cả các TextBox
            maKhachHangTextBox.Text = "";
            txtTenCongTy.Text = "";
            emailTextBox.Text = "";
            diaChiTextBox.Text = "";
            maHopDongTextBox.Text = "";
            soDienThoaiTextBox.Text = "";
            nguoiDaiDienTextBox.Text = "";

            // Đặt thông báo trạng thái (nếu cần)
            lblThongBao.Text = "";
            lblThongBao.Visible = false;
        }

        private void dataGridViewKhachHang_SelectionChanged(object sender, EventArgs e)
        {

            // Kiểm tra nếu có hàng nào được chọn
            if (dataGridViewKhachHang.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridViewKhachHang.SelectedRows[0];

                // Kiểm tra nếu hàng không có dữ liệu
                if (selectedRow.Cells["MaKhachHang"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["MaKhachHang"].Value.ToString()))
                {
                    // Gọi hàm để reset các TextBox
                    troVeBanDau();
                    return;
                }

                // Nếu có dữ liệu, hiển thị trong các TextBox
                maKhachHangTextBox.Text = selectedRow.Cells["MaKhachHang"].Value?.ToString();
                txtTenCongTy.Text = selectedRow.Cells["TenCongTy"].Value?.ToString();
                emailTextBox.Text = selectedRow.Cells["Email"].Value?.ToString();
                diaChiTextBox.Text = selectedRow.Cells["DiaChi"].Value?.ToString();
                maHopDongTextBox.Text = selectedRow.Cells["MaHopDong"].Value?.ToString();
                soDienThoaiTextBox.Text = selectedRow.Cells["SoDienThoai"].Value?.ToString();
                nguoiDaiDienTextBox.Text = selectedRow.Cells["NguoiDaiDien"].Value?.ToString();
            }
            else
            {
                // Không có hàng nào được chọn, reset TextBox
                troVeBanDau();
            }
        }
    }
}
