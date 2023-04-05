using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart5
{
    public partial class BookStockAppCheckedListBox : Form
    {
        public BookStockAppCheckedListBox()
        {
            InitializeComponent();
        }

        private void BookStockAppCheckedListBox_Load(object sender, EventArgs e)
        {
            foreach (var item in VirtualDatabase.BooksTable)
            {
                clbBooks.Items.Add(item);
            }
        }

        private void clbBooks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var currentValue = e.CurrentValue;
            var index = e.Index;
            var newValue = e.NewValue;

            CheckedListBox checkedListBox = (CheckedListBox)sender;

            if(e.NewValue == CheckState.Checked)
            {
                Book book = checkedListBox.Items[index] as Book;

                bookNameText.Text = book.Name;
                bookCategoryText.Text = book.Category;
                bookCountText.Text = book.Count.ToString();
                bookAuthorText.Text = book.Author;
                bookDescription.Text = book.Description;

                bookPicture.Image = Image.FromFile(book.ImagePath);
                bookPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void clbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CheckedListBox checkedListBox = (CheckedListBox)sender;

            //Book book = checkedListBox.SelectedItem as Book;

            //bookNameText.Text = book.Name;
            //bookCategoryText.Text = book.Category;
            //bookCountText.Text = book.Count.ToString();
            //bookAuthorText.Text = book.Author;
            //bookDescription.Text = book.Description;

            //bookPicture.Image = Image.FromFile(book.ImagePath);
            //bookPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
