using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.UserGroupStatus
{
    public class UserGroupStatusData : BaseStorage<long, Data.Entity.UserGroupStatus>, IUserGroupStatusData
    {
        public override string GetPath()
        {
            return @"Storage\UserGroupStatus\UserGroupStatusStorage.json";
        }

        protected override long GetPK(Data.Entity.UserGroupStatus entity)
        {
            return entity.Id;
        }
    }
}
