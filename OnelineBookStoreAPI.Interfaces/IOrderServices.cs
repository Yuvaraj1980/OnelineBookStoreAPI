using OnelineBookStoreAPI.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.Interfaces
{
    public interface IOrderServices
    {
        List<Order> GetOrderDetails(int userID);
    }
}
