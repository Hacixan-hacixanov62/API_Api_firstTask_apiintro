using API_first_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace API_first_Task.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
