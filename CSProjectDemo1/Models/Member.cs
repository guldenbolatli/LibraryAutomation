using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo1.Models
{
    public class Member : IMember
    {
        [Key]
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public Member()
        {
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (book.Status == Status.Available)
            {
                BorrowedBooks.Add(book);
                book.Status = Status.Borrowed;
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.Status = Status.Available;
            }
        }

        public void ShowBorrowedBooks()
        {
            Console.WriteLine("Borrowed Books: ");
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine($"- {book.Title} ({book.Author})");
            }
        }
    }
}
