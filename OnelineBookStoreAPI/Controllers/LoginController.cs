using OnelineBookStoreAPI.Interfaces;
using OnelineBookStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnelineBookStoreAPI.Controllers
{
    public class LoginController : ApiController
    {
        private readonly ILoginServices _loginServices;       

        public LoginController(ILoginServices loginServices)
        {
            _loginServices = loginServices;
        }       

        [HttpPost]
        [Route("api/login/registeruser")]
        public bool RegisterUser(User userDetails)
        {
            return _loginServices.RegisterUser(userDetails);             
        }

        [HttpPost]
        [Route("api/login/loginuser")]
        public string LoginUser(User userDetails)
        {
            return _loginServices.LoginUser(userDetails);
        }
    }
}
