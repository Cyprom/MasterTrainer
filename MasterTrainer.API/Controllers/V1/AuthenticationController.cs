﻿namespace MasterTrainer.API.Controllers.V1
{
    using NLog;
    using System;
    using System.Web;
    using System.Web.Http;
    using System.Web.Security;
    using MasterTrainer.DataContracts.AuthenticationManagement;
    using MasterTrainer.Business.AuthenticationManagement.Services;
    using MasterTrainer.Business.UserManagement.Services;

    [RoutePrefix("api/v1/authentication")]
    public class AuthenticationController : ApiController
    {
        private ILogger logger = LogManager.GetLogger("APILogger");
        private readonly IAuthenticationService authenticationService;
        private readonly IUserService userService;

        public AuthenticationController()
        {
            authenticationService = new AuthenticationService();
            userService = new UserService();
        }

        [HttpPost, Route("log-in")]
        public IHttpActionResult LogIn(Credentials credentials)
        {
            try
            {
                var user = authenticationService.Authenticate(credentials.Name, credentials.Password);
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(credentials.Name.ToLowerInvariant(), false);
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

        [Authorize, HttpDelete, Route("log-out")]
        public IHttpActionResult LogOut()
        {
            try
            {
                if (HttpContext.Current.Request.IsAuthenticated)
                {
                    FormsAuthentication.SignOut();
                }
                return Ok();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                return InternalServerError(ex);
            }
        }

        [HttpGet, Route("is-logged-in")]
        public IHttpActionResult IsLoggedIn()
        {
            try
            {
                if (HttpContext.Current.Request.IsAuthenticated)
                {
                    var user = userService.GetByName(HttpContext.Current.User?.Identity?.Name);
                    return Ok(user);
                }
                return Unauthorized();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                return InternalServerError(ex);
            }
        }
    }
}