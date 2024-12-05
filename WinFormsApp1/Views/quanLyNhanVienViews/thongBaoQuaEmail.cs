
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views.quanLyNhanVienViews
{
    public partial class thongBaoQuaEmail : Form
    {
        private readonly nhanVienController _controller;
        private List<string> attachmentPaths = new List<string>();
        private string placeholderTextBox = "Tiêu đề Email";
        private string placeholderRichTextBox = "Nội dung Email";



        public thongBaoQuaEmail(nhanVienController controller)
        {
            InitializeComponent();
            _controller = controller;
            LoadNhanVienComboBox();
            lblThongBao.Text = "";
            //placeholder for textboxes
            SetPlaceholderForTextBox(txtTieuDe);
            txtTieuDe.GotFocus += RemovePlaceholderForTextBox;
            txtTieuDe.LostFocus += AddPlaceholderForTextBox;
            //placeholder for richtextbox
            SetPlaceholderForRichTextBox(txtNoiDung);
            txtNoiDung.GotFocus += RemovePlaceholderForRichTextBox;
            txtNoiDung.LostFocus += AddPlaceholderForRichTextBox;
            cbxChonNhanVien.AutoCompleteMode = AutoCompleteMode.None;
            cbxChonNhanVien.AutoCompleteSource = AutoCompleteSource.None;

        }
        // Placeholder của tiêu đề email
        private void SetPlaceholderForTextBox(TextBox textBox)
        {
            textBox.Text = placeholderTextBox;
            textBox.ForeColor = Color.Gray;
        }

        private void RemovePlaceholderForTextBox(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == placeholderTextBox && textBox.ForeColor == Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void AddPlaceholderForTextBox(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderTextBox;
                textBox.ForeColor = Color.Gray;
            }
        }
        //placeholder cho nội dung email
        private void SetPlaceholderForRichTextBox(RichTextBox richTextBox)
        {
            richTextBox.Text = placeholderRichTextBox;
            richTextBox.ForeColor = Color.Gray;
        }

        private void RemovePlaceholderForRichTextBox(object? sender, EventArgs e)
        {
            RichTextBox richTextBox = sender as RichTextBox;
            if (richTextBox != null && richTextBox.Text == placeholderRichTextBox && richTextBox.ForeColor == Color.Gray)
            {
                richTextBox.Text = "";
                richTextBox.ForeColor = Color.Black;
            }
        }

        private void AddPlaceholderForRichTextBox(object? sender, EventArgs e)
        {
            RichTextBox richTextBox = sender as RichTextBox;
            if (richTextBox != null && string.IsNullOrWhiteSpace(richTextBox.Text))
            {
                richTextBox.Text = placeholderRichTextBox;
                richTextBox.ForeColor = Color.Gray;
            }
        }


        private void LoadNhanVienComboBox()
        {
            var danhSachNhanVien = _controller.LayDanhSachNhanVien();
            foreach (var nhanVien in danhSachNhanVien)
            {
                if (!string.IsNullOrEmpty(nhanVien.HoVaTen) && !string.IsNullOrEmpty(nhanVien.Email))
                {
                    cbxChonNhanVien.Items.Add(new ComboBoxItem(nhanVien.HoVaTen, nhanVien.Email));
                }
            }

        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btnGuiMail_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "";

            // Kiểm tra nếu không có mục nào được chọn
            if (cbxChonNhanVien.SelectedItem == null)
            {
                // Tìm nhân viên khớp với Text nhập liệu (không phân biệt hoa thường)
                string enteredText = cbxChonNhanVien.Text.Trim().ToLower();
                foreach (var item in cbxChonNhanVien.Items)
                {
                    if (item is ComboBoxItem comboBoxItem && comboBoxItem.Text.ToLower() == enteredText)
                    {
                        cbxChonNhanVien.SelectedItem = comboBoxItem; // Cập nhật SelectedItem
                        break;
                    }
                }
            }

            // Nếu vẫn không tìm thấy nhân viên
            if (cbxChonNhanVien.SelectedItem == null)
            {
                ShowMessage("Vui lòng chọn một nhân viên.", false);
                return;
            }

            // Lấy email của nhân viên được chọn
            string recipientEmail = ((ComboBoxItem)cbxChonNhanVien.SelectedItem).Value;
            string subject = txtTieuDe.Text.Trim();
            string messageBody = txtNoiDung.Text.Trim();

            if (string.IsNullOrWhiteSpace(subject) || subject == placeholderTextBox)
            {
                ShowMessage("Vui lòng nhập tiêu đề email.", false);
                txtTieuDe.Focus();
                return;
            }

            // Kiểm tra nội dung email (bỏ qua nếu là placeholder)
            if (string.IsNullOrWhiteSpace(messageBody) || messageBody == placeholderRichTextBox)
            {
                ShowMessage("Vui lòng nhập nội dung email.", false);
                txtNoiDung.Focus(); 
                return;
            }

            // Gửi email qua controller
            bool isSent = _controller.GuiThongBaoQuaEmail(recipientEmail, subject, messageBody, attachmentPaths);

            if (isSent)
            {
                ShowMessage("Email đã được gửi thành công!", true);
            }
            else
            {
                ShowMessage("Lỗi khi gửi email.", false);
            }
        }

        private void ShowMessage(string message, bool isSuccess)
        {
            lblThongBao.Text = message;
            lblThongBao.ForeColor = isSuccess ? Color.Green : Color.Red;
        }

        private void iconXoa_Click(object sender, EventArgs e)
        {
            if (cbxChonNhanVien.Items.Count > 0)
            {
                cbxChonNhanVien.SelectedIndex = 0;
            }
            else
            {
                cbxChonNhanVien.Text = "";
            }
            txtTieuDe.Clear();
            txtNoiDung.Clear();
            lblThongBao.Text = "";
            attachmentPaths.Clear();
        }

        private void iconGanTep_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true; // Allow multiple files
                openFileDialog.Filter = "All Files (*.*)|*.*"; // Set file filter

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        attachmentPaths.Add(fileName); // Add selected file paths to the list
                    }

                    ShowMessage($"Đã thêm {openFileDialog.FileNames.Length} tệp đính kèm.", true);
                }
            }
        }
        //hàm gợi ý khi nhập vào combobox
        private string previousText = ""; // Chuỗi trước đó để so sánh
        private void cbxChonNhanVien_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                string currentText = cbxChonNhanVien.Text.Trim().ToLower();

                // Nếu không nhập gì hoặc không thay đổi, ẩn gợi ý
                if (string.IsNullOrWhiteSpace(currentText) || currentText == previousText)
                {
                    lstGoiY.Visible = false;
                    return;
                }

                // Lưu chuỗi hiện tại vào previousText
                previousText = currentText;

                // Lọc và hiển thị danh sách gợi ý
                this.BeginInvoke(new Action(() =>
                {
                    FilterComboBoxItems(currentText);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong TextUpdate: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FilterComboBoxItems(string filterText)
        {
            try
            {
                // Truy vấn danh sách nhân viên từ controller
                var danhSachNhanVien = _controller.LayDanhSachNhanVien();

                // Lọc danh sách phù hợp
                var filteredItems = danhSachNhanVien
                    .Where(nv => BoDauTiengViet(nv.HoVaTen.ToLower()).Contains(BoDauTiengViet(filterText)))
                    .Select(nv => new ComboBoxItem(nv.HoVaTen, nv.Email)) // Tạo đối tượng ComboBoxItem
                    .ToList();

                // Cập nhật ListBox với ComboBoxItem
                lstGoiY.Items.Clear();
                foreach (var item in filteredItems)
                {
                    lstGoiY.Items.Add(item); // Thêm ComboBoxItem vào ListBox
                }

                // Hiển thị hoặc ẩn ListBox
                lstGoiY.Visible = filteredItems.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong FilterComboBoxItems: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BoDauTiengViet(string input)
        {
            try
            {
                string[] vietnameseSigns = new string[]
                {
                "aáàảãạâấầẩẫậăắằẳẵặ",
                "eéèẻẽẹêếềểễệ",
                "iíìỉĩị",
                "oóòỏõọôốồổỗộơớờởỡợ",
                "uúùủũụưứừửữự",
                "yýỳỷỹỵ",
                "dđ"
                };

                foreach (var signs in vietnameseSigns)
                {
                    char nonSign = signs[0];
                    foreach (var sign in signs)
                    {
                        input = input.Replace(sign, nonSign);
                    }
                }
                return input.ToLower(); // Chuẩn hóa thành chữ thường
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong BoDauTiengViet: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return input; // Trả lại chuỗi gốc nếu xảy ra lỗi
            }
        }

        private void cbxChonNhanVien_Leave(object sender, EventArgs e)
        {
            lstGoiY.Visible = false;
        }

        private void lstGoiY_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstGoiY.SelectedItem != null && lstGoiY.SelectedItem is ComboBoxItem selectedItem)
                {
                    // Gán ComboBoxItem trực tiếp vào ComboBox
                    cbxChonNhanVien.SelectedItem = selectedItem;

                    // Gán Text hiển thị cho ComboBox
                    cbxChonNhanVien.Text = selectedItem.Text;

                    // Đặt con trỏ ở cuối chuỗi
                    cbxChonNhanVien.SelectionStart = cbxChonNhanVien.Text.Length;
                    cbxChonNhanVien.SelectionLength = 0;

                    // Ẩn ListBox sau khi chọn
                    lstGoiY.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong lstGoiY_SelectedIndexChanged: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
