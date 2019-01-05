namespace MasterTrainer.API.Controllers.V1
{
    using NLog;
    using System;
    using System.Web.Http;
    using MasterTrainer.Business.PawnManagement.Services;

    [Authorize, RoutePrefix("api/v1/pawn")]
    public class PawnController : ApiController
    {
        private ILogger logger = LogManager.GetLogger("APILogger");
        private readonly IPawnService pawnService;

        public PawnController()
        {
            this.pawnService = new PawnService();
        }

        [HttpGet, Route("pawns")]
        public IHttpActionResult ReadAll()
        {
            try
            {
                var pawns = pawnService.GetAll();
                return Ok(pawns);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                return InternalServerError(ex);
            }
        }
    }
}