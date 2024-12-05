using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views.saoLuuPhucHoiViews
{
    public partial class saoLuuPhucHoiControl : UserControl
    {
        private readonly saoLuuPhucHoiController _controller;
        private readonly string _tenTaiKhoan;

        public saoLuuPhucHoiControl(string tenTaiKhoan, string connectionString)
        {
            InitializeComponent();
            _tenTaiKhoan = tenTaiKhoan;
            labelUserName.Text = $"{_tenTaiKhoan}";

            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _controller = new saoLuuPhucHoiController(connectionString);
            InitializeControls();
        }

        // Cấu hình các thành phần trên giao diện
        private void InitializeControls()
        {
            // ComboBox cho khoảng thời gian
            comboBoxTimeRange.Items.AddRange(new object[]
            {
                "1 giờ trước",
                "1 ngày trước",
                "1 tuần trước",
                "4 tuần trước"
            });
            comboBoxTimeRange.SelectedIndex = 0; // Mặc định chọn "1 giờ trước"

            // Sự kiện thay đổi khoảng thời gian
            comboBoxTimeRange.SelectedIndexChanged += (s, e) => UpdateDataGridView();

            // Sự kiện thay đổi trạng thái của CheckBox
            rabHopDong.CheckedChanged += (s, e) => UpdateDataGridView();
            rabKhachHang.CheckedChanged += (s, e) => UpdateDataGridView();
            rabMauQuanTrac.CheckedChanged += (s, e) => UpdateDataGridView();
            //rabPhieuTraHang.CheckedChanged += (s, e) => UpdateDataGridView();

            // Cấu hình DataGridView
            dataSaoLuu.AutoGenerateColumns = true;
            dataSaoLuu.ReadOnly = true;
            dataSaoLuu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Ẩn thông báo ban đầu
            lblThongBao.Visible = false;
        }

        // Hiển thị thông báo bằng Label
        private void HienThiThongBao(string message, bool isError = true)
        {
            lblThongBao.Visible = true;
            lblThongBao.ForeColor = isError ? Color.Red : Color.Green;
            lblThongBao.Text = message;

        }

        // Cập nhật dữ liệu hiển thị trong DataGridView
        private void UpdateDataGridView()
        {
            try
            {
                // Lấy khoảng thời gian từ ComboBox
                var selectedTimeRange = comboBoxTimeRange.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedTimeRange))
                {
                    return;
                }
                var (startTime, endTime) = _controller.LayKhoangThoiGian(selectedTimeRange);

                // Kiểm tra trạng thái CheckBox
                bool includeHopDong = rabHopDong.Checked;
                bool includeKhachHang = rabKhachHang.Checked;
                bool includeMauQuanTrac = rabMauQuanTrac.Checked;
                //bool includePhieuKetQua = rabPhieuTraHang.Checked;

                // Lấy dữ liệu từ Controller
                var historyData = _controller.LayLichSuTongHop(startTime, endTime, includeHopDong, includeKhachHang, includeMauQuanTrac);

                // Gán dữ liệu vào DataGridView
                dataSaoLuu.DataSource = historyData;
            }
            catch (Exception ex)
            {
                HienThiThongBao($"Lỗi khi cập nhật dữ liệu: {ex.Message}", true);
            }
        }

        // Xử lý sự kiện nút "Phục hồi"
        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (dataSaoLuu.SelectedRows.Count > 0)
            {
                try
                {
                    // Lấy dòng được chọn
                    var selectedRow = dataSaoLuu.SelectedRows[0];

                    // Lấy thông tin từ dòng được chọn
                    var bangGocValue = selectedRow.Cells["Banggoc"]?.Value;
                    if (bangGocValue == null)
                    {
                        HienThiThongBao("Không thể phục hồi dữ liệu vì tên bảng gốc không xác định.", true);
                        return;
                    }
                    string? sourceTable = bangGocValue.ToString(); // Lấy bảng gốc
                    if (string.IsNullOrEmpty(sourceTable))
                    {
                        return;
                    }
                    string historyTable = $"{sourceTable}"; // Tạo bảng lịch sử

                    string primaryKeyColumn = "Khoachinh"; // Cột khóa chính trong bảng lịch sử

                    var khoachinhValue = selectedRow.Cells["Khoachinh"]?.Value;
                    if (khoachinhValue == null)
                    {
                        HienThiThongBao("Không thể phục hồi dữ liệu vì khóa chính không xác định.", true);
                        return;
                    }
                    object primaryKeyValue = khoachinhValue;

                    // Gọi phương thức phục hồi từ Controller
                    _controller.PhucHoiDuLieu(historyTable, sourceTable, primaryKeyColumn, primaryKeyValue);

                    // Cập nhật lại DataGridView
                    UpdateDataGridView();

                    // Hiển thị thông báo thành công
                    HienThiThongBao("Phục hồi dữ liệu thành công!", false);
                }
                catch (Exception ex)
                {
                    HienThiThongBao($"Lỗi khi phục hồi dữ liệu: {ex.Message}", true);
                }
            }
            else
            {
                HienThiThongBao("Vui lòng chọn một dòng để phục hồi!", true);
            }
        }

        // Xử lý sự kiện nút "Hủy bỏ"
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            try
            {
                // Đặt ComboBox về giá trị mặc định
                comboBoxTimeRange.SelectedIndex = 0; // Chọn giá trị mặc định

                // Bỏ chọn tất cả các CheckBox
                rabHopDong.Checked = false;
                rabKhachHang.Checked = false;
                rabMauQuanTrac.Checked = false;
                rabPhieuTraHang.Checked = false;

                // Hiển thị thông báo xác nhận
                HienThiThongBao("Đã hủy tất cả các lựa chọn!", false);
            }
            catch (Exception ex)
            {
                HienThiThongBao($"Lỗi khi hủy thao tác: {ex.Message}", true);
            }
        }

        private void lienHevaHotroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lienHeTroGiup = new lienHeTroGiup();
            lienHeTroGiup.ShowDialog();
        }

        private void rabPhieuTraHang_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem radio button "Phiếu trả hàng" có được chọn hay không
            if (rabPhieuTraHang.Checked)
            {
                // Hiển thị thông báo
                HienThiThongBao("Chức năng này đang được phát triển!", false);
            }
            else
            {
                // Ẩn thông báo
                lblThongBao.Visible = false;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form lienHeTroGiup = new lienHeTroGiup();
            lienHeTroGiup.ShowDialog();
        }
    }
}
