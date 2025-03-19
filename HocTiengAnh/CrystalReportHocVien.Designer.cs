
namespace HocTiengAnh
{
    partial class KetQuaHocVien
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
            this.crpKetQuaHocVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpKetQuaHocVien
            // 
            this.crpKetQuaHocVien.ActiveViewIndex = -1;
            this.crpKetQuaHocVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpKetQuaHocVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpKetQuaHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpKetQuaHocVien.Location = new System.Drawing.Point(0, 0);
            this.crpKetQuaHocVien.Name = "crpKetQuaHocVien";
            this.crpKetQuaHocVien.Size = new System.Drawing.Size(800, 450);
            this.crpKetQuaHocVien.TabIndex = 0;
            // 
            // KetQuaHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crpKetQuaHocVien);
            this.Name = "KetQuaHocVien";
            this.Text = "Ket Qua Hoc Vien";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpKetQuaHocVien;
    }
}