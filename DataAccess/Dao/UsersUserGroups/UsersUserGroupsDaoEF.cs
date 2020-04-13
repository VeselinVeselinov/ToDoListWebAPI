using ToDoListWebAPI.DataAccess.Dao.Common;
using Microsoft.EntityFrameworkCore;

namespace ToDoListWebAPI.DataAccess.Dao.UsersUserGroups
{
    public class UsersUserGroupsDaoEF : BaseDaoEF<long, Data.Entity.UsersUserGroup>
        , IUsersUserGroupsDao
    {
        public UsersUserGroupsDaoEF(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
