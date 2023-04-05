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
    public partial class BookStockApp : Form
    {
        public BookStockApp()
        {
            InitializeComponent();
        }

        private void BookStockApp_Load(object sender, EventArgs e)
        {
            FillComboboxV2();
        }

        void FillComboboxV1()
        {
            foreach (var item in VirtualDatabase.BooksTable)
            {
                cmbBooks.Items.Add(item);
            }
        }

        void FillComboboxV2()
        {
            cmbBooks.DataSource = VirtualDatabase.BooksTable;
        }

        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1-ci yol
            object o1 = cmbBooks.SelectedItem;
            Book book = (Book)o1;

            //2-ci yol
            book = cmbBooks.SelectedItem as Book;

            //AS with nullable check
            book = cmbBooks.SelectedItem == null ? null : cmbBooks.SelectedItem as Book;

            //3-cü yol
            ComboBox selectedCombobox = sender as ComboBox;
            book = selectedCombobox.SelectedItem == null ? null : selectedCombobox.SelectedItem as Book;

            bookNameText.Text = book.Name;
            bookCategoryText.Text = book.Category;
            bookCountText.Text = book.Count.ToString();
            bookAuthorText.Text = book.Author;
            bookDescription.Text = book.Description;

            bookPicture.Image = Image.FromFile(book.ImagePath);
            bookPicture.SizeMode = PictureBoxSizeMode.StretchImage;

            var selectedIndex = selectedCombobox.SelectedIndex; //0, 1, 2... index deyerini qaytarir
        }
    }
}
