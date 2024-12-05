namespace WinFormsApp1.Views.quanLyNhanVienViews
{
    partial class quanLyNhanVienControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanLyNhanVienControl));
            panelQuanLyNhanVienUC = new Panel();
            panel4 = new Panel();
            dataGridViewNhanVien = new DataGridView();
            maNhanVien = new DataGridViewTextBoxColumn();
            hoVaTen = new DataGridViewTextBoxColumn();
            ngaySinh = new DataGridViewTextBoxColumn();
            Sodienthoai = new DataGridViewTextBoxColumn();
            chucVu = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            thongBaoLabel = new Label();
            chucVuComboBox = new ComboBox();
            ngaySinhDateTimePicker = new DateTimePicker();
            hoVaTenTextBox = new TextBox();
            btnHuy = new Button();
            btnLuu = new Button();
            emailTextBox = new TextBox();
            soDienThoaiTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            maNhanVienTextBox = new TextBox();
            panel2 = new Panel();
            labelUsername = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            themToolStripMenuItem = new ToolStripMenuItem();
            btnChinhSua = new ToolStripMenuItem();
            locNhanVienStripMenuItem1 = new ToolStripMenuItem();
            thongBaoEmailToolStripMenuItem = new ToolStripMenuItem();
            hieuSuatStripMenuItem1 = new ToolStripMenuItem();
            lichSuToolStripMenuItem = new ToolStripMenuItem();
            lienHeHoTroToolStripMenuItem = new ToolStripMenuItem();
            panelQuanLyNhanVienUC.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelQuanLyNhanVienUC
            // 
            panelQuanLyNhanVienUC.Controls.Add(panel4);
            panelQuanLyNhanVienUC.Controls.Add(groupBox1);
            panelQuanLyNhanVienUC.Controls.Add(panel2);
            panelQuanLyNhanVienUC.Dock = DockStyle.Fill;
            panelQuanLyNhanVienUC.Location = new Point(0, 0);
            panelQuanLyNhanVienUC.Name = "panelQuanLyNhanVienUC";
            panelQuanLyNhanVienUC.Size = new Size(1295, 710);
            panelQuanLyNhanVienUC.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Controls.Add(dataGridViewNhanVien);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 232);
            panel4.Name = "panel4";
            panel4.Size = new Size(1295, 478);
            panel4.TabIndex = 14;
            // 
            // dataGridViewNhanVien
            // 
            dataGridViewNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNhanVien.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewNhanVien.ColumnHeadersHeight = 40;
            dataGridViewNhanVien.Columns.AddRange(new DataGridViewColumn[] { maNhanVien, hoVaTen, ngaySinh, Sodienthoai, chucVu, email });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewNhanVien.Dock = DockStyle.Fill;
            dataGridViewNhanVien.GridColor = SystemColors.Menu;
            dataGridViewNhanVien.ImeMode = ImeMode.NoControl;
            dataGridViewNhanVien.Location = new Point(0, 0);
            dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            dataGridViewNhanVien.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewNhanVien.RowHeadersVisible = false;
            dataGridViewNhanVien.RowHeadersWidth = 100;
            dataGridViewNhanVien.RowTemplate.Height = 24;
            dataGridViewNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNhanVien.Size = new Size(1295, 478);
            dataGridViewNhanVien.TabIndex = 0;
            dataGridViewNhanVien.SelectionChanged += dataGridViewNhanVien_SelectionChanged;
            // 
            // maNhanVien
            // 
            maNhanVien.HeaderText = "Mã nhân viên";
            maNhanVien.MinimumWidth = 6;
            maNhanVien.Name = "maNhanVien";
            maNhanVien.ReadOnly = true;
            // 
            // hoVaTen
            // 
            hoVaTen.HeaderText = "Họ và tên";
            hoVaTen.MinimumWidth = 6;
            hoVaTen.Name = "hoVaTen";
            hoVaTen.ReadOnly = true;
            // 
            // ngaySinh
            // 
            ngaySinh.HeaderText = "Ngày sinh";
            ngaySinh.MinimumWidth = 6;
            ngaySinh.Name = "ngaySinh";
            ngaySinh.ReadOnly = true;
            // 
            // Sodienthoai
            // 
            Sodienthoai.HeaderText = "Số điện thoại";
            Sodienthoai.MinimumWidth = 6;
            Sodienthoai.Name = "Sodienthoai";
            Sodienthoai.ReadOnly = true;
            // 
            // chucVu
            // 
            chucVu.HeaderText = "Chức vụ";
            chucVu.MinimumWidth = 6;
            chucVu.Name = "chucVu";
            chucVu.ReadOnly = true;
            // 
            // email
            // 
            email.FillWeight = 140F;
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(197, 219, 204);
            groupBox1.Controls.Add(thongBaoLabel);
            groupBox1.Controls.Add(chucVuComboBox);
            groupBox1.Controls.Add(ngaySinhDateTimePicker);
            groupBox1.Controls.Add(hoVaTenTextBox);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(soDienThoaiTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(maNhanVienTextBox);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 59);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1295, 173);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Nhân Viên";
            // 
            // thongBaoLabel
            // 
            thongBaoLabel.AutoSize = true;
            thongBaoLabel.Location = new Point(404, 6);
            thongBaoLabel.Name = "thongBaoLabel";
            thongBaoLabel.Size = new Size(0, 20);
            thongBaoLabel.TabIndex = 0;
            // 
            // chucVuComboBox
            // 
            chucVuComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            chucVuComboBox.Font = new Font("Segoe UI", 11F);
            chucVuComboBox.FormattingEnabled = true;
            chucVuComboBox.Items.AddRange(new object[] { "Nhân viên" });
            chucVuComboBox.Location = new Point(654, 36);
            chucVuComboBox.Name = "chucVuComboBox";
            chucVuComboBox.Size = new Size(258, 28);
            chucVuComboBox.TabIndex = 8;
            // 
            // ngaySinhDateTimePicker
            // 
            ngaySinhDateTimePicker.CustomFormat = "dd/MM/yyyy";
            ngaySinhDateTimePicker.Font = new Font("Segoe UI", 11F);
            ngaySinhDateTimePicker.Format = DateTimePickerFormat.Custom;
            ngaySinhDateTimePicker.Location = new Point(654, 76);
            ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            ngaySinhDateTimePicker.Size = new Size(258, 27);
            ngaySinhDateTimePicker.TabIndex = 10;
            // 
            // hoVaTenTextBox
            // 
            hoVaTenTextBox.Font = new Font("Segoe UI", 11F);
            hoVaTenTextBox.Location = new Point(146, 78);
            hoVaTenTextBox.Name = "hoVaTenTextBox";
            hoVaTenTextBox.Size = new Size(258, 27);
            hoVaTenTextBox.TabIndex = 4;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Gray;
            btnHuy.Font = new Font("Segoe UI", 11F);
            btnHuy.ForeColor = SystemColors.ControlLightLight;
            btnHuy.Location = new Point(949, 118);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(92, 28);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(89, 142, 108);
            btnLuu.Font = new Font("Segoe UI", 11F);
            btnLuu.ForeColor = SystemColors.ControlLightLight;
            btnLuu.Location = new Point(1053, 118);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(92, 27);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 11F);
            emailTextBox.Location = new Point(146, 117);
            emailTextBox.Margin = new Padding(3, 2, 3, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(258, 27);
            emailTextBox.TabIndex = 6;
            // 
            // soDienThoaiTextBox
            // 
            soDienThoaiTextBox.Font = new Font("Segoe UI", 11F);
            soDienThoaiTextBox.Location = new Point(654, 117);
            soDienThoaiTextBox.Margin = new Padding(3, 2, 3, 2);
            soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            soDienThoaiTextBox.Size = new Size(258, 27);
            soDienThoaiTextBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(527, 122);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 11;
            label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(527, 78);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 9;
            label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(527, 38);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 7;
            label4.Text = "Chức vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(18, 118);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.Location = new Point(18, 77);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 3;
            label8.Text = "Tên nhân viên";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F);
            label9.Location = new Point(18, 37);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 1;
            label9.Text = "Mã nhân viên";
            // 
            // maNhanVienTextBox
            // 
            maNhanVienTextBox.Font = new Font("Segoe UI", 11F);
            maNhanVienTextBox.Location = new Point(146, 37);
            maNhanVienTextBox.Margin = new Padding(3, 2, 3, 2);
            maNhanVienTextBox.Name = "maNhanVienTextBox";
            maNhanVienTextBox.Size = new Size(258, 27);
            maNhanVienTextBox.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(labelUsername);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1295, 59);
            panel2.TabIndex = 11;
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelUsername.ForeColor = Color.FromArgb(89, 142, 108);
            labelUsername.Location = new Point(922, 22);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(25, 21);
            labelUsername.TabIndex = 1;
            labelUsername.Text = " A";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Image = Properties.Resources.avatar;
            pictureBox1.Location = new Point(1126, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.SeaShell;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { themToolStripMenuItem, btnChinhSua, locNhanVienStripMenuItem1, thongBaoEmailToolStripMenuItem, hieuSuatStripMenuItem1, lichSuToolStripMenuItem, lienHeHoTroToolStripMenuItem });
            menuStrip1.Location = new Point(1, 1);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(714, 56);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // themToolStripMenuItem
            // 
            themToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            themToolStripMenuItem.Image = Properties.Resources.more;
            themToolStripMenuItem.Name = "themToolStripMenuItem";
            themToolStripMenuItem.Size = new Size(69, 52);
            themToolStripMenuItem.Text = "Thêm";
            themToolStripMenuItem.Click += themToolStripMenuItem_Click;
            // 
            // btnChinhSua
            // 
            btnChinhSua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChinhSua.Image = Properties.Resources.edit;
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(58, 52);
            btnChinhSua.Text = "Sửa";
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // locNhanVienStripMenuItem1
            // 
            locNhanVienStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            locNhanVienStripMenuItem1.Image = (Image)resources.GetObject("locNhanVienStripMenuItem1.Image");
            locNhanVienStripMenuItem1.Name = "locNhanVienStripMenuItem1";
            locNhanVienStripMenuItem1.Size = new Size(58, 52);
            locNhanVienStripMenuItem1.Text = "Lọc";
            locNhanVienStripMenuItem1.Click += locNhanVienStripMenuItem1_Click;
            // 
            // thongBaoEmailToolStripMenuItem
            // 
            thongBaoEmailToolStripMenuItem.Image = (Image)resources.GetObject("thongBaoEmailToolStripMenuItem.Image");
            thongBaoEmailToolStripMenuItem.Name = "thongBaoEmailToolStripMenuItem";
            thongBaoEmailToolStripMenuItem.Size = new Size(128, 52);
            thongBaoEmailToolStripMenuItem.Text = "Thông báo Email";
            thongBaoEmailToolStripMenuItem.Click += thongBaoEmailToolStripMenuItem_Click;
            // 
            // hieuSuatStripMenuItem1
            // 
            hieuSuatStripMenuItem1.Image = Properties.Resources.performance;
            hieuSuatStripMenuItem1.Name = "hieuSuatStripMenuItem1";
            hieuSuatStripMenuItem1.Size = new Size(89, 52);
            hieuSuatStripMenuItem1.Text = "Hiệu suất";
            hieuSuatStripMenuItem1.Click += hieuSuatStripMenuItem1_Click;
            // 
            // lichSuToolStripMenuItem
            // 
            lichSuToolStripMenuItem.Image = Properties.Resources.history;
            lichSuToolStripMenuItem.Name = "lichSuToolStripMenuItem";
            lichSuToolStripMenuItem.Size = new Size(114, 52);
            lichSuToolStripMenuItem.Text = "Tra cứu lịch sử";
            lichSuToolStripMenuItem.Click += lichSuToolStripMenuItem_Click;
            // 
            // lienHeHoTroToolStripMenuItem
            // 
            lienHeHoTroToolStripMenuItem.Image = (Image)resources.GetObject("lienHeHoTroToolStripMenuItem.Image");
            lienHeHoTroToolStripMenuItem.Name = "lienHeHoTroToolStripMenuItem";
            lienHeHoTroToolStripMenuItem.Size = new Size(129, 52);
            lienHeHoTroToolStripMenuItem.Text = "Liên hệ và Hỗ trợ";
            lienHeHoTroToolStripMenuItem.Click += lienHeHoTroToolStripMenuItem_Click;
            // 
            // quanLyNhanVienControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelQuanLyNhanVienUC);
            Name = "quanLyNhanVienControl";
            Size = new Size(1295, 710);
            panelQuanLyNhanVienUC.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNhanVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelQuanLyNhanVienUC;
        private Panel panel2;
        private Label labelUsername;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themToolStripMenuItem;
        private ToolStripMenuItem btnChinhSua;
        private ToolStripMenuItem thongBaoEmailToolStripMenuItem;
        private ToolStripMenuItem hieuSuatStripMenuItem1;
        private ToolStripMenuItem lichSuToolStripMenuItem;
        private GroupBox groupBox1;
        private ComboBox chucVuComboBox;
        private DateTimePicker ngaySinhDateTimePicker;
        private TextBox hoVaTenTextBox;
        private Button btnHuy;
        private Button btnLuu;
        private TextBox emailTextBox;
        private TextBox soDienThoaiTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label8;
        private Label label9;
        private TextBox maNhanVienTextBox;
        private Panel panel4;
        private Label thongBaoLabel;
        private ToolStripMenuItem lienHeHoTroToolStripMenuItem;
        private ToolStripMenuItem locNhanVienStripMenuItem1;
        public DataGridView dataGridViewNhanVien;
        private DataGridViewTextBoxColumn maNhanVien;
        private DataGridViewTextBoxColumn hoVaTen;
        private DataGridViewTextBoxColumn ngaySinh;
        private DataGridViewTextBoxColumn Sodienthoai;
        private DataGridViewTextBoxColumn chucVu;
        private DataGridViewTextBoxColumn email;
    }
}
