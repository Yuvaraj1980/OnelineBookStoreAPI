using System.Web.Http;
using WebActivatorEx;
using OnelineBookStoreAPI;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace OnelineBookStoreAPI
{
    public class SwaggerConfig
    {    

        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "OnelineBookStoreAPI");
                        c.PrettyPrint();
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.DocumentTitle("OnlineBookStore Swagger UI");
                    });
        }
    }
}
