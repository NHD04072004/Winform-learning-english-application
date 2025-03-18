
namespace HocTiengAnh
{
    partial class DsBaiHoc
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnDSKH_user = new System.Windows.Forms.Button();
            this.btnDSKHoaHoc = new System.Windows.Forms.Button();
            this.flpDSBaiHoc = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDSBaiHoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(-15, -8);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.btnAccount);
            this.splitContainer1.Panel1.Controls.Add(this.btnDSKH_user);
            this.splitContainer1.Panel1.Controls.Add(this.btnDSKHoaHoc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flpDSBaiHoc);
            this.splitContainer1.Panel2.Controls.Add(this.lblDSBaiHoc);
            this.splitContainer1.Size = new System.Drawing.Size(1441, 938);
            this.splitContainer1.SplitterDistance = 399;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Image = global::HocTiengAnh.Properties.Resources.z6394803753249_fd6515512734cfc9c93b1415f52f6174;
            this.btnAccount.Location = new System.Drawing.Point(84, 817);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(242, 58);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "<user name>";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // btnDSKH_user
            // 
            this.btnDSKH_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSKH_user.Location = new System.Drawing.Point(15, 351);
            this.btnDSKH_user.Name = "btnDSKH_user";
            this.btnDSKH_user.Size = new System.Drawing.Size(339, 116);
            this.btnDSKH_user.TabIndex = 1;
            this.btnDSKH_user.Text = "KHÓA HỌC CỦA BẠN";
            this.btnDSKH_user.UseVisualStyleBackColor = true;
            this.btnDSKH_user.Click += new System.EventHandler(this.btnDSKH_user_Click);
            // 
            // btnDSKHoaHoc
            // 
            this.btnDSKHoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSKHoaHoc.Location = new System.Drawing.Point(15, 214);
            this.btnDSKHoaHoc.Name = "btnDSKHoaHoc";
            this.btnDSKHoaHoc.Size = new System.Drawing.Size(339, 112);
            this.btnDSKHoaHoc.TabIndex = 0;
            this.btnDSKHoaHoc.Text = "KHÓA HỌC";
            this.btnDSKHoaHoc.UseVisualStyleBackColor = true;
            this.btnDSKHoaHoc.Click += new System.EventHandler(this.btnDSKHoaHoc_Click);
            // 
            // flpDSBaiHoc
            // 
            this.flpDSBaiHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpDSBaiHoc.Location = new System.Drawing.Point(38, 88);
            this.flpDSBaiHoc.Name = "flpDSBaiHoc";
            this.flpDSBaiHoc.Size = new System.Drawing.Size(984, 832);
            this.flpDSBaiHoc.TabIndex = 1;
            // 
            // lblDSBaiHoc
            // 
            this.lblDSBaiHoc.AutoSize = true;
            this.lblDSBaiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSBaiHoc.Location = new System.Drawing.Point(31, 22);
            this.lblDSBaiHoc.Name = "lblDSBaiHoc";
            this.lblDSBaiHoc.Size = new System.Drawing.Size(281, 42);
            this.lblDSBaiHoc.TabIndex = 0;
            this.lblDSBaiHoc.Text = "CÁC BÀI HỌC ";
            // 
            // DsBaiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 923);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DsBaiHoc";
            this.Text = "DsBaiHoc";
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
        private System.Windows.Forms.Button btnDSKH_user;
        private System.Windows.Forms.Button btnDSKHoaHoc;
        private System.Windows.Forms.FlowLayoutPanel flpDSBaiHoc;
        private System.Windows.Forms.Label lblDSBaiHoc;
    }
}