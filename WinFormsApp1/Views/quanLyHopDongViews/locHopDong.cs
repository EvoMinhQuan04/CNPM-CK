using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Views.quanLyHopDongViews;

namespace WinFormsApp1
{
    public partial class locHopDong : Form
    {
        private readonly hopDongController hdController;
        private readonly quanLyHopDongControl hopDongControl;

        public locHopDong(string connectionString, quanLyHopDongControl hopDongControl)
        {
            InitializeComponent();
            hdController = new hopDongController(connectionString);
            this.hopDongControl = hopDongControl;
            noiDungComboBox();

            LoadNgayLapKetThucComboBox(connectionString);


        }

        private void noiDungComboBox()
        {
            comboBoxLoaiLoc.Items.Clear();
            comboBoxLoaiLoc.Items.Add("Mã khách hàng");
            comboBoxLoaiLoc.Items.Add("Mã nhân viên");
            comboBoxLoaiLoc.Items.Add("Mã hợp đồng");
            comboBoxLoaiLoc.Items.Add("Trạng thái hợp đồng");
            comboBoxLoaiLoc.SelectedIndex = 0;
        }

        private void LoadNgayLapKetThucComboBox(string connectionString)
        {
            // Lấy danh sách ngày lập và thêm vào comboBoxNgayLap
            var danhSachNgayLap = hdController.LayDanhSachNgay("Ngaylap");
            foreach (var ngay in danhSachNgayLap)
            {
                comboBoxNgayLap.Items.Add(ngay.ToString("dd/MM/yyyy"));
            }

            // Lấy danh sách ngày trả và thêm vào comboBoxNgayKetThuc
            var danhSachNgayKetThuc = hdController.LayDanhSachNgay("Ngaytra");
            foreach (var ngay in danhSachNgayKetThuc)
            {
                comboBoxNgayKetThuc.Items.Add(ngay.ToString("dd/MM/yyyy"));
            }
        }
        //hàm xử lí thông báo
        private void HienThiThongBao(string message, bool isError)
        {
            labelThongBao.Visible = true;
            labelThongBao.ForeColor = isError ? System.Drawing.Color.Red : System.Drawing.Color.Green;
            labelThongBao.Text = message;
        }


        private void btnLoc_Click(object sender, EventArgs e)
        {
            // Get values from controls
            string loaiLoc = comboBoxLoaiLoc.Text;
            string thongTin = textBoxThongTin.Text.Trim();
            DateTime? ngayLap = null;
            DateTime? ngayKetThuc = null;

            // Kiểm tra nếu TextBox thông tin rỗng
            if (string.IsNullOrEmpty(thongTin))
            {
                HienThiThongBao("Vui lòng nhập thông tin cần tìm.", true);
                return;
            }
            // Kiểm tra định dạng thông tin theo loại lọc
            if (loaiLoc == "Mã nhân viên")
            {
                // Kiểm tra mã nhân viên: phải viết hoa, có thể chứa số nếu trùng tên, và không có khoảng cách
                if (!Regex.IsMatch(thongTin, @"^[A-Z]+[0-9]*$") || thongTin.Contains(' '))
                {
                    HienThiThongBao("Mã nhân viên phải viết hoa và có thể chứa số phía sau nếu trùng tên, nhưng không có khoảng cách.", true);
                    return;
                }
            }
            // Kiểm tra định dạng thông tin theo loại lọc
            if (loaiLoc == "Mã hợp đồng" && !Regex.IsMatch(thongTin, @"^\d{2}\.\d{3}$"))
            {
                HienThiThongBao("Mã hợp đồng không đúng định dạng.", true);
                return;
            }

            if (loaiLoc == "Mã khách hàng" && !Regex.IsMatch(thongTin, @"^KH\d+$"))
            {
                HienThiThongBao("Mã khách hàng không đúng định dạng.", true);
                return;
            }
            //kiểm tra mã khách hàng có tồn tại hay không
            if (loaiLoc == "Mã khách hàng" && !hdController.KiemTraMaKhachHangTonTai(thongTin))
            {
                HienThiThongBao("Mã khách hàng không tồn tại.", true);
                return;
            }
            //kiểm tra mã nhân viên có tồn tại hay không
            if (loaiLoc == "Mã nhân viên" && !hdController.KiemTraMaNhanVienTonTai(thongTin))
            {
                HienThiThongBao("Mã nhân viên không tồn tại.", true);
                return;
            }
            //kiểm tra mã hợp đồng có tồn tại trong QLHD hay không
            if (loaiLoc == "Mã hợp đồng" && !hdController.KiemTraMaHopDongTonTaiTrongQLHD(thongTin))
            {
                HienThiThongBao("Mã hợp đồng không tồn tại.", true);
                return;
            }

            // Nếu có giá trị trong ComboBox Ngày Lập
            if (DateTime.TryParseExact(comboBoxNgayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedNgayLap))
            {
                ngayLap = parsedNgayLap;
            }
            if (DateTime.TryParseExact(comboBoxNgayKetThuc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedNgayKetThuc))
            {
                ngayKetThuc = parsedNgayKetThuc;
            }


            // Kiểm tra nếu ngày lập lớn hơn ngày kết thúc (nếu cả hai có giá trị)
            if (ngayLap.HasValue && ngayKetThuc.HasValue && ngayLap > ngayKetThuc)
            {
                HienThiThongBao("Ngày lập phải nhỏ hơn hoặc bằng ngày trả.", true);
                return;
            }

            try
            {
                // Call LocHopDong with all three filters
                var ketQuaLoc = hdController.LocHopDong(loaiLoc, thongTin, ngayLap, ngayKetThuc);

                // Display the filtered results in the parent form's ListView
                hopDongControl.HienThiKetQuaLoc(ketQuaLoc);

                // Display feedback based on results
                if (ketQuaLoc.Count > 0)
                {
                    HienThiThongBao("Lọc thành công!", false);
                }
                else
                {
                    HienThiThongBao("Không tìm thấy kết quả phù hợp.", true);
                }
            }
            catch (Exception ex)
            {
                HienThiThongBao("Đã xảy ra lỗi khi lọc hợp đồng: " + ex.Message, true);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            comboBoxLoaiLoc.SelectedIndex = 0;
            textBoxThongTin.Clear();
            labelThongBao.Text = "";
            comboBoxNgayLap.SelectedIndex = 0;
            comboBoxNgayKetThuc.SelectedIndex = 0;

        }
    }
}
