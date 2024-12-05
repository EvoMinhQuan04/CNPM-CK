namespace WinFormsApp1.Views.saoLuuPhucHoiViews
{
    partial class saoLuuPhucHoiControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saoLuuPhucHoiControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel6 = new Panel();
            rabPhieuTraHang = new RadioButton();
            rabKhachHang = new RadioButton();
            rabMauQuanTrac = new RadioButton();
            rabHopDong = new RadioButton();
            lblThongBao = new Label();
            btnHuyBo = new Button();
            btnPhucHoi = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBoxTimeRange = new ComboBox();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            labelUserName = new Label();
            pictureBox1 = new PictureBox();
            panelSaoLuuPhucHoiUC = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            dataSaoLuu = new DataGridView();
            label4 = new Label();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSaoLuuPhucHoiUC.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataSaoLuu).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(197, 219, 204);
            panel6.Controls.Add(rabPhieuTraHang);
            panel6.Controls.Add(rabKhachHang);
            panel6.Controls.Add(rabMauQuanTrac);
            panel6.Controls.Add(rabHopDong);
            panel6.Controls.Add(lblThongBao);
            panel6.Controls.Add(btnHuyBo);
            panel6.Controls.Add(btnPhucHoi);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(comboBoxTimeRange);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 59);
            panel6.Name = "panel6";
            panel6.Size = new Size(1299, 172);
            panel6.TabIndex = 1;
            // 
            // rabPhieuTraHang
            // 
            rabPhieuTraHang.AutoSize = true;
            rabPhieuTraHang.Font = new Font("Segoe UI", 12F);
            rabPhieuTraHang.Location = new Point(698, 67);
            rabPhieuTraHang.Name = "rabPhieuTraHang";
            rabPhieuTraHang.Size = new Size(129, 25);
            rabPhieuTraHang.TabIndex = 10;
            rabPhieuTraHang.TabStop = true;
            rabPhieuTraHang.Text = "Phiếu trả hàng";
            rabPhieuTraHang.UseVisualStyleBackColor = true;
            rabPhieuTraHang.CheckedChanged += rabPhieuTraHang_CheckedChanged;
            // 
            // rabKhachHang
            // 
            rabKhachHang.AutoSize = true;
            rabKhachHang.Font = new Font("Segoe UI", 12F);
            rabKhachHang.Location = new Point(507, 66);
            rabKhachHang.Name = "rabKhachHang";
            rabKhachHang.Size = new Size(178, 25);
            rabKhachHang.TabIndex = 6;
            rabKhachHang.TabStop = true;
            rabKhachHang.Text = "Thông tin khách hàng";
            rabKhachHang.UseVisualStyleBackColor = true;
            // 
            // rabMauQuanTrac
            // 
            rabMauQuanTrac.AutoSize = true;
            rabMauQuanTrac.Font = new Font("Segoe UI", 12F);
            rabMauQuanTrac.Location = new Point(353, 67);
            rabMauQuanTrac.Name = "rabMauQuanTrac";
            rabMauQuanTrac.Size = new Size(128, 25);
            rabMauQuanTrac.TabIndex = 5;
            rabMauQuanTrac.TabStop = true;
            rabMauQuanTrac.Text = "Mẫu quan trắc";
            rabMauQuanTrac.UseVisualStyleBackColor = true;
            // 
            // rabHopDong
            // 
            rabHopDong.AutoSize = true;
            rabHopDong.Font = new Font("Segoe UI", 12F);
            rabHopDong.Location = new Point(200, 67);
            rabHopDong.Name = "rabHopDong";
            rabHopDong.Size = new Size(98, 25);
            rabHopDong.TabIndex = 4;
            rabHopDong.TabStop = true;
            rabHopDong.Text = "Hợp đồng";
            rabHopDong.UseVisualStyleBackColor = true;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Location = new Point(407, 29);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 15);
            lblThongBao.TabIndex = 2;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Gray;
            btnHuyBo.Cursor = Cursors.Hand;
            btnHuyBo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuyBo.ForeColor = SystemColors.ControlLightLight;
            btnHuyBo.Location = new Point(204, 107);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(89, 34);
            btnHuyBo.TabIndex = 8;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnPhucHoi
            // 
            btnPhucHoi.BackColor = Color.FromArgb(89, 142, 108);
            btnPhucHoi.Cursor = Cursors.Hand;
            btnPhucHoi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhucHoi.ForeColor = SystemColors.ControlLightLight;
            btnPhucHoi.Location = new Point(359, 107);
            btnPhucHoi.Name = "btnPhucHoi";
            btnPhucHoi.Size = new Size(89, 34);
            btnPhucHoi.TabIndex = 9;
            btnPhucHoi.Text = "Phục hồi";
            btnPhucHoi.UseVisualStyleBackColor = false;
            btnPhucHoi.Click += btnPhucHoi_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(20, 113);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 7;
            label5.Text = "Thao tác";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(19, 67);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 3;
            label3.Text = "Loại dữ liệu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 24);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 0;
            label2.Text = "Phạm vi thời gian";
            // 
            // comboBoxTimeRange
            // 
            comboBoxTimeRange.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTimeRange.FormattingEnabled = true;
            comboBoxTimeRange.Location = new Point(200, 24);
            comboBoxTimeRange.Name = "comboBoxTimeRange";
            comboBoxTimeRange.Size = new Size(98, 23);
            comboBoxTimeRange.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(menuStrip1);
            panel2.Controls.Add(labelUserName);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1299, 59);
            panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.SeaShell;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(3, 1);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(295, 53);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
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
            // labelUserName
            // 
            labelUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelUserName.ForeColor = Color.FromArgb(89, 142, 108);
            labelUserName.Location = new Point(930, 22);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(25, 21);
            labelUserName.TabIndex = 0;
            labelUserName.Text = " A";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Image = Properties.Resources.avatar;
            pictureBox1.Location = new Point(1128, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelSaoLuuPhucHoiUC
            // 
            panelSaoLuuPhucHoiUC.Controls.Add(panel4);
            panelSaoLuuPhucHoiUC.Controls.Add(panel6);
            panelSaoLuuPhucHoiUC.Controls.Add(panel2);
            panelSaoLuuPhucHoiUC.Dock = DockStyle.Fill;
            panelSaoLuuPhucHoiUC.Location = new Point(0, 0);
            panelSaoLuuPhucHoiUC.Name = "panelSaoLuuPhucHoiUC";
            panelSaoLuuPhucHoiUC.Size = new Size(1299, 739);
            panelSaoLuuPhucHoiUC.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 231);
            panel4.Name = "panel4";
            panel4.Size = new Size(1299, 508);
            panel4.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataSaoLuu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1299, 487);
            panel1.TabIndex = 2;
            // 
            // dataSaoLuu
            // 
            dataSaoLuu.AllowUserToAddRows = false;
            dataSaoLuu.AllowUserToDeleteRows = false;
            dataSaoLuu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSaoLuu.BackgroundColor = Color.Snow;
            dataSaoLuu.ColumnHeadersHeight = 40;
            dataSaoLuu.Cursor = Cursors.Hand;
            dataSaoLuu.Dock = DockStyle.Fill;
            dataSaoLuu.Location = new Point(0, 0);
            dataSaoLuu.Name = "dataSaoLuu";
            dataSaoLuu.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataSaoLuu.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataSaoLuu.RowHeadersVisible = false;
            dataSaoLuu.RowHeadersWidth = 100;
            dataSaoLuu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataSaoLuu.RowTemplate.Height = 24;
            dataSaoLuu.Size = new Size(1299, 487);
            dataSaoLuu.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(280, 21);
            label4.TabIndex = 0;
            label4.Text = "Danh sách sao lưu và phục hồi dữ liệu";
            // 
            // saoLuuPhucHoiControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panelSaoLuuPhucHoiUC);
            Name = "saoLuuPhucHoiControl";
            Size = new Size(1299, 739);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSaoLuuPhucHoiUC.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataSaoLuu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Button btnHuyBo;
        private Button btnPhucHoi;
        private Label label5;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxTimeRange;
        private Panel panel2;
        private Label labelUserName;
        private PictureBox pictureBox1;
        private Label lblThongBao;
        private Panel panelSaoLuuPhucHoiUC;
        private Panel panel4;
        private Label label4;
        private RadioButton rabMauQuanTrac;
        private RadioButton rabHopDong;
        private RadioButton rabPhieuTraHang;
        private RadioButton rabKhachHang;
        private Panel panel1;
        private DataGridView dataSaoLuu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}

