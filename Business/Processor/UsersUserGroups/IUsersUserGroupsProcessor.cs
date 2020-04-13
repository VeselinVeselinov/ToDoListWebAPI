using ToDoListWebAPI.Business.Convertor.UsersUserGroups;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.UsersUserGroups
{
    public interface IUsersUserGroupsProcessor : IBaseProcessor<long, UsersUserGroupsParam, UsersUserGroupsResult>
    {
    }
}
