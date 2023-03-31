using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework_of_Bookstore
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Bir dənə kitabxana app'ı yazacaqsınız. İlk öncə mən bir neçə müəllif əlavə edəcəyəm və sonra da
             müəlliflərin kitablarını əlavə edəcəyəm. Nəzərə alın ki, müəllifləri əlavə edəndən sonra birinci müəllif
             məlumatlarını ekranda görməliyəm ki, kitab'ı əlavə edəndə müəllifin Id dəyərinə görə əlavə edəcəm.
             Bura qədər bildiyiniz hər şeydən istifadə edərək bu app'ı yazmağa çalışın. Müəllif və kitabları əlavə
             etmək, silmək, hamısını görmək, Ad'a görə axtarmaq kimi seçim olacaq. Bacarsanız editləmək funksiyasını
             da yazın.
             */
            
            List<Author> authors = new List<Author>();
            List<Book> books = new List<Book>();

            Begin:
            ShowMenu();

            var choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    foreach (var item in books)
                    {
                        Console.WriteLine("Book Info");
                        Console.WriteLine("Id: " + item.Id);
                        Console.WriteLine("Name: " + item.Name);
                        Console.WriteLine("AuthorId: " + item.AuthorId);
                        Console.WriteLine("-------------------- \r\n");
                    }

                    Console.WriteLine("Davam etmek ucun her-hansisa key'e basin: ");
                    Console.ReadLine();
                    goto Begin;

                case "2":
                    Console.WriteLine("Kitab melumatlarini daxil edin:");
                    Console.Write("Id: ");
                    var newBookId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    var newBookName = Console.ReadLine();
                    Console.Write("AuthorId: ");
                    var newBookAuthorId = Convert.ToInt32(Console.ReadLine());

                    var checkAuthor = authors.Find(m => m.Id == newBookAuthorId);

                    if(checkAuthor == null)
                    {
                        Console.WriteLine("Daxil etdiyiniz muellif tapilmadi!");
                    }
                    else
                    {
                        Book book = new Book(newBookId, newBookName, newBookAuthorId);
                        books.Add(book);

                        Console.WriteLine("Yeni kitab elave edildi.");
                    }

                    Thread.Sleep(3000);

                    goto Begin;

                case "3":
                    Console.WriteLine("Silinecek kitabin Id deyerini daxil edin:");
                    var deleteBookId = Convert.ToInt32(Console.ReadLine());

                    var deleteBook = books.Find(m => m.Id == deleteBookId);

                    if(deleteBook == null)
                        Console.WriteLine("Kitab tapilmadi!");
                    else
                    {
                        books.Remove(deleteBook);
                        Console.WriteLine("Kitab silindi!");
                    }

                    Thread.Sleep(3000);

                    goto Begin;

                case "4":
                    Console.WriteLine("Axtarmaq istediyiniz kitabin adini daxil edin: ");
                    var searchBookName = Console.ReadLine().ToLower();

                    var findBook = books.Find(m => m.Name.ToLower() == searchBookName);

                    if(findBook == null)
                    {
                        Console.WriteLine("Axtardiginiz kitab tapilmadi!");

                        Thread.Sleep(3000);

                        goto Begin;
                    }
                    else
                    {
                        Console.WriteLine("Book Info");
                        Console.WriteLine("Id: " + findBook.Id);
                        Console.WriteLine("Name: " + findBook.Name);
                        Console.WriteLine("AuthorId: " + findBook.AuthorId);

                        Console.WriteLine("Davam etmek ucun her-hansisa key'e basin: ");
                        Console.ReadLine();
                        goto Begin;
                    }

                case "5":
                    foreach (var item in authors)
                    {
                        Console.WriteLine("Author Info");
                        Console.WriteLine("Id: " + item.Id);
                        Console.WriteLine("Name: " + item.Name);
                        Console.WriteLine("Surname: " + item.Surname);
                        Console.WriteLine("-------------------- \r\n");
                    }

                    Console.WriteLine("Davam etmek ucun her-hansisa key'e basin: ");
                    Console.ReadLine();
                    goto Begin;

                case "6":
                    Console.WriteLine("Muellif melumatlarini daxil edin:");
                    Console.Write("Id: ");
                    var newAuthorId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    var newAuthorName = Console.ReadLine();
                    Console.Write("Surname: ");
                    var newAuthorSurname = Console.ReadLine();

                    Author author = new Author(newAuthorId, newAuthorName, newAuthorSurname);
                    authors.Add(author);

                    Console.WriteLine("Yeni muellif elave edildi.");

                    Thread.Sleep(3000);

                    goto Begin;

                case "7":
                    Console.WriteLine("Silinecek muellifin Id deyerini daxil edin:");
                    var deleteAuthorId = Convert.ToInt32(Console.ReadLine());

                    var deleteAuthor = authors.Find(m => m.Id == deleteAuthorId);

                    if (deleteAuthor == null)
                        Console.WriteLine("Muellif tapilmadi!");
                    else
                    {
                        authors.Remove(deleteAuthor);
                        Console.WriteLine("Muellif silindi!");
                    }

                    Thread.Sleep(3000);

                    goto Begin;

                case "8":
                    Console.WriteLine("Axtarmaq istediyiniz muellifin adini ve soyadini daxil edin: ");
                    var searchAuthorName = Console.ReadLine().ToLower();
                    var searchAuthorSurname = Console.ReadLine().ToLower();

                    var findAuthor = authors.Find(m => m.Name.ToLower() == searchAuthorName && m.Surname.ToLower() == searchAuthorSurname);

                    if (findAuthor == null)
                    {
                        Console.WriteLine("Axtardiginiz muellif tapilmadi!");

                        Thread.Sleep(3000);

                        goto Begin;
                    }
                    else
                    {
                        Console.WriteLine("Author Info");
                        Console.WriteLine("Id: " + findAuthor.Id);
                        Console.WriteLine("Name: " + findAuthor.Name);
                        Console.WriteLine("Surname: " + findAuthor.Surname);

                        Console.WriteLine("Davam etmek ucun her-hansisa key'e basin: ");
                        Console.ReadLine();
                        goto Begin;
                    }

                //Edit section
                case "9":
                    Console.WriteLine("Editlemek istediyiniz muellifin Id deyerini daxil edin:");
                    var editAuthorId = Convert.ToInt32(Console.ReadLine());

                    var editAuthor = authors.Find(m => m.Id == editAuthorId);

                    if (editAuthor == null)
                        Console.WriteLine("Muellif tapilmadi!");
                    else
                    {
                        Console.WriteLine("Muellifin adini daxil edin: ");
                        editAuthor.Name = Console.ReadLine();

                        Console.WriteLine("Muellifin soyadini daxil edin: ");
                        editAuthor.Surname = Console.ReadLine();

                        Console.WriteLine("Muellif yenilendi!");
                    }

                    Thread.Sleep(3000);

                    goto Begin;

                case "10":
                    Console.WriteLine("Editlemek istediyiniz kitabin Id deyerini daxil edin:");
                    var editBookId = Convert.ToInt32(Console.ReadLine());

                    var editBook = books.Find(m => m.Id == editBookId);

                    if (editBook == null)
                        Console.WriteLine("Kitab tapilmadi!");
                    else
                    {
                        Console.WriteLine("Kitabin adini daxil edin: ");
                        editBook.Name = Console.ReadLine();

                        Console.WriteLine("Kitabin muellifinin Id deyerini daxil edin: ");
                        
                        var editBookAuthorId = Convert.ToInt32(Console.ReadLine());

                        var checkAuthorForEdit = authors.Find(m => m.Id == editBookAuthorId);

                        if (checkAuthorForEdit == null)
                        {
                            Console.WriteLine("Daxil etdiyiniz muellif tapilmadi!");
                        }
                        else
                        {
                            editBook.AuthorId = editBookAuthorId;
                            Console.WriteLine("Kitab yenilendi!");
                        }
                    }

                    Thread.Sleep(3000);

                    goto Begin;

                default:
                    Console.WriteLine("Yanlis deyer daxil edildi.");
                    Thread.Sleep(3000);
                    goto Begin;
            }
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu: ");
            Console.WriteLine("Kitab");
            Console.WriteLine("1. Kitablari gor");
            Console.WriteLine("2. Kitab elave et");
            Console.WriteLine("3. Kitab sil");
            Console.WriteLine("4. Kitab axtar");
            Console.WriteLine("Muellif");
            Console.WriteLine("5. Muellifleri gor");
            Console.WriteLine("6. Muellif elave et");
            Console.WriteLine("7. Muellif sil");
            Console.WriteLine("8. Muellif axtar");
            Console.WriteLine("Edit");
            Console.WriteLine("9. Muellif melumatlarini yenile");
            Console.WriteLine("10. Kitab melumatlarini yenile");
        }
    }
}
