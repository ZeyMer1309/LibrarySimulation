using LibrarySimulation.Data;
using LibrarySimulation.Models;
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
        BookDbContext bookDbContext = new BookDbContext();
        public UcCategory()
        {
            InitializeComponent();
        }

        public void ClearAll()
        {
            picEdit.Visible = true;

            picAdd.Image = Properties.Resources.add;
            picDelete.Image = Properties.Resources.delete;

            picAdd.Enabled = true;
            picDelete.Enabled = true;

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
    }
}
