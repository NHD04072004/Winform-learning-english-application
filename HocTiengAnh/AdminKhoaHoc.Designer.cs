
namespace HocTiengAnh
{
    partial class AdminKhoaHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminKhoaHoc));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnDSHocVien = new System.Windows.Forms.Button();
            this.btnDSKhoaHoc = new System.Windows.Forms.Button();
            this.flpDSKhoaHoc = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTenKhoaHoc = new System.Windows.Forms.TextBox();
            this.lblTenKhoaHoc = new System.Windows.Forms.Label();
            this.txtMaKhoaHoc = new System.Windows.Forms.TextBox();
            this.lblMaKhoaHoc = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblDSKhoaHoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.btnAccount);
            this.splitContainer1.Panel1.Controls.Add(this.btnDSHocVien);
            this.splitContainer1.Panel1.Controls.Add(this.btnDSKhoaHoc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flpDSKhoaHoc);
            this.splitContainer1.Panel2.Controls.Add(this.txtTenKhoaHoc);
            this.splitContainer1.Panel2.Controls.Add(this.lblTenKhoaHoc);
            this.splitContainer1.Panel2.Controls.Add(this.txtMaKhoaHoc);
            this.splitContainer1.Panel2.Controls.Add(this.lblMaKhoaHoc);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel2.Controls.Add(this.btnSua);
            this.splitContainer1.Panel2.Controls.Add(this.btnThem);
            this.splitContainer1.Panel2.Controls.Add(this.lblDSKhoaHoc);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(836, 482);
            this.splitContainer1.SplitterDistance = 201;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.Location = new System.Drawing.Point(4, 392);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(194, 87);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "ADMIN";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // btnDSHocVien
            // 
            this.btnDSHocVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDSHocVien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDSHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSHocVien.Location = new System.Drawing.Point(12, 126);
            this.btnDSHocVien.Name = "btnDSHocVien";
            this.btnDSHocVien.Size = new System.Drawing.Size(176, 74);
            this.btnDSHocVien.TabIndex = 2;
            this.btnDSHocVien.Text = "HỌC VIÊN";
            this.btnDSHocVien.UseVisualStyleBackColor = false;
            this.btnDSHocVien.Click += new System.EventHandler(this.btnDSHocVien_Click);
            // 
            // btnDSKhoaHoc
            // 
            this.btnDSKhoaHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDSKhoaHoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDSKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSKhoaHoc.Location = new System.Drawing.Point(12, 43);
            this.btnDSKhoaHoc.Name = "btnDSKhoaHoc";
            this.btnDSKhoaHoc.Size = new System.Drawing.Size(176, 74);
            this.btnDSKhoaHoc.TabIndex = 0;
            this.btnDSKhoaHoc.Text = "KHÓA HỌC";
            this.btnDSKhoaHoc.UseVisualStyleBackColor = false;
            this.btnDSKhoaHoc.Click += new System.EventHandler(this.btnDSKhoaHoc_Click);
            // 
            // flpDSKhoaHoc
            // 
            this.flpDSKhoaHoc.Location = new System.Drawing.Point(20, 126);
            this.flpDSKhoaHoc.Name = "flpDSKhoaHoc";
            this.flpDSKhoaHoc.Size = new System.Drawing.Size(599, 287);
            this.flpDSKhoaHoc.TabIndex = 9;
            // 
            // txtTenKhoaHoc
            // 
            this.txtTenKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoaHoc.Location = new System.Drawing.Point(444, 80);
            this.txtTenKhoaHoc.Name = "txtTenKhoaHoc";
            this.txtTenKhoaHoc.Size = new System.Drawing.Size(175, 27);
            this.txtTenKhoaHoc.TabIndex = 8;
            // 
            // lblTenKhoaHoc
            // 
            this.lblTenKhoaHoc.AutoSize = true;
            this.lblTenKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhoaHoc.Location = new System.Drawing.Point(321, 83);
            this.lblTenKhoaHoc.Name = "lblTenKhoaHoc";
            this.lblTenKhoaHoc.Size = new System.Drawing.Size(114, 20);
            this.lblTenKhoaHoc.TabIndex = 7;
            this.lblTenKhoaHoc.Text = "Tên khóa học:";
            // 
            // txtMaKhoaHoc
            // 
            this.txtMaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoaHoc.Location = new System.Drawing.Point(138, 80);
            this.txtMaKhoaHoc.Name = "txtMaKhoaHoc";
            this.txtMaKhoaHoc.Size = new System.Drawing.Size(147, 27);
            this.txtMaKhoaHoc.TabIndex = 6;
            // 
            // lblMaKhoaHoc
            // 
            this.lblMaKhoaHoc.AutoSize = true;
            this.lblMaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhoaHoc.Location = new System.Drawing.Point(16, 83);
            this.lblMaKhoaHoc.Name = "lblMaKhoaHoc";
            this.lblMaKhoaHoc.Size = new System.Drawing.Size(109, 20);
            this.lblMaKhoaHoc.TabIndex = 5;
            this.lblMaKhoaHoc.Text = "Mã khóa học:";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(504, 419);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 52);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(383, 419);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 52);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(262, 419);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 52);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblDSKhoaHoc
            // 
            this.lblDSKhoaHoc.AutoSize = true;
            this.lblDSKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSKhoaHoc.Location = new System.Drawing.Point(21, 28);
            this.lblDSKhoaHoc.Name = "lblDSKhoaHoc";
            this.lblDSKhoaHoc.Size = new System.Drawing.Size(381, 32);
            this.lblDSKhoaHoc.TabIndex = 0;
            this.lblDSKhoaHoc.Text = "CÁC KHÓA HỌC CỦA BẠN";
            // 
            // AdminKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 482);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdminKhoaHoc";
            this.Text = "AdminKhoaHoc";
            this.Load += new System.EventHandler(this.AdminKhoaHoc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnDSHocVien;
        private System.Windows.Forms.Button btnDSKhoaHoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblDSKhoaHoc;
        private System.Windows.Forms.TextBox txtTenKhoaHoc;
        private System.Windows.Forms.Label lblTenKhoaHoc;
        private System.Windows.Forms.TextBox txtMaKhoaHoc;
        private System.Windows.Forms.Label lblMaKhoaHoc;
        private System.Windows.Forms.FlowLayoutPanel flpDSKhoaHoc;
    }
}