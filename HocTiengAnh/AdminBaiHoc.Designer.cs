
namespace HocTiengAnh
{
    partial class AdminBaiHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBaiHoc));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnDSHocVien = new System.Windows.Forms.Button();
            this.btnDSBaiHoc = new System.Windows.Forms.Button();
            this.btnDSKhoaHoc = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTenBaiHoc = new System.Windows.Forms.TextBox();
            this.lblTenBaiHoc = new System.Windows.Forms.Label();
            this.txtMaBaiHoc = new System.Windows.Forms.TextBox();
            this.lblMaBaiHoc = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblDSBaiHoc = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnDSBaiHoc);
            this.splitContainer1.Panel1.Controls.Add(this.btnDSKhoaHoc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.txtTenBaiHoc);
            this.splitContainer1.Panel2.Controls.Add(this.lblTenBaiHoc);
            this.splitContainer1.Panel2.Controls.Add(this.txtMaBaiHoc);
            this.splitContainer1.Panel2.Controls.Add(this.lblMaBaiHoc);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel2.Controls.Add(this.btnSua);
            this.splitContainer1.Panel2.Controls.Add(this.btnThem);
            this.splitContainer1.Panel2.Controls.Add(this.lblDSBaiHoc);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(847, 473);
            this.splitContainer1.SplitterDistance = 202;
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
            this.btnAccount.Size = new System.Drawing.Size(195, 78);
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
            this.btnDSHocVien.Location = new System.Drawing.Point(12, 207);
            this.btnDSHocVien.Name = "btnDSHocVien";
            this.btnDSHocVien.Size = new System.Drawing.Size(177, 65);
            this.btnDSHocVien.TabIndex = 2;
            this.btnDSHocVien.Text = "HỌC VIÊN";
            this.btnDSHocVien.UseVisualStyleBackColor = false;
            this.btnDSHocVien.Click += new System.EventHandler(this.btnDSHocVien_Click);
            // 
            // btnDSBaiHoc
            // 
            this.btnDSBaiHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDSBaiHoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDSBaiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSBaiHoc.Location = new System.Drawing.Point(12, 126);
            this.btnDSBaiHoc.Name = "btnDSBaiHoc";
            this.btnDSBaiHoc.Size = new System.Drawing.Size(177, 65);
            this.btnDSBaiHoc.TabIndex = 1;
            this.btnDSBaiHoc.Text = "BÀI HỌC";
            this.btnDSBaiHoc.UseVisualStyleBackColor = false;
            this.btnDSBaiHoc.Click += new System.EventHandler(this.btnDSBaiHoc_Click);
            // 
            // btnDSKhoaHoc
            // 
            this.btnDSKhoaHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDSKhoaHoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDSKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSKhoaHoc.Location = new System.Drawing.Point(12, 43);
            this.btnDSKhoaHoc.Name = "btnDSKhoaHoc";
            this.btnDSKhoaHoc.Size = new System.Drawing.Size(177, 65);
            this.btnDSKhoaHoc.TabIndex = 0;
            this.btnDSKhoaHoc.Text = "KHÓA HỌC";
            this.btnDSKhoaHoc.UseVisualStyleBackColor = false;
            this.btnDSKhoaHoc.Click += new System.EventHandler(this.btnDSKhoaHoc_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(610, 285);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // txtTenBaiHoc
            // 
            this.txtTenBaiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBaiHoc.Location = new System.Drawing.Point(434, 75);
            this.txtTenBaiHoc.Name = "txtTenBaiHoc";
            this.txtTenBaiHoc.Size = new System.Drawing.Size(175, 27);
            this.txtTenBaiHoc.TabIndex = 13;
            // 
            // lblTenBaiHoc
            // 
            this.lblTenBaiHoc.AutoSize = true;
            this.lblTenBaiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBaiHoc.Location = new System.Drawing.Point(319, 78);
            this.lblTenBaiHoc.Name = "lblTenBaiHoc";
            this.lblTenBaiHoc.Size = new System.Drawing.Size(101, 20);
            this.lblTenBaiHoc.TabIndex = 12;
            this.lblTenBaiHoc.Text = "Tên bài học:";
            // 
            // txtMaBaiHoc
            // 
            this.txtMaBaiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBaiHoc.Location = new System.Drawing.Point(128, 75);
            this.txtMaBaiHoc.Name = "txtMaBaiHoc";
            this.txtMaBaiHoc.Size = new System.Drawing.Size(147, 27);
            this.txtMaBaiHoc.TabIndex = 11;
            // 
            // lblMaBaiHoc
            // 
            this.lblMaBaiHoc.AutoSize = true;
            this.lblMaBaiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBaiHoc.Location = new System.Drawing.Point(15, 78);
            this.lblMaBaiHoc.Name = "lblMaBaiHoc";
            this.lblMaBaiHoc.Size = new System.Drawing.Size(96, 20);
            this.lblMaBaiHoc.TabIndex = 10;
            this.lblMaBaiHoc.Text = "Mã bài học:";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(485, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 52);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(364, 399);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 52);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(243, 399);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 52);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblDSBaiHoc
            // 
            this.lblDSBaiHoc.AutoSize = true;
            this.lblDSBaiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSBaiHoc.Location = new System.Drawing.Point(15, 25);
            this.lblDSBaiHoc.Name = "lblDSBaiHoc";
            this.lblDSBaiHoc.Size = new System.Drawing.Size(317, 32);
            this.lblDSBaiHoc.TabIndex = 5;
            this.lblDSBaiHoc.Text = "DANH SÁCH BÀI HỌC";
            // 
            // AdminBaiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 473);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdminBaiHoc";
            this.Text = "AdminBaiHoc";
            this.Load += new System.EventHandler(this.AdminBaiHoc_Load);
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
        private System.Windows.Forms.Button btnDSBaiHoc;
        private System.Windows.Forms.Button btnDSKhoaHoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblDSBaiHoc;
        private System.Windows.Forms.TextBox txtTenBaiHoc;
        private System.Windows.Forms.Label lblTenBaiHoc;
        private System.Windows.Forms.TextBox txtMaBaiHoc;
        private System.Windows.Forms.Label lblMaBaiHoc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}