namespace WinFormsApp1.Views.quanLyHopDongViews
{
    partial class quanLyHopDongControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanLyHopDongControl));
            panelQuanLyHopDongUC = new Panel();
            panelBody = new Panel();
            panel1 = new Panel();
            dataGridViewHopDong = new DataGridView();
            maHopDong = new DataGridViewTextBoxColumn();
            maKhachHang = new DataGridViewTextBoxColumn();
            maNhanVien = new DataGridViewTextBoxColumn();
            quy = new DataGridViewTextBoxColumn();
            ngayLap = new DataGridViewTextBoxColumn();
            ngayTra = new DataGridViewTextBoxColumn();
            viecCanLam = new DataGridViewTextBoxColumn();
            trangThai = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            lblThongBao = new Label();
            btnHuy = new Button();
            trangThaiTextBox = new TextBox();
            viecCanLamTextBox = new TextBox();
            ngayTraDateTimePicker = new DateTimePicker();
            ngayLapDateTimePicker = new DateTimePicker();
            quyTextBox = new ComboBox();
            maNhanVienTextBox = new TextBox();
            maKhachHangTextBox = new TextBox();
            maHopDongTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLuu = new Button();
            panelTop = new Panel();
            pictureBox3 = new PictureBox();
            labelUsername = new Label();
            menuStrip = new MenuStrip();
            menuItemHienThi = new ToolStripMenuItem();
            danhSachTreHan = new ToolStripMenuItem();
            menuItemThem = new ToolStripMenuItem();
            btnChinhSua = new ToolStripMenuItem();
            menuItemLoc = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            panelQuanLyHopDongUC.SuspendLayout();
            panelBody.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHopDong).BeginInit();
            groupBox1.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panelQuanLyHopDongUC
            // 
            panelQuanLyHopDongUC.Controls.Add(panelBody);
            panelQuanLyHopDongUC.Controls.Add(panelTop);
            panelQuanLyHopDongUC.Dock = DockStyle.Fill;
            panelQuanLyHopDongUC.Location = new Point(0, 0);
            panelQuanLyHopDongUC.Name = "panelQuanLyHopDongUC";
            panelQuanLyHopDongUC.Size = new Size(1246, 636);
            panelQuanLyHopDongUC.TabIndex = 0;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.Snow;
            panelBody.Controls.Add(panel1);
            panelBody.Controls.Add(groupBox1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 59);
            panelBody.Margin = new Padding(3, 2, 3, 2);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1246, 577);
            panelBody.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(dataGridViewHopDong);
            panel1.Location = new Point(0, 173);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1246, 404);
            panel1.TabIndex = 1;
            // 
            // dataGridViewHopDong
            // 
            dataGridViewHopDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHopDong.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHopDong.ColumnHeadersHeight = 40;
            dataGridViewHopDong.Columns.AddRange(new DataGridViewColumn[] { maHopDong, maKhachHang, maNhanVien, quy, ngayLap, ngayTra, viecCanLam, trangThai });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewHopDong.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewHopDong.Dock = DockStyle.Fill;
            dataGridViewHopDong.GridColor = SystemColors.Menu;
            dataGridViewHopDong.ImeMode = ImeMode.NoControl;
            dataGridViewHopDong.Location = new Point(0, 0);
            dataGridViewHopDong.Name = "dataGridViewHopDong";
            dataGridViewHopDong.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewHopDong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHopDong.RowHeadersVisible = false;
            dataGridViewHopDong.RowHeadersWidth = 100;
            dataGridViewHopDong.RowTemplate.Height = 24;
            dataGridViewHopDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHopDong.Size = new Size(1246, 404);
            dataGridViewHopDong.TabIndex = 0;
            dataGridViewHopDong.SelectionChanged += dataGridViewHopDong_SelectionChanged;
            // 
            // maHopDong
            // 
            maHopDong.FillWeight = 63.46838F;
            maHopDong.HeaderText = "Mã hợp đồng";
            maHopDong.MinimumWidth = 150;
            maHopDong.Name = "maHopDong";
            maHopDong.ReadOnly = true;
            // 
            // maKhachHang
            // 
            maKhachHang.FillWeight = 63.9593849F;
            maKhachHang.HeaderText = "Mã khách hàng";
            maKhachHang.MinimumWidth = 150;
            maKhachHang.Name = "maKhachHang";
            maKhachHang.ReadOnly = true;
            // 
            // maNhanVien
            // 
            maNhanVien.FillWeight = 56.6801758F;
            maNhanVien.HeaderText = "Mã nhân viên";
            maNhanVien.MinimumWidth = 150;
            maNhanVien.Name = "maNhanVien";
            maNhanVien.ReadOnly = true;
            // 
            // quy
            // 
            quy.FillWeight = 48.18161F;
            quy.HeaderText = "Qúy";
            quy.MinimumWidth = 50;
            quy.Name = "quy";
            quy.ReadOnly = true;
            // 
            // ngayLap
            // 
            ngayLap.FillWeight = 25.0626545F;
            ngayLap.HeaderText = "Ngày lập";
            ngayLap.MinimumWidth = 100;
            ngayLap.Name = "ngayLap";
            ngayLap.ReadOnly = true;
            // 
            // ngayTra
            // 
            ngayTra.FillWeight = 23.3391056F;
            ngayTra.HeaderText = "Ngày trả";
            ngayTra.MinimumWidth = 100;
            ngayTra.Name = "ngayTra";
            ngayTra.ReadOnly = true;
            // 
            // viecCanLam
            // 
            viecCanLam.FillWeight = 496.3178F;
            viecCanLam.HeaderText = "Việc cần làm";
            viecCanLam.MinimumWidth = 250;
            viecCanLam.Name = "viecCanLam";
            viecCanLam.ReadOnly = true;
            // 
            // trangThai
            // 
            trangThai.FillWeight = 62.9908371F;
            trangThai.HeaderText = "Trạng thái";
            trangThai.MinimumWidth = 120;
            trangThai.Name = "trangThai";
            trangThai.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(197, 219, 204);
            groupBox1.Controls.Add(lblThongBao);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(trangThaiTextBox);
            groupBox1.Controls.Add(viecCanLamTextBox);
            groupBox1.Controls.Add(ngayTraDateTimePicker);
            groupBox1.Controls.Add(ngayLapDateTimePicker);
            groupBox1.Controls.Add(quyTextBox);
            groupBox1.Controls.Add(maNhanVienTextBox);
            groupBox1.Controls.Add(maKhachHangTextBox);
            groupBox1.Controls.Add(maHopDongTextBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1246, 173);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hợp đồng";
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Location = new Point(411, 7);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 20);
            lblThongBao.TabIndex = 0;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Gray;
            btnHuy.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = SystemColors.ControlLightLight;
            btnHuy.Location = new Point(971, 134);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(72, 29);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // trangThaiTextBox
            // 
            trangThaiTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trangThaiTextBox.Location = new Point(891, 84);
            trangThaiTextBox.Margin = new Padding(3, 2, 3, 2);
            trangThaiTextBox.Name = "trangThaiTextBox";
            trangThaiTextBox.Size = new Size(268, 27);
            trangThaiTextBox.TabIndex = 16;
            // 
            // viecCanLamTextBox
            // 
            viecCanLamTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viecCanLamTextBox.Location = new Point(891, 38);
            viecCanLamTextBox.Margin = new Padding(3, 2, 3, 2);
            viecCanLamTextBox.Name = "viecCanLamTextBox";
            viecCanLamTextBox.Size = new Size(268, 27);
            viecCanLamTextBox.TabIndex = 14;
            // 
            // ngayTraDateTimePicker
            // 
            ngayTraDateTimePicker.CustomFormat = "dd/MM/yyyy";
            ngayTraDateTimePicker.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayTraDateTimePicker.Format = DateTimePickerFormat.Custom;
            ngayTraDateTimePicker.Location = new Point(501, 122);
            ngayTraDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            ngayTraDateTimePicker.Name = "ngayTraDateTimePicker";
            ngayTraDateTimePicker.Size = new Size(240, 27);
            ngayTraDateTimePicker.TabIndex = 12;
            // 
            // ngayLapDateTimePicker
            // 
            ngayLapDateTimePicker.CustomFormat = "dd/MM/yyyy";
            ngayLapDateTimePicker.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayLapDateTimePicker.Format = DateTimePickerFormat.Custom;
            ngayLapDateTimePicker.Location = new Point(501, 82);
            ngayLapDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            ngayLapDateTimePicker.Name = "ngayLapDateTimePicker";
            ngayLapDateTimePicker.Size = new Size(240, 27);
            ngayLapDateTimePicker.TabIndex = 10;
            // 
            // quyTextBox
            // 
            quyTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quyTextBox.FormattingEnabled = true;
            quyTextBox.Items.AddRange(new object[] { "1", "2", "3", "4" });
            quyTextBox.Location = new Point(501, 38);
            quyTextBox.Margin = new Padding(3, 2, 3, 2);
            quyTextBox.Name = "quyTextBox";
            quyTextBox.Size = new Size(240, 28);
            quyTextBox.TabIndex = 8;
            // 
            // maNhanVienTextBox
            // 
            maNhanVienTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maNhanVienTextBox.Location = new Point(136, 124);
            maNhanVienTextBox.Margin = new Padding(3, 2, 3, 2);
            maNhanVienTextBox.Name = "maNhanVienTextBox";
            maNhanVienTextBox.Size = new Size(240, 27);
            maNhanVienTextBox.TabIndex = 6;
            // 
            // maKhachHangTextBox
            // 
            maKhachHangTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maKhachHangTextBox.Location = new Point(136, 81);
            maKhachHangTextBox.Margin = new Padding(3, 2, 3, 2);
            maKhachHangTextBox.Name = "maKhachHangTextBox";
            maKhachHangTextBox.Size = new Size(240, 27);
            maKhachHangTextBox.TabIndex = 4;
            // 
            // maHopDongTextBox
            // 
            maHopDongTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maHopDongTextBox.Location = new Point(136, 39);
            maHopDongTextBox.Margin = new Padding(3, 2, 3, 2);
            maHopDongTextBox.Name = "maHopDongTextBox";
            maHopDongTextBox.Size = new Size(240, 27);
            maHopDongTextBox.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(785, 40);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 13;
            label8.Text = "Việc cần làm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(414, 81);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 9;
            label7.Text = "Ngày lập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(414, 123);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 11;
            label6.Text = "Ngày trả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(788, 86);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 15;
            label5.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(414, 38);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 7;
            label4.Text = "Quý";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(14, 80);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(16, 124);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(14, 39);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã hợp đồng";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(89, 142, 108);
            btnLuu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = SystemColors.ControlLightLight;
            btnLuu.Location = new Point(1056, 134);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 29);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.SeaShell;
            panelTop.Controls.Add(pictureBox3);
            panelTop.Controls.Add(labelUsername);
            panelTop.Controls.Add(menuStrip);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1246, 59);
            panelTop.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.avatar;
            pictureBox3.Location = new Point(1087, 1);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelUsername.ForeColor = Color.FromArgb(89, 142, 108);
            labelUsername.Location = new Point(874, 22);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(21, 21);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "A";
            // 
            // menuStrip
            // 
            menuStrip.AutoSize = false;
            menuStrip.BackColor = Color.SeaShell;
            menuStrip.Dock = DockStyle.None;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuItemHienThi, menuItemThem, btnChinhSua, menuItemLoc, toolStripMenuItem3 });
            menuStrip.Location = new Point(0, 2);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(449, 55);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // menuItemHienThi
            // 
            menuItemHienThi.DropDownItems.AddRange(new ToolStripItem[] { danhSachTreHan });
            menuItemHienThi.Font = new Font("Segoe UI", 10.2F);
            menuItemHienThi.Image = Properties.Resources.view_details;
            menuItemHienThi.Name = "menuItemHienThi";
            menuItemHienThi.Size = new Size(89, 51);
            menuItemHienThi.Text = "Hiển thị";
            // 
            // danhSachTreHan
            // 
            danhSachTreHan.Name = "danhSachTreHan";
            danhSachTreHan.Size = new Size(254, 24);
            danhSachTreHan.Text = "Danh sách hợp đồng trễ hạn";
            danhSachTreHan.Click += danhSachTreHan_Click;
            // 
            // menuItemThem
            // 
            menuItemThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuItemThem.Image = Properties.Resources.more;
            menuItemThem.Name = "menuItemThem";
            menuItemThem.Size = new Size(75, 51);
            menuItemThem.Text = "Thêm";
            menuItemThem.Click += menuItemThem_Click;
            // 
            // btnChinhSua
            // 
            btnChinhSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChinhSua.Image = Properties.Resources.edit;
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(63, 51);
            btnChinhSua.Text = "Sửa";
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // menuItemLoc
            // 
            menuItemLoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuItemLoc.Image = Properties.Resources.slider;
            menuItemLoc.Name = "menuItemLoc";
            menuItemLoc.Size = new Size(62, 51);
            menuItemLoc.Text = "Lọc";
            menuItemLoc.Click += menuItemLoc_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = (Image)resources.GetObject("toolStripMenuItem3.Image");
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(129, 51);
            toolStripMenuItem3.Text = "Liên hệ và Hỗ trợ";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // quanLyHopDongControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelQuanLyHopDongUC);
            Name = "quanLyHopDongControl";
            Size = new Size(1246, 636);
            panelQuanLyHopDongUC.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHopDong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelQuanLyHopDongUC;
        private Panel panelTop;
        private PictureBox pictureBox3;
        private Label labelUsername;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuItemHienThi;
        private ToolStripMenuItem danhSachTreHan;
        private ToolStripMenuItem menuItemThem;
        private ToolStripMenuItem btnChinhSua;
        private ToolStripMenuItem menuItemLoc;
        private Panel panelBody;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnHuy;
        private TextBox trangThaiTextBox;
        private TextBox viecCanLamTextBox;
        private DateTimePicker ngayTraDateTimePicker;
        private DateTimePicker ngayLapDateTimePicker;
        private ComboBox quyTextBox;
        private TextBox maNhanVienTextBox;
        private TextBox maKhachHangTextBox;
        private TextBox maHopDongTextBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLuu;
        private ToolStripMenuItem toolStripMenuItem3;
        private Label lblThongBao;
        public DataGridView dataGridViewHopDong;
        private DataGridViewTextBoxColumn maHopDong;
        private DataGridViewTextBoxColumn maKhachHang;
        private DataGridViewTextBoxColumn maNhanVien;
        private DataGridViewTextBoxColumn quy;
        private DataGridViewTextBoxColumn ngayLap;
        private DataGridViewTextBoxColumn ngayTra;
        private DataGridViewTextBoxColumn viecCanLam;
        private DataGridViewTextBoxColumn trangThai;
    }
}
