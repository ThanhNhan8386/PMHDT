namespace ApDung_HienThiSinhVienTheoLop
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDSLop = new System.Windows.Forms.Label();
            this.lblDSSV = new System.Windows.Forms.Label();
            this.lsbDSLop = new System.Windows.Forms.ListBox();
            this.lsvSinhVien = new System.Windows.Forms.ListView();
            this.colMaSV = new System.Windows.Forms.ColumnHeader();
            this.colTenSV = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinh = new System.Windows.Forms.ColumnHeader();
            this.colQueQuan = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(180, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Áp dụng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDSLop
            // 
            this.lblDSLop.AutoSize = true;
            this.lblDSLop.Location = new System.Drawing.Point(20, 50);
            this.lblDSLop.Name = "lblDSLop";
            this.lblDSLop.Size = new System.Drawing.Size(74, 15);
            this.lblDSLop.TabIndex = 1;
            this.lblDSLop.Text = "Danh sách lớp:";
            // 
            // lblDSSV
            // 
            this.lblDSSV.AutoSize = true;
            this.lblDSSV.Location = new System.Drawing.Point(230, 50);
            this.lblDSSV.Name = "lblDSSV";
            this.lblDSSV.Size = new System.Drawing.Size(94, 15);
            this.lblDSSV.TabIndex = 2;
            this.lblDSSV.Text = "Danh sách sinh viên:";
            // 
            // lsbDSLop
            // 
            this.lsbDSLop.FormattingEnabled = true;
            this.lsbDSLop.ItemHeight = 15;
            this.lsbDSLop.Location = new System.Drawing.Point(20, 70);
            this.lsbDSLop.Name = "lsbDSLop";
            this.lsbDSLop.Size = new System.Drawing.Size(180, 229);
            this.lsbDSLop.TabIndex = 3;
            this.lsbDSLop.SelectedIndexChanged += new System.EventHandler(this.lsbDSLop_SelectedIndexChanged);
            // 
            // lsvSinhVien
            // 
            this.lsvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colTenSV,
            this.colGioiTinh,
            this.colQueQuan});
            this.lsvSinhVien.FullRowSelect = true;
            this.lsvSinhVien.GridLines = true;
            this.lsvSinhVien.HideSelection = false;
            this.lsvSinhVien.Location = new System.Drawing.Point(230, 70);
            this.lsvSinhVien.Name = "lsvSinhVien";
            this.lsvSinhVien.Size = new System.Drawing.Size(350, 230);
            this.lsvSinhVien.TabIndex = 4;
            this.lsvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lsvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã SV";
            this.colMaSV.Width = 70;
            // 
            // colTenSV
            // 
            this.colTenSV.Text = "Tên SV";
            this.colTenSV.Width = 120;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 70;
            // 
            // colQueQuan
            // 
            this.colQueQuan.Text = "Quê quán";
            this.colQueQuan.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 330);
            this.Controls.Add(this.lsvSinhVien);
            this.Controls.Add(this.lsbDSLop);
            this.Controls.Add(this.lblDSSV);
            this.Controls.Add(this.lblDSLop);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hiển thị sinh viên theo lớp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDSLop;
        private System.Windows.Forms.Label lblDSSV;
        private System.Windows.Forms.ListBox lsbDSLop;
        private System.Windows.Forms.ListView lsvSinhVien;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
    }
}
