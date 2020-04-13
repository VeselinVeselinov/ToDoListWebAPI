using ToDoListWebAPI.Business.Convertor.Common;

namespace ToDoListWebAPI.Business.Convertor.NotificationStatus
{
	class NotificationStatusResultConverter : BaseResultConverter<Data.Entity.NotificationStatus ,NotificationStatusResult>
		, INotificationStatusResultConverter
    {
		public override void ConvertSpecific(Data.Entity.NotificationStatus entity, NotificationStatusResult result) { }

		public override NotificationStatusResult GetNewResult()
		{
			return new NotificationStatusResult();
		}
	}
}
