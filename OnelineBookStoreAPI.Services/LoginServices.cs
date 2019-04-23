using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using OnelineBookStoreAPI.DAL;
using OnelineBookStoreAPI.DAL.Interfaces;
using OnelineBookStoreAPI.DAL.Models;
using OnelineBookStoreAPI.Interfaces;
using OnelineBookStoreAPI.Models;

namespace OnelineBookStoreAPI.Services
{
    public class LoginServices : ILoginServices
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public LoginServices(IRepository repository, IMapper mapper)
        {

            _mapper = mapper;
            _repository = repository;
        }

        public string LoginUser(User userDetails)
        {
            UserDAO user = _mapper.Map<UserDAO>(userDetails);
            return _repository.FindUser(user);            
        }

        public bool RegisterUser(User userDetails)
        {
            throw new NotImplementedException();
        }
    }
}
