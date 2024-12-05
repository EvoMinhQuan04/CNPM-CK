using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views.quanLyNhanVienViews
{
    public partial class lichSu : Form
    {
        private readonly nhanVienController _controller;

        public lichSu(string connectionString)
        {
            InitializeComponent();
            _controller = new nhanVienController(connectionString);
            InitializeControls();
        }

        // Khởi tạo các thành phần giao diện
        private void InitializeControls()
        {
            // ComboBox cho khoảng thời gian
            comboBoxThoiGian.Items.AddRange(new object[]
            {
                "1 giờ trước",
                "1 ngày trước",
                "1 tuần trước",
                "4 tuần trước"
            });
            comboBoxThoiGian.SelectedIndex = 0; // Mặc định chọn "1 giờ trước"

            // ComboBox cho bảng
            cbxChonBang.Items.AddRange(new object[]
            {
                "Hợp đồng",
                "Khách hàng",
                "Mẫu quan trắc",
                "Phiếu kết quả"
            });
            cbxChonBang.SelectedIndex = 0; // Mặc định chọn bảng đầu tiên

            // Ẩn thông báo ban đầu
            lblThongBao.Visible = false;

            // Cấu hình DataGridView
            dataGridViewHistory.AutoGenerateColumns = true;
            dataGridViewHistory.ReadOnly = true;
            dataGridViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm")
            {
                txtTimKiem.Text = string.Empty; // Xóa nội dung "Tìm kiếm"
                txtTimKiem.ForeColor = Color.Black; // Đổi màu chữ thành màu đen
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm kiếm"; // Đặt lại nội dung "Tìm kiếm"
                txtTimKiem.ForeColor = Color.Gray; // Đổi màu chữ thành màu xám nhạt
            }
        }

        // Xử lý sự kiện nút "Đặt lại"
        private void btnReset_Click(object sender, EventArgs e)
        {
            comboBoxThoiGian.SelectedIndex = 0;
            cbxChonBang.SelectedIndex = 0;
            txtTimKiem.Clear();
            dataGridViewHistory.DataSource = null;
            lblThongBao.Visible = false;
        }

        private void luuThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ ComboBox
                var selectedTimeRange = comboBoxThoiGian.SelectedItem?.ToString();
                var selectedTable = cbxChonBang.SelectedItem?.ToString();
                var searchKeyword = txtTimKiem.Text.Trim();

                if (string.IsNullOrEmpty(selectedTimeRange) || string.IsNullOrEmpty(selectedTable))
                {
                    MessageBox.Show("Vui lòng chọn khoảng thời gian và bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //lấy từ nhanvienController
                // Lấy khoảng thời gian
                var (startTime, endTime) = _controller.LayKhoangThoiGian(selectedTimeRange);

                // Lấy dữ liệu từ controller
                var dataTable = _controller.LayLichSuTongHop(
                    startTime,
                    endTime,
                    includeHopDong: selectedTable == "Hợp đồng",
                    includeKhachHang: selectedTable == "Khách hàng",
                    includeMauQuanTrac: selectedTable == "Mẫu quan trắc",
                    includePhieuKetQua: selectedTable == "Phiếu kết quả"
                );
                if (dataTable.Rows.Count > 0 && !string.IsNullOrEmpty(searchKeyword))
                {
                    var filteredRows = dataTable.AsEnumerable()
                        .Where(row => row.ItemArray.Any(field => field.ToString().Contains(searchKeyword)))
                        .CopyToDataTable();
                    dataGridViewHistory.DataSource = filteredRows;
                }
                else
                {
                    dataGridViewHistory.DataSource = dataTable;
                }
                if (dataGridViewHistory.Columns.Contains("Banggoc"))
                    dataGridViewHistory.Columns.Remove("Banggoc");

                if (dataGridViewHistory.Columns.Contains("Khoachinh"))
                    dataGridViewHistory.Columns.Remove("Khoachinh");

                if (dataGridViewHistory.RowCount - 1 == 0)
                {
                    lblThongBao.Text = "Không có chỉnh sửa mới trong khoảng thời gian này";
                    lblThongBao.ForeColor = Color.Green;
                    lblThongBao.Visible = true;
                }
                else
                {
                    lblThongBao.Text = $"Tìm thấy {dataGridViewHistory.RowCount - 1} kết quả.";
                    lblThongBao.ForeColor = Color.Green;
                    lblThongBao.Visible = true;
                }
            }
            catch (InvalidOperationException)
            {
                lblThongBao.Text = "Không có dữ liệu nào khớp với từ khóa tìm kiếm.";
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
