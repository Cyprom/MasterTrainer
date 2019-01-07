using System;
using System.Web;
using System.Web.Http;
using MasterTrainer.API.App_Start;

namespace MasterTrainer.API
{

    /**
     * Development tasks
     * -----------------
     * TODO: Prepare dashboard
     * TODO: Write instructions manual (static pages in frontend instructions component)
     * TODO: Complete design and styling of unauthorized pages
     */

    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(ApiConfiguration.Register);
        }

        protected void Session_Start(object sender, EventArgs e) { }

        protected void Application_BeginRequest(object sender, EventArgs e) { }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) { }

        protected void Application_Error(object sender, EventArgs e) { }

        protected void Session_End(object sender, EventArgs e) { }

        protected void Application_End(object sender, EventArgs e) { }
    }
}