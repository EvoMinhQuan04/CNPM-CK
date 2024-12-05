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

namespace WinFormsApp1.Views.quanLyNhanVienViews
{
    public partial class locThongTinNhanVien : Form
    {
        private readonly nhanVienController nvController;
        private readonly quanLyNhanVienControl nhanVienControl;
        public locThongTinNhanVien(string connectionString, quanLyNhanVienControl nhanVienControl)
        {
            InitializeComponent();
            nvController = new nhanVienController(connectionString);
            this.nhanVienControl = nhanVienControl;
            noiDungComboBox();
        }
        private void noiDungComboBox()
        {
            comboBoxThuocTinh.Items.Clear();
            comboBoxThuocTinh.Items.Add("Mã nhân viên");
            comboBoxThuocTinh.Items.Add("Tên nhân viên");
            comboBoxThuocTinh.Items.Add("Chức vụ");
            comboBoxThuocTinh.Items.Add("Email");
            comboBoxThuocTinh.Items.Add("Số điện thoại");
            comboBoxThuocTinh.Items.Add("Ngày sinh");
            comboBoxThuocTinh.SelectedIndex = 0;
        }

        private void HienThiKetQuaLoc(List<NhanVien> ketQuaLoc)
        {
            // Kiểm tra nếu có kết quả lọc
            if (ketQuaLoc.Count > 0)
            {
                nhanVienControl.dataGridViewNhanVien.Rows.Clear();
                foreach (var nv in ketQuaLoc)
                {
                    // Xử lý NgaySinh an toàn
                    string ngaySinh = nv.NgaySinh is DateTime
                        ? ((DateTime)nv.NgaySinh).ToString("dd/MM/yyyy")
                        : "Không xác định";

                    nhanVienControl.dataGridViewNhanVien.Rows.Add(
                        nv.MaNhanVien,
                        nv.HoVaTen,
                        ngaySinh,
                        nv.SoDienThoai,
                        nv.ChucVu,
                        nv.Email
                    );
                }
            }
        }
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
        private void btnLoc_Click(object sender, EventArgs e)
        {
            string selectedAttribute = comboBoxThuocTinh.Text;
            string inputValue = textBoxGiaTri.Text.Trim();

            if (string.IsNullOrEmpty(selectedAttribute) || string.IsNullOrEmpty(inputValue))
            {
                labelThongBao.Text = "Vui lòng chọn thuộc tính và nhập giá trị cần tìm kiếm.";
                labelThongBao.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Kiểm tra định dạng giá trị đầu vào
            switch (selectedAttribute)
            {
                case "Mã nhân viên":
                    if (!System.Text.RegularExpressions.Regex.IsMatch(inputValue, @"^[A-Z]+[0-9]*$") || inputValue.Contains(' '))
                    {
                        labelThongBao.Text = "Mã nhân viên phải viết hoa và có thể chứa số phía sau khi trùng tên, nhưng không có khoảng cách.";
                        labelThongBao.ForeColor = System.Drawing.Color.Red;
                        return ;
                    }
                    break;
                case "Tên nhân viên":
                    if (!KiemTraVietHoaChuCaiDau(inputValue))
                    {
                        labelThongBao.Text = "Họ và tên phải viết hoa chữ cái đầu mỗi chữ.";
                        labelThongBao.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                    break;
                case "Số điện thoại":
                    if (!Regex.IsMatch(inputValue, @"^(0|\+84)\d{9,10}$"))
                    {
                        labelThongBao.Text = "Số điện thoại không đúng định dạng. Vui lòng nhập số điện thoại hợp lệ.";
                        labelThongBao.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                    break;
                case "Email":
                    if (!Regex.IsMatch(inputValue, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                    {
                        labelThongBao.Text = "Email không đúng định dạng. Vui lòng nhập email hợp lệ.";
                        labelThongBao.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                    break;
                case "Ngày sinh":
                    if (!DateTime.TryParseExact(inputValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var ngaySinh))
                    {
                        labelThongBao.Text = "Ngày sinh không hợp lệ. Định dạng hợp lệ: dd/MM/yyyy.";
                        labelThongBao.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                    inputValue = ngaySinh.ToString("yyyy-MM-dd");
                    break;
                case "Chức vụ":
                    if (string.IsNullOrEmpty(inputValue))
                    {
                        labelThongBao.Text = "Chức vụ không được để trống.";
                        labelThongBao.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                    break;
                default:
                    labelThongBao.Text = "Thuộc tính không hợp lệ.";
                    labelThongBao.ForeColor = System.Drawing.Color.Red;
                    return;
            }

            try
            {
                var ketQuaLoc = nvController.LocNhanVien(selectedAttribute, inputValue);
                HienThiKetQuaLoc(ketQuaLoc);

                // Chỉ hiển thị kết quả khi có dữ liệu
                if (ketQuaLoc != null && ketQuaLoc.Count > 0)
                {
                    HienThiKetQuaLoc(ketQuaLoc);
                    labelThongBao.Text = "Lọc thành công!";
                    labelThongBao.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    labelThongBao.Text = "Không tìm thấy kết quả phù hợp.";
                    labelThongBao.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                labelThongBao.Text = "Lỗi khi lọc thông tin nhân viên: " + ex.Message;
                labelThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            comboBoxThuocTinh.SelectedIndex = 0;
            textBoxGiaTri.Clear();
            labelThongBao.Text = "";
        }
    }
}
