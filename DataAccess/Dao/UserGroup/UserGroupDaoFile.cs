using ToDoListWebAPI.Storage.UserGroup;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.UserGroup
{
    public class UserGroupDaoFile : BaseDaoFile<long, Data.Entity.UserGroup, IUserGroupData>, IUserGroupDao
    {
        public UserGroupDaoFile(IUserGroupData dataStorage) : base(dataStorage)
        {
        }

        protected override long GetPK(Data.Entity.UserGroup entity)
        {
            return entity.Id;
        }
    }
}
