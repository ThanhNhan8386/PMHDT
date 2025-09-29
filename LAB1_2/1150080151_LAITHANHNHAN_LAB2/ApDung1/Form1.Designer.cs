namespace ApDung1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxOption;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.RadioButton rdbUSCLN;
        private System.Windows.Forms.RadioButton rdbBSCNN;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;

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
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.groupBoxOption = new System.Windows.Forms.GroupBox();
            this.rdbUSCLN = new System.Windows.Forms.RadioButton();
            this.rdbBSCNN = new System.Windows.Forms.RadioButton();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.BackColor = System.Drawing.Color.LightGreen;
            this.groupBoxInput.Controls.Add(this.lblA);
            this.groupBoxInput.Controls.Add(this.lblB);
            this.groupBoxInput.Controls.Add(this.txtA);
            this.groupBoxInput.Controls.Add(this.txtB);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(250, 100);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Nhập dữ liệu:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(10, 30);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(75, 20);
            this.lblA.Text = "Số nguyên a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(10, 65);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(75, 20);
            this.lblB.Text = "Số nguyên b:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(100, 27);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(120, 26);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(100, 62);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(120, 26);
            // 
            // groupBoxOption
            // 
            this.groupBoxOption.Controls.Add(this.rdbUSCLN);
            this.groupBoxOption.Controls.Add(this.rdbBSCNN);
            this.groupBoxOption.Location = new System.Drawing.Point(280, 12);
            this.groupBoxOption.Name = "groupBoxOption";
            this.groupBoxOption.Size = new System.Drawing.Size(150, 100);
            this.groupBoxOption.TabIndex = 1;
            this.groupBoxOption.TabStop = false;
            this.groupBoxOption.Text = "Tùy chọn:";
            // 
            // rdbUSCLN
            // 
            this.rdbUSCLN.AutoSize = true;
            this.rdbUSCLN.Location = new System.Drawing.Point(15, 30);
            this.rdbUSCLN.Name = "rdbUSCLN";
            this.rdbUSCLN.Size = new System.Drawing.Size(82, 24);
            this.rdbUSCLN.Text = "USCLN";
            this.rdbUSCLN.UseVisualStyleBackColor = true;
            // 
            // rdbBSCNN
            // 
            this.rdbBSCNN.AutoSize = true;
            this.rdbBSCNN.Location = new System.Drawing.Point(15, 65);
            this.rdbBSCNN.Name = "rdbBSCNN";
            this.rdbBSCNN.Size = new System.Drawing.Size(85, 24);
            this.rdbBSCNN.Text = "BSCNN";
            this.rdbBSCNN.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(12, 130);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(58, 20);
            this.lblKetQua.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(80, 127);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(200, 26);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(80, 170);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 30);
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(180, 170);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 220);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxOption);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);
            this.Name = "Form1";
            this.Text = "Tìm USCLN và BSCNN của số nguyên a và b";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOption.ResumeLayout(false);
            this.groupBoxOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
