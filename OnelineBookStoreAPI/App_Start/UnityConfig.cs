using AutoMapper;
using OnelineBookStoreAPI.DAL;
using OnelineBookStoreAPI.DAL.Interfaces;
using OnelineBookStoreAPI.DAL.Models;
using OnelineBookStoreAPI.Interfaces;
using OnelineBookStoreAPI.Interfaces.Models;
using OnelineBookStoreAPI.Models;
using OnelineBookStoreAPI.Services;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace OnelineBookStoreAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterSingleton<IRepository, OnelineBookStoreAPIRepository>();
            container.RegisterSingleton<ILoginServices, LoginServices>();
            container.RegisterSingleton<IOrderServices, OrderServices>();
            container.RegisterSingleton<IBookServices, BookServices>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Book, BooksDAO>();
                cfg.CreateMap<Order, OrderDAO>();
                cfg.CreateMap<User, UserDAO>();
            });

            IMapper mapper = config.CreateMapper();    
            
            container.RegisterInstance(mapper);
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}