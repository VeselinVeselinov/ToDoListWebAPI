using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Alert
{
	class AlertDaoEF : BaseDaoEF<long, Data.Entity.Alert>, IAlertDao
	{
		public AlertDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
