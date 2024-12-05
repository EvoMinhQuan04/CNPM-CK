namespace WinFormsApp1.Views.quanLyMauQuanTracViews
{
    partial class quanLyMauQuanTracControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanLyMauQuanTracControl));
            panelQuanLyMauQuanTracUC = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dataGridViewMauQuanTrac = new DataGridView();
            MaMau = new DataGridViewTextBoxColumn();
            MaHopDong = new DataGridViewTextBoxColumn();
            TenMau = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            NgayLay = new DataGridViewTextBoxColumn();
            NgayTra = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            lblThongBao = new Label();
            dtpNgayTra = new DateTimePicker();
            dtpNgayLay = new DateTimePicker();
            maHopDongTextBox = new TextBox();
            btnHuy = new Button();
            btnLuu = new Button();
            maNhanVienTextBox = new TextBox();
            noiDungTextBox = new TextBox();
            tenMauTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            maMauTextBox = new TextBox();
            panel2 = new Panel();
            menuStrip = new MenuStrip();
            menuItemThem = new ToolStripMenuItem();
            btnChinhSua = new ToolStripMenuItem();
            menuItemLoc = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            labelUserName = new Label();
            pictureBox1 = new PictureBox();
            panelQuanLyMauQuanTracUC.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMauQuanTrac).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelQuanLyMauQuanTracUC
            // 
            panelQuanLyMauQuanTracUC.Controls.Add(panel3);
            panelQuanLyMauQuanTracUC.Controls.Add(panel2);
            panelQuanLyMauQuanTracUC.Dock = DockStyle.Fill;
            panelQuanLyMauQuanTracUC.Location = new Point(0, 0);
            panelQuanLyMauQuanTracUC.Name = "panelQuanLyMauQuanTracUC";
            panelQuanLyMauQuanTracUC.Size = new Size(1263, 750);
            panelQuanLyMauQuanTracUC.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(1263, 691);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Controls.Add(dataGridViewMauQuanTrac);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 171);
            panel4.Name = "panel4";
            panel4.Size = new Size(1263, 520);
            panel4.TabIndex = 10;
            // 
            // dataGridViewMauQuanTrac
            // 
            dataGridViewMauQuanTrac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMauQuanTrac.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMauQuanTrac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMauQuanTrac.ColumnHeadersHeight = 40;
            dataGridViewMauQuanTrac.Columns.AddRange(new DataGridViewColumn[] { MaMau, MaHopDong, TenMau, NoiDung, NgayLay, NgayTra, MaNhanVien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewMauQuanTrac.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMauQuanTrac.Dock = DockStyle.Fill;
            dataGridViewMauQuanTrac.GridColor = SystemColors.Menu;
            dataGridViewMauQuanTrac.ImeMode = ImeMode.NoControl;
            dataGridViewMauQuanTrac.Location = new Point(0, 0);
            dataGridViewMauQuanTrac.Name = "dataGridViewMauQuanTrac";
            dataGridViewMauQuanTrac.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewMauQuanTrac.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMauQuanTrac.RowHeadersVisible = false;
            dataGridViewMauQuanTrac.RowHeadersWidth = 100;
            dataGridViewMauQuanTrac.RowTemplate.Height = 24;
            dataGridViewMauQuanTrac.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMauQuanTrac.Size = new Size(1263, 520);
            dataGridViewMauQuanTrac.TabIndex = 0;
            dataGridViewMauQuanTrac.SelectionChanged += dataGridViewMauQuanTrac_SelectionChanged;
            // 
            // MaMau
            // 
            MaMau.HeaderText = "Mã mẫu";
            MaMau.Name = "MaMau";
            MaMau.ReadOnly = true;
            // 
            // MaHopDong
            // 
            MaHopDong.HeaderText = "Mã hợp đồng";
            MaHopDong.Name = "MaHopDong";
            MaHopDong.ReadOnly = true;
            // 
            // TenMau
            // 
            TenMau.HeaderText = "Tên mẫu";
            TenMau.Name = "TenMau";
            TenMau.ReadOnly = true;
            // 
            // NoiDung
            // 
            NoiDung.HeaderText = "Nội dung";
            NoiDung.Name = "NoiDung";
            NoiDung.ReadOnly = true;
            // 
            // NgayLay
            // 
            NgayLay.HeaderText = "Ngày lấy";
            NgayLay.Name = "NgayLay";
            NgayLay.ReadOnly = true;
            // 
            // NgayTra
            // 
            NgayTra.HeaderText = "Ngày trả";
            NgayTra.Name = "NgayTra";
            NgayTra.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(197, 219, 204);
            groupBox1.Controls.Add(lblThongBao);
            groupBox1.Controls.Add(dtpNgayTra);
            groupBox1.Controls.Add(dtpNgayLay);
            groupBox1.Controls.Add(maHopDongTextBox);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(maNhanVienTextBox);
            groupBox1.Controls.Add(noiDungTextBox);
            groupBox1.Controls.Add(tenMauTextBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(maMauTextBox);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1263, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Mẫu Quan Trắc";
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Location = new Point(422, 7);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 20);
            lblThongBao.TabIndex = 0;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            dtpNgayTra.Font = new Font("Segoe UI", 11F);
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.Location = new Point(551, 115);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(243, 27);
            dtpNgayTra.TabIndex = 12;
            // 
            // dtpNgayLay
            // 
            dtpNgayLay.CustomFormat = "dd/MM/yyyy";
            dtpNgayLay.Font = new Font("Segoe UI", 11F);
            dtpNgayLay.Format = DateTimePickerFormat.Custom;
            dtpNgayLay.Location = new Point(550, 79);
            dtpNgayLay.Name = "dtpNgayLay";
            dtpNgayLay.Size = new Size(243, 27);
            dtpNgayLay.TabIndex = 10;
            // 
            // maHopDongTextBox
            // 
            maHopDongTextBox.Font = new Font("Segoe UI", 11F);
            maHopDongTextBox.Location = new Point(145, 79);
            maHopDongTextBox.Name = "maHopDongTextBox";
            maHopDongTextBox.Size = new Size(243, 27);
            maHopDongTextBox.TabIndex = 4;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Gray;
            btnHuy.Font = new Font("Segoe UI", 11F);
            btnHuy.ForeColor = SystemColors.ControlLightLight;
            btnHuy.Location = new Point(907, 126);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 29);
            btnHuy.TabIndex = 15;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(89, 142, 108);
            btnLuu.Font = new Font("Segoe UI", 11F);
            btnLuu.ForeColor = SystemColors.ControlLightLight;
            btnLuu.Location = new Point(1010, 126);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(80, 29);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // maNhanVienTextBox
            // 
            maNhanVienTextBox.Font = new Font("Segoe UI", 11F);
            maNhanVienTextBox.Location = new Point(146, 117);
            maNhanVienTextBox.Margin = new Padding(3, 2, 3, 2);
            maNhanVienTextBox.Name = "maNhanVienTextBox";
            maNhanVienTextBox.Size = new Size(243, 27);
            maNhanVienTextBox.TabIndex = 6;
            // 
            // noiDungTextBox
            // 
            noiDungTextBox.Font = new Font("Segoe UI", 11F);
            noiDungTextBox.Location = new Point(551, 42);
            noiDungTextBox.Margin = new Padding(3, 2, 3, 2);
            noiDungTextBox.Name = "noiDungTextBox";
            noiDungTextBox.Size = new Size(243, 27);
            noiDungTextBox.TabIndex = 8;
            // 
            // tenMauTextBox
            // 
            tenMauTextBox.Font = new Font("Segoe UI", 11F);
            tenMauTextBox.Location = new Point(903, 45);
            tenMauTextBox.Margin = new Padding(3, 2, 3, 2);
            tenMauTextBox.Name = "tenMauTextBox";
            tenMauTextBox.Size = new Size(243, 27);
            tenMauTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(833, 47);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 13;
            label7.Text = "Tên mẫu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(424, 119);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 11;
            label6.Text = "Ngày trả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(424, 80);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "Ngày lấy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(422, 43);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 7;
            label4.Text = "Nội dung";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(18, 121);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã nhân viên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.Location = new Point(18, 82);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 3;
            label8.Text = "Mã hợp đồng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F);
            label9.Location = new Point(20, 41);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 1;
            label9.Text = "Mã mẫu";
            // 
            // maMauTextBox
            // 
            maMauTextBox.Font = new Font("Segoe UI", 11F);
            maMauTextBox.Location = new Point(146, 40);
            maMauTextBox.Margin = new Padding(3, 2, 3, 2);
            maMauTextBox.Name = "maMauTextBox";
            maMauTextBox.Size = new Size(243, 27);
            maMauTextBox.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(menuStrip);
            panel2.Controls.Add(labelUserName);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1263, 59);
            panel2.TabIndex = 1;
            // 
            // menuStrip
            // 
            menuStrip.AutoSize = false;
            menuStrip.BackColor = Color.SeaShell;
            menuStrip.Dock = DockStyle.None;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuItemThem, btnChinhSua, menuItemLoc, toolStripMenuItem1 });
            menuStrip.Location = new Point(0, 3);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(374, 53);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // menuItemThem
            // 
            menuItemThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuItemThem.Image = Properties.Resources.more;
            menuItemThem.Name = "menuItemThem";
            menuItemThem.Size = new Size(75, 49);
            menuItemThem.Text = "Thêm";
            menuItemThem.Click += menuItemThem_Click;
            // 
            // btnChinhSua
            // 
            btnChinhSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChinhSua.Image = Properties.Resources.edit;
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(63, 49);
            btnChinhSua.Text = "Sửa";
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // menuItemLoc
            // 
            menuItemLoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuItemLoc.Image = Properties.Resources.slider;
            menuItemLoc.Name = "menuItemLoc";
            menuItemLoc.Size = new Size(62, 49);
            menuItemLoc.Text = "Lọc";
            menuItemLoc.Click += menuItemLoc_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(129, 49);
            toolStripMenuItem1.Text = "Liên hệ và Hỗ trợ";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // labelUserName
            // 
            labelUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelUserName.ForeColor = Color.FromArgb(89, 142, 108);
            labelUserName.Location = new Point(895, 21);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(25, 21);
            labelUserName.TabIndex = 1;
            labelUserName.Text = " A";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Image = Properties.Resources.avatar;
            pictureBox1.Location = new Point(1098, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // quanLyMauQuanTracControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelQuanLyMauQuanTracUC);
            Name = "quanLyMauQuanTracControl";
            Size = new Size(1263, 750);
            panelQuanLyMauQuanTracUC.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMauQuanTrac).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelQuanLyMauQuanTracUC;
        private Panel panel2;
        private Label labelUserName;
        private PictureBox pictureBox1;
        private Panel panel3;
        private GroupBox groupBox1;
        private Button btnHuy;
        private Button btnLuu;
        private TextBox maNhanVienTextBox;
        private TextBox noiDungTextBox;
        private TextBox tenMauTextBox;
        private ComboBox tenCongTyComboBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label8;
        private Label label9;
        private TextBox maMauTextBox;
        private TextBox maHopDongTextBox;
        private DateTimePicker dtpNgayLay;
        private DateTimePicker dtpNgayTra;
        private Label lblThongBao;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuItemThem;
        private ToolStripMenuItem btnChinhSua;
        private ToolStripMenuItem menuItemLoc;
        private ToolStripMenuItem toolStripMenuItem1;
        private Panel panel4;
        public DataGridView dataGridViewMauQuanTrac;
        private DataGridViewTextBoxColumn MaMau;
        private DataGridViewTextBoxColumn MaHopDong;
        private DataGridViewTextBoxColumn TenMau;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn NgayLay;
        private DataGridViewTextBoxColumn NgayTra;
        private DataGridViewTextBoxColumn MaNhanVien;
    }
}
