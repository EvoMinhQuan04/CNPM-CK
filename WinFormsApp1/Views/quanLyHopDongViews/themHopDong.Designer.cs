namespace WinFormsApp1
{
    partial class themHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(themHopDong));
            panel1 = new Panel();
            thongBaoLoi = new Label();
            huy = new Button();
            btnThem = new Button();
            trangThai = new ComboBox();
            ngayTra = new DateTimePicker();
            quy = new ComboBox();
            ngayLap = new DateTimePicker();
            maNhanVien = new TextBox();
            maKhachHang = new TextBox();
            viecCanLam = new TextBox();
            maHopDong = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(thongBaoLoi);
            panel1.Controls.Add(huy);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(trangThai);
            panel1.Controls.Add(ngayTra);
            panel1.Controls.Add(quy);
            panel1.Controls.Add(ngayLap);
            panel1.Controls.Add(maNhanVien);
            panel1.Controls.Add(maKhachHang);
            panel1.Controls.Add(viecCanLam);
            panel1.Controls.Add(maHopDong);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 418);
            panel1.TabIndex = 0;
            // 
            // thongBaoLoi
            // 
            thongBaoLoi.AutoSize = true;
            thongBaoLoi.ForeColor = Color.Linen;
            thongBaoLoi.Location = new Point(85, 347);
            thongBaoLoi.Name = "thongBaoLoi";
            thongBaoLoi.Size = new Size(0, 15);
            thongBaoLoi.TabIndex = 17;
            // 
            // huy
            // 
            huy.BackColor = Color.Gray;
            huy.Font = new Font("Segoe UI", 10.2F);
            huy.ForeColor = SystemColors.ControlLightLight;
            huy.Location = new Point(404, 360);
            huy.Margin = new Padding(3, 2, 3, 2);
            huy.Name = "huy";
            huy.Size = new Size(76, 38);
            huy.TabIndex = 18;
            huy.Text = "Hủy";
            huy.UseVisualStyleBackColor = false;
            huy.Click += huy_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(89, 142, 108);
            btnThem.Font = new Font("Segoe UI", 10.2F);
            btnThem.ForeColor = SystemColors.ControlLightLight;
            btnThem.Location = new Point(494, 360);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(76, 38);
            btnThem.TabIndex = 19;
            btnThem.Text = "Lưu";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // trangThai
            // 
            trangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            trangThai.FormattingEnabled = true;
            trangThai.Items.AddRange(new object[] { "Đã hoàn thành", "Đang hoạt động" });
            trangThai.Location = new Point(235, 306);
            trangThai.Margin = new Padding(3, 2, 3, 2);
            trangThai.Name = "trangThai";
            trangThai.Size = new Size(336, 23);
            trangThai.TabIndex = 16;
            // 
            // ngayTra
            // 
            ngayTra.CustomFormat = "dd/MM/yyyy";
            ngayTra.Format = DateTimePickerFormat.Custom;
            ngayTra.Location = new Point(235, 233);
            ngayTra.Margin = new Padding(3, 2, 3, 2);
            ngayTra.Name = "ngayTra";
            ngayTra.Size = new Size(336, 23);
            ngayTra.TabIndex = 12;
            // 
            // quy
            // 
            quy.DropDownStyle = ComboBoxStyle.DropDownList;
            quy.FormattingEnabled = true;
            quy.Items.AddRange(new object[] { "1", "2", "3", "4" });
            quy.Location = new Point(235, 163);
            quy.Margin = new Padding(3, 2, 3, 2);
            quy.Name = "quy";
            quy.Size = new Size(336, 23);
            quy.TabIndex = 8;
            // 
            // ngayLap
            // 
            ngayLap.CustomFormat = "dd/MM/yyyy";
            ngayLap.Format = DateTimePickerFormat.Custom;
            ngayLap.Location = new Point(235, 197);
            ngayLap.Margin = new Padding(3, 2, 3, 2);
            ngayLap.Name = "ngayLap";
            ngayLap.Size = new Size(336, 23);
            ngayLap.TabIndex = 10;
            // 
            // maNhanVien
            // 
            maNhanVien.Location = new Point(235, 128);
            maNhanVien.Margin = new Padding(3, 2, 3, 2);
            maNhanVien.Name = "maNhanVien";
            maNhanVien.Size = new Size(336, 23);
            maNhanVien.TabIndex = 6;
            // 
            // maKhachHang
            // 
            maKhachHang.Location = new Point(235, 93);
            maKhachHang.Margin = new Padding(3, 2, 3, 2);
            maKhachHang.Name = "maKhachHang";
            maKhachHang.Size = new Size(336, 23);
            maKhachHang.TabIndex = 4;
            // 
            // viecCanLam
            // 
            viecCanLam.Location = new Point(235, 269);
            viecCanLam.Margin = new Padding(3, 2, 3, 2);
            viecCanLam.Name = "viecCanLam";
            viecCanLam.Size = new Size(336, 23);
            viecCanLam.TabIndex = 14;
            // 
            // maHopDong
            // 
            maHopDong.Location = new Point(235, 56);
            maHopDong.Margin = new Padding(3, 2, 3, 2);
            maHopDong.Name = "maHopDong";
            maHopDong.Size = new Size(336, 23);
            maHopDong.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(85, 268);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 13;
            label9.Text = "Việc cần làm*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(85, 128);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 5;
            label8.Text = "Mã nhân viên*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(85, 305);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 15;
            label7.Text = "Trạng thái*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(85, 233);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "Ngày trả*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 162);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 7;
            label5.Text = "Quý*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 197);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 9;
            label4.Text = "Ngày lập*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 92);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã khách hàng*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 56);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã hợp đồng*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 10);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "Thông tin hợp đồng";
            // 
            // themHopDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 418);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "themHopDong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Hợp Đồng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox maHopDong;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox maNhanVien;
        private TextBox maKhachHang;
        private TextBox viecCanLam;
        private ComboBox quy;
        private DateTimePicker ngayLap;
        private DateTimePicker ngayTra;
        private Button btnThem;
        private ComboBox trangThai;
        private Button huy;
        private Label thongBaoLoi;
    }
}