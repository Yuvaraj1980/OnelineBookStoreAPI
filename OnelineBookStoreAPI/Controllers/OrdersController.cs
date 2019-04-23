using OnelineBookStoreAPI.Interfaces;
using OnelineBookStoreAPI.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OnelineBookStoreAPI.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly IOrderServices _orderServices;

        public OrdersController(IOrderServices bookServices)
        {
            _orderServices = bookServices;
        }

        [HttpGet]
        [Route("api/orders/orderdetails")]
        public List<Order> GetOrderDetails(int userID)
        {
            return _orderServices.GetOrderDetails(userID);
        }       
    }
}