using OnelineBookStoreAPI.Interfaces;
using OnelineBookStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;

namespace OnelineBookStoreAPI.Controllers
{
    public class BooksController : ApiController
    {
        private readonly IBookServices _bookServices;

        public BooksController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        [HttpGet]
        [Route("api/books/viewbooks")]
        public List<Book> ViewBooks()
        {
            return _bookServices.GetBooksList();
        }

        [HttpPost]
        [Route("api/books/buybook")]
        public bool BuyBook(int userID, Book book)
        {
            return _bookServices.BuyBook(userID, book);
        }       
    }
}