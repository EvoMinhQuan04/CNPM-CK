using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views.quanLyNhanVienViews
{
    public partial class quanLyNhanVienControl : UserControl
    {
        private readonly nhanVienController nhanVienController;
        private readonly string connectionString;
        private bool isEditing = false;
        private readonly string _tenTaiKhoan;
        public quanLyNhanVienControl(string tenTaiKhoan, string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            nhanVienController = new nhanVienController(connectionString);
            _tenTaiKhoan = tenTaiKhoan;
            labelUsername.Text = $"{_tenTaiKhoan}";
            LoadEmployees();
            maNhanVienTextBox.Enabled = false;
        }

        private void LoadEmployees()
        {
            dataGridViewNhanVien.Rows.Clear();
            var danhSachNhanVien = nhanVienController.LayDanhSachNhanVien();
            foreach (var nv in danhSachNhanVien)
            {
                dataGridViewNhanVien.Rows.Add(
                    nv.MaNhanVien,
                    nv.HoVaTen,
                    nv.NgaySinh?.ToString("dd/MM/yyyy") ?? string.Empty,
                    nv.SoDienThoai,
                    nv.ChucVu,
                    nv.Email

                );
            }
        }

        private void SetEditingMode(bool enable)
        {
            maNhanVienTextBox.Enabled = false;
            hoVaTenTextBox.Enabled = enable;
            emailTextBox.Enabled = enable;
            soDienThoaiTextBox.Enabled = enable;
            ngaySinhDateTimePicker.Enabled = enable;
            chucVuComboBox.Enabled = enable;

            btnChinhSua.Enabled = !enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;

            isEditing = enable;
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var themNhanVienForm = new themNhanVien(nhanVienController))
            {
                themNhanVienForm.NhanVienDaThem += (s, args) => LoadEmployees();
                if (themNhanVienForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployees();
                }
            }

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                SetEditingMode(true); // Chuyển sang chế độ chỉnh sửa
            }
            else
            {
                thongBaoLabel.Text = "Vui lòng chọn một nhân viên để chỉnh sửa.";
                thongBaoLabel.ForeColor = Color.Red;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetEditingMode(false);
            thongBaoLabel.Text = "Bạn đã hủy chỉnh sửa";
            thongBaoLabel.ForeColor = Color.Red;
            thongBaoLabel.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //kiểm tra toàn bộ thông tin trước khi lưu
            string maNhanVien = maNhanVienTextBox.Text.Trim();
            string hoVaTen = hoVaTenTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string soDienThoai = soDienThoaiTextBox.Text.Trim();
            DateTime ngaySinh = ngaySinhDateTimePicker.Value;
            string chucVu = chucVuComboBox.Text.Trim();

            if (string.IsNullOrEmpty(maNhanVien))
            {
                thongBaoLabel.Text = "Vui lòng nhập mã nhân viên.";
                thongBaoLabel.ForeColor = Color.Red;
                maNhanVienTextBox.Focus(); // Focus vào mã nhân viên
                return;
            }
            if (string.IsNullOrEmpty(hoVaTen))
            {
                thongBaoLabel.Text = "Vui lòng nhập họ và tên.";
                thongBaoLabel.ForeColor = Color.Red;
                hoVaTenTextBox.Focus(); // Focus vào họ và tên
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                thongBaoLabel.Text = "Vui lòng nhập email.";
                thongBaoLabel.ForeColor = Color.Red;
                emailTextBox.Focus(); // Focus vào email
                return;
            }
            if (string.IsNullOrEmpty(soDienThoai))
            {
                thongBaoLabel.Text = "Vui lòng nhập số điện thoại.";
                thongBaoLabel.ForeColor = Color.Red;
                soDienThoaiTextBox.Focus(); // Focus vào số điện thoại
                return;
            }
            if (ngaySinh == DateTime.MinValue)
            {
                thongBaoLabel.Text = "Vui lòng chọn ngày sinh.";
                thongBaoLabel.ForeColor = Color.Red;
                ngaySinhDateTimePicker.Focus(); // Focus vào ngày sinh
                return;
            }
            if (string.IsNullOrEmpty(chucVu))
            {
                thongBaoLabel.Text = "Vui lòng chọn chức vụ.";
                thongBaoLabel.ForeColor = Color.Red;
                chucVuComboBox.Focus(); // Focus vào chức vụ
                return;
            }
            if (!string.Equals(chucVu, "Nhân viên", StringComparison.OrdinalIgnoreCase))
            {
                thongBaoLabel.Text = "Chức vụ không hợp lệ. Vui lòng chọn 'Nhân viên'.";
                thongBaoLabel.ForeColor = Color.Red;
                chucVuComboBox.Focus(); // Focus vào ComboBox để người dùng sửa
                return;
            }
            // Sử dụng hàm kiểm tra dữ liệu
            if (!kiemTraDuLieu(maNhanVien, hoVaTen, email, soDienThoai, chucVu))
            {
                return;
            }
            // Lấy thông tin từ các trường nhập
            var nhanVien = new NhanVien
            {
                MaNhanVien = maNhanVienTextBox.Text.Trim(),
                HoVaTen = hoVaTenTextBox.Text.Trim(),
                Email = emailTextBox.Text.Trim(),
                SoDienThoai = soDienThoaiTextBox.Text.Trim(),
                NgaySinh = ngaySinhDateTimePicker.Value,
                ChucVu = chucVuComboBox.Text.Trim()
            };

            // Gọi controller để cập nhật thông tin nhân viên
            bool isUpdated = nhanVienController.CapNhatNhanVien(nhanVien);

            if (isUpdated)
            {
                thongBaoLabel.Text = "Cập nhật thành công.";
                thongBaoLabel.ForeColor = Color.Green;
                LoadEmployees(); // Tải lại danh sách sau khi cập nhật
                SetEditingMode(false); // Quay về chế độ không chỉnh sửa
            }
            else
            {
                thongBaoLabel.Text = "Cập nhật thất bại.";
                thongBaoLabel.ForeColor = Color.Red;
            }
        }
        //các hàm kiểm tra dữ liệu trước khi lưu
        private bool kiemTraDuLieu(string maNhanVien, string hoVaTen, string email, string soDienThoai, string chucVu)
        {

            // Kiểm tra mã nhân viên: phải viết hoa có thể có số và không có khoảng cách
            if (!System.Text.RegularExpressions.Regex.IsMatch(maNhanVien, @"^[A-Z]+[0-9]*$") || maNhanVien.Contains(' '))
            {
                thongBaoLabel.Text = "Mã nhân viên phải viết hoa và có thể chứa số phía sau khi trùng tên, nhưng không có khoảng cách.";
                thongBaoLabel.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            // Kiểm tra họ và tên: phải viết hoa chữ cái đầu mỗi từ
            if (!KiemTraVietHoaChuCaiDau(hoVaTen))
            {
                thongBaoLabel.Text = "Họ và tên phải viết hoa chữ cái đầu mỗi chữ.";
                thongBaoLabel.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            // Kiểm tra định dạng email
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                thongBaoLabel.Text = "Email không hợp lệ.";
                thongBaoLabel.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            // Kiểm tra số điện thoại
            if (!Regex.IsMatch(soDienThoai, @"^0\d{9,10}$"))
            {
                thongBaoLabel.Text = "Số điện thoại không hợp lệ.";
                thongBaoLabel.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //không kiểm tra số điện thoại khi sửa thông tin nhân viên trừ số điện thoại của nhân viên đó tránh khi không chỉnh sửa tới sdt
            if (nhanVienController.kiemTraSoDienThoaiTonTaiTruNhanVien(soDienThoai, maNhanVien))
            {
                thongBaoLabel.Text = "Số điện thoại đã tồn tại. Vui lòng nhập số khác.";
                thongBaoLabel.ForeColor = Color.Red;
                return false; // Dừng nếu số điện thoại bị trùng
            }
            // Kiểm tra ngày sinh: phải từ 18 tuổi trở lên
            if (!KiemTraTuoiHopLe(ngaySinhDateTimePicker.Value))
            {
                thongBaoLabel.Text = "Nhân viên phải từ 18 tuổi trở lên.";
                thongBaoLabel.ForeColor = System.Drawing.Color.Red;
                return false;
            }



            return true;
        }
        //các hàm hỗ trợ kiểm tra dữ liệu
        private bool KiemTraVietHoaChuCaiDau(string hoVaTen)
        {
            // Kiểm tra nếu chuỗi không chứa khoảng trắng
            if (!hoVaTen.Contains(' '))
            {
                return false; // Tên không hợp lệ nếu không có khoảng cách
            }

            string[] words = hoVaTen.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                // Kiểm tra nếu từ không bắt đầu bằng chữ cái viết hoa
                if (!char.IsUpper(word[0]))
                {
                    return false;
                }
            }

            return true;
        }
        private bool KiemTraTuoiHopLe(DateTime ngaySinh)
        {
            int tuoi = DateTime.Now.Year - ngaySinh.Year;

            // Nếu ngày sinh chưa đến sinh nhật trong năm nay, giảm tuổi đi 1
            if (DateTime.Now < ngaySinh.AddYears(tuoi))
            {
                tuoi--;
            }

            return tuoi >= 18;
        }


        private void dataGridViewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewNhanVien.SelectedRows[0];

                // Kiểm tra dòng được chọn có dữ liệu hợp lệ hay không
                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[1].Value != null)
                {
                    // Điền thông tin từ hàng đã chọn vào các TextBox
                    // Xử lý ngày sinh với kiểm tra giá trị null và chuyển đổi an toàn
                    if (selectedRow.Cells[2].Value != null && DateTime.TryParseExact(
                        selectedRow.Cells[2].Value.ToString(),
                        "dd/MM/yyyy",
                        null,
                        System.Globalization.DateTimeStyles.None, out DateTime ngaySinh))
                    {
                        ngaySinhDateTimePicker.Value = ngaySinh;
                    }
                    else
                    {
                        ngaySinhDateTimePicker.Value = DateTime.Now; // Giá trị mặc định nếu không hợp lệ
                    }
                    maNhanVienTextBox.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
                    hoVaTenTextBox.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                    emailTextBox.Text = selectedRow.Cells[5].Value?.ToString() ?? "";
                    soDienThoaiTextBox.Text = selectedRow.Cells[3].Value?.ToString() ?? "";



                    // Điền giá trị vào ComboBox
                    chucVuComboBox.Text = selectedRow.Cells[4].Value?.ToString() ?? "";

                    // Tắt chế độ chỉnh sửa
                    SetEditingMode(false);
                }
                else
                {
                    // Nếu dòng không hợp lệ (trống), reset các TextBox
                    troVeBanDau();
                }
            }
        }

        private void troVeBanDau()
        {
            maNhanVienTextBox.Text = "";
            hoVaTenTextBox.Text = "";
            emailTextBox.Text = "";
            soDienThoaiTextBox.Text = "";
            ngaySinhDateTimePicker.Value = DateTime.Now;
            chucVuComboBox.Text = "";
        }

        private void thongBaoEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var emailForm = new thongBaoQuaEmail(nhanVienController))
            {
                emailForm.ShowDialog();
            }
        }

        private void hieuSuatStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var hieuSuatForm = new baoCaoHieuSuat(nhanVienController))
            {
                hieuSuatForm.ShowDialog();
            }
        }

        private void lienHeHoTroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lienHeTroGiup = new lienHeTroGiup();
            lienHeTroGiup.ShowDialog();
        }

        private void lichSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var lichSuForm = new lichSu(connectionString))
            {
                lichSuForm.ShowDialog();
            }
        }

        private void locNhanVienStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (nhanVienController == null || string.IsNullOrEmpty(connectionString))
            {
                return;
            }

            // Khởi tạo form locThongTinKhachHang và truyền vào connectionString và instance của quanLyKhachHangControl
            using (var locForm = new locThongTinNhanVien(connectionString, this))
            {
                locForm.ShowDialog();
            }
        }
    }
}
