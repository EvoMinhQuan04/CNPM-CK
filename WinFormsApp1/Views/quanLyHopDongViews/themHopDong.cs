using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class themHopDong : Form
    {
        private hopDongController hopDongController;
        private nhanVienController nhanVienController;
        private System.Windows.Forms.Timer? clearFormTimer;
        public themHopDong(hopDongController controller)
        {
            InitializeComponent();
            hopDongController = controller ?? throw new ArgumentNullException(nameof(controller));
            InitializeClearFormTimer();
            hopDongThem = delegate { };
            loadQuyCombobox();
        }

        private void InitializeClearFormTimer()
        {
            clearFormTimer = new System.Windows.Forms.Timer();
            clearFormTimer.Interval = 2000; // 2 giây
            clearFormTimer.Tick += ClearFormTimer_Tick;
        }

        private void ClearFormTimer_Tick(object? sender, EventArgs e)
        {
            clearFormTimer?.Stop(); // Dừng timer sau khi chạy
            ClearForm(); // Xóa dữ liệu trên form
            thongBaoLoi.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearForm(); // Xóa dữ liệu trên form ngay lập tức
        }

        private void ClearForm()
        {
            maHopDong.Clear();
            maKhachHang.Clear();
            maNhanVien.Clear();
            quy.SelectedIndex = -1;
            trangThai.SelectedIndex = -1;
            viecCanLam.Clear();
            ngayLap.Value = DateTime.Now;
            ngayTra.Value = DateTime.Now;
            thongBaoLoi.Text = ""; // Xóa thông báo lỗi
            thongBaoLoi.ForeColor = Color.Black; // Đặt màu mặc định lại (nếu cần)
        }
        public EventHandler hopDongThem;

        private void OnHopDongThem()
        {
            hopDongThem?.Invoke(this, EventArgs.Empty);
        }

        private void loadQuyCombobox()
        {
            quy.Items.Clear();
            quy.Items.Add("1");
            quy.Items.Add("2");
            quy.Items.Add("3");
            quy.Items.Add("4");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            thongBaoLoi.Text = ""; // Xóa thông báo lỗi trước khi kiểm tra
            thongBaoLoi.ForeColor = Color.Black; // Đặt lại màu về mặc định

            // Lấy dữ liệu từ các textbox
            string maHopDongNhap = maHopDong.Text.Trim();
            string maKhachHangNhap = maKhachHang.Text.Trim();
            string maNhanVienNhap = maNhanVien.Text.Trim();
            int quyNhap = int.Parse(quy.SelectedItem?.ToString() ?? "0");
            DateTime ngayLapNhap = ngayLap.Value;
            DateTime ngayTraNhap = ngayTra.Value;
            string viecCanLamNhap = viecCanLam.Text.Trim();
            string trangThaiNhap = trangThai.Text.Trim();

            //kiểm tra phải nhập đầy đủ thông tin
            if(!kiemTraNhapDuLieuDayDu(maHopDong, maKhachHang, maNhanVien, quy, ngayLap, ngayTra, viecCanLam, trangThai))
            {
                return;
            }
            // Kiểm tra tính hợp lệ của dữ liệu đầu vào và kiểm tra tồn tại nếu có
            if (!kiemTraDuLieu(maHopDongNhap, maKhachHangNhap, trangThaiNhap, ngayLapNhap, ngayTraNhap, quyNhap))
                return;

            // Tạo đối tượng hợp đồng
            var hopDong = new HopDong
            {
                MaHopDong = maHopDongNhap,
                MaKhachHang = maKhachHangNhap,
                MaNhanVien = maNhanVienNhap,
                Quy = quyNhap,
                TrangThai = trangThaiNhap,
                NgayLap = ngayLapNhap,
                NgayTra = ngayTraNhap,
                ViecCanLam = viecCanLamNhap
            };

            // Gọi controller để thêm hợp đồng
            bool isSuccess = hopDongController?.ThemHopDong(hopDong) ?? false;
            if (isSuccess)
            {
                thongBaoLoi.Text = "Thêm hợp đồng thành công!";
                thongBaoLoi.ForeColor = Color.Green;
                if (clearFormTimer != null)
                {
                    clearFormTimer.Start(); // Xóa form sau 2 giây
                }
                OnHopDongThem(); // Thông báo cho form khác biết đã thêm hợp đồng

                // Kiểm tra nếu hợp đồng vừa thêm có ngày trả đã quá hạn và trạng thái là "Đang hoạt động"
                if (ngayTraNhap < DateTime.Now && trangThaiNhap == "Đang hoạt động")
                {
                    thongBaoLoi.Text += "\nTrạng thái hợp đồng đã được cập nhật thành 'Đã trễ hạn'.";
                    hopDong.TrangThai = "Đã trễ hạn";
                    hopDongController?.CapNhatHopDong(hopDong); // Cập nhật trạng thái hợp đồng
                }
            }
            else
            {
                thongBaoLoi.Text = "Lỗi khi thêm hợp đồng!";
                thongBaoLoi.ForeColor = Color.Red;
            }
        }

        private bool kiemTraDuLieu(string maHopDong, string maKhachHang, string trangThai, DateTime ngayLapNhap, DateTime ngayTraNhap, int quy)
        {
            //kiểm tra mã hợp đồng phải đúng định dạng
            if (!Regex.IsMatch(maHopDong, @"^\d{2}\.\d{3}$"))
            {
                thongBaoLoi.Text = "Mã hợp đồng sai định dạng. Định dạng hợp lệ xx.y với xx đại diện năm, y là số gồm 3 chữ số";
                thongBaoLoi.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //kiểm tra phần năm trong mã hợp đồng phải lớn hơn hoặc bằng 24
            int year = int.Parse(maHopDong.Split('.')[0]);
            if (year < 24)
            {
                thongBaoLoi.Text = "Phần năm trong mã hợp đồng phải lớn hơn hoặc bằng 24";
                thongBaoLoi.ForeColor = Color.Red;
                return false;
            }
            // Kiểm tra mã khách hàng: Tiền tố luôn là KH (in hoa) + số (ít nhất 1 chữ số)
            if (!Regex.IsMatch(maKhachHang, @"^KH\d+$"))
            {
                thongBaoLoi.Text = "Mã khách hàng sai định dạng. Định dạng hợp lệ là KHx với x là số.";
                thongBaoLoi.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //kiểm tra mã nhân viên phải tồn tại trong cơ sở dữ liệu
            if (!hopDongController.KiemTraMaNhanVienTonTai(maNhanVien.Text))
            {
                thongBaoLoi.Text = "Mã nhân viên không tồn tại. Vui lòng kiểm tra lại.";
                thongBaoLoi.ForeColor = Color.Red;
                return false;
            }
            //kiểm tra mã khách hàng phải tồn tại trong cơ sở dữ liệu
            if (!hopDongController.KiemTraMaKhachHangTonTai(maKhachHang))
            {
                thongBaoLoi.Text = "Mã khách hàng không tồn tại. Vui lòng kiểm tra lại.";
                thongBaoLoi.ForeColor = Color.Red;
                return false;
            }
            // Kiểm tra mã hợp đồng có phù hợp với mã khách hàng không (trường hợp có khách hàng A với hd A1 nhưng khi thêm hd lại chọn mã hd A1 nhưng chọn khách hàng B)
            if (hopDongController.KiemTraHopDongKhongPhuHop(maHopDong, maKhachHang))
            {
                thongBaoLoi.Text = "Mã hợp đồng đã tồn tại nhưng không thuộc mã khách hàng này. Vui lòng kiểm tra thông tin khách hàng.";
                thongBaoLoi.ForeColor = Color.Red;
                return false;
            }
            //ver2 kiểm tra mã hợp đồng và mã khách hàng phải trùng nhau khi đã có khách hàng này cùng với mã này trước đó
            if (!hopDongController.KiemTraMaHopDongVaMaKhachHangTonTai(maHopDong, maKhachHang))
            {
                thongBaoLoi.Text = "Mã khách hàng không phù hợp với mã hợp đồng, vui lòng kiểm tra thông tin.";
                thongBaoLoi.ForeColor = Color.Red;
                return false;
            }
            //kiểm tra mã hợp đồng phải khác trong QLHD
            if (hopDongController.KiemTraMaHopDongTonTaiTrongQLHD(maHopDong))
            {
                thongBaoLoi.Text = "Mã hợp đồng đã tồn tại trong Quản lý hợp đồng. Vui lòng nhập mã khác.";
                thongBaoLoi.ForeColor = Color.Red;
                return false;
            }
            //kiểm tra ngày lập phải nhỏ hơn ngày trả
            if (ngayTraNhap <= ngayLapNhap)
            {
                thongBaoLoi.Text = "Ngày trả phải sau ngày lập. Vui lòng kiểm tra lại.";
                thongBaoLoi.ForeColor = Color.Red;
                return false;
            }
            // Kiểm tra ngày lập và ngày trả phải nằm trong khoảng của quý
            if (!kiemTraNgayTrongQuy(ngayLapNhap, ngayTraNhap, quy))
            {
                return false;
            }

            return true;
        }
        //kiểm tra ngày lập và ngày trả phải nằm trong khoảng của quý
        private bool kiemTraNgayTrongQuy(DateTime ngayLap, DateTime ngayTra, int quy)
        {
            // Lấy tháng và năm của ngày lập và ngày trả
            int thangLap = ngayLap.Month;
            int thangTra = ngayTra.Month;

            // Xác định khoảng tháng hợp lệ cho từng quý
            int thangBatDau, thangKetThuc;
            switch (quy)
            {
                case 1: // Quý 1: Tháng 1 - 3
                    thangBatDau = 1;
                    thangKetThuc = 3;
                    break;
                case 2: // Quý 2: Tháng 4 - 6
                    thangBatDau = 4;
                    thangKetThuc = 6;
                    break;
                case 3: // Quý 3: Tháng 7 - 9
                    thangBatDau = 7;
                    thangKetThuc = 9;
                    break;
                case 4: // Quý 4: Tháng 10 - 12
                    thangBatDau = 10;
                    thangKetThuc = 12;
                    break;
                default:
                    thongBaoLoi.Text = "Quý không hợp lệ.";
                    thongBaoLoi.ForeColor = Color.Red;
                    return false;
            }

            // Kiểm tra ngày lập và ngày trả nằm trong khoảng tháng của quý
            if (thangLap < thangBatDau || thangLap > thangKetThuc)
            {
                thongBaoLoi.Text = $"Ngày lập phải nằm trong khoảng từ tháng {thangBatDau} đến tháng {thangKetThuc}.";
                thongBaoLoi.ForeColor = Color.Red;
                return false;
            }

            if (thangTra < thangBatDau || thangTra > thangKetThuc)
            {
                thongBaoLoi.Text = $"Ngày trả phải nằm trong khoảng từ tháng {thangBatDau} đến tháng {thangKetThuc}.";
                thongBaoLoi.ForeColor = Color.Red;
                return false;
            }

            return true; // Nếu cả hai ngày đều nằm trong khoảng của quý
        }

        private bool kiemTraNhapDuLieuDayDu(TextBox maHopDong, TextBox maKhachHang, TextBox maNhanVien, ComboBox quy, DateTimePicker ngayLap, DateTimePicker ngayTra, TextBox viecCanLam, ComboBox trangThai)
        {
            // Kiểm tra từng trường thông tin và hiển thị thông báo cụ thể
            if (string.IsNullOrEmpty(maHopDong.Text))
            {
                thongBaoLoi.Text = "Vui lòng nhập mã hợp đồng.";
                thongBaoLoi.ForeColor = Color.Red;
                thongBaoLoi.Visible = true;
                maHopDong.Focus(); 
                return false;
            }

            if (string.IsNullOrEmpty(maKhachHang.Text))
            {
                thongBaoLoi.Text = "Vui lòng nhập mã khách hàng.";
                thongBaoLoi.ForeColor = Color.Red;
                thongBaoLoi.Visible = true;
                maKhachHang.Focus(); 
                return false;
            }

            if (string.IsNullOrEmpty(maNhanVien.Text))
            {
                thongBaoLoi.Text = "Vui lòng nhập mã nhân viên.";
                thongBaoLoi.ForeColor = Color.Red;
                thongBaoLoi.Visible = true;
                maNhanVien.Focus();
                return false;
            }
            // Kiểm tra mã nhân viên: phải viết hoa có thể có số nếu mã nhân viên trùng và không có khoảng cách
            if (!System.Text.RegularExpressions.Regex.IsMatch(maNhanVien.Text, @"^[A-Z]+[0-9]*$") || maNhanVien.Text.Contains(' '))
            {
                thongBaoLoi.Text = "Mã nhân viên phải viết hoa và có thể chứa số phía sau khi trùng tên, nhưng không có khoảng cách.";
                thongBaoLoi.ForeColor = System.Drawing.Color.Red;
                thongBaoLoi.Visible = true;
                maNhanVien.Focus();
                return false;
            }

            if (quy.SelectedItem == null)
            {
                thongBaoLoi.Text = "Vui lòng chọn quý.";
                thongBaoLoi.ForeColor = Color.Red;
                thongBaoLoi.Visible = true;
                quy.Focus(); 
                return false;
            }

            // Kiểm tra giá trị nhập vào ComboBox quý khi dùng chức năng sửa
            if (!int.TryParse(quy.Text, out int quyValue) || quyValue < 1 || quyValue > 4)
            {
                thongBaoLoi.Text = "Quý phải là số từ 1 đến 4.";
                thongBaoLoi.ForeColor = Color.Red;
                thongBaoLoi.Visible = true;
                quy.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(viecCanLam.Text))
            {
                thongBaoLoi.Text = "Vui lòng nhập công việc cần làm.";
                thongBaoLoi.ForeColor = Color.Red;
                thongBaoLoi.Visible = true;
                viecCanLam.Focus(); 
                return false;
            }

            if (trangThai.SelectedItem == null)
            {
                thongBaoLoi.Text = "Vui lòng chọn trạng thái.";
                thongBaoLoi.ForeColor = Color.Red;
                thongBaoLoi.Visible = true;
                trangThai.Focus(); 
                return false;
            }
            return true;

        }
        

        private void huy_Click(object sender, EventArgs e)
        {
            ClearForm();
            thongBaoLoi.Text = ""; // Xóa thông báo lỗi khi hủy
        }
    }
}
