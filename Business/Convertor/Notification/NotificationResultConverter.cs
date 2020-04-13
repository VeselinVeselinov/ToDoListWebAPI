using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.Notification
{
	class NotificationResultConverter : BaseResultConverter<Data.Entity.Notification, NotificationResult>
		, INotificationResultConverter
    {
		public override void ConvertSpecific(Data.Entity.Notification entity, NotificationResult result)
		{
			result.AlertId = entity.Alert.Id;
			result.AlertName = entity.Alert.Name;
			result.StatusId = entity.Status.Id;
			result.StatusName = entity.Status.Name;
		}

		public override NotificationResult GetNewResult()
		{
			return new NotificationResult();
		}
	}
}
