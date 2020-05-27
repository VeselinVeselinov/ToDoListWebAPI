using ToDoListWebAPI.Business.Convertor.NotificationStatus;
using ToDoListWebAPI.Business.Processor.Common;
using ToDoListWebAPI.DataAccess.Dao.NotificationStatus;

namespace ToDoListWebAPI.Business.Processor.NotificationStatus
{
	class NotificationStatusProcessor : BaseProcessor<long, Data.Entity.NotificationStatus
		, NotificationStatusParam, NotificationStatusResult
		, INotificationStatusParamConverter, INotificationStatusResultConverter
		, INotificationStatusDao>, INotificationStatusProcessor
	{
		public NotificationStatusProcessor(INotificationStatusParamConverter paramConverter
			, INotificationStatusResultConverter resultConverter
			,INotificationStatusDao dao)
			: base(paramConverter, resultConverter, dao)
		{

		}

		protected override long GetPK(NotificationStatusParam entity)
		{
			return entity.Id;
		}

		protected override void ValidateParametersSpecific(NotificationStatusParam param, long id)
		{ }
	}
}
