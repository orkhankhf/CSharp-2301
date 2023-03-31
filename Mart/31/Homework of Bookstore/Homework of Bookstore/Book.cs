using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_of_Bookstore
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }

        public Book(int id, string name, int authorId)
        {
            this.Id = id;
            this.Name = name;
            this.AuthorId = authorId;
        }
    }
}
