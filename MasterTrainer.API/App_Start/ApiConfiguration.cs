namespace MasterTrainer.API.App_Start
{
    using System.Web.Http;

    // TODO: Fix database types
    // TODO: Use injection or singletons
    // TODO: Test initial setup
    // TODO: Happy coding!

    public class ApiConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}