using ToDoListWebAPI.Business.Convertor.Notification;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.Notification
{
	public interface INotificationProcessor:IBaseProcessor<long, NotificationParam, NotificationResult>
    {
	}
}
