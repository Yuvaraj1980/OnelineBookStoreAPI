using OnelineBookStoreAPI.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.DAL.Interfaces
{
    public interface IRepository
    {      
        bool AddUser(UserDAO user);
        string FindUser(UserDAO user);
        List<BooksDAO> GetBooks();
        bool BuyBook(int userID, BooksDAO booksDAO);
        OrderDAO GetOrderDetails(int userID);
    }
}
