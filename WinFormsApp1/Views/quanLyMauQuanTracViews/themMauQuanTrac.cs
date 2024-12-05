using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Controllers;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class themMauQuanTrac : Form
    {
        private readonly mauQuanTracController? _maucontroller;
        // Sự kiện thông báo dữ liệu đã được lưu
        public event EventHandler? luuDuLieu;

        public themMauQuanTrac(string connectionString)
        {
            InitializeComponent();
            _maucontroller = new mauQuanTracController(connectionString);


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa thông báo
                lblThongBao.Text = "";
                lblThongBao.ForeColor = Color.Black;

                //lấy dữ liệu từ các control
                string maHopDong = txtMaHopDong.Text.Trim();
                string maMau = txtMaMau.Text.Trim();
                string tenMau = txtTenMau.Text.Trim();
                string noiDung = txtNoiDung.Text.Trim();
                DateTime ngayLay = dtpNgayLay.Value;
                DateTime ngayTra = dtpNgayTra.Value;
                string maNhanVien = txtMaNhanVien.Text.Trim();


                //kiểm tra nhập thiếu thông tin
                if (!kiemTraNhapDuLieuDayDu())
                {
                    return;
                }

                //kiểm tra định dạng các dữ liệu nhập vào
                if (!kiemTraDuLieu())
                {
                    return;
                }

                var mau = new MauQuanTrac
                {
                    MaHopDong = txtMaHopDong.Text.Trim(),
                    MaMau = txtMaMau.Text.Trim(),
                    TenMau = txtTenMau.Text.Trim(),
                    NoiDung = txtNoiDung.Text.Trim(),
                    NgayLay = dtpNgayLay.Value,
                    NgayTra = dtpNgayTra.Value,
                    MaNhanVien = txtMaNhanVien.Text.Trim()
                };

                // Gọi hàm thêm mẫu từ Controller
                if (_maucontroller != null)
                {
                    bool result = _maucontroller.ThemMauQuanTrac(mau);
                    if (result)
                    {
                        lblThongBao.Text = "Thêm mẫu quan trắc thành công.";
                        lblThongBao.ForeColor = Color.Green;
                        luuDuLieu?.Invoke(this, EventArgs.Empty);

                    }
                    else
                    {
                        lblThongBao.Text = "Thêm mẫu quan trắc thất bại.";
                        lblThongBao.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblThongBao.Text = "Lỗi: Controller không được khởi tạo.";
                    lblThongBao.ForeColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                lblThongBao.Text = $"Lỗi: {ex.Message}";
            }

        }

        //hàm kiểm tra nhập thông tin đầu vào
        private bool kiemTraNhapDuLieuDayDu()
        {
            if (string.IsNullOrWhiteSpace(txtMaHopDong.Text))
            {
                lblThongBao.Text = "Mã hợp đồng không được để trống.";
                lblThongBao.ForeColor = Color.Red;
                txtMaHopDong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaMau.Text))
            {
                lblThongBao.Text = "Mã mẫu không được để trống.";
                lblThongBao.ForeColor = Color.Red;
                txtMaMau.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenMau.Text))
            {
                lblThongBao.Text = "Tên mẫu không được để trống.";
                lblThongBao.ForeColor = Color.Red;
                txtTenMau.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                lblThongBao.Text = "Nội dung không được để trống.";
                lblThongBao.ForeColor = Color.Red;
                txtNoiDung.Focus();
                return false;
            }
            if (dtpNgayLay.Value > dtpNgayTra.Value)
            {
                lblThongBao.Text = "Ngày lấy không được lớn hơn ngày trả.";
                lblThongBao.ForeColor = Color.Red;
                dtpNgayLay.Focus();
                return false;
            }
            //if (cmbKetQua.SelectedItem == null)
            //{
            //    lblThongBao.Text = "Kết quả không được để trống.";
            //    lblThongBao.ForeColor = Color.Red;
            //    cmbKetQua.Focus();
            //    return false;
            //}
            if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
            {
                lblThongBao.Text = "Mã nhân viên không được để trống.";
                lblThongBao.ForeColor = Color.Red;
                txtMaNhanVien.Focus();
                return false;
            }

            return true;
        }
        //hàm kiểm tra dữ liệu tồn tại và trùng nhau
        private bool kiemTraDuLieu()
        {
            if (_maucontroller == null)
            {
                lblThongBao.Text = "Lỗi: Controller không được khởi tạo.";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }
            //kiểm tra định dạng mã hợp đồng
            if (!Regex.IsMatch(txtMaHopDong.Text.Trim(), @"^\d{2}\.\d{3}$"))
            {
                lblThongBao.Text = "Mã hợp đồng sai định dạng. Định dạng hợp lệ xx.y với xx đại diện năm, y là số gồm 3 chữ số";
                lblThongBao.ForeColor = Color.Red;
                txtMaHopDong.Focus();
                return false;
            }

            //kiểm tra mã hợp đồng không tồn tại cả trong qlkh, qlhd
            if (!_maucontroller.KiemTraMaHopDongTonTai(txtMaHopDong.Text.Trim()))
            {
                lblThongBao.Text = "Mã hợp đồng không tồn tại.";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }
            //kiểm tra định dạng tiền tố nhập của mã mẫu chỉ có các giá trị sau: NM, NT, KK, D đằng sau là các số.
            if (!Regex.IsMatch(txtMaMau.Text.Trim(), @"^(NM|NT|KK|D)\d+$"))
            {
                lblThongBao.Text = "Mã mẫu không đúng định dạng. Định dạng hợp lệ: NMx; NTx, KKx, Dx với x là các số có 1 hoặc nhiều chữ số.";
                lblThongBao.ForeColor = Color.Red;
                txtMaMau.Focus();
                return false;
            }
            //kiểm tra tồn tại mã mẫu trong qlmqt
            if (_maucontroller != null && _maucontroller.KiemTraMaMauTonTai(txtMaMau.Text.Trim()))
            {
                lblThongBao.Text = "Mã mẫu đã tồn tại. Vui lòng nhập mã khác.";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }
            //kiểm tra định dạng mã nhân viên phải viết hoa và có thể chứa số phía sau nếu trùng tên, nhưng không có khoảng cách.
            if (!Regex.IsMatch(txtMaNhanVien.Text.Trim(), @"^[A-Z]+[0-9]*$") || txtMaNhanVien.Text.Trim().Contains(' '))
            {
                lblThongBao.Text = "Mã nhân viên phải viết hoa và có thể chứa số phía sau nếu trùng tên, nhưng không có khoảng cách.";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }

            //kiểm tra mã nhân viên phải tồn tại - túc là phải có nhân viên đó.
            if (_maucontroller != null && !_maucontroller.KiemTraMaNhanVienTonTai(txtMaNhanVien.Text.Trim()))
            {
                lblThongBao.Text = "Mã nhân viên không tồn tại.";
                lblThongBao.ForeColor = Color.Red;
                return false;
            }


            return true;
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            //reset lại các control
            txtMaHopDong.Text = "";
            txtMaMau.Text = "";
            txtTenMau.Text = "";
            txtNoiDung.Text = "";
            dtpNgayLay.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            txtMaNhanVien.Text = "";
            lblThongBao.Text = "";
        }
    }
}
