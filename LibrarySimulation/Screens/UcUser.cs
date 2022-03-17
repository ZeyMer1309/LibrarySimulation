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
    public partial class UcUser : UserControl
    {
        BookDbContext bookDbContext = new BookDbContext();

        public UcUser()
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

            tbxUserName.Text = "";
            dtpCreationDate.Value = DateTime.Today;
        }

        private void RefreshData()
        {
            var users = bookDbContext.Users.Select(u => new
            {
                ID = u.Id,
                AdSoyad = u.Name,
                KayitTarihi = u.CreationDate,
                ElindekiKitapSayisi = u.Books.Sum(b => 1)
            });

            dgvUserList.DataSource = users.ToList();

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
            User user = new User
            {
                Name = tbxUserName.Text,
                CreationDate = dtpCreationDate.Value
            };

            bookDbContext.Users.Add(user);
            bookDbContext.SaveChanges();

            RefreshData();
        }
    }
}
