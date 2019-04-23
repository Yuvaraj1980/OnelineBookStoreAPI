using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnelineBookStoreAPI.Models
{
    public class Book
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