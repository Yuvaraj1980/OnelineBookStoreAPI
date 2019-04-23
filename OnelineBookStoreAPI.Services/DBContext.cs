using OnelineBookStoreAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.Services
{
    public class DBContext
    {
        private static OnelineBookStoreDBContext _context = new OnelineBookStoreDBContext();
        private DBContext()
        {
        }

        public static OnelineBookStoreDBContext GetContext()
        {
            return _context;
        }
    }
}
