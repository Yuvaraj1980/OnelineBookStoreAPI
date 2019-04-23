using OnelineBookStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.Interfaces
{
    public interface ILoginServices
    {
        bool RegisterUser(User userDetails);
        string LoginUser(User userDetails);        
    }
}
