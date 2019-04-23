using OnelineBookStoreAPI.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.DAL
{
    public class OnelineBookStoreDBContext 
    {
        public OnelineBookStoreDBContext()
        {
            OnlineBookStoreDBInitializer onlineBookStoreDBInitializer = new OnlineBookStoreDBInitializer(this);
        }

        public List<UserDAO> Users { get; set; }
        public List<BooksDAO> Books { get; set; }
        public List<OrderDAO> Orders { get; set; }     
    }
}
