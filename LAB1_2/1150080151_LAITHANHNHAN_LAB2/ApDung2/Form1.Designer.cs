namespace ApDung2
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lvLog = new System.Windows.Forms.ListView();
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();

            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(90, 15);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 0;

            // lvLog
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colGroup,
            this.colResult});
            this.lvLog.HideSelection = false;
            this.lvLog.Location = new System.Drawing.Point(12, 200);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(400, 150);
            this.lvLog.TabIndex = 1;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;

            // Columns
            this.colTime.Text = "Ngày giờ";
            this.colTime.Width = 130;
            this.colGroup.Text = "Nhóm";
            this.colGroup.Width = 130;
            this.colResult.Text = "Kết quả";
            this.colResult.Width = 100;

            // Nút số
            int x = 12, y = 60;
            int dx = 60, dy = 40;

            this.btn1.Location = new System.Drawing.Point(x, y);
            this.btn1.Size = new System.Drawing.Size(50, 30);
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);

            this.btn2.Location = new System.Drawing.Point(x + dx, y);
            this.btn2.Size = new System.Drawing.Size(50, 30);
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);

            this.btn3.Location = new System.Drawing.Point(x + dx * 2, y);
            this.btn3.Size = new System.Drawing.Size(50, 30);
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);

            this.btn4.Location = new System.Drawing.Point(x, y + dy);
            this.btn4.Size = new System.Drawing.Size(50, 30);
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);

            this.btn5.Location = new System.Drawing.Point(x + dx, y + dy);
            this.btn5.Size = new System.Drawing.Size(50, 30);
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);

            this.btn6.Location = new System.Drawing.Point(x + dx * 2, y + dy);
            this.btn6.Size = new System.Drawing.Size(50, 30);
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);

            this.btn7.Location = new System.Drawing.Point(x, y + dy * 2);
            this.btn7.Size = new System.Drawing.Size(50, 30);
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);

            this.btn8.Location = new System.Drawing.Point(x + dx, y + dy * 2);
            this.btn8.Size = new System.Drawing.Size(50, 30);
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);

            this.btn9.Location = new System.Drawing.Point(x + dx * 2, y + dy * 2);
            this.btn9.Size = new System.Drawing.Size(50, 30);
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(200, 60);
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnEnter
            this.btnEnter.BackColor = System.Drawing.Color.Lime;
            this.btnEnter.Location = new System.Drawing.Point(200, 100);
            this.btnEnter.Size = new System.Drawing.Size(80, 30);
            this.btnEnter.Text = "Enter";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

            // btnRing
            this.btnRing.BackColor = System.Drawing.Color.Red;
            this.btnRing.Location = new System.Drawing.Point(200, 140);
            this.btnRing.Size = new System.Drawing.Size(80, 30);
            this.btnRing.Text = "RING";
            this.btnRing.Click += new System.EventHandler(this.btnRing_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(430, 370);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lvLog);

            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);

            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnRing);

            this.Text = "Security Panel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colGroup;
        private System.Windows.Forms.ColumnHeader colResult;

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnRing;
    }
}
