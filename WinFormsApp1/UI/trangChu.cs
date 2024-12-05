// UI/trangChu.cs
using System;
using System.Windows.Forms;
using WinFormsApp1.Views;
using WinFormsApp1.Controllers;
using WinFormsApp1.Views.quanLyHopDongViews;
using WinFormsApp1.Views.quanLyNhanVienViews;
using WinFormsApp1.Views.saoLuuPhucHoiViews;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApp1.Views.quanLyMauQuanTracViews;
using WinFormsApp1.Views.quanLyPhieuTraHangViews;
namespace WinFormsApp1.UI
{
    public partial class trangChu : Form
    {

        private List<Control> macDinhContentControls;
        private readonly string _tenTaiKhoan;
        private readonly string _connectionString;
        private readonly string _vaitro;
        private System.Windows.Forms.ToolTip _toolTip;
        private System.Windows.Forms.Button _activeButton; // Nút đang được kích hoạt
        private Padding _pressedMargin = new Padding(5, 5, 5, 5); // Margin khi nút chìm
        private Padding _normalMargin = new Padding(3, 2, 3, 2); // Margin thông thường


        // Constructor của trangChu nhận thêm tham số
        public trangChu(string tenTaiKhoan, string connectionString, string vaitro)
        {
            InitializeComponent();
            _tenTaiKhoan = tenTaiKhoan;
            _connectionString = connectionString;
            _vaitro = vaitro;
            _toolTip = new System.Windows.Forms.ToolTip();
            macDinhContentControls = new List<Control>(panelMain.Controls.OfType<Control>());
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is System.Windows.Forms.Button button)
                {
                    button.Click += (s, e) => SetActiveButton(button);
                }
            }

