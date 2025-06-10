using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblLogo;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblRole;
        private ComboBox cboRole;
        private Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblLogo = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRole = new Label();
            cboRole = new ComboBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 100;
            panelHeader.Paint += panelHeader_Paint;
            panelHeader.Controls.Add(lblLogo);
            panelHeader.BackColor = Color.FromArgb(0, 120, 215); // Blue background
            // 
            // lblLogo
            // 
            lblLogo.Text = "Student Mangment System Login";
            lblLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblLogo.ForeColor = Color.Black;
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(20, 20);
            // 
            // lblUsername
            // 
            lblUsername.Text = "Username:";
            lblUsername.Font = new Font("Segoe UI", 11F);
            lblUsername.ForeColor = Color.Green;
            lblUsername.Location = new Point(50, 110);
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(150, 105);
            txtUsername.Width = 250;
            txtUsername.BackColor = Color.Black;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Font = new Font("Segoe UI", 11F);
            // 
            // lblPassword
            // 
            lblPassword.Text = "Password:";
            lblPassword.Font = new Font("Segoe UI", 11F);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(50, 160);
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 155);
            txtPassword.Width = 250;
            txtPassword.BackColor = Color.Black;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.PasswordChar = '*';
            // 
            // lblRole
            // 
            lblRole.Text = "Role:";
            lblRole.Font = new Font("Segoe UI", 11F);
            lblRole.ForeColor = Color.Black;
            lblRole.Location = new Point(50, 210);
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.Location = new Point(150, 205);
            cboRole.Width = 250;
            cboRole.BackColor = Color.Black;
            cboRole.ForeColor = Color.Black;
            cboRole.Font = new Font("Segoe UI", 11F);
            cboRole.Items.AddRange(new[] { "Admin", "Teacher" });
            cboRole.SelectedIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Text = "Login";
            btnLogin.Location = new Point(200, 260);
            btnLogin.Width = 120;
            btnLogin.Height = 40;
            btnLogin.BackColor = Color.FromArgb(0, 153, 51); // Green button
            btnLogin.ForeColor = Color.Black;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.Click += btnLogin_Click;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = ControlPaint.Light(Color.FromArgb(0, 153, 51));
            btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = Color.FromArgb(0, 153, 51);
            // 
            // LoginForm
            // 
            ClientSize = new Size(600, 500);
            Controls.Add(panelHeader);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(cboRole);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
