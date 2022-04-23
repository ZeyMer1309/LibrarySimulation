using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySimulation.Data
{
    class BookSQL
    {
        public static void BookValidation()
        {
            // UserBook tablosu ile Book tablosundaki isShelf alanını kontrol et. (Silinen kullanıcılar için)
            //throw new Exception("BookSQL içindeki BookValidation fonksiyonu yazılmadı");

            /*
            update Books Set Books.IsInShelf = 'false'
            FROM Books JOIN UsersBooks
            ON Books.Id = UsersBooks.BookId

            update Books Set Books.IsInShelf = 'true'
            FROM Books JOIN UsersBooks
            ON Books.Id != UsersBooks.BookId
            */

            //System.Windows.Forms.MessageBox.Show("BookSQL içindeki BookValidation fonksiyonu yazılmadı");
        }
    }
}
