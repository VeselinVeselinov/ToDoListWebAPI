using ToDoListWebAPI.Business.Convertor.UserGroup;
using ToDoListWebAPI.Business.Processor.UserGroup;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.UserGroup
{
    public class UserGroupController : BaseController<long, UserGroupParam, UserGroupResult, IUserGroupProcessor>
    {
        public UserGroupController(IUserGroupProcessor processor) : base(processor)
        {
        }
    }
}