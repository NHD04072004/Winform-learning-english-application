
namespace HocTiengAnh
{
    partial class AdminHocVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHocVien));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnDSHocVien = new System.Windows.Forms.Button();
            this.btnDSBaiHoc = new System.Windows.Forms.Button();
            this.btnDSKhoaHoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHocVien = new System.Windows.Forms.DataGridView();
            this.lblDSHocVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel2.Controls.Add(this.btnSua);
            this.splitContainer1.Panel2.Controls.Add(this.btnThem);
            this.splitContainer1.Panel2.Controls.Add(this.dgvHocVien);
            this.splitContainer1.Panel2.Controls.Add(this.lblDSHocVien);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(821, 466);
            this.splitContainer1.SplitterDistance = 197;
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
            this.btnAccount.Size = new System.Drawing.Size(190, 71);
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
            this.btnDSHocVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDSHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSHocVien.Location = new System.Drawing.Point(12, 207);
            this.btnDSHocVien.Name = "btnDSHocVien";
            this.btnDSHocVien.Size = new System.Drawing.Size(172, 58);
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
            this.btnDSBaiHoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDSBaiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSBaiHoc.Location = new System.Drawing.Point(12, 126);
            this.btnDSBaiHoc.Name = "btnDSBaiHoc";
            this.btnDSBaiHoc.Size = new System.Drawing.Size(172, 58);
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
            this.btnDSKhoaHoc.Size = new System.Drawing.Size(172, 58);
            this.btnDSKhoaHoc.TabIndex = 0;
            this.btnDSKhoaHoc.Text = "KHÓA HỌC";
            this.btnDSKhoaHoc.UseVisualStyleBackColor = false;
            this.btnDSKhoaHoc.Click += new System.EventHandler(this.btnDSKhoaHoc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(488, 389);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 52);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(367, 389);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 52);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(246, 389);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 52);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvHocVien
            // 
            this.dgvHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocVien.Location = new System.Drawing.Point(24, 85);
            this.dgvHocVien.Name = "dgvHocVien";
            this.dgvHocVien.RowHeadersWidth = 51;
            this.dgvHocVien.RowTemplate.Height = 24;
            this.dgvHocVien.Size = new System.Drawing.Size(579, 271);
            this.dgvHocVien.TabIndex = 6;
            // 
            // lblDSHocVien
            // 
            this.lblDSHocVien.AutoSize = true;
            this.lblDSHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSHocVien.Location = new System.Drawing.Point(18, 25);
            this.lblDSHocVien.Name = "lblDSHocVien";
            this.lblDSHocVien.Size = new System.Drawing.Size(338, 32);
            this.lblDSHocVien.TabIndex = 5;
            this.lblDSHocVien.Text = "DANH SÁCH HỌC VIÊN";
            // 
            // AdminHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 466);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdminHocVien";
            this.Text = "AdminHocVien";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvHocVien;
        private System.Windows.Forms.Label lblDSHocVien;
    }
}