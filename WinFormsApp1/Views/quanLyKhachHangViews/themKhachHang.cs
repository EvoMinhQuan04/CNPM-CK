using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class themKhachHang : Form
    {
        private readonly khachHangController? khachHangController;
        private System.Windows.Forms.Timer clearFormTimer;

        public themKhachHang(khachHangController controller)
        {
            InitializeComponent();
            InitializeClearFormTimer();
            clearFormTimer = new System.Windows.Forms.Timer();
            khachHangController = controller ?? throw new ArgumentNullException(nameof(controller));
            khachHangThem = delegate { };
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

        private void ClearForm()
        {
            maKhachHangTextBox.Clear();
            tenCongTyTextBox.Clear();
            diaChiTextBox.Clear();
            nguoiDaiDienTextBox.Clear();
            maHopDongTextBox.Clear();
            soDienThoaiTextBox.Clear();
            emailTextBox.Clear();
        }

        public event EventHandler khachHangThem;

        private void OnKhachHangThem()
        {
            khachHangThem?.Invoke(this, EventArgs.Empty);
        }


        private void bntThem_Click(object sender, EventArgs e)
        {

            // Lấy dữ liệu từ các textbox
            string maKhachHang = maKhachHangTextBox.Text.Trim();
            string tenCongTy = tenCongTyTextBox.Text.Trim();
            string diaChi = diaChiTextBox.Text.Trim();
            string nguoiDaiDien = nguoiDaiDienTextBox.Text.Trim();
            string maHopDong = maHopDongTextBox.Text.Trim();
            string soDienThoai = soDienThoaiTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();

            // Kiểm tra nếu có trường nào để trống và focus vào trường đó
            // Gọi hàm kiểm tra thông tin nhập vào đầy đủ
            if (!kiemTraThongTinNhapDu(maKhachHangTextBox, tenCongTyTextBox, diaChiTextBox,
                                 nguoiDaiDienTextBox, maHopDongTextBox, soDienThoaiTextBox, emailTextBox))
            {
                return; // Dừng lại nếu có lỗi
            }
            // Kiểm tra tính định dạng của dữ liệu và tồn tại
            if (!kiemTraDinhDang(maKhachHang, maHopDong, soDienThoai, email))
                return;
            

            // Tạo đối tượng khách hàng
            var khachHang = new KhachHang
            {
                MaKhachHang = maKhachHang,
                TenCongTy = tenCongTy,
                DiaChi = diaChi,
                NguoiDaiDien = nguoiDaiDien,
                MaHopDong = maHopDong,
                SoDienThoai = soDienThoai,
                Email = email
            };

            // Gọi controller để thêm khách hàng
            bool isSuccess = khachHangController?.ThemKhachHang(khachHang) ?? false;
            if (isSuccess)
            {
                thongBaoLabel.Text = "Thêm khách hàng thành công!";
                thongBaoLabel.ForeColor = System.Drawing.Color.Green;
                clearFormTimer.Start(); // Xóa form sau 2 giây
                OnKhachHangThem(); // Thông báo cho form khác biết đã thêm khách hàng

            }
            else
            {
                thongBaoLabel.Text = "Lỗi khi thêm khách hàng!";
                thongBaoLabel.ForeColor = System.Drawing.Color.Red;
            }

        }
        private bool kiemTraThongTinNhapDu(TextBox maKhachHangTextBox, TextBox tenCongTyTextBox, TextBox diaChiTextBox,
                             TextBox nguoiDaiDienTextBox, TextBox maHopDongTextBox, TextBox soDienThoaiTextBox, TextBox emailTextBox)
        {
            if (string.IsNullOrEmpty(maKhachHangTextBox.Text.Trim()))
            {
                thongBaoLabel.Text = "Vui lòng nhập mã khách hàng.";
                thongBaoLabel.ForeColor = Color.Red;
                thongBaoLabel.Visible = true;
                maKhachHangTextBox.Focus(); 
                return false;
            }

            if (string.IsNullOrEmpty(tenCongTyTextBox.Text.Trim()))
            {
                thongBaoLabel.Text = "Vui lòng nhập tên công ty.";
                thongBaoLabel.ForeColor = Color.Red;
                thongBaoLabel.Visible = true;
                tenCongTyTextBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(diaChiTextBox.Text.Trim()))
            {
                thongBaoLabel.Text = "Vui lòng nhập địa chỉ.";
                thongBaoLabel.ForeColor = Color.Red;
                thongBaoLabel.Visible = true;
                diaChiTextBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(nguoiDaiDienTextBox.Text.Trim()))
            {
                thongBaoLabel.Text = "Vui lòng nhập tên người đại diện.";
                thongBaoLabel.ForeColor = Color.Red;
                thongBaoLabel.Visible = true;
                nguoiDaiDienTextBox.Focus(); 
                return false;
            }

            if (string.IsNullOrEmpty(maHopDongTextBox.Text.Trim()))
            {
                thongBaoLabel.Text = "Vui lòng nhập mã hợp đồng.";
                thongBaoLabel.ForeColor = Color.Red;
                thongBaoLabel.Visible = true;
                maHopDongTextBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(soDienThoaiTextBox.Text.Trim()))
            {
                thongBaoLabel.Text = "Vui lòng nhập số điện thoại.";
                thongBaoLabel.ForeColor = Color.Red;
                thongBaoLabel.Visible = true;
                soDienThoaiTextBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(emailTextBox.Text.Trim()))
            {
                thongBaoLabel.Text = "Vui lòng nhập email.";
                thongBaoLabel.ForeColor = Color.Red;
                thongBaoLabel.Visible = true;
                emailTextBox.Focus();
                return false;
            }

            return true; 
        }


        private bool kiemTraDinhDang(string maKhachHang, string maHopDong, string soDienThoai, string email)
        {
            
            // Kiểm tra mã khách hàng: Tiền tố luôn là KH (in hoa) + số (ít nhất 1 chữ số)
            if (!Regex.IsMatch(maKhachHang, @"^KH\d+$"))
            {
                thongBaoLabel.Text = "Mã khách hàng sai định dạng. Định dạng hợp lệ là KHx với x là số.";
                thongBaoLabel.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //kiểm tra mã hợp đồng phải đúng định dạng
            if (!Regex.IsMatch(maHopDong, @"^\d{2}\.\d{3}$"))
            {
                thongBaoLabel.Text = "Mã hợp đồng sai định dạng. Định dạng hợp lệ xx.y với xx đại diện năm, y là số gồm 3 chữ số";
                thongBaoLabel.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //kiểm tra phần năm trong mã hợp đồng phải lớn hơn hoặc bằng 24
            int xxPart = int.Parse(maHopDong.Split('.')[0]);
            if (xxPart < 24)
            {
                thongBaoLabel.Text = "Phần xx của mã hợp đồng phải lớn hơn hoặc bằng 24.";
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
            //kiểm tra trùng số điện thoại khi thêm khách hàng
            if (khachHangController.KiemTraSoDienThoaiTonTai(soDienThoai))
            {
                thongBaoLabel.Text = "Số điện thoại đã tồn tại. Vui lòng nhập số khác.";
                thongBaoLabel.ForeColor = Color.Red;
                thongBaoLabel.Visible = true;
                return false;
            }
            // Kiểm tra định dạng email
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                thongBaoLabel.Text = "Email không hợp lệ.";
                thongBaoLabel.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //kiểm tra mã khách hàng đã tồn tại trong QLKH , được trùng bên QLHD
            if (khachHangController.KiemTraMaKhachHangTonTai(maKhachHang))
            {
                thongBaoLabel.Text = "Mã khách hàng đã tồn tại. Vui lòng nhập mã khác.";
                thongBaoLabel.ForeColor = Color.Red;
                thongBaoLabel.Visible = true;
                return false;
            }
            //kiểm tra mã hợp đồng đã tồn tại trong QLHD và QLKH khi thêm khách hàng
            if (khachHangController.KiemTraMaHopDongTonTai(maHopDong))
            {
                thongBaoLabel.Text = "Mã hợp đồng đã tồn tại. Vui lòng nhập mã khác.";
                thongBaoLabel.ForeColor = Color.Red;
                thongBaoLabel.Visible = true;
                return false;
            }
            

            return true;
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            ClearForm();
            thongBaoLabel.Text = ""; // Xóa thông báo khi hủy
        }
    }
}
