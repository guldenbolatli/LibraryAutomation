using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo1.Models
{
    public interface IMember
    {
        [Key]
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        List<Book> BorrowedBooks { get; set; }
        void BorrowBook(Book book);
        void ReturnBook(Book book);
        void ShowBorrowedBooks();
    }
}
