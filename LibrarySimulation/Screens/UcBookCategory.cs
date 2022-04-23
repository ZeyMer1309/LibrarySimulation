using LibrarySimulation.Data;
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
            }).ToList();

            lbxCategoryTypes.DataSource = categories;
            lbxCategoryTypes.DisplayMember = "Ctg";
            lbxCategoryTypes.ValueMember = "ID";

            lbxCategoryTypes.SelectedIndexChanged += lbxCategoryTypes_SelectedIndexChanged;
            getBooksByCategoryId(Convert.ToInt32(lbxCategoryTypes.SelectedValue));
        }

        private void lbxCategoryTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBooksByCategoryId(Convert.ToInt32(lbxCategoryTypes.SelectedValue));
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
    }
}
