using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo1.Models
{
    public class Library
    {
        private List<Book>Books {  get; set; }
        private List<IMember> Members { get; set; }
        public Library()
        {
            Books = new List<Book>();
            Members = new List<IMember>();
        }
        /// <summary>
        /// To add a book to the library
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book) 
        { 
            Books.Add(book); 
        }
        /// <summary>
        /// To add a member to the library
        /// </summary>
        /// <param name="member"></param>
        public void AddMember(IMember member) 
        {  
            Members.Add(member); 
        }
        /// <summary>
        /// To borrow a book to the member
        /// </summary>
        /// <param name="member"></param>
        /// <param name="book"></param>
        public void GiveBook(IMember member, Book book)
        {
            if(!Books.Contains(book))
            {
                Console.WriteLine("The book is not available.");
                return;
            }
            if(!Members.Contains(member))
            {
                Console.WriteLine("The member is not available.");
                return;
            }
            if(book.Status != Status.Available)
            {
                Console.WriteLine("The book can not borrow.");
                return;
            }
            member.BorrowBook(book);
            Console.WriteLine("The book was borrowed.");
        }
        /// <summary>
        /// To return the book borrowed by the member
        /// </summary>
        /// <param name="member"></param>
        /// <param name="book"></param>
        public void TakeBook(IMember member, Book book)
        {
            if (!Members.Contains(member))
            {
                Console.WriteLine("The member is not available.");
                return;
            }

            if (!member.BorrowedBooks.Contains(book))
            {
                Console.WriteLine("The member has no borrowed this book.");
                return;
            }

            member.ReturnBook(book);
            Console.WriteLine("The book was returned. ");
        }
        /// <summary>
        /// To show the books borrowed by the member
        /// </summary>
        /// <param name="member"></param>
        public void ShowBorrowedBook(IMember member)
        {
            if(member == null)
            {
                Console.WriteLine("The member is null.");
            }
            if(member.BorrowedBooks.Count > 0)
            {
                member.ShowBorrowedBooks();
            }
        }
        /// <summary>
        /// To display the library status
        /// </summary>
        public void DisplayLibraryStatus()
        {
            Console.WriteLine("Library Status: ");
            Console.WriteLine($"Available Books: {Books.Count(b => b.Status == Status.Available)}");
            Console.WriteLine($"Borrowed Books: {Books.Count(b => b.Status == Status.Borrowed)}");
            Console.WriteLine($"Member Count: {Members.Count}");
        }
    }
}
