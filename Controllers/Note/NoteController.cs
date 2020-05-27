using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoListWebAPI.Business.Convertor.Note;
using ToDoListWebAPI.Business.Processor.Note;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.Note
{
    public class NoteController : BaseController<long, NoteParam, NoteResult, INoteProcessor>
    {
        public NoteController(INoteProcessor processor) : base(processor)
        {
        }

        /// <summary>
        /// Finds a note by it's accountId and category name.
        /// </summary>
        /// <param name="accountId">The note's account id. </param>
        /// <param name="category">The note's category. </param>
        /// <returns>A note/note collection. </returns>
        /// <response code = "200" >Returns the found note/s. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired note/s does not exist. </response>
        [HttpGet("GetByIdAndCategory")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByIdAndCategory([FromQuery]long accountId, [FromQuery]string category)
        {
            if (accountId == 0 || category == null)
            {
                return BadRequest();
            }

            try
            {
                List<NoteResult> result = Processor.GetByIdAndCategory(accountId, category);

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Finds a note by it's accountId and text content.
        /// </summary>
        /// <param name="accountId">The note's account id. </param>
        /// <param name="content">The note's text content. </param>
        /// <returns>A note/note collection. </returns>
        /// <response code = "200" >Returns the found note/s. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired note/s does not exist. </response>
        [HttpGet("GetByIdAndContent")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByIdAndContent([FromQuery]long accountId, [FromQuery]string content)
        {
            if (accountId == 0 || content == null)
            {
                return BadRequest();
            }

            try
            {
                List<NoteResult> result = Processor.GetByIdAndContent(accountId, content);

                return Ok(result);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Finds a note by it's accountId and name.
        /// </summary>
        /// <param name="accountId">The note's account id. </param>
        /// <param name="name">The note's name. </param>
        /// <returns>A note/note collection. </returns>
        /// <response code = "200" >Returns the found note/s. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired note/s does not exist. </response>
        [HttpGet("GetByIdAndName")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByIdAndName([FromQuery]long accountId, [FromQuery]string name)
        {
            if (accountId == 0 || name == null)
            {
                return BadRequest();
            }

            try
            {
                List<NoteResult> result = Processor.GetByIdAndName(accountId, name);

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Finds a note by it's accountId and type.
        /// </summary>
        /// <param name="accountId">The note's account id. </param>
        /// <param name="type">The note's type's name. </param>
        /// <returns>A note/note collection. </returns>
        /// <response code = "200" >Returns the found note/s. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired note/s does not exist. </response>
        [HttpGet("GetByIdAndType")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByIdAndType([FromQuery]long accountId, [FromQuery]string type)
        {
            if (accountId == 0 || type == null)
            {
                return BadRequest();
            }

            try
            {
                List<NoteResult> result = Processor.GetByIdAndType(accountId, type);

                return Ok(result);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }
    }
}