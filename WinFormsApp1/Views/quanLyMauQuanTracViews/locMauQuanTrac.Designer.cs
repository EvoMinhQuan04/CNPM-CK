namespace WinFormsApp1.Views.quanLyMauQuanTracViews
{
    partial class locMauQuanTrac
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locMauQuanTrac));
            panelHeader = new Panel();
            lblThongBao = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txtMaNhanVien = new TextBox();
            label5 = new Label();
            txtMaMau = new TextBox();
            label4 = new Label();
            btnLoc = new Button();
            cbBoxNgayTra = new ComboBox();
            label3 = new Label();
            cbBoxNgayLay = new ComboBox();
            label2 = new Label();
            txtMaHopDong = new TextBox();
            label1 = new Label();
            dataGridViewMauQuanTrac = new DataGridView();
            MaMau = new DataGridViewTextBoxColumn();
            MaHopDong = new DataGridViewTextBoxColumn();
            TenMau = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            NgayLay = new DataGridViewTextBoxColumn();
            NgayTra = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMauQuanTrac).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SeaShell;
            panelHeader.Controls.Add(lblThongBao);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1263, 40);
            panelHeader.TabIndex = 0;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Font = new Font("Segoe UI", 9F);
            lblThongBao.Location = new Point(340, 15);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 15);
            lblThongBao.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.back;
            pictureBox1.Location = new Point(4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaNhanVien);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMaMau);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(cbBoxNgayTra);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbBoxNgayLay);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaHopDong);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1263, 79);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thuộc tính";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Segoe UI", 12F);
            txtMaNhanVien.Location = new Point(472, 35);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(100, 29);
            txtMaNhanVien.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(374, 40);
            label5.Name = "label5";
            label5.Size = new Size(93, 19);
            label5.TabIndex = 4;
            label5.Text = "Mã nhân viên";
            // 
            // txtMaMau
            // 
            txtMaMau.Font = new Font("Segoe UI", 12F);
            txtMaMau.Location = new Point(277, 35);
            txtMaMau.Name = "txtMaMau";
            txtMaMau.Size = new Size(72, 29);
            txtMaMau.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(211, 40);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 2;
            label4.Text = "Mã mẫu";
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(89, 142, 108);
            btnLoc.Cursor = Cursors.Hand;
            btnLoc.Font = new Font("Segoe UI", 12F);
            btnLoc.Location = new Point(1044, 33);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(75, 32);
            btnLoc.TabIndex = 10;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // cbBoxNgayTra
            // 
            cbBoxNgayTra.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBoxNgayTra.Font = new Font("Segoe UI", 12F);
            cbBoxNgayTra.FormattingEnabled = true;
            cbBoxNgayTra.Location = new Point(894, 36);
            cbBoxNgayTra.Name = "cbBoxNgayTra";
            cbBoxNgayTra.Size = new Size(115, 29);
            cbBoxNgayTra.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(826, 41);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 8;
            label3.Text = "Ngày trả";
            // 
            // cbBoxNgayLay
            // 
            cbBoxNgayLay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBoxNgayLay.Font = new Font("Segoe UI", 12F);
            cbBoxNgayLay.FormattingEnabled = true;
            cbBoxNgayLay.Location = new Point(671, 35);
            cbBoxNgayLay.Name = "cbBoxNgayLay";
            cbBoxNgayLay.Size = new Size(121, 29);
            cbBoxNgayLay.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(601, 39);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 6;
            label2.Text = "Ngày lấy";
            // 
            // txtMaHopDong
            // 
            txtMaHopDong.Font = new Font("Segoe UI", 12F);
            txtMaHopDong.Location = new Point(117, 35);
            txtMaHopDong.Name = "txtMaHopDong";
            txtMaHopDong.Size = new Size(74, 29);
            txtMaHopDong.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(20, 39);
            label1.Name = "label1";
            label1.Size = new Size(93, 19);
            label1.TabIndex = 0;
            label1.Text = "Mã hợp đồng";
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
            dataGridViewMauQuanTrac.Location = new Point(0, 119);
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
            dataGridViewMauQuanTrac.Size = new Size(1263, 414);
            dataGridViewMauQuanTrac.TabIndex = 2;
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
            // locMauQuanTrac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 533);
            Controls.Add(dataGridViewMauQuanTrac);
            Controls.Add(groupBox1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "locMauQuanTrac";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lọc mẫu quan trắc";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMauQuanTrac).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private ComboBox cbBoxNgayTra;
        private Label label3;
        private ComboBox cbBoxNgayLay;
        private Label label2;
        private TextBox txtMaHopDong;
        private Label label1;
        private Button btnLoc;
        private Label lblThongBao;
        public DataGridView dataGridViewMauQuanTrac;
        private DataGridViewTextBoxColumn MaMau;
        private DataGridViewTextBoxColumn MaHopDong;
        private DataGridViewTextBoxColumn TenMau;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn NgayLay;
        private DataGridViewTextBoxColumn NgayTra;
        private DataGridViewTextBoxColumn MaNhanVien;
        private TextBox txtMaNhanVien;
        private Label label5;
        private TextBox txtMaMau;
        private Label label4;
    }
}