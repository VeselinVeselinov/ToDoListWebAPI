using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.UserStatus
{
	class UserStatusDaoEF : BaseDaoEF<long, Data.Entity.UserStatus>, IUserStatusDao
	{
		public UserStatusDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
