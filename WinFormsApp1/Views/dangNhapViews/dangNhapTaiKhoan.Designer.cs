namespace WinFormsApp1.Views
{
    partial class dangNhapTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangNhapTaiKhoan));
            label1 = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            xacNhan = new Button();
            toolTip1 = new ToolTip(components);
            checkBoxHien = new CheckBox();
            lblThongBao = new Label();
            panelForm = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panelForm.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 3);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(89, 142, 108);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 20, 45, 0);
            label1.Size = new Size(337, 197);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTaiKhoan
            // 
            tableLayoutPanel1.SetColumnSpan(txtTaiKhoan, 2);
            txtTaiKhoan.Dock = DockStyle.Fill;
            txtTaiKhoan.Location = new Point(5, 202);
            txtTaiKhoan.Margin = new Padding(5);
            txtTaiKhoan.Multiline = true;
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(298, 27);
            txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            tableLayoutPanel1.SetColumnSpan(txtMatKhau, 2);
            txtMatKhau.Dock = DockStyle.Fill;
            txtMatKhau.Location = new Point(5, 239);
            txtMatKhau.Margin = new Padding(5);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(298, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // xacNhan
            // 
            xacNhan.BackColor = Color.DarkSeaGreen;
            xacNhan.Dock = DockStyle.Fill;
            xacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xacNhan.Location = new Point(157, 273);
            xacNhan.Margin = new Padding(3, 2, 3, 2);
            xacNhan.Name = "xacNhan";
            xacNhan.Size = new Size(148, 37);
            xacNhan.TabIndex = 6;
            xacNhan.Text = "Xác nhận";
            xacNhan.UseVisualStyleBackColor = false;
            xacNhan.Click += xacNhan_Click;
            // 
            // checkBoxHien
            // 
            checkBoxHien.Dock = DockStyle.Fill;
            checkBoxHien.ForeColor = Color.Linen;
            checkBoxHien.Location = new Point(313, 236);
            checkBoxHien.Margin = new Padding(5, 2, 5, 2);
            checkBoxHien.Name = "checkBoxHien";
            checkBoxHien.Padding = new Padding(10, 10, 0, 10);
            checkBoxHien.Size = new Size(25, 33);
            checkBoxHien.TabIndex = 4;
            checkBoxHien.Text = "checkBox1";
            checkBoxHien.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxHien.UseVisualStyleBackColor = true;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.ForeColor = Color.Linen;
            lblThongBao.Location = new Point(3, 312);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(74, 15);
            lblThongBao.TabIndex = 0;
            lblThongBao.Text = "lblThongBao";
            // 
            // panelForm
            // 
            panelForm.Controls.Add(tableLayoutPanel1);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(351, 3);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(343, 491);
            panelForm.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(lblThongBao, 0, 4);
            tableLayoutPanel1.Controls.Add(checkBoxHien, 2, 2);
            tableLayoutPanel1.Controls.Add(txtMatKhau, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTaiKhoan, 0, 1);
            tableLayoutPanel1.Controls.Add(xacNhan, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.2068634F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.54027939F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.54027939F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.543957F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.543957F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.543957F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.540354F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.540354F));
            tableLayoutPanel1.Size = new Size(343, 491);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Linen;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(89, 142, 108);
            label2.Location = new Point(3, 271);
            label2.Name = "label2";
            label2.Size = new Size(148, 41);
            label2.TabIndex = 5;
            label2.Text = "Quên mật khẩu?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 491);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logoUpdate;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 491);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panelForm, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(697, 497);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // dangNhapTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(697, 497);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "dangNhapTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập Tài Khoản";
            FormClosing += dangNhapTaiKhoan_FormClosing;
            panelForm.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button xacNhan;
        private ToolTip toolTip1;
        private CheckBox checkBoxHien;
        private Label lblThongBao;
        private Panel panelForm;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
  
    }
}