using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    partial class AddStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelContainer;
        private Label lblName;
        private TextBox txtName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblClass;
        private ComboBox cboClass;
        private Label lblEnrollment;
        private DateTimePicker dtpEnrollment;
        private Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            panelContainer = new Panel();
            lblName = new Label();
            txtName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblClass = new Label();
            cboClass = new ComboBox();
            lblEnrollment = new Label();
            dtpEnrollment = new DateTimePicker();
            btnSave = new Button();
            panelHeader.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(500, 60);
            panelHeader.TabIndex = 1;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(317, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Student";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(224, 242, 241);
            panelContainer.Controls.Add(lblName);
            panelContainer.Controls.Add(txtName);
            panelContainer.Controls.Add(lblAge);
            panelContainer.Controls.Add(txtAge);
            panelContainer.Controls.Add(lblClass);
            panelContainer.Controls.Add(cboClass);
            panelContainer.Controls.Add(lblEnrollment);
            panelContainer.Controls.Add(dtpEnrollment);
            panelContainer.Controls.Add(btnSave);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 60);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(30);
            panelContainer.Size = new Size(500, 260);
            panelContainer.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(33, 33, 33);
            lblName.Location = new Point(30, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 31);
            txtName.TabIndex = 1;
            // 
            // lblAge
            // 
            lblAge.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblAge.ForeColor = Color.FromArgb(33, 33, 33);
            lblAge.Location = new Point(30, 80);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(120, 78);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(300, 31);
            txtAge.TabIndex = 3;
            // 
            // lblClass
            // 
            lblClass.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblClass.ForeColor = Color.FromArgb(33, 33, 33);
            lblClass.Location = new Point(30, 130);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(100, 23);
            lblClass.TabIndex = 4;
            lblClass.Text = "Class:";
            // 
            // cboClass
            // 
            cboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClass.Location = new Point(120, 128);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(300, 33);
            cboClass.TabIndex = 5;
            // 
            // lblEnrollment
            // 
            lblEnrollment.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnrollment.ForeColor = Color.FromArgb(33, 33, 33);
            lblEnrollment.Location = new Point(30, 180);
            lblEnrollment.Name = "lblEnrollment";
            lblEnrollment.Size = new Size(100, 23);
            lblEnrollment.TabIndex = 6;
            lblEnrollment.Text = "Enrolled:";
            // 
            // dtpEnrollment
            // 
            dtpEnrollment.Location = new Point(120, 178);
            dtpEnrollment.Name = "dtpEnrollment";
            dtpEnrollment.Size = new Size(300, 31);
            dtpEnrollment.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 129, 138);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(120, 230);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddStudentForm
            // 
            ClientSize = new Size(500, 320);
            Controls.Add(panelContainer);
            Controls.Add(panelHeader);
            Name = "AddStudentForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
