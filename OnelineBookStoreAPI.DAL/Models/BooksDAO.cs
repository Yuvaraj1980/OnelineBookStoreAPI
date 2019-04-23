using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.DAL.Models
{
    public class BooksDAO
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public double BookPrice { get; set; }
        public string BookShortDescription { get; set; }
        public string BookLongDescription { get; set; }
        public string BookSourceImagePath { get; set; }
    }
}
