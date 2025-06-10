using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using StudentManagementSystem;

namespace StudentManagementSystem.Forms
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
            this.Text = "Add Student";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Customize input fields and controls
            CustomizeTextBox(txtName, "Enter full name");
            CustomizeTextBox(txtAge, "Enter age");
            CustomizeComboBox(cboClass);
            CustomizeDatePicker(dtpEnrollment);
            CustomizeButton(btnSave, Color.FromArgb(0, 129, 138));  // Teal button color

            // Add class options to ComboBox
            cboClass.Items.AddRange(new[] { "Class A", "Class B", "Class C" });
            cboClass.SelectedIndex = 0;
            dtpEnrollment.Value = DateTime.Today;
        }

        // Gradient effect for header panel (from blue to teal)
        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(panelHeader.ClientRectangle,
                                                      Color.FromArgb(0, 94, 158),   // Blue gradient start
                                                      Color.FromArgb(0, 129, 138),   // Teal gradient end
                                                      45F))
            {
                e.Graphics.FillRectangle(brush, panelHeader.ClientRectangle);
            }
        }

        // Customizes the appearance of TextBox controls
        private void CustomizeTextBox(TextBox txt, string placeholder)
        {
            txt.Font = new Font("Segoe UI", 11F);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = Color.FromArgb(224, 242, 241);
            txt.ForeColor = Color.Gray;
            txt.Width = 300;
            txt.Height = 30;
            txt.Text = placeholder;

            // Event handler for when the TextBox gains focus
            txt.GotFocus += (s, e) =>
            {
                if (txt.Text == placeholder) txt.Text = "";
                txt.ForeColor = Color.FromArgb(33, 33, 33);
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

        // Customizes the appearance of ComboBox controls
        private void CustomizeComboBox(ComboBox cbo)
        {
            cbo.Font = new Font("Segoe UI", 11F);
            cbo.FlatStyle = FlatStyle.Flat;
            cbo.BackColor = Color.FromArgb(224, 242, 241);
            cbo.ForeColor = Color.FromArgb(33, 33, 33);
            cbo.Width = 300;
            cbo.Height = 30;
        }

        // Customizes the appearance of DateTimePicker controls
        private void CustomizeDatePicker(DateTimePicker dtp)
        {
            dtp.Font = new Font("Segoe UI", 11F);
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Width = 300;
            dtp.Height = 30;
            dtp.CalendarForeColor = Color.FromArgb(33, 33, 33);
            dtp.CalendarMonthBackground = Color.FromArgb(224, 242, 241);
        }

        // Customizes the appearance of Button controls
        private void CustomizeButton(Button btn, Color backColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn.Height = 40;
            btn.Width = 120;
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleCenter;

            // Event handler for mouse hover (lighten button color)
            btn.MouseEnter += (s, e) => btn.BackColor = ControlPaint.Light(backColor);

            // Event handler for mouse leave (reset button color)
            btn.MouseLeave += (s, e) => btn.BackColor = backColor;
        }

        // Click event handler for the "Save" button
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate name input
            string name = txtName.Text.Trim();
            if (name == "Enter full name" || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate age input
            if (!int.TryParse(txtAge.Text.Trim(), out int age) || age < 5 || age > 100)
            {
                MessageBox.Show("Please enter a valid age between 5 and 100.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate class selection
            if (cboClass.SelectedItem == null)
            {
                MessageBox.Show("Please select a class.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new student object and add it to the data store
            var student = new Student
            {
                Name = name,
                Age = age,
                Class = cboClass.SelectedItem.ToString(),
                EnrollmentDate = dtpEnrollment.Value
            };

            DataStore.Students.Add(student);

            // Inform the user that the student was successfully saved
            MessageBox.Show("Student record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();  // Close the form after saving
        }
    }
}
