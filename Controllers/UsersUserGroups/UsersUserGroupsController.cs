using ToDoListWebAPI.Business.Convertor.UsersUserGroups;
using ToDoListWebAPI.Business.Processor.UsersUserGroups;
using ToDoListWebAPI.Controllers.Common;

namespace ToDoListWebAPI.Controllers.UsersUserGroups
{
    public class UsersUserGroupsController : BaseController<long, UsersUserGroupsParam, UsersUserGroupsResult
        , IUsersUserGroupsProcessor>
    {
        public UsersUserGroupsController(IUsersUserGroupsProcessor processor) : base(processor)
        {
        }
    }
}