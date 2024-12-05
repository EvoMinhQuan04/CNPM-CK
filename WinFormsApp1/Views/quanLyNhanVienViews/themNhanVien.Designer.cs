namespace WinFormsApp1
{
    partial class themNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(themNhanVien));
            panel1 = new Panel();
            btnHuy = new Button();
            thongBaoLabel = new Label();
            chucVuComboBox = new ComboBox();
            soDienThoaiTextBox = new TextBox();
            label9 = new Label();
            ngaySinhDateTimePicker = new DateTimePicker();
            label6 = new Label();
            luuThemNV = new Button();
            emailTextBox = new TextBox();
            hoVaTenTextBox = new TextBox();
            maNhanVienTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(thongBaoLabel);
            panel1.Controls.Add(chucVuComboBox);
            panel1.Controls.Add(soDienThoaiTextBox);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(ngaySinhDateTimePicker);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(luuThemNV);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(hoVaTenTextBox);
            panel1.Controls.Add(maNhanVienTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 469);
            panel1.TabIndex = 1;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Gray;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(324, 388);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(76, 38);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // thongBaoLabel
            // 
            thongBaoLabel.AutoSize = true;
            thongBaoLabel.Location = new Point(86, 357);
            thongBaoLabel.Name = "thongBaoLabel";
            thongBaoLabel.Size = new Size(0, 15);
            thongBaoLabel.TabIndex = 13;
            // 
            // chucVuComboBox
            // 
            chucVuComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            chucVuComboBox.Font = new Font("Segoe UI", 10.2F);
            chucVuComboBox.FormattingEnabled = true;
            chucVuComboBox.Items.AddRange(new object[] { "", "Nhân viên" });
            chucVuComboBox.Location = new Point(231, 304);
            chucVuComboBox.Name = "chucVuComboBox";
            chucVuComboBox.Size = new Size(405, 27);
            chucVuComboBox.TabIndex = 12;
            // 
            // soDienThoaiTextBox
            // 
            soDienThoaiTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soDienThoaiTextBox.Location = new Point(231, 205);
            soDienThoaiTextBox.Multiline = true;
            soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            soDienThoaiTextBox.Size = new Size(405, 26);
            soDienThoaiTextBox.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(81, 304);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 11;
            label9.Text = "Chức vụ";
            // 
            // ngaySinhDateTimePicker
            // 
            ngaySinhDateTimePicker.CustomFormat = "dd/MM/yyyy";
            ngaySinhDateTimePicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaySinhDateTimePicker.Format = DateTimePickerFormat.Custom;
            ngaySinhDateTimePicker.Location = new Point(231, 253);
            ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            ngaySinhDateTimePicker.Size = new Size(405, 23);
            ngaySinhDateTimePicker.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(81, 253);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 9;
            label6.Text = "Ngày sinh";
            // 
            // luuThemNV
            // 
            luuThemNV.BackColor = Color.FromArgb(89, 142, 108);
            luuThemNV.Cursor = Cursors.Hand;
            luuThemNV.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            luuThemNV.Location = new Point(448, 388);
            luuThemNV.Name = "luuThemNV";
            luuThemNV.Size = new Size(76, 38);
            luuThemNV.TabIndex = 15;
            luuThemNV.Text = "Lưu";
            luuThemNV.UseVisualStyleBackColor = false;
            luuThemNV.Click += luuThemNV_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(231, 160);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(405, 26);
            emailTextBox.TabIndex = 6;
            // 
            // hoVaTenTextBox
            // 
            hoVaTenTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoVaTenTextBox.Location = new Point(231, 116);
            hoVaTenTextBox.Multiline = true;
            hoVaTenTextBox.Name = "hoVaTenTextBox";
            hoVaTenTextBox.Size = new Size(405, 26);
            hoVaTenTextBox.TabIndex = 4;
            // 
            // maNhanVienTextBox
            // 
            maNhanVienTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maNhanVienTextBox.Location = new Point(231, 72);
            maNhanVienTextBox.Multiline = true;
            maNhanVienTextBox.Name = "maNhanVienTextBox";
            maNhanVienTextBox.Size = new Size(405, 25);
            maNhanVienTextBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(81, 205);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 7;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 161);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 117);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 3;
            label3.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 73);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 18);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "Thông tin cơ bản";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(767, 47);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SeaShell;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(44, 13);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 0;
            label8.Text = "Thêm nhân viên";
            // 
            // themNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 516);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "themNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm nhân viên";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button luuThemNV;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox hoVaTenTextBox;
        private System.Windows.Forms.TextBox maNhanVienTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox soDienThoaiTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox chucVuComboBox;
        private Label thongBaoLabel;
        private Button btnHuy;
    }
}