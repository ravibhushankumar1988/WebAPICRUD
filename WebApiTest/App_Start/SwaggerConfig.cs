using System.Web.Http;
using WebActivatorEx;
using WebApiTest;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebApiTest
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;
            GlobalConfiguration.Configuration
                .EnableSwagger(c => c.SingleApiVersion("V1", "First WEB API DEMO"))
                .EnableSwaggerUi();

            //GlobalConfiguration.Configuration 
            //    .EnableSwagger(c =>
            //        {                        
            //            c.SingleApiVersion("v1", "WebApiTest");                       

            //        })
            //    .EnableSwaggerUi(c =>
            //        {
                        
            //        });
        }
    }
}