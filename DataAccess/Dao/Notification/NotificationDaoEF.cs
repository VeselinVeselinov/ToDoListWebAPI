using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Notification
{
	class NotificationDaoEF : BaseDaoEF<long, Data.Entity.Notification>, INotificationDao
	{
		public NotificationDaoEF(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
