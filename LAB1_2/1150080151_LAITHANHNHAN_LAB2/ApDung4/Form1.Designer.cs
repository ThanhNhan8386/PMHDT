namespace ApDung4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstMatHang;
        private System.Windows.Forms.ListBox lstDaChon;
        private System.Windows.Forms.Label lblMatHang;
        private System.Windows.Forms.Label lblDaChon;
        private System.Windows.Forms.Button btnChuyen1;
        private System.Windows.Forms.Button btnChuyenHet1;
        private System.Windows.Forms.Button btnChuyen2;
        private System.Windows.Forms.Button btnChuyenHet2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstMatHang = new System.Windows.Forms.ListBox();
            this.lstDaChon = new System.Windows.Forms.ListBox();
            this.lblMatHang = new System.Windows.Forms.Label();
            this.lblDaChon = new System.Windows.Forms.Label();
            this.btnChuyen1 = new System.Windows.Forms.Button();
            this.btnChuyenHet1 = new System.Windows.Forms.Button();
            this.btnChuyen2 = new System.Windows.Forms.Button();
            this.btnChuyenHet2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatHang
            // 
            this.lblMatHang.Text = "Danh sách các mặt hàng";
            this.lblMatHang.Location = new System.Drawing.Point(20, 20);
            // 
            // lstMatHang
            // 
            this.lstMatHang.Location = new System.Drawing.Point(20, 50);
            this.lstMatHang.Size = new System.Drawing.Size(150, 200);
            this.lstMatHang.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // lblDaChon
            // 
            this.lblDaChon.Text = "Các mặt hàng lựa chọn";
            this.lblDaChon.Location = new System.Drawing.Point(300, 20);
            // 
            // lstDaChon
            // 
            this.lstDaChon.Location = new System.Drawing.Point(300, 50);
            this.lstDaChon.Size = new System.Drawing.Size(150, 200);
            this.lstDaChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // btnChuyen1
            // 
            this.btnChuyen1.Text = ">";
            this.btnChuyen1.Location = new System.Drawing.Point(200, 60);
            this.btnChuyen1.Click += new System.EventHandler(this.btnChuyen1_Click);
            // 
            // btnChuyenHet1
            // 
            this.btnChuyenHet1.Text = ">>";
            this.btnChuyenHet1.Location = new System.Drawing.Point(200, 100);
            this.btnChuyenHet1.Click += new System.EventHandler(this.btnChuyenHet1_Click);
            // 
            // btnChuyen2
            // 
            this.btnChuyen2.Text = "<";
            this.btnChuyen2.Location = new System.Drawing.Point(200, 140);
            this.btnChuyen2.Click += new System.EventHandler(this.btnChuyen2_Click);
            // 
            // btnChuyenHet2
            // 
            this.btnChuyenHet2.Text = "<<";
            this.btnChuyenHet2.Location = new System.Drawing.Point(200, 180);
            this.btnChuyenHet2.Click += new System.EventHandler(this.btnChuyenHet2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(480, 280);
            this.Controls.Add(this.lblMatHang);
            this.Controls.Add(this.lstMatHang);
            this.Controls.Add(this.lblDaChon);
            this.Controls.Add(this.lstDaChon);
            this.Controls.Add(this.btnChuyen1);
            this.Controls.Add(this.btnChuyenHet1);
            this.Controls.Add(this.btnChuyen2);
            this.Controls.Add(this.btnChuyenHet2);
            this.Text = "Bài tập 7 - ApDung4";
            this.ResumeLayout(false);
        }
    }
}
