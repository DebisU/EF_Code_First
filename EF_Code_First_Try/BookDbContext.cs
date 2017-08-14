namespace EF_Code_First_Try
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookDbContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public BookDbContext()
            : base("name=BookDbContext")
        {
        }

    }
}