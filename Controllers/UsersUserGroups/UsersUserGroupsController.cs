using System.Linq;
using System.Collections.Generic;
using ToDoListWebAPI.Business.Convertor.UsersUserGroups;
using ToDoListWebAPI.Business.Processor.UsersUserGroups;
using ToDoListWebAPI.Controllers.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ToDoListWebAPI.Controllers.UsersUserGroups
{
    public class UsersUserGroupsController : BaseController<long, UsersUserGroupsParam, UsersUserGroupsResult
        , IUsersUserGroupsProcessor>
    {
        public UsersUserGroupsController(IUsersUserGroupsProcessor processor) : base(processor) { }

        /// <summary>
        /// Returns all of the authority groups that the user's currently in.
        /// </summary>
        /// <param name="id">The user's identifier that  we use to find his roles. </param>
        /// <returns>List of user's group names. </returns>
        /// <response code = "200" >User's current active roles are successfully found and returned. </response>
        /// <response code = "400" >Invalid input credentials. </response>
        [HttpGet("GetAuthorities/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetUserRoles(long id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            try
            {
                var authorities = Processor.FindByField("userid", id.ToString())
                    .Select(entity => entity.GroupName)
                    .ToArray();

                return Ok(authorities);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }
    }
}