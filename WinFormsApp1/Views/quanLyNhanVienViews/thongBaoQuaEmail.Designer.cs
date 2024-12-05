namespace WinFormsApp1.Views.quanLyNhanVienViews
{
    partial class thongBaoQuaEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thongBaoQuaEmail));
            label1 = new Label();
            cbxChonNhanVien = new ComboBox();
            txtTieuDe = new TextBox();
            txtNoiDung = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            btnGuiMail = new Button();
            iconXoa = new PictureBox();
            iconGanTep = new PictureBox();
            lblThongBao = new Label();
            lstGoiY = new ListBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconGanTep).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 0;
            label1.Text = "Email mới";
            // 
            // cbxChonNhanVien
            // 
            cbxChonNhanVien.Font = new Font("Segoe UI", 9F);
            cbxChonNhanVien.FormattingEnabled = true;
            cbxChonNhanVien.Location = new Point(15, 34);
            cbxChonNhanVien.Name = "cbxChonNhanVien";
            cbxChonNhanVien.Size = new Size(750, 23);
            cbxChonNhanVien.TabIndex = 1;
            cbxChonNhanVien.Text = "Chọn nhân viên";
            cbxChonNhanVien.TextUpdate += cbxChonNhanVien_TextUpdate;
            cbxChonNhanVien.Leave += cbxChonNhanVien_Leave;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Font = new Font("Segoe UI", 9F);
            txtTieuDe.Location = new Point(15, 121);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(750, 23);
            txtTieuDe.TabIndex = 3;
            txtTieuDe.Text = "Tiêu đề";
            // 
            // txtNoiDung
            // 
            txtNoiDung.BorderStyle = BorderStyle.FixedSingle;
            txtNoiDung.Font = new Font("Segoe UI", 9F);
            txtNoiDung.Location = new Point(15, 152);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(750, 220);
            txtNoiDung.TabIndex = 4;
            txtNoiDung.Text = "Nội dung";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuiMail
            // 
            btnGuiMail.BackColor = Color.FromArgb(89, 142, 108);
            btnGuiMail.Cursor = Cursors.Hand;
            btnGuiMail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuiMail.Location = new Point(15, 382);
            btnGuiMail.Name = "btnGuiMail";
            btnGuiMail.Size = new Size(105, 39);
            btnGuiMail.TabIndex = 5;
            btnGuiMail.Text = "Gửi Email";
            btnGuiMail.UseVisualStyleBackColor = false;
            btnGuiMail.Click += btnGuiMail_Click;
            // 
            // iconXoa
            // 
            iconXoa.Cursor = Cursors.Hand;
            iconXoa.Image = (Image)resources.GetObject("iconXoa.Image");
            iconXoa.Location = new Point(733, 386);
            iconXoa.Name = "iconXoa";
            iconXoa.Size = new Size(31, 33);
            iconXoa.SizeMode = PictureBoxSizeMode.Zoom;
            iconXoa.TabIndex = 12;
            iconXoa.TabStop = false;
            iconXoa.Click += iconXoa_Click;
            // 
            // iconGanTep
            // 
            iconGanTep.Cursor = Cursors.Hand;
            iconGanTep.Image = (Image)resources.GetObject("iconGanTep.Image");
            iconGanTep.Location = new Point(140, 385);
            iconGanTep.Name = "iconGanTep";
            iconGanTep.Size = new Size(31, 33);
            iconGanTep.SizeMode = PictureBoxSizeMode.Zoom;
            iconGanTep.TabIndex = 11;
            iconGanTep.TabStop = false;
            iconGanTep.Click += iconGanTep_Click;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Location = new Point(214, 394);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 15);
            lblThongBao.TabIndex = 6;
            // 
            // lstGoiY
            // 
            lstGoiY.FormattingEnabled = true;
            lstGoiY.ItemHeight = 15;
            lstGoiY.Location = new Point(147, 63);
            lstGoiY.Name = "lstGoiY";
            lstGoiY.Size = new Size(156, 49);
            lstGoiY.TabIndex = 2;
            lstGoiY.SelectedIndexChanged += lstGoiY_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Location = new Point(15, 66);
            label2.Name = "label2";
            label2.Size = new Size(126, 46);
            label2.TabIndex = 13;
            label2.Text = "Gợi ý tên khi nhập, vui lòng nhập đầy đủ tên nhân viên.";
            // 
            // thongBaoQuaEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(785, 445);
            Controls.Add(label2);
            Controls.Add(lstGoiY);
            Controls.Add(lblThongBao);
            Controls.Add(iconXoa);
            Controls.Add(iconGanTep);
            Controls.Add(btnGuiMail);
            Controls.Add(txtNoiDung);
            Controls.Add(txtTieuDe);
            Controls.Add(cbxChonNhanVien);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "thongBaoQuaEmail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông báo qua Email";
            ((System.ComponentModel.ISupportInitialize)iconXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconGanTep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxChonNhanVien;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuiMail;
        private System.Windows.Forms.PictureBox iconGanTep;
        private System.Windows.Forms.PictureBox iconXoa;
        private Label lblThongBao;
        private ListBox lstGoiY;
        private Label label2;
    }
}