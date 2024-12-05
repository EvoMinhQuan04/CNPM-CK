using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions; 

namespace WinFormsApp1
{
    public partial class lienHeTroGiup : Form
    {
        private string _placeholderText = "Tên";
        private string _placeholderText2 = "Email";
        private string _placeholderText3 = "Nhập nội dung...";

        public lienHeTroGiup()
        {
            InitializeComponent();

            SetPlaceholder(textBox1, _placeholderText);
            SetPlaceholder(textBox2, _placeholderText2);
            SetPlaceholder(textBox3, _placeholderText3);

            textBox1.GotFocus += RemovePlaceholder;
            textBox1.LostFocus += AddPlaceholder;

            textBox2.GotFocus += RemovePlaceholder;
            textBox2.LostFocus += AddPlaceholder;

            textBox3.GotFocus += RemovePlaceholder;
            textBox3.LostFocus += AddPlaceholder;
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
        }

        private void RemovePlaceholder(object? sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && textBox.ForeColor == Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == textBox1)
                    SetPlaceholder(textBox, _placeholderText);
                else if (textBox == textBox2)
                    SetPlaceholder(textBox, _placeholderText2);
                else if (textBox == textBox3)
                    SetPlaceholder(textBox, _placeholderText3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text; // Tên người dùng nhập
            string emailNguoiDung = textBox2.Text; // Email người dùng nhập
            string noiDungYeuCau = textBox3.Text; // Nội dung yêu cầu của người dùng

            // Email gửi cố định
            string emailGui = "415quancao@gmail.com";
            string matKhauEmailGui = "gvwx scah maxz ijrh"; // Thay bằng mật khẩu thực tế của email gửi

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrWhiteSpace(ten) || ten == _placeholderText)
            {
                lblThongBao.Text = "Vui lòng nhập tên!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(emailNguoiDung) || emailNguoiDung == _placeholderText2 || !IsValidEmail(emailNguoiDung))
            {
                lblThongBao.Text = "Vui lòng nhập email hợp lệ!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(noiDungYeuCau) || noiDungYeuCau == _placeholderText3)
            {
                lblThongBao.Text = "Vui lòng nhập nội dung yêu cầu!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }

            // Nội dung email gửi cho khách hàng
            string emailBodyKhachHang = $@"
            <!DOCTYPE html>
            <html>
            <head>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        background-color: #f9f9f9;
                        margin: 0;
                        padding: 0;
                    }}
                    .email-container {{
                        max-width: 600px;
                        margin: 20px auto;
                        background: #ffffff;
                        border: 1px solid #dddddd;
                        border-radius: 8px;
                        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
                        padding: 20px;
                    }}
                    .header {{
                        text-align: center;
                        background: #4CAF50;
                        color: white;
                        padding: 15px;
                        border-radius: 8px 8px 0 0;
                    }}
                    .content {{
                        margin-top: 20px;
                        font-size: 16px;
                        color: #333333;
                        line-height: 1.6;
                    }}
                    .footer {{
                        text-align: center;
                        margin-top: 20px;
                        font-size: 14px;
                        color: #666666;
                    }}
                </style>
            </head>
            <body>
                <div class='email-container'>
                    <div class='header'>
                        <h1>Hỗ Trợ Khách Hàng</h1>
                    </div>
                    <div class='content'>
                        <p>Xin chào <strong>{ten}</strong>,</p>
                        <p>
                            Cảm ơn quý khách đã tin dùng sản phẩm của chúng tôi. Về yêu cầu hỗ trợ của quý khách sẽ được đội ngũ công ty phản hồi đến quý khách trong thời gian sớm nhất.
                        </p>
                        <p>Xin trân trọng cảm ơn!</p>
                    </div>
                    <div class='footer'>
                        <p>&copy; {DateTime.Now.Year} InnoTrain. All rights reserved.</p>
                    </div>
                </div>
            </body>
            </html>";


            // Nội dung email gửi cho công ty
            string emailBodyCongTy = $@"
            <!DOCTYPE html>
            <html>
            <head>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        background-color: #f9f9f9;
                        margin: 0;
                        padding: 0;
                    }}
                    .email-container {{
                        max-width: 600px;
                        margin: 20px auto;
                        background: #ffffff;
                        border: 1px solid #dddddd;
                        border-radius: 8px;
                        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
                        padding: 20px;
                    }}
                    .header {{
                        text-align: center;
                        background: #2196F3;
                        color: white;
                        padding: 15px;
                        border-radius: 8px 8px 0 0;
                    }}
                    .content {{
                        margin-top: 20px;
                        font-size: 16px;
                        color: #333333;
                        line-height: 1.6;
                    }}
                    .footer {{
                        text-align: center;
                        margin-top: 20px;
                        font-size: 14px;
                        color: #666666;
                    }}
                </style>
            </head>
            <body>
                <div class='email-container'>
                    <div class='header'>
                        <h1>Yêu Cầu Khách Hàng</h1>
                    </div>
                    <div class='content'>
                        <p><strong>Tên khách hàng:</strong> {ten}</p>
                        <p><strong>Email khách hàng:</strong> {emailNguoiDung}</p>
                        <p><strong>Nội dung yêu cầu:</strong></p>
                        <p>{noiDungYeuCau}</p>
                    </div>
                    <div class='footer'>
                        <p>&copy; {DateTime.Now.Year} InnoTrain. All rights reserved.</p>
                    </div>
                </div>
            </body>
            </html>";


            try
            {
                // Gửi email xác nhận tới khách hàng
                SendEmail(emailGui, matKhauEmailGui, emailNguoiDung, "Hỗ Trợ Khách Hàng", emailBodyKhachHang, "THÔNG BÁO XÁC NHẬN");

                // Gửi email yêu cầu hỗ trợ tới công ty
                SendEmail(emailGui, matKhauEmailGui, emailGui, "Yêu cầu hỗ trợ từ khách hàng", emailBodyCongTy, "YÊU CẦU KHÁCH HÀNG");


                lblThongBao.Text = "Yêu cầu của bạn đã được gửi đi. Cảm ơn bạn đã liên hệ!";
                lblThongBao.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblThongBao.Text = $"Lỗi: {ex.Message}";
            }
        }

        // Hàm kiểm tra định dạng email
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // Hàm gửi email
        private void SendEmail(string emailGui, string matKhauEmailGui, string emailNhan, string tieuDe, string noiDung, string displayName)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(emailGui, displayName);
            mail.To.Add(emailNhan);
            mail.Subject = tieuDe;
            mail.Body = noiDung;
            mail.IsBodyHtml = true; // Cho phép HTML trong nội dung email

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(emailGui, matKhauEmailGui);
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }




    }
}
