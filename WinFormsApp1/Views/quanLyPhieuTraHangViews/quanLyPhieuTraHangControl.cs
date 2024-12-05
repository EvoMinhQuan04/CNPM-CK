using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views.quanLyPhieuTraHangViews
{
    public partial class quanLyPhieuTraHangControl : UserControl
    {
        private readonly string _tenTaiKhoan;
        private phieuKetQuaController? phieuKetQuaController;
        private mauQuanTracController? mauQuanTracController;


        public quanLyPhieuTraHangControl(string tenTaiKhoan, string connectionString)
        {
            InitializeComponent();
            _tenTaiKhoan = tenTaiKhoan;
            phieuKetQuaController = new phieuKetQuaController(connectionString);
            mauQuanTracController = new mauQuanTracController(connectionString);
            lblUserName.Text = $"{_tenTaiKhoan}";
            duLieuPhieuKetQua();
            taoPhieuKetQua();
            btnCapNhat.Enabled = false;


        }
        //các hàm xử lí tự động tạo phiếu trả hàng khi có mẫu quan trắc
        private void taoPhieuKetQua()
        {
            var danhSachMauQuanTrac = mauQuanTracController?.LayDanhSachMauQuanTrac();
            if (danhSachMauQuanTrac == null)
            {
                lblThongBao.Text = "Không có dữ liệu mẫu quan trắc để tạo phiếu kết quả!";
                return;
            }
            phieuKetQuaController?.TaoPhieuKetQuaChoTatCaMauQuanTrac(danhSachMauQuanTrac);

            duLieuPhieuKetQua();
        }


        private void duLieuPhieuKetQua()
        {
            try
            {
                var danhSach = phieuKetQuaController?.LayDanhSachPhieuKetQua();
                dataGridViewPhieuKetQua.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView

                if (danhSach != null)
                {
                    foreach (var phieu in danhSach)
                    {
                        var rowIndex = dataGridViewPhieuKetQua.Rows.Add(
                            phieu.MaMauThu,
                            phieu.MaHopDong,
                            phieu.NgayLayMau.ToString("dd/MM/yyyy"),
                            phieu.NgayTraKetQua.ToString("dd/MM/yyyy"),
                            phieu.TrangThaiKetQuaPhanTich,
                            phieu.TrangThaiXuLy
                        );
                        // Gán Tag cho hàng
                        dataGridViewPhieuKetQua.Rows[rowIndex].Tag = phieu.MaPhieuKetQua;
                    }
                }
                //bỏ chọn hàng đầu tiên
                dataGridViewPhieuKetQua.ClearSelection();

            }
            catch (Exception ex)
            {
                lblThongBao.Text = $"Lỗi khi tải dữ liệu phiếu kết quả: {ex.Message}";
                lblThongBao.ForeColor = Color.Red;
            }
        }

        private void LoadChiTietThongSo(int maPhieuKetQua)
        {
            try
            {
                // Lấy danh sách chi tiết thông số từ Controller
                DataTable chiTietThongSo = phieuKetQuaController.LayChiTietThongSo(maPhieuKetQua);

                // Xóa tất cả các dòng trong DataGridView trước khi thêm dữ liệu mới
                dataGridViewChiTietThongSo.Rows.Clear();

                // Kiểm tra nếu không có dữ liệu
                if (chiTietThongSo == null || chiTietThongSo.Rows.Count == 0)
                {
                    // Chỉ hiển thị thông báo nếu người dùng đã chọn phiếu hợp lệ
                    lblThongBao.Text = "Không có dữ liệu chi tiết cho phiếu kết quả này!";
                    lblThongBao.ForeColor = Color.Red;
                    return;
                }
                lblThongBao.Text = string.Empty;

                // Thêm dữ liệu vào DataGridView
                foreach (DataRow row in chiTietThongSo.Rows)
                {
                    // Thêm từng dòng dữ liệu vào DataGridView
                    int rowIndex = dataGridViewChiTietThongSo.Rows.Add(
                        row["Thongso"]?.ToString(),
                        row["Donvi"]?.ToString(),
                        row["Phuongphapphantich"]?.ToString(),
                        row["KetquaPTN"]?.ToString(),
                        row["KetquaHT"]?.ToString(),
                        row["Quychuansosanh"]?.ToString()
                    );

                    // Gán Tag nếu cần (tùy chọn)
                    dataGridViewChiTietThongSo.Rows[rowIndex].Tag = row;
                    dataGridViewChiTietThongSo.Rows[rowIndex].Cells["Thongso"].Tag = row["Thongso"]; // Lưu giá trị đầy đủ
                }
                dataGridViewChiTietThongSo.ClearSelection();
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu xảy ra sự cố khi tải dữ liệu
                lblThongBao.Text = $"Lỗi khi tải dữ liệu chi tiết: {ex.Message}";
                lblThongBao.ForeColor = Color.Red;
            }
        }




        private void dataGridViewPhieuKetQua_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPhieuKetQua.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPhieuKetQua.SelectedRows[0];

                // Kiểm tra nếu hàng không có dữ liệu
                if (selectedRow.Cells["MaMau"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["MaMau"].Value.ToString()))
                {
                    // Gọi hàm để reset các TextBox
                    troVeBanDau();
                    return;
                }

                // Nếu hàng được chọn không có Tag hoặc không hợp lệ, bỏ qua
                if (selectedRow.Tag == null || !int.TryParse(selectedRow.Tag.ToString(), out int maPhieuKetQua))
                {
                    return; // Không hiển thị thông báo ở đây
                }

                // Gọi hàm LoadChiTietThongSo để kiểm tra và hiển thị dữ liệu chi tiết
                LoadChiTietThongSo(maPhieuKetQua);

                txtMaMau.Text = selectedRow.Cells["MaMau"].Value?.ToString();
                txtMaHopDong.Text = selectedRow.Cells["MaHopDong"].Value?.ToString();
                txtNgayLayMau.Text = selectedRow.Cells["NgayLayMau"].Value?.ToString();
                txtNgayTraKetQua.Text = selectedRow.Cells["NgayTraKetQua"].Value?.ToString();
                txtKetQuaPhanTich.Text = selectedRow.Cells["TrangThaiKetQuaPhanTich"].Value?.ToString();
                txtTrangThai.Text = selectedRow.Cells["TrangThaiXuLy"].Value?.ToString();

                // Gọi cập nhật thông số và đơn vị
                capNhatThongSoVaDonVi(txtMaMau.Text);
            }
            else
            {
                // Xóa dữ liệu trong các TextBox nếu không có hàng nào được chọn
                txtMaMau.Text = string.Empty;
                txtMaHopDong.Text = string.Empty;
                txtNgayLayMau.Text = string.Empty;
                txtNgayTraKetQua.Text = string.Empty;
                txtKetQuaPhanTich.Text = string.Empty;
                txtTrangThai.Text = string.Empty;
            }
        }
        private void troVeBanDau()
        {
            // Xóa dữ liệu trong các TextBox
            txtMaMau.Text = string.Empty;
            txtMaHopDong.Text = string.Empty;
            txtNgayLayMau.Text = string.Empty;
            txtNgayTraKetQua.Text = string.Empty;
            txtKetQuaPhanTich.Text = string.Empty;
            txtTrangThai.Text = string.Empty;

            // Xóa thông báo
            lblThongBao.Text = string.Empty;
            lblThongBao.Visible = false;

            // Reset các ComboBox (nếu cần)
            cmbThongSo.SelectedIndex = -1;
            cmbDonVi.SelectedIndex = -1;

        }




        private void capNhatThongSoVaDonVi(string maMau)
        {
            // Xóa các mục hiện tại trong combobox
            cmbThongSo.Items.Clear();
            cmbDonVi.Items.Clear();

            if (maMau.StartsWith("KK")) // Không khí
            {
                cmbThongSo.Items.AddRange(new string[] { "Nhiệt độ (°C)", "NO₂ (µg/Nm³, ppb)", "CO (µg/Nm³, ppb)", "SO₂ (µg/Nm³, ppb)", "O₃ (µg/Nm³, ppb)", "Bụi PM₁₀ (µg/Nm³)", "Bụi PM₂.₅ (µg/Nm³)" });
                cmbDonVi.Items.AddRange(new string[] { "°C", "µg/Nm³", "ppb" });
            }
            else if (maMau.StartsWith("NT")) // Nước thải
            {
                cmbThongSo.Items.AddRange(new string[] { "Lưu lượng (m³/h)", "Nhiệt độ (°C)", "Độ màu (Pt-Co)", "pH (-)", "TSS (mg/L)", "COD (mg/L)", "NH₄⁺ (mg/L)", "Tổng Phốtpho (mg/L)", "Tổng Nito (mg/L)", "TOC (mg/L)", "Clo dư (mg/L)" });
                cmbDonVi.Items.AddRange(new string[] { "m³/h", "°C", "Pt-Co", "mg/L", "-" });
            }
            else if (maMau.StartsWith("NM")) // Nước mặt
            {
                cmbThongSo.Items.AddRange(new string[] { "Nhiệt độ (°C)", "pH (-)", "TSS (mg/L)", "COD (mg/L)", "DO (mg/L)", "NO₃⁻ (mg/L)", "PO₄³⁻ (mg/L)", "NH₄⁺ (mg/L)", "Tổng P (mg/L)", "Tổng N (mg/L)", "TOC (mg/L)" });
                cmbDonVi.Items.AddRange(new string[] { "°C", "mg/L", "-" });
            }
            else if (maMau.StartsWith("D")) // Đất
            {
                cmbThongSo.Items.AddRange(new string[] { "Độ ẩm (%)", "pH (-)", "Kim loại nặng (mg/kg)", "Độ dẫn điện (µS/cm)" });
                cmbDonVi.Items.AddRange(new string[] { "%", "mg/kg", "µS/cm" });
            }
            else
            {
                lblThongBao.Text = "Không thể xác định loại mẫu!";
            }

            // Thiết lập giá trị mặc định cho ComboBox (nếu cần)
            if (cmbThongSo.Items.Count > 0) cmbThongSo.SelectedIndex = 0;
            if (cmbDonVi.Items.Count > 0) cmbDonVi.SelectedIndex = 0;

        }

        private void xuatPhieuMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridViewPhieuKetQua.SelectedRows.Count == 0)
                {
                    lblThongBao.Text = "Vui lòng chọn một phiếu trả hàng để xuất!";
                    lblThongBao.ForeColor = Color.Red;
                    return;
                }

                var selectedRow = dataGridViewPhieuKetQua.SelectedRows[0];
                if (selectedRow.Tag == null || !int.TryParse(selectedRow.Tag.ToString(), out int maPhieuKetQua))
                {
                    lblThongBao.Text = "Không thể xác định mã phiếu kết quả!";
                    lblThongBao.ForeColor = Color.Red;
                    return;
                }
                // Kiểm tra nếu phiếu kết quả chưa có dữ liệu chi tiết
                DataTable chiTietThongSo = phieuKetQuaController?.LayChiTietThongSo(maPhieuKetQua);
                if (chiTietThongSo == null || chiTietThongSo.Rows.Count == 0)
                {
                    lblThongBao.Text = "Phiếu kết quả này chưa có dữ liệu chi tiết, không thể xuất phiếu!";
                    lblThongBao.ForeColor = Color.Red;
                    return;
                }

                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Chọn nơi lưu file PDF";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var controller = new phieuKetQuaController(phieuKetQuaController._connectionString);
                        controller.ExportPhieuKetQuaToPdf(maPhieuKetQua, saveFileDialog.FileName);
                        lblThongBao.Text = "Xuất file PDF thành công!";
                    }
                }
            }
            catch (Exception ex)
            {
                lblThongBao.Text = $"Lỗi khi xuất file PDF: {ex.Message}";
            }


        }
        private string LayTenThongSo(string thongSoRaw)
        {
            if (string.IsNullOrWhiteSpace(thongSoRaw))
                return string.Empty;

            // Tách phần ngoài dấu ngoặc
            int index = thongSoRaw.IndexOf('(');
            if (index > 0)
                return thongSoRaw.Substring(0, index).Trim(); // Lấy phần trước dấu '('

            return thongSoRaw.Trim(); // Trường hợp không có dấu '('
        }


        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewPhieuKetQua.SelectedRows.Count == 0)
            {
                lblThongBao.Text = "Vui lòng chọn một phiếu trả hàng để xác nhận!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }

            var selectedRow = dataGridViewPhieuKetQua.SelectedRows[0];
            if (selectedRow.Tag == null || !int.TryParse(selectedRow.Tag.ToString(), out int maPhieuKetQua))
            {
                lblThongBao.Text = "Không thể xác định mã phiếu kết quả!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }



            // Lấy dữ liệu từ các combobox và textbox
            string thongSoRaw = cmbThongSo.SelectedItem?.ToString();
            string thongSo = LayTenThongSo(thongSoRaw);
            string donVi = cmbDonVi.SelectedItem?.ToString();
            string phuongPhap = txtPhuongPhapPhanTich.Text.Trim();
            string ketQuaPTN = txtNoiDungKetQuaPhanTichPTN.Text.Trim();
            string ketQuaHT = txtNoiDungKetQuaPhanTichHT.Text.Trim();
            string quyChuanSoSanh = txtQuyChuanVietNam.Text.Trim();
            // Kiểm tra các trường thông số
            if (string.IsNullOrWhiteSpace(thongSo) || string.IsNullOrWhiteSpace(donVi) || string.IsNullOrWhiteSpace(phuongPhap) || string.IsNullOrWhiteSpace(ketQuaHT) || string.IsNullOrWhiteSpace(quyChuanSoSanh) || string.IsNullOrWhiteSpace(ketQuaPTN))
            {
                lblThongBao.Text = "Vui lòng nhập đầy đủ thông tin chi tiết thông số!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }
            //kiểm tra thông số
            if (!phieuKetQuaController.KiemTraDonViHopLe(thongSo, donVi))
            {
                lblThongBao.Text = $"Đơn vị '{donVi}' không hợp lệ cho thông số '{thongSo}'!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }



            try
            {
                bool capNhatKetQuaThanhCong = false;
                bool luuChiTietThanhCong = false;

                // Gọi controller để cập nhật dữ liệu phiếu kết quả
                if (phieuKetQuaController != null)
                {
                    capNhatKetQuaThanhCong = phieuKetQuaController.CapNhatKetQuaPhieuTraHang(maPhieuKetQua);

                    if (!capNhatKetQuaThanhCong)
                    {
                        lblThongBao.Text = "Cập nhật kết quả phân tích thất bại!";
                        lblThongBao.ForeColor = Color.Red;
                    }
                    else
                    {
                        // Nếu thông số chưa tồn tại, tiến hành lưu
                        if (!phieuKetQuaController.KiemTraThuocTinhDaTonTai(maPhieuKetQua, thongSo))
                        {

                            luuChiTietThanhCong = phieuKetQuaController.ThemChiTietThongSo(maPhieuKetQua, thongSo, donVi, phuongPhap, ketQuaPTN, ketQuaHT, quyChuanSoSanh);



                            if (!luuChiTietThanhCong)
                            {
                                lblThongBao.Text = "Lưu thông tin chi tiết thất bại!";
                                lblThongBao.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            lblThongBao.Text = "Thông số đã tồn tại, không thể lưu trùng lặp!";
                            lblThongBao.ForeColor = Color.Red;
                        }
                    }

                    // Nếu cả hai nhiệm vụ đều thành công
                    if (capNhatKetQuaThanhCong && luuChiTietThanhCong)
                    {
                        lblThongBao.Text = "Cập nhật kết quả và lưu thông tin chi tiết thành công!";
                        lblThongBao.ForeColor = Color.Green;

                        // Làm mới dữ liệu nếu cần
                        duLieuPhieuKetQua();
                    }
                }
                else
                {
                    lblThongBao.Text = "Controller không được khởi tạo!";
                    lblThongBao.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblThongBao.Text = $"Lỗi: {ex.Message}";
                lblThongBao.ForeColor = Color.Red;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form lienHeTroGiup = new lienHeTroGiup();
            lienHeTroGiup.ShowDialog();
        }

        private void dataGridViewChiTietThongSo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewChiTietThongSo.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewChiTietThongSo.SelectedRows[0];

                // Kiểm tra nếu hàng không có dữ liệu
                if (selectedRow.Cells["Thongso"].Value == null ||
                    string.IsNullOrWhiteSpace(selectedRow.Cells["Thongso"].Value.ToString()))
                {
                    troVeBanDauChiTiet();
                    return;
                }

                string thongSoGoc = selectedRow.Cells["Thongso"].Value?.ToString();
                string donVi = selectedRow.Cells["Donvi"].Value?.ToString();

                // Ghép phần trong ngoặc để hiển thị
                string thongSoHienThi = TimVaHienThiThongSoDayDu(thongSoGoc, donVi);

                // Hiển thị giá trị đầy đủ trong ComboBox
                cmbThongSo.SelectedItem = thongSoHienThi;
                cmbDonVi.SelectedItem = donVi;
                txtPhuongPhapPhanTich.Text = selectedRow.Cells["Phuongphapphantich"].Value?.ToString();
                txtNoiDungKetQuaPhanTichPTN.Text = selectedRow.Cells["KetquaPTN"].Value?.ToString();
                txtNoiDungKetQuaPhanTichHT.Text = selectedRow.Cells["KetquaHT"].Value?.ToString();
                txtQuyChuanVietNam.Text = selectedRow.Cells["Quychuansosanh"].Value?.ToString();
            }
            else
            {
                // Nếu không có dòng nào được chọn, reset các trường
                troVeBanDauChiTiet();
            }
        }

        private string TimVaHienThiThongSoDayDu(string thongSo, string donVi)
        {
            if (string.IsNullOrEmpty(thongSo) || string.IsNullOrEmpty(donVi))
                return thongSo;

            foreach (var item in cmbThongSo.Items)
            {
                // Lấy giá trị từ ComboBox và kiểm tra phần đầu
                if (item.ToString().StartsWith(thongSo) && item.ToString().Contains(donVi))
                {
                    return item.ToString(); // Trả về giá trị đầy đủ nếu tìm thấy
                }
            }

            // Nếu không tìm thấy, tự động ghép phần trong ngoặc
            return $"{thongSo} ({donVi})";
        }

        private void troVeBanDauChiTiet()
        {
            cmbThongSo.SelectedIndex = -1;
            cmbDonVi.SelectedIndex = -1;
            txtPhuongPhapPhanTich.Clear();
            txtNoiDungKetQuaPhanTichPTN.Clear();
            txtNoiDungKetQuaPhanTichHT.Clear();
            txtQuyChuanVietNam.Clear();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTietThongSo.SelectedRows.Count == 0)
            {
                lblThongBao.Text = "Vui lòng chọn một dòng để sửa!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }

            // Lấy hàng được chọn
            var selectedRow = dataGridViewChiTietThongSo.SelectedRows[0];

            // Hiển thị dữ liệu lên các TextBox và ComboBox
            cmbThongSo.Text = selectedRow.Cells["Thongso"].Value?.ToString();
            cmbDonVi.Text = selectedRow.Cells["Donvi"].Value?.ToString();
            txtPhuongPhapPhanTich.Text = selectedRow.Cells["Phuongphapphantich"].Value?.ToString();
            txtNoiDungKetQuaPhanTichPTN.Text = selectedRow.Cells["KetquaPTN"].Value?.ToString();
            txtNoiDungKetQuaPhanTichHT.Text = selectedRow.Cells["KetquaHT"].Value?.ToString();
            txtQuyChuanVietNam.Text = selectedRow.Cells["Quychuansosanh"].Value?.ToString();

            // Hiển thị nút "Cập nhật"
            btnCapNhat.Enabled = true;
            cmbDonVi.Enabled = false;
            cmbThongSo.Enabled = false;

            // Ẩn thông báo
            lblThongBao.Text = string.Empty;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTietThongSo.SelectedRows.Count == 0)
            {
                lblThongBao.Text = "Vui lòng chọn một dòng để cập nhật!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }

            try
            {
                // Lấy hàng được chọn
                var selectedRow = dataGridViewPhieuKetQua.SelectedRows[0];
                if (selectedRow.Tag == null || !int.TryParse(selectedRow.Tag.ToString(), out int maPhieuKetQua))
                {
                    lblThongBao.Text = "Không thể xác định mã phiếu kết quả!";
                    lblThongBao.ForeColor = Color.Red;
                    return;
                }
                // Lấy thông tin từ giao diện
                string thongSoRaw = cmbThongSo.Text.Trim();
                string thongSo = LayTenThongSo(thongSoRaw);
                string donVi = cmbDonVi.Text.Trim();
                string phuongPhap = txtPhuongPhapPhanTich.Text.Trim();
                string ketQuaPTN = txtNoiDungKetQuaPhanTichPTN.Text.Trim();
                string ketQuaHT = txtNoiDungKetQuaPhanTichHT.Text.Trim();
                string quyChuanSoSanh = txtQuyChuanVietNam.Text.Trim();

                // Kiểm tra các trường thông số
                if (string.IsNullOrWhiteSpace(thongSo) || string.IsNullOrWhiteSpace(donVi) || string.IsNullOrWhiteSpace(phuongPhap) || string.IsNullOrWhiteSpace(ketQuaHT) || string.IsNullOrWhiteSpace(quyChuanSoSanh) || string.IsNullOrWhiteSpace(ketQuaPTN))
                {
                    lblThongBao.Text = "Vui lòng nhập đầy đủ thông tin chi tiết thông số!";
                    lblThongBao.ForeColor = Color.Red;
                    return;
                }

                // Cập nhật thông tin vào cơ sở dữ liệu
                bool capNhatThanhCong = phieuKetQuaController.CapNhatChiTietThongSo(maPhieuKetQua, thongSo, donVi, phuongPhap, ketQuaPTN, ketQuaHT, quyChuanSoSanh);

                if (capNhatThanhCong)
                {
                    lblThongBao.Text = "Cập nhật thành công!";
                    lblThongBao.ForeColor = Color.Green;
                    LoadChiTietThongSo(maPhieuKetQua);
                }
                else
                {
                    lblThongBao.Text = "Cập nhật thất bại!";
                    lblThongBao.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblThongBao.Text = $"Lỗi: {ex.Message}";
                lblThongBao.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các TextBox và ComboBox
            cmbThongSo.SelectedIndex = -1;
            cmbDonVi.SelectedIndex = -1;
            dataGridViewChiTietThongSo.ClearSelection();
            dataGridViewPhieuKetQua.ClearSelection();
            txtPhuongPhapPhanTich.Clear();
            txtNoiDungKetQuaPhanTichPTN.Clear();
            txtNoiDungKetQuaPhanTichHT.Clear();
            txtQuyChuanVietNam.Clear();
            // Ẩn nút "Cập nhật"
            btnCapNhat.Enabled = false;
            cmbDonVi.Enabled = true;
            cmbThongSo.Enabled = true;

            // Xóa thông báo
            lblThongBao.Text = string.Empty;
        }
    }
}
