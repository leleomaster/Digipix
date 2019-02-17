using Digipix.Infrastructure.AutoMapper.Mappers;
using System.Web.Http;

namespace Digipix.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.Run();
        }
    }
}
