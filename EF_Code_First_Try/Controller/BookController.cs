using EF_Code_First_Try.Infrastructure;
using EF_Code_First_Try.Model;
using System.Collections.Generic;
using System.Linq;

namespace EF_Code_First_Try.Controller
{
    class BookController : IDbController<Book>
    {
        Context context;

        public BookController()
        {
            context = new Context();
        }

        public List<Book> Index()
        {
            List<Book> books = context.Books.ToList();
            return books;
        }


        public Book Details(int id)
        {
            Book book = context.Books.SingleOrDefault(b => b.BookID == id);

            if (book == null)
            {
                return new Book();
            }
            return book;
        }

        public Book Create()
        {
            return new Book();
        }


        public Book Create(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return book;
        }

        public Book Edit(int id)
        {
            Book book = context.Books.Single(p => p.BookID == id);
            if (book == null)
            {
                return new Book();
            }
            return book;
        }

        public Book Edit(int id, Book book)
        {
            Book _book = context.Books.Single(p => p.BookID == id);

            _book = book;
            context.SaveChanges();

            return book;
        }

        public Book Delete(int id)
        {
            Book book = context.Books.Single(p => p.BookID == id);
            this.Delete(id, book);
            return book;
        }

        public Book Delete(int id, Book book)
        {
            Book _book = context.Books.Single(p => p.BookID == id);
            context.Books.Remove(_book);
            context.SaveChanges();
            return book;
        }
    }
}
