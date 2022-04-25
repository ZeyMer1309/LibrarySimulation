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
                                       .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>().HasMany(u => u.Books)
                                       .WithOne(ub => ub.User)
                                       .HasForeignKey(x => x.UserId)
                                       .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CategoriesBooks>().HasKey("BookId", "CategoryId");

            modelBuilder.Entity<Book>().HasMany(book => book.Categories)
                                       .WithOne(cb => cb.Book)
                                       .HasForeignKey(x => x.BookId)
                                       .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>().HasMany(c => c.Books)
                                           .WithOne(cb => cb.Category)
                                           .HasForeignKey(x => x.CategoryId)
                                           .OnDelete(DeleteBehavior.Cascade);



            // VERİLER

            modelBuilder.Entity<Author>().HasData(new Author { Id = 1, Name = "Agatha", LastName = "Christie", Info = "Polisiye roman yazarı" });
            modelBuilder.Entity<Author>().HasData(new Author { Id = 2, Name = "José", LastName = "Saramago", Info = "Nobel Edebiyat Ödüllü, Portekizli yazar" });
            modelBuilder.Entity<Author>().HasData(new Author { Id = 3, Name = "George", LastName = "Orwell", Info = "Politik kurgu yazarı" });
            modelBuilder.Entity<Author>().HasData(new Author { Id = 4, Name = "Antoine", LastName = "de Saint-Exupéry", Info = "Fransız yazar ve pilot" });
            modelBuilder.Entity<Author>().HasData(new Author { Id = 5, Name = "Necip Fazıl", LastName = "Kısakürek", Info = "Türk şair ve yazar" });



            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Polisiye" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Politik" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Roman" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4, Name = "Bilim Kurgu" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 5, Name = "Psikoloji" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 6, Name = "Gizem" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 7, Name = "Eleştri" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 8, Name = "Distopya" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 9, Name = "Şiir" });



            modelBuilder.Entity<Book>().HasData(new Book { Id = 1, Name = "Doğu Ekspresinde Cinayet", AuthorId = 1, Year = new DateTime(1934, 01, 01), IsInShelf = false, PageCount = 171 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 2, Name = "Körlük", AuthorId = 2, Year = new DateTime(1994, 01, 01), IsInShelf = true, PageCount = 352 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 3, Name = "Görmek", AuthorId = 2, Year = new DateTime(2004, 01, 01), IsInShelf = true, PageCount = 225 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 4, Name = "Hayvan Çiftliği", AuthorId = 3, Year = new DateTime(1945, 01, 01), IsInShelf = true, PageCount = 112 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 5, Name = "1984", AuthorId = 3, Year = new DateTime(1949, 01, 01), IsInShelf = true, PageCount = 352 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 6, Name = "Küçük Prens", AuthorId = 4, Year = new DateTime(1943, 01, 01), IsInShelf = true, PageCount = 96 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 7, Name = "Çile", AuthorId = 5, Year = new DateTime(1962, 01, 01), IsInShelf = true, PageCount = 512 });



            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 1, CategoryId = 1 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 1, CategoryId = 3 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 1, CategoryId = 6 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 2, CategoryId = 3 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 2, CategoryId = 4 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 2, CategoryId = 5 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 3, CategoryId = 2 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 4, CategoryId = 2 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 4, CategoryId = 3 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 4, CategoryId = 7 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 5, CategoryId = 2 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 5, CategoryId = 4 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 5, CategoryId = 8 }); 
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 6, CategoryId = 4 });
            modelBuilder.Entity<CategoriesBooks>().HasData(new CategoriesBooks { BookId = 7, CategoryId = 9 });



            modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "Ömer Gürbüz", CreationDate = new DateTime(2022, 03, 16) });
            modelBuilder.Entity<User>().HasData(new User { Id = 2, Name = "Ahmet Hamdi Tanpınar", CreationDate = new DateTime(2022, 04, 16) });



            modelBuilder.Entity<UsersBooks>().HasData(new UsersBooks { UserId = 1, BookId = 1, BorrowDate = new DateTime(2022, 03, 16) });
            modelBuilder.Entity<UsersBooks>().HasData(new UsersBooks { UserId = 1, BookId = 7, BorrowDate = new DateTime(2022, 03, 16) });
            modelBuilder.Entity<UsersBooks>().HasData(new UsersBooks { UserId = 2, BookId = 3, BorrowDate = new DateTime(2022, 04, 16) });
            modelBuilder.Entity<UsersBooks>().HasData(new UsersBooks { UserId = 2, BookId = 2, BorrowDate = new DateTime(2022, 04, 16) });
        }
    }
}
