using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySimulation.Models
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public List<CategoriesBooks> Books { get; set; }
    }
}
