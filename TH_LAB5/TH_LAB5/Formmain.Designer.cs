namespace TH_LAB5
{
    partial class Formmain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Label lblNote;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnForm1 = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // ===== FORM =====
            this.ClientSize = new System.Drawing.Size(500, 280);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn chức năng";

            // ===== TIÊU ĐỀ =====
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Text = "CHƯƠNG TRÌNH LAB 5 - ADO.NET";
            this.lblTitle.Location = new System.Drawing.Point(90, 30);

            // ===== GHI CHÚ =====
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblNote.ForeColor = System.Drawing.Color.Gray;
            this.lblNote.Text = "Chọn chức năng để mở form tương ứng";
            this.lblNote.Location = new System.Drawing.Point(130, 70);

            // ===== NÚT FORM1 =====
            this.btnForm1.Text = "Sửa dữ liệu KHÔNG dùng Parameter";
            this.btnForm1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnForm1.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnForm1.ForeColor = System.Drawing.Color.White;
            this.btnForm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm1.FlatAppearance.BorderSize = 0;
            this.btnForm1.Size = new System.Drawing.Size(320, 45);
            this.btnForm1.Location = new System.Drawing.Point(90, 110);
            this.btnForm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);

            // ===== NÚT FORM2 =====
            this.btnForm2.Text = "Sửa dữ liệu CÓ dùng Parameter";
            this.btnForm2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnForm2.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnForm2.ForeColor = System.Drawing.Color.White;
            this.btnForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm2.FlatAppearance.BorderSize = 0;
            this.btnForm2.Size = new System.Drawing.Size(320, 45);
            this.btnForm2.Location = new System.Drawing.Point(90, 170);
            this.btnForm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);

            // ===== ADD CONTROL =====
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnForm1);
            this.Controls.Add(this.btnForm2);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
