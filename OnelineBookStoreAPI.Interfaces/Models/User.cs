using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnelineBookStoreAPI.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserSecurityQuestion { get; set; }
        public string UserSecurityAnswer { get; set; }
    }
}