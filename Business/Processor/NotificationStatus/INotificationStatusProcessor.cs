using ToDoListWebAPI.Business.Convertor.NotificationStatus;
using ToDoListWebAPI.Business.Processor.Common;

namespace ToDoListWebAPI.Business.Processor.NotificationStatus
{
	public interface INotificationStatusProcessor:IBaseProcessor<long, NotificationStatusParam, NotificationStatusResult>
    {
		
	}
}
