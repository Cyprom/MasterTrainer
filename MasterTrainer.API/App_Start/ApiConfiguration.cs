using System.Web.Http;

namespace MasterTrainer.API.App_Start
{
    public class ApiConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
        }
    }
}