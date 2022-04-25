using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySimulation.Data
{
    class BookSQL
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Mssqllocaldb; Database=LibrarySimulatorDb; Integrated security=true");

        /// <summary>
        /// Bu fonksiyon kitapların rafta olup olmadığının kontrolünü yapar. Bunu yaparken önce tüm kitapları rafta olarak ayarlar. Sonra da alınmış kitapları raftan siler.
        /// </summary>
        public void BookValidation()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "update Books Set Books.IsInShelf = \'true\' FROM Books";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "update Books Set Books.IsInShelf = \'false\' FROM Books JOIN UsersBooks ON Books.Id = UsersBooks.BookId";
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void GiveBook(int userId, List<int> bookIds)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            foreach (var bookId in bookIds)
            {
                cmd.CommandText = "delete from UsersBooks where BookId = "+ bookId +" AND UserId = " + userId +"";
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }

        public void TakeBook(int userId, List<int> bookIds)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            foreach (var bookId in bookIds)
            {
                cmd.CommandText = "insert into UsersBooks (UserId, BookId, BorrowDate) values ( @UserId , @BookId , CAST( GETDATE() AS Date) )";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@BookId", bookId);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }
    }
}
