// Views/ucTrangChu.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;
using WinFormsApp1.Views.quanLyHopDongViews;
using WinFormsApp1.Views.quanLyNhanVienViews;
using WinFormsApp1.Views.saoLuuPhucHoiViews;
using WinFormsApp1.UI;
namespace WinFormsApp1.Views
{
    public partial class ucTrangChu : UserControl
    {


        private string _connectionString;
        private string _tenTaiKhoan;
        private string _vaiTro;
        private chatbotController _chatbotController;

        public ucTrangChu(string tenTaiKhoan, string connectionString, string vaiTro)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _tenTaiKhoan = tenTaiKhoan;
            txtHienThiTen1.Text = _tenTaiKhoan;
            lblHienThiTen.Text = _tenTaiKhoan;
            _vaiTro = vaiTro;
            _chatbotController = new chatbotController(_connectionString);


        }


        private void button17_Click_1(object sender, EventArgs e)
        {
            Form lienHeTroGiup = new lienHeTroGiup();
            lienHeTroGiup.ShowDialog();

        }

        private async void button15_Click_1(object sender, EventArgs e)
        {
            string userInput = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("Vui lòng nhập câu hỏi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị câu hỏi của người dùng (tạm thời)
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.SelectionColor = Color.Blue; // Màu xanh cho câu hỏi người dùng
            richTextBox1.AppendText($"Bạn: {userInput}\n\n");
            txtInput.Clear();

            // Hiển thị "Đang trả lời..." của chatbot (bên trái)
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.SelectionColor = Color.Gray; // Màu xám cho loading
            richTextBox1.AppendText("Chatbot: Đang trả lời...\n");
            richTextBox1.ScrollToCaret();

            // Hiệu ứng chờ (giả lập xử lý)
            await Task.Delay(2000); // Chờ 2 giây

            // Xóa câu hỏi cũ và "Đang trả lời..."
            int lastUserQuestionIndex = richTextBox1.Text.LastIndexOf($"Bạn: {userInput}");
            int chatbotLoadingIndex = richTextBox1.Text.LastIndexOf("Chatbot: Đang trả lời...");

            // Kiểm tra và xóa câu hỏi người dùng (nếu tồn tại)
            if (lastUserQuestionIndex >= 0 && lastUserQuestionIndex + $"Bạn: {userInput}\n\n".Length <= richTextBox1.Text.Length)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(lastUserQuestionIndex, $"Bạn: {userInput}\n\n".Length);
            }

            // Kiểm tra và xóa "Đang trả lời..." (nếu tồn tại)
            if (chatbotLoadingIndex >= 0 && chatbotLoadingIndex + "Chatbot: Đang trả lời...\n".Length <= richTextBox1.Text.Length)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(chatbotLoadingIndex, "Chatbot: Đang trả lời...\n".Length);
            }

            // Lấy phản hồi từ chatbot
            string response = _chatbotController.HandleRequest(userInput);

            // Hiển thị lại câu hỏi của người dùng (bên phải)
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.AppendText($"Bạn: {userInput}\n\n");

            // Hiển thị phản hồi từ chatbot (bên trái)
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.SelectionColor = Color.Green; // Màu xanh lá cho phản hồi chatbot
            richTextBox1.AppendText($"Chatbot: {response}\n\n");
            richTextBox1.ScrollToCaret();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form lienHeTroGiup = new lienHeTroGiup();
            lienHeTroGiup.ShowDialog();
        }
    }
}
