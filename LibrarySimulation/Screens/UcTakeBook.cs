using LibrarySimulation.Data;
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
    public partial class UcTakeBook : UserControl
    {
        BookDbContext bookDbContext;
        BookSQL bookSQL;
        public UcTakeBook()
        {
            InitializeComponent();
            bookDbContext = new BookDbContext();
            bookSQL = new BookSQL();
        }

        public void RefreshData()
        {
            var users = bookDbContext.Users.Select(u => new
            {
                ID = u.Id,
                Name = u.Name
            }).ToList();

            lbxUsers.DataSource = users;
            lbxUsers.DisplayMember = "Name";
            lbxUsers.ValueMember = "ID";

            lbxUsers.SelectedIndexChanged += lbxUsers_SelectedIndexChanged;
            getBooksByUserId(Convert.ToInt32(lbxUsers.SelectedValue));
        }

        private void lbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBooksByUserId(Convert.ToInt32(lbxUsers.SelectedValue));
        }

        public void getBooksByUserId(int Id)
        {
            var allContext = bookDbContext.Books.Include(b => b.Author)
                                                .Include(b => b.Users)
                                                .ThenInclude(u => u.User);

            var data = allContext.Select(b => new
            {
                BookId = b.Id,
                BookName = b.Name,
                BookAuthor = b.Author.Name + " " + b.Author.LastName,
                Users = b.Users
            });

            dgvBooksByUsers.DataSource = data.Select(x => new 
            { 
                x.BookId, x.BookName, x.BookAuthor,
                BorrowDate = x.Users.Where(b => b.UserId == Convert.ToInt32(lbxUsers.SelectedValue)).Select(b => b.BorrowDate).First() 
            }).ToList();

            var filteredData = data.Where(d => d.Users.Any(u => u.UserId == Id));

            foreach (DataGridViewRow row in dgvBooksByUsers.Rows)
                row.Selected = filteredData.Select(x => x.BookId).Contains(Convert.ToInt32(row.Cells[0].Value));
        }

        private void picTake_Click(object sender, EventArgs e)
        {
            int userId = (int)lbxUsers.SelectedValue;
            List<int> bookIds = new List<int>();
            for (int i = 0; i < dgvBooksByUsers.SelectedRows.Count; i++)
                if (Convert.ToDateTime(dgvBooksByUsers.SelectedRows[i].Cells[3].Value) < new DateTime(2000, 1, 1))
                    bookIds.Add(Convert.ToInt32(dgvBooksByUsers.SelectedRows[i].Cells[0].Value));

            bookSQL.TakeBook(userId, bookIds);

            int tempSelection = lbxUsers.SelectedIndex;
            RefreshData();
            lbxUsers.SelectedIndex = tempSelection;
        }

        private void picGive_Click(object sender, EventArgs e)
        {
            int userId = (int)lbxUsers.SelectedValue;
            List<int> bookIds = new List<int>();
            for (int i = 0; i < dgvBooksByUsers.SelectedRows.Count; i++)
                bookIds.Add(Convert.ToInt32(dgvBooksByUsers.SelectedRows[i].Cells[0].Value));

            bookSQL.GiveBook(userId, bookIds);

            int tempSelection = lbxUsers.SelectedIndex;
            RefreshData();
            lbxUsers.SelectedIndex = tempSelection;
        }
    }
}
