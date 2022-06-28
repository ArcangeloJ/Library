using Microsoft.EntityFrameworkCore;

namespace Library
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author>? Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOPJAQUE\SQLEXPRESS;Database=Library;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
