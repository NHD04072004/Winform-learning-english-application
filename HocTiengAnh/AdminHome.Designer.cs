
namespace HocTiengAnh
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnDSHocVien = new System.Windows.Forms.Button();
            this.btnDSBaiHoc = new System.Windows.Forms.Button();
            this.btnDSKhoaHoc = new System.Windows.Forms.Button();
            this.dgvDSKhoaHoc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTongKQ = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTong = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTongHV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoaHoc)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.dgvDSKhoaHoc);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(906, 477);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 0;
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
            this.btnAccount.Size = new System.Drawing.Size(211, 82);
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
            this.btnDSHocVien.Size = new System.Drawing.Size(193, 69);
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
            this.btnDSBaiHoc.Size = new System.Drawing.Size(193, 69);
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
            this.btnDSKhoaHoc.Size = new System.Drawing.Size(193, 69);
            this.btnDSKhoaHoc.TabIndex = 0;
            this.btnDSKhoaHoc.Text = "KHÓA HỌC";
            this.btnDSKhoaHoc.UseVisualStyleBackColor = false;
            this.btnDSKhoaHoc.Click += new System.EventHandler(this.btnDSKhoaHoc_Click);
            // 
            // dgvDSKhoaHoc
            // 
            this.dgvDSKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhoaHoc.Location = new System.Drawing.Point(12, 207);
            this.dgvDSKhoaHoc.Name = "dgvDSKhoaHoc";
            this.dgvDSKhoaHoc.RowHeadersWidth = 51;
            this.dgvDSKhoaHoc.RowTemplate.Height = 24;
            this.dgvDSKhoaHoc.Size = new System.Drawing.Size(660, 258);
            this.dgvDSKhoaHoc.TabIndex = 2;
            this.dgvDSKhoaHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKhoaHoc_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblTongKQ);
            this.panel2.Location = new System.Drawing.Point(359, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 183);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "TỔNG SỐ KẾT QUẢ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 117);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblTongKQ
            // 
            this.lblTongKQ.AutoSize = true;
            this.lblTongKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongKQ.Location = new System.Drawing.Point(196, 44);
            this.lblTongKQ.Name = "lblTongKQ";
            this.lblTongKQ.Size = new System.Drawing.Size(36, 25);
            this.lblTongKQ.TabIndex = 1;
            this.lblTongKQ.Text = "??";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblTong);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTongHV);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 183);
            this.panel1.TabIndex = 0;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(48, 147);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(222, 25);
            this.lblTong.TabIndex = 2;
            this.lblTong.Text = "TỔNG SỐ HỌC VIÊN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 117);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTongHV
            // 
            this.lblTongHV.AutoSize = true;
            this.lblTongHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongHV.Location = new System.Drawing.Point(196, 44);
            this.lblTongHV.Name = "lblTongHV";
            this.lblTongHV.Size = new System.Drawing.Size(36, 25);
            this.lblTongHV.TabIndex = 0;
            this.lblTongHV.Text = "??";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 477);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdminHome";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoaHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnDSHocVien;
        private System.Windows.Forms.Button btnDSBaiHoc;
        private System.Windows.Forms.Button btnDSKhoaHoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongKQ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTongHV;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvDSKhoaHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTong;
    }
}