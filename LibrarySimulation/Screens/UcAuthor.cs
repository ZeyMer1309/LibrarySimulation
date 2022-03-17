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
    public partial class UcAuthor : UserControl
    {
        BookDbContext bookDbContext = new BookDbContext();

        public UcAuthor()
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

        private void picEdit_Click(object sender, EventArgs e)
        {
            picEdit.Visible = false;

            picAdd.Image = Properties.Resources.addGrey;
            picDelete.Image = Properties.Resources.deleteGrey;

            picAdd.Enabled = false;
            picDelete.Enabled = false;

            picSave.Visible = true;
            picDiscard.Visible = true;

            dgvAuthorList.Enabled = false;
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
    }
}
