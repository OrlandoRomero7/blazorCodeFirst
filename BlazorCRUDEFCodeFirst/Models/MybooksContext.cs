using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDEFCodeFirst.Models
{
    public class MybooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=OrlandoPC;Initial Catalog=BlazorCRUDEFCodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
