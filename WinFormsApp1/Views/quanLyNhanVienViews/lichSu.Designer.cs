namespace WinFormsApp1.Views.quanLyNhanVienViews
{
    partial class lichSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lichSu));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            lblThongBao = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            dataGridViewHistory = new DataGridView();
            panelChucNang = new Panel();
            comboBoxThoiGian = new ComboBox();
            luuThemNV = new Button();
            pictureBox2 = new PictureBox();
            cbxChonBang = new ComboBox();
            txtTimKiem = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            panelChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblThongBao);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1273, 47);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 7);
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
            label8.Location = new Point(37, 12);
            label8.Name = "label8";
            label8.Size = new Size(175, 20);
            label8.TabIndex = 0;
            label8.Text = "Tra cứu lịch sử chỉnh sửa";
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Location = new Point(457, 18);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 15);
            lblThongBao.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panelChucNang);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(1273, 634);
            panel1.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Menu;
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(1273, 567);
            panel3.TabIndex = 26;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewHistory);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1273, 567);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách chỉnh sửa";
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Dock = DockStyle.Fill;
            dataGridViewHistory.Location = new Point(3, 23);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowHeadersVisible = false;
            dataGridViewHistory.RowHeadersWidth = 51;
            dataGridViewHistory.RowTemplate.Height = 24;
            dataGridViewHistory.Size = new Size(1267, 541);
            dataGridViewHistory.TabIndex = 0;
            // 
            // panelChucNang
            // 
            panelChucNang.Controls.Add(label2);
            panelChucNang.Controls.Add(label1);
            panelChucNang.Controls.Add(comboBoxThoiGian);
            panelChucNang.Controls.Add(luuThemNV);
            panelChucNang.Controls.Add(pictureBox2);
            panelChucNang.Controls.Add(cbxChonBang);
            panelChucNang.Controls.Add(txtTimKiem);
            panelChucNang.Dock = DockStyle.Top;
            panelChucNang.Location = new Point(0, 0);
            panelChucNang.Name = "panelChucNang";
            panelChucNang.Size = new Size(1273, 67);
            panelChucNang.TabIndex = 1;
            // 
            // comboBoxThoiGian
            // 
            comboBoxThoiGian.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxThoiGian.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxThoiGian.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxThoiGian.FormattingEnabled = true;
            comboBoxThoiGian.Location = new Point(157, 23);
            comboBoxThoiGian.Name = "comboBoxThoiGian";
            comboBoxThoiGian.Size = new Size(134, 23);
            comboBoxThoiGian.TabIndex = 0;
            // 
            // luuThemNV
            // 
            luuThemNV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            luuThemNV.BackColor = Color.FromArgb(89, 142, 108);
            luuThemNV.Cursor = Cursors.Hand;
            luuThemNV.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            luuThemNV.Location = new Point(1053, 19);
            luuThemNV.Name = "luuThemNV";
            luuThemNV.Size = new Size(82, 30);
            luuThemNV.TabIndex = 3;
            luuThemNV.Text = "Tìm kiếm";
            luuThemNV.UseVisualStyleBackColor = false;
            luuThemNV.Click += luuThemNV_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.search_interface_symbol;
            pictureBox2.Location = new Point(961, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // cbxChonBang
            // 
            cbxChonBang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbxChonBang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxChonBang.FormattingEnabled = true;
            cbxChonBang.Location = new Point(418, 24);
            cbxChonBang.Margin = new Padding(3, 2, 3, 2);
            cbxChonBang.Name = "cbxChonBang";
            cbxChonBang.Size = new Size(133, 23);
            cbxChonBang.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.ForeColor = Color.Black;
            txtTimKiem.Location = new Point(612, 21);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(371, 26);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_Enter;
            txtTimKiem.VisibleChanged += txtTimKiem_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(51, 24);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 21;
            label1.Text = "Mốc thời gian";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(306, 25);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 22;
            label2.Text = "Trường dữ liệu";
            // 
            // lichSu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 681);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "lichSu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch sử";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            panelChucNang.ResumeLayout(false);
            panelChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxThoiGian;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button luuThemNV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private ComboBox cbxChonBang;
        private Label lblThongBao;
        private GroupBox groupBox1;
        private Panel panelChucNang;
        private Label label1;
        private Label label2;
    }
}