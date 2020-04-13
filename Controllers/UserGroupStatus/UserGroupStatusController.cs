using Microsoft.AspNetCore.Mvc;
using ToDoListWebAPI.Controllers.Common;
using ToDoListWebAPI.Business.Convertor.UserGroupStatus;
using ToDoListWebAPI.Business.Processor.UserGroupStatus;

namespace ToDoListWebAPI.Controllers.UserGroupStatus
{
    public class UserGroupStatusController : BaseController<long, UserGroupStatusParam
        , UserGroupStatusResult, IUserGroupStatusProcessor>
    {
        public UserGroupStatusController(IUserGroupStatusProcessor processor) : base(processor)
        {
        }
    }
}