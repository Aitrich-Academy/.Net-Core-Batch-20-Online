using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Model
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
    : base(options)
        {
        }
        public DbSet<Book> books  { get; set; }

    }
}

