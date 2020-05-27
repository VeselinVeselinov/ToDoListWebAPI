using ToDoListWebAPI.Business.Convertor.Notification;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.Notification;

namespace ToDoListWebAPI.Business.Processor.Notification
{
	class NotificationProcessor : BaseProcessor<long, Data.Entity.Notification, NotificationParam, NotificationResult
		, INotificationParamConverter, INotificationResultConverter, INotificationDao>, INotificationProcessor
	{
		public NotificationProcessor(INotificationParamConverter paramConverter, INotificationResultConverter resultConverter,
			INotificationDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(NotificationParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(NotificationParam param, long id)
		{ }
	}
}
