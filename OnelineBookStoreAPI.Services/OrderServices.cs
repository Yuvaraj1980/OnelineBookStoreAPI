using AutoMapper;
using OnelineBookStoreAPI.DAL.Interfaces;
using OnelineBookStoreAPI.DAL.Models;
using OnelineBookStoreAPI.Interfaces;
using OnelineBookStoreAPI.Interfaces.Models;
using OnelineBookStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public OrderServices(IRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public List<Order> GetOrderDetails(int userID)
        {
            OrderDAO results = _repository.GetOrderDetails(userID);
            List<Order> orderList = new List<Order>();
            var bookmap = _mapper.Map<List<Book>>(results.BooksList);
            orderList.Add(new Order { UserID = userID, OrderId = results.OrderID, OrderedBooksList = bookmap });
       
            return orderList;
        }
    }
}
