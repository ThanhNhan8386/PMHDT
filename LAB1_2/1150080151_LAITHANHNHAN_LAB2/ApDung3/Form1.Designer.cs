namespace ApDung3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;

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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // Label Username
            this.lblUsername.Text = "Username:";
            this.lblUsername.Location = new System.Drawing.Point(30, 30);

            // TextBox Username
            this.txtUsername.Location = new System.Drawing.Point(120, 30);
            this.txtUsername.Width = 200;

            // Label Password
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(30, 70);

            // TextBox Password
            this.txtPassword.Location = new System.Drawing.Point(120, 70);
            this.txtPassword.Width = 200;
            this.txtPassword.PasswordChar = '*';

            // Button Login
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Location = new System.Drawing.Point(120, 120);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // Button Exit
            this.btnExit.Text = "Thoát";
            this.btnExit.Location = new System.Drawing.Point(230, 120);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // ErrorProvider
            this.errorProvider1.ContainerControl = this;

            // Form
            this.ClientSize = new System.Drawing.Size(380, 200);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Text = "Đăng nhập hệ thống";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
