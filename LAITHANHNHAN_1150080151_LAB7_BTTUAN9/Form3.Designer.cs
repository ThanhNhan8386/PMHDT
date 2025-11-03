namespace Lab7_ChinhSuaDuLieu
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox groupBoxSua;
        private System.Windows.Forms.Label lblMaNXB;
        private System.Windows.Forms.Label lblTenNXB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnCapNhat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBoxSua = new System.Windows.Forms.GroupBox();
            this.lblMaNXB = new System.Windows.Forms.Label();
            this.lblTenNXB = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.groupBoxSua.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(200, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(184, 17);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Chỉnh sửa thông tin dữ liệu";
            // 
            // dgvNXB
            // 
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Location = new System.Drawing.Point(20, 40);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.Size = new System.Drawing.Size(300, 250);
            this.dgvNXB.TabIndex = 1;
            this.dgvNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellClick);
            // 
            // groupBoxSua
            // 
            this.groupBoxSua.Controls.Add(this.lblMaNXB);
            this.groupBoxSua.Controls.Add(this.lblTenNXB);
            this.groupBoxSua.Controls.Add(this.lblDiaChi);
            this.groupBoxSua.Controls.Add(this.txtMaNXB);
            this.groupBoxSua.Controls.Add(this.txtTenNXB);
            this.groupBoxSua.Controls.Add(this.txtDiaChi);
            this.groupBoxSua.Controls.Add(this.btnCapNhat);
            this.groupBoxSua.Location = new System.Drawing.Point(340, 40);
            this.groupBoxSua.Name = "groupBoxSua";
            this.groupBoxSua.Size = new System.Drawing.Size(250, 250);
            this.groupBoxSua.TabIndex = 2;
            this.groupBoxSua.TabStop = false;
            this.groupBoxSua.Text = "Chỉnh sửa thông tin:";
            // 
            // lblMaNXB
            // 
            this.lblMaNXB.AutoSize = true;
            this.lblMaNXB.Location = new System.Drawing.Point(20, 40);
            this.lblMaNXB.Name = "lblMaNXB";
            this.lblMaNXB.Size = new System.Drawing.Size(48, 13);
            this.lblMaNXB.TabIndex = 0;
            this.lblMaNXB.Text = "Mã NXB:";
            // 
            // lblTenNXB
            // 
            this.lblTenNXB.AutoSize = true;
            this.lblTenNXB.Location = new System.Drawing.Point(20, 80);
            this.lblTenNXB.Name = "lblTenNXB";
            this.lblTenNXB.Size = new System.Drawing.Size(52, 13);
            this.lblTenNXB.TabIndex = 1;
            this.lblTenNXB.Text = "Tên NXB:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(20, 120);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(44, 13);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(90, 37);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(130, 20);
            this.txtMaNXB.TabIndex = 3;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(90, 77);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(130, 20);
            this.txtTenNXB.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(90, 117);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(130, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(60, 160);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(130, 40);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Chỉnh sửa thông tin";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(620, 320);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dgvNXB);
            this.Controls.Add(this.groupBoxSua);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.groupBoxSua.ResumeLayout(false);
            this.groupBoxSua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
