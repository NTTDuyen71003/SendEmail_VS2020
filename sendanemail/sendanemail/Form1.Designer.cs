namespace sendanemail
{
    partial class DangNhap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Email = new System.Windows.Forms.Label();
            this.MaOTP = new System.Windows.Forms.Label();
            this.llbDangKy = new System.Windows.Forms.LinkLabel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtOtp = new System.Windows.Forms.TextBox();
            this.btnGuiMaOTP = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::sendanemail.Properties.Resources.output_onlinegiftools;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(386, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 385);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(52, 154);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(55, 21);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email:";
            // 
            // MaOTP
            // 
            this.MaOTP.AutoSize = true;
            this.MaOTP.BackColor = System.Drawing.Color.Transparent;
            this.MaOTP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaOTP.Location = new System.Drawing.Point(27, 272);
            this.MaOTP.Name = "MaOTP";
            this.MaOTP.Size = new System.Drawing.Size(80, 21);
            this.MaOTP.TabIndex = 2;
            this.MaOTP.Text = "Mã OTP:";
            // 
            // llbDangKy
            // 
            this.llbDangKy.AutoSize = true;
            this.llbDangKy.BackColor = System.Drawing.Color.Transparent;
            this.llbDangKy.LinkColor = System.Drawing.Color.White;
            this.llbDangKy.Location = new System.Drawing.Point(277, 328);
            this.llbDangKy.Name = "llbDangKy";
            this.llbDangKy.Size = new System.Drawing.Size(47, 13);
            this.llbDangKy.TabIndex = 4;
            this.llbDangKy.TabStop = true;
            this.llbDangKy.Text = "Đăng ký";
            this.llbDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDangKy_LinkClicked);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.Location = new System.Drawing.Point(113, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 32);
            this.txtEmail.TabIndex = 5;
            // 
            // txtOtp
            // 
            this.txtOtp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtOtp.Location = new System.Drawing.Point(113, 267);
            this.txtOtp.Name = "txtOtp";
            this.txtOtp.Size = new System.Drawing.Size(275, 32);
            this.txtOtp.TabIndex = 6;
            this.txtOtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtp_KeyPress);
            // 
            // btnGuiMaOTP
            // 
            this.btnGuiMaOTP.BackColor = System.Drawing.Color.Transparent;
            this.btnGuiMaOTP.Location = new System.Drawing.Point(405, 266);
            this.btnGuiMaOTP.Name = "btnGuiMaOTP";
            this.btnGuiMaOTP.Size = new System.Drawing.Size(78, 33);
            this.btnGuiMaOTP.TabIndex = 7;
            this.btnGuiMaOTP.Text = "Gửi mã OTP";
            this.btnGuiMaOTP.UseVisualStyleBackColor = false;
            this.btnGuiMaOTP.Click += new System.EventHandler(this.btnGuiMaOTP_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDangNhap.Location = new System.Drawing.Point(113, 315);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(114, 36);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(31, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật Khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMatKhau.Location = new System.Drawing.Point(113, 207);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(275, 32);
            this.txtMatKhau.TabIndex = 11;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sendanemail.Properties.Resources.sky_night;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 423);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnGuiMaOTP);
            this.Controls.Add(this.txtOtp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.llbDangKy);
            this.Controls.Add(this.MaOTP);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangNhap";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label MaOTP;
        private System.Windows.Forms.LinkLabel llbDangKy;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtOtp;
        private System.Windows.Forms.Button btnGuiMaOTP;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
    }
}

