using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.NotificationStatus
{
	class NotificationStatusDaoEF : BaseDaoEF<long, Data.Entity.NotificationStatus>, INotificationStatusDao
	{
		public NotificationStatusDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
