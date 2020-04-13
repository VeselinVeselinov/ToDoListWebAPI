using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.UserGroup
{
    public class UserGroupDaoEF : BaseDaoEF<long, Data.Entity.UserGroup>, IUserGroupDao
    {
        public UserGroupDaoEF(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
