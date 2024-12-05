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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.Views.quanLyHopDongViews
{
    public partial class quanLyHopDongControl : UserControl
    {
        private hopDongController hopDongController;
        private string? connectionString;
        private readonly string _tenTaiKhoan;
        public quanLyHopDongControl(string tenTaiKhoan, string? connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            hopDongController = new hopDongController(connectionString);
            _tenTaiKhoan = tenTaiKhoan;
            labelUsername.Text = $"{_tenTaiKhoan}";
            LoadContracts();
        }
        private void HienThiThongBao(string? message, bool isError)
        {
            lblThongBao.Visible = true;
            lblThongBao.ForeColor = isError ? Color.Red : Color.Green;
            lblThongBao.Text = message;

        }

        private void LoadContracts()
        {
            dataGridViewHopDong.Rows.Clear(); // Xóa tất cả các hàng hiện có
            var danhSachHopDong = hopDongController.LayDanhSachHopDong();

            foreach (var hd in danhSachHopDong)
            {
                dataGridViewHopDong.Rows.Add(
                    hd.MaHopDong,
                    hd.MaKhachHang,
                    hd.MaNhanVien,
                    hd.Quy.ToString(),
                    hd.NgayLap.ToString("dd/MM/yyyy"),
                    hd.NgayTra.ToString("dd/MM/yyyy"),
                    hd.ViecCanLam,
                    hd.TrangThai
                );
            }
        }


        private void menuItemThem_Click(object sender, EventArgs e)
        {
            if (hopDongController == null)
            {
                return;
            }
            using (var themHopDongForm = new themHopDong(hopDongController))
            {
                themHopDongForm.hopDongThem += (s, args) => LoadContracts();
                if (themHopDongForm.ShowDialog() == DialogResult.OK)
                {
                    LoadContracts();
                }
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView hay không
            if (dataGridViewHopDong.SelectedRows.Count == 0)
            {
                // Hiển thị thông báo lỗi nếu không có hàng nào được chọn
                HienThiThongBao("Vui lòng chọn một hợp đồng để chỉnh sửa.", true);
                return;
            }
            setEdit(true);
        }

        private void setEdit(bool enable)
        {
            maHopDongTextBox.Enabled = false;
            maKhachHangTextBox.Enabled = false;
            maNhanVienTextBox.Enabled = enable;
            quyTextBox.Enabled = enable;
            trangThaiTextBox.Enabled = enable;
            ngayLapDateTimePicker.Enabled = enable;
            ngayTraDateTimePicker.Enabled = enable;
            viecCanLamTextBox.Enabled = enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;

        }

        private void menuItemLoc_Click(object sender, EventArgs e)
        {
            if (hopDongController == null || string.IsNullOrEmpty(connectionString))
            {
                return;
            }

            // Khởi tạo form locThongTinKhachHang và truyền vào connectionString và instance của quanLyKhachHangControl
            using (var locForm = new locHopDong(connectionString, this))
            {
                locForm.ShowDialog();
                //locForm.BringToFront();
            }
        }

        private void danhSachTreHan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                HienThiThongBao("Kết nối cơ sở dữ liệu không khả dụng.", true);
                return;

            }
            var danhSachTreHan = HopDong.LayHopDongTreHan(connectionString);

            // Xóa tất cả các hàng hiện tại trong DataGridView
            dataGridViewHopDong.Rows.Clear();

            // Thêm các hàng mới vào DataGridView
            foreach (var hd in danhSachTreHan)
            {
                dataGridViewHopDong.Rows.Add(
                    hd.MaHopDong,
                    hd.MaKhachHang,
                    hd.MaNhanVien,
                    hd.Quy.ToString(),
                    hd.NgayLap.ToString("dd/MM/yyyy"),
                    hd.NgayTra.ToString("dd/MM/yyyy"),
                    hd.ViecCanLam,
                    hd.TrangThai
                );
            }
            if (danhSachTreHan.Count == 0)
            {
                HienThiThongBao("Không có hợp đồng nào trễ hạn!", false);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                HienThiThongBao("Kết nối cơ sở dữ liệu không khả dụng.", true);
                return;
            }
            // Lấy dữ liệu từ các textbox
            string maHopDong = maHopDongTextBox.Text.Trim();
            string maNhanVien = maNhanVienTextBox.Text.Trim();
            DateTime ngayLap = ngayLapDateTimePicker.Value.Date;
            DateTime ngayTra = ngayTraDateTimePicker.Value.Date;
            string maKhachHang = maKhachHangTextBox.Text.Trim();
            string viecCanLam = viecCanLamTextBox.Text.Trim();
            string trangThai = trangThaiTextBox.Text.Trim();
            int quyNhap = int.Parse(quyTextBox.SelectedItem?.ToString() ?? "0");

            //các hàm kiểm tra dữ liệu
            //kiểm tra phải nhập đầy đủ thông tin
            if (!kiemTraNhapDuLieuDayDu(maHopDongTextBox, maKhachHangTextBox, maNhanVienTextBox, quyTextBox, ngayLapDateTimePicker, ngayTraDateTimePicker, viecCanLamTextBox, trangThaiTextBox))
            {
                return;
            }
            // Kiểm tra tính hợp lệ của dữ liệu đầu vào và kiểm tra tồn tại nếu có
            if (!kiemTraDuLieu(maHopDong, maKhachHang, trangThai, ngayLap, ngayTra, quyNhap))
                return;
            //kiểm tra tự động điều chỉnh trạng thái dựa vào ngày trả khi thực hiện chỉnh sửa thông tin
            if (ngayTra < DateTime.Today && trangThai == "Đang hoạt động")
            {
                trangThai = "Đã trễ hạn"; 
            }
            else if (ngayTra >= DateTime.Today && trangThai == "Đã trễ hạn")
            {
                trangThai = "Đang hoạt động";
            }

            var hd = new HopDong
            {
                MaHopDong = maHopDongTextBox.Text.Trim(),
                MaKhachHang = maKhachHangTextBox.Text.Trim(),
                MaNhanVien = maNhanVienTextBox.Text.Trim(),
                Quy = int.Parse(quyTextBox.Text.Trim()),
                TrangThai = trangThai,
                NgayLap = ngayLapDateTimePicker.Value,
                NgayTra = ngayTraDateTimePicker.Value,
                ViecCanLam = viecCanLamTextBox.Text.Trim()
            };

            if (HopDong.CapNhatHopDong(connectionString, hd))
            {
                HienThiThongBao("Cập nhật thông tin hợp đồng thành công!", false);
                LoadContracts(); // Tải lại danh sách sau khi cập nhật
                setEdit(false);
            }
            else
            {
                HienThiThongBao("Cập nhật thất bại!", true);
            }
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dataGridViewHopDong.SelectedRows.Count > 0)
            {
                // Lấy giá trị của cột "MaHopDong" từ hàng được chọn
                string maHopDong = dataGridViewHopDong.SelectedRows[0].Cells["maHopDong"].Value.ToString();
            }
            setEdit(false);
        }

        private void dataGridViewHopDong_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewHopDong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewHopDong.SelectedRows[0];

                // Kiểm tra nếu ô đầu tiên không có dữ liệu (có thể thay đổi kiểm tra theo cột cụ thể)
                if (selectedRow.Cells["maHopDong"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["maHopDong"].Value.ToString()))
                {
                    troVeBanDau();
                    return;
                }

                // Nếu có dữ liệu, tiếp tục gán giá trị
                maHopDongTextBox.Text = selectedRow.Cells["maHopDong"].Value.ToString();
                maKhachHangTextBox.Text = selectedRow.Cells["maKhachHang"].Value.ToString();
                maNhanVienTextBox.Text = selectedRow.Cells["maNhanVien"].Value.ToString();
                quyTextBox.Text = selectedRow.Cells["quy"].Value.ToString();
                ngayLapDateTimePicker.Value = DateTime.ParseExact(selectedRow.Cells["ngayLap"].Value.ToString(), "dd/MM/yyyy", null);
                ngayTraDateTimePicker.Value = DateTime.ParseExact(selectedRow.Cells["ngayTra"].Value.ToString(), "dd/MM/yyyy", null);
                viecCanLamTextBox.Text = selectedRow.Cells["viecCanLam"].Value.ToString();
                trangThaiTextBox.Text = selectedRow.Cells["trangThai"].Value.ToString();
            }
            else
            {
                // Không có hàng nào được chọn
                troVeBanDau();
            }
            setEdit(false);
        }

        private void troVeBanDau()
        {
            maHopDongTextBox.Text = "";
            maKhachHangTextBox.Text = "";
            maNhanVienTextBox.Text = "";
            quyTextBox.Text = "";
            ngayLapDateTimePicker.Value = DateTime.Now;
            ngayTraDateTimePicker.Value = DateTime.Now;
            viecCanLamTextBox.Text = "";
            trangThaiTextBox.Text = "";

        }

        public void HienThiKetQuaLoc(List<HopDong> ketQuaLoc)
        {
            if(ketQuaLoc.Count > 0)
            {
                dataGridViewHopDong.Rows.Clear();
                foreach (var hd in ketQuaLoc)
                {
                    dataGridViewHopDong.Rows.Add(
                        hd.MaHopDong,
                        hd.MaKhachHang,
                        hd.MaNhanVien,
                        hd.Quy.ToString(),
                        hd.NgayLap.ToString("dd/MM/yyyy"),
                        hd.NgayTra.ToString("dd/MM/yyyy"),
                        hd.ViecCanLam,
                        hd.TrangThai
                    );
                }
            }    
            
        }
        //các hàm xử lí kiểm tra dữ liệu khi sử dụng chức năng sửa
        private bool kiemTraDuLieu(string maHopDong, string maKhachHang, string trangThai, DateTime ngayLapNhap, DateTime ngayTraNhap, int quy)
        {
            //kiểm tra mã hợp đồng phải đúng định dạng
            if (!Regex.IsMatch(maHopDong, @"^\d{2}\.\d{3}$"))
            {
                lblThongBao.Text = "Mã hợp đồng sai định dạng. Định dạng hợp lệ xx.y với xx đại diện năm, y là số gồm 3 chữ số";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //kiểm tra phần năm trong mã hợp đồng phải lớn hơn hoặc bằng 24
            int year = int.Parse(maHopDong.Split('.')[0]);
            if (year < 24)
            {
                lblThongBao.Text = "Phần năm trong mã hợp đồng phải lớn hơn hoặc bằng 24";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }
            // Kiểm tra mã khách hàng: Tiền tố luôn là KH (in hoa) + số (ít nhất 1 chữ số)
            if (!Regex.IsMatch(maKhachHang, @"^KH\d+$"))
            {
                lblThongBao.Text = "Mã khách hàng sai định dạng. Định dạng hợp lệ là KHx với x là số.";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            //kiểm tra mã nhân viên phải tồn tại trong cơ sở dữ liệu
            if (!hopDongController.KiemTraMaNhanVienTonTai(maNhanVienTextBox.Text))
            {
                lblThongBao.Text = "Mã nhân viên không tồn tại. Vui lòng kiểm tra lại.";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }
            //kiểm tra mã khách hàng phải tồn tại trong cơ sở dữ liệu
            if (!hopDongController.KiemTraMaKhachHangTonTai(maKhachHang))
            {
                lblThongBao.Text = "Mã khách hàng không tồn tại. Vui lòng kiểm tra lại.";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }
            // Kiểm tra mã hợp đồng có phù hợp với mã khách hàng không (trường hợp có khách hàng A với hd A1 nhưng khi thêm hd lại chọn mã hd A1 nhưng chọn khách hàng B)
            if (hopDongController.KiemTraHopDongKhongPhuHop(maHopDong, maKhachHang))
            {
                lblThongBao.Text = "Mã hợp đồng đã tồn tại nhưng không thuộc mã khách hàng này. Vui lòng kiểm tra thông tin khách hàng.";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }
            //ver2 kiểm tra mã hợp đồng và mã khách hàng phải trùng nhau khi đã có khách hàng này cùng với mã này trước đó
            if (!hopDongController.KiemTraMaHopDongVaMaKhachHangTonTai(maHopDong, maKhachHang))
            {
                lblThongBao.Text = "Mã khách hàng không phù hợp với mã hợp đồng, vui lòng kiểm tra thông tin.";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }
            
            //kiểm tra ngày lập phải nhỏ hơn ngày trả
            if (ngayTraNhap <= ngayLapNhap)
            {
                lblThongBao.Text = "Ngày trả phải sau ngày lập. Vui lòng kiểm tra lại.";
                lblThongBao.ForeColor = Color.Red;
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
                    lblThongBao.Text = "Quý không hợp lệ.";
                    lblThongBao.ForeColor = Color.Red;
                    return false;
            }

            // Kiểm tra ngày lập và ngày trả nằm trong khoảng tháng của quý
            if (thangLap < thangBatDau || thangLap > thangKetThuc)
            {
                lblThongBao.Text = $"Ngày lập phải nằm trong khoảng từ tháng {thangBatDau} đến tháng {thangKetThuc}.";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }

            if (thangTra < thangBatDau || thangTra > thangKetThuc)
            {
                lblThongBao.Text = $"Ngày trả phải nằm trong khoảng từ tháng {thangBatDau} đến tháng {thangKetThuc}.";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }

            return true; // Nếu cả hai ngày đều nằm trong khoảng của quý
        }


        private bool kiemTraNhapDuLieuDayDu(System.Windows.Forms.TextBox maHopDong, System.Windows.Forms.TextBox maKhachHang, System.Windows.Forms.TextBox maNhanVien, System.Windows.Forms.ComboBox quy, DateTimePicker ngayLap, DateTimePicker ngayTra, System.Windows.Forms.TextBox viecCanLam, System.Windows.Forms.TextBox trangThai)
        {
            // Kiểm tra từng trường thông tin và hiển thị thông báo cụ thể
            if (string.IsNullOrEmpty(maHopDong.Text))
            {
                lblThongBao.Text = "Vui lòng nhập mã hợp đồng.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                maHopDong.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(maKhachHang.Text))
            {
                lblThongBao.Text = "Vui lòng nhập mã khách hàng.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                maKhachHang.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(maNhanVien.Text))
            {
                lblThongBao.Text = "Vui lòng nhập mã nhân viên.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                maNhanVien.Focus();
                return false;
            }
            // Kiểm tra mã nhân viên: phải viết hoa có thể có số nếu mã nhân viên trùng và không có khoảng cách
            if (!System.Text.RegularExpressions.Regex.IsMatch(maNhanVien.Text, @"^[A-Z]+[0-9]*$") || maNhanVien.Text.Contains(' '))
            {
                lblThongBao.Text = "Mã nhân viên phải viết hoa và có thể chứa số phía sau khi trùng tên, nhưng không có khoảng cách.";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                lblThongBao.Visible = true;
                maNhanVien.Focus();
                return false;
            }

            if (quy.SelectedItem == null)
            {
                lblThongBao.Text = "Vui lòng chọn quý.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                quy.Focus();
                return false;
            }

            // Kiểm tra giá trị nhập vào ComboBox quý khi dùng chức năng sửa
            if (!int.TryParse(quy.Text, out int quyValue) || quyValue < 1 || quyValue > 4)
            {
                lblThongBao.Text = "Quý phải là số từ 1 đến 4.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                quy.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(viecCanLam.Text))
            {
                lblThongBao.Text = "Vui lòng nhập công việc cần làm.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                viecCanLam.Focus();
                return false;
            }
            //vì giao diện sửa trạng thái là textbox
            if (string.IsNullOrWhiteSpace(trangThai.Text))
            {
                lblThongBao.Text = "Vui lòng nhập trạng thái.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                trangThai.Focus();
                return false;
            }
            // Kiểm tra giá trị hợp lệ của trạng thái
            string trangThaiValue = trangThai.Text.Trim();
            if (trangThaiValue != "Đã hoàn thành" && trangThaiValue != "Đang hoạt động" && trangThaiValue != "Đã trễ hạn")
            {
                lblThongBao.Text = "Trạng thái không hợp lệ. Vui lòng nhập 'Đã hoàn thành' hoặc 'Đang hoạt động' hoặc 'Đã trễ hạn'.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
                trangThai.Focus();
                return false;
            }

            return true;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form lienHeTroGiup = new lienHeTroGiup();
            lienHeTroGiup.ShowDialog();
        }

        
    }
}
