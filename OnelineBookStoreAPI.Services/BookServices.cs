using AutoMapper;
using OnelineBookStoreAPI.DAL.Interfaces;
using OnelineBookStoreAPI.DAL.Models;
using OnelineBookStoreAPI.Interfaces;
using OnelineBookStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnelineBookStoreAPI.Services
{
    public class BookServices : IBookServices
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public BookServices(IMapper mapper, IRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public bool BuyBook(int userID, Book bookDetails)
        {
            BooksDAO book = _mapper.Map<BooksDAO>(bookDetails);
            return _repository.BuyBook(userID, book);
        }

        public List<Book> GetBooksList()
        {
            var results = _repository.GetBooks();
            List<Book> booksList = new List<Book>();
             booksList.AddRange(_mapper.Map<List<Book>>(results));
            
            return booksList;    
        }
    }
}
