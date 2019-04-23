using OnelineBookStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.Interfaces.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public int UserID { get; set; }
        public List<Book> OrderedBooksList { get; set; }
    }
}
