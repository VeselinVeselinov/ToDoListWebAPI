using ToDoListWebAPI.DataAccess.Dao.Common;
using ToDoListWebAPI.Storage.UserGroupStatus;

namespace ToDoListWebAPI.DataAccess.Dao.UserGroupStatus
{
    public class UserGroupStatusDaoFile : BaseDaoFile<long, Data.Entity.UserGroupStatus, IUserGroupStatusData>
        , IUserGroupStatusDao
    {
        public UserGroupStatusDaoFile(IUserGroupStatusData dataStorage) : base(dataStorage)
        {
        }

        protected override long GetPK(Data.Entity.UserGroupStatus entity)
        {
            return entity.Id;
        }
    }
}
