namespace HocTiengAnh
{
    partial class Dangky
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
            this.lblDangKy = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.lblGoiYDangKy = new System.Windows.Forms.Label();
            this.lblXacnhanPassword = new System.Windows.Forms.Label();
            this.tbXacnhanPassword = new System.Windows.Forms.TextBox();
            this.cbHienthimatkhau = new System.Windows.Forms.CheckBox();
            this.lbThongbaoloi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDangKy
            // 
            this.lblDangKy.AutoSize = true;
            this.lblDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblDangKy.Location = new System.Drawing.Point(112, 28);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(125, 31);
            this.lblDangKy.TabIndex = 1;
            this.lblDangKy.Text = "Đăng Ký";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(40, 80);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(119, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Tên đăng nhập";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(44, 103);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(266, 48);
            this.tbUsername.TabIndex = 4;
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(40, 237);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Mật khẩu";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(44, 260);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(266, 48);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(40, 159);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(44, 182);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(266, 48);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(112, 529);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(136, 35);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(112, 444);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(136, 35);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // lblGoiYDangKy
            // 
            this.lblGoiYDangKy.AutoSize = true;
            this.lblGoiYDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoiYDangKy.Location = new System.Drawing.Point(87, 493);
            this.lblGoiYDangKy.Name = "lblGoiYDangKy";
            this.lblGoiYDangKy.Size = new System.Drawing.Size(190, 20);
            this.lblGoiYDangKy.TabIndex = 11;
            this.lblGoiYDangKy.Text = "Bạn đã có tài khoản rồi?";
            // 
            // lblXacnhanPassword
            // 
            this.lblXacnhanPassword.AutoSize = true;
            this.lblXacnhanPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXacnhanPassword.Location = new System.Drawing.Point(40, 314);
            this.lblXacnhanPassword.Name = "lblXacnhanPassword";
            this.lblXacnhanPassword.Size = new System.Drawing.Size(174, 20);
            this.lblXacnhanPassword.TabIndex = 12;
            this.lblXacnhanPassword.Text = "Xác nhận lại mật khẩu";
            this.lblXacnhanPassword.Click += new System.EventHandler(this.lblXacnhanPassword_Click);
            // 
            // tbXacnhanPassword
            // 
            this.tbXacnhanPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbXacnhanPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXacnhanPassword.Location = new System.Drawing.Point(44, 337);
            this.tbXacnhanPassword.Multiline = true;
            this.tbXacnhanPassword.Name = "tbXacnhanPassword";
            this.tbXacnhanPassword.Size = new System.Drawing.Size(266, 48);
            this.tbXacnhanPassword.TabIndex = 13;
            this.tbXacnhanPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbXacnhanPassword_Validating);
            // 
            // cbHienthimatkhau
            // 
            this.cbHienthimatkhau.AutoSize = true;
            this.cbHienthimatkhau.Location = new System.Drawing.Point(44, 412);
            this.cbHienthimatkhau.Name = "cbHienthimatkhau";
            this.cbHienthimatkhau.Size = new System.Drawing.Size(130, 20);
            this.cbHienthimatkhau.TabIndex = 14;
            this.cbHienthimatkhau.Text = "Hiển thị mật khẩu";
            this.cbHienthimatkhau.UseVisualStyleBackColor = true;
            this.cbHienthimatkhau.CheckedChanged += new System.EventHandler(this.cbHienthimatkhau_CheckedChanged);
            // 
            // lbThongbaoloi
            // 
            this.lbThongbaoloi.AutoSize = true;
            this.lbThongbaoloi.Location = new System.Drawing.Point(41, 390);
            this.lbThongbaoloi.Name = "lbThongbaoloi";
            this.lbThongbaoloi.Size = new System.Drawing.Size(0, 16);
            this.lbThongbaoloi.TabIndex = 15;
            // 
            // Dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 586);
            this.Controls.Add(this.lbThongbaoloi);
            this.Controls.Add(this.cbHienthimatkhau);
            this.Controls.Add(this.tbXacnhanPassword);
            this.Controls.Add(this.lblXacnhanPassword);
            this.Controls.Add(this.lblGoiYDangKy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDangKy);
            this.Name = "Dangky";
            this.Text = "Đăng Ký";
            this.Load += new System.EventHandler(this.Dangky_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangKy;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label lblGoiYDangKy;
        private System.Windows.Forms.Label lblXacnhanPassword;
        private System.Windows.Forms.TextBox tbXacnhanPassword;
        private System.Windows.Forms.CheckBox cbHienthimatkhau;
        private System.Windows.Forms.Label lbThongbaoloi;
    }
}