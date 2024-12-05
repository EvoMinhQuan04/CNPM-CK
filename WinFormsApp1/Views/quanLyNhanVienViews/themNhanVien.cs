using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class themNhanVien : Form
    {
        private readonly nhanVienController _nhanVienController;
        private readonly NhanVien? _nhanVien;
        private System.Windows.Forms.Timer clearFormTimer;
        public themNhanVien(nhanVienController controller, NhanVien? nhanVien = null)
        {
            InitializeComponent();
            InitializeClearFormTimer();
            clearFormTimer = new System.Windows.Forms.Timer();
            _nhanVienController = controller ?? throw new ArgumentNullException(nameof(controller));
            _nhanVien = nhanVien;
            NhanVienDaThem = delegate { };
            if (_nhanVien != null)
            {
                LoadNhanVienData(); // Hiển thị thông tin nếu cập nhật
            }
        }

        private void InitializeClearFormTimer()
        {
            clearFormTimer = new System.Windows.Forms.Timer();
            clearFormTimer.Interval = 2000; // 2 giây
            clearFormTimer.Tick += ClearFormTimer_Tick;
        }

        private void ClearFormTimer_Tick(object? sender, EventArgs e)
        {
            clearFormTimer.Stop(); // Dừng timer sau khi chạy
            ClearForm(); // Xóa dữ liệu trên form
            thongBaoLabel.Text = ""; // Xóa thông báo sau khi clear form
        }

        private void LoadNhanVienData()
        {
            if (_nhanVien == null)
            {
                throw new InvalidOperationException("NhanVien object is null.");
            }
            maNhanVienTextBox.Text = _nhanVien.MaNhanVien;
            hoVaTenTextBox.Text = _nhanVien.HoVaTen;
            emailTextBox.Text = _nhanVien.Email;
            soDienThoaiTextBox.Text = _nhanVien.SoDienThoai;
            ngaySinhDateTimePicker.Value = _nhanVien.NgaySinh ?? DateTime.Now;
            chucVuComboBox.Text = _nhanVien.ChucVu;
            maNhanVienTextBox.Enabled = false; // Không cho phép chỉnh sửa mã nhân viên khi cập nhật
        }

        private void ClearForm()
        {
            maNhanVienTextBox.Clear();
            hoVaTenTextBox.Clear();
            emailTextBox.Clear();
            soDienThoaiTextBox.Clear();
            ngaySinhDateTimePicker.Value = DateTime.Now;
            chucVuComboBox.SelectedIndex = -1;
        }

        public event EventHandler NhanVienDaThem;

        private void OnNhanVienDaThem()
        {
            NhanVienDaThem?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void luuThemNV_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin nhập
            string maNhanVien = maNhanVienTextBox.Text.Trim();
            string hoVaTen = hoVaTenTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string soDienThoai = soDienThoaiTextBox.Text.Trim();
            DateTime ngaySinh = ngaySinhDateTimePicker.Value;
            string chucVu = chucVuComboBox.Text.Trim();
            //kiểm tra điền đầy đủ thông tin

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

            

            if (!kiemTraDuLieu(maNhanVien, hoVaTen, email, soDienThoai, chucVu))
            {
                return; // Dừng nếu dữ liệu không hợp lệ
            }

            // Kiểm tra xem mã nhân viên đã tồn tại trong cơ sở dữ liệu chưa
            if (_nhanVienController.kiemTraMaNhanVienTonTai(maNhanVien))
            {
                thongBaoLabel.Text = "Mã nhân viên đã tồn tại. Vui lòng nhập mã khác.";
                thongBaoLabel.ForeColor = Color.Red;
                return; // Dừng nếu mã nhân viên đã tồn tại
            }

            var nhanVien = new NhanVien
            {
                MaNhanVien = maNhanVien,
                HoVaTen = hoVaTen,
                Email = email,
                SoDienThoai = soDienThoai,
                NgaySinh = ngaySinh,
                ChucVu = chucVu
            };

            bool success = false;

            // Chỉ thêm mới nhân viên
            if (_nhanVien == null)
            {
                success = _nhanVienController.ThemNhanVien(nhanVien);

                // Hiển thị thông báo dựa trên kết quả
                thongBaoLabel.Text = success ? "Thêm nhân viên thành công!" : "Lỗi khi thêm nhân viên.";
                thongBaoLabel.ForeColor = success ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }
            else
            {
                thongBaoLabel.Text = "Nhân viên đã tồn tại. Không thể thêm nhân viên mới.";
                thongBaoLabel.ForeColor = System.Drawing.Color.Red;
            }


            if (success)
            {
                NhanVienDaThem?.Invoke(this, EventArgs.Empty); // Kích hoạt sự kiện để cập nhật danh sách
                clearFormTimer.Start(); // Bắt đầu đếm thời gian xóa dữ liệu form
            }
        }

        // Kiểm tra tính hợp lệ của form
        private bool kiemTraDuLieu(string maNhanVien, string hoVaTen, string email, string soDienThoai, string chucVu)
        {

            // Kiểm tra mã nhân viên: phải viết hoa có thể có số nếu mã nhân viên trùng và không có khoảng cách
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
            if (_nhanVienController.kiemTraSoDienThoaiTonTai(soDienThoai))
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




        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearForm();
            thongBaoLabel.Text = ""; 
        }
    }
}
