using System;
using System.Windows.Forms;
using System.Drawing; // Thêm thư viện để sử dụng các thuộc tính màu và font

namespace WinFormsApp1.Views
{
    public partial class dangNhap// Đảm bảo lớp kế thừa từ Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangNhap));
            pictureBox1 = new PictureBox();
            btnDangNhapTaiKhoan = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logoUpdate;
            pictureBox1.Location = new Point(173, 100);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(687, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // btnDangNhapTaiKhoan
            // 
            btnDangNhapTaiKhoan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDangNhapTaiKhoan.BackColor = Color.FromArgb(89, 142, 108);
            btnDangNhapTaiKhoan.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhapTaiKhoan.ForeColor = Color.LavenderBlush;
            btnDangNhapTaiKhoan.Location = new Point(365, 536);
            btnDangNhapTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            btnDangNhapTaiKhoan.Name = "btnDangNhapTaiKhoan";
            btnDangNhapTaiKhoan.Size = new Size(360, 58);
            btnDangNhapTaiKhoan.TabIndex = 2;
            btnDangNhapTaiKhoan.Text = "ĐĂNG NHẬP VỚI TÀI KHOẢN";
            btnDangNhapTaiKhoan.UseVisualStyleBackColor = false;
            btnDangNhapTaiKhoan.UseWaitCursor = true;
            btnDangNhapTaiKhoan.Click += btnDangNhapTaiKhoan_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(348, 65);
            label2.Name = "label2";
            label2.Size = new Size(389, 32);
            label2.TabIndex = 0;
            label2.Text = "CHÀO MỪNG ĐẾN VỚI AIRELEAF";
            label2.UseWaitCursor = true;
            // 
            // dangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1028, 648);
            Controls.Add(label2);
            Controls.Add(btnDangNhapTaiKhoan);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "dangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AireLeaf";
            UseWaitCursor = true;
            FormClosing += dangNhap_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDangNhapTaiKhoan;
        private System.Windows.Forms.Label label2;
    }
}
