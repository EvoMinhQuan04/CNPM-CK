namespace WinFormsApp1
{
    partial class baoCaoHieuSuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baoCaoHieuSuat));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label1 = new Label();
            txtNam = new TextBox();
            txtMaNhanVien = new TextBox();
            cmbQuy = new ComboBox();
            lblThongBao = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            panel7 = new Panel();
            label12 = new Label();
            label7 = new Label();
            label9 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            txtTongHopDongTrongQuyCuaNv = new TextBox();
            txtTongSoHopDongCty = new TextBox();
            txtTongSoHopDongTrongQuyCuaCty = new TextBox();
            label11 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            dataMau = new DataGridView();
            maNhanVien = new DataGridViewTextBoxColumn();
            hoVaTen = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            Sodienthoai = new DataGridViewTextBoxColumn();
            ngaySinh = new DataGridViewTextBoxColumn();
            chucVu = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataMau).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtNam);
            panel2.Controls.Add(txtMaNhanVien);
            panel2.Controls.Add(cmbQuy);
            panel2.Controls.Add(lblThongBao);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1502, 41);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
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
            label8.Location = new Point(37, 9);
            label8.Name = "label8";
            label8.Size = new Size(145, 20);
            label8.TabIndex = 0;
            label8.Text = "Hiệu suất nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(350, 14);
            label1.Name = "label1";
            label1.Size = new Size(186, 19);
            label1.TabIndex = 2;
            label1.Text = "Nhập mã/họ tên nhân viên";
            // 
            // txtNam
            // 
            txtNam.Location = new Point(1050, 14);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(78, 23);
            txtNam.TabIndex = 7;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(539, 12);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(132, 23);
            txtMaNhanVien.TabIndex = 3;
            // 
            // cmbQuy
            // 
            cmbQuy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuy.FormattingEnabled = true;
            cmbQuy.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cmbQuy.Location = new Point(807, 13);
            cmbQuy.Name = "cmbQuy";
            cmbQuy.Size = new Size(109, 23);
            cmbQuy.TabIndex = 5;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Location = new Point(188, 15);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 15);
            lblThongBao.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(727, 15);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 4;
            label3.Text = "Chọn quý:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(962, 15);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 6;
            label4.Text = "Nhập năm:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(89, 142, 108);
            button2.Location = new Point(1149, 9);
            button2.Name = "button2";
            button2.Size = new Size(88, 31);
            button2.TabIndex = 8;
            button2.Text = "Tìm kiếm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(splitContainer1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(1502, 741);
            panel1.TabIndex = 20;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 176);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Size = new Size(1025, 520);
            splitContainer1.SplitterDistance = 518;
            splitContainer1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1025, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(477, 520);
            panel3.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label9);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 696);
            panel7.Name = "panel7";
            panel7.Size = new Size(1502, 45);
            panel7.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label12.Location = new Point(1044, 15);
            label12.Name = "label12";
            label12.Size = new Size(454, 19);
            label12.TabIndex = 2;
            label12.Text = "Biểu đồ số lượng hợp đồng của nhân viên so với công ty trong quý";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(131, 15);
            label7.Name = "label7";
            label7.Size = new Size(254, 19);
            label7.TabIndex = 0;
            label7.Text = "Biểu đồ thống kê số lượng hợp đồng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.Location = new Point(607, 15);
            label9.Name = "label9";
            label9.Size = new Size(324, 19);
            label9.TabIndex = 1;
            label9.Text = "Biểu đồ tỉ lệ đóng góp của nhân viên trong quý";
            // 
            // panel6
            // 
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 135);
            panel6.Name = "panel6";
            panel6.Size = new Size(1502, 41);
            panel6.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(703, 10);
            label6.Name = "label6";
            label6.Size = new Size(161, 21);
            label6.TabIndex = 0;
            label6.Text = "THỐNG KÊ CHI TIẾT ";
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txtTongHopDongTrongQuyCuaNv);
            panel5.Controls.Add(txtTongSoHopDongCty);
            panel5.Controls.Add(txtTongSoHopDongTrongQuyCuaCty);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 88);
            panel5.Name = "panel5";
            panel5.Size = new Size(1502, 47);
            panel5.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(33, 15);
            label5.Name = "label5";
            label5.Size = new Size(279, 19);
            label5.TabIndex = 0;
            label5.Text = "Tổng số hợp đồng trong quý của nhân viên:";
            // 
            // txtTongHopDongTrongQuyCuaNv
            // 
            txtTongHopDongTrongQuyCuaNv.Location = new Point(326, 14);
            txtTongHopDongTrongQuyCuaNv.Name = "txtTongHopDongTrongQuyCuaNv";
            txtTongHopDongTrongQuyCuaNv.ReadOnly = true;
            txtTongHopDongTrongQuyCuaNv.Size = new Size(50, 23);
            txtTongHopDongTrongQuyCuaNv.TabIndex = 1;
            // 
            // txtTongSoHopDongCty
            // 
            txtTongSoHopDongCty.Location = new Point(885, 15);
            txtTongSoHopDongCty.Name = "txtTongSoHopDongCty";
            txtTongSoHopDongCty.ReadOnly = true;
            txtTongSoHopDongCty.Size = new Size(62, 23);
            txtTongSoHopDongCty.TabIndex = 3;
            // 
            // txtTongSoHopDongTrongQuyCuaCty
            // 
            txtTongSoHopDongTrongQuyCuaCty.Location = new Point(1390, 14);
            txtTongSoHopDongTrongQuyCuaCty.Name = "txtTongSoHopDongTrongQuyCuaCty";
            txtTongSoHopDongTrongQuyCuaCty.ReadOnly = true;
            txtTongSoHopDongTrongQuyCuaCty.Size = new Size(50, 23);
            txtTongSoHopDongTrongQuyCuaCty.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(641, 16);
            label11.Name = "label11";
            label11.Size = new Size(239, 19);
            label11.TabIndex = 2;
            label11.Text = "Tổng số lượng hợp đồng của công ty:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(1121, 17);
            label10.Name = "label10";
            label10.Size = new Size(265, 19);
            label10.TabIndex = 4;
            label10.Text = "Tổng số hợp đồng trong quý của công ty:";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataMau);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1502, 88);
            panel4.TabIndex = 51;
            // 
            // dataMau
            // 
            dataMau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataMau.ColumnHeadersHeight = 40;
            dataMau.Columns.AddRange(new DataGridViewColumn[] { maNhanVien, hoVaTen, email, Sodienthoai, ngaySinh, chucVu });
            dataMau.Dock = DockStyle.Fill;
            dataMau.Location = new Point(0, 19);
            dataMau.Name = "dataMau";
            dataMau.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataMau.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataMau.RowHeadersVisible = false;
            dataMau.RowHeadersWidth = 100;
            dataMau.RowTemplate.Height = 24;
            dataMau.Size = new Size(1502, 69);
            dataMau.TabIndex = 1;
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
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // Sodienthoai
            // 
            Sodienthoai.HeaderText = "Số điện thoại";
            Sodienthoai.MinimumWidth = 6;
            Sodienthoai.Name = "Sodienthoai";
            Sodienthoai.ReadOnly = true;
            // 
            // ngaySinh
            // 
            ngaySinh.HeaderText = "Ngày sinh";
            ngaySinh.MinimumWidth = 6;
            ngaySinh.Name = "ngaySinh";
            ngaySinh.ReadOnly = true;
            // 
            // chucVu
            // 
            chucVu.HeaderText = "Chức vụ";
            chucVu.MinimumWidth = 6;
            chucVu.Name = "chucVu";
            chucVu.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 0;
            label2.Text = "Danh sách nhân viên";
            // 
            // baoCaoHieuSuat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1502, 782);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "baoCaoHieuSuat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo hiệu suất";
            WindowState = FormWindowState.Maximized;
            Load += baoCaoHieuSuat_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataMau).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataMau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVu;
        private Label label1;
        private TextBox txtMaNhanVien;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox txtTongHopDongTrongQuyCuaNv;
        private Label label7;
        private Label label9;
        private Label lblThongBao;
        private TextBox txtTongSoHopDongTrongQuyCuaCty;
        private Label label10;
        private ComboBox cmbQuy;
        private TextBox txtNam;
        private Label label11;
        private TextBox txtTongSoHopDongCty;
        private Label label12;
        private Panel panel3;
        private Panel panel4;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private SplitContainer splitContainer1;
    }
}