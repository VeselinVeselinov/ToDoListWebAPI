using ToDoListWebAPI.Controllers.Common;
using ToDoListWebAPI.Business.Convertor.ApiSession;
using ToDoListWebAPI.Business.Processor.ApiSession;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ToDoListWebAPI.Controllers.ApiSession
{
    public class ApiSessionController : BaseController<long, ApiSessionParam, ApiSessionResult, IApiSessionProcessor>
    {
        public ApiSessionController(IApiSessionProcessor processor) : base(processor){ }

        /// <summary>
        /// Finds an active session by its authToken.
        /// </summary>
        /// <param name="token">Session's authToken. </param>
        /// <returns>ApiSessionResult </returns>
        /// <response code = "200" >An active session has been found. </response>
        /// <response code = "400" >Input data is invalid. </response>
        [HttpGet("GetByToken/{token}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetByTokenAsync(string token)
        {
            if (token == null)
            {
                return BadRequest();
            }

            try
            {
                ApiSessionResult sessionResult = await Processor.GetByAuthTokenAsync(token);

                return Ok(sessionResult);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }
    }
}