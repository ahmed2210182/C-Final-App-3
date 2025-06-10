namespace StudentManagementSystem.Forms
{
    partial class EditStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lblEnrollment;
        private System.Windows.Forms.DateTimePicker dtpEnrollment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblAge = new System.Windows.Forms.Label();
            txtAge = new System.Windows.Forms.TextBox();
            lblClass = new System.Windows.Forms.Label();
            cboClass = new System.Windows.Forms.ComboBox();
            lblEnrollment = new System.Windows.Forms.Label();
            dtpEnrollment = new System.Windows.Forms.DateTimePicker();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = System.Drawing.Color.White;
            lblName.Location = new System.Drawing.Point(50, 80);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(120, 75);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(200, 23);
            txtName.TabIndex = 1;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.ForeColor = System.Drawing.Color.White;
            lblAge.Location = new System.Drawing.Point(50, 130);
            lblAge.Name = "lblAge";
            lblAge.Size = new System.Drawing.Size(31, 15);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new System.Drawing.Point(120, 125);
            txtAge.Name = "txtAge";
            txtAge.Size = new System.Drawing.Size(200, 23);
            txtAge.TabIndex = 3;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.ForeColor = System.Drawing.Color.White;
            lblClass.Location = new System.Drawing.Point(50, 180);
            lblClass.Name = "lblClass";
            lblClass.Size = new System.Drawing.Size(37, 15);
            lblClass.TabIndex = 4;
            lblClass.Text = "Class:";
            // 
            // cboClass
            // 
            cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboClass.Location = new System.Drawing.Point(120, 175);
            cboClass.Name = "cboClass";
            cboClass.Size = new System.Drawing.Size(200, 23);
            cboClass.TabIndex = 5;
            // 
            // lblEnrollment
            // 
            lblEnrollment.AutoSize = true;
            lblEnrollment.ForeColor = System.Drawing.Color.White;
            lblEnrollment.Location = new System.Drawing.Point(50, 230);
            lblEnrollment.Name = "lblEnrollment";
            lblEnrollment.Size = new System.Drawing.Size(68, 15);
            lblEnrollment.TabIndex = 6;
            lblEnrollment.Text = "Enrollment:";
            // 
            // dtpEnrollment
            // 
            dtpEnrollment.Location = new System.Drawing.Point(150, 225);
            dtpEnrollment.Name = "dtpEnrollment";
            dtpEnrollment.Size = new System.Drawing.Size(200, 23);
            dtpEnrollment.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.SeaGreen;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(120, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(80, 35);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.DarkRed;
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(220, 280);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(80, 35);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(lblClass);
            panel1.Controls.Add(cboClass);
            panel1.Controls.Add(lblEnrollment);
            panel1.Controls.Add(dtpEnrollment);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(660, 360);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            label1.Location = new System.Drawing.Point(20, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 30);
            label1.TabIndex = 10;
            label1.Text = "Edit Student";
            // 
            // EditStudentForm
            // 
            ClientSize = new System.Drawing.Size(660, 360);
            Controls.Add(panel1);
            Name = "EditStudentForm";
            Text = "Edit Student";
            Load += EditStudentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
