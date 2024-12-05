// Views/dangNhapTaiKhoan.cs
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WinFormsApp1.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.Views
{
    public partial class dangNhapTaiKhoan : Form
    {
        private readonly dangNhapTaiKhoanController _controller;
        private readonly string _connectionString;
        private string _placeholderText = "Mã người dùng/Email";
        private string _placeholderText2 = "Mật khẩu";

        public dangNhapTaiKhoan(dangNhapTaiKhoanController controller, string connectionString)
        {
            InitializeComponent();
            _controller = controller;
            _connectionString = connectionString;
            SetPlaceholder(txtTaiKhoan, _placeholderText);
            SetPlaceholder(txtMatKhau, _placeholderText2);
            txtTaiKhoan.GotFocus += RemovePlaceholder;
            txtTaiKhoan.LostFocus += AddPlaceholder;

            txtMatKhau.GotFocus += RemovePlaceholder;
            txtMatKhau.LostFocus += AddPlaceholder;

            // Đặt thuộc tính PasswordChar để ẩn mật khẩu ban đầu
            txtMatKhau.PasswordChar = '\0';

            // Đăng ký sự kiện cho checkBoxHien
            checkBoxHien.CheckedChanged += checkBoxHien_CheckedChanged;
        }
        private void SetPlaceholder(System.Windows.Forms.TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            if (textBox == txtMatKhau)
            {
                textBox.PasswordChar = '\0'; // Hiển thị Placeholder không ẩn
            }
        }

        private void RemovePlaceholder(object? sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != null && textBox.ForeColor == Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                if (textBox == txtMatKhau)
                {
                    textBox.PasswordChar = '*'; // Ẩn mật khẩu

                }
            }
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == txtTaiKhoan)
                    SetPlaceholder(textBox, _placeholderText);
                else if (textBox == txtMatKhau)
                    SetPlaceholder(textBox, _placeholderText2);
                
            }
        }

        // Phương thức xử lý sự kiện CheckedChanged của checkBoxHien
        private void checkBoxHien_CheckedChanged(object? sender, EventArgs e)
        {
            if (txtMatKhau.ForeColor != Color.Gray && !string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                if (checkBoxHien.Checked)
                {
                    txtMatKhau.PasswordChar = '\0'; // Hiển thị mật khẩu
                }
                else
                {
                    txtMatKhau.PasswordChar = '*'; // Ẩn mật khẩu
                }
            }
            else
            {
                // Nếu TextBox không có nội dung thực, giữ nguyên trạng thái Placeholder
                txtMatKhau.PasswordChar = '\0'; // Đảm bảo Placeholder hiển thị
            }
        }

        private void xacNhan_Click(object sender, EventArgs e)
        {
            string taiKhoanHoacEmail = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // Kiểm tra điều kiện nhập vào (tài khoản hoặc email)
            if (string.IsNullOrEmpty(taiKhoanHoacEmail) || string.IsNullOrEmpty(matKhau))
            {
                lblThongBao.Text = "Vui lòng nhập đầy đủ tài khoản/email và mật khẩu.";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Kiểm tra định dạng email hoặc tài khoản
            bool isEmail = Regex.IsMatch(taiKhoanHoacEmail, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"); // Kiểm tra định dạng email
            bool isUsername = Regex.IsMatch(taiKhoanHoacEmail, @"^[A-Z0-9]{3,5}$"); // 3 đến 5 ký tự viết hoa

            if (!isEmail && !isUsername)
            {
                lblThongBao.Text = "Vui lòng nhập đúng định dạng Email hoặc tài khoản của bạn.";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                return;
            }
           
            // Kiểm tra điều kiện của mật khẩu
            string matKhauPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$";
            if (!Regex.IsMatch(matKhau, matKhauPattern))
            {
                lblThongBao.Text = "Mật khẩu phải có ít nhất 6 ký tự, bao gồm chữ hoa, chữ thường và số.";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                return;
            }
            bool ketQuaDangNhap = _controller.KiemTraDangNhap(taiKhoanHoacEmail, matKhau);

            if (ketQuaDangNhap)
            {
                string vaiTro = _controller.LayVaiTro(taiKhoanHoacEmail); // Lấy vai trò của người dùng
                lblThongBao.Text = "Đăng nhập thành công!";
                lblThongBao.ForeColor = System.Drawing.Color.Green;
                _controller.MoTrangChu(this, taiKhoanHoacEmail, vaiTro);
            }
            else
            {
                lblThongBao.Text = "Tài khoản/email hoặc mật khẩu không đúng.";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }


        private void dangNhapTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //quên mật khẩu click
        private void label2_Click(object sender, EventArgs e)
        {
            var formQuenMatKhau = new quenMatKhau(_connectionString);
            formQuenMatKhau.Show();
            this.Hide();
        }
    }
}
