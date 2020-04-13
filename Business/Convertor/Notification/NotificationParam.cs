using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Notification
{
	public class NotificationParam:BaseParamNamed
    {
		public long AlertId { get; set; }

		public string NotificationMessage { get; set; }

		public long StatusId { get; set; }
	}
}
