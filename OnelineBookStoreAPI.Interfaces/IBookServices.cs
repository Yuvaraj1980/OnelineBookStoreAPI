using OnelineBookStoreAPI.Interfaces.Models;
using OnelineBookStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.Interfaces
{
    public interface IBookServices
    {
        List<Book> GetBooksList();

        bool BuyBook(int userID, Book book);
    }
}
