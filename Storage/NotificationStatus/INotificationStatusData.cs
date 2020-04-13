using ToDoListWebAPI.Storage.Common;

namespace ToDoListWebAPI.Storage.NotificationStatus
{
	interface INotificationStatusData:IBaseStorage<long,Data.Entity.NotificationStatus>
	{
	}
}
