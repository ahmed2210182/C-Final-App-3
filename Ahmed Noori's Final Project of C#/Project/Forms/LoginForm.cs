using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using StudentManagementSystem;

namespace StudentManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(250, 250, 255); // Lighter background color

            // Style panels, controls
            StylePanelHeader(panelHeader);
            StyleTextBox(txtUsername, "Username");
            StyleTextBox(txtPassword, "Password", isPassword: true);
            StyleComboBox(cboRole);
            StyleButton(btnLogin, Color.FromArgb(0, 128, 0)); // Dark green button

            cboRole.Items.AddRange(new[] { "Admin", "Teacher" });
            cboRole.SelectedIndex = 0;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(panelHeader.ClientRectangle,
                                                      Color.FromArgb(0, 102, 204),   // Darker blue gradient start
                                                      Color.FromArgb(0, 204, 255),   // Light blue gradient end
                                                      45F))
            {
                e.Graphics.FillRectangle(brush, panelHeader.ClientRectangle);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string role = cboRole.SelectedItem.ToString();

            if (user == "admin" && pass == "1234")
            {
                SessionManager.Role = role;
                MessageBox.Show($"Welcome, {role}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new DashboardForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Styling methods
        private void StylePanelHeader(Panel pnl)
        {
            pnl.Paint -= panelHeader_Paint;
            pnl.Paint += panelHeader_Paint;
        }

        private void StyleTextBox(TextBox txt, string placeholder, bool isPassword = false)
        {
            txt.Font = new Font("Segoe UI", 12F); // Increased font size
            txt.ForeColor = Color.DarkGray; // Placeholder color
            txt.BackColor = Color.FromArgb(240, 240, 250); // Lighter background color
            txt.Text = placeholder;
            txt.GotFocus += (s, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.FromArgb(30, 30, 30); // Active input color
                }
                if (isPassword) txt.PasswordChar = '*';
            };
            txt.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.DarkGray;
                    txt.PasswordChar = '\0';
                }
            };
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Width = 280;  // Increased width
            txt.Height = 45;  // Increased height
        }

        private void StyleComboBox(ComboBox cbo)
        {
            cbo.Font = new Font("Segoe UI", 12F); // Increased font size
            cbo.FlatStyle = FlatStyle.Flat;
            cbo.BackColor = Color.FromArgb(240, 240, 250); // Light background color
            cbo.ForeColor = Color.Black;
            cbo.Width = 280; // Increased width
            cbo.Height = 45; // Increased height
        }

        private void StyleButton(Button btn, Color bg)
        {
            btn.BackColor = bg;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold); // Increased font size
            btn.Cursor = Cursors.Hand;
            btn.Width = 150; // Increased width
            btn.Height = 50; // Increased height
            btn.MouseEnter += (s, e) => btn.BackColor = ControlPaint.Light(bg);
            btn.MouseLeave += (s, e) => btn.BackColor = bg;
        }
    }
}
