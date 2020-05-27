using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using ToDoListWebAPI.Business.Convertor.Common;
using ToDoListWebAPI.Business.Processor.Common;
using Microsoft.EntityFrameworkCore;

namespace ToDoListWebAPI.Controllers.Common
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<PK, TParam, TResult, TProcessor> : ControllerBase, IBaseController<PK, TParam>
        where TParam : BaseParam
        where TResult : BaseResult
        where TProcessor : IBaseProcessor<PK, TParam, TResult>
    {
        private TProcessor _processor;

        public TProcessor Processor
        {
            get { return _processor; }
            set { _processor = value; }
        }

        public BaseController(TProcessor processor)
        {
            _processor = processor;
        }

        /// <summary>
        /// Creates a new entity in the system. 
        /// </summary>
        /// <param name="param">The param model - inputted from the request body. </param>
        /// <returns>The newly created entity. </returns>
        /// <response code = "200" >Entity has been successfully created. </response>
        /// <response code = "400" >The input data is invalid. </response>
        [HttpPost("AddItem")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody]TParam param)
        {
            if (param == null)
            {
                return BadRequest("Input data can not be empty. ");
            }

            try
            {
                TResult result = Processor.Create(param);

                return Ok(result);
            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return BadRequest("Unfortunately something went terribly wrong. ");
            }
        }

        /// <summary>
        /// Creates a collection of entities in the system. 
        /// </summary>
        /// <param name="param">The param model - sent from the request body. </param>
        /// <returns>The newly created entity collection. </returns>
        /// <response code = "200" >Entities have been successfully created. </response>
        /// <response code = "400" >The input data is invalid. </response>
        [HttpPost("AddItems")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateList([FromBody]List<TParam> param)
        {
            if (param == null)
            {
                return BadRequest("Input data can not be empty. ");
            }

            try
            {
                List<TResult> result = Processor.Create(param);

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest("Unfortunately something went terribly wrong. ");
            }
        }

        /// <summary>
        /// Removes an existing entity from the system. 
        /// </summary>
        /// <param name="id">The desired entity's id. </param>
        /// <returns></returns>
        /// <response code = "200" >The entity has been successfully removed from the system. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired entity does not exist. </response> 
        [HttpDelete("EraseItem/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult EraseByID(PK id)
        {
            if (id == null)
            {
                return BadRequest("Input data can not be empty. ");
            }

            try
            {
                Processor.Erase(id);

                return Ok($"Entity with id:{id} was successfully erased from the system. ");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return BadRequest("Unfortunately something went terribly wrong. ");
            }
        }

        /// <summary>
        /// Removes a collection of entities from the system. 
        /// </summary>
        /// <param name="idList">Ids of the entity collection we desire to delete. </param>
        /// <returns>Erase message. </returns>
        /// <response code = "200" >The entity collection is successfully removed. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired entity/ies does not exist. </response>
        [HttpDelete("EraseItems")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Erase([FromBody]List<PK> idList)
        {
            if (idList.Count == 0)
            {
                return BadRequest("Input data can not be empty. ");
            }

            try
            {
                Processor.Erase(idList);

                string erasedIds = "";
                idList.ForEach(id => erasedIds += (id.ToString() + ", "));
                erasedIds = erasedIds.Remove(erasedIds.Length - 2);

                return Ok($"Entities with ids: {erasedIds} were successfully erased from the system. ");
            }
            catch(KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return BadRequest("Unfortunately something went terribly wrong. ");
            }
        }

        /// <summary>
        /// Deletes an entity from the system by setting it to inactive. 
        /// </summary>
        /// <param name="id">Entity's id. </param>
        /// <returns>Delete message. </returns>
        /// <response code = "200" >Entity has been successfully set to inactive. </response>
        /// <response code = "400" >Input data is invalid. </response>
        /// <response code = "404" >Entity does not exist. </response>
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteById(PK id)
        {
            if (id == null)
            {
                return BadRequest("Input data can not be empty. ");
            }

            try
            {
                Processor.Delete(id);

                return Ok($"Entity with id:{id} has been set to inactive. ");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return BadRequest("Unfortunately something went terribly wrong. ");
            }
        }

        /// <summary>
        /// Deletes a collection of entities by setting them to inactive. 
        /// </summary>
        /// <param name="idList">Entities's id collection. </param>
        /// <returns>Delete message. </returns>
        /// <response code = "200" >The entities have been successfully set to inactive. </response>
        /// <response code = "400" >Input data is invalid. </response>
        /// <response code = "404" >Entity does not exist. </response>
        [HttpDelete("DeleteList")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Delete(List<PK> idList)
        {
            if (idList.Count == 0)
            {
                return BadRequest("Input data can not be empty. ");
            }

            try
            {
                Processor.Delete(idList);

                string deletedIds = "";
                idList.ForEach(id => deletedIds += (id.ToString() + ", "));
                deletedIds = deletedIds.Remove(deletedIds.Length - 2);

                return Ok($"Entities with ids:{deletedIds} have been set to inactive. ");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return BadRequest("Unfortunately something went terribly wrong. ");
            }
        }

        /// <summary>
        /// Finds an entity by the pair field/value.
        /// </summary>
        /// <param name="fieldName">The name of the field we are filtering by. </param>
        /// <param name="value">The field's value. </param>
        /// <returns>An entity/entity collection. </returns>
        /// <response code = "200" >Returns the found entity/ies. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired entity does not exist. </response>
        [HttpGet("FindExt")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult FindByField([FromQuery]string fieldName, [FromQuery]string value)
        {
            if (fieldName == null)
            {
                return BadRequest("Input data can not be empty. ");
            }

            try
            {
                List<TResult> result = Processor.FindByField(fieldName, value);

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest("Unfortunately something went terribly wrong. ");
            }
        }

        /// <summary>
        /// Finds an entity by its id.
        /// </summary>
        /// <param name="id">Entity's id.</param>
        /// <returns>Found entity. </returns>
        /// <response code = "200" >Successfully returned the entity. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired entity does not exist. </response>
        [HttpGet("Find/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult FindByPK(PK id)
        {
            if (id == null)
            {
                return BadRequest("Input data can not be empty. ");
            }

            try
            {
                TResult result = Processor.Find(id);

                return Ok(result);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return BadRequest("Unfortunately something went terribly wrong. ");
            }
        }

        /// <summary>
        /// Lists all of the existing entities in the system.
        /// </summary>
        /// <returns>List of the existing entities. </returns>
        /// <response code = "200" >Successfully returned all of the entities. </response>
        /// <response code = "400" >Something unfortunate has occured. </response>
        [HttpGet("ListAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[Microsoft.AspNetCore.Authorization.Authorize(Roles = "Administrator")]
        public IActionResult ListAll()
        {
            try
            {
                List<TResult> result = Processor.Find();

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest("Unfortunately something went terribly wrong. ");
            }
        }

        /// <summary>
        /// Updates an entity.
        /// </summary>
        /// <param name="id">The desired entity's id. </param>
        /// <param name="param">A param model of the entity we desire to update. </param>
        /// <returns></returns>
        /// <response code = "200" >Entity has been successfully updated. </response>
        /// <response code = "400" >Input data is invalid. </response>
        /// <response code = "404" >The desired entity does not exist. </response>
        [HttpPut("UpdateItem/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Update(PK id, [FromBody]TParam param)
        {
            if (id == null || param == null)
            {
                return BadRequest("Input cannot be empty. ");
            }

            try
            {
                Processor.Update(id, param);

                return Ok($"Entity with id: {id} has been successfully updated. ");
            }
            catch(KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return BadRequest("Unfortunately something went terribly wrong. ");
            }
        }

        /// <summary>
        /// Updates a collection of entities. 
        /// </summary>
        /// <param name="param">The entities's param model collection. </param>
        /// <returns></returns>
        /// <response code = "200" >Entities have been successfully updated. </response>
        /// <response code = "400" >The input data is invalid. </response>
        /// <response code = "404" >The desired entity does not exist. </response>
        [HttpPut("UpdateItems")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Update([FromBody]List<TParam> param)
        {
            if (param == null)
            {
                return BadRequest("Input data can not be empty. ");
            }

            try
            {
                Processor.Update(param);

                string updatedIds = "";
                param.ForEach(entity => updatedIds += (entity.Id.ToString() + ", "));
                updatedIds = updatedIds.Remove(updatedIds.Length - 2);

                return Ok($"Entities with ids: {updatedIds} were successfully updated. ");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return BadRequest("Unfortunately something went terribly wrong. ");
            }
        }
    }
}