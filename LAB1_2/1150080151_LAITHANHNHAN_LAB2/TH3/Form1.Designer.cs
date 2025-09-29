namespace TH3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnChonDau;
        private System.Windows.Forms.Button btnChonLeCuoi;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnXoaDay;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhap = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChonDau = new System.Windows.Forms.Button();
            this.btnChonLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnXoaDay = new System.Windows.Forms.Button();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.BackColor = System.Drawing.Color.Teal;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Text = "Ứng dụng xử lý dãy số";
            this.lblTitle.Height = 40;
            // 
            // lblNhap
            // 
            this.lblNhap.Text = "Nhập số nguyên:";
            this.lblNhap.Location = new System.Drawing.Point(20, 60);
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(150, 60);
            this.txtSo.Width = 120;
            // 
            // btnNhap
            // 
            this.btnNhap.Text = "Nhập số";
            this.btnNhap.Location = new System.Drawing.Point(280, 60);
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lsbDaySo
            // 
            this.lsbDaySo.Location = new System.Drawing.Point(20, 100);
            this.lsbDaySo.Size = new System.Drawing.Size(200, 200);
            // 
            // grpChucNang
            // 
            this.grpChucNang.Text = "Chức năng:";
            this.grpChucNang.Location = new System.Drawing.Point(240, 100);
            this.grpChucNang.Size = new System.Drawing.Size(200, 200);
            this.grpChucNang.Controls.AddRange(new System.Windows.Forms.Control[] {
                btnTang2, btnChonDau, btnChonLeCuoi, btnXoaChon, btnXoaDau, btnXoaCuoi
            });
            // 
            // btnTang2
            // 
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.Location = new System.Drawing.Point(20, 30);
            this.btnTang2.Width = 160;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnChonDau
            // 
            this.btnChonDau.Text = "Chọn số chẵn đầu";
            this.btnChonDau.Location = new System.Drawing.Point(20, 60);
            this.btnChonDau.Width = 160;
            this.btnChonDau.Click += new System.EventHandler(this.btnChonDau_Click);
            // 
            // btnChonLeCuoi
            // 
            this.btnChonLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnChonLeCuoi.Location = new System.Drawing.Point(20, 90);
            this.btnChonLeCuoi.Width = 160;
            this.btnChonLeCuoi.Click += new System.EventHandler(this.btnChonLeCuoi_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaChon.Location = new System.Drawing.Point(20, 120);
            this.btnXoaChon.Width = 160;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnXoaDau
            // 
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.Location = new System.Drawing.Point(20, 150);
            this.btnXoaDau.Width = 160;
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);
            // 
            // btnXoaCuoi
            // 
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.Location = new System.Drawing.Point(20, 180);
            this.btnXoaCuoi.Width = 160;
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Text = "Kết thúc ứng dụng";
            this.btnKetThuc.BackColor = System.Drawing.Color.Red;
            this.btnKetThuc.ForeColor = System.Drawing.Color.White;
            this.btnKetThuc.Location = new System.Drawing.Point(20, 320);
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnXoaDay
            // 
            this.btnXoaDay.Text = "Xóa dãy số";
            this.btnXoaDay.BackColor = System.Drawing.Color.Gray;
            this.btnXoaDay.ForeColor = System.Drawing.Color.White;
            this.btnXoaDay.Location = new System.Drawing.Point(240, 320);
            this.btnXoaDay.Click += new System.EventHandler(this.btnXoaDay_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(460, 380);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnXoaDay);
            this.Text = "TH3 - Xử lý dãy số";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
