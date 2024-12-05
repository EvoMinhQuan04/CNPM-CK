namespace WinFormsApp1.Views
{
    partial class quenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quenMatKhau));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            textBox2 = new TextBox();
            btnGetVerificationCode = new Button();
            btnXacThuc = new Button();
            thongBaoLoi = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(89, 142, 108);
            label1.Location = new Point(60, 6);
            label1.Name = "label1";
            label1.Size = new Size(258, 30);
            label1.TabIndex = 0;
            label1.Text = "KHÔI PHỤC MẬT KHẨU";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 68);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 1;
            label2.Text = "Mã người dùng/Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 3;
            label3.Text = "Mã xác nhận";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(15, 97);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(333, 23);
            txtUsername.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(14, 165);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 23);
            textBox2.TabIndex = 4;
            // 
            // btnGetVerificationCode
            // 
            btnGetVerificationCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetVerificationCode.BackColor = Color.DarkSeaGreen;
            btnGetVerificationCode.Font = new Font("Segoe UI", 11F);
            btnGetVerificationCode.Location = new Point(236, 159);
            btnGetVerificationCode.Margin = new Padding(3, 2, 3, 2);
            btnGetVerificationCode.Name = "btnGetVerificationCode";
            btnGetVerificationCode.Size = new Size(107, 36);
            btnGetVerificationCode.TabIndex = 5;
            btnGetVerificationCode.Text = "Lấy mã";
            btnGetVerificationCode.UseVisualStyleBackColor = false;
            btnGetVerificationCode.Click += btnGetVerificationCode_Click;
            // 
            // btnXacThuc
            // 
            btnXacThuc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnXacThuc.BackColor = Color.DarkSeaGreen;
            btnXacThuc.Font = new Font("Segoe UI", 11F);
            btnXacThuc.Location = new Point(12, 223);
            btnXacThuc.Margin = new Padding(3, 2, 3, 2);
            btnXacThuc.Name = "btnXacThuc";
            btnXacThuc.Size = new Size(336, 32);
            btnXacThuc.TabIndex = 7;
            btnXacThuc.Text = "Xác nhận";
            btnXacThuc.UseVisualStyleBackColor = false;
            btnXacThuc.Click += btnXacThuc_Click;
            // 
            // thongBaoLoi
            // 
            thongBaoLoi.AutoSize = true;
            thongBaoLoi.ForeColor = Color.Linen;
            thongBaoLoi.Location = new Point(15, 191);
            thongBaoLoi.Name = "thongBaoLoi";
            thongBaoLoi.Size = new Size(38, 15);
            thongBaoLoi.TabIndex = 6;
            thongBaoLoi.Text = "label4";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.back;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // quenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(356, 293);
            Controls.Add(pictureBox1);
            Controls.Add(thongBaoLoi);
            Controls.Add(btnXacThuc);
            Controls.Add(btnGetVerificationCode);
            Controls.Add(textBox2);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "quenMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên Mật Khẩu";
            FormClosing += quenMatKhau_FormClosing;
            Load += quenMatKhau_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox textBox2;
        private Button btnGetVerificationCode;
        private Button btnXacThuc;
        private Label thongBaoLoi;
        private PictureBox pictureBox1;
    }
}