            if (_vaitro == "Nhanvien")
            {

                // Vô hiệu hóa sự kiện Click mà không thay đổi màu sắc
                btn_quan_ly_nhan_vien.Enabled = true; // Giữ Enabled để có thể hiển thị hover, nhưng xử lý thủ công
                btn_quan_ly_nhan_vien.Click -= btn_quan_ly_nhan_vien_Click; // Xóa sự kiện Click để không thực hiện chức năng
                btn_quan_ly_nhan_vien.Cursor = Cursors.Hand; // Giữ kiểu con trỏ tay
                btn_quan_ly_nhan_vien.BackColor = Color.FromArgb(89, 142, 108); // Mã màu ban đầu

                // Hiển thị thông báo khi di chuột vào
                _toolTip.SetToolTip(btn_quan_ly_nhan_vien, "Bạn không có quyền truy cập chức năng này.");

                // Thêm sự kiện MouseHover để hiển thị thông báo bằng ToolTip
                btn_quan_ly_nhan_vien.MouseHover += (sender, e) =>
                {
                    _toolTip.Show("Bạn không có quyền truy cập chức năng này.", btn_quan_ly_nhan_vien, 2000); // Thông báo hiển thị trong 2 giây
                };
                

            }
            noiDungMacDinh();
            hienThiTrangChu();


        }

        private void hienThiTrangChu()
        {
            UserControl trangChuConTrol = new ucTrangChu(_tenTaiKhoan, _connectionString, _vaitro);
            panelMain.Controls.Clear();
            trangChuConTrol.Dock = DockStyle.Fill;
            panelMain.Controls.Add(trangChuConTrol);
        }

        private void trangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void hienThiControl(UserControl control)
        {
            foreach (Control c in panelMain.Controls)
            {
                if (c is UserControl)
                {
                    panelMain.Controls.Remove(c);
                }
            }
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void btn_quan_ly_hop_dong_Click(object sender, EventArgs e)
        {
            UserControl hopDongControl = new quanLyHopDongControl(_tenTaiKhoan, _connectionString);
            hopDongControl.Dock = DockStyle.Fill;
            hienThiControl(hopDongControl);
        }

        private void btn_quan_ly_khach_hang_Click(object sender, EventArgs e)
        {
            var khachHangControl = new quanLyKhachHangControl(_tenTaiKhoan, _connectionString);
            hienThiControl(khachHangControl);
        }

        private void btn_quan_ly_nhan_vien_Click(object? sender, EventArgs e)
        {
            if (_vaitro == "Nhanvien")
            {
                return; // Nếu là nhân viên, không làm gì
            }
            var nhanVienControl = new quanLyNhanVienControl(_tenTaiKhoan, _connectionString);
            hienThiControl(nhanVienControl);
        }

        private void btn_trang_chu_Click(object sender, EventArgs e)
        {
            hienThiMacDinh();
        }

        private void hienThiMacDinh()
        {
            foreach (Control c in panelMain.Controls)
            {
                if (c is UserControl)
                {
                    panelMain.Controls.Remove(c);
                }
            }
            noiDungMacDinh();
        }

        private void noiDungMacDinh()
        {
            panelMain.Controls.Clear();
            // Thêm lại giao diện mặc định của trang chủ
            UserControl trangChuControl = new ucTrangChu(_tenTaiKhoan, _connectionString, _vaitro);
            trangChuControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(trangChuControl);
        }

        private void btn_sao_luu_phuc_hoi_Click(object sender, EventArgs e)
        {
            var saoLuuPhucHoi = new saoLuuPhucHoiControl(_tenTaiKhoan, _connectionString);
            hienThiControl(saoLuuPhucHoi);
        }

        private void btn_quan_ly_mau_kiem_dinh_Click(object sender, EventArgs e)
        {
            var quanTraclControl = new quanLyMauQuanTracControl(_tenTaiKhoan, _connectionString);
            hienThiControl(quanTraclControl);
        }

        private void btn_quan_ly_phieu_tra_hang_Click(object sender, EventArgs e)
        {
            var phieuTraHangControl = new quanLyPhieuTraHangControl(_tenTaiKhoan, _connectionString);
            hienThiControl(phieuTraHangControl);
        }
        //hiệu ứng nút
        private void SetActiveButton(System.Windows.Forms.Button newButton)
        {
            // Nếu đã có nút kích hoạt, khôi phục trạng thái cho nút đó
            if (_activeButton != null)
            {
                _activeButton.Margin = _normalMargin; // Trả về margin thông thường
                _activeButton.BackColor = Color.FromArgb(89, 142, 108);
                _activeButton.FlatStyle = FlatStyle.Flat;
                _activeButton.TextAlign = ContentAlignment.MiddleCenter;
                _activeButton.Size = new Size(219, 53);
                _activeButton.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold, GraphicsUnit.Point);
                _activeButton.FlatAppearance.BorderColor = Color.White;
                if (_activeButton == btn_dang_xuat)
                {
                    btn_dang_xuat.Text = "      Đăng xuất";
                    btn_dang_xuat.Size = new Size(219, 51);
                    btn_dang_xuat.Padding = new Padding(0, 0, 0, 0);
                    btn_dang_xuat.BackColor = Color.FromArgb(197, 219, 204);


                }

            }

            // Áp dụng trạng thái mới cho nút được kích hoạt

            _activeButton = newButton;
            if (_activeButton != null)
            {
                _activeButton.Margin = _pressedMargin; // Áp dụng margin "chìm"
                _activeButton.FlatStyle = FlatStyle.Popup;
                _activeButton.TextAlign = ContentAlignment.MiddleCenter;
                _activeButton.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold, GraphicsUnit.Point);
                _activeButton.BackColor = Color.FromArgb(50, 102, 67);

                if (_activeButton == btn_dang_xuat)
                {
                    btn_dang_xuat.FlatStyle = FlatStyle.Flat;
                    btn_dang_xuat.Text = "        Đăng xuất";
                    btn_dang_xuat.BackColor = Color.FromArgb(197, 219, 204);

                }
            }
        }

        private void btn_dang_xuat_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Close the main form and show the login form
                Form mainForm = this.FindForm();
                mainForm?.Hide();

                var loginController = new dangNhapController(_connectionString);
                var loginForm = new dangNhap(loginController);
                loginForm.Show(); // Show the login form as a dialog
            }

        }
    }
}
