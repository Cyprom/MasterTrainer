namespace MasterTrainer.API.Controllers.V1
{
    using NLog;
    using System;
    using System.Web.Http;
    using MasterTrainer.DataContracts.RegistrationManagement;
    using MasterTrainer.Business.RegistrationManagement.Services;

    [RoutePrefix("api/v1/registration")]
    public class RegistrationController : ApiController
    {
        private ILogger logger = LogManager.GetLogger("APILogger");
        private readonly IRegistrationService registrationService;

        public RegistrationController()
        {
            registrationService = new RegistrationService();
        }

        [HttpPost, Route("register")]
        public IHttpActionResult Register(Registration registration)
        {
            try
            {
                var user = registrationService.Register(registration.Name, registration.Email, registration.Password, registration.Confirmation);
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