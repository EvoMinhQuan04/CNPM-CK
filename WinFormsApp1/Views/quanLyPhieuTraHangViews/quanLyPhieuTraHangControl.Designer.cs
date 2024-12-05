namespace WinFormsApp1.Views.quanLyPhieuTraHangViews
{
    partial class quanLyPhieuTraHangControl
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanLyPhieuTraHangControl));
            panel1 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            dataGridViewPhieuKetQua = new DataGridView();
            MaMau = new DataGridViewTextBoxColumn();
            MaHopDong = new DataGridViewTextBoxColumn();
            NgayLayMau = new DataGridViewTextBoxColumn();
            NgayTraKetQua = new DataGridViewTextBoxColumn();
            TrangThaiKetQuaPhanTich = new DataGridViewTextBoxColumn();
            TrangThaiXuLy = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            dataGridViewChiTietThongSo = new DataGridView();
            ThongSo = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            PhuongPhapPhanTich = new DataGridViewTextBoxColumn();
            KetQuaPTN = new DataGridViewTextBoxColumn();
            KetQuaHT = new DataGridViewTextBoxColumn();
            QuyChuanSoSanh = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            button2 = new Button();
            btnCapNhat = new Button();
            txtNoiDungKetQuaPhanTichHT = new TextBox();
            label12 = new Label();
            txtQuyChuanVietNam = new TextBox();
            label3 = new Label();
            btnXacNhan = new Button();
            txtNoiDungKetQuaPhanTichPTN = new TextBox();
            label11 = new Label();
            txtPhuongPhapPhanTich = new TextBox();
            label10 = new Label();
            cmbDonVi = new ComboBox();
            label9 = new Label();
            cmbThongSo = new ComboBox();
            label2 = new Label();
            txtTrangThai = new TextBox();
            txtKetQuaPhanTich = new TextBox();
            txtNgayTraKetQua = new TextBox();
            txtNgayLayMau = new TextBox();
            txtMaHopDong = new TextBox();
            txtMaMau = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblUserName = new Label();
            menuStrip1 = new MenuStrip();
            xuatPhieuMenuItem = new ToolStripMenuItem();
            btnChinhSua = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            lblThongBao = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhieuKetQua).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChiTietThongSo).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 696);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(groupBox2);
            panel3.Location = new Point(0, 57);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1205, 639);
            panel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewPhieuKetQua);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(0, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1205, 257);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu kết quả";
            // 
            // dataGridViewPhieuKetQua
            // 
            dataGridViewPhieuKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPhieuKetQua.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPhieuKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPhieuKetQua.ColumnHeadersHeight = 40;
            dataGridViewPhieuKetQua.Columns.AddRange(new DataGridViewColumn[] { MaMau, MaHopDong, NgayLayMau, NgayTraKetQua, TrangThaiKetQuaPhanTich, TrangThaiXuLy });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPhieuKetQua.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPhieuKetQua.Dock = DockStyle.Fill;
            dataGridViewPhieuKetQua.GridColor = SystemColors.Menu;
            dataGridViewPhieuKetQua.ImeMode = ImeMode.NoControl;
            dataGridViewPhieuKetQua.Location = new Point(3, 25);
            dataGridViewPhieuKetQua.Name = "dataGridViewPhieuKetQua";
            dataGridViewPhieuKetQua.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPhieuKetQua.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPhieuKetQua.RowHeadersVisible = false;
            dataGridViewPhieuKetQua.RowHeadersWidth = 100;
            dataGridViewPhieuKetQua.RowTemplate.Height = 24;
            dataGridViewPhieuKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPhieuKetQua.Size = new Size(1199, 229);
            dataGridViewPhieuKetQua.TabIndex = 0;
            dataGridViewPhieuKetQua.SelectionChanged += dataGridViewPhieuKetQua_SelectionChanged;
            // 
            // MaMau
            // 
            MaMau.FillWeight = 304.568542F;
            MaMau.HeaderText = "Mã mẫu";
            MaMau.MinimumWidth = 150;
            MaMau.Name = "MaMau";
            MaMau.ReadOnly = true;
            // 
            // MaHopDong
            // 
            MaHopDong.FillWeight = 7.693529F;
            MaHopDong.HeaderText = "Mã hợp đồng";
            MaHopDong.MinimumWidth = 150;
            MaHopDong.Name = "MaHopDong";
            MaHopDong.ReadOnly = true;
            // 
            // NgayLayMau
            // 
            NgayLayMau.FillWeight = 7.693529F;
            NgayLayMau.HeaderText = "Ngày lấy mẫu";
            NgayLayMau.MinimumWidth = 150;
            NgayLayMau.Name = "NgayLayMau";
            NgayLayMau.ReadOnly = true;
            // 
            // NgayTraKetQua
            // 
            NgayTraKetQua.FillWeight = 7.693529F;
            NgayTraKetQua.HeaderText = "Ngày trả kết quả";
            NgayTraKetQua.MinimumWidth = 150;
            NgayTraKetQua.Name = "NgayTraKetQua";
            NgayTraKetQua.ReadOnly = true;
            // 
            // TrangThaiKetQuaPhanTich
            // 
            TrangThaiKetQuaPhanTich.FillWeight = 264.657349F;
            TrangThaiKetQuaPhanTich.HeaderText = "Trạng thái kết quả phân tích";
            TrangThaiKetQuaPhanTich.MinimumWidth = 400;
            TrangThaiKetQuaPhanTich.Name = "TrangThaiKetQuaPhanTich";
            TrangThaiKetQuaPhanTich.ReadOnly = true;
            // 
            // TrangThaiXuLy
            // 
            TrangThaiXuLy.FillWeight = 7.693529F;
            TrangThaiXuLy.HeaderText = "Trạng thái xử lý";
            TrangThaiXuLy.MinimumWidth = 200;
            TrangThaiXuLy.Name = "TrangThaiXuLy";
            TrangThaiXuLy.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewChiTietThongSo);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(0, 432);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1205, 207);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết thông số phiếu trả hàng";
            // 
            // dataGridViewChiTietThongSo
            // 
            dataGridViewChiTietThongSo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewChiTietThongSo.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewChiTietThongSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewChiTietThongSo.ColumnHeadersHeight = 40;
            dataGridViewChiTietThongSo.Columns.AddRange(new DataGridViewColumn[] { ThongSo, DonVi, PhuongPhapPhanTich, KetQuaPTN, KetQuaHT, QuyChuanSoSanh });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewChiTietThongSo.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewChiTietThongSo.Dock = DockStyle.Fill;
            dataGridViewChiTietThongSo.GridColor = SystemColors.Menu;
            dataGridViewChiTietThongSo.ImeMode = ImeMode.NoControl;
            dataGridViewChiTietThongSo.Location = new Point(3, 25);
            dataGridViewChiTietThongSo.Name = "dataGridViewChiTietThongSo";
            dataGridViewChiTietThongSo.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewChiTietThongSo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewChiTietThongSo.RowHeadersVisible = false;
            dataGridViewChiTietThongSo.RowHeadersWidth = 100;
            dataGridViewChiTietThongSo.RowTemplate.Height = 24;
            dataGridViewChiTietThongSo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewChiTietThongSo.Size = new Size(1199, 179);
            dataGridViewChiTietThongSo.TabIndex = 0;
            dataGridViewChiTietThongSo.SelectionChanged += dataGridViewChiTietThongSo_SelectionChanged;
            // 
            // ThongSo
            // 
            ThongSo.FillWeight = 304.568542F;
            ThongSo.HeaderText = "Thông số";
            ThongSo.MinimumWidth = 100;
            ThongSo.Name = "ThongSo";
            ThongSo.ReadOnly = true;
            // 
            // DonVi
            // 
            DonVi.FillWeight = 59.0862923F;
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 100;
            DonVi.Name = "DonVi";
            DonVi.ReadOnly = true;
            // 
            // PhuongPhapPhanTich
            // 
            PhuongPhapPhanTich.FillWeight = 59.0862923F;
            PhuongPhapPhanTich.HeaderText = "Phương pháp phân tích";
            PhuongPhapPhanTich.MinimumWidth = 200;
            PhuongPhapPhanTich.Name = "PhuongPhapPhanTich";
            PhuongPhapPhanTich.ReadOnly = true;
            // 
            // KetQuaPTN
            // 
            KetQuaPTN.FillWeight = 59.0862923F;
            KetQuaPTN.HeaderText = "Kết quả Phòng thí nghiệm (PTN)";
            KetQuaPTN.MinimumWidth = 270;
            KetQuaPTN.Name = "KetQuaPTN";
            KetQuaPTN.ReadOnly = true;
            // 
            // KetQuaHT
            // 
            KetQuaHT.FillWeight = 59.0862923F;
            KetQuaHT.HeaderText = "Kết quả Hiện trường (HT)";
            KetQuaHT.MinimumWidth = 250;
            KetQuaHT.Name = "KetQuaHT";
            KetQuaHT.ReadOnly = true;
            // 
            // QuyChuanSoSanh
            // 
            QuyChuanSoSanh.FillWeight = 59.0862923F;
            QuyChuanSoSanh.HeaderText = "Quy chuẩn so sánh";
            QuyChuanSoSanh.MinimumWidth = 230;
            QuyChuanSoSanh.Name = "QuyChuanSoSanh";
            QuyChuanSoSanh.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(197, 219, 204);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(btnCapNhat);
            groupBox2.Controls.Add(txtNoiDungKetQuaPhanTichHT);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtQuyChuanVietNam);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnXacNhan);
            groupBox2.Controls.Add(txtNoiDungKetQuaPhanTichPTN);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtPhuongPhapPhanTich);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cmbDonVi);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmbThongSo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtTrangThai);
            groupBox2.Controls.Add(txtKetQuaPhanTich);
            groupBox2.Controls.Add(txtNgayTraKetQua);
            groupBox2.Controls.Add(txtNgayLayMau);
            groupBox2.Controls.Add(txtMaHopDong);
            groupBox2.Controls.Add(txtMaMau);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1205, 175);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết thông số";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(89, 142, 108);
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(1097, 15);
            button2.Name = "button2";
            button2.Size = new Size(102, 42);
            button2.TabIndex = 26;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(89, 142, 108);
            btnCapNhat.Font = new Font("Segoe UI", 12F);
            btnCapNhat.Location = new Point(1097, 68);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(102, 42);
            btnCapNhat.TabIndex = 25;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtNoiDungKetQuaPhanTichHT
            // 
            txtNoiDungKetQuaPhanTichHT.Font = new Font("Segoe UI", 12F);
            txtNoiDungKetQuaPhanTichHT.Location = new Point(609, 131);
            txtNoiDungKetQuaPhanTichHT.Name = "txtNoiDungKetQuaPhanTichHT";
            txtNoiDungKetQuaPhanTichHT.Size = new Size(115, 29);
            txtNoiDungKetQuaPhanTichHT.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(444, 136);
            label12.Name = "label12";
            label12.Size = new Size(153, 21);
            label12.TabIndex = 14;
            label12.Text = "Kết quả phân tích HT";
            // 
            // txtQuyChuanVietNam
            // 
            txtQuyChuanVietNam.Font = new Font("Segoe UI", 12F);
            txtQuyChuanVietNam.Location = new Point(889, 134);
            txtQuyChuanVietNam.Name = "txtQuyChuanVietNam";
            txtQuyChuanVietNam.Size = new Size(199, 29);
            txtQuyChuanVietNam.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(741, 136);
            label3.Name = "label3";
            label3.Size = new Size(142, 21);
            label3.TabIndex = 22;
            label3.Text = "Quy chuẩn so sánh";
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.FromArgb(89, 142, 108);
            btnXacNhan.Font = new Font("Segoe UI", 12F);
            btnXacNhan.Location = new Point(1097, 124);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(102, 42);
            btnXacNhan.TabIndex = 24;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click_1;
            // 
            // txtNoiDungKetQuaPhanTichPTN
            // 
            txtNoiDungKetQuaPhanTichPTN.Font = new Font("Segoe UI", 12F);
            txtNoiDungKetQuaPhanTichPTN.Location = new Point(203, 131);
            txtNoiDungKetQuaPhanTichPTN.Name = "txtNoiDungKetQuaPhanTichPTN";
            txtNoiDungKetQuaPhanTichPTN.Size = new Size(218, 29);
            txtNoiDungKetQuaPhanTichPTN.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(13, 137);
            label11.Name = "label11";
            label11.Size = new Size(163, 21);
            label11.TabIndex = 6;
            label11.Text = "Kết quả phân tích PTN";
            // 
            // txtPhuongPhapPhanTich
            // 
            txtPhuongPhapPhanTich.Font = new Font("Segoe UI", 12F);
            txtPhuongPhapPhanTich.Location = new Point(203, 91);
            txtPhuongPhapPhanTich.Name = "txtPhuongPhapPhanTich";
            txtPhuongPhapPhanTich.Size = new Size(218, 29);
            txtPhuongPhapPhanTich.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(13, 95);
            label10.Name = "label10";
            label10.Size = new Size(172, 21);
            label10.TabIndex = 4;
            label10.Text = "Phương pháp phân tích";
            // 
            // cmbDonVi
            // 
            cmbDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDonVi.Font = new Font("Segoe UI", 12F);
            cmbDonVi.FormattingEnabled = true;
            cmbDonVi.Location = new Point(202, 54);
            cmbDonVi.Name = "cmbDonVi";
            cmbDonVi.Size = new Size(219, 29);
            cmbDonVi.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(13, 59);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 2;
            label9.Text = "Đơn vị";
            // 
            // cmbThongSo
            // 
            cmbThongSo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbThongSo.Font = new Font("Segoe UI", 12F);
            cmbThongSo.FormattingEnabled = true;
            cmbThongSo.Location = new Point(202, 21);
            cmbThongSo.Name = "cmbThongSo";
            cmbThongSo.Size = new Size(219, 29);
            cmbThongSo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(13, 28);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 0;
            label2.Text = "Thông số";
            // 
            // txtTrangThai
            // 
            txtTrangThai.Font = new Font("Segoe UI", 12F);
            txtTrangThai.Location = new Point(889, 57);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.ReadOnly = true;
            txtTrangThai.Size = new Size(202, 29);
            txtTrangThai.TabIndex = 19;
            // 
            // txtKetQuaPhanTich
            // 
            txtKetQuaPhanTich.Font = new Font("Segoe UI", 12F);
            txtKetQuaPhanTich.Location = new Point(889, 16);
            txtKetQuaPhanTich.Name = "txtKetQuaPhanTich";
            txtKetQuaPhanTich.ReadOnly = true;
            txtKetQuaPhanTich.Size = new Size(202, 29);
            txtKetQuaPhanTich.TabIndex = 17;
            // 
            // txtNgayTraKetQua
            // 
            txtNgayTraKetQua.Font = new Font("Segoe UI", 12F);
            txtNgayTraKetQua.Location = new Point(889, 97);
            txtNgayTraKetQua.Name = "txtNgayTraKetQua";
            txtNgayTraKetQua.ReadOnly = true;
            txtNgayTraKetQua.Size = new Size(201, 29);
            txtNgayTraKetQua.TabIndex = 21;
            // 
            // txtNgayLayMau
            // 
            txtNgayLayMau.Font = new Font("Segoe UI", 12F);
            txtNgayLayMau.Location = new Point(609, 96);
            txtNgayLayMau.Name = "txtNgayLayMau";
            txtNgayLayMau.ReadOnly = true;
            txtNgayLayMau.Size = new Size(115, 29);
            txtNgayLayMau.TabIndex = 13;
            // 
            // txtMaHopDong
            // 
            txtMaHopDong.Font = new Font("Segoe UI", 12F);
            txtMaHopDong.Location = new Point(609, 57);
            txtMaHopDong.Name = "txtMaHopDong";
            txtMaHopDong.ReadOnly = true;
            txtMaHopDong.Size = new Size(115, 29);
            txtMaHopDong.TabIndex = 11;
            // 
            // txtMaMau
            // 
            txtMaMau.Font = new Font("Segoe UI", 12F);
            txtMaMau.Location = new Point(609, 20);
            txtMaMau.Name = "txtMaMau";
            txtMaMau.ReadOnly = true;
            txtMaMau.Size = new Size(115, 29);
            txtMaMau.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(741, 62);
            label8.Name = "label8";
            label8.Size = new Size(115, 21);
            label8.TabIndex = 18;
            label8.Text = "Trạng thái xử lý";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(741, 21);
            label7.Name = "label7";
            label7.Size = new Size(134, 21);
            label7.TabIndex = 16;
            label7.Text = "Trạng thái kết quả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(741, 101);
            label6.Name = "label6";
            label6.Size = new Size(125, 21);
            label6.TabIndex = 20;
            label6.Text = "Ngày trả kết quả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(444, 100);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 12;
            label5.Text = "Ngày lấy mẫu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(444, 61);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 10;
            label4.Text = "Mã hợp đồng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(444, 24);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 8;
            label1.Text = "Mã mẫu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(menuStrip1);
            panel2.Controls.Add(lblThongBao);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1205, 57);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Image = Properties.Resources.avatar;
            pictureBox1.Location = new Point(1039, 1);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUserName.ForeColor = Color.FromArgb(89, 142, 108);
            lblUserName.Location = new Point(837, 22);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(21, 21);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "A";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.SeaShell;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { xuatPhieuMenuItem, btnChinhSua, toolStripMenuItem1 });
            menuStrip1.Location = new Point(3, 2);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(353, 53);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // xuatPhieuMenuItem
            // 
            xuatPhieuMenuItem.AutoToolTip = true;
            xuatPhieuMenuItem.Checked = true;
            xuatPhieuMenuItem.CheckState = CheckState.Checked;
            xuatPhieuMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xuatPhieuMenuItem.Image = (Image)resources.GetObject("xuatPhieuMenuItem.Image");
            xuatPhieuMenuItem.Name = "xuatPhieuMenuItem";
            xuatPhieuMenuItem.Size = new Size(107, 49);
            xuatPhieuMenuItem.Text = "Xuất phiếu";
            xuatPhieuMenuItem.Click += xuatPhieuMenuItem_Click;
            // 
            // btnChinhSua
            // 
            btnChinhSua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChinhSua.Image = Properties.Resources.edit;
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(58, 49);
            btnChinhSua.Text = "Sửa";
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Segoe UI", 10.2F);
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(147, 49);
            toolStripMenuItem1.Text = "Liên hệ và Hỗ trợ";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Location = new Point(359, 22);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 15);
            lblThongBao.TabIndex = 1;
            // 
            // quanLyPhieuTraHangControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "quanLyPhieuTraHangControl";
            Size = new Size(1205, 696);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhieuKetQua).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChiTietThongSo).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem xuatPhieuMenuItem;
        private Panel panel3;
        private GroupBox groupBox2;
        private TextBox txtNoiDungKetQuaPhanTichPTN;
        private Label label11;
        private TextBox txtPhuongPhapPhanTich;
        private Label label10;
        private ComboBox cmbDonVi;
        private Label label9;
        private ComboBox cmbThongSo;
        private Label label2;
        private TextBox txtTrangThai;
        private TextBox txtKetQuaPhanTich;
        private Button btnXacNhan;
        private Label lblThongBao;
        private TextBox txtNgayTraKetQua;
        private TextBox txtNgayLayMau;
        private TextBox txtMaHopDong;
        private TextBox txtMaMau;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private Label lblUserName;
        private TextBox txtQuyChuanVietNam;
        private Label label3;
        private ToolStripMenuItem toolStripMenuItem1;
        private TextBox txtNoiDungKetQuaPhanTichHT;
        private Label label12;
        public DataGridView dataGridViewPhieuKetQua;
        private DataGridViewTextBoxColumn MaMau;
        private DataGridViewTextBoxColumn MaHopDong;
        private DataGridViewTextBoxColumn NgayLayMau;
        private DataGridViewTextBoxColumn NgayTraKetQua;
        private DataGridViewTextBoxColumn TrangThaiKetQuaPhanTich;
        private DataGridViewTextBoxColumn TrangThaiXuLy;
        public DataGridView dataGridViewChiTietThongSo;
        private DataGridViewTextBoxColumn ThongSo;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn PhuongPhapPhanTich;
        private DataGridViewTextBoxColumn KetQuaPTN;
        private DataGridViewTextBoxColumn KetQuaHT;
        private DataGridViewTextBoxColumn QuyChuanSoSanh;
        private ToolStripMenuItem btnChinhSua;
        private Button button2;
        private Button btnCapNhat;
    }
}
