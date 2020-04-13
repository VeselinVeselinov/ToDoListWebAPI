using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.UserGroupStatus
{
    public class UserGroupStatusDaoEF : BaseDaoEF<long, Data.Entity.UserGroupStatus>, IUserGroupStatusDao
    {
        public UserGroupStatusDaoEF(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
