using Microsoft.EntityFrameworkCore;
using BookWebAPI.Models;

namespace BookWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Seed data pattern initially
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Văn học" },
                new Category { Id = 2, Name = "Giáo trình" }
            );

            // Configure relationships if needed
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany()
                .HasForeignKey(b => b.CategoryId);
        }
    }
}
