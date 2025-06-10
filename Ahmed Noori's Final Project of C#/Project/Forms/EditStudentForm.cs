using System;
using System.Drawing;
using System.Windows.Forms;
using StudentManagementSystem;

namespace StudentManagementSystem.Forms
{
    public partial class EditStudentForm : Form
    {
        private int studentIndex;

        public EditStudentForm(int index)
        {
            InitializeComponent();
            studentIndex = index;

            // Load the selected student data
            var student = DataStore.Students[studentIndex];
            txtName.Text = student.Name;
            txtAge.Text = student.Age.ToString();
            cboClass.Items.AddRange(new string[] { "Class A", "Class B", "Class C" });
            cboClass.SelectedItem = student.Class;
            dtpEnrollment.Value = student.EnrollmentDate;
        }

        // Save button functionality
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate age input
            if (!int.TryParse(txtAge.Text.Trim(), out int age))
            {
                MessageBox.Show("Please enter a valid age.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (age < 5 || age > 100)
            {
                MessageBox.Show("Age must be between 5 and 100.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate class selection
            if (cboClass.SelectedItem == null)
            {
                MessageBox.Show("Please select a class.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update student data
            var student = DataStore.Students[studentIndex];
            student.Name = name;
            student.Age = age;
            student.Class = cboClass.SelectedItem.ToString();
            student.EnrollmentDate = dtpEnrollment.Value;

            // Inform the user that the data has been updated
            MessageBox.Show("Student record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // Cancel button functionality
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Form load event (can be used for additional initialization if necessary)
        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            // Additional code for form initialization can be added here if needed
        }

        // Styling method for controls
        private void StyleTextBox(TextBox txt, string placeholder)
        {
            txt.Font = new Font("Segoe UI", 12F);  // Increased font size
            txt.ForeColor = Color.Gray;
            txt.BackColor = Color.FromArgb(230, 230, 250);  // Lighter background color
            txt.Text = placeholder;
            txt.Width = 350;  // Increased width
            txt.Height = 35;  // Increased height

            // Event handler for when the TextBox gains focus
            txt.GotFocus += (s, e) =>
            {
                if (txt.Text == placeholder) txt.Text = "";
                txt.ForeColor = Color.FromArgb(50, 50, 50);  // Darker color for active text
            };

            // Event handler for when the TextBox loses focus
            txt.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        // Styling method for ComboBox controls
        private void StyleComboBox(ComboBox cbo)
        {
            cbo.Font = new Font("Segoe UI", 12F);
            cbo.BackColor = Color.FromArgb(230, 230, 250);  // Lighter background color
            cbo.ForeColor = Color.FromArgb(50, 50, 50);  // Darker text
            cbo.Width = 350;  // Increased width
            cbo.Height = 35;  // Increased height
        }

        // Styling method for DateTimePicker controls
        private void StyleDateTimePicker(DateTimePicker dtp)
        {
            dtp.Font = new Font("Segoe UI", 12F);
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Width = 350;  // Increased width
            dtp.Height = 35;  // Increased height
            dtp.CalendarForeColor = Color.FromArgb(50, 50, 50);
            dtp.CalendarMonthBackground = Color.FromArgb(230, 230, 250);  // Lighter background color
        }

        // Styling method for Button controls
        private void StyleButton(Button btn, Color backColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);  // Increased font size
            btn.Width = 160;  // Increased width
            btn.Height = 50;  // Increased height
            btn.Cursor = Cursors.Hand;

            // Hover effect
            btn.MouseEnter += (s, e) => btn.BackColor = ControlPaint.Light(backColor);
            btn.MouseLeave += (s, e) => btn.BackColor = backColor;
        }
    }
}
