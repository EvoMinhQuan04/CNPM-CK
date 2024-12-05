using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;
using WinFormsApp1.Views;

namespace WinFormsApp1.Views;

public partial class locThongTinKhachHang : Form
{
    private readonly khachHangController khController;
    private readonly quanLyKhachHangControl khachHangControl;

    public locThongTinKhachHang(string connectionString, quanLyKhachHangControl khachHangControl)
    {
        InitializeComponent();
        khController = new khachHangController(connectionString);
        this.khachHangControl = khachHangControl;
        noiDungComboBox();
    }

    private void noiDungComboBox()
    {
        comboBoxThuocTinh.Items.Clear();
        comboBoxThuocTinh.Items.Add("Mã khách hàng");
        comboBoxThuocTinh.Items.Add("Tên công ty");
        comboBoxThuocTinh.Items.Add("Địa chỉ");
        comboBoxThuocTinh.Items.Add("Người đại diện");
        comboBoxThuocTinh.Items.Add("Mã hợp đồng");
        comboBoxThuocTinh.Items.Add("Số điện thoại");
        comboBoxThuocTinh.Items.Add("Email");
        comboBoxThuocTinh.SelectedIndex = 0;
    }




    private void HienThiKetQuaLoc(List<KhachHang> ketQuaLoc)
    {
        // Xóa toàn bộ các hàng trong DataGridView trước khi thêm mới
        khachHangControl.dataGridViewKhachHang.Rows.Clear();

        // Duyệt qua danh sách khách hàng và thêm từng hàng vào DataGridView
        foreach (var kh in ketQuaLoc)
        {
            khachHangControl.dataGridViewKhachHang.Rows.Add(
                kh.MaKhachHang,
                kh.TenCongTy,
                kh.Email,
                kh.DiaChi,
                kh.MaHopDong,
                kh.SoDienThoai,
                kh.NguoiDaiDien
            );
        }
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
        // Kiểm tra dữ liệu theo loại thuộc tính
        switch (selectedAttribute)
        {
            case "Mã khách hàng":
                if (!Regex.IsMatch(inputValue, @"^KH\d+$"))
                {
                    labelThongBao.Text = "Mã khách hàng không đúng định dạng. Định dạng hợp lệ: KHx. Với x là số hoặc nhiều số";
                    labelThongBao.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                break;
            case "Mã hợp đồng":
                if (!Regex.IsMatch(inputValue, @"^\d{2}\.\d{3}$"))
                {
                    labelThongBao.Text = "Mã hợp đồng không đúng định dạng. Định dạng hợp lệ: 24.xxx. 24 đại diện cho năm, xxx là số có 3 chữ số";
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
        }

        try
        {
            // Lấy kết quả lọc từ controller
            var ketQuaLoc = khController.LocKhachHang(selectedAttribute, inputValue);

            // Kiểm tra dữ liệu trả về trước khi hiển thị
            if (ketQuaLoc != null && ketQuaLoc.Any()) // Kiểm tra danh sách có dữ liệu
            {
                HienThiKetQuaLoc(ketQuaLoc); // Hiển thị dữ liệu
                labelThongBao.Text = "Lọc thành công!";
                labelThongBao.ForeColor = System.Drawing.Color.Green;
                labelThongBao.Visible = true;
            }
            else
            {
                labelThongBao.Text = "Không tìm thấy kết quả phù hợp.";
                labelThongBao.ForeColor = System.Drawing.Color.Red;
                labelThongBao.Visible = true;
            }
        }
        catch (Exception ex)
        {
            // Hiển thị thông báo lỗi nếu có exception
            labelThongBao.Text = "Lỗi khi lọc thông tin khách hàng: " + ex.Message;
            labelThongBao.ForeColor = System.Drawing.Color.Red;
            labelThongBao.Visible = true;
        }

    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        comboBoxThuocTinh.SelectedIndex = 0;
        textBoxGiaTri.Clear();
        labelThongBao.Text = "";
    }
}
