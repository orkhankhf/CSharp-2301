namespace EmployeeManagementSystem
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.employeeSurname = new System.Windows.Forms.TextBox();
            this.employeeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.male = new System.Windows.Forms.CheckBox();
            this.female = new System.Windows.Forms.CheckBox();
            this.employeeJobDetails = new System.Windows.Forms.RichTextBox();
            this.uploadImageBtn = new System.Windows.Forms.Button();
            this.uploadCvBtn = new System.Windows.Forms.Button();
            this.addNewEmployeeBtn = new System.Windows.Forms.Button();
            this.removeEmployeeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(780, 380);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uploadCvBtn);
            this.groupBox1.Controls.Add(this.uploadImageBtn);
            this.groupBox1.Controls.Add(this.employeeJobDetails);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.employeeBirthDate);
            this.groupBox1.Controls.Add(this.employeeSurname);
            this.groupBox1.Controls.Add(this.employeeName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(798, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Job Details";
            // 
            // employeeName
            // 
            this.employeeName.Location = new System.Drawing.Point(77, 24);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(217, 20);
            this.employeeName.TabIndex = 1;
            // 
            // employeeSurname
            // 
            this.employeeSurname.Location = new System.Drawing.Point(77, 50);
            this.employeeSurname.Name = "employeeSurname";
            this.employeeSurname.Size = new System.Drawing.Size(217, 20);
            this.employeeSurname.TabIndex = 1;
            // 
            // employeeBirthDate
            // 
            this.employeeBirthDate.Location = new System.Drawing.Point(77, 76);
            this.employeeBirthDate.Name = "employeeBirthDate";
            this.employeeBirthDate.Size = new System.Drawing.Size(217, 20);
            this.employeeBirthDate.TabIndex = 2;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(77, 102);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 17);
            this.male.TabIndex = 3;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(163, 102);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(60, 17);
            this.female.TabIndex = 3;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // employeeJobDetails
            // 
            this.employeeJobDetails.Location = new System.Drawing.Point(77, 217);
            this.employeeJobDetails.Name = "employeeJobDetails";
            this.employeeJobDetails.Size = new System.Drawing.Size(217, 117);
            this.employeeJobDetails.TabIndex = 4;
            this.employeeJobDetails.Text = "";
            // 
            // uploadImageBtn
            // 
            this.uploadImageBtn.Location = new System.Drawing.Point(77, 125);
            this.uploadImageBtn.Name = "uploadImageBtn";
            this.uploadImageBtn.Size = new System.Drawing.Size(217, 40);
            this.uploadImageBtn.TabIndex = 5;
            this.uploadImageBtn.Text = "Upload Image";
            this.uploadImageBtn.UseVisualStyleBackColor = true;
            this.uploadImageBtn.Click += new System.EventHandler(this.uploadImageBtn_Click);
            // 
            // uploadCvBtn
            // 
            this.uploadCvBtn.Location = new System.Drawing.Point(77, 171);
            this.uploadCvBtn.Name = "uploadCvBtn";
            this.uploadCvBtn.Size = new System.Drawing.Size(217, 40);
            this.uploadCvBtn.TabIndex = 5;
            this.uploadCvBtn.Text = "Upload CV";
            this.uploadCvBtn.UseVisualStyleBackColor = true;
            this.uploadCvBtn.Click += new System.EventHandler(this.uploadCvBtn_Click);
            // 
            // addNewEmployeeBtn
            // 
            this.addNewEmployeeBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.addNewEmployeeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewEmployeeBtn.Location = new System.Drawing.Point(798, 358);
            this.addNewEmployeeBtn.Name = "addNewEmployeeBtn";
            this.addNewEmployeeBtn.Size = new System.Drawing.Size(300, 34);
            this.addNewEmployeeBtn.TabIndex = 2;
            this.addNewEmployeeBtn.Text = "Add";
            this.addNewEmployeeBtn.UseVisualStyleBackColor = false;
            this.addNewEmployeeBtn.Click += new System.EventHandler(this.addNewEmployeeBtn_Click);
            // 
            // removeEmployeeBtn
            // 
            this.removeEmployeeBtn.BackColor = System.Drawing.Color.Red;
            this.removeEmployeeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeEmployeeBtn.Location = new System.Drawing.Point(12, 398);
            this.removeEmployeeBtn.Name = "removeEmployeeBtn";
            this.removeEmployeeBtn.Size = new System.Drawing.Size(185, 40);
            this.removeEmployeeBtn.TabIndex = 3;
            this.removeEmployeeBtn.Text = "Delete Selected Employee";
            this.removeEmployeeBtn.UseVisualStyleBackColor = false;
            this.removeEmployeeBtn.Click += new System.EventHandler(this.removeEmployeeBtn_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 461);
            this.Controls.Add(this.removeEmployeeBtn);
            this.Controls.Add(this.addNewEmployeeBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employeesDataGridView);
            this.Name = "Employees";
            this.Text = "Employee Control System";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uploadCvBtn;
        private System.Windows.Forms.Button uploadImageBtn;
        private System.Windows.Forms.RichTextBox employeeJobDetails;
        private System.Windows.Forms.CheckBox female;
        private System.Windows.Forms.CheckBox male;
        private System.Windows.Forms.DateTimePicker employeeBirthDate;
        private System.Windows.Forms.TextBox employeeSurname;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewEmployeeBtn;
        private System.Windows.Forms.Button removeEmployeeBtn;
    }
}