using LibreriasAZb.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace LibreriasAZb.Data
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
