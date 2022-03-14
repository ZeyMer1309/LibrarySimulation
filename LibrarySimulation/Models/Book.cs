using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySimulation.Models
{
    class Book
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int PageCount { get; set; }
        public DateTime Year { get; set; }
        public bool IsInShelf { get; set; }


        public Author Author { get; set; }
        public int AuthorId { get; set; }


        public List<User> Users { get; set; }


        public List<Category> Categories { get; set; }
    }
}
