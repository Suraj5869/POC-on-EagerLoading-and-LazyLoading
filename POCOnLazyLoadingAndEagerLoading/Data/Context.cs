using Microsoft.EntityFrameworkCore;
using POCOnLazyLoadingAndEagerLoading.Models;

namespace POCOnLazyLoadingAndEagerLoading.Data
{
    public class Context:DbContext
    {
        public DbSet<Author> Authors {  get; set; }
        public DbSet<Book> Books { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
