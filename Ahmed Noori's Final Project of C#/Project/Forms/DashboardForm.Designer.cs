using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblHeader;
        private Button btnLogout;
        private Panel panelSidebar;
        private Label lblRole;
        private Panel panelMain;
        private FlowLayoutPanel flpButtons;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblHeader = new Label();
            btnLogout = new Button();
            panelSidebar = new Panel();
            lblRole = new Label();
            panelMain = new Panel();
            flpButtons = new FlowLayoutPanel();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnDelete = new Button();
            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(600, 60);
            panelHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(20, 18);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(64, 15);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Dashboard";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(500, 15);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(80, 30);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(lblRole);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 60);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(160, 340);
            panelSidebar.TabIndex = 1;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(20, 20);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(0, 15);
            lblRole.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(flpButtons);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(160, 60);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(440, 340);
            panelMain.TabIndex = 0;
            // 
            // flpButtons
            // 
            flpButtons.AutoScroll = true;
            flpButtons.Controls.Add(btn0);
            flpButtons.Controls.Add(btn1);
            flpButtons.Controls.Add(btn2);
            flpButtons.Controls.Add(btn3);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.FlowDirection = FlowDirection.TopDown;
            flpButtons.Location = new Point(0, 0);
            flpButtons.Name = "flpButtons";
            flpButtons.Padding = new Padding(20);
            flpButtons.Size = new Size(440, 340);
            flpButtons.TabIndex = 0;
            flpButtons.WrapContents = false;
            // 
            // btn0
            // 
            btn0.Location = new Point(23, 23);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 23);
            btn0.TabIndex = 0;
            btn0.Text = "Add Student";
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(23, 52);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 1;
            btn1.Text = "View Students";
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(23, 81);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 2;
            btn2.Text = "Edit Student";
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(23, 110);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 23);
            btn3.TabIndex = 3;
            btn3.Text = "Reports";
            btn3.Click += btn3_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(23, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Student";
            btnDelete.Click += btnDelete_Click;
            // 
            // DashboardForm
            // 
            ClientSize = new Size(600, 400);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DashboardForm";
            Load += DashboardForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelMain.ResumeLayout(false);
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
