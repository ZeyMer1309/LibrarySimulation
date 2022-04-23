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
        int lastId;
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

            picDelete.Image = Properties.Resources.delete;
            picDelete.Enabled = true;

            if (dgvCategoryList.RowCount != 0)
            {
                picEdit.Enabled = true;
                picEdit.Image = Properties.Resources.edit;

                picFind.Enabled = true;
                picFind.Image = Properties.Resources.find;
            }
            else
            {
                picEdit.Enabled = false;
                picEdit.Image = Properties.Resources.editGrey;

                picFind.Enabled = false;
                picFind.Image = Properties.Resources.findGrey;
            }

            dgvCategoryList.Enabled = true;

            ucUserCategory1.Visible = false;

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

        private bool LastIdValidation()
        {
            bool result = true;

            if (lastId != Convert.ToInt32(dgvCategoryList.SelectedRows[0].Cells[0].Value))
                result = false;

            return result;
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            if (lastId != Convert.ToInt32(dgvCategoryList.SelectedRows[0].Cells[0].Value))
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
            else
                MessageBox.Show("Son değişiklik az önce yapıldı. Lütfen farklı bir kategori üzerinde değişiklik işlemi talep edin.");

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

            lastId = Convert.ToInt32(dgvCategoryList.SelectedRows[0].Cells[0].Value);

            RefreshData();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (LastIdValidation())
            {
                Category deletingCategory = new Category
                {
                    Id = Convert.ToInt32(dgvCategoryList.SelectedRows[0].Cells[0].Value)
                };

                if (bookDbContext.Entry(deletingCategory).State == EntityState.Detached)
                    bookDbContext.Categories.Attach(deletingCategory);

                bookDbContext.Categories.Remove(deletingCategory);
                bookDbContext.SaveChanges();

                RefreshData();
            }
            else
                MessageBox.Show("Son değişiklik az önce yapıldı. Lütfen farklı bir kitap üzerinde değişiklik işlemi talep edin.");

        }

        private void picFind_Click(object sender, EventArgs e)
        {
            ucUserCategory1.rdf = RefreshData;
            ucUserCategory1.Visible = true;
            ucUserCategory1.RefreshData();
        }
    }
}
