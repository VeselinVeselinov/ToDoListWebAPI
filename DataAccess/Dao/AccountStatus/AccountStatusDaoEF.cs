using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.AccountStatus
{
	class AccountStatusDaoEF : BaseDaoEF<long, Data.Entity.AccountStatus>, IAccountStatusDao
	{
		public AccountStatusDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
