namespace WindowsFormsAppPart4.DynamicFormElementsFolder
{
    partial class DynamicFormElements
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
            this.createNewButtonBtn = new System.Windows.Forms.Button();
            this.createNewTextBoxBtn = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // createNewButtonBtn
            // 
            this.createNewButtonBtn.Location = new System.Drawing.Point(12, 12);
            this.createNewButtonBtn.Name = "createNewButtonBtn";
            this.createNewButtonBtn.Size = new System.Drawing.Size(133, 39);
            this.createNewButtonBtn.TabIndex = 0;
            this.createNewButtonBtn.Text = "Yeni button əlavə et";
            this.createNewButtonBtn.UseVisualStyleBackColor = true;
            this.createNewButtonBtn.Click += new System.EventHandler(this.createNewButtonBtn_Click);
            // 
            // createNewTextBoxBtn
            // 
            this.createNewTextBoxBtn.Location = new System.Drawing.Point(12, 220);
            this.createNewTextBoxBtn.Name = "createNewTextBoxBtn";
            this.createNewTextBoxBtn.Size = new System.Drawing.Size(133, 39);
            this.createNewTextBoxBtn.TabIndex = 0;
            this.createNewTextBoxBtn.Text = "Yeni textbox əlavə et";
            this.createNewTextBoxBtn.UseVisualStyleBackColor = true;
            this.createNewTextBoxBtn.Click += new System.EventHandler(this.createNewTextBoxBtn_Click);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Location = new System.Drawing.Point(12, 57);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(776, 157);
            this.buttonsPanel.TabIndex = 1;
            // 
            // textBoxPanel
            // 
            this.textBoxPanel.Location = new System.Drawing.Point(12, 265);
            this.textBoxPanel.Name = "textBoxPanel";
            this.textBoxPanel.Size = new System.Drawing.Size(776, 173);
            this.textBoxPanel.TabIndex = 2;
            // 
            // DynamicFormElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.createNewTextBoxBtn);
            this.Controls.Add(this.createNewButtonBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DynamicFormElements";
            this.Text = "Dinamik form elementləri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createNewButtonBtn;
        private System.Windows.Forms.Button createNewTextBoxBtn;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.FlowLayoutPanel textBoxPanel;
    }
}