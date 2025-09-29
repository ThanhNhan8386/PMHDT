namespace TH2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.CheckBox chkCaoRang;
        private System.Windows.Forms.CheckBox chkTayTrang;
        private System.Windows.Forms.CheckBox chkHanRang;
        private System.Windows.Forms.CheckBox chkBeRang;
        private System.Windows.Forms.CheckBox chkBocRang;
        private System.Windows.Forms.NumericUpDown numHanRang;
        private System.Windows.Forms.NumericUpDown numBeRang;
        private System.Windows.Forms.NumericUpDown numBocRang;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.chkCaoRang = new System.Windows.Forms.CheckBox();
            this.chkTayTrang = new System.Windows.Forms.CheckBox();
            this.chkHanRang = new System.Windows.Forms.CheckBox();
            this.chkBeRang = new System.Windows.Forms.CheckBox();
            this.chkBocRang = new System.Windows.Forms.CheckBox();
            this.numHanRang = new System.Windows.Forms.NumericUpDown();
            this.numBeRang = new System.Windows.Forms.NumericUpDown();
            this.numBocRang = new System.Windows.Forms.NumericUpDown();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBocRang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Green;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            this.lblTitle.Height = 50;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Text = "Tên khách hàng:";
            this.lblCustomer.Location = new System.Drawing.Point(20, 70);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(150, 70);
            this.txtCustomer.Width = 250;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grpServices
            // 
            this.grpServices.Text = "Dịch vụ tại phòng khám:";
            this.grpServices.Location = new System.Drawing.Point(20, 110);
            this.grpServices.Size = new System.Drawing.Size(400, 200);
            this.grpServices.Controls.AddRange(new System.Windows.Forms.Control[] {
                chkCaoRang, chkTayTrang, chkHanRang, chkBeRang, chkBocRang,
                numHanRang, numBeRang, numBocRang
            });
            // 
            // chkCaoRang
            // 
            this.chkCaoRang.Text = "Lấy cao răng - 50.000đ/2 hàm";
            this.chkCaoRang.Location = new System.Drawing.Point(20, 30);
            // 
            // chkTayTrang
            // 
            this.chkTayTrang.Text = "Tẩy trắng răng - 100.000đ/2 hàm";
            this.chkTayTrang.Location = new System.Drawing.Point(20, 60);
            // 
            // chkHanRang
            // 
            this.chkHanRang.Text = "Hàn răng - 100.000đ/1 răng";
            this.chkHanRang.Location = new System.Drawing.Point(20, 90);
            // 
            // numHanRang
            // 
            this.numHanRang.Location = new System.Drawing.Point(300, 90);
            this.numHanRang.Minimum = 0;
            this.numHanRang.Maximum = 50;
            // 
            // chkBeRang
            // 
            this.chkBeRang.Text = "Bẻ răng - 10.000đ/1 răng";
            this.chkBeRang.Location = new System.Drawing.Point(20, 120);
            // 
            // numBeRang
            // 
            this.numBeRang.Location = new System.Drawing.Point(300, 120);
            this.numBeRang.Minimum = 0;
            this.numBeRang.Maximum = 50;
            // 
            // chkBocRang
            // 
            this.chkBocRang.Text = "Bọc răng - 1.000.000đ/1 răng";
            this.chkBocRang.Location = new System.Drawing.Point(20, 150);
            // 
            // numBocRang
            // 
            this.numBocRang.Location = new System.Drawing.Point(300, 150);
            this.numBocRang.Minimum = 0;
            this.numBocRang.Maximum = 50;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.Location = new System.Drawing.Point(100, 330);
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(220, 330);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(460, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnThoat);
            this.Text = "Phòng khám nha khoa";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBocRang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
