namespace WinFormsApp1.Views
{
    partial class ucTrangChu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTrangChu));
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            txtHienThiTen1 = new Label();
            avatar = new PictureBox();
            lblHienThiTen = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel_chatbot_show = new Panel();
            richTextBox1 = new RichTextBox();
            txtInput = new TextBox();
            button15 = new Button();
            panel7 = new Panel();
            pictureBox2 = new PictureBox();
            header_chatbot = new Label();
            panelContent = new Panel();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_chatbot_show.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(menuStrip1);
            panel2.Controls.Add(txtHienThiTen1);
            panel2.Controls.Add(avatar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 59);
            panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.SeaShell;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(295, 53);
            menuStrip1.TabIndex = 2;
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
            // txtHienThiTen1
            // 
            txtHienThiTen1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtHienThiTen1.AutoSize = true;
            txtHienThiTen1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHienThiTen1.ForeColor = Color.FromArgb(89, 142, 108);
            txtHienThiTen1.Location = new Point(939, 22);
            txtHienThiTen1.Name = "txtHienThiTen1";
            txtHienThiTen1.Size = new Size(25, 21);
            txtHienThiTen1.TabIndex = 0;
            txtHienThiTen1.Text = " A";
            // 
            // avatar
            // 
            avatar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            avatar.Image = Properties.Resources.mat;
            avatar.Location = new Point(1138, 1);
            avatar.Margin = new Padding(3, 2, 3, 2);
            avatar.Name = "avatar";
            avatar.Size = new Size(74, 56);
            avatar.SizeMode = PictureBoxSizeMode.Zoom;
            avatar.TabIndex = 0;
            avatar.TabStop = false;
            // 
            // lblHienThiTen
            // 
            lblHienThiTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHienThiTen.AutoSize = true;
            lblHienThiTen.BackColor = SystemColors.ControlLightLight;
            lblHienThiTen.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblHienThiTen.ForeColor = Color.FromArgb(89, 142, 108);
            lblHienThiTen.Location = new Point(172, 8);
            lblHienThiTen.Name = "lblHienThiTen";
            lblHienThiTen.Size = new Size(169, 32);
            lblHienThiTen.TabIndex = 1;
            lblHienThiTen.Text = "Nguyễn Văn A";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(46, 8);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 0;
            label1.Text = "Xin chào, ";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel_chatbot_show);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 636);
            panel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblHienThiTen);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(939, 636);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logoChim;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(939, 636);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel_chatbot_show
            // 
            panel_chatbot_show.Controls.Add(richTextBox1);
            panel_chatbot_show.Controls.Add(txtInput);
            panel_chatbot_show.Controls.Add(button15);
            panel_chatbot_show.Controls.Add(panel7);
            panel_chatbot_show.Dock = DockStyle.Right;
            panel_chatbot_show.Location = new Point(939, 0);
            panel_chatbot_show.Margin = new Padding(3, 2, 3, 2);
            panel_chatbot_show.Name = "panel_chatbot_show";
            panel_chatbot_show.Size = new Size(373, 636);
            panel_chatbot_show.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.SeaShell;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 12F);
            richTextBox1.Location = new Point(0, 91);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(373, 474);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.Snow;
            txtInput.Dock = DockStyle.Bottom;
            txtInput.Font = new Font("Segoe UI", 11F);
            txtInput.Location = new Point(0, 565);
            txtInput.Margin = new Padding(3, 2, 3, 2);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(373, 38);
            txtInput.TabIndex = 2;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(89, 142, 108);
            button15.Dock = DockStyle.Bottom;
            button15.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.ForeColor = SystemColors.Control;
            button15.Location = new Point(0, 603);
            button15.Margin = new Padding(3, 2, 3, 2);
            button15.Name = "button15";
            button15.Size = new Size(373, 33);
            button15.TabIndex = 3;
            button15.Text = "Gửi";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click_1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(197, 219, 204);
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(header_chatbot);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(373, 91);
            panel7.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.chatbot2;
            pictureBox2.Location = new Point(4, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // header_chatbot
            // 
            header_chatbot.AutoSize = true;
            header_chatbot.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header_chatbot.ForeColor = SystemColors.ControlDarkDark;
            header_chatbot.Location = new Point(92, 32);
            header_chatbot.Name = "header_chatbot";
            header_chatbot.Size = new Size(202, 30);
            header_chatbot.TabIndex = 0;
            header_chatbot.Text = "Chatbot thông báo";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panel1);
            panelContent.Controls.Add(panel2);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1312, 695);
            panelContent.TabIndex = 5;
            // 
            // ucTrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panelContent);
            Name = "ucTrangChu";
            Size = new Size(1312, 695);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_chatbot_show.ResumeLayout(false);
            panel_chatbot_show.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblHienThiTen;
        private Label label1;
        private Label txtHienThiTen1;
        private PictureBox avatar;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel_chatbot_show;
        private RichTextBox richTextBox1;
        private TextBox txtInput;
        private Button button15;
        private Panel panel7;
        private PictureBox pictureBox2;
        private Label header_chatbot;
        private Panel panelContent;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
