using API_first_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace API_first_Task.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>().HasData(
        //         new Category
        //         {
        //             Id = 1,
        //             CreatedDate = DateTime.Now,
        //             Name = "UI UX",
        //         },

        //          new Category
        //          {
        //              Id = 2,
        //              CreatedDate = DateTime.Now,
        //              Name = "Backend Development",

        //          },

        //          new Category
        //          {
        //              Id = 3,
        //              CreatedDate = DateTime.Now,
        //              Name = "Frontend",
        //          });






            

        //}

    }
}
