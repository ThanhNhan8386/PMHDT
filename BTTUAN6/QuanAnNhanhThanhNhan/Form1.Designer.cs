namespace QuanAnNhanhThanhNhan
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();

            // Tạo các nút món ăn
            this.btnComChienTrung = new System.Windows.Forms.Button();
            this.btnBanhMyOpLa = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btnOcRangMuoi = new System.Windows.Forms.Button();
            this.btnKhoaiTayChien = new System.Windows.Forms.Button();
            this.btn7up = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnMyXaoHaiSan = new System.Windows.Forms.Button();
            this.btnCaVienChien = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnBugerBoNuong = new System.Windows.Forms.Button();
            this.btnDuiGaRan = new System.Windows.Forms.Button();
            this.btnBunBoHue = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // (Thêm ảnh ở Properties sau khi thiết kế)

            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(100, 25);
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.Text = "Quán ăn nhanh Thành Nhân";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // groupBox1
            // 
            this.groupBox1.Text = "Danh sách món ăn:";
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Size = new System.Drawing.Size(420, 200);

            // Thêm các nút món ăn vào groupBox1
            System.Windows.Forms.Button[] buttons = {
                btnComChienTrung, btnBanhMyOpLa, btnCoca,
                btnLipton, btnOcRangMuoi, btnKhoaiTayChien,
                btn7up, btnCam, btnMyXaoHaiSan,
                btnCaVienChien, btnPepsi, btnCafe,
                btnBugerBoNuong, btnDuiGaRan, btnBunBoHue
            };

            string[] texts = {
                "Cơm chiên trứng", "Bánh mì ốp la", "Coca",
                "Lipton", "Ốc rang muối", "Khoai tây chiên",
                "7 up", "Cam", "Mỳ xào hải sản",
                "Cá viên chiên", "Pepsi", "Cafe",
                "Buger bò nướng", "Đùi gà rán", "Bún bò Huế"
            };

            int x = 10, y = 20, count = 0;
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = texts[i];
                buttons[i].Size = new System.Drawing.Size(120, 35);
                buttons[i].Location = new System.Drawing.Point(x, y);
                this.groupBox1.Controls.Add(buttons[i]);
                count++;
                x += 130;
                if (count % 3 == 0)
                {
                    x = 10;
                    y += 45;
                }
            }

            // 
            // lstOrder
            // 
            this.lstOrder.Location = new System.Drawing.Point(12, 370);
            this.lstOrder.Size = new System.Drawing.Size(420, 120);

            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(12, 320);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // cboBan
            // 
            this.cboBan.Location = new System.Drawing.Point(120, 320);
            this.cboBan.Size = new System.Drawing.Size(120, 24);
            this.cboBan.Items.AddRange(new object[] {
            "Bàn 1", "Bàn 2", "Bàn 3", "Bàn 4"});

            // 
            // btnOrder
            // 
            this.btnOrder.Text = "Order";
            this.btnOrder.Location = new System.Drawing.Point(270, 320);
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cboBan);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lstOrder);
            this.Text = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnComChienTrung;
        private System.Windows.Forms.Button btnBanhMyOpLa;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnLipton;
        private System.Windows.Forms.Button btnOcRangMuoi;
        private System.Windows.Forms.Button btnKhoaiTayChien;
        private System.Windows.Forms.Button btn7up;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnMyXaoHaiSan;
        private System.Windows.Forms.Button btnCaVienChien;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btnBugerBoNuong;
        private System.Windows.Forms.Button btnDuiGaRan;
        private System.Windows.Forms.Button btnBunBoHue;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboBan;
        private System.Windows.Forms.Button btnOrder;
    }
}
