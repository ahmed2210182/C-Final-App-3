using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using StudentManagementSystem;

namespace StudentManagementSystem.Forms
{
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
            InitializeComponent();
            this.Text = "View & Search Students";
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(40, 40, 70);  // Darker background color for a modern look

            // Style the controls
            StyleTextBox(txtSearchName, "Search by name...");
            StyleComboBox(cboFilterClass);
            StyleButton(btnSearch, Color.FromArgb(255, 87, 34));  // Orange button for search
            StyleButton(btnReset, Color.FromArgb(76, 175, 80));     // Green button for reset
            StyleDataGrid(dgvStudents);

            // Populate the filter ComboBox with class options
            cboFilterClass.Items.AddRange(new[] { "All", "Class A", "Class B", "Class C" });
            cboFilterClass.SelectedIndex = 0;

            // Load all student data initially
            LoadData(DataStore.Students);
        }

        // Load student data into the DataGridView
        private void LoadData(System.Collections.Generic.List<Student> students)
        {
            dgvStudents.DataSource = students.Select(s => new
            {
                s.Name,
                s.Age,
                Class = s.Class,
                EnrollmentDate = s.EnrollmentDate.ToShortDateString()
            }).ToList();
        }

        // Handle the Search button click event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = DataStore.Students.AsEnumerable();

            // Search by name if the textbox is not empty
            if (!string.IsNullOrWhiteSpace(txtSearchName.Text) && txtSearchName.ForeColor == Color.Black)
                query = query.Where(s => s.Name.IndexOf(txtSearchName.Text, StringComparison.OrdinalIgnoreCase) >= 0);

            // Filter by class if selected
            if (cboFilterClass.SelectedIndex > 0)
            {
                var selectedClass = cboFilterClass.SelectedItem.ToString();
                query = query.Where(s => s.Class == selectedClass);
            }

            var result = query.ToList();

            // Show a message if no records match the search criteria
            if (!result.Any())
                MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Load the filtered data into the DataGridView
            LoadData(result);
        }

        // Handle the Reset button click event
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset the search and filter
            txtSearchName.Text = "Search by name...";
            txtSearchName.ForeColor = Color.Gray;
            cboFilterClass.SelectedIndex = 0;

            // Reload all student data
            LoadData(DataStore.Students);
        }

        // Styling Methods

        // Style the TextBox with placeholder text
        private void StyleTextBox(TextBox txt, string placeholder)
        {
            txt.Font = new Font("Segoe UI", 12F);  // Increased font size for better readability
            txt.ForeColor = Color.Gray;
            txt.BackColor = Color.FromArgb(230, 230, 250);  // Lighter background color
            txt.Text = placeholder;
            txt.Width = 350;  // Increased width
            txt.Height = 40;  // Increased height

            // Event to clear the placeholder text when focused
            txt.GotFocus += (s, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            // Event to restore placeholder text if no input
            txt.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        // Style the ComboBox with a clean appearance
        private void StyleComboBox(ComboBox cbo)
        {
            cbo.Font = new Font("Segoe UI", 12F);  // Increased font size
            cbo.ForeColor = Color.FromArgb(33, 33, 33);
            cbo.BackColor = Color.FromArgb(230, 230, 250);  // Lighter background color
            cbo.Width = 350;  // Increased width
            cbo.Height = 40;  // Increased height
        }

        // Style the Button with hover effects
        private void StyleButton(Button btn, Color backColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);  // Larger font size for better clarity
            btn.Cursor = Cursors.Hand;
            btn.Height = 45;  // Increased height for more clickable area
            btn.Width = 100;  // Increased width

            // Hover effect for the button
            btn.MouseEnter += (s, e) => btn.BackColor = ControlPaint.Light(backColor);
            btn.MouseLeave += (s, e) => btn.BackColor = backColor;
        }

        // Style the DataGridView for a clean, modern look
        private void StyleDataGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(245, 245, 248);
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 94, 158);  // Teal color for the header
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);  // Larger font for the header
            dgv.RowTemplate.Height = 35;  // Increased row height for readability
            dgv.GridColor = Color.FromArgb(200, 200, 200);  // Lighter grid color
        }

        private void ViewStudentsForm_Load(object sender, EventArgs e)
        {
            // Additional logic can be added here if needed when the form loads
        }
    }
}
