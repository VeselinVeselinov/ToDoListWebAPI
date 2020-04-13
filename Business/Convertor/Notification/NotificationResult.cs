using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Notification
{
	public class NotificationResult:BaseResultNamed
    {
		public long AlertId { get; set; }

		public string AlertName { get; set; }

		public string NotificationMessage { get; set; }

		public long StatusId { get; set; }

		public string StatusName { get; set; }
	}
}
