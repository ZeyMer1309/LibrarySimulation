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
    public partial class UcBook : UserControl
    {
        BookDbContext bookDbContext = new BookDbContext();

        public UcBook()
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

            tbxBookName.Text = "";
            nupPageCount.Value = 0;
            dtpYear.Value = DateTime.Today;

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

            dgvBookList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBookList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBookList.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBookList.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


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
            Book book = new Book
            {
                Name = tbxBookName.Text,
                AuthorId = (int)cbxAuthor.SelectedValue,
                IsInShelf = true,
                PageCount = (int)nupPageCount.Value,
                Year = dtpYear.Value
            };

            bookDbContext.Books.Add(book);
            bookDbContext.SaveChanges();

            RefreshData();
        }
    }
}
