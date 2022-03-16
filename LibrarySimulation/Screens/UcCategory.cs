﻿using LibrarySimulation.Data;
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

        public void UC_Load()
        {
            ClearAll();

            BookDbContext bookDbContext = new BookDbContext();

            var categories = bookDbContext.Categories.Select(c => new
            {
                ID = c.Id,
                Kategori = c.Name,
                BuTurdeKitapSayisi = c.Books.Sum(b => b.CategoryId)
            });

            dgvCategoryList.DataSource = categories.ToList();
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
    }
}
