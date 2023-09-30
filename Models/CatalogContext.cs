using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MyTermProject.Models
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options) { }

        public DbSet<Books> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>().HasData(

                new Books
                {
                    ID = 1,
                    BookTitle = "Harry Potter and the Sorcerer's Stone",
                    AuthorName = "JK Rowling",
                    Genre = "Fantasy",
                    BookFormat = Format.Audio
                },
                new Books { 
                    ID = 2,
                    BookTitle = "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones",
                    AuthorName = "James Clear",
                    Genre = "Self-Help",
                    BookFormat = Format.Hardcover
                 },
                new Books
                {
                    ID = 3,
                    BookTitle = "Night Road",
                    AuthorName = "Kristin Hannah",
                }
            );
        }
    }
}
