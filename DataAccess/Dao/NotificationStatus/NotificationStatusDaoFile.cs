using ToDoListWebAPI.DataAccess.Dao.Common;
using ToDoListWebAPI.Storage.NotificationStatus;

namespace ToDoListWebAPI.DataAccess.Dao.NotificationStatus
{
	class NotificationStatusDaoFile : BaseDaoFile<long, Data.Entity.NotificationStatus, INotificationStatusData>, INotificationStatusDao
	{
		public NotificationStatusDaoFile(INotificationStatusData dataStorage) : base(dataStorage)
		{
		}

		protected override long GetPK(Data.Entity.NotificationStatus entity)
		{
			return entity.Id;
		}
	}
}
