    using System;
    using System.Windows.Forms;

    namespace ApDung3
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                bool isValid = true;

                // Kiểm tra Username
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    errorProvider1.SetError(txtUsername, "Username không được để trống!");
                    isValid = false;
                }
                else
                {
                    errorProvider1.SetError(txtUsername, "");
                }

                // Kiểm tra Password
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    errorProvider1.SetError(txtPassword, "Password không được để trống!");
                    isValid = false;
                }
                else
                {
                    errorProvider1.SetError(txtPassword, "");
                }

                // Nếu hợp lệ
                if (isValid)
                {
                    MessageBox.Show($"Chào mừng {txtUsername.Text} đăng nhập thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }
    }
