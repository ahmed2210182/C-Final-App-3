using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblHeader;
        private Button btnGenerateReport;
        private Button btnPrintPreview;
        private TextBox txtReport;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDocument printDocument1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            panelHeader = new Panel();
            lblHeader = new Label();
            btnGenerateReport = new Button();
            btnPrintPreview = new Button();
            txtReport = new TextBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new PrintDocument();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(650, 60);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(103, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Reports";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(20, 80);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(75, 23);
            btnGenerateReport.TabIndex = 1;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnPrintPreview
            // 
            btnPrintPreview.Location = new Point(180, 80);
            btnPrintPreview.Name = "btnPrintPreview";
            btnPrintPreview.Size = new Size(75, 23);
            btnPrintPreview.TabIndex = 2;
            btnPrintPreview.Text = "Print Preview";
            btnPrintPreview.Click += btnPrintPreview_Click;
            // 
            // txtReport
            // 
            txtReport.Location = new Point(20, 140);
            txtReport.Name = "txtReport";
            txtReport.ReadOnly = true;
            txtReport.Size = new Size(600, 23);
            txtReport.TabIndex = 3;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ReportsForm
            // 
            ClientSize = new Size(650, 400);
            Controls.Add(panelHeader);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnPrintPreview);
            Controls.Add(txtReport);
            Name = "ReportsForm";
            Text = "Reports";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
