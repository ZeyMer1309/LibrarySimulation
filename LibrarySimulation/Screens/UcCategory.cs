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

namespace LibrarySimulation
{
    public partial class UcCategory : UserControl
    {
        BookDbContext bookDbContext;
        public UcCategory()
        {
            InitializeComponent();
            bookDbContext = new BookDbContext();
        }

        public void ClearAll()
        {
            picEdit.Visible = true;

            picAdd.Image = Properties.Resources.add;
            picAdd.Enabled = true;



            picDelete.Image = Properties.Resources.deleteGrey;
            picDelete.Enabled = false;
            
            

            dgvCategoryList.Enabled = true;

            picSave.Visible = false;
            picDiscard.Visible = false;

            tbxCategory.Text = "";
        }

        private void RefreshData()
        {
            var categories = bookDbContext.Categories.Select(c => new
            {
                ID = c.Id,
                Kategori = c.Name,
                BuTurdeKitapSayisi = c.Books.Sum(b => 1)
            });

            dgvCategoryList.DataSource = categories.ToList();

            ClearAll();
        }

        public void UC_Load()
        {
            RefreshData();
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            picEdit.Visible = false;

            picAdd.Image = Properties.Resources.addGrey;
            picDelete.Image = Properties.Resources.deleteGrey;

            picAdd.Enabled = false;
            picDelete.Enabled = false;

            picSave.Visible = true;
            picDiscard.Visible = true;

            dgvCategoryList.Enabled = false;

            tbxCategory.Text = dgvCategoryList.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void picDiscard_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category { Name = tbxCategory.Text };

            bookDbContext.Categories.Add(category);
            bookDbContext.SaveChanges();

            RefreshData();
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            Category updatingCategory = new Category
            {
                Id = Convert.ToInt32(dgvCategoryList.SelectedRows[0].Cells[0].Value),
                Name = tbxCategory.Text
            };

            bookDbContext.Entry(updatingCategory).State = EntityState.Modified;
            bookDbContext.SaveChanges();

            RefreshData();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            int currentId = Convert.ToInt32(dgvCategoryList.SelectedRows[0].Cells[0].Value);

            Category updatingCategory = new Category
            {
                Id = currentId,
                Name = tbxCategory.Text
            };

            if (bookDbContext.Entry(updatingCategory).State == EntityState.Detached)
                bookDbContext.Categories.Attach(updatingCategory);

            bookDbContext.Categories.Remove(updatingCategory);
            bookDbContext.SaveChanges();

            RefreshData();
        }
    }
}
