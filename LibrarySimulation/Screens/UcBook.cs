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
    public partial class UcBook : UserControl
    {
        BookDbContext bookDbContext;
        int lastId;

        public UcBook()
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

            if (dgvBookList.RowCount != 0)
            {
                picEdit.Enabled = true;
                picEdit.Image = Properties.Resources.edit;
            }
            else
            {
                picEdit.Enabled = false;
                picEdit.Image = Properties.Resources.editGrey;
            }

            dgvBookList.Enabled = true;
            picSave.Visible = false;
            picDiscard.Visible = false;

            tbxBookName.Text = "";
            nupPageCount.Value = 0;
            nupYear.Value = DateTime.Today.Year;

            cbxAuthor.SelectedItem = null;
        }

        public void RefreshData()
        {
            var books = bookDbContext.Books.Select(b => new
            {
                ID = b.Id,
                KitapAdi = b.Name,
                Yazari = b.Author.Name + " " + b.Author.LastName,
                SayfaSayisi = b.PageCount,
                RaftaMi = b.IsInShelf,
                CikisYili = b.Year.Year
            });

            dgvBookList.DataSource = books.ToList();

            dgvBookList.Columns[0].Width = 43;
            dgvBookList.Columns[1].Width = 232;
            dgvBookList.Columns[2].Width = 231;
            dgvBookList.Columns[3].Width = 86;
            dgvBookList.Columns[4].Width = 50;
            dgvBookList.Columns[5].Width = 67;


            var authors = bookDbContext.Authors.Select(a => new
            {
                ID = a.Id,
                Yazar = a.Name + " " + a.LastName
            }).ToList();

            cbxAuthor.DataSource = authors;
            cbxAuthor.DisplayMember = "Yazar"; // Görünecek kısım
            cbxAuthor.ValueMember = "ID"; // Değer kısmı

            ClearAll();
        }

        public void UC_Load()
        {
            RefreshData();
        }

        private bool LastIdValidation()
        {
            bool result = true;

            if (lastId != Convert.ToInt32(dgvBookList.SelectedRows[0].Cells[0].Value))
                result = false;

            return result;
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            if (lastId != Convert.ToInt32(dgvBookList.SelectedRows[0].Cells[0].Value))
            {
                picEdit.Visible = false;

                picAdd.Image = Properties.Resources.addGrey;
                picDelete.Image = Properties.Resources.deleteGrey;

                picAdd.Enabled = false;
                picDelete.Enabled = false;

                picSave.Visible = true;
                picDiscard.Visible = true;

                dgvBookList.Enabled = false;

                tbxBookName.Text = dgvBookList.SelectedRows[0].Cells[1].Value.ToString();
                if (dgvBookList.SelectedRows[0].Cells[2].Value != null)
                    foreach (dynamic item in cbxAuthor.Items)
                        if (item.Yazar == dgvBookList.SelectedRows[0].Cells[2].Value.ToString())
                            cbxAuthor.SelectedItem = item;

                nupYear.Value = Convert.ToDecimal(dgvBookList.SelectedRows[0].Cells[5].Value);
                nupPageCount.Value = Convert.ToDecimal(dgvBookList.SelectedRows[0].Cells[3].Value);
            }
            else
                MessageBox.Show("Son değişiklik az önce yapıldı. Lütfen farklı bir kitap üzerinde değişiklik işlemi talep edin.");
        }

        private void picDiscard_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                Name = tbxBookName.Text,
                AuthorId = (int)cbxAuthor.SelectedValue,
                IsInShelf = true,
                PageCount = (int)nupPageCount.Value,
                Year = DateTime.ParseExact(nupYear.Value.ToString(), "yyyy", System.Globalization.CultureInfo.InvariantCulture)
            };

            bookDbContext.Books.Add(book);
            bookDbContext.SaveChanges();

            RefreshData();
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            Book updatingBook = new Book
            {
                Id = Convert.ToInt32(dgvBookList.SelectedRows[0].Cells[0].Value),
                Name = tbxBookName.Text,
                AuthorId = (int)cbxAuthor.SelectedValue,
                IsInShelf = true,
                PageCount = (int)nupPageCount.Value,
                Year = DateTime.ParseExact(nupYear.Value.ToString(), "yyyy", System.Globalization.CultureInfo.InvariantCulture)
            };

            bookDbContext.Entry(updatingBook).State = EntityState.Modified;
            bookDbContext.SaveChanges();

            lastId = Convert.ToInt32(dgvBookList.SelectedRows[0].Cells[0].Value);

            RefreshData();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (LastIdValidation())
            {
                Book deletingBook = new Book
                {
                    Id = Convert.ToInt32(dgvBookList.SelectedRows[0].Cells[0].Value)
                };

                if (bookDbContext.Entry(deletingBook).State == EntityState.Detached)
                    bookDbContext.Books.Attach(deletingBook);

                bookDbContext.Books.Remove(deletingBook);
                bookDbContext.SaveChanges();

                RefreshData();
            }
            else
                MessageBox.Show("Son değişiklik az önce yapıldı. Lütfen farklı bir kitap üzerinde değişiklik işlemi talep edin.");

        }
    }
}
