using ToDoListWebAPI.DataAccess.Dao.Common;

namespace ToDoListWebAPI.DataAccess.Dao.Notification
{
	interface INotificationDao : IBaseDao<long, Data.Entity.Notification>
    {
	}
}
