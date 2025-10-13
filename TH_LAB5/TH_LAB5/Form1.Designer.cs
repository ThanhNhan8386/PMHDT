namespace TH_LAB5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblChonMaLop;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.GroupBox groupDanhSach;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.GroupBox groupThongTin;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblMaLop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblChonMaLop = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.groupDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.groupThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();

            this.groupDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.groupThongTin.SuspendLayout();
            this.SuspendLayout();

            // ===== FORM =====
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Text = "Sửa dữ liệu (Không dùng Parameter)";
            this.Load += new System.EventHandler(this.Form1_Load);

            // ===== TIÊU ĐỀ =====
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Text = "SỬA DỮ LIỆU KHÔNG DÙNG PARAMETER";
            this.lblTitle.Location = new System.Drawing.Point(230, 15);

            // ===== CHỌN MÃ LỚP =====
            this.lblChonMaLop.AutoSize = true;
            this.lblChonMaLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChonMaLop.Text = "Chọn mã lớp:";
            this.lblChonMaLop.Location = new System.Drawing.Point(280, 60);

            this.cboMaLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLop.Size = new System.Drawing.Size(180, 25);
            this.cboMaLop.Location = new System.Drawing.Point(380, 57);
            this.cboMaLop.SelectedIndexChanged += new System.EventHandler(this.cboMaLop_SelectedIndexChanged);

            // ===== DANH SÁCH SINH VIÊN =====
            this.groupDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupDanhSach.Text = "Danh sách sinh viên";
            this.groupDanhSach.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.groupDanhSach.Location = new System.Drawing.Point(30, 100);
            this.groupDanhSach.Size = new System.Drawing.Size(480, 360);
            this.groupDanhSach.Controls.Add(this.dgvSinhVien);

            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);

            // ===== THÔNG TIN SINH VIÊN =====
            this.groupThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupThongTin.Text = "Thông tin sinh viên";
            this.groupThongTin.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.groupThongTin.Location = new System.Drawing.Point(530, 100);
            this.groupThongTin.Size = new System.Drawing.Size(340, 360);

            int lblX = 25, txtX = 130, y = 40, gap = 42;

            // Mã SV
            this.lblMaSV.Text = "Mã SV:";
            this.lblMaSV.Location = new System.Drawing.Point(lblX, y);
            this.txtMaSV.Location = new System.Drawing.Point(txtX, y - 5);
            this.txtMaSV.Width = 180;
            this.txtMaSV.Height = 27;
            y += gap;

            // Tên SV
            this.lblTenSV.Text = "Tên SV:";
            this.lblTenSV.Location = new System.Drawing.Point(lblX, y);
            this.txtTenSV.Location = new System.Drawing.Point(txtX, y - 5);
            this.txtTenSV.Width = 180;
            this.txtTenSV.Height = 27;
            y += gap;

            // Giới tính
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Location = new System.Drawing.Point(lblX, y);
            this.cboGioiTinh.Location = new System.Drawing.Point(txtX, y - 5);
            this.cboGioiTinh.Width = 180;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            y += gap;

            // Ngày sinh
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.Location = new System.Drawing.Point(lblX, y);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(txtX, y - 5);
            this.dtpNgaySinh.Width = 180;
            y += gap;

            // Quê quán
            this.lblQueQuan.Text = "Quê quán:";
            this.lblQueQuan.Location = new System.Drawing.Point(lblX, y);
            this.txtQueQuan.Location = new System.Drawing.Point(txtX, y - 5);
            this.txtQueQuan.Width = 180;
            this.txtQueQuan.Height = 27;
            y += gap;

            // Mã lớp
            this.lblMaLop.Text = "Mã lớp:";
            this.lblMaLop.Location = new System.Drawing.Point(lblX, y);
            this.txtMaLop.Location = new System.Drawing.Point(txtX, y - 5);
            this.txtMaLop.Width = 180;
            this.txtMaLop.Height = 27;
            y += gap + 10;

            // ===== CÁC NÚT =====
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Location = new System.Drawing.Point(25, y);
            this.btnThem.Size = new System.Drawing.Size(90, 38);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Text = "Sửa";
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Location = new System.Drawing.Point(130, y);
            this.btnSua.Size = new System.Drawing.Size(80, 38);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Location = new System.Drawing.Point(225, y);
            this.btnXoa.Size = new System.Drawing.Size(80, 38);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // ===== ADD CONTROL VÀO GROUP THÔNG TIN =====
            this.groupThongTin.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.lblMaSV, this.txtMaSV,
                this.lblTenSV, this.txtTenSV,
                this.lblGioiTinh, this.cboGioiTinh,
                this.lblNgaySinh, this.dtpNgaySinh,
                this.lblQueQuan, this.txtQueQuan,
                this.lblMaLop, this.txtMaLop,
                this.btnThem, this.btnSua, this.btnXoa
            });

            // ===== ADD CONTROL VÀO FORM =====
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblChonMaLop);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.groupDanhSach);
            this.Controls.Add(this.groupThongTin);

            this.groupDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
