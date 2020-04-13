using ToDoListWebAPI.DataAccess.Dao.Common;
using ToDoListWebAPI.Storage.UsersUserGroups;

namespace ToDoListWebAPI.DataAccess.Dao.UsersUserGroups
{
    public class UsersUserGroupsDaoFile : BaseDaoFile<long, Data.Entity.UsersUserGroup, IUsersUserGroupsData>
        , IUsersUserGroupsDao
    {
        public UsersUserGroupsDaoFile(IUsersUserGroupsData dataStorage) : base(dataStorage)
        {
        }

        protected override long GetPK(Data.Entity.UsersUserGroup entity)
        {
            return entity.Id;
        }
    }
}
