using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.UserGroup
{
    public interface IUserGroupData : IBaseStorage<long, Data.Entity.UserGroup>
    {
    }
}
