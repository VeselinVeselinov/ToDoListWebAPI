using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ToDoListWebAPI.Business.Processor.Authentication;
using ToDoListWebAPI.Business.Convertor.Account;
using Microsoft.AspNetCore.Authorization;

namespace ToDoListWebAPI.Controllers.Authentication
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthProcessor _authProcessor;

        public IAuthProcessor AuthProcessor
        {
            get { return _authProcessor; }
            set { _authProcessor = value; }
        }

        public AuthController(IAuthProcessor authProcessor)
        {
            _authProcessor = authProcessor;
        }

        [HttpPost("Register")]
        [AllowAnonymous]
        public IActionResult Register([FromBody]AccountParam param)
        {
            try
            {
                AuthProcessor.Register(param, Request);

                return Ok("You have successfully managed to create an account. ");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return BadRequest();
            }  
        }

        //[HttpGet("ValidateUsername/{username}")]
        //[AllowAnonymous]
        //public IActionResult ValidateUsername(string username)
        //{
        //    try
        //    {
        //        bool isValid = AuthProcessor.ValidateUsername(username);

        //        return Ok(isValid);
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest();
        //    }
        //}

        //[HttpGet("ValidateEmail/{email}")]
        //[AllowAnonymous]
        //public IActionResult ValidateEmail(string email)
        //{
        //    try
        //    {
        //        bool isValid = AuthProcessor.ValidateEmail(email);

        //        return Ok(isValid);
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest();
        //    }
        //}

        /// <summary>
        /// Logs a user in the system by creating him a session and generating an authToken. 
        /// </summary>
        /// <returns>An authToken. </returns>
        /// <response code = "200" >User has successfully received an auth token. </response>
        /// <response code = "401" >Unauthorized request. </response>
        [HttpGet("LogIn")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult LogIn()
        {
            try
            {
                string authToken = AuthProcessor.GetAuthToken(HttpContext);

                return Ok(authToken);
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }

        /// <summary>
        /// Logs a user out of the system by terminating his current api session.
        /// </summary>
        /// <returns>Successful message. </returns>
        /// <response code = "200" >User's current api session is successfully terminated. </response>
        /// <response code = "400" >Bad request. </response>
        [HttpGet("LogOut")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult LogOut()
        {
            try
            {
                AuthProcessor.TerminateApiSession(HttpContext);

                return Ok("User has successfully logged out of the system. ");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}