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
    public partial class BookStockAppListBox : Form
    {
        public BookStockAppListBox()
        {
            InitializeComponent();
        }

        private void BookStockAppListBox_Load(object sender, EventArgs e)
        {
            FillComboboxV2();
        }

        void FillComboboxV1()
        {
            foreach (var item in VirtualDatabase.BooksTable)
            {
                lstBooks.Items.Add(item);
            }
        }

        void FillComboboxV2()
        {
            lstBooks.DataSource = VirtualDatabase.BooksTable;
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCount = lstBooks.SelectedItems.Count;

            if(selectedCount == 1)
            {
                ListBox lbox = (ListBox)sender;

                Book book = (Book)lbox.SelectedItem;

                bookNameText.Text = book.Name;
                bookCategoryText.Text = book.Category;
                bookCountText.Text = book.Count.ToString();
                bookAuthorText.Text = book.Author;
                bookDescription.Text = book.Description;

                bookPicture.Image = Image.FromFile(book.ImagePath);
                bookPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                List<Book> books = new List<Book>();

                foreach (var item in lstBooks.SelectedItems)
                {
                    books.Add(item as Book);
                }

                MultipleListBoxResultView multiView = new MultipleListBoxResultView(books);

                multiView.ShowDialog();
            }
        }
    }
}
