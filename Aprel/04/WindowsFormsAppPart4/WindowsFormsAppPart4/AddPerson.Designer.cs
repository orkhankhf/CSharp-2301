namespace WindowsFormsAppPart4
{
    partial class AddPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.docSerialTextBox = new System.Windows.Forms.TextBox();
            this.docNumberTextBox = new System.Windows.Forms.TextBox();
            this.saveFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vəsiqənin Seriyası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vəsiqənin nömrəsi";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(178, 46);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(160, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(178, 72);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(160, 20);
            this.surnameTextBox.TabIndex = 1;
            // 
            // docSerialTextBox
            // 
            this.docSerialTextBox.Location = new System.Drawing.Point(178, 98);
            this.docSerialTextBox.Name = "docSerialTextBox";
            this.docSerialTextBox.Size = new System.Drawing.Size(160, 20);
            this.docSerialTextBox.TabIndex = 1;
            // 
            // docNumberTextBox
            // 
            this.docNumberTextBox.Location = new System.Drawing.Point(178, 124);
            this.docNumberTextBox.Name = "docNumberTextBox";
            this.docNumberTextBox.Size = new System.Drawing.Size(160, 20);
            this.docNumberTextBox.TabIndex = 1;
            // 
            // saveFormBtn
            // 
            this.saveFormBtn.Location = new System.Drawing.Point(178, 172);
            this.saveFormBtn.Name = "saveFormBtn";
            this.saveFormBtn.Size = new System.Drawing.Size(160, 41);
            this.saveFormBtn.TabIndex = 2;
            this.saveFormBtn.Text = "Yadda Saxcla";
            this.saveFormBtn.UseVisualStyleBackColor = true;
            this.saveFormBtn.Click += new System.EventHandler(this.saveFormBtn_Click);
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 269);
            this.Controls.Add(this.saveFormBtn);
            this.Controls.Add(this.docNumberTextBox);
            this.Controls.Add(this.docSerialTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPerson";
            this.Text = "Məlumat Əlavə Etmə";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox docSerialTextBox;
        private System.Windows.Forms.TextBox docNumberTextBox;
        private System.Windows.Forms.Button saveFormBtn;
    }
}

