using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.DAL.Models
{
    public class OrderDAO
    {
        public string OrderID { get; set; }
        public int UserID { get; set; }
        public List<BooksDAO> BooksList { get; set; }
    }
}
