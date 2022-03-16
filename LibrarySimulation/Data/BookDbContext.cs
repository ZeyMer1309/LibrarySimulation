using LibrarySimulation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySimulation.Data
{
    class BookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\Mssqllocaldb; Database=LibrarySimulatorDb; Integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(x => x.Name)
                                       .IsRequired()
                                       .HasMaxLength(250);

            modelBuilder.Entity<Book>().HasOne(book => book.Author)
                                       .WithMany(author => author.Books)
                                       .HasForeignKey(book => book.AuthorId)
                                       .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<UsersBooks>().HasKey("BookId", "UserId", "BorrowDate");

            modelBuilder.Entity<Book>().HasMany(book => book.Users)
                                       .WithOne(ub => ub.Book)
                                       .HasForeignKey(x => x.BookId)
                                       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>().HasMany(u => u.Books)
                                       .WithOne(ub => ub.User)
                                       .HasForeignKey(x => x.UserId)
                                       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CategoriesBooks>().HasKey("BookId", "CategoryId");

            modelBuilder.Entity<Book>().HasMany(book => book.Categories)
                                       .WithOne(cb => cb.Book)
                                       .HasForeignKey(x => x.BookId)
                                       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().HasMany(c => c.Books)
                                           .WithOne(cb => cb.Category)
                                           .HasForeignKey(x => x.CategoryId)
                                           .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Author>().HasData(new Author { Id = 1, Name = "Agatha", LastName = "Christie", Info = "Polisiye roman yazarı" });

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Polisiye" });

            modelBuilder.Entity<Book>().HasData(new Book { Id = 1, Name = "Doğu Ekspresinde Cinayet", AuthorId = 1 });

            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 1, CategoryId = 1 });

            modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "Ömer Gürbüz", CreationDate = new DateTime(2022, 03, 16) });

            modelBuilder.Entity<UsersBooks>().HasData(new UsersBooks { UserId = 1, BookId = 1, BorrowDate = new DateTime(2022, 03, 16) });
        }
    }
}
