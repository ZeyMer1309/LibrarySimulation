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
    public partial class UcUser : UserControl
    {
        BookDbContext bookDbContext;
        int lastId;

        public UcUser()
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

            if (dgvUserList.RowCount != 0)
            {
                picEdit.Enabled = true;
                picEdit.Image = Properties.Resources.edit;
            }
            else
            {
                picEdit.Enabled = false;
                picEdit.Image = Properties.Resources.editGrey;
            }

            dgvUserList.Enabled = true;

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

        private bool LastIdValidation()
        {
            bool result = true;

            if (lastId != Convert.ToInt32(dgvUserList.SelectedRows[0].Cells[0].Value))
                result = false;

            return result;
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            if (lastId != Convert.ToInt32(dgvUserList.SelectedRows[0].Cells[0].Value))
            {
                picEdit.Visible = false;

                picAdd.Image = Properties.Resources.addGrey;
                picDelete.Image = Properties.Resources.deleteGrey;

                picAdd.Enabled = false;
                picDelete.Enabled = false;

                picSave.Visible = true;
                picDiscard.Visible = true;

                dgvUserList.Enabled = false;

                tbxUserName.Text = dgvUserList.SelectedRows[0].Cells[1].Value.ToString();
                dtpCreationDate.Value = Convert.ToDateTime(dgvUserList.SelectedRows[0].Cells[2].Value);
            }
            else
                MessageBox.Show("Son değişiklik az önce yapıldı. Lütfen farklı bir kullanıcı üzerinde değişiklik işlemi talep edin.");

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

        private void picSave_Click(object sender, EventArgs e)
        {
            User updatingUser = new User
            {
                Id = Convert.ToInt32(dgvUserList.SelectedRows[0].Cells[0].Value),
                Name = tbxUserName.Text,
                CreationDate = dtpCreationDate.Value
            };

            bookDbContext.Entry(updatingUser).State = EntityState.Modified;
            bookDbContext.SaveChanges();

            lastId = Convert.ToInt32(dgvUserList.SelectedRows[0].Cells[0].Value);

            RefreshData();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (LastIdValidation())
            {
                User deletingUser = new User
                {
                    Id = Convert.ToInt32(dgvUserList.SelectedRows[0].Cells[0].Value)
                };

                if (bookDbContext.Entry(deletingUser).State == EntityState.Detached)
                    bookDbContext.Users.Attach(deletingUser);

                bookDbContext.Users.Remove(deletingUser);
                bookDbContext.SaveChanges();

                RefreshData();
            }
            else
                MessageBox.Show("Son değişiklik az önce yapıldı. Lütfen farklı bir kitap üzerinde değişiklik işlemi talep edin.");
        }
    }
}
