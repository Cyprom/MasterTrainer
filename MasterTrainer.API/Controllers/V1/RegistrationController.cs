using NLog;
using System;
using System.Web.Http;
using MasterTrainer.Business.Services;
using MasterTrainer.DataContracts.Server;

namespace MasterTrainer.API.Controllers.V1
{
    [RoutePrefix("api/v1/registration")]
    public class RegistrationController : ApiController
    {
        private ILogger logger = LogManager.GetLogger("APILogger");

        private readonly IRegistrationService registrationService;

        public RegistrationController(IRegistrationService registrationService)
        {
            this.registrationService = registrationService;
        }

        [HttpPost, Route("register")]
        public IHttpActionResult Register(Registration registration)
        {
            try
            {
                var user = registrationService.Register(registration.Name, registration.Password, registration.Confirmation);
                if (user != null)
                {
                    return Ok(user);
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                return InternalServerError(ex);
            }
        }
    }
}