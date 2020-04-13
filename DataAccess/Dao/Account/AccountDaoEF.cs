using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Account
{
	class AccountDaoEF : BaseDaoEF<long, Data.Entity.Account>, IAccountDao
	{
		public AccountDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
