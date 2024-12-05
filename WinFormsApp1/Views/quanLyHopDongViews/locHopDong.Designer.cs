namespace WinFormsApp1
{
    partial class locHopDong
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locHopDong));
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            labelThongBao = new Label();
            comboBoxLoaiLoc = new ComboBox();
            comboBoxNgayKetThuc = new ComboBox();
            comboBoxNgayLap = new ComboBox();
            btnLamMoi = new Button();
            btnLoc = new Button();
            textBoxThongTin = new TextBox();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelThongBao);
            groupBox1.Controls.Add(comboBoxLoaiLoc);
            groupBox1.Controls.Add(comboBoxNgayKetThuc);
            groupBox1.Controls.Add(comboBoxNgayLap);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(textBoxThongTin);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(987, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(611, 16);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Ngày trả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(433, 16);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Ngày lập";
            // 
            // labelThongBao
            // 
            labelThongBao.AutoSize = true;
            labelThongBao.Location = new Point(28, 68);
            labelThongBao.Name = "labelThongBao";
            labelThongBao.Size = new Size(0, 15);
            labelThongBao.TabIndex = 9;
            // 
            // comboBoxLoaiLoc
            // 
            comboBoxLoaiLoc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLoaiLoc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxLoaiLoc.FormattingEnabled = true;
            comboBoxLoaiLoc.Items.AddRange(new object[] { "Mã hợp đồng", "Mã khách hàng", "Mã nhân viên", "Trạng thái hợp đồng" });
            comboBoxLoaiLoc.Location = new Point(107, 40);
            comboBoxLoaiLoc.Margin = new Padding(3, 2, 3, 2);
            comboBoxLoaiLoc.Name = "comboBoxLoaiLoc";
            comboBoxLoaiLoc.Size = new Size(147, 27);
            comboBoxLoaiLoc.TabIndex = 1;
            // 
            // comboBoxNgayKetThuc
            // 
            comboBoxNgayKetThuc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNgayKetThuc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxNgayKetThuc.FormattingEnabled = true;
            comboBoxNgayKetThuc.Location = new Point(611, 41);
            comboBoxNgayKetThuc.Margin = new Padding(3, 2, 3, 2);
            comboBoxNgayKetThuc.Name = "comboBoxNgayKetThuc";
            comboBoxNgayKetThuc.Size = new Size(154, 27);
            comboBoxNgayKetThuc.TabIndex = 6;
            // 
            // comboBoxNgayLap
            // 
            comboBoxNgayLap.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNgayLap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxNgayLap.FormattingEnabled = true;
            comboBoxNgayLap.Location = new Point(434, 41);
            comboBoxNgayLap.Margin = new Padding(3, 2, 3, 2);
            comboBoxNgayLap.Name = "comboBoxNgayLap";
            comboBoxNgayLap.Size = new Size(154, 27);
            comboBoxNgayLap.TabIndex = 4;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Gray;
            btnLamMoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = SystemColors.ControlLightLight;
            btnLamMoi.Location = new Point(788, 37);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 30);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(89, 142, 108);
            btnLoc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoc.ForeColor = SystemColors.ControlLightLight;
            btnLoc.Location = new Point(888, 37);
            btnLoc.Margin = new Padding(3, 2, 3, 2);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(73, 30);
            btnLoc.TabIndex = 8;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // textBoxThongTin
            // 
            textBoxThongTin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxThongTin.Location = new Point(260, 40);
            textBoxThongTin.Margin = new Padding(3, 2, 3, 2);
            textBoxThongTin.Name = "textBoxThongTin";
            textBoxThongTin.Size = new Size(165, 27);
            textBoxThongTin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 43);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // locHopDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 98);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "locHopDong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lọc Hợp Đồng";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLamMoi;
        private Button btnLoc;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBoxNgayLap;
        private ComboBox comboBoxNgayKetThuc;
        private ComboBox comboBoxLoaiLoc;
        private TextBox textBoxThongTin;
        private Label labelThongBao;
        private Label label3;
        private Label label2;
    }
}