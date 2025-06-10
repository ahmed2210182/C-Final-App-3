using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    partial class ViewStudentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvStudents;
        private Label lblSearchName;
        private TextBox txtSearchName;
        private Label lblSearchClass;
        private ComboBox cboFilterClass;
        private Button btnSearch;
        private Button btnReset;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvStudents = new DataGridView();
            lblSearchName = new Label();
            txtSearchName = new TextBox();
            lblSearchClass = new Label();
            cboFilterClass = new ComboBox();
            btnSearch = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudents.Location = new Point(20, 70);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(680, 260);
            dgvStudents.TabIndex = 6;
            // 
            // lblSearchName
            // 
            lblSearchName.AutoSize = true;
            lblSearchName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearchName.ForeColor = Color.LightSkyBlue;
            lblSearchName.Location = new Point(20, 20);
            lblSearchName.Name = "lblSearchName";
            lblSearchName.Size = new Size(52, 20);
            lblSearchName.TabIndex = 0;
            lblSearchName.Text = "Name:";
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(90, 18);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(100, 23);
            txtSearchName.TabIndex = 1;
            // 
            // lblSearchClass
            // 
            lblSearchClass.AutoSize = true;
            lblSearchClass.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearchClass.ForeColor = Color.LightSkyBlue;
            lblSearchClass.Location = new Point(300, 20);
            lblSearchClass.Name = "lblSearchClass";
            lblSearchClass.Size = new Size(45, 20);
            lblSearchClass.TabIndex = 2;
            lblSearchClass.Text = "Class:";
            // 
            // cboFilterClass
            // 
            cboFilterClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterClass.Location = new Point(360, 18);
            cboFilterClass.Name = "cboFilterClass";
            cboFilterClass.Size = new Size(120, 23);
            cboFilterClass.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(500, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(590, 18);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            // 
            // ViewStudentsForm
            // 
            ClientSize = new Size(720, 360);
            Controls.Add(lblSearchName);
            Controls.Add(txtSearchName);
            Controls.Add(lblSearchClass);
            Controls.Add(cboFilterClass);
            Controls.Add(btnSearch);
            Controls.Add(btnReset);
            Controls.Add(dgvStudents);
            Name = "ViewStudentsForm";
            Text = "View & Search Students";
            Load += ViewStudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
