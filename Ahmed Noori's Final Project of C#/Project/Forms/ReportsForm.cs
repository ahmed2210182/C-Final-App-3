using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using StudentManagementSystem;

namespace StudentManagementSystem.Forms
{
    public partial class ReportsForm : Form
    {
        private string reportText;

        public ReportsForm()
        {
            InitializeComponent();
            this.Text = "Reports";
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(40, 40, 70); // Darker background color for a more modern look

            // Style UI controls
            StylePanelHeader(panelHeader);
            StyleButton(btnGenerateReport, Color.FromArgb(0, 150, 136)); // Teal button for report generation
            StyleButton(btnPrintPreview, Color.FromArgb(33, 150, 243)); // Blue button for print preview
            StyleTextBox(txtReport);
        }

        // Generate the report when the Generate Report button is clicked
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Create the report text
            reportText = string.Join(Environment.NewLine,
                DataStore.Students.Select(s => $"{s.Name}, Age: {s.Age}, Class: {s.Class}, Enrolled: {s.EnrollmentDate:d}"));

            // Display the generated report in the text box
            txtReport.Text = reportText;
        }

        // Show the print preview when the Print Preview button is clicked
        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        // Print the report when the PrintPage event is triggered
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(reportText, new Font("Segoe UI", 14F), Brushes.Black, new PointF(50, 50));
        }

        // Styling methods for various controls

        // Style the header panel with a gradient background
        private void StylePanelHeader(Panel pnl)
        {
            pnl.Paint += (s, e) =>
            {
                using (var brush = new LinearGradientBrush(pnl.ClientRectangle,
                                                          Color.FromArgb(0, 153, 136), // New gradient start color (Teal)
                                                          Color.FromArgb(0, 183, 158), // New gradient end color (Light Teal)
                                                          45F)) // Gradient direction
                {
                    e.Graphics.FillRectangle(brush, pnl.ClientRectangle);
                }
            };
        }

        // Style buttons with specific background color and hover effect
        private void StyleButton(Button btn, Color bg)
        {
            btn.BackColor = bg;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold); // Slightly larger font
            btn.Cursor = Cursors.Hand;
            btn.Height = 50;  // Increased height for better accessibility
            btn.Width = 160;  // Increased width for a more prominent button

            // Hover effect to lighten the button color
            btn.MouseEnter += (s, e) => btn.BackColor = ControlPaint.Light(bg);
            btn.MouseLeave += (s, e) => btn.BackColor = bg;
        }

        // Style the text box for displaying the report
        private void StyleTextBox(TextBox txt)
        {
            txt.Font = new Font("Consolas", 12F); // Increased font size for better readability
            txt.BackColor = Color.FromArgb(250, 250, 250); // Lighter background color
            txt.ForeColor = Color.FromArgb(50, 50, 50); // Darker text for readability
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Multiline = true;
            txt.ScrollBars = ScrollBars.Vertical;
            txt.Width = 500; // Increased width to fit the content
            txt.Height = 300; // Increased height for larger content display
        }

        // Optional: Empty header paint handler for additional customizations
        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            // If needed, additional painting logic can be added here for customizations
        }
    }
}
