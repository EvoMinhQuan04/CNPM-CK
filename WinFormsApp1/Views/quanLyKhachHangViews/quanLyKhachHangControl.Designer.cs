namespace WinFormsApp1.Controllers
{
    partial class quanLyKhachHangControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanLyKhachHangControl));
            panelQuanLyKhachHangUC = new Panel();
            panel3 = new Panel();
            dataGridViewKhachHang = new DataGridView();
            MaKhachHang = new DataGridViewTextBoxColumn();
            TenCongTy = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            MaHopDong = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            NguoiDaiDien = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtTenCongTy = new TextBox();
            lblThongBao = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            diaChiTextBox = new TextBox();
            nguoiDaiDienTextBox = new TextBox();
            maHopDongTextBox = new TextBox();
            soDienThoaiTextBox = new TextBox();
            emailTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            maKhachHangTextBox = new TextBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            labelUsername = new Label();
            menuStrip1 = new MenuStrip();
            themToolStripMenuItem = new ToolStripMenuItem();
            btnChinhSua = new ToolStripMenuItem();
            MenuItemLocKhachHang = new ToolStripMenuItem();
            troGiupToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelQuanLyKhachHangUC.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKhachHang).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelQuanLyKhachHangUC
            // 
            panelQuanLyKhachHangUC.Controls.Add(panel3);
            panelQuanLyKhachHangUC.Controls.Add(groupBox1);
            panelQuanLyKhachHangUC.Controls.Add(panel2);
            panelQuanLyKhachHangUC.Dock = DockStyle.Fill;
            panelQuanLyKhachHangUC.Location = new Point(0, 0);
            panelQuanLyKhachHangUC.Name = "panelQuanLyKhachHangUC";
            panelQuanLyKhachHangUC.Size = new Size(1244, 656);
            panelQuanLyKhachHangUC.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewKhachHang);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 232);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1244, 424);
            panel3.TabIndex = 5;
            // 
            // dataGridViewKhachHang
            // 
            dataGridViewKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKhachHang.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewKhachHang.ColumnHeadersHeight = 40;
            dataGridViewKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKhachHang, TenCongTy, Email, DiaChi, MaHopDong, SoDienThoai, NguoiDaiDien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewKhachHang.Dock = DockStyle.Fill;
            dataGridViewKhachHang.GridColor = SystemColors.Menu;
            dataGridViewKhachHang.ImeMode = ImeMode.NoControl;
            dataGridViewKhachHang.Location = new Point(0, 0);
            dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            dataGridViewKhachHang.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewKhachHang.RowHeadersVisible = false;
            dataGridViewKhachHang.RowHeadersWidth = 100;
            dataGridViewKhachHang.RowTemplate.Height = 24;
            dataGridViewKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKhachHang.Size = new Size(1244, 424);
            dataGridViewKhachHang.TabIndex = 0;
            dataGridViewKhachHang.SelectionChanged += dataGridViewKhachHang_SelectionChanged;
            // 
            // MaKhachHang
            // 
            MaKhachHang.HeaderText = "Mã khách hàng";
            MaKhachHang.Name = "MaKhachHang";
            MaKhachHang.ReadOnly = true;
            // 
            // TenCongTy
            // 
            TenCongTy.HeaderText = "Tên công ty";
            TenCongTy.Name = "TenCongTy";
            TenCongTy.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // MaHopDong
            // 
            MaHopDong.HeaderText = "Mã hợp đồng";
            MaHopDong.Name = "MaHopDong";
            MaHopDong.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // NguoiDaiDien
            // 
            NguoiDaiDien.HeaderText = "Người đại diện";
            NguoiDaiDien.Name = "NguoiDaiDien";
            NguoiDaiDien.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(197, 219, 204);
            groupBox1.Controls.Add(txtTenCongTy);
            groupBox1.Controls.Add(lblThongBao);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(diaChiTextBox);
            groupBox1.Controls.Add(nguoiDaiDienTextBox);
            groupBox1.Controls.Add(maHopDongTextBox);
            groupBox1.Controls.Add(soDienThoaiTextBox);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(maKhachHangTextBox);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 59);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1244, 173);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Khách Hàng";
            // 
            // txtTenCongTy
            // 
            txtTenCongTy.Font = new Font("Segoe UI", 11F);
            txtTenCongTy.Location = new Point(146, 68);
            txtTenCongTy.Name = "txtTenCongTy";
            txtTenCongTy.Size = new Size(243, 27);
            txtTenCongTy.TabIndex = 5;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Location = new Point(410, 2);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 20);
            lblThongBao.TabIndex = 1;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Gray;
            btnHuy.Font = new Font("Segoe UI", 11F);
            btnHuy.ForeColor = SystemColors.ControlLightLight;
            btnHuy.Location = new Point(936, 99);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 29);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(89, 142, 108);
            btnLuu.Font = new Font("Segoe UI", 11F);
            btnLuu.ForeColor = SystemColors.ControlLightLight;
            btnLuu.Location = new Point(1039, 99);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(80, 29);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // diaChiTextBox
            // 
            diaChiTextBox.Font = new Font("Segoe UI", 11F);
            diaChiTextBox.Location = new Point(146, 107);
            diaChiTextBox.Margin = new Padding(3, 2, 3, 2);
            diaChiTextBox.Name = "diaChiTextBox";
            diaChiTextBox.Size = new Size(243, 27);
            diaChiTextBox.TabIndex = 7;
            // 
            // nguoiDaiDienTextBox
            // 
            nguoiDaiDienTextBox.Font = new Font("Segoe UI", 11F);
            nguoiDaiDienTextBox.Location = new Point(551, 35);
            nguoiDaiDienTextBox.Margin = new Padding(3, 2, 3, 2);
            nguoiDaiDienTextBox.Name = "nguoiDaiDienTextBox";
            nguoiDaiDienTextBox.Size = new Size(243, 27);
            nguoiDaiDienTextBox.TabIndex = 9;
            // 
            // maHopDongTextBox
            // 
            maHopDongTextBox.Font = new Font("Segoe UI", 11F);
            maHopDongTextBox.Location = new Point(551, 75);
            maHopDongTextBox.Margin = new Padding(3, 2, 3, 2);
            maHopDongTextBox.Name = "maHopDongTextBox";
            maHopDongTextBox.Size = new Size(243, 27);
            maHopDongTextBox.TabIndex = 11;
            // 
            // soDienThoaiTextBox
            // 
            soDienThoaiTextBox.Font = new Font("Segoe UI", 11F);
            soDienThoaiTextBox.Location = new Point(551, 109);
            soDienThoaiTextBox.Margin = new Padding(3, 2, 3, 2);
            soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            soDienThoaiTextBox.Size = new Size(243, 27);
            soDienThoaiTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 11F);
            emailTextBox.Location = new Point(895, 34);
            emailTextBox.Margin = new Padding(3, 2, 3, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(243, 27);
            emailTextBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(833, 36);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(420, 110);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 12;
            label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(420, 71);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 10;
            label5.Text = "Mã hợp đồng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(420, 33);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 8;
            label4.Text = "Người đại diện";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(18, 105);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên công ty";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 2;
            label1.Text = "Mã khách hàng";
            // 
            // maKhachHangTextBox
            // 
            maKhachHangTextBox.Font = new Font("Segoe UI", 11F);
            maKhachHangTextBox.Location = new Point(146, 32);
            maKhachHangTextBox.Margin = new Padding(3, 2, 3, 2);
            maKhachHangTextBox.Name = "maKhachHangTextBox";
            maKhachHangTextBox.Size = new Size(243, 27);
            maKhachHangTextBox.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(labelUsername);
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1244, 59);
            panel2.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox4.Image = Properties.Resources.avatar;
            pictureBox4.Location = new Point(1086, 1);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.SeaShell;
            labelUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelUsername.ForeColor = Color.FromArgb(89, 142, 108);
            labelUsername.Location = new Point(877, 22);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(21, 21);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "A";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.SeaShell;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { themToolStripMenuItem, btnChinhSua, MenuItemLocKhachHang, troGiupToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(375, 57);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // themToolStripMenuItem
            // 
            themToolStripMenuItem.Font = new Font("Segoe UI", 10.2F);
            themToolStripMenuItem.Image = Properties.Resources.more;
            themToolStripMenuItem.Name = "themToolStripMenuItem";
            themToolStripMenuItem.Size = new Size(75, 53);
            themToolStripMenuItem.Text = "Thêm";
            themToolStripMenuItem.Click += themToolStripMenuItem_Click;
            // 
            // btnChinhSua
            // 
            btnChinhSua.Font = new Font("Segoe UI", 10.2F);
            btnChinhSua.Image = Properties.Resources.edit;
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(63, 53);
            btnChinhSua.Text = "Sửa";
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // MenuItemLocKhachHang
            // 
            MenuItemLocKhachHang.Font = new Font("Segoe UI", 10.2F);
            MenuItemLocKhachHang.Image = Properties.Resources.slider;
            MenuItemLocKhachHang.Name = "MenuItemLocKhachHang";
            MenuItemLocKhachHang.Size = new Size(62, 53);
            MenuItemLocKhachHang.Text = "Lọc";
            MenuItemLocKhachHang.Click += MenuItemLocKhachHang_Click;
            // 
            // troGiupToolStripMenuItem
            // 
            troGiupToolStripMenuItem.Font = new Font("Segoe UI", 10.2F);
            troGiupToolStripMenuItem.Image = (Image)resources.GetObject("troGiupToolStripMenuItem.Image");
            troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            troGiupToolStripMenuItem.Size = new Size(147, 53);
            troGiupToolStripMenuItem.Text = "Liên hệ và Hỗ trợ";
            troGiupToolStripMenuItem.Click += troGiupToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // quanLyKhachHangControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelQuanLyKhachHangUC);
            Name = "quanLyKhachHangControl";
            Size = new Size(1244, 656);
            panelQuanLyKhachHangUC.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelQuanLyKhachHangUC;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Label labelUsername;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themToolStripMenuItem;
        private ToolStripMenuItem btnChinhSua;
        private ToolStripMenuItem MenuItemLocKhachHang;
        private ToolStripMenuItem troGiupToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnHuy;
        private Button btnLuu;
        private TextBox diaChiTextBox;
        private TextBox nguoiDaiDienTextBox;
        private TextBox maHopDongTextBox;
        private TextBox soDienThoaiTextBox;
        private TextBox emailTextBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox maKhachHangTextBox;
        private Panel panel3;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblThongBao;
        private TextBox txtTenCongTy;
        public DataGridView dataGridViewKhachHang;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn TenCongTy;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn MaHopDong;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn NguoiDaiDien;
    }
}
