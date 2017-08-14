using EF_Code_First_Try.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Try.Infrastructure
{
    interface IBookController
    {
        List<Book> Index();
        Book Details(int id);
        Book Create();
        Book Create(Book book);
        Book Edit(int id);
        Book Edit(int id, Book book);
        Book Delete(int id);
        Book Delete(int id, Book book);
    }
}
