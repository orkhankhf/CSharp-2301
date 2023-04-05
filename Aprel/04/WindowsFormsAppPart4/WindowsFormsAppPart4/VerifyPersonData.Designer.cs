namespace WindowsFormsAppPart4
{
    partial class VerifyPersonData
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
            this.docNumberDisabledTextBox = new System.Windows.Forms.TextBox();
            this.docSerialDisabledTextBox = new System.Windows.Forms.TextBox();
            this.surnameDisabledTextBox = new System.Windows.Forms.TextBox();
            this.nameDisabledTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitFormBtn = new System.Windows.Forms.Button();
            this.cancelFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // docNumberDisabledTextBox
            // 
            this.docNumberDisabledTextBox.Enabled = false;
            this.docNumberDisabledTextBox.Location = new System.Drawing.Point(163, 117);
            this.docNumberDisabledTextBox.Name = "docNumberDisabledTextBox";
            this.docNumberDisabledTextBox.Size = new System.Drawing.Size(160, 20);
            this.docNumberDisabledTextBox.TabIndex = 6;
            // 
            // docSerialDisabledTextBox
            // 
            this.docSerialDisabledTextBox.Enabled = false;
            this.docSerialDisabledTextBox.Location = new System.Drawing.Point(163, 91);
            this.docSerialDisabledTextBox.Name = "docSerialDisabledTextBox";
            this.docSerialDisabledTextBox.Size = new System.Drawing.Size(160, 20);
            this.docSerialDisabledTextBox.TabIndex = 7;
            // 
            // surnameDisabledTextBox
            // 
            this.surnameDisabledTextBox.Enabled = false;
            this.surnameDisabledTextBox.Location = new System.Drawing.Point(163, 65);
            this.surnameDisabledTextBox.Name = "surnameDisabledTextBox";
            this.surnameDisabledTextBox.Size = new System.Drawing.Size(160, 20);
            this.surnameDisabledTextBox.TabIndex = 8;
            // 
            // nameDisabledTextBox
            // 
            this.nameDisabledTextBox.Enabled = false;
            this.nameDisabledTextBox.Location = new System.Drawing.Point(163, 39);
            this.nameDisabledTextBox.Name = "nameDisabledTextBox";
            this.nameDisabledTextBox.Size = new System.Drawing.Size(160, 20);
            this.nameDisabledTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vəsiqənin nömrəsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vəsiqənin Seriyası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad";
            // 
            // submitFormBtn
            // 
            this.submitFormBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.submitFormBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.submitFormBtn.Location = new System.Drawing.Point(163, 159);
            this.submitFormBtn.Name = "submitFormBtn";
            this.submitFormBtn.Size = new System.Drawing.Size(160, 33);
            this.submitFormBtn.TabIndex = 10;
            this.submitFormBtn.Text = "Təsdiqlə";
            this.submitFormBtn.UseVisualStyleBackColor = false;
            this.submitFormBtn.Click += new System.EventHandler(this.submitFormBtn_Click);
            // 
            // cancelFormBtn
            // 
            this.cancelFormBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.cancelFormBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelFormBtn.Location = new System.Drawing.Point(163, 198);
            this.cancelFormBtn.Name = "cancelFormBtn";
            this.cancelFormBtn.Size = new System.Drawing.Size(160, 33);
            this.cancelFormBtn.TabIndex = 10;
            this.cancelFormBtn.Text = "Geri Qayıt";
            this.cancelFormBtn.UseVisualStyleBackColor = false;
            this.cancelFormBtn.Click += new System.EventHandler(this.cancelFormBtn_Click);
            // 
            // VerifyPersonData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 248);
            this.Controls.Add(this.cancelFormBtn);
            this.Controls.Add(this.submitFormBtn);
            this.Controls.Add(this.docNumberDisabledTextBox);
            this.Controls.Add(this.docSerialDisabledTextBox);
            this.Controls.Add(this.surnameDisabledTextBox);
            this.Controls.Add(this.nameDisabledTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VerifyPersonData";
            this.Text = "Təsdiqləmə";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox docNumberDisabledTextBox;
        private System.Windows.Forms.TextBox docSerialDisabledTextBox;
        private System.Windows.Forms.TextBox surnameDisabledTextBox;
        private System.Windows.Forms.TextBox nameDisabledTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitFormBtn;
        private System.Windows.Forms.Button cancelFormBtn;
    }
}