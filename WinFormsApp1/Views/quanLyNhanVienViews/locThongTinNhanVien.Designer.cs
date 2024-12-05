namespace WinFormsApp1.Views.quanLyNhanVienViews
{
    partial class locThongTinNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locThongTinNhanVien));
            groupBox1 = new GroupBox();
            labelThongBao = new Label();
            btnHuy = new Button();
            btnLoc = new Button();
            label1 = new Label();
            comboBoxThuocTinh = new ComboBox();
            textBoxGiaTri = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(labelThongBao);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxThuocTinh);
            groupBox1.Controls.Add(textBoxGiaTri);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(634, 77);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // labelThongBao
            // 
            labelThongBao.AutoSize = true;
            labelThongBao.ForeColor = Color.Linen;
            labelThongBao.Location = new Point(8, 58);
            labelThongBao.Name = "labelThongBao";
            labelThongBao.Size = new Size(38, 15);
            labelThongBao.TabIndex = 5;
            labelThongBao.Text = "label2";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Gray;
            btnHuy.ForeColor = SystemColors.ControlLightLight;
            btnHuy.Location = new Point(431, 29);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(77, 30);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Làm mới";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(89, 142, 108);
            btnLoc.ForeColor = SystemColors.ControlLightLight;
            btnLoc.Location = new Point(522, 29);
            btnLoc.Margin = new Padding(3, 2, 3, 2);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(73, 30);
            btnLoc.TabIndex = 4;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(8, 31);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            // 
            // comboBoxThuocTinh
            // 
            comboBoxThuocTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxThuocTinh.FormattingEnabled = true;
            comboBoxThuocTinh.Items.AddRange(new object[] { "Mã khách hàng", "Tên công ty", "Địa chỉ", "Ký hiệu công ty", "Mã hợp đồng", "Số điện thoại", "Email" });
            comboBoxThuocTinh.Location = new Point(96, 31);
            comboBoxThuocTinh.Margin = new Padding(3, 2, 3, 2);
            comboBoxThuocTinh.Name = "comboBoxThuocTinh";
            comboBoxThuocTinh.Size = new Size(133, 23);
            comboBoxThuocTinh.TabIndex = 1;
            // 
            // textBoxGiaTri
            // 
            textBoxGiaTri.Location = new Point(249, 32);
            textBoxGiaTri.Margin = new Padding(3, 2, 3, 2);
            textBoxGiaTri.Name = "textBoxGiaTri";
            textBoxGiaTri.Size = new Size(164, 23);
            textBoxGiaTri.TabIndex = 2;
            // 
            // locThongTinNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 77);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "locThongTinNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lọc Thông Tin Khách Hàng";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelThongBao;
        private Button btnHuy;
        private Button btnLoc;
        private Label label1;
        private ComboBox comboBoxThuocTinh;
        private TextBox textBoxGiaTri;
    }
}