using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();

        public DbSet<Category> Categories => Set<Category>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(p => p.Name)
                    .HasMaxLength(200)
                    .IsRequired();

                entity.Property(p => p.Price)
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(p => p.Category)
                    .WithMany(c => c.Products)
                    .HasForeignKey(p => p.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(c => c.Name)
                    .HasMaxLength(200)
                    .IsRequired();

                entity.HasData(
                    new Category { Id = 1, Name = "Electronics" },
                    new Category { Id = 2, Name = "Books" },
                    new Category { Id = 3, Name = "Clothing" },
                    new Category { Id = 4, Name = "Sports" }
                );
            });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 25000.00m, Stock = 15, Description = "15-inch laptop, 16GB RAM", CategoryId = 1 },
                new Product { Id = 2, Name = "Wireless Mouse", Price = 350.00m, Stock = 50, Description = "Ergonomic wireless mouse", CategoryId = 1 },
                new Product { Id = 3, Name = "Mechanical Keyboard", Price = 1200.00m, Stock = 30, Description = "RGB mechanical keyboard", CategoryId = 1 },
                new Product { Id = 4, Name = "Clean Code", Price = 450.00m, Stock = 20, Description = "Robert C. Martin - Software craftsmanship", CategoryId = 2 },
                new Product { Id = 5, Name = "Design Patterns", Price = 520.00m, Stock = 12, Description = "Gang of Four - classic book", CategoryId = 2 },
                new Product { Id = 6, Name = "The Pragmatic Programmer", Price = 480.00m, Stock = 18, Description = "Hunt & Thomas", CategoryId = 2 },
                new Product { Id = 7, Name = "T-Shirt", Price = 200.00m, Stock = 100, Description = "Cotton t-shirt, size L", CategoryId = 3 },
                new Product { Id = 8, Name = "Jeans", Price = 650.00m, Stock = 40, Description = "Denim jeans, size 32", CategoryId = 3 },
                new Product { Id = 9, Name = "Running Shoes", Price = 1800.00m, Stock = 25, Description = "Lightweight running shoes", CategoryId = 4 },
                new Product { Id = 10, Name = "Yoga Mat", Price = 300.00m, Stock = 60, Description = "Non-slip yoga mat 6mm", CategoryId = 4 },
                new Product { Id = 11, Name = "Dumbbells Set", Price = 1500.00m, Stock = 10, Description = "Adjustable dumbbells 20kg", CategoryId = 4 },
                new Product { Id = 12, Name = "USB-C Hub", Price = 420.00m, Stock = 35, Description = "7-in-1 USB-C hub", CategoryId = 1 }
            );
        }
    }
}
