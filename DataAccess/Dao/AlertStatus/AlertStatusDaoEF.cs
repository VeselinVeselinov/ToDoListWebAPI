using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.AlertStatus
{
	class AlertStatusDaoEF : BaseDaoEF<long, Data.Entity.AlertStatus>, IAlertStatusDao
	{
		public AlertStatusDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
