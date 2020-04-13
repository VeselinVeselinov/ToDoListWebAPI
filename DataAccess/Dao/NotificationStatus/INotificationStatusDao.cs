using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.NotificationStatus
{
	interface INotificationStatusDao : IBaseDao<long, Data.Entity.NotificationStatus>
    {
	}
}
