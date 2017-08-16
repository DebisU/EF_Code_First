namespace EF_Code_First_Try
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public Context()
            : base("name=BookDbContext")
        {
        }

    }
}