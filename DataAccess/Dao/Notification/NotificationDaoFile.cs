using ToDoListWebAPI.DataAccess.Dao.Common;
using ToDoListWebAPI.Storage.Notification;

namespace ToDoListWebAPI.DataAccess.Dao.Notification
{
	class NotificationDaoFile : BaseDaoFile<long, Data.Entity.Notification, INotificationData>, INotificationDao
	{
		public NotificationDaoFile(INotificationData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.Notification entity)
		{
			return entity.Id;
		}
	}
}
