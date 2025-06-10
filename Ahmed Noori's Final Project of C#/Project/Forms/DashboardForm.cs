using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StudentManagementSystem;

namespace StudentManagementSystem.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            // Set window properties
            this.Text = $"Dashboard - {SessionManager.Role}";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;

            // Customize panel colors
            panelHeader.BackColor = Color.FromArgb(55, 71, 79);
            panelSidebar.BackColor = Color.FromArgb(38, 50, 56);
            panelMain.BackColor = Color.WhiteSmoke;

            // Style the header label
            lblHeader.ForeColor = Color.White;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);

            // Set up the role label
            lblRole.ForeColor = Color.WhiteSmoke;
            lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblRole.Text = $"Role: {SessionManager.Role}";

            // Customize the Logout button
            btnLogout.BackColor = Color.FromArgb(244, 67, 54); // Red button color
            btnLogout.ForeColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Click += (s, e) => this.Close();

            // Style the dashboard buttons
            StyleButton(btn0, Color.FromArgb(76, 175, 80));   // Add Student
            StyleButton(btn1, Color.FromArgb(33, 150, 243));  // View Students
            StyleButton(btn2, Color.FromArgb(255, 152, 0));   // Edit Student
            StyleButton(btn3, Color.FromArgb(156, 39, 176));  // View Reports
            StyleButton(btnDelete, Color.FromArgb(233, 67, 53)); // Delete Student

            // Disable certain buttons for Teacher role
            if (SessionManager.Role == "Teacher")
            {
                btn0.Enabled = false;
                btn2.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        // Method to style buttons
        private void StyleButton(Button btn, Color backColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn.Width = 200;
            btn.Height = 100;
            btn.Margin = new Padding(10);
            btn.Cursor = Cursors.Hand;

            // Hover effect
            btn.MouseEnter += (s, e) => btn.BackColor = ControlPaint.Light(backColor);
            btn.MouseLeave += (s, e) => btn.BackColor = backColor;
        }

        // Button click event handlers
        private void btn0_Click(object sender, EventArgs e) => new AddStudentForm().ShowDialog();
        private void btn1_Click(object sender, EventArgs e) => new ViewStudentsForm().ShowDialog();
        private void btn2_Click(object sender, EventArgs e) => new EditStudentForm(0).ShowDialog();
        private void btn3_Click(object sender, EventArgs e) => new ReportsForm().ShowDialog();

        // Delete button functionality with student selection prompt
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Retrieve a list of student names for deletion
            var names = DataStore.Students.Select(s => s.Name).ToArray();
            string selectedName = Prompt.ShowDialog("Select student to delete:", "Delete Student", names);
            if (selectedName == null) return;

            // Find the selected student in the data store
            var student = DataStore.Students.First(s => s.Name == selectedName);

            // Confirm the deletion action
            var result = MessageBox.Show(
                $"Are you sure you want to delete {student.Name}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // If confirmed, delete the student
            if (result == DialogResult.Yes)
            {
                DataStore.Students.Remove(student);
                MessageBox.Show("Student deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // The method that runs when the form is loaded
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Any logic required when the dashboard form loads can be added here
        }
    }

    // Helper class to show a prompt for student selection (deletion)
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string[] options)
        {
            using var dlg = new Form()
            {
                Width = 300,
                Height = 180,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            var lbl = new Label() { Left = 10, Top = 10, Text = text, AutoSize = true };
            var cb = new ComboBox() { Left = 10, Top = 40, Width = 260, DropDownStyle = ComboBoxStyle.DropDownList };
            cb.Items.AddRange(options);
            if (options.Length > 0) cb.SelectedIndex = 0;

            var btnOK = new Button() { Text = "OK", Left = 60, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            var btnCancel = new Button() { Text = "Cancel", Left = 150, Width = 80, Top = 80, DialogResult = DialogResult.Cancel };

            dlg.Controls.AddRange(new Control[] { lbl, cb, btnOK, btnCancel });
            dlg.AcceptButton = btnOK;
            dlg.CancelButton = btnCancel;

            // Return the selected item, or null if canceled
            return dlg.ShowDialog() == DialogResult.OK ? cb.SelectedItem.ToString() : null;
        }
    }
}
