using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.Notification
{
	class NotificationData:BaseStorage<long,Data.Entity.Notification>,INotificationData
	{
		public override string GetPath()
		{
			return @"Storage\Notification\NotificationStorage.json";
		}

		protected override long GetPK(Data.Entity.Notification entity)
		{
			return entity.Id;
		}
	}
}
