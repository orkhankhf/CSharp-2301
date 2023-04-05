namespace WindowsFormsAppPart5
{
    partial class BookStockApp
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
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.bookCategoryText = new System.Windows.Forms.TextBox();
            this.bookCountText = new System.Windows.Forms.TextBox();
            this.bookAuthorText = new System.Windows.Forms.TextBox();
            this.bookDescription = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitablar";
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(60, 6);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(559, 21);
            this.cmbBooks.TabIndex = 1;
            this.cmbBooks.SelectedIndexChanged += new System.EventHandler(this.cmbBooks_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookDescription);
            this.groupBox1.Controls.Add(this.bookAuthorText);
            this.groupBox1.Controls.Add(this.bookCountText);
            this.groupBox1.Controls.Add(this.bookCategoryText);
            this.groupBox1.Controls.Add(this.bookNameText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bookPicture);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 404);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilən kitab haqqında məlumat";
            // 
            // bookPicture
            // 
            this.bookPicture.Location = new System.Drawing.Point(6, 19);
            this.bookPicture.Name = "bookPicture";
            this.bookPicture.Size = new System.Drawing.Size(160, 199);
            this.bookPicture.TabIndex = 0;
            this.bookPicture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitab Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kateqoriya";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stok Ədəd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Müəllif";
            // 
            // bookNameText
            // 
            this.bookNameText.Location = new System.Drawing.Point(272, 77);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(256, 20);
            this.bookNameText.TabIndex = 2;
            // 
            // bookCategoryText
            // 
            this.bookCategoryText.Location = new System.Drawing.Point(272, 103);
            this.bookCategoryText.Name = "bookCategoryText";
            this.bookCategoryText.Size = new System.Drawing.Size(256, 20);
            this.bookCategoryText.TabIndex = 2;
            // 
            // bookCountText
            // 
            this.bookCountText.Location = new System.Drawing.Point(272, 129);
            this.bookCountText.Name = "bookCountText";
            this.bookCountText.Size = new System.Drawing.Size(256, 20);
            this.bookCountText.TabIndex = 2;
            // 
            // bookAuthorText
            // 
            this.bookAuthorText.Location = new System.Drawing.Point(272, 155);
            this.bookAuthorText.Name = "bookAuthorText";
            this.bookAuthorText.Size = new System.Drawing.Size(256, 20);
            this.bookAuthorText.TabIndex = 2;
            // 
            // bookDescription
            // 
            this.bookDescription.Location = new System.Drawing.Point(6, 224);
            this.bookDescription.Name = "bookDescription";
            this.bookDescription.Size = new System.Drawing.Size(595, 174);
            this.bookDescription.TabIndex = 3;
            this.bookDescription.Text = "";
            // 
            // BookStockApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookStockApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitab Stock Proqramı";
            this.Load += new System.EventHandler(this.BookStockApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox bookDescription;
        private System.Windows.Forms.TextBox bookAuthorText;
        private System.Windows.Forms.TextBox bookCountText;
        private System.Windows.Forms.TextBox bookCategoryText;
        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox bookPicture;
    }
}

