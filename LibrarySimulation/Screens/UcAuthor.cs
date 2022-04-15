using LibrarySimulation.Data;
using LibrarySimulation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySimulation
{
    public partial class UcAuthor : UserControl
    {
        BookDbContext bookDbContext;
        int lastId;

        public UcAuthor()
        {
            InitializeComponent();
            bookDbContext = new BookDbContext();
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

            if (dgvAuthorList.RowCount != 0)
            {
                picEdit.Enabled = true;
                picEdit.Image = Properties.Resources.edit;

                picDelete.Enabled = true;
                picDelete.Image = Properties.Resources.delete;
            }
            else
            {
                picEdit.Enabled = false;
                picEdit.Image = Properties.Resources.editGrey;

                picDelete.Enabled = false;
                picDelete.Image = Properties.Resources.deleteGrey;
            }

            dgvAuthorList.Enabled = true;

            tbxAuthorName.Text = "";
            tbxAuthorLastName.Text = "";
            tbxInfo.Text = "";
        }

        private void RefreshData()
        {
            var authors = bookDbContext.Authors.Select(a => new
            {
                ID = a.Id,
                Yazar = a.Name + " " + a.LastName,
                Bilgi = a.Info,
                KitapSayisi = a.Books.Sum(b => 1)
            });

            dgvAuthorList.DataSource = authors.ToList();

            dgvAuthorList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAuthorList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            ClearAll();
        }

        public void UC_Load()
        {
            RefreshData();
        }

        private bool LastIdValidation()
        {
            bool result = true;

            if (lastId != Convert.ToInt32(dgvAuthorList.SelectedRows[0].Cells[0].Value))
                result = false;

            return result;
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            if (LastIdValidation())
            {
                picEdit.Visible = false;

                picAdd.Image = Properties.Resources.addGrey;
                picDelete.Image = Properties.Resources.deleteGrey;

                picAdd.Enabled = false;
                picDelete.Enabled = false;

                picSave.Visible = true;
                picDiscard.Visible = true;

                dgvAuthorList.Enabled = false;

                var authors = bookDbContext.Authors.Select(a => new
                {
                    ID = a.Id,
                    YazarAdi = a.Name,
                    YazarSoyadi = a.LastName,
                    Bilgi = a.Info,
                }).ToList();

                int currentId = Convert.ToInt32(dgvAuthorList.SelectedRows[0].Cells[0].Value);

                foreach (var author in authors)
                    if (author.ID == currentId)
                    {
                        tbxAuthorName.Text = author.YazarAdi;
                        tbxAuthorLastName.Text = author.YazarSoyadi;
                        tbxInfo.Text = author.Bilgi;
                        break;
                    }
            }
            else
                MessageBox.Show("Son değişiklik az önce yapıldı. Lütfen farklı bir yazar üzerinde değişiklik işlemi talep edin.");
        }

        private void picDiscard_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            Author author = new Author
            {
                Name = tbxAuthorName.Text,
                LastName = tbxAuthorLastName.Text,
                Info = tbxInfo.Text
            };

            bookDbContext.Authors.Add(author);
            bookDbContext.SaveChanges();

            RefreshData();
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            Author updatingAuthor = new Author
            {
                Id = Convert.ToInt32(dgvAuthorList.SelectedRows[0].Cells[0].Value),
                Name = tbxAuthorName.Text,
                LastName = tbxAuthorLastName.Text,
                Info = tbxInfo.Text
            };

            bookDbContext.Entry(updatingAuthor).State = EntityState.Modified;
            bookDbContext.SaveChanges();

            lastId = Convert.ToInt32(dgvAuthorList.SelectedRows[0].Cells[0].Value);

            RefreshData();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (LastIdValidation())
            {
                Author deletingAuthor = new Author
                {
                    Id = Convert.ToInt32(dgvAuthorList.SelectedRows[0].Cells[0].Value)
                };

                if (bookDbContext.Entry(deletingAuthor).State == EntityState.Detached)
                    bookDbContext.Authors.Attach(deletingAuthor);

                bookDbContext.Authors.Remove(deletingAuthor);
                bookDbContext.SaveChanges();

                RefreshData();
            }
            else
                MessageBox.Show("Son değişiklik az önce yapıldı. Lütfen farklı bir yazar üzerinde silme işlemi talep edin.");

        }
    }
}
