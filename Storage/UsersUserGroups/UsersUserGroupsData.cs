using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.UsersUserGroups
{
    public class UsersUserGroupsData : BaseStorage<long, Data.Entity.UsersUserGroup>, IUsersUserGroupsData
    {
        public override string GetPath()
        {
            return @"Storage\UsersUserGroups\UsersUserGroupsStorage.json";
        }

        protected override long GetPK(Data.Entity.UsersUserGroup entity)
        {
            return entity.Id;
        }
    }
}
