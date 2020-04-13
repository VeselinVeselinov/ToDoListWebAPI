using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.NotificationStatus
{
	class NotificationStatusData:BaseStorage<long,Data.Entity.NotificationStatus>,INotificationStatusData
	{
		public override string GetPath()
		{
			return @"Storage\NotificationStatus\NotificationStatusStorage.json";
		}

		protected override long GetPK(Data.Entity.NotificationStatus entity)
		{
			return entity.Id;
		}
	}
}
