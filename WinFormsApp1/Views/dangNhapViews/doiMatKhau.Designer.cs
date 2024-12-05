namespace WinFormsApp1.Views
{
    partial class doiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doiMatKhau));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            matKhau1 = new TextBox();
            matKhau2 = new TextBox();
            xacNhanDoi = new Button();
            thongBaoLoi = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(89, 142, 108);
            label1.Location = new Point(100, 7);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 78);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 137);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 3;
            label3.Text = "Nhập lại mật khẩu ";
            // 
            // matKhau1
            // 
            matKhau1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            matKhau1.Location = new Point(43, 101);
            matKhau1.Margin = new Padding(3, 2, 3, 2);
            matKhau1.Name = "matKhau1";
            matKhau1.Size = new Size(282, 23);
            matKhau1.TabIndex = 2;
            // 
            // matKhau2
            // 
            matKhau2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            matKhau2.Location = new Point(43, 160);
            matKhau2.Margin = new Padding(3, 2, 3, 2);
            matKhau2.Name = "matKhau2";
            matKhau2.Size = new Size(282, 23);
            matKhau2.TabIndex = 4;
            // 
            // xacNhanDoi
            // 
            xacNhanDoi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            xacNhanDoi.BackColor = Color.DarkSeaGreen;
            xacNhanDoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xacNhanDoi.Location = new Point(98, 213);
            xacNhanDoi.Margin = new Padding(3, 2, 3, 2);
            xacNhanDoi.Name = "xacNhanDoi";
            xacNhanDoi.Size = new Size(172, 32);
            xacNhanDoi.TabIndex = 6;
            xacNhanDoi.Text = "Xác nhận đổi";
            xacNhanDoi.UseVisualStyleBackColor = false;
            xacNhanDoi.Click += xacNhanDoi_Click;
            // 
            // thongBaoLoi
            // 
            thongBaoLoi.AutoSize = true;
            thongBaoLoi.ForeColor = Color.Linen;
            thongBaoLoi.Location = new Point(29, 185);
            thongBaoLoi.Name = "thongBaoLoi";
            thongBaoLoi.Size = new Size(38, 15);
            thongBaoLoi.TabIndex = 5;
            thongBaoLoi.Text = "label4";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.back;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // doiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(374, 292);
            Controls.Add(pictureBox1);
            Controls.Add(thongBaoLoi);
            Controls.Add(xacNhanDoi);
            Controls.Add(matKhau2);
            Controls.Add(matKhau1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "doiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox matKhau1;
        private TextBox matKhau2;
        private Button xacNhanDoi;
        private Label thongBaoLoi;
        private PictureBox pictureBox1;
    }
}