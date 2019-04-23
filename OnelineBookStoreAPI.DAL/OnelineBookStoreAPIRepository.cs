using OnelineBookStoreAPI.DAL.Interfaces;
using OnelineBookStoreAPI.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.DAL
{
    public class OnelineBookStoreAPIRepository :  IRepository
    {
        public OnelineBookStoreDBContext _context;

        public OnelineBookStoreAPIRepository(OnelineBookStoreDBContext context)
        {
            _context = context;
        }

        public bool AddUser(UserDAO user)
        {
            return true;
        }

        public string FindUser(UserDAO user)
        {
            return _context.Users.Find(x => x.UserName == user.UserName && x.Password == user.Password).UserID;
        }           

        public List<BooksDAO> GetBooks()
        {
            return _context.Books.ToList();
        }

        public bool BuyBook(int userID, BooksDAO booksDAO)
        {
            var bookList = new List<BooksDAO>();
            bookList.Add(booksDAO);
            if (!_context.Orders.Exists(x => x.UserID == userID))
            {
                _context.Orders.Add(new OrderDAO() { BooksList = bookList, OrderID = new Random(1000).Next().ToString(), UserID = userID });
            }
            else
            {
              int index =  _context.Orders.FindIndex(x => x.UserID == userID);
                _context.Orders[index].BooksList.Add(booksDAO);
            }
            return true;
        }

        public OrderDAO GetOrderDetails(int userID)
        {
            return _context.Orders.Find(x=>x.UserID == userID);
        }       
    }
}
