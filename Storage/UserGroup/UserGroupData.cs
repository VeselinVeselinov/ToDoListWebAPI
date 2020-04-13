using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.UserGroup
{
    public class UserGroupData : BaseStorage<long, Data.Entity.UserGroup>, IUserGroupData
    {
        public override string GetPath()
        {
            return @"Storage\UserGroup\UserGroupStorage.json";
        }

        protected override long GetPK(Data.Entity.UserGroup entity)
        {
            return entity.Id;
        }
    }
}
