using LibrarySimulation.Data;
using LibrarySimulation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySimulation.Screens
{
    public partial class UcBookCategory : UserControl
    {
        public delegate void RefreshDataFunction();
        public RefreshDataFunction rdf;
        BookDbContext bookDbContext;
        int lastId;

        public UcBookCategory()
        {
            InitializeComponent();
            bookDbContext = new BookDbContext();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            rdf();
        }

        public void RefreshData()
        {
            var categories = bookDbContext.Categories.Select(c => new
            {
                ID = c.Id,
                Ctg = c.Name
            });

            lbxCategoryTypes.DataSource = categories.ToList();
            lbxCategoryTypes.DisplayMember = "Ctg";
            lbxCategoryTypes.ValueMember = "ID";

            lbxCategories.DataSource = categories.ToList();
            lbxCategories.DisplayMember = "Ctg";
            lbxCategories.ValueMember = "ID";

            var books = bookDbContext.Books.Select(b => new
            {
                ID = b.Id,
                Book = b.Name
            }).ToList();

            lbxBooks.DataSource = books;
            lbxBooks.DisplayMember = "Book";
            lbxBooks.ValueMember = "ID";

            lbxBooks.SelectedIndexChanged += lbxBooks_SelectedIndexChanged;
            getCategoriesByBookId(Convert.ToInt32(lbxBooks.SelectedValue));

            lbxCategoryTypes.SelectedIndexChanged += lbxCategoryTypes_SelectedIndexChanged;
            getBooksByCategoryId(Convert.ToInt32(lbxCategoryTypes.SelectedValue));
        }

        private void lbxCategoryTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBooksByCategoryId(Convert.ToInt32(lbxCategoryTypes.SelectedValue));
        }

        private void lbxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCategoriesByBookId(Convert.ToInt32(lbxBooks.SelectedValue));
        }

        public void getBooksByCategoryId(int Id)
        {
            var allContext = bookDbContext.Books.Include(b => b.Author)
                                                .Include(b => b.Categories)
                                                .ThenInclude(c => c.Category);

            var data = allContext.Select(b => new
            {
                BookId = b.Id,
                BookName = b.Name,
                BookAuthor = b.Author.Name + " " + b.Author.LastName,
                BookCategory = b.Categories
            });

            var filteredData = data.Where(d => d.BookCategory.Any(bc => bc.CategoryId == Id));

            dgvBooksByCategories.DataSource = filteredData.Select(x => new { x.BookId, x.BookName, x.BookAuthor }).ToList();
        }

        public void getCategoriesByBookId(int id)
        {
            BookSQL bookSQL = new BookSQL();
            Dictionary<int, string> categories = bookSQL.getCategoriesByBookId(id);
            lbxCategories.SelectedIndex = -1;

            foreach (var category in categories)
                lbxCategories.SetSelectedWithValue(category.Key, true);
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            List<int> selectedCategories = new List<int>();
            foreach (dynamic item in lbxCategories.SelectedItems)
                selectedCategories.Add(item.ID);

            new BookSQL().DeleteBookCategoryDetails((int)lbxBooks.SelectedValue);
            new BookSQL().AddBookCategoryDetails((int)lbxBooks.SelectedValue, selectedCategories);

            RefreshData();
        }
    }
}
