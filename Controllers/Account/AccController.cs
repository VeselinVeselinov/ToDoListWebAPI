using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoListWebAPI.Business.Convertor.Account;
using ToDoListWebAPI.Business.Processor.Account;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.Account
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccController : BaseController<long, AccountParam, AccountResult, IAccountProcessor>
    {
        public AccController(IAccountProcessor processor) : base(processor) { }

        /// <summary>
        /// Finds an account by it's userId and name.
        /// </summary>
        /// <param name="userId">The account's user id. </param>
        /// <param name="name">The account's name. </param>
        /// <returns>An account/account collection. </returns>
        /// <response code = "200" >Returns the found account/s. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired account/s does not exist. </response>
        [HttpGet("GetByIdAndName")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByIdAndName([FromQuery]long userId, [FromQuery]string name)
        {
            if (userId == 0 || name == null)
            {
                return BadRequest();
            }

            try
            {
                List<AccountResult> result = Processor.GetByIdAndName(userId, name);

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Finds an account by it's userId and first name.
        /// </summary>
        /// <param name="userId">The account's user id. </param>
        /// <param name="firstName">The account's first name. </param>
        /// <returns>An account/account collection. </returns>
        /// <response code = "200" >Returns the found account/s. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired account/s does not exist. </response>
        [HttpGet("GetByIdAndFirstName")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByIdAndFirstName([FromQuery]long userId, [FromQuery]string firstName)
        {
            if (userId == 0 || firstName == null)
            {
                return BadRequest();
            }

            try
            {
                List<AccountResult> result = Processor.GetByIdAndFirstName(userId, firstName);

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Finds an account by it's userId and last name.
        /// </summary>
        /// <param name="userId">The account's user id. </param>
        /// <param name="lastName">The account's last name. </param>
        /// <returns>An account/account collection. </returns>
        /// <response code = "200" >Returns the found account/s. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired account/s does not exist. </response>
        [HttpGet("GetByIdAndLastName")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByIdAndLastName([FromQuery]long userId, [FromQuery]string lastName)
        {
            if (userId == 0 || lastName == null)
            {
                return BadRequest();
            }

            try
            {
                List<AccountResult> result = Processor.GetByIdAndLastName(userId, lastName);

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Finds an account by it's userId and email.
        /// </summary>
        /// <param name="userId">The account's user id. </param>
        /// <param name="email">The account's email. </param>
        /// <returns>An account/account collection. </returns>
        /// <response code = "200" >Returns the found account/s. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired account/s does not exist. </response>
        [HttpGet("GetByIdAndEmail")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByIdAndEmail([FromQuery]long userId, [FromQuery]string email)
        {
            if (userId == 0 || email == null)
            {
                return BadRequest();
            }

            try
            {
                List<AccountResult> result = Processor.GetByIdAndEmail(userId, email);

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Finds an account by it's userId and phone.
        /// </summary>
        /// <param name="userId">The account's user id. </param>
        /// <param name="phone">The account's phone number. </param>
        /// <returns>An account/account collection. </returns>
        /// <response code = "200" >Returns the found account/s. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired account/s does not exist. </response>
        [HttpGet("GetByIdAndPhone")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByIdAndPhone([FromQuery]long userId, [FromQuery]string phone)
        {
            if (userId == 0 || phone == null)
            {
                return BadRequest();
            }

            try
            {
                List<AccountResult> result = Processor.GetByIdAndPhone(userId, phone);

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}