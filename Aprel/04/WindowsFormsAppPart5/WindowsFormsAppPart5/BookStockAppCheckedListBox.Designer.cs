namespace WindowsFormsAppPart5
{
    partial class BookStockAppCheckedListBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookDescription = new System.Windows.Forms.RichTextBox();
            this.bookAuthorText = new System.Windows.Forms.TextBox();
            this.bookCountText = new System.Windows.Forms.TextBox();
            this.bookCategoryText = new System.Windows.Forms.TextBox();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookPicture = new System.Windows.Forms.PictureBox();
            this.clbBooks = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(273, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 404);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilən kitab haqqında məlumat";
            // 
            // bookDescription
            // 
            this.bookDescription.Location = new System.Drawing.Point(6, 224);
            this.bookDescription.Name = "bookDescription";
            this.bookDescription.Size = new System.Drawing.Size(595, 174);
            this.bookDescription.TabIndex = 3;
            this.bookDescription.Text = "";
            // 
            // bookAuthorText
            // 
            this.bookAuthorText.Location = new System.Drawing.Point(272, 155);
            this.bookAuthorText.Name = "bookAuthorText";
            this.bookAuthorText.Size = new System.Drawing.Size(256, 20);
            this.bookAuthorText.TabIndex = 2;
            // 
            // bookCountText
            // 
            this.bookCountText.Location = new System.Drawing.Point(272, 129);
            this.bookCountText.Name = "bookCountText";
            this.bookCountText.Size = new System.Drawing.Size(256, 20);
            this.bookCountText.TabIndex = 2;
            // 
            // bookCategoryText
            // 
            this.bookCategoryText.Location = new System.Drawing.Point(272, 103);
            this.bookCategoryText.Name = "bookCategoryText";
            this.bookCategoryText.Size = new System.Drawing.Size(256, 20);
            this.bookCategoryText.TabIndex = 2;
            // 
            // bookNameText
            // 
            this.bookNameText.Location = new System.Drawing.Point(272, 77);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(256, 20);
            this.bookNameText.TabIndex = 2;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stok Ədəd";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitab Adı";
            // 
            // bookPicture
            // 
            this.bookPicture.Location = new System.Drawing.Point(6, 19);
            this.bookPicture.Name = "bookPicture";
            this.bookPicture.Size = new System.Drawing.Size(160, 199);
            this.bookPicture.TabIndex = 0;
            this.bookPicture.TabStop = false;
            // 
            // clbBooks
            // 
            this.clbBooks.FormattingEnabled = true;
            this.clbBooks.Location = new System.Drawing.Point(12, 12);
            this.clbBooks.Name = "clbBooks";
            this.clbBooks.Size = new System.Drawing.Size(255, 394);
            this.clbBooks.TabIndex = 4;
            this.clbBooks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbBooks_ItemCheck);
            this.clbBooks.SelectedIndexChanged += new System.EventHandler(this.clbBooks_SelectedIndexChanged);
            // 
            // BookStockAppCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 425);
            this.Controls.Add(this.clbBooks);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookStockAppCheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitab Stock Proqramı";
            this.Load += new System.EventHandler(this.BookStockAppCheckedListBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.CheckedListBox clbBooks;
    }
}