using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        { 
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency() { Id = 1, Title="INR", Description ="Indian INR"},
                new Currency() { Id = 2, Title="DOLLAR", Description ="US DOLLAR"},
                new Currency() { Id = 3, Title="LIRA", Description ="TURKISH LIRA"},
                new Currency() { Id = 4, Title="POUND", Description ="SUDANESE POUND"}
                ); 

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = 1, Title="Hindi", Description = "Hindi" },
                new Language() { Id = 2, Title="Marathi", Description = "Marathi" },
                new Language() { Id = 3, Title="English", Description = "English" },
                new Language() { Id = 4, Title="France", Description = "France" }
                );
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Bookprice> Bookprices { get; set; }
        public DbSet<Currency> Currencies { get; set; }

    }
}
