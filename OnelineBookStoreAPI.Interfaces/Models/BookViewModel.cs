using OnelineBookStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.Interfaces.Models
{
    public class BookViewModel
    {
        public Dictionary<string, Book> BookDetails { get; set; }
    }
}
