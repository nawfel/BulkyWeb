using Bulky.DataAccess;
using Bulky.Models;
using Bulky.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Models.Category
                {
                    Id = 1,
                    Name = "action",
                    DisplayOrder = 2
                },
                new Category
                {
                    Id = 2,
                    Name = "scifi",
                    DisplayOrder = 4
                },
                   new Category
                   {
                       Id = 3,
                       Name = "thriller",
                       DisplayOrder = 3
                   }
                );
            modelBuilder.Entity<Product>().HasData(
                new Models.Models.Product
                {
                    Id = 1,
                    Title = "Title",
                    Description = "Description",
                    ISBN = "isbn21234353",
                    ListPrice = 19,
                    Price = 19,
                    Price100 = 19,
                    Price50 = 19,
                    CategoryId = 1,
                    Author = "RDGDG",
                    ImageUrl = ""

                },
                new Models.Models.Product
                {
                    Id = 2,
                    Title = "Title",
                    Description = "Description",
                    ISBN = "isbn21234353",
                    ListPrice = 19,
                    Price = 19,
                    Price100 = 19,
                    Price50 = 19,
                    CategoryId = 1,
                    Author = "DVXFV",
                    ImageUrl = ""

                }
                );
        }
    }
}